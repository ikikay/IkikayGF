namespace IkikayGF.Forms
{
    partial class AddCategorie
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
            this.components = new System.ComponentModel.Container();
            this.mSMAddCategorie = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mSMAddMouvement = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mButtonAddCategorie = new MetroFramework.Controls.MetroTile();
            this.mLinkBack = new MetroFramework.Controls.MetroLink();
            this.mLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.mTxBCategorieLibelle = new MetroFramework.Controls.MetroTextBox();
            this.mLabelCategorieLibelle = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddMouvement)).BeginInit();
            this.SuspendLayout();
            // 
            // mSMAddCategorie
            // 
            this.mSMAddCategorie.Owner = this;
            // 
            // mSMAddMouvement
            // 
            this.mSMAddMouvement.Owner = null;
            // 
            // mButtonAddCategorie
            // 
            this.mButtonAddCategorie.ActiveControl = null;
            this.mButtonAddCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddCategorie.Location = new System.Drawing.Point(25, 125);
            this.mButtonAddCategorie.Name = "mButtonAddCategorie";
            this.mButtonAddCategorie.Size = new System.Drawing.Size(979, 50);
            this.mButtonAddCategorie.TabIndex = 39;
            this.mButtonAddCategorie.Text = "Ajouter le catégorie";
            this.mButtonAddCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddCategorie.UseSelectable = true;
            this.mButtonAddCategorie.Click += new System.EventHandler(this.mButtonAddCategorie_Click);
            // 
            // mLinkBack
            // 
            this.mLinkBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mLinkBack.Image = global::IkikayGF.Properties.Resources.appbar_arrow_left_left;
            this.mLinkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLinkBack.ImageSize = 35;
            this.mLinkBack.Location = new System.Drawing.Point(25, 35);
            this.mLinkBack.Name = "mLinkBack";
            this.mLinkBack.Size = new System.Drawing.Size(81, 23);
            this.mLinkBack.TabIndex = 38;
            this.mLinkBack.Text = "Retour";
            this.mLinkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mLinkBack.UseSelectable = true;
            this.mLinkBack.Click += new System.EventHandler(this.mLinkBack_Click);
            // 
            // mLabelTitle
            // 
            this.mLabelTitle.AutoSize = true;
            this.mLabelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelTitle.Location = new System.Drawing.Point(175, 35);
            this.mLabelTitle.Name = "mLabelTitle";
            this.mLabelTitle.Size = new System.Drawing.Size(196, 25);
            this.mLabelTitle.TabIndex = 37;
            this.mLabelTitle.Text = "Ajout d\'un mouvement :";
            this.mLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mTxBCategorieLibelle
            // 
            this.mTxBCategorieLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBCategorieLibelle.CustomButton.Image = null;
            this.mTxBCategorieLibelle.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBCategorieLibelle.CustomButton.Name = "";
            this.mTxBCategorieLibelle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBCategorieLibelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBCategorieLibelle.CustomButton.TabIndex = 1;
            this.mTxBCategorieLibelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBCategorieLibelle.CustomButton.UseSelectable = true;
            this.mTxBCategorieLibelle.CustomButton.Visible = false;
            this.mTxBCategorieLibelle.Lines = new string[0];
            this.mTxBCategorieLibelle.Location = new System.Drawing.Point(175, 75);
            this.mTxBCategorieLibelle.MaxLength = 32767;
            this.mTxBCategorieLibelle.Name = "mTxBCategorieLibelle";
            this.mTxBCategorieLibelle.PasswordChar = '\0';
            this.mTxBCategorieLibelle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBCategorieLibelle.SelectedText = "";
            this.mTxBCategorieLibelle.SelectionLength = 0;
            this.mTxBCategorieLibelle.SelectionStart = 0;
            this.mTxBCategorieLibelle.ShortcutsEnabled = true;
            this.mTxBCategorieLibelle.Size = new System.Drawing.Size(829, 25);
            this.mTxBCategorieLibelle.TabIndex = 36;
            this.mTxBCategorieLibelle.UseSelectable = true;
            this.mTxBCategorieLibelle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBCategorieLibelle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelCategorieLibelle
            // 
            this.mLabelCategorieLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelCategorieLibelle.AutoSize = true;
            this.mLabelCategorieLibelle.Location = new System.Drawing.Point(25, 75);
            this.mLabelCategorieLibelle.Name = "mLabelCategorieLibelle";
            this.mLabelCategorieLibelle.Size = new System.Drawing.Size(57, 19);
            this.mLabelCategorieLibelle.TabIndex = 35;
            this.mLabelCategorieLibelle.Text = "Libelle : ";
            // 
            // AddCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 200);
            this.Controls.Add(this.mButtonAddCategorie);
            this.Controls.Add(this.mLinkBack);
            this.Controls.Add(this.mLabelTitle);
            this.Controls.Add(this.mTxBCategorieLibelle);
            this.Controls.Add(this.mLabelCategorieLibelle);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "AddCategorie";
            this.Padding = new System.Windows.Forms.Padding(50, 60, 20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddMouvement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager mSMAddCategorie;
        private MetroFramework.Controls.MetroTile mButtonAddCategorie;
        private MetroFramework.Controls.MetroLink mLinkBack;
        private MetroFramework.Controls.MetroLabel mLabelTitle;
        private MetroFramework.Controls.MetroTextBox mTxBCategorieLibelle;
        private MetroFramework.Controls.MetroLabel mLabelCategorieLibelle;
        private MetroFramework.Components.MetroStyleManager mSMAddMouvement;
    }
}