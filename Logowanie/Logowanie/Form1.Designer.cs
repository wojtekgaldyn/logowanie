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
            label1 = new Label();
            label2 = new Label();
            materialButtonLogowanie = new MaterialSkin.Controls.MaterialButton();
            TextBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            TextBoxHaslo = new MaterialSkin.Controls.MaterialTextBox();
            textBoxEmailRejestracja = new MaterialSkin.Controls.MaterialTextBox();
            textBoxHasloRejestracja = new MaterialSkin.Controls.MaterialTextBox();
            textBoxNazwaRejestracja = new MaterialSkin.Controls.MaterialTextBox();
            buttonRejestracja = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 42);
            label1.TabIndex = 5;
            label1.Text = "Logowanie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(454, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 42);
            label2.TabIndex = 11;
            label2.Text = "Rejestracja";
            // 
            // materialButtonLogowanie
            // 
            materialButtonLogowanie.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonLogowanie.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonLogowanie.Depth = 0;
            materialButtonLogowanie.Font = new Font("Segoe UI", 11F);
            materialButtonLogowanie.HighEmphasis = true;
            materialButtonLogowanie.Icon = null;
            materialButtonLogowanie.Location = new Point(21, 193);
            materialButtonLogowanie.Margin = new Padding(4, 6, 4, 6);
            materialButtonLogowanie.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonLogowanie.Name = "materialButtonLogowanie";
            materialButtonLogowanie.NoAccentTextColor = Color.Empty;
            materialButtonLogowanie.Size = new Size(86, 36);
            materialButtonLogowanie.TabIndex = 14;
            materialButtonLogowanie.Text = "Zaloguj";
            materialButtonLogowanie.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonLogowanie.UseAccentColor = false;
            materialButtonLogowanie.UseVisualStyleBackColor = true;
            materialButtonLogowanie.Click += materialButtonLogowanie_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.AnimateReadOnly = false;
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.Depth = 0;
            TextBoxEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxEmail.Hint = "Podaj email:";
            TextBoxEmail.LeadingIcon = null;
            TextBoxEmail.Location = new Point(21, 78);
            TextBoxEmail.MaxLength = 50;
            TextBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxEmail.Multiline = false;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(243, 50);
            TextBoxEmail.TabIndex = 15;
            TextBoxEmail.Text = "";
            TextBoxEmail.TrailingIcon = null;
            // 
            // TextBoxHaslo
            // 
            TextBoxHaslo.AnimateReadOnly = false;
            TextBoxHaslo.BorderStyle = BorderStyle.None;
            TextBoxHaslo.Depth = 0;
            TextBoxHaslo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxHaslo.Hint = "Podaj haslo:";
            TextBoxHaslo.LeadingIcon = null;
            TextBoxHaslo.Location = new Point(21, 134);
            TextBoxHaslo.MaxLength = 50;
            TextBoxHaslo.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxHaslo.Multiline = false;
            TextBoxHaslo.Name = "TextBoxHaslo";
            TextBoxHaslo.Size = new Size(243, 50);
            TextBoxHaslo.TabIndex = 16;
            TextBoxHaslo.Text = "";
            TextBoxHaslo.TrailingIcon = null;
            // 
            // textBoxEmailRejestracja
            // 
            textBoxEmailRejestracja.AnimateReadOnly = false;
            textBoxEmailRejestracja.BorderStyle = BorderStyle.None;
            textBoxEmailRejestracja.Depth = 0;
            textBoxEmailRejestracja.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxEmailRejestracja.Hint = "Podaj email:";
            textBoxEmailRejestracja.LeadingIcon = null;
            textBoxEmailRejestracja.Location = new Point(454, 77);
            textBoxEmailRejestracja.MaxLength = 50;
            textBoxEmailRejestracja.MouseState = MaterialSkin.MouseState.OUT;
            textBoxEmailRejestracja.Multiline = false;
            textBoxEmailRejestracja.Name = "textBoxEmailRejestracja";
            textBoxEmailRejestracja.Size = new Size(243, 50);
            textBoxEmailRejestracja.TabIndex = 17;
            textBoxEmailRejestracja.Text = "";
            textBoxEmailRejestracja.TrailingIcon = null;
            // 
            // textBoxHasloRejestracja
            // 
            textBoxHasloRejestracja.AnimateReadOnly = false;
            textBoxHasloRejestracja.BorderStyle = BorderStyle.None;
            textBoxHasloRejestracja.Depth = 0;
            textBoxHasloRejestracja.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxHasloRejestracja.Hint = "Podaj haslo:";
            textBoxHasloRejestracja.LeadingIcon = null;
            textBoxHasloRejestracja.Location = new Point(454, 133);
            textBoxHasloRejestracja.MaxLength = 50;
            textBoxHasloRejestracja.MouseState = MaterialSkin.MouseState.OUT;
            textBoxHasloRejestracja.Multiline = false;
            textBoxHasloRejestracja.Name = "textBoxHasloRejestracja";
            textBoxHasloRejestracja.Size = new Size(243, 50);
            textBoxHasloRejestracja.TabIndex = 18;
            textBoxHasloRejestracja.Text = "";
            textBoxHasloRejestracja.TrailingIcon = null;
            // 
            // textBoxNazwaRejestracja
            // 
            textBoxNazwaRejestracja.AnimateReadOnly = false;
            textBoxNazwaRejestracja.BorderStyle = BorderStyle.None;
            textBoxNazwaRejestracja.Depth = 0;
            textBoxNazwaRejestracja.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNazwaRejestracja.Hint = "Podaj nazwe uzytkownika:";
            textBoxNazwaRejestracja.LeadingIcon = null;
            textBoxNazwaRejestracja.Location = new Point(454, 193);
            textBoxNazwaRejestracja.MaxLength = 50;
            textBoxNazwaRejestracja.MouseState = MaterialSkin.MouseState.OUT;
            textBoxNazwaRejestracja.Multiline = false;
            textBoxNazwaRejestracja.Name = "textBoxNazwaRejestracja";
            textBoxNazwaRejestracja.Size = new Size(243, 50);
            textBoxNazwaRejestracja.TabIndex = 19;
            textBoxNazwaRejestracja.Text = "";
            textBoxNazwaRejestracja.TrailingIcon = null;
            // 
            // buttonRejestracja
            // 
            buttonRejestracja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRejestracja.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonRejestracja.Depth = 0;
            buttonRejestracja.HighEmphasis = true;
            buttonRejestracja.Icon = null;
            buttonRejestracja.Location = new Point(454, 252);
            buttonRejestracja.Margin = new Padding(4, 6, 4, 6);
            buttonRejestracja.MouseState = MaterialSkin.MouseState.HOVER;
            buttonRejestracja.Name = "buttonRejestracja";
            buttonRejestracja.NoAccentTextColor = Color.Empty;
            buttonRejestracja.Size = new Size(225, 36);
            buttonRejestracja.TabIndex = 20;
            buttonRejestracja.Text = "Zarejestruj uzytkownika";
            buttonRejestracja.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonRejestracja.UseAccentColor = false;
            buttonRejestracja.UseVisualStyleBackColor = true;
            buttonRejestracja.Click += buttonRejestracja_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRejestracja);
            Controls.Add(textBoxNazwaRejestracja);
            Controls.Add(textBoxHasloRejestracja);
            Controls.Add(textBoxEmailRejestracja);
            Controls.Add(TextBoxHaslo);
            Controls.Add(TextBoxEmail);
            Controls.Add(materialButtonLogowanie);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button buttonLogowanie;
        private MaterialSkin.Controls.MaterialButton materialButtonLogowanie;
        private MaterialSkin.Controls.MaterialTextBox TextBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox TextBoxHaslo;
        private MaterialSkin.Controls.MaterialTextBox textBoxEmailRejestracja;
        private MaterialSkin.Controls.MaterialTextBox textBoxHasloRejestracja;
        private MaterialSkin.Controls.MaterialTextBox textBoxNazwaRejestracja;
        private MaterialSkin.Controls.MaterialButton buttonRejestracja;
    }
}
