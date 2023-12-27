namespace Tyuiu.ZariovAR.Sprint7
{
    partial class FormPopulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPopul = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogPopul = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPopul = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewPopul = new System.Windows.Forms.DataGridView();
            this.Страны = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Население = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPopul = new System.Windows.Forms.Button();
            this.buttonPopulGrafic = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopul)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPopul
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPopul.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPopul.Legends.Add(legend1);
            this.chartPopul.Location = new System.Drawing.Point(261, 0);
            this.chartPopul.Name = "chartPopul";
            this.chartPopul.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartPopul.Series.Add(series1);
            this.chartPopul.Series.Add(series2);
            this.chartPopul.Size = new System.Drawing.Size(1163, 672);
            this.chartPopul.TabIndex = 1;
            this.chartPopul.Text = "chart1";
            this.chartPopul.Click += new System.EventHandler(this.chartPopul_Click);
            // 
            // openFileDialogPopul
            // 
            this.openFileDialogPopul.FileName = "openFileDialog1";
            // 
            // dataGridViewPopul
            // 
            this.dataGridViewPopul.AllowUserToOrderColumns = true;
            this.dataGridViewPopul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Страны,
            this.Население});
            this.dataGridViewPopul.Location = new System.Drawing.Point(12, 0);
            this.dataGridViewPopul.Name = "dataGridViewPopul";
            this.dataGridViewPopul.RowHeadersVisible = false;
            this.dataGridViewPopul.Size = new System.Drawing.Size(244, 429);
            this.dataGridViewPopul.TabIndex = 0;
            // 
            // Страны
            // 
            this.Страны.HeaderText = "Страны";
            this.Страны.Name = "Страны";
            // 
            // Население
            // 
            this.Население.HeaderText = "Население";
            this.Население.Name = "Население";
            // 
            // buttonPopul
            // 
            this.buttonPopul.Location = new System.Drawing.Point(12, 435);
            this.buttonPopul.Name = "buttonPopul";
            this.buttonPopul.Size = new System.Drawing.Size(244, 23);
            this.buttonPopul.TabIndex = 2;
            this.buttonPopul.Text = "Вывести таблицу";
            this.buttonPopul.UseVisualStyleBackColor = true;
            this.buttonPopul.Click += new System.EventHandler(this.buttonPopul_Click);
            // 
            // buttonPopulGrafic
            // 
            this.buttonPopulGrafic.Location = new System.Drawing.Point(12, 464);
            this.buttonPopulGrafic.Name = "buttonPopulGrafic";
            this.buttonPopulGrafic.Size = new System.Drawing.Size(243, 23);
            this.buttonPopulGrafic.TabIndex = 4;
            this.buttonPopulGrafic.Text = "Вывести в график";
            this.buttonPopulGrafic.UseVisualStyleBackColor = true;
            this.buttonPopulGrafic.Click += new System.EventHandler(this.buttonPopulGrafic_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 493);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(243, 28);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 684);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.chartPopul);
            this.Controls.Add(this.buttonPopulGrafic);
            this.Controls.Add(this.dataGridViewPopul);
            this.Controls.Add(this.buttonPopul);
            this.Name = "FormPopulation";
            ((System.ComponentModel.ISupportInitialize)(this.chartPopul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopul;
        private System.Windows.Forms.OpenFileDialog openFileDialogPopul;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPopul;
        private System.Windows.Forms.DataGridView dataGridViewPopul;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPopulGrafic;
        private System.Windows.Forms.Button buttonPopul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страны;
        private System.Windows.Forms.DataGridViewTextBoxColumn Население;
    }
}