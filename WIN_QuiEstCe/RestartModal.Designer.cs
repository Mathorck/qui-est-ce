namespace WIN_QuiEstCe
{
    partial class RestartModal
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
            btnYes = new Button();
            lblTitle = new Label();
            lblScore = new Label();
            btnNo = new Button();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.FlatAppearance.BorderColor = SystemColors.Control;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = SystemColors.Control;
            btnYes.Location = new Point(12, 175);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(255, 47);
            btnYes.TabIndex = 6;
            btnYes.Text = "Oui, Je rejoue.";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(56, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(421, 54);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Voulez vous rejouer ?";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = SystemColors.Control;
            lblScore.Location = new Point(121, 106);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(69, 23);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score : ";
            // 
            // btnNo
            // 
            btnNo.DialogResult = DialogResult.No;
            btnNo.FlatAppearance.BorderColor = SystemColors.Control;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = SystemColors.Control;
            btnNo.Location = new Point(289, 175);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(255, 47);
            btnNo.TabIndex = 9;
            btnNo.Text = "Non, j'y vais.";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // RestartModal
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            CancelButton = btnNo;
            ClientSize = new Size(556, 234);
            Controls.Add(btnNo);
            Controls.Add(lblScore);
            Controls.Add(lblTitle);
            Controls.Add(btnYes);
            Name = "RestartModal";
            Text = "RestartModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Label lblTitle;
        private Label lblScore;
        private Button btnNo;
    }
}