namespace Logowanie
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
            labelLogin = new Label();
            labelHaslo = new Label();
            textBoxLogin = new TextBox();
            buttonLogowanie = new Button();
            textBoxHaslo = new TextBox();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(39, 56);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(70, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Podaj login:";
            // 
            // labelHaslo
            // 
            labelHaslo.AutoSize = true;
            labelHaslo.Location = new Point(39, 191);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(71, 15);
            labelHaslo.TabIndex = 1;
            labelHaslo.Text = "Podaj haslo:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(44, 108);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(100, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // buttonLogowanie
            // 
            buttonLogowanie.Location = new Point(542, 344);
            buttonLogowanie.Name = "buttonLogowanie";
            buttonLogowanie.Size = new Size(75, 23);
            buttonLogowanie.TabIndex = 3;
            buttonLogowanie.Text = "Wyslij";
            buttonLogowanie.UseVisualStyleBackColor = true;
            buttonLogowanie.Click += buttonLogowanie_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Location = new Point(44, 241);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(100, 23);
            textBoxHaslo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxHaslo);
            Controls.Add(buttonLogowanie);
            Controls.Add(textBoxLogin);
            Controls.Add(labelHaslo);
            Controls.Add(labelLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelHaslo;
        private TextBox textBoxLogin;
        private Button buttonLogowanie;
        private TextBox textBoxHaslo;
    }
}
