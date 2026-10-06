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
            labelAktualnaNazwa = new Label();
            labelAktualneBio = new Label();
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
            // labelAktualnaNazwa
            // 
            labelAktualnaNazwa.AutoSize = true;
            labelAktualnaNazwa.Location = new Point(33, 74);
            labelAktualnaNazwa.Name = "labelAktualnaNazwa";
            labelAktualnaNazwa.Size = new Size(90, 15);
            labelAktualnaNazwa.TabIndex = 4;
            labelAktualnaNazwa.Text = "Aktualna nazwa";
            // 
            // labelAktualneBio
            // 
            labelAktualneBio.AutoSize = true;
            labelAktualneBio.Location = new Point(381, 74);
            labelAktualneBio.Name = "labelAktualneBio";
            labelAktualneBio.Size = new Size(74, 15);
            labelAktualneBio.TabIndex = 5;
            labelAktualneBio.Text = "Aktualna bio";
            // 
            // EdytujForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAktualneBio);
            Controls.Add(labelAktualnaNazwa);
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
        private Label labelAktualnaNazwa;
        private Label labelAktualneBio;
    }
}