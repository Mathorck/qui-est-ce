using LIB_QuiEstCe;

namespace WIN_QuiEstCe
{
    public partial class QuiEstCe : Form
    {
        private const int BTN_SIZE = 85;
        private const int BTN_MARGIN = 5;

        private List<Button> btnList;
        private Dictionary<Button, Image?> pathList;
        private Jeu jeu;
        public QuiEstCe()
        {
            InitializeComponent();
            jeu = new Jeu();
            btnFinal.Hide();
            InitGrille();
            InitQuestion();

            //debug
//#if DEBUG
//            //lblResponse.Text = jeu.GetChosenOne();
//#endif
        }

        private void InitQuestion()
        {
            lbx_Question.Items.Clear();
            foreach (string q in jeu.GetQuestions().ToArray())
            {
                lbx_Question.Items.Add(q);
            }
        }

        private void InitGrille()
        {
            List<Personnage> prsn = jeu.GetPersoList();
            btnList = new List<Button>();
            pathList = new Dictionary<Button, Image?>();
            pnl_Grille.Controls.Clear();
            int i = 0;
            for (int x = 0; x < Jeu.TBL_X; x++)
            {
                for (int y = 0; y < Jeu.TBL_Y; y++)
                {
                    string chmain = prsn[i].Image;
                    string nom = prsn[i].Nom;
                    Button btn;
                    Image? img = Image.FromFile(chmain);

                    if (prsn[i].Image != null)
                        btn = CreateCase(x, y, img, nom);
                    else
                        btn = CreateCase(x, y, null, nom);

                    pathList.Add(btn, img);
                    btnList.Add(btn);
                    pnl_Grille.Controls.Add(btn);
                    i++;
                }
            }
        }
        private void UpdateGrille()
        {
            int i = 0;
            for (int x = 0; x < Jeu.TBL_X; x++)
            {
                for (int y = 0; y < Jeu.TBL_Y; y++)
                {
                    if (jeu.IsCaseSelected(x, y))
                    {
                        btnList[i].FlatAppearance.BorderColor = Color.Red;
                        btnList[i].BackgroundImage = null;
                    }
                    else
                    {
                        btnList[i].FlatAppearance.BorderColor = Color.Green;
                        btnList[i].BackgroundImage = pathList[btnList[i]];
                    }
                    i++;
                }
            }
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;
            Button btn = (Button)sender;
            string[] coord = btn.Name.Split('_');
            int x = int.Parse(coord[1]);
            int y = int.Parse(coord[2]);
            int lastX = 0, lastY = 0;
            bool recharge = jeu.SelectCase(x, y);

            if (jeu.LastOne())
            {
                btnFinal.Show();
                for (int xx = 0; xx < Jeu.TBL_X; xx++)
                    for (int yy = 0; yy < Jeu.TBL_Y; yy++)
                    {
                        if (!jeu.IsCaseSelected(xx, yy))
                        {
                            lastX = xx;
                            lastY = yy;

                        }
                    }

                btnFinal.Text = $"Est ce que c'est {jeu.GetPerson(lastX, lastY)}";
            }
            else
                btnFinal.Hide();
            if (recharge)
                UpdateGrille();
        }


        /// <summary>
        /// Méthode qui crée un bouton parfaitement configuré pour le jeu
        /// </summary>
        /// <param name="x">position</param>
        /// <param name="y">position</param>
        /// <param name="img">image</param>
        /// <returns></returns>
        private Button CreateCase(int x, int y, Image img, string nom)
        {
            Button btn = new Button();
            btn.FlatAppearance.BorderColor = Color.Green;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.DarkGray;
            btn.Location = new Point((BTN_SIZE + BTN_MARGIN) * x, (BTN_SIZE + BTN_MARGIN) * y);
            btn.Name = $"btn_{x}_{y}";
            btn.Size = new Size(BTN_SIZE, BTN_SIZE);
            btn.TabIndex = x + y;
            btn.Text = nom;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.UseVisualStyleBackColor = true;
            btn.BackgroundImage = img;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Click += btnCase_Click;
            return btn;
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            if (lbx_Question.SelectedItem == null)
                return;
            string question = lbx_Question.SelectedItem.ToString();
            lbx_Question.Items.Remove(question);
            lblResponse.Text = jeu.AskQuestion(question);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn)
                return;
            string nom = btn.Text.Replace("Est ce que c'est ", "");
            if (jeu.Guess(nom))
            {
                lblResponse.Text = $"Bravo ! vous avez trouvé c'était {nom}.";
                RestartModal rm = new RestartModal(jeu.GetScore());
                if (rm.ShowDialog() == DialogResult.Yes)
                {
                    jeu = new Jeu();
                    btnFinal.Hide();
                    InitGrille();
                    InitQuestion();
                    lblResponse.Text = "";
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                lblResponse.Text = $"Désolé, ce n'était pas {nom}.";
            }
        }

        private void QuiEstCe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
