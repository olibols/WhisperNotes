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

        private async void ProcessRecordedAudio()
        {
            try
            {
                var whisperHandler = new WhisperHandler();
                string audioFilePath = @"C:\Users\Feathers\Desktop\untitled.mp3";
                //button1.Enabled = false;
                this.Text = "Processing audio file...";

                // Process the audio file and get the results
                var results = await whisperHandler.ProcessAudioFileAsync(audioFilePath);

                //button1.Text = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //button1.Enabled = true;
            }
        }
    }
}
