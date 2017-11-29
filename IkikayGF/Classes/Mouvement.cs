using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkikayGF.Classes
{
    class Mouvement
    {
        // ---------------------------------------------------------------------------------------- //
        // --------------------------------------- Attributs -------------------------------------- //
        // ---------------------------------------------------------------------------------------- //
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String libelle;
        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        private Boolean credit_debit;
        public Boolean Credit_debit
        {
            get { return credit_debit; }
            set { credit_debit = value; }
        }

        private List<Transaction> lesTransactions;
        public List<Transaction> LesTransactions
        {
            get { return lesTransactions; }
            set { lesTransactions = value; }
        }



        // --------------------------------------- Méthodes --------------------------------------- //
        // ---------------------------------------------------------------------------------------- //

        // Constructeur Nouveau Avant BDD
        public Mouvement(string libelle, bool credit_debit)
        {
            this.id = 0;
            this.libelle = libelle;
            this.credit_debit = credit_debit;
            this.lesTransactions = new List<Transaction>();
        }

        // Constructeur Via BDD
        public Mouvement(int id, string libelle, bool credit_debit, List<Transaction> lesTransactions)
        {
            this.id = id;
            this.libelle = libelle;
            this.credit_debit = credit_debit;
            this.lesTransactions = lesTransactions;
        }

        // ---------------------------------------------------------------------------------------- //
        // ---------------------------------------- Public ---------------------------------------- //
        // ---------------------------------------------------------------------------------------- //


        // ---------------------------------------------------------------------------------------- //
        // ---------------------------------------- Privé ----------------------------------------- //
        // ---------------------------------------------------------------------------------------- //

    }
}
