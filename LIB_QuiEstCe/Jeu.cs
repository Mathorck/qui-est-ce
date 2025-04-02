using System.Text.Json;

namespace LIB_QuiEstCe;
public class Jeu
{
    public const string QUESTION_FILE = "./Ressources/Questions.json";
    public const string PERSO_FILE = "./Ressources/Personnages.json";
    public const int TBL_X = 6;
    public const int TBL_Y = 4;

    private Personnage chosenOne;
    private Case[,] plateau;
    private List<Question> questions;
    private static Random rng = new Random();
    private int score = 0;


    public Jeu()
    {
        Init();
    }

    private void Init()
    {
        List<Personnage> prsn = new List<Personnage>();
        plateau = new Case[TBL_X, TBL_Y];
        prsn = InitPerso();
        InitPlateau(prsn);
        InitQuestions();
    }

    private List<Personnage> InitPerso()
    {
        List<Personnage> personnages = new List<Personnage>
        {
            new Personnage("Alain", "Ressources/Images/Alain.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Alice", "Ressources/Images/Alice.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Bob", "Ressources/Images/Bob.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Caroline", "Ressources/Images/Caroline.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Chris", "Ressources/Images/Chris.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.BarbeNu }),
            new Personnage("Denis", "Ressources/Images/Denis.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBrun, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Dora", "Ressources/Images/Dora.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Elodie", "Ressources/Images/Elodie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu}),
            new Personnage("Eric", "Ressources/Images/Eric.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Franck", "Ressources/Images/Franck.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxLong, Attribut.ClrCheveuxBlond, Attribut.BarbeBarbe, Attribut.BarbeMoustache, Attribut.ClrBarbeBlond }),
            new Personnage("Gregory", "Ressources/Images/Gregory.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBlond, Attribut.BarbeMoustache, Attribut.BarbeNu }),
            new Personnage("Hugo", "Ressources/Images/Hugo.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Ilian", "Ressources/Images/Ilian.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.Lunettes, Attribut.BarbeBarbe, Attribut.BarbeMoustache, Attribut.ClrBarbeRoux }),
            new Personnage("Jeremy", "Ressources/Images/Jeremy.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.BarbeNu }),
            new Personnage("Katia", "Ressources/Images/Katia.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBlond, Attribut.BarbeNu }),
            new Personnage("Kévin", "Ressources/Images/Kévin.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Laurent", "Ressources/Images/Laurent.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.BarbeNu }),
            new Personnage("Lisa", "Ressources/Images/Lisa.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Lou", "Ressources/Images/Lou.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBlond, Attribut.BarbeNu }),
            new Personnage("Marc", "Ressources/Images/Marc.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.BarbeBarbe, Attribut.ClrBarbeNoir }),
            new Personnage("Marie", "Ressources/Images/Marie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.BarbeNu }),
            new Personnage("Matehau", "Ressources/Images/Matehau.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Mélanie", "Ressources/Images/Mélanie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Natacha", "Ressources/Images/Natacha.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.BarbeNu }),
            new Personnage("Paul", "Ressources/Images/Paul.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Rachid", "Ressources/Images/Rachid.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeNu }),
            new Personnage("Sam", "Ressources/Images/Sam.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBrun, Attribut.BarbeMoustache, Attribut.BarbeBarbe, Attribut.ClrBarbeBrun }),
            new Personnage("Samira", "Ressources/Images/Samira.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Sophie", "Ressources/Images/Sophie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.Lunettes, Attribut.BarbeNu }),
            new Personnage("Ted", "Ressources/Images/Ted.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.BarbeNu })
        };
        return personnages;
    }


    private void InitPlateau(List<Personnage> prsn)
    {
        Shuffle(prsn);
        chosenOne = prsn[rng.Next(0,24)];
        int i = 0;
        for (int x = 0; x < plateau.GetLength(0); x++)
        {
            for (int y = 0; y < plateau.GetLength(1); y++)
            {
                plateau[x, y] = new Case(prsn[i]);
                i++;
            }
        }
    }

    private void InitQuestions()
    {
        questions = new List<Question>
        {
            new Question(Attribut.Homme, "Est-ce un homme ?", "Oui, C'est un homme", "Non, C'est une femme"),
            new Question(Attribut.Femme, "Est-ce une femme ?", "Oui, C'est une femme", "Non, C'est un homme"),
            new Question(Attribut.Lunettes, "Porte-t-il des lunettes ?", "Oui, Il porte des lunettes", "Non, Il ne porte pas de lunettes"),
            new Question(Attribut.CheveuxLong, "A-t-il les cheveux longs ?", "Oui, Il a les cheveux longs", "Non, Il n'a pas les cheveux longs"),
            new Question(Attribut.CheveuxCourt, "A-t-il les cheveux courts ?", "Oui, Il a les cheveux courts", "Non, Il n'a pas les cheveux courts"),
            new Question(Attribut.CheveuxChauve, "Est-il chauve ?", "Oui, Il est chauve", "Non, Il n'est pas chauve"),
            new Question(Attribut.CheveuxBlanc, "A-t-il les cheveux blancs ?","Oui, Il a les cheveux blancs", "Non, Il n'a pas les cheveux blancs"),
            new Question(Attribut.ClrCheveuxBrun, "A-t-il les cheveux bruns ?","Oui, Il a les cheveux bruns", "Non, Il n'a pas les cheveux bruns"),
            new Question(Attribut.ClrCheveuxBlond, "A-t-il les cheveux blonds ?", "Oui, Il a les cheveux blonds", "Non, Il n'a pas les cheveux blonds"),
            new Question(Attribut.ClrCheveuxRoux, "A-t-il les cheveux roux ?", "Oui, Il a les cheveux roux", "Non, Il n'a pas les cheveux roux"),
            new Question(Attribut.ClrCheveuxNoir, "A-t-il les cheveux noirs ?", "Oui, Il a les cheveux noirs", "Non, Il n'a pas les cheveux noirs"),
            new Question(Attribut.ClrCheveuxBlanc, "A-t-il les cheveux blancs ?", "Oui, Il a les cheveux blancs", "Non, Il n'a pas les cheveux blancs"),
            new Question(Attribut.BarbeMoustache, "A-t-il une moustache ?", "Oui, Il a une moustache", "Non, Il n'a pas de moustache"),
            new Question(Attribut.BarbeBarbe, "A-t-il une barbe ?", "Oui, Il a une barbe", "Non, Il n'a pas de barbe"),
            new Question(Attribut.BarbeNu, "Est-il rasé ou nu ?", "Oui, Il est rasé ou nu", "Non, Il n'est pas rasé ou nu"),
            new Question(Attribut.ClrBarbeBrun, "A-t-il une barbe brune ?", "Oui, Il a une barbe brune", "Non, Il n'a pas de barbe brune"),
            new Question(Attribut.ClrBarbeBlond, "A-t-il une barbe blonde ?", "Oui, Il a une barbe blonde", "Non, Il n'a pas de barbe blonde"),
            new Question(Attribut.ClrBarbeRoux, "A-t-il une barbe rousse ?", "Oui, Il a une barbe rousse", "Non, Il n'a pas de barbe rousse"),
            new Question(Attribut.ClrBarbeNoir, "A-t-il une barbe noire ?", "Oui, Il a une barbe noire", "Non, Il n'a pas de barbe noire")

        };
    }

    public List<string> GetQuestions()
    {
        List<string> qst = new List<string>();
        foreach ( Question q in questions)
        {
            qst.Add(q.QuestionTexte);
        }
        return qst;
    }
    public string AskQuestion(string Texte)
    {
        score++;
        foreach (Question q in questions)
        {
            if (q.QuestionTexte == Texte)
            {
                foreach (Attribut a in chosenOne.Attributs)
                {
                    if (a == q.Attribute)
                        return q.ReponsePositive;
                }
                return q.ReponseNegative;
            }
        }
        return "Question non trouvée";
    }

   public bool Guess(string name)
    {
        score++;
        if (name == chosenOne.Nom)
            return true;
        return false;
    }

    public List<Personnage> GetPersoList()
    {
        List<Personnage> prsn = new List<Personnage>();
        foreach (Case c in plateau)
        {
            prsn.Add(c.Personnage);
        }
        return prsn;
    }

    /// <summary>
    /// Méthode qui permet de sélectionner une case
    /// </summary>
    /// <param name="x">X</param>
    /// <param name="y">Y</param>
    /// <returns>Si la case a été sélectionnée</returns>
    public bool SelectCase(int x, int y)
    {
        if (isOutOfRange(x, y))
            return false;
        plateau[x, y].Selectionner();
        return true;
    }

    public bool IsCaseSelected(int x, int y)
    {
        if (isOutOfRange(x, y))
            throw new ArgumentOutOfRangeException("Les coordonnées sont en dehors du plateau");
        return plateau[x, y].Validee;
    }

    private bool isOutOfRange(int x, int y)
    {
        if (x >= TBL_X || y >= TBL_Y)
            return true;
        if (x < 0 || y < 0)
            return true;
        return false;
    }

    public static void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public string GetPerson(int x,int y)
    {
        if (isOutOfRange(x, y))
            return "the index was Out of Range Exception";
        return plateau[x, y].Personnage.Nom;
    }

    public string GetChosenOne() => chosenOne.Nom;

    public bool LastOne()
    {
        int nb = 0;
        foreach (Case c in plateau)
        {
            if (c.Validee)
                nb++;
        }
        return nb == 23;
    }

    public int GetScore() => score;
}

