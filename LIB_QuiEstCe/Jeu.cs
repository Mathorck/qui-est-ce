using System.Text.Json;

namespace LIB_QuiEstCe;
public class Jeu
{
    public const string QUESTION_FILE = "./Ressources/Questions.json";
    public const string PERSO_FILE = "./Ressources/Personnages.json";

    private Case[,] plateau;
    private Dictionary<Attribut, string> questions;
    private static Random rng = new Random();


    public Jeu()
    {
        Init();
    }

    private void Init()
    {
        List<Personnage> prsn = new List<Personnage>();
        plateau = new Case[6, 4];
        questions = new Dictionary<Attribut, string>();
        prsn = InitPerso();
        InitPlateau(prsn);
        InitQuestions();
    }

    private List<Personnage> InitPerso()
    {
        List<Personnage> personnages = new List<Personnage>
    {
        new Personnage("Paul", "Ressources/Images/Paul.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.LunettesRectangles, Attribut.ClrYeuxMarron }),
        new Personnage("Dora", "Ressources/Images/Dora.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.LunettesRectangles, Attribut.ClrYeuxVert }),
        new Personnage("Sam", "Ressources/Images/Sam.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBrun, Attribut.BarbeMoustache, Attribut.ClrYeuxMarron }),
        new Personnage("Ted", "Ressources/Images/Ted.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxNoir }),
        new Personnage("Katia", "Ressources/Images/Katia.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBlond, Attribut.ClrYeuxBleu }),
        new Personnage("Alain", "Ressources/Images/Alain.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.LunettesRectangles, Attribut.ClrYeuxBleu }),
        new Personnage("Bob", "Ressources/Images/Bob.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.LunettesRectangles, Attribut.ClrYeuxMarron }),
        new Personnage("Sophie", "Ressources/Images/Sophie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.LunettesRondes, Attribut.ClrYeuxNoir }),
        new Personnage("Natacha", "Ressources/Images/Natacha.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.ClrYeuxVert }),
        new Personnage("Chris", "Ressources/Images/Chris.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.ClrYeuxMarron }),
        new Personnage("Denis", "Ressources/Images/Denis.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBrun, Attribut.LunettesRectangles, Attribut.ClrYeuxBleu }),
        new Personnage("Lou", "Ressources/Images/Lou.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBlond, Attribut.ClrYeuxBleu }),
        new Personnage("Eric", "Ressources/Images/Eric.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxNoir }),
        new Personnage("Alice", "Ressources/Images/Alice.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxVert }),
        new Personnage("Franck", "Ressources/Images/Franck.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxLong, Attribut.ClrCheveuxBlanc, Attribut.ClrYeuxMarron }),
        new Personnage("Gregory", "Ressources/Images/Gregory.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxBlond, Attribut.BarbeMoustache, Attribut.ClrYeuxBleu }),
        new Personnage("Hugo", "Ressources/Images/Hugo.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.LunettesRectangles, Attribut.ClrYeuxMarron }),
        new Personnage("Samira", "Ressources/Images/Samira.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxNoir, Attribut.LunettesRondes, Attribut.ClrYeuxNoir }),
        new Personnage("Ilian", "Ressources/Images/Ilian.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.LunettesRectangles, Attribut.ClrYeuxVert }),
        new Personnage("Jeremy", "Ressources/Images/Jeremy.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.ClrYeuxBleu }),
        new Personnage("Lisa", "Ressources/Images/Lisa.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxNoir, Attribut.LunettesCarree, Attribut.ClrYeuxVert }),
        new Personnage("Kévin", "Ressources/Images/Kévin.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxMarron }),
        new Personnage("Caroline", "Ressources/Images/Caroline.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.LunettesCarree, Attribut.ClrYeuxBleu }),
        new Personnage("Laurent", "Ressources/Images/Laurent.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxChauve, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.ClrYeuxNoir }),
        new Personnage("Mélanie", "Ressources/Images/Mélanie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxRoux, Attribut.LunettesRectangles, Attribut.ClrYeuxVert }),
        new Personnage("Marie", "Ressources/Images/Marie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxLong, Attribut.ClrCheveuxBrun, Attribut.ClrYeuxMarron }),
        new Personnage("Rachid", "Ressources/Images/Rachid.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxNoir }),
        new Personnage("Marc", "Ressources/Images/Marc.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.BarbeMoustache, Attribut.ClrYeuxMarron }),
        new Personnage("Elodie", "Ressources/Images/Elodie.png", new List<Attribut> { Attribut.Femme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.LunettesRondes, Attribut.ClrYeuxBleu }),
        new Personnage("Matehau", "Ressources/Images/Matehau.png", new List<Attribut> { Attribut.Homme, Attribut.CheveuxCourt, Attribut.ClrCheveuxNoir, Attribut.ClrYeuxNoir })
    };

        return personnages;
    }


    private void InitPlateau(List<Personnage> prsn)
    {
        Shuffle(prsn);
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
        if (File.Exists(QUESTION_FILE))
        {
            string jsonString = File.ReadAllText(QUESTION_FILE);
            var questionsFromJson = JsonSerializer.Deserialize<Dictionary<Attribut, string>>(jsonString);
            if (questionsFromJson != null)
            {
                questions = questionsFromJson;
            }
        }
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
}

