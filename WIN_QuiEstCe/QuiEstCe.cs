using LIB_QuiEstCe;

namespace WIN_QuiEstCe
{
    public partial class QuiEstCe : Form
    {
        private const int BTN_SIZE = 75;

        private Jeu jeu;
        public QuiEstCe()
        {
            InitializeComponent();
            jeu = new Jeu();
            InitGrille();
        }

        private void InitGrille()
        {
            List<Personnage> prsn = jeu.GetPersoList();
            int i = 0;
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    string chmain = prsn[i].Image;
                    if (prsn[i].Image != null && File.Exists(chmain))
                    {
                        pnl_Grille.Controls.Add(CreateCase(x, y, Image.FromFile(chmain)));
                    }
                    else
                    {
                        pnl_Grille.Controls.Add(CreateCase(x, y, null));
                    }
                    i++;
                }
            }
        }

        /// <summary>
        /// Méthode qui crée un bouton parfaitement configuré pour le jeu
        /// </summary>
        /// <param name="x">position</param>
        /// <param name="y">position</param>
        /// <param name="img">image</param>
        /// <returns></returns>
        private Button CreateCase(int x,int y,Image img)
        {
            Button btn = new Button();
            btn.FlatAppearance.BorderColor = SystemColors.Control;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = SystemColors.Control;
            btn.Location = new Point(BTN_SIZE*x, BTN_SIZE*y);
            btn.Name = $"btn_{x}_{y}";
            btn.Size = new Size(BTN_SIZE, BTN_SIZE);
            btn.TabIndex = 2;
            btn.Text = "";
            btn.UseVisualStyleBackColor = true;
            btn.BackgroundImage = img;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            return btn;
        }
    }
}
