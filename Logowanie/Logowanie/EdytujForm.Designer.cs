namespace Logowanie
{
    partial class EdytujForm
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
            label1 = new Label();
            labeledytujEmail = new Label();
            buttonEdytujNazwe = new Button();
            buttonEdytujBio = new Button();
            labelNazwa = new Label();
            labelBio = new Label();
            textBoxBio = new TextBox();
            textBoxNazwa = new TextBox();
            labelAktualneBio = new Label();
            labelAktualnaNazwa = new Label();
            buttonPowrot = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Edytuj nazwe:";
            // 
            // labeledytujEmail
            // 
            labeledytujEmail.AutoSize = true;
            labeledytujEmail.Location = new Point(381, 44);
            labeledytujEmail.Name = "labeledytujEmail";
            labeledytujEmail.Size = new Size(63, 15);
            labeledytujEmail.TabIndex = 1;
            labeledytujEmail.Text = "Edytuj Bio:";
            labeledytujEmail.Click += labeledytujEmail_Click;
            // 
            // buttonEdytujNazwe
            // 
            buttonEdytujNazwe.Location = new Point(33, 207);
            buttonEdytujNazwe.Name = "buttonEdytujNazwe";
            buttonEdytujNazwe.Size = new Size(226, 23);
            buttonEdytujNazwe.TabIndex = 2;
            buttonEdytujNazwe.Text = "Edytuj nazwe uzytkownika";
            buttonEdytujNazwe.UseVisualStyleBackColor = true;
            buttonEdytujNazwe.Click += buttonEdytujNazwe_Click;
            // 
            // buttonEdytujBio
            // 
            buttonEdytujBio.Location = new Point(381, 207);
            buttonEdytujBio.Name = "buttonEdytujBio";
            buttonEdytujBio.Size = new Size(226, 23);
            buttonEdytujBio.TabIndex = 3;
            buttonEdytujBio.Text = "Edytuj bio uzytkownika";
            buttonEdytujBio.UseVisualStyleBackColor = true;
            buttonEdytujBio.Click += buttonEdytujBio_Click;
            // 
            // labelNazwa
            // 
            labelNazwa.AutoSize = true;
            labelNazwa.Location = new Point(33, 74);
            labelNazwa.Name = "labelNazwa";
            labelNazwa.Size = new Size(90, 15);
            labelNazwa.TabIndex = 4;
            labelNazwa.Text = "Aktualna nazwa";
            // 
            // labelBio
            // 
            labelBio.AutoSize = true;
            labelBio.Location = new Point(381, 74);
            labelBio.Name = "labelBio";
            labelBio.Size = new Size(74, 15);
            labelBio.TabIndex = 5;
            labelBio.Text = "Aktualna bio";
            // 
            // textBoxBio
            // 
            textBoxBio.Location = new Point(463, 36);
            textBoxBio.Name = "textBoxBio";
            textBoxBio.Size = new Size(169, 23);
            textBoxBio.TabIndex = 6;
            // 
            // textBoxNazwa
            // 
            textBoxNazwa.Location = new Point(118, 36);
            textBoxNazwa.Name = "textBoxNazwa";
            textBoxNazwa.Size = new Size(169, 23);
            textBoxNazwa.TabIndex = 7;
            // 
            // labelAktualneBio
            // 
            labelAktualneBio.AutoSize = true;
            labelAktualneBio.Location = new Point(463, 74);
            labelAktualneBio.Name = "labelAktualneBio";
            labelAktualneBio.Size = new Size(30, 15);
            labelAktualneBio.TabIndex = 8;
            labelAktualneBio.Text = "brak";
            // 
            // labelAktualnaNazwa
            // 
            labelAktualnaNazwa.AutoSize = true;
            labelAktualnaNazwa.Location = new Point(129, 74);
            labelAktualnaNazwa.Name = "labelAktualnaNazwa";
            labelAktualnaNazwa.Size = new Size(30, 15);
            labelAktualnaNazwa.TabIndex = 9;
            labelAktualnaNazwa.Text = "brak";
            // 
            // buttonPowrot
            // 
            buttonPowrot.Location = new Point(557, 391);
            buttonPowrot.Name = "buttonPowrot";
            buttonPowrot.Size = new Size(120, 23);
            buttonPowrot.TabIndex = 10;
            buttonPowrot.Text = "Wroc do profilu";
            buttonPowrot.UseVisualStyleBackColor = true;
            buttonPowrot.Click += buttonPowrot_Click;
            // 
            // EdytujForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPowrot);
            Controls.Add(labelAktualnaNazwa);
            Controls.Add(labelAktualneBio);
            Controls.Add(textBoxNazwa);
            Controls.Add(textBoxBio);
            Controls.Add(labelBio);
            Controls.Add(labelNazwa);
            Controls.Add(buttonEdytujBio);
            Controls.Add(buttonEdytujNazwe);
            Controls.Add(labeledytujEmail);
            Controls.Add(label1);
            Name = "EdytujForm";
            Text = "Edytuj profil";
            Load += EdytujForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labeledytujEmail;
        private Button buttonEdytujNazwe;
        private Button buttonEdytujBio;
        private Label labelNazwa;
        private Label labelBio;
        private TextBox textBoxBio;
        private TextBox textBoxNazwa;
        private Label labelAktualneBio;
        private Label labelAktualnaNazwa;
        private Button buttonPowrot;
    }
}