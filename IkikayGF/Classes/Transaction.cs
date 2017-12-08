using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkikayGF.Classes
{
    public class Transaction
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

        private DateTime previsionDate;
        public DateTime PrevisionDate
        {
            get { return previsionDate; }
            set { previsionDate = value; }
        }

        private DateTime effectueDate;
        public DateTime EffectueDate
        {
            get { return effectueDate; }
            set { effectueDate = value; }
        }

        private Double previsionMontant;
        public Double PrevisionMontant
        {
            get { return previsionMontant; }
            set { previsionMontant = value; }
        }

        private Double effectueMontant;
        public Double EffectueMontant
        {
            get { return effectueMontant; }
            set { effectueMontant = value; }
        }

        private Boolean fait;
        public Boolean Fait
        {
            get { return fait; }
            set { fait = value; }
        }

        private Mouvement leMouvement;
        public Mouvement LeMouvement
        {
            get { return leMouvement; }
            set { leMouvement = value; }
        }



        // --------------------------------------- Méthodes --------------------------------------- //
        // ---------------------------------------------------------------------------------------- //

        // Constructeur Avant BDD
        public Transaction(DateTime previsionDate, DateTime effectueDate, double previsionMontant, double effectueMontant, bool fait, Mouvement leMouvement)
        {
            this.id = 0;
            this.previsionDate = previsionDate;
            this.effectueDate = effectueDate;
            this.previsionMontant = previsionMontant;
            this.effectueMontant = effectueMontant;
            this.fait = fait;
            this.leMouvement = leMouvement;
        }

        // Constructeur Via BDD
        public Transaction(int id, DateTime previsionDate, DateTime effectueDate, double previsionMontant, double effectueMontant, bool fait, Mouvement leMouvement)
        {
            this.id = id;
            this.previsionDate = previsionDate;
            this.effectueDate = effectueDate;
            this.previsionMontant = previsionMontant;
            this.effectueMontant = effectueMontant;
            this.fait = fait;
            this.leMouvement = leMouvement;
        }

        // ---------------------------------------------------------------------------------------- //
        // ---------------------------------------- Public ---------------------------------------- //
        // ---------------------------------------------------------------------------------------- //


        // ---------------------------------------------------------------------------------------- //
        // ---------------------------------------- Privé ----------------------------------------- //
        // ---------------------------------------------------------------------------------------- //
        // ---------------------------------------------------------------------------------------- //

    }
}
