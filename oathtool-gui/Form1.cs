using OtpNet;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace oathtool_gui
{
    public partial class Form1 : Form
    {
        private bool hasShownReminder = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoBase32.Checked = true; // Default mode
        }

        private void txtSecretKey_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            lblOutput.ForeColor = Color.Black;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string input = txtSecretKey.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "Please enter a secret key.";
                return;
            }

            try
            {
                byte[] keyBytes;

                if (rdoBase32.Checked)
                {
                    keyBytes = Base32Encoding.ToBytes(input);
                }
                else if (rdoHex.Checked)
                {
                    keyBytes = DecodeHexString(input.Replace(" ", ""));
                }
                else
                {
                    lblOutput.ForeColor = Color.Red;
                    lblOutput.Text = "Please select an encoding mode.";
                    return;
                }

                var totp = new Totp(keyBytes);
                string code = totp.ComputeTotp();
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"TOTP Code: {code}";
            }
            catch (Exception ex)
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = $"Error: {ex.Message}";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string output = lblOutput.Text;

            if (!string.IsNullOrWhiteSpace(output) && output.StartsWith("TOTP Code: "))
            {
                string code = output.Substring("TOTP Code: ".Length);
                Clipboard.SetText(code);

                if (!hasShownReminder)
                {
                    MessageBox.Show(
                        "Make sure to save the secret key, NOT the decoded key, in a safe place. You may need it to sign in again.",
                        "Reminder",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    hasShownReminder = true;
                }
            }
        }

        // Hex string decoder (supports A-F, a-f, 0-9, even-length only)
        private static byte[] DecodeHexString(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have an even number of characters.");

            byte[] result = new byte[hex.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return result;
        }
    }
}
