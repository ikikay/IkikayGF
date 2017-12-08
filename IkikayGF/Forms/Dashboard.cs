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
        // Bouttons et Cliques :
        // --------------------------------------------------------------------
        private void mButtonAddMouvement_Click(object sender, EventArgs e)
        {
            AddMouvement formAddMouvement = new AddMouvement();
            formAddMouvement.Show();
            this.Close();
        }

        // --------------------------------------------------------------------
        // Fonctions de refresh :
        // --------------------------------------------------------------------
        private void refreshGrid()
        {
            //Chargement de la liste des mouvements
            mGridMouvements.RowTemplate.MinimumHeight = 35;
            mGridMouvements.AutoGenerateColumns = false;
            // Fait le lien entre la colonne et le noms des colonnes du DataTable pour s'auto remplir
            mGridMouvements.Columns[0].DataPropertyName = "id"; //Attention Colonne Hide
            mGridMouvements.Columns[1].DataPropertyName = "libelle";
            mGridMouvements.DataSource = DaoMouvement.dtReadAll();
        }

        private void mGridMouvements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clique sur la column Modifier (Modifier) et Pas sur le header
            if (e.ColumnIndex == mGridMouvements.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                ModifyMouvement formModifyMouvement = new ModifyMouvement(DaoMouvement.readOne(mGridMouvements.Rows[e.RowIndex].Cells[0].Value.ToString()));
                formModifyMouvement.Show();
                this.Close();
            }
            else if (e.ColumnIndex == mGridMouvements.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le contrat ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

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
    }
}
