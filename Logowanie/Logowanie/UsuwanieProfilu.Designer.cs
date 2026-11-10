namespace Logowanie
{
    partial class UsuwanieProfilu
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
            usunTextBox = new MaterialSkin.Controls.MaterialTextBox();
            usunProfilButton = new MaterialSkin.Controls.MaterialButton();
            wrocButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(226, 63);
            label1.Name = "label1";
            label1.Size = new Size(288, 42);
            label1.TabIndex = 14;
            label1.Text = "Usuwanie profilu";
            // 
            // usunTextBox
            // 
            usunTextBox.AnimateReadOnly = false;
            usunTextBox.BorderStyle = BorderStyle.None;
            usunTextBox.Depth = 0;
            usunTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usunTextBox.Hint = "Podaj haslo:";
            usunTextBox.LeadingIcon = null;
            usunTextBox.Location = new Point(75, 180);
            usunTextBox.MaxLength = 50;
            usunTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usunTextBox.Multiline = false;
            usunTextBox.Name = "usunTextBox";
            usunTextBox.Size = new Size(294, 50);
            usunTextBox.TabIndex = 15;
            usunTextBox.Text = "";
            usunTextBox.TrailingIcon = null;
            // 
            // usunProfilButton
            // 
            usunProfilButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usunProfilButton.BackColor = SystemColors.MenuHighlight;
            usunProfilButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            usunProfilButton.Depth = 0;
            usunProfilButton.HighEmphasis = true;
            usunProfilButton.Icon = null;
            usunProfilButton.Location = new Point(401, 194);
            usunProfilButton.Margin = new Padding(4, 6, 4, 6);
            usunProfilButton.MouseState = MaterialSkin.MouseState.HOVER;
            usunProfilButton.Name = "usunProfilButton";
            usunProfilButton.NoAccentTextColor = Color.Empty;
            usunProfilButton.Size = new Size(113, 36);
            usunProfilButton.TabIndex = 16;
            usunProfilButton.Text = "Usun profil";
            usunProfilButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            usunProfilButton.UseAccentColor = false;
            usunProfilButton.UseVisualStyleBackColor = false;
            usunProfilButton.Click += usunProfilButton_Click;
            // 
            // wrocButton
            // 
            wrocButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            wrocButton.BackColor = SystemColors.MenuHighlight;
            wrocButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            wrocButton.Depth = 0;
            wrocButton.HighEmphasis = true;
            wrocButton.Icon = null;
            wrocButton.Location = new Point(522, 194);
            wrocButton.Margin = new Padding(4, 6, 4, 6);
            wrocButton.MouseState = MaterialSkin.MouseState.HOVER;
            wrocButton.Name = "wrocButton";
            wrocButton.NoAccentTextColor = Color.Empty;
            wrocButton.Size = new Size(235, 36);
            wrocButton.TabIndex = 17;
            wrocButton.Text = "Wroc bez usuwania profilu";
            wrocButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            wrocButton.UseAccentColor = false;
            wrocButton.UseVisualStyleBackColor = false;
            wrocButton.Click += wrocButton_Click;
            // 
            // UsuwanieProfilu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wrocButton);
            Controls.Add(usunProfilButton);
            Controls.Add(usunTextBox);
            Controls.Add(label1);
            Name = "UsuwanieProfilu";
            Text = "UsuwanieProfilu";
            Load += UsuwanieProfilu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox usunTextBox;
        private MaterialSkin.Controls.MaterialButton usunProfilButton;
        private MaterialSkin.Controls.MaterialButton wrocButton;
    }
}