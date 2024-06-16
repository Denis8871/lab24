using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadingEncryption
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource ctsRedoc;
        private CancellationTokenSource ctsSha;
        private CancellationTokenSource ctsLuc;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartRedoc_Click(object sender, EventArgs e)
        {
            ctsRedoc = new CancellationTokenSource();
            Task.Run(() => Encryptor.EncryptREDOC(ctsRedoc.Token, UpdateRedocTextBox), ctsRedoc.Token);
        }

        private void btnStopRedoc_Click(object sender, EventArgs e)
        {
            ctsRedoc?.Cancel();
        }

        private void btnStartSha_Click(object sender, EventArgs e)
        {
            ctsSha = new CancellationTokenSource();
            Task.Run(() => Encryptor.EncryptSHA(ctsSha.Token, UpdateShaTextBox), ctsSha.Token);
        }

        private void btnStopSha_Click(object sender, EventArgs e)
        {
            ctsSha?.Cancel();
        }

        private void btnStartLuc_Click(object sender, EventArgs e)
        {
            ctsLuc = new CancellationTokenSource();
            Task.Run(() => Encryptor.EncryptLUC(ctsLuc.Token, UpdateLucTextBox), ctsLuc.Token);
        }

        private void btnStopLuc_Click(object sender, EventArgs e)
        {
            ctsLuc?.Cancel();
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            btnStartRedoc_Click(sender, e);
            btnStartSha_Click(sender, e);
            btnStartLuc_Click(sender, e);
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            btnStopRedoc_Click(sender, e);
            btnStopSha_Click(sender, e);
            btnStopLuc_Click(sender, e);
        }

        private void UpdateRedocTextBox(string text)
        {
            if (textBoxRedoc.InvokeRequired)
            {
                textBoxRedoc.Invoke(new Action<string>(UpdateRedocTextBox), text);
            }
            else
            {
                textBoxRedoc.Text = text;
                textBoxRedoc.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void UpdateShaTextBox(string text)
        {
            if (textBoxSha.InvokeRequired)
            {
                textBoxSha.Invoke(new Action<string>(UpdateShaTextBox), text);
            }
            else
            {
                textBoxSha.Text = text;
                textBoxSha.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void UpdateLucTextBox(string text)
        {
            if (textBoxLuc.InvokeRequired)
            {
                textBoxLuc.Invoke(new Action<string>(UpdateLucTextBox), text);
            }
            else
            {
                textBoxLuc.Text = text;
                textBoxLuc.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}