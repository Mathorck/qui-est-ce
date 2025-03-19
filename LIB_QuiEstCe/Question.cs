namespace LIB_QuiEstCe
{
    public class Question
    {
        private Attribut attribute;
        private string questionTexte;
        private string reponsePositive;
        private string reponseNegative;

        public Attribut Attribute
        {
            get { return attribute; }
            private set { attribute = value; }
        }
        public string QuestionTexte
        {
            get { return questionTexte; }
            private set { questionTexte = value; }
        }
        public string ReponsePositive
        {
            get { return reponsePositive; }
            private set { reponsePositive = value; }
        }
        public string ReponseNegative
        {
            get { return reponseNegative; }
            private set { reponseNegative = value; }
        }

        public Question(Attribut attribute, string questionTexte, string reponsePositive, string reponseNegative)
        {
            this.attribute = attribute;
            this.questionTexte = questionTexte;
            this.reponsePositive = reponsePositive;
            this.reponseNegative = reponseNegative;
        }
    }
}
