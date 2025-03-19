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
            btnQuestion = new Button();
            lbx_Question = new ListBox();
            lblResponse = new Label();
            btnFinal = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_Ico).BeginInit();
            SuspendLayout();
            // 
            // pnl_Grille
            // 
            pnl_Grille.Location = new Point(12, 137);
            pnl_Grille.Name = "pnl_Grille";
            pnl_Grille.Size = new Size(550, 367);
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
            // btnQuestion
            // 
            btnQuestion.FlatAppearance.BorderColor = SystemColors.Control;
            btnQuestion.FlatStyle = FlatStyle.Flat;
            btnQuestion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestion.ForeColor = SystemColors.Control;
            btnQuestion.Location = new Point(568, 501);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(293, 47);
            btnQuestion.TabIndex = 2;
            btnQuestion.Text = "Poser Question";
            btnQuestion.UseVisualStyleBackColor = true;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // lbx_Question
            // 
            lbx_Question.BackColor = Color.FromArgb(30, 30, 40);
            lbx_Question.Font = new Font("Segoe UI", 13F);
            lbx_Question.ForeColor = SystemColors.Control;
            lbx_Question.FormattingEnabled = true;
            lbx_Question.Location = new Point(568, 137);
            lbx_Question.Name = "lbx_Question";
            lbx_Question.Size = new Size(293, 349);
            lbx_Question.TabIndex = 3;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Font = new Font("Segoe UI", 13F);
            lblResponse.ForeColor = SystemColors.Control;
            lblResponse.Location = new Point(283, 100);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 25);
            lblResponse.TabIndex = 4;
            // 
            // btnFinal
            // 
            btnFinal.FlatAppearance.BorderColor = SystemColors.Control;
            btnFinal.FlatStyle = FlatStyle.Flat;
            btnFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinal.ForeColor = SystemColors.Control;
            btnFinal.Location = new Point(12, 501);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(550, 47);
            btnFinal.TabIndex = 5;
            btnFinal.Text = "Est ce que c'est ";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // QuiEstCe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(873, 560);
            Controls.Add(btnFinal);
            Controls.Add(lblResponse);
            Controls.Add(lbx_Question);
            Controls.Add(btnQuestion);
            Controls.Add(pnl_Grille);
            Controls.Add(pbx_Ico);
            Name = "QuiEstCe";
            Text = "Qui Est-ce ?";
            FormClosing += QuiEstCe_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbx_Ico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Grille;
        private PictureBox pbx_Ico;
        private Button btnQuestion;
        private ListBox lbx_Question;
        private Label lblResponse;
        private Button btnFinal;
    }
}
