namespace QRCode_Generator
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
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(113, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(177, 401);
            materialButton1.Margin = new Padding(10, 15, 10, 15);
            materialButton1.MinimumSize = new Size(10, 0);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(68, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Gerar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Visible = false;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(66, 109);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(291, 50);
            materialTextBox1.TabIndex = 4;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            materialTextBox1.Click += materialTextBox1_Click;
            materialTextBox1.TextChanged += materialTextBox1_TextChanged;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.BackColor = SystemColors.ControlDark;
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = (Image)resources.GetObject("materialFloatingActionButton1.Icon");
            materialFloatingActionButton1.Location = new Point(363, 381);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(56, 56);
            materialFloatingActionButton1.TabIndex = 6;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = false;
            materialFloatingActionButton1.Visible = false;
            materialFloatingActionButton1.Click += materialFloatingActionButton1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(66, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(129, 23);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Insira seu texto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(materialLabel1);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(materialTextBox1);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
