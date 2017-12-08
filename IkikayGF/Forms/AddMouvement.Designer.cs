namespace IkikayGF.Forms
{
    partial class AddMouvement
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
            this.mSMAddMouvement = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mLinkBack = new MetroFramework.Controls.MetroLink();
            this.mLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.mTxBMouvementLibelle = new MetroFramework.Controls.MetroTextBox();
            this.mLabelMouvementLibelle = new MetroFramework.Controls.MetroLabel();
            this.mButtonAddMouvement = new MetroFramework.Controls.MetroTile();
            this.mRBDebit = new MetroFramework.Controls.MetroRadioButton();
            this.mRBCredit = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddMouvement)).BeginInit();
            this.SuspendLayout();
            // 
            // mSMAddMouvement
            // 
            this.mSMAddMouvement.Owner = this;
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
            this.mLinkBack.TabIndex = 20;
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
            this.mLabelTitle.TabIndex = 19;
            this.mLabelTitle.Text = "Ajout d\'un mouvement :";
            this.mLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mTxBMouvementLibelle
            // 
            this.mTxBMouvementLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBMouvementLibelle.CustomButton.Image = null;
            this.mTxBMouvementLibelle.CustomButton.Location = new System.Drawing.Point(805, 1);
            this.mTxBMouvementLibelle.CustomButton.Name = "";
            this.mTxBMouvementLibelle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxBMouvementLibelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBMouvementLibelle.CustomButton.TabIndex = 1;
            this.mTxBMouvementLibelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBMouvementLibelle.CustomButton.UseSelectable = true;
            this.mTxBMouvementLibelle.CustomButton.Visible = false;
            this.mTxBMouvementLibelle.Lines = new string[0];
            this.mTxBMouvementLibelle.Location = new System.Drawing.Point(175, 75);
            this.mTxBMouvementLibelle.MaxLength = 32767;
            this.mTxBMouvementLibelle.Name = "mTxBMouvementLibelle";
            this.mTxBMouvementLibelle.PasswordChar = '\0';
            this.mTxBMouvementLibelle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBMouvementLibelle.SelectedText = "";
            this.mTxBMouvementLibelle.SelectionLength = 0;
            this.mTxBMouvementLibelle.SelectionStart = 0;
            this.mTxBMouvementLibelle.ShortcutsEnabled = true;
            this.mTxBMouvementLibelle.Size = new System.Drawing.Size(829, 25);
            this.mTxBMouvementLibelle.TabIndex = 18;
            this.mTxBMouvementLibelle.UseSelectable = true;
            this.mTxBMouvementLibelle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBMouvementLibelle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelMouvementLibelle
            // 
            this.mLabelMouvementLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelMouvementLibelle.AutoSize = true;
            this.mLabelMouvementLibelle.Location = new System.Drawing.Point(25, 75);
            this.mLabelMouvementLibelle.Name = "mLabelMouvementLibelle";
            this.mLabelMouvementLibelle.Size = new System.Drawing.Size(57, 19);
            this.mLabelMouvementLibelle.TabIndex = 17;
            this.mLabelMouvementLibelle.Text = "Libelle : ";
            // 
            // mButtonAddMouvement
            // 
            this.mButtonAddMouvement.ActiveControl = null;
            this.mButtonAddMouvement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddMouvement.Location = new System.Drawing.Point(25, 160);
            this.mButtonAddMouvement.Name = "mButtonAddMouvement";
            this.mButtonAddMouvement.Size = new System.Drawing.Size(979, 50);
            this.mButtonAddMouvement.TabIndex = 32;
            this.mButtonAddMouvement.Text = "Ajouter le mouvement";
            this.mButtonAddMouvement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddMouvement.UseSelectable = true;
            this.mButtonAddMouvement.Click += new System.EventHandler(this.mButtonAddMouvement_Click);
            // 
            // mRBDebit
            // 
            this.mRBDebit.AutoSize = true;
            this.mRBDebit.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mRBDebit.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.mRBDebit.Location = new System.Drawing.Point(25, 110);
            this.mRBDebit.Name = "mRBDebit";
            this.mRBDebit.Size = new System.Drawing.Size(68, 25);
            this.mRBDebit.TabIndex = 33;
            this.mRBDebit.Text = "Débit";
            this.mRBDebit.UseSelectable = true;
            // 
            // mRBCredit
            // 
            this.mRBCredit.AutoSize = true;
            this.mRBCredit.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mRBCredit.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.mRBCredit.Location = new System.Drawing.Point(175, 110);
            this.mRBCredit.Name = "mRBCredit";
            this.mRBCredit.Size = new System.Drawing.Size(73, 25);
            this.mRBCredit.TabIndex = 34;
            this.mRBCredit.Text = "Crédit";
            this.mRBCredit.UseSelectable = true;
            // 
            // AddMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 235);
            this.Controls.Add(this.mRBCredit);
            this.Controls.Add(this.mRBDebit);
            this.Controls.Add(this.mButtonAddMouvement);
            this.Controls.Add(this.mLinkBack);
            this.Controls.Add(this.mLabelTitle);
            this.Controls.Add(this.mTxBMouvementLibelle);
            this.Controls.Add(this.mLabelMouvementLibelle);
            this.MinimumSize = new System.Drawing.Size(400, 235);
            this.Name = "AddMouvement";
            this.Padding = new System.Windows.Forms.Padding(50, 60, 20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.mSMAddMouvement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager mSMAddMouvement;
        private MetroFramework.Controls.MetroLink mLinkBack;
        private MetroFramework.Controls.MetroLabel mLabelTitle;
        private MetroFramework.Controls.MetroTextBox mTxBMouvementLibelle;
        private MetroFramework.Controls.MetroLabel mLabelMouvementLibelle;
        private MetroFramework.Controls.MetroTile mButtonAddMouvement;
        private MetroFramework.Controls.MetroRadioButton mRBCredit;
        private MetroFramework.Controls.MetroRadioButton mRBDebit;
    }
}