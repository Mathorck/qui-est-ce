namespace WIN_QuiEstCe
{
    partial class QuiEstCe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuiEstCe));
            pnl_Grille = new Panel();
            pbx_Ico = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_Ico).BeginInit();
            SuspendLayout();
            // 
            // pnl_Grille
            // 
            pnl_Grille.Location = new Point(12, 137);
            pnl_Grille.Name = "pnl_Grille";
            pnl_Grille.Size = new Size(776, 311);
            pnl_Grille.TabIndex = 0;
            // 
            // pbx_Ico
            // 
            pbx_Ico.Image = (Image)resources.GetObject("pbx_Ico.Image");
            pbx_Ico.Location = new Point(12, -62);
            pbx_Ico.Name = "pbx_Ico";
            pbx_Ico.Size = new Size(253, 282);
            pbx_Ico.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_Ico.TabIndex = 1;
            pbx_Ico.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(359, 51);
            button1.Name = "button1";
            button1.Size = new Size(84, 63);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // QuiEstCe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(800, 560);
            Controls.Add(button1);
            Controls.Add(pnl_Grille);
            Controls.Add(pbx_Ico);
            Name = "QuiEstCe";
            Text = "Qui Est-ce ?";
            ((System.ComponentModel.ISupportInitialize)pbx_Ico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Grille;
        private PictureBox pbx_Ico;
        private Button button1;
    }
}
