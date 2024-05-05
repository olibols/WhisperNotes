using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace WhisperNotes
{
    public partial class InputDeviceSelector : UserControl
    {
        public InputDeviceSelector()
        {
            InitializeComponent();
        }

        private void InputDeviceSelector_Load(object sender, EventArgs e)
        {
            PopulateMicrophones();
        }

        private void PopulateMicrophones()
        {
            comboBoxMicrophones.Items.Clear();
            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(n);
                comboBoxMicrophones.Items.Add(deviceInfo.ProductName);
            }
            if (comboBoxMicrophones.Items.Count > 0)
            {
                comboBoxMicrophones.SelectedIndex = 0;
            }
        }

        public int GetSelectedMicrophone()
        {
            return comboBoxMicrophones.SelectedIndex;
        }

        private string GetSelectedMicrophoneName()
        {
            return comboBoxMicrophones.SelectedItem.ToString();
        }
    }
}
