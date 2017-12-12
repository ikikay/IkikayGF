using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using perso
using IkikayGF.Properties;  // Personnalisation des couleurs
using IkikayGF.Dao;
using MetroFramework;


namespace IkikayGF.Forms
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();

            this.StyleManager = mSMDashboard;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;

            refreshGrid();
        }

        // --------------------------------------------------------------------
        // Boutons et Cliques :
        // --------------------------------------------------------------------
        //// * * * MOUVEMENT * * *
        private void mButtonAddMouvement_Click(object sender, EventArgs e)
        {
            AddMouvement formAddMouvement = new AddMouvement();
            formAddMouvement.Show();
            this.Close();
        }

        private void mGridMouvements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clique sur la column Modifier et Pas sur le header
            if (e.ColumnIndex == mGridMouvements.Columns["MouvementModifier"].Index && e.RowIndex >= 0)
            {
                ModifyMouvement formModifyMouvement = new ModifyMouvement(DaoMouvement.readOne(mGridMouvements.Rows[e.RowIndex].Cells[0].Value.ToString()));
                formModifyMouvement.Show();
                this.Close();
            }
            else if (e.ColumnIndex == mGridMouvements.Columns["MouvementSupprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le mouvement ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DaoMouvement.delete(mGridMouvements.Rows[e.RowIndex].Cells[0].Value.ToString());
                    refreshGrid();
                }
                else if (result == DialogResult.No)
                {
                    // Ne rien faire
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        // * * * CATEGORIE * * *

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshGrid()
        {
            // * * * MOUVEMENT * * *
            //Chargement de la liste des mouvements
            mGridMouvements.RowTemplate.MinimumHeight = 35;
            mGridMouvements.AutoGenerateColumns = false;
            // Fait le lien entre la colonne et le noms des colonnes du DataTable pour s'auto remplir
            mGridMouvements.Columns["MouvementId"].DataPropertyName = "id"; //Attention Colonne Hide
            mGridMouvements.Columns["MouvementLibelle"].DataPropertyName = "libelle";
            mGridMouvements.DataSource = DaoMouvement.dtReadAll();

            // * * * CATEGORIE * * *
            //Chargement de la liste des catégories
            mGridCategorie.RowTemplate.MinimumHeight = 35;
            mGridCategorie.AutoGenerateColumns = false;
            // Fait le lien entre la colonne et le noms des colonnes du DataTable pour s'auto remplir
            mGridCategorie.Columns["CategorieId"].DataPropertyName = "id"; //Attention Colonne Hide
            mGridCategorie.Columns["CategorieLibelle"].DataPropertyName = "libelle";
            mGridCategorie.DataSource = DaoCategorie.dtReadAll();
        }
    }
}
