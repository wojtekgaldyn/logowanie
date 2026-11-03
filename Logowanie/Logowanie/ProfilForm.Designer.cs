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
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            label1 = new Label();
            buttonWyloguj = new MaterialSkin.Controls.MaterialButton();
            buttonEdytuj = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            materialListView1.FullRowSelect = true;
            materialListView1.HeaderStyle = ColumnHeaderStyle.None;
            materialListView1.Location = new Point(37, 115);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(200, 100);
            materialListView1.TabIndex = 8;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(258, 25);
            label1.Name = "label1";
            label1.Size = new Size(184, 42);
            label1.TabIndex = 9;
            label1.Text = "Twoj profil";
            // 
            // buttonWyloguj
            // 
            buttonWyloguj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonWyloguj.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonWyloguj.Depth = 0;
            buttonWyloguj.HighEmphasis = true;
            buttonWyloguj.Icon = null;
            buttonWyloguj.Location = new Point(698, 339);
            buttonWyloguj.Margin = new Padding(4, 6, 4, 6);
            buttonWyloguj.MouseState = MaterialSkin.MouseState.HOVER;
            buttonWyloguj.Name = "buttonWyloguj";
            buttonWyloguj.NoAccentTextColor = Color.Empty;
            buttonWyloguj.Size = new Size(89, 36);
            buttonWyloguj.TabIndex = 11;
            buttonWyloguj.Text = "Wyloguj";
            buttonWyloguj.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonWyloguj.UseAccentColor = false;
            buttonWyloguj.UseVisualStyleBackColor = true;
            buttonWyloguj.Click += buttonWyloguj_Click_1;
            // 
            // buttonEdytuj
            // 
            buttonEdytuj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdytuj.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdytuj.Depth = 0;
            buttonEdytuj.HighEmphasis = true;
            buttonEdytuj.Icon = null;
            buttonEdytuj.Location = new Point(561, 339);
            buttonEdytuj.Margin = new Padding(4, 6, 4, 6);
            buttonEdytuj.MouseState = MaterialSkin.MouseState.HOVER;
            buttonEdytuj.Name = "buttonEdytuj";
            buttonEdytuj.NoAccentTextColor = Color.Empty;
            buttonEdytuj.Size = new Size(128, 36);
            buttonEdytuj.TabIndex = 12;
            buttonEdytuj.Text = "Edytuj profil";
            buttonEdytuj.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdytuj.UseAccentColor = false;
            buttonEdytuj.UseVisualStyleBackColor = true;
            buttonEdytuj.Click += buttonEdytuj_Click;
            // 
            // ProfilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdytuj);
            Controls.Add(buttonWyloguj);
            Controls.Add(label1);
            Controls.Add(materialListView1);
            Name = "ProfilForm";
            Text = "Profil";
            Load += ProfilForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton buttonWyloguj;
        private MaterialSkin.Controls.MaterialButton buttonEdytuj;
    }
}