namespace oathtool_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputCode = new TextBox();
            whatToDo = new Label();
            decodeButton = new Button();
            outputCode = new Label();
            buttonCopy = new Button();
            SuspendLayout();
            // 
            // inputCode
            // 
            inputCode.Location = new Point(12, 73);
            inputCode.Name = "inputCode";
            inputCode.Size = new Size(320, 23);
            inputCode.TabIndex = 0;
            inputCode.TextChanged += inputCode_TextChanged;
            // 
            // whatToDo
            // 
            whatToDo.AutoSize = true;
            whatToDo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whatToDo.Location = new Point(12, 18);
            whatToDo.Name = "whatToDo";
            whatToDo.Size = new Size(175, 15);
            whatToDo.TabIndex = 1;
            whatToDo.Text = "Input secret key to decode here:";
            whatToDo.Click += whatToDo_Click;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(338, 73);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(75, 23);
            decodeButton.TabIndex = 2;
            decodeButton.Text = "Decode!";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += decodeButton_Click;
            // 
            // outputCode
            // 
            outputCode.AutoSize = true;
            outputCode.Location = new Point(12, 45);
            outputCode.Name = "outputCode";
            outputCode.Size = new Size(0, 15);
            outputCode.TabIndex = 3;
            outputCode.Click += outputCode_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(338, 45);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 23);
            buttonCopy.TabIndex = 4;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 111);
            Controls.Add(buttonCopy);
            Controls.Add(outputCode);
            Controls.Add(decodeButton);
            Controls.Add(whatToDo);
            Controls.Add(inputCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 150);
            MinimizeBox = false;
            MinimumSize = new Size(450, 150);
            Name = "Form1";
            Text = "Authenticator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputCode;
        private Label whatToDo;
        private Button decodeButton;
        private Label outputCode;
        private Button buttonCopy;
    }
}
