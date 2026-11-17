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
            labelNazwa = new Label();
            labelBio = new Label();
            labelAktualneBio = new Label();
            labelAktualnaNazwa = new Label();
            textBoxNazwa = new MaterialSkin.Controls.MaterialTextBox();
            textBoxBio = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            buttonEdytujNazwe = new MaterialSkin.Controls.MaterialButton();
            buttonEdytujBio = new MaterialSkin.Controls.MaterialButton();
            butonPowrot = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // labelNazwa
            // 
            labelNazwa.AutoSize = true;
            labelNazwa.Font = new Font("Segoe UI", 17.25F);
            labelNazwa.Location = new Point(33, 103);
            labelNazwa.Name = "labelNazwa";
            labelNazwa.Size = new Size(174, 31);
            labelNazwa.TabIndex = 4;
            labelNazwa.Text = "Aktualna nazwa";
            // 
            // labelBio
            // 
            labelBio.AutoSize = true;
            labelBio.Font = new Font("Segoe UI", 17.25F);
            labelBio.Location = new Point(406, 103);
            labelBio.Name = "labelBio";
            labelBio.Size = new Size(148, 31);
            labelBio.TabIndex = 5;
            labelBio.Text = "Aktualna bio:";
            // 
            // labelAktualneBio
            // 
            labelAktualneBio.Font = new Font("Segoe UI", 17.25F);
            labelAktualneBio.Location = new Point(555, 103);
            labelAktualneBio.Name = "labelAktualneBio";
            labelAktualneBio.Size = new Size(222, 93);
            labelAktualneBio.TabIndex = 8;
            labelAktualneBio.Text = "brak";
            // 
            // labelAktualnaNazwa
            // 
            labelAktualnaNazwa.AutoSize = true;
            labelAktualnaNazwa.Font = new Font("Segoe UI", 17.25F);
            labelAktualnaNazwa.Location = new Point(213, 103);
            labelAktualnaNazwa.Name = "labelAktualnaNazwa";
            labelAktualnaNazwa.Size = new Size(59, 31);
            labelAktualnaNazwa.TabIndex = 9;
            labelAktualnaNazwa.Text = "brak";
            // 
            // textBoxNazwa
            // 
            textBoxNazwa.AnimateReadOnly = false;
            textBoxNazwa.BorderStyle = BorderStyle.None;
            textBoxNazwa.Depth = 0;
            textBoxNazwa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNazwa.Hint = "Podaj nowa nazwe:";
            textBoxNazwa.LeadingIcon = null;
            textBoxNazwa.Location = new Point(33, 214);
            textBoxNazwa.MaxLength = 50;
            textBoxNazwa.MouseState = MaterialSkin.MouseState.OUT;
            textBoxNazwa.Multiline = false;
            textBoxNazwa.Name = "textBoxNazwa";
            textBoxNazwa.Size = new Size(271, 50);
            textBoxNazwa.TabIndex = 11;
            textBoxNazwa.Text = "";
            textBoxNazwa.TrailingIcon = null;
            // 
            // textBoxBio
            // 
            textBoxBio.AnimateReadOnly = false;
            textBoxBio.BorderStyle = BorderStyle.None;
            textBoxBio.Depth = 0;
            textBoxBio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxBio.Hint = "Podaj nowe bio:";
            textBoxBio.LeadingIcon = null;
            textBoxBio.Location = new Point(406, 214);
            textBoxBio.MaxLength = 50;
            textBoxBio.MouseState = MaterialSkin.MouseState.OUT;
            textBoxBio.Multiline = false;
            textBoxBio.Name = "textBoxBio";
            textBoxBio.Size = new Size(271, 50);
            textBoxBio.TabIndex = 12;
            textBoxBio.Text = "";
            textBoxBio.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 42);
            label1.TabIndex = 13;
            label1.Text = "Edycja profilu";
            // 
            // buttonEdytujNazwe
            // 
            buttonEdytujNazwe.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdytujNazwe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdytujNazwe.Depth = 0;
            buttonEdytujNazwe.HighEmphasis = true;
            buttonEdytujNazwe.Icon = null;
            buttonEdytujNazwe.Location = new Point(33, 273);
            buttonEdytujNazwe.Margin = new Padding(4, 6, 4, 6);
            buttonEdytujNazwe.MouseState = MaterialSkin.MouseState.HOVER;
            buttonEdytujNazwe.Name = "buttonEdytujNazwe";
            buttonEdytujNazwe.NoAccentTextColor = Color.Empty;
            buttonEdytujNazwe.Size = new Size(236, 36);
            buttonEdytujNazwe.TabIndex = 14;
            buttonEdytujNazwe.Text = "Edytuj nazwe uzytkownika";
            buttonEdytujNazwe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdytujNazwe.UseAccentColor = false;
            buttonEdytujNazwe.UseVisualStyleBackColor = true;
            buttonEdytujNazwe.Click += buttonEdytujNazwe_Click;
            // 
            // buttonEdytujBio
            // 
            buttonEdytujBio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdytujBio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdytujBio.Depth = 0;
            buttonEdytujBio.HighEmphasis = true;
            buttonEdytujBio.Icon = null;
            buttonEdytujBio.Location = new Point(406, 273);
            buttonEdytujBio.Margin = new Padding(4, 6, 4, 6);
            buttonEdytujBio.MouseState = MaterialSkin.MouseState.HOVER;
            buttonEdytujBio.Name = "buttonEdytujBio";
            buttonEdytujBio.NoAccentTextColor = Color.Empty;
            buttonEdytujBio.Size = new Size(209, 36);
            buttonEdytujBio.TabIndex = 15;
            buttonEdytujBio.Text = "Edytuj bio uzytkownika";
            buttonEdytujBio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdytujBio.UseAccentColor = false;
            buttonEdytujBio.UseVisualStyleBackColor = true;
            buttonEdytujBio.Click += buttonEdytujBio_Click;
            // 
            // butonPowrot
            // 
            butonPowrot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            butonPowrot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            butonPowrot.Depth = 0;
            butonPowrot.HighEmphasis = true;
            butonPowrot.Icon = null;
            butonPowrot.Location = new Point(555, 380);
            butonPowrot.Margin = new Padding(4, 6, 4, 6);
            butonPowrot.MouseState = MaterialSkin.MouseState.HOVER;
            butonPowrot.Name = "butonPowrot";
            butonPowrot.NoAccentTextColor = Color.Empty;
            butonPowrot.Size = new Size(209, 36);
            butonPowrot.TabIndex = 16;
            butonPowrot.Text = "Wroc do profilu";
            butonPowrot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            butonPowrot.UseAccentColor = false;
            butonPowrot.UseVisualStyleBackColor = true;
            butonPowrot.Click += butonPowrot_Click;
            // 
            // EdytujForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butonPowrot);
            Controls.Add(buttonEdytujBio);
            Controls.Add(buttonEdytujNazwe);
            Controls.Add(label1);
            Controls.Add(textBoxBio);
            Controls.Add(textBoxNazwa);
            Controls.Add(labelAktualnaNazwa);
            Controls.Add(labelAktualneBio);
            Controls.Add(labelBio);
            Controls.Add(labelNazwa);
            Name = "EdytujForm";
            Text = "Edytuj profil";
            Load += EdytujForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNazwa;
        private Label labelBio;
        private Label labelAktualneBio;
        private Label labelAktualnaNazwa;
        private Button buttonPowrot;
        private MaterialSkin.Controls.MaterialTextBox textBoxNazwa;
        private MaterialSkin.Controls.MaterialTextBox textBoxBio;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton buttonEdytujNazwe;
        private MaterialSkin.Controls.MaterialButton buttonEdytujBio;
        private MaterialSkin.Controls.MaterialButton butonPowrot;
    }
}