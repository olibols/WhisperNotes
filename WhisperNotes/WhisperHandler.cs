using System;
using System.IO;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Whisper.net;

namespace WhisperNotes
{
    internal class WhisperHandler
    {
        private readonly WhisperProcessor _whisperProcessor;

        public WhisperHandler()
        {
            string modelFileName = "ggml-model-whisper-base.bin";
            if (!File.Exists(modelFileName))
            {
                throw new FileNotFoundException("Model file not found");
            }

            var whisperFactory = WhisperFactory.FromPath(modelFileName);
            _whisperProcessor = whisperFactory.CreateBuilder()
                .WithLanguage("auto")
                .Build();
        }

        public async Task<List<string>> ProcessAudioFileAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Audio file not found.");
            }

            string extension = Path.GetExtension(filePath).ToLower();
            using var fileStream = File.OpenRead(filePath);
            using var memoryStream = new MemoryStream();
            switch (extension)
            {
                case ".mp3":
                    ConvertMp3ToWav(fileStream, memoryStream);
                    break;
                case ".wav":
                    ConvertWavTo16kHz(fileStream, memoryStream);
                    break;
                default:
                    throw new NotSupportedException("Unsupported file format.");
            }

            memoryStream.Seek(0, SeekOrigin.Begin); // Reset the memory stream position to the beginning before processing
            return await ProcessStream(memoryStream);
        }

        private void ConvertMp3ToWav(Stream inputStream, Stream outputStream)
        {
            using var reader = new Mp3FileReader(inputStream);
            var resampler = new WdlResamplingSampleProvider(reader.ToSampleProvider(), 16000);
            WaveFileWriter.WriteWavFileToStream(outputStream, resampler.ToWaveProvider16());
        }

        private void ConvertWavTo16kHz(Stream inputStream, Stream outputStream)
        {
            using var reader = new WaveFileReader(inputStream);
            var resampler = new WdlResamplingSampleProvider(reader.ToSampleProvider(), 16000);
            WaveFileWriter.WriteWavFileToStream(outputStream, resampler.ToWaveProvider16());
        }

        private async Task<List<string>> ProcessStream(Stream stream)
        {
            var results = new List<string>();
            await foreach (var result in _whisperProcessor.ProcessAsync(stream))
            {
                results.Add($"{result.Start}->{result.End}: {result.Text}");
            }
            return results;
        }
    }
}
