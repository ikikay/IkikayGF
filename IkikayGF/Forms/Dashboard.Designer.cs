namespace IkikayGF.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mSMDashboard = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTBDashboard = new MetroFramework.Controls.MetroTabControl();
            this.mTabDashboard = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.DTDashboardLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTDashboardDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTDashboardMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTDashboardFait = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mTabMouvements = new MetroFramework.Controls.MetroTabPage();
            this.mGridMouvements = new MetroFramework.Controls.MetroGrid();
            this.mTBSearchMouvement = new MetroFramework.Controls.MetroTextBox();
            this.mButtonAddMouvement = new MetroFramework.Controls.MetroTile();
            this.mTabCategories = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.mGridCategorie = new MetroFramework.Controls.MetroGrid();
            this.mTBSearchCategorie = new MetroFramework.Controls.MetroTextBox();
            this.mButtonAddCategorie = new MetroFramework.Controls.MetroTile();
            this.MouvementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouvementLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouvementModifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.MouvementSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategorieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorieLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorieModifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategorieSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mSMDashboard)).BeginInit();
            this.mTBDashboard.SuspendLayout();
            this.mTabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.mTabMouvements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridMouvements)).BeginInit();
            this.mTabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // mSMDashboard
            // 
            this.mSMDashboard.Owner = this;
            // 
            // mTBDashboard
            // 
            this.mTBDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBDashboard.Controls.Add(this.mTabDashboard);
            this.mTBDashboard.Controls.Add(this.mTabMouvements);
            this.mTBDashboard.Controls.Add(this.mTabCategories);
            this.mTBDashboard.Location = new System.Drawing.Point(25, 25);
            this.mTBDashboard.Name = "mTBDashboard";
            this.mTBDashboard.SelectedIndex = 0;
            this.mTBDashboard.Size = new System.Drawing.Size(974, 718);
            this.mTBDashboard.TabIndex = 0;
            this.mTBDashboard.UseSelectable = true;
            // 
            // mTabDashboard
            // 
            this.mTabDashboard.Controls.Add(this.metroGrid1);
            this.mTabDashboard.Controls.Add(this.chart2);
            this.mTabDashboard.Controls.Add(this.chart1);
            this.mTabDashboard.HorizontalScrollbarBarColor = true;
            this.mTabDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabDashboard.HorizontalScrollbarSize = 10;
            this.mTabDashboard.Location = new System.Drawing.Point(4, 38);
            this.mTabDashboard.Name = "mTabDashboard";
            this.mTabDashboard.Size = new System.Drawing.Size(966, 676);
            this.mTabDashboard.TabIndex = 0;
            this.mTabDashboard.Text = "Dashboard";
            this.mTabDashboard.VerticalScrollbarBarColor = true;
            this.mTabDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.mTabDashboard.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTDashboardLibelle,
            this.DTDashboardDate,
            this.DTDashboardMontant,
            this.DTDashboardFait});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(495, 5);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(465, 666);
            this.metroGrid1.TabIndex = 4;
            // 
            // DTDashboardLibelle
            // 
            this.DTDashboardLibelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTDashboardLibelle.HeaderText = "Libelle";
            this.DTDashboardLibelle.Name = "DTDashboardLibelle";
            // 
            // DTDashboardDate
            // 
            this.DTDashboardDate.HeaderText = "Date";
            this.DTDashboardDate.Name = "DTDashboardDate";
            // 
            // DTDashboardMontant
            // 
            this.DTDashboardMontant.HeaderText = "Montant";
            this.DTDashboardMontant.Name = "DTDashboardMontant";
            // 
            // DTDashboardFait
            // 
            this.DTDashboardFait.HeaderText = "Fait";
            this.DTDashboardFait.Name = "DTDashboardFait";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(5, 5);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 6;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(465, 320);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(5, 350);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 6;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(465, 320);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // mTabMouvements
            // 
            this.mTabMouvements.Controls.Add(this.mGridMouvements);
            this.mTabMouvements.Controls.Add(this.mTBSearchMouvement);
            this.mTabMouvements.Controls.Add(this.mButtonAddMouvement);
            this.mTabMouvements.HorizontalScrollbarBarColor = true;
            this.mTabMouvements.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabMouvements.HorizontalScrollbarSize = 10;
            this.mTabMouvements.Location = new System.Drawing.Point(4, 38);
            this.mTabMouvements.Name = "mTabMouvements";
            this.mTabMouvements.Size = new System.Drawing.Size(966, 676);
            this.mTabMouvements.TabIndex = 1;
            this.mTabMouvements.Text = "Les mouvements";
            this.mTabMouvements.VerticalScrollbarBarColor = true;
            this.mTabMouvements.VerticalScrollbarHighlightOnWheel = false;
            this.mTabMouvements.VerticalScrollbarSize = 10;
            // 
            // mGridMouvements
            // 
            this.mGridMouvements.AllowUserToAddRows = false;
            this.mGridMouvements.AllowUserToDeleteRows = false;
            this.mGridMouvements.AllowUserToResizeRows = false;
            this.mGridMouvements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridMouvements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridMouvements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridMouvements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridMouvements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridMouvements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.mGridMouvements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridMouvements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MouvementId,
            this.MouvementLibelle,
            this.MouvementModifier,
            this.MouvementSupprimer});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridMouvements.DefaultCellStyle = dataGridViewCellStyle17;
            this.mGridMouvements.EnableHeadersVisualStyles = false;
            this.mGridMouvements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridMouvements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridMouvements.Location = new System.Drawing.Point(5, 95);
            this.mGridMouvements.Name = "mGridMouvements";
            this.mGridMouvements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridMouvements.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.mGridMouvements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridMouvements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridMouvements.Size = new System.Drawing.Size(956, 576);
            this.mGridMouvements.TabIndex = 10;
            this.mGridMouvements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridMouvements_CellContentClick);
            // 
            // mTBSearchMouvement
            // 
            this.mTBSearchMouvement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBSearchMouvement.CausesValidation = false;
            // 
            // 
            // 
            this.mTBSearchMouvement.CustomButton.Image = null;
            this.mTBSearchMouvement.CustomButton.Location = new System.Drawing.Point(928, 2);
            this.mTBSearchMouvement.CustomButton.Name = "";
            this.mTBSearchMouvement.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTBSearchMouvement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBSearchMouvement.CustomButton.TabIndex = 1;
            this.mTBSearchMouvement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBSearchMouvement.CustomButton.UseSelectable = true;
            this.mTBSearchMouvement.CustomButton.Visible = false;
            this.mTBSearchMouvement.DisplayIcon = true;
            this.mTBSearchMouvement.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTBSearchMouvement.IconRight = true;
            this.mTBSearchMouvement.Lines = new string[] {
        "Rechercher . . . TODO"};
            this.mTBSearchMouvement.Location = new System.Drawing.Point(5, 5);
            this.mTBSearchMouvement.Margin = new System.Windows.Forms.Padding(5);
            this.mTBSearchMouvement.MaxLength = 32767;
            this.mTBSearchMouvement.Name = "mTBSearchMouvement";
            this.mTBSearchMouvement.PasswordChar = '\0';
            this.mTBSearchMouvement.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBSearchMouvement.SelectedText = "";
            this.mTBSearchMouvement.SelectionLength = 0;
            this.mTBSearchMouvement.SelectionStart = 0;
            this.mTBSearchMouvement.ShortcutsEnabled = true;
            this.mTBSearchMouvement.Size = new System.Drawing.Size(956, 30);
            this.mTBSearchMouvement.TabIndex = 9;
            this.mTBSearchMouvement.Text = "Rechercher . . . TODO";
            this.mTBSearchMouvement.UseSelectable = true;
            this.mTBSearchMouvement.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBSearchMouvement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mButtonAddMouvement
            // 
            this.mButtonAddMouvement.ActiveControl = null;
            this.mButtonAddMouvement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddMouvement.BackColor = System.Drawing.Color.Red;
            this.mButtonAddMouvement.Location = new System.Drawing.Point(5, 40);
            this.mButtonAddMouvement.Name = "mButtonAddMouvement";
            this.mButtonAddMouvement.Size = new System.Drawing.Size(956, 50);
            this.mButtonAddMouvement.TabIndex = 8;
            this.mButtonAddMouvement.Text = "Ajouter un mouvement";
            this.mButtonAddMouvement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddMouvement.UseSelectable = true;
            this.mButtonAddMouvement.Click += new System.EventHandler(this.mButtonAddMouvement_Click);
            // 
            // mTabCategories
            // 
            this.mTabCategories.Controls.Add(this.mGridCategorie);
            this.mTabCategories.Controls.Add(this.mTBSearchCategorie);
            this.mTabCategories.Controls.Add(this.mButtonAddCategorie);
            this.mTabCategories.HorizontalScrollbarBarColor = true;
            this.mTabCategories.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabCategories.HorizontalScrollbarSize = 10;
            this.mTabCategories.Location = new System.Drawing.Point(4, 38);
            this.mTabCategories.Name = "mTabCategories";
            this.mTabCategories.Size = new System.Drawing.Size(966, 676);
            this.mTabCategories.TabIndex = 2;
            this.mTabCategories.Text = "Les catégories";
            this.mTabCategories.VerticalScrollbarBarColor = true;
            this.mTabCategories.VerticalScrollbarHighlightOnWheel = false;
            this.mTabCategories.VerticalScrollbarSize = 10;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modifier";
            this.dataGridViewImageColumn1.Image = global::IkikayGF.Properties.Resources.tab_modifier;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Supprimer";
            this.dataGridViewImageColumn2.Image = global::IkikayGF.Properties.Resources.tab_supprimer;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 55;
            // 
            // mGridCategorie
            // 
            this.mGridCategorie.AllowUserToAddRows = false;
            this.mGridCategorie.AllowUserToDeleteRows = false;
            this.mGridCategorie.AllowUserToResizeRows = false;
            this.mGridCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridCategorie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.mGridCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategorieId,
            this.CategorieLibelle,
            this.CategorieModifier,
            this.CategorieSupprimer});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridCategorie.DefaultCellStyle = dataGridViewCellStyle21;
            this.mGridCategorie.EnableHeadersVisualStyles = false;
            this.mGridCategorie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridCategorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridCategorie.Location = new System.Drawing.Point(5, 95);
            this.mGridCategorie.Name = "mGridCategorie";
            this.mGridCategorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridCategorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.mGridCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridCategorie.Size = new System.Drawing.Size(956, 576);
            this.mGridCategorie.TabIndex = 13;
            // 
            // mTBSearchCategorie
            // 
            this.mTBSearchCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBSearchCategorie.CausesValidation = false;
            // 
            // 
            // 
            this.mTBSearchCategorie.CustomButton.Image = null;
            this.mTBSearchCategorie.CustomButton.Location = new System.Drawing.Point(928, 2);
            this.mTBSearchCategorie.CustomButton.Name = "";
            this.mTBSearchCategorie.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTBSearchCategorie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBSearchCategorie.CustomButton.TabIndex = 1;
            this.mTBSearchCategorie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBSearchCategorie.CustomButton.UseSelectable = true;
            this.mTBSearchCategorie.CustomButton.Visible = false;
            this.mTBSearchCategorie.DisplayIcon = true;
            this.mTBSearchCategorie.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTBSearchCategorie.IconRight = true;
            this.mTBSearchCategorie.Lines = new string[] {
        "Rechercher . . . TODO"};
            this.mTBSearchCategorie.Location = new System.Drawing.Point(5, 5);
            this.mTBSearchCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.mTBSearchCategorie.MaxLength = 32767;
            this.mTBSearchCategorie.Name = "mTBSearchCategorie";
            this.mTBSearchCategorie.PasswordChar = '\0';
            this.mTBSearchCategorie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBSearchCategorie.SelectedText = "";
            this.mTBSearchCategorie.SelectionLength = 0;
            this.mTBSearchCategorie.SelectionStart = 0;
            this.mTBSearchCategorie.ShortcutsEnabled = true;
            this.mTBSearchCategorie.Size = new System.Drawing.Size(956, 30);
            this.mTBSearchCategorie.TabIndex = 12;
            this.mTBSearchCategorie.Text = "Rechercher . . . TODO";
            this.mTBSearchCategorie.UseSelectable = true;
            this.mTBSearchCategorie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBSearchCategorie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mButtonAddCategorie
            // 
            this.mButtonAddCategorie.ActiveControl = null;
            this.mButtonAddCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonAddCategorie.BackColor = System.Drawing.Color.Red;
            this.mButtonAddCategorie.Location = new System.Drawing.Point(5, 40);
            this.mButtonAddCategorie.Name = "mButtonAddCategorie";
            this.mButtonAddCategorie.Size = new System.Drawing.Size(956, 50);
            this.mButtonAddCategorie.TabIndex = 11;
            this.mButtonAddCategorie.Text = "Ajouter une catégorie";
            this.mButtonAddCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAddCategorie.UseSelectable = true;
            // 
            // MouvementId
            // 
            this.MouvementId.HeaderText = "Id";
            this.MouvementId.MinimumWidth = 75;
            this.MouvementId.Name = "MouvementId";
            this.MouvementId.Visible = false;
            // 
            // MouvementLibelle
            // 
            this.MouvementLibelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.MouvementLibelle.DefaultCellStyle = dataGridViewCellStyle16;
            this.MouvementLibelle.HeaderText = "Nom du mouvement";
            this.MouvementLibelle.Name = "MouvementLibelle";
            // 
            // MouvementModifier
            // 
            this.MouvementModifier.HeaderText = "Modifier";
            this.MouvementModifier.Image = global::IkikayGF.Properties.Resources.tab_modifier;
            this.MouvementModifier.MinimumWidth = 55;
            this.MouvementModifier.Name = "MouvementModifier";
            this.MouvementModifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MouvementModifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MouvementModifier.Width = 55;
            // 
            // MouvementSupprimer
            // 
            this.MouvementSupprimer.HeaderText = "Supprimer";
            this.MouvementSupprimer.Image = global::IkikayGF.Properties.Resources.tab_supprimer;
            this.MouvementSupprimer.MinimumWidth = 60;
            this.MouvementSupprimer.Name = "MouvementSupprimer";
            this.MouvementSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MouvementSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MouvementSupprimer.Width = 60;
            // 
            // CategorieId
            // 
            this.CategorieId.HeaderText = "Id";
            this.CategorieId.MinimumWidth = 75;
            this.CategorieId.Name = "CategorieId";
            this.CategorieId.Visible = false;
            // 
            // CategorieLibelle
            // 
            this.CategorieLibelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.CategorieLibelle.DefaultCellStyle = dataGridViewCellStyle20;
            this.CategorieLibelle.HeaderText = "Nom de la catégorie";
            this.CategorieLibelle.Name = "CategorieLibelle";
            // 
            // CategorieModifier
            // 
            this.CategorieModifier.HeaderText = "Modifier";
            this.CategorieModifier.Image = global::IkikayGF.Properties.Resources.tab_modifier;
            this.CategorieModifier.MinimumWidth = 55;
            this.CategorieModifier.Name = "CategorieModifier";
            this.CategorieModifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategorieModifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategorieModifier.Width = 55;
            // 
            // CategorieSupprimer
            // 
            this.CategorieSupprimer.HeaderText = "Supprimer";
            this.CategorieSupprimer.Image = global::IkikayGF.Properties.Resources.tab_supprimer;
            this.CategorieSupprimer.MinimumWidth = 60;
            this.CategorieSupprimer.Name = "CategorieSupprimer";
            this.CategorieSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategorieSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategorieSupprimer.Width = 60;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mTBDashboard);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.mSMDashboard)).EndInit();
            this.mTBDashboard.ResumeLayout(false);
            this.mTabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.mTabMouvements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridMouvements)).EndInit();
            this.mTabCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridCategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager mSMDashboard;
        private MetroFramework.Controls.MetroTabControl mTBDashboard;
        private MetroFramework.Controls.MetroTabPage mTabDashboard;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTDashboardLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTDashboardDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTDashboardMontant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DTDashboardFait;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTabPage mTabMouvements;
        private MetroFramework.Controls.MetroGrid mGridMouvements;
        private MetroFramework.Controls.MetroTextBox mTBSearchMouvement;
        private MetroFramework.Controls.MetroTile mButtonAddMouvement;
        private MetroFramework.Controls.MetroTabPage mTabCategories;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroGrid mGridCategorie;
        private MetroFramework.Controls.MetroTextBox mTBSearchCategorie;
        private MetroFramework.Controls.MetroTile mButtonAddCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouvementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouvementLibelle;
        private System.Windows.Forms.DataGridViewImageColumn MouvementModifier;
        private System.Windows.Forms.DataGridViewImageColumn MouvementSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorieLibelle;
        private System.Windows.Forms.DataGridViewImageColumn CategorieModifier;
        private System.Windows.Forms.DataGridViewImageColumn CategorieSupprimer;
    }
}