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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.mTBSearch = new MetroFramework.Controls.MetroTextBox();
            this.mButtonAddMouvement = new MetroFramework.Controls.MetroTile();
            this.mTabCategories = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouvementLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mSMDashboard)).BeginInit();
            this.mTBDashboard.SuspendLayout();
            this.mTabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.mTabMouvements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridMouvements)).BeginInit();
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
            this.mTBDashboard.SelectedIndex = 1;
            this.mTBDashboard.Size = new System.Drawing.Size(974, 718);
            this.mTBDashboard.TabIndex = 0;
            this.mTBDashboard.UseSelectable = true;
            // 
            // mTabDashboard
            // 
            this.mTabDashboard.CausesValidation = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTDashboardLibelle,
            this.DTDashboardDate,
            this.DTDashboardMontant,
            this.DTDashboardFait});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(495, 5);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(5, 5);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(465, 320);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 350);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(465, 320);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // mTabMouvements
            // 
            this.mTabMouvements.Controls.Add(this.mGridMouvements);
            this.mTabMouvements.Controls.Add(this.mTBSearch);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridMouvements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mGridMouvements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridMouvements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MouvementLibelle,
            this.Modifier,
            this.Supprimer});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridMouvements.DefaultCellStyle = dataGridViewCellStyle6;
            this.mGridMouvements.EnableHeadersVisualStyles = false;
            this.mGridMouvements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridMouvements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridMouvements.Location = new System.Drawing.Point(5, 95);
            this.mGridMouvements.Name = "mGridMouvements";
            this.mGridMouvements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridMouvements.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mGridMouvements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridMouvements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridMouvements.Size = new System.Drawing.Size(956, 576);
            this.mGridMouvements.TabIndex = 10;
            this.mGridMouvements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridMouvements_CellContentClick);
            // 
            // mTBSearch
            // 
            this.mTBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBSearch.CausesValidation = false;
            // 
            // 
            // 
            this.mTBSearch.CustomButton.Image = null;
            this.mTBSearch.CustomButton.Location = new System.Drawing.Point(928, 2);
            this.mTBSearch.CustomButton.Name = "";
            this.mTBSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTBSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBSearch.CustomButton.TabIndex = 1;
            this.mTBSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBSearch.CustomButton.UseSelectable = true;
            this.mTBSearch.CustomButton.Visible = false;
            this.mTBSearch.DisplayIcon = true;
            this.mTBSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTBSearch.IconRight = true;
            this.mTBSearch.Lines = new string[] {
        "Rechercher . . . TODO"};
            this.mTBSearch.Location = new System.Drawing.Point(5, 5);
            this.mTBSearch.Margin = new System.Windows.Forms.Padding(5);
            this.mTBSearch.MaxLength = 32767;
            this.mTBSearch.Name = "mTBSearch";
            this.mTBSearch.PasswordChar = '\0';
            this.mTBSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBSearch.SelectedText = "";
            this.mTBSearch.SelectionLength = 0;
            this.mTBSearch.SelectionStart = 0;
            this.mTBSearch.ShortcutsEnabled = true;
            this.mTBSearch.Size = new System.Drawing.Size(956, 30);
            this.mTBSearch.TabIndex = 9;
            this.mTBSearch.Text = "Rechercher . . . TODO";
            this.mTBSearch.UseSelectable = true;
            this.mTBSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 75;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // MouvementLibelle
            // 
            this.MouvementLibelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.MouvementLibelle.DefaultCellStyle = dataGridViewCellStyle5;
            this.MouvementLibelle.HeaderText = "Nom du mouvement";
            this.MouvementLibelle.Name = "MouvementLibelle";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::IkikayGF.Properties.Resources.tab_modifier;
            this.Modifier.MinimumWidth = 55;
            this.Modifier.Name = "Modifier";
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Width = 55;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Image = global::IkikayGF.Properties.Resources.tab_supprimer;
            this.Supprimer.MinimumWidth = 60;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Width = 60;
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
        private MetroFramework.Controls.MetroTextBox mTBSearch;
        private MetroFramework.Controls.MetroTile mButtonAddMouvement;
        private MetroFramework.Controls.MetroTabPage mTabCategories;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouvementLibelle;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}