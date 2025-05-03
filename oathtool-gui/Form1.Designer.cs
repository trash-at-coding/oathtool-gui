namespace oathtool_gui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtSecretKey = new TextBox();
            lblInstruction = new Label();
            btnDecode = new Button();
            lblOutput = new Label();
            btnCopy = new Button();
            grpMode = new GroupBox();
            rdoBase32 = new RadioButton();
            rdoHex = new RadioButton();
            grpMode.SuspendLayout();
            SuspendLayout();
            // 
            // txtSecretKey
            // 
            txtSecretKey.Location = new Point(12, 126);
            txtSecretKey.Name = "txtSecretKey";
            txtSecretKey.Size = new Size(320, 23);
            txtSecretKey.TabIndex = 0;
            txtSecretKey.TextChanged += txtSecretKey_TextChanged;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 9F);
            lblInstruction.Location = new Point(12, 18);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(175, 15);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Please input the secret key in the textbox.";
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(338, 125);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(75, 23);
            btnDecode.TabIndex = 3;
            btnDecode.Text = "Decode!";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 45);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 2;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(338, 90);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // grpMode
            // 
            grpMode.Controls.Add(rdoBase32);
            grpMode.Controls.Add(rdoHex);
            grpMode.Location = new Point(12, 70);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(200, 50);
            grpMode.TabIndex = 5;
            grpMode.TabStop = false;
            grpMode.Text = "Encoding Mode";
            // 
            // rdoBase32
            // 
            rdoBase32.AutoSize = true;
            rdoBase32.Location = new Point(6, 22);
            rdoBase32.Name = "rdoBase32";
            rdoBase32.Size = new Size(95, 19);
            rdoBase32.TabIndex = 0;
            rdoBase32.TabStop = true;
            rdoBase32.Text = "Base32 Mode";
            rdoBase32.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            rdoHex.AutoSize = true;
            rdoHex.Location = new Point(110, 22);
            rdoHex.Name = "rdoHex";
            rdoHex.Size = new Size(79, 19);
            rdoHex.TabIndex = 1;
            rdoHex.TabStop = true;
            rdoHex.Text = "Hex Mode";
            rdoHex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnDecode;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 161);
            Controls.Add(grpMode);
            Controls.Add(btnCopy);
            Controls.Add(lblOutput);
            Controls.Add(btnDecode);
            Controls.Add(lblInstruction);
            Controls.Add(txtSecretKey);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 200);
            MinimizeBox = false;
            MinimumSize = new Size(450, 200);
            Name = "Form1";
            Text = "Authenticator";
            Load += Form1_Load;
            grpMode.ResumeLayout(false);
            grpMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSecretKey;
        private Label lblInstruction;
        private Button btnDecode;
        private Label lblOutput;
        private Button btnCopy;
        private RadioButton rdoBase32;
        private RadioButton rdoHex;
        private GroupBox grpMode;
    }
}
