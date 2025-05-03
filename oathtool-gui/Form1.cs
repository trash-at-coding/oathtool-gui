using OtpNet;
using System.Reflection.Metadata;

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
        }

        private void whatToDo_Click(object sender, EventArgs e)
        {
        }

        private void outputCode_Click(object sender, EventArgs e)
        {
        }

        private void inputCode_TextChanged(object sender, EventArgs e)
        {
        }
        private void decodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string base32Key = inputCode.Text.Trim();

                if (string.IsNullOrEmpty(base32Key))
                {
                    outputCode.ForeColor = Color.Red;
                    outputCode.Text = "I'm not going to decode nothing as the code!";
                    return;
                }

                byte[] keyBytes = Base32Encoding.ToBytes(base32Key);
                var totp = new Totp(keyBytes);
                string code = totp.ComputeTotp();
                outputCode.ForeColor = Color.Black;
                outputCode.Text = $"TOTP Code: {code}";
            }
            catch (Exception ex)
            {
                outputCode.ForeColor = Color.Red;
                if (ex.Message.Contains("(Parameter 'c')"))
                {
                    string base32err = $"The secret key is invalid.";
                    outputCode.Text = $"Error: {base32err}";
                }
                else
                {
                    outputCode.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(outputCode.Text))
            {
                // Optionally just copy the digits (not the label prefix)
                string code = outputCode.Text;
                if (code.StartsWith("TOTP Code: "))
                {
                    code = code.Substring("TOTP Code: ".Length);
                }

                Clipboard.SetText(code);

                // Show reminder only the first time
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
    }
}
