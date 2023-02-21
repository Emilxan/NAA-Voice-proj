using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Synthez
{
    public partial class MainForm : Form
    {
        SpeechSynthesizer sp = new SpeechSynthesizer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sp.SetOutputToDefaultAudioDevice();

            foreach(InstalledVoice voice in sp.GetInstalledVoices())
            {
                cmbBoxDictor.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStart.Text == "Start")
                {
                    sp.Dispose();
                    sp = new SpeechSynthesizer();
                    sp.Volume = trackVolume.Value;
                    sp.Rate = trackRate.Value;
                    sp.SelectVoice(cmbBoxDictor.Text);
                    sp.SpeakAsync(rTxtBox.Text);

                    btnStart.Text = "Stop";
                    btnStart.BackColor = Color.Red;
                }
                else
                {
                    sp.Dispose();

                    btnStart.Text = "Start";
                    btnStart.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPauseResume.Text == "Pause")
                {
                    sp.Pause();

                    btnPauseResume.Text = "Resume";
                }
                else
                {
                    sp.Resume();

                    btnPauseResume.Text = "Pause";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
