using System.Windows.Forms;
using NAudio.Wave;


namespace WhisperNotes
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveSource = null;
        private WaveFileWriter waveFile = null;
        private string tempFilePath = Path.Combine(Path.GetTempPath(), "tempWave.wav");


        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var whisperHandler = new WhisperHandler();
                string audioFilePath = @"C:\Users\Feathers\Desktop\untitled.mp3";
                button1.Enabled = false;
                this.Text = "Processing audio file...";

                // Process the audio file and get the results
                var results = await whisperHandler.ProcessAudioFileAsync(audioFilePath);

                button1.Text = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(16000, 1); // Set format to 16kHz mono which is suitable for Whisper

            waveSource.DataAvailable += WaveSource_DataAvailable;
            waveSource.RecordingStopped += WaveSource_RecordingStopped;

            waveFile = new WaveFileWriter(tempFilePath, waveSource.WaveFormat);

            waveSource.StartRecording();
            recordButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            waveSource.StopRecording();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            waveSource.StopRecording();
        }

        private void WaveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        private void WaveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

            recordButton.Enabled = true;
            stopButton.Enabled = false;

            ProcessRecordedAudio();
        }

        private async void ProcessRecordedAudio()
        {
            var whisperHandler = new WhisperHandler();
            try
            {
                var results = await whisperHandler.ProcessAudioFileAsync(tempFilePath);
                outputTextBox.Text = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
