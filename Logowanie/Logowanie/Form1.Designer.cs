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
            textBoxEmail = new TextBox();
            textBoxHaslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxHasloRejestracja = new TextBox();
            buttonRejestracja = new Button();
            textBoxEmailRejestracja = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxNazwaRejestracja = new TextBox();
            label5 = new Label();
            buttonLogowanie = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(39, 81);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(72, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Podaj email:";
            // 
            // labelHaslo
            // 
            labelHaslo.AutoSize = true;
            labelHaslo.Location = new Point(39, 164);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(71, 15);
            labelHaslo.TabIndex = 1;
            labelHaslo.Text = "Podaj haslo:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(39, 110);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(165, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Location = new Point(39, 194);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(165, 23);
            textBoxHaslo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 5;
            label1.Text = "Logowanie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(428, 9);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 11;
            label2.Text = "Rejestracja";
            // 
            // textBoxHasloRejestracja
            // 
            textBoxHasloRejestracja.Location = new Point(428, 194);
            textBoxHasloRejestracja.Name = "textBoxHasloRejestracja";
            textBoxHasloRejestracja.Size = new Size(165, 23);
            textBoxHasloRejestracja.TabIndex = 10;
            // 
            // buttonRejestracja
            // 
            buttonRejestracja.Location = new Point(428, 347);
            buttonRejestracja.Name = "buttonRejestracja";
            buttonRejestracja.Size = new Size(190, 23);
            buttonRejestracja.TabIndex = 9;
            buttonRejestracja.Text = "Zarejestruj uzytkownika";
            buttonRejestracja.UseVisualStyleBackColor = true;
            buttonRejestracja.Click += buttonRejestracja_Click;
            // 
            // textBoxEmailRejestracja
            // 
            textBoxEmailRejestracja.Location = new Point(428, 110);
            textBoxEmailRejestracja.Name = "textBoxEmailRejestracja";
            textBoxEmailRejestracja.Size = new Size(165, 23);
            textBoxEmailRejestracja.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Podaj haslo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 81);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Podaj email:";
            // 
            // textBoxNazwaRejestracja
            // 
            textBoxNazwaRejestracja.Location = new Point(428, 275);
            textBoxNazwaRejestracja.Name = "textBoxNazwaRejestracja";
            textBoxNazwaRejestracja.Size = new Size(165, 23);
            textBoxNazwaRejestracja.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 245);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 12;
            label5.Text = "Podaj nazwe uztkownika:";
            // 
            // buttonLogowanie
            // 
            buttonLogowanie.Location = new Point(39, 347);
            buttonLogowanie.Name = "buttonLogowanie";
            buttonLogowanie.Size = new Size(88, 23);
            buttonLogowanie.TabIndex = 3;
            buttonLogowanie.Text = "Zaloguj";
            buttonLogowanie.UseVisualStyleBackColor = true;
            buttonLogowanie.Click += buttonLogowanie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNazwaRejestracja);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxHasloRejestracja);
            Controls.Add(buttonRejestracja);
            Controls.Add(textBoxEmailRejestracja);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxHaslo);
            Controls.Add(buttonLogowanie);
            Controls.Add(textBoxEmail);
            Controls.Add(labelHaslo);
            Controls.Add(labelLogin);
            Name = "Form1";
            Text = "Logowanie";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelHaslo;
        private TextBox textBoxEmail;
        private TextBox textBoxHaslo;
        private Label label1;
        private Label label2;
        private TextBox textBoxHasloRejestracja;
        private Button buttonRejestracja;
        private TextBox textBoxEmailRejestracja;
        private Label label3;
        private Label label4;
        private TextBox textBoxNazwaRejestracja;
        private Label label5;
        private Button buttonLogowanie;
    }
}
