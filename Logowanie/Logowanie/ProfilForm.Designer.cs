namespace Logowanie
{
    partial class ProfilForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNazwaUzytkownika = new Label();
            labelEmail = new Label();
            labelBio = new Label();
            labelPobranaNazwa = new Label();
            labelPobranyEmail = new Label();
            labelPobraneBio = new Label();
            buttonEdytuj = new Button();
            SuspendLayout();
            // 
            // labelNazwaUzytkownika
            // 
            labelNazwaUzytkownika.AutoSize = true;
            labelNazwaUzytkownika.Location = new Point(35, 45);
            labelNazwaUzytkownika.Name = "labelNazwaUzytkownika";
            labelNazwaUzytkownika.Size = new Size(114, 15);
            labelNazwaUzytkownika.TabIndex = 0;
            labelNazwaUzytkownika.Text = "Nazwa uzytkownika:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(35, 105);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email:";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelBio
            // 
            labelBio.AutoSize = true;
            labelBio.Location = new Point(35, 171);
            labelBio.Name = "labelBio";
            labelBio.Size = new Size(27, 15);
            labelBio.TabIndex = 2;
            labelBio.Text = "Bio:";
            labelBio.Click += labelBio_Click;
            // 
            // labelPobranaNazwa
            // 
            labelPobranaNazwa.AutoSize = true;
            labelPobranaNazwa.Location = new Point(334, 45);
            labelPobranaNazwa.Name = "labelPobranaNazwa";
            labelPobranaNazwa.Size = new Size(42, 15);
            labelPobranaNazwa.TabIndex = 3;
            labelPobranaNazwa.Text = "Nazwa";
            // 
            // labelPobranyEmail
            // 
            labelPobranyEmail.AutoSize = true;
            labelPobranyEmail.Location = new Point(334, 105);
            labelPobranyEmail.Name = "labelPobranyEmail";
            labelPobranyEmail.Size = new Size(36, 15);
            labelPobranyEmail.TabIndex = 4;
            labelPobranyEmail.Text = "Email";
            // 
            // labelPobraneBio
            // 
            labelPobraneBio.AutoSize = true;
            labelPobraneBio.Location = new Point(334, 171);
            labelPobraneBio.Name = "labelPobraneBio";
            labelPobraneBio.Size = new Size(24, 15);
            labelPobraneBio.TabIndex = 5;
            labelPobraneBio.Text = "Bio";
            // 
            // buttonEdytuj
            // 
            buttonEdytuj.Location = new Point(295, 339);
            buttonEdytuj.Name = "buttonEdytuj";
            buttonEdytuj.Size = new Size(75, 23);
            buttonEdytuj.TabIndex = 6;
            buttonEdytuj.Text = "Edytuj";
            buttonEdytuj.UseVisualStyleBackColor = true;
            buttonEdytuj.Click += buttonEdytuj_Click;
            // 
            // ProfilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdytuj);
            Controls.Add(labelPobraneBio);
            Controls.Add(labelPobranyEmail);
            Controls.Add(labelPobranaNazwa);
            Controls.Add(labelBio);
            Controls.Add(labelEmail);
            Controls.Add(labelNazwaUzytkownika);
            Name = "ProfilForm";
            Text = "Profil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNazwaUzytkownika;
        private Label labelEmail;
        private Label labelBio;
        private Label labelPobranaNazwa;
        private Label labelPobranyEmail;
        private Label labelPobraneBio;
        private Button buttonEdytuj;
    }
}