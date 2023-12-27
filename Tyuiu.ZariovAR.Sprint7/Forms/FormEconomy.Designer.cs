namespace Tyuiu.ZariovAR.Sprint7
{
    partial class FormEconomy
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
            this.dataGridViewEconomy = new System.Windows.Forms.DataGridView();
            this.Страна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Экономика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEconomy = new System.Windows.Forms.Button();
            this.openFileDialogEconomy = new System.Windows.Forms.OpenFileDialog();
            this.buttonGrafucEconomy = new System.Windows.Forms.Button();
            this.buttonSaveEconomy = new System.Windows.Forms.Button();
            this.chartEconomy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialogEconomy = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEconomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEconomy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEconomy
            // 
            this.dataGridViewEconomy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEconomy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Страна,
            this.Экономика});
            this.dataGridViewEconomy.Location = new System.Drawing.Point(12, 0);
            this.dataGridViewEconomy.Name = "dataGridViewEconomy";
            this.dataGridViewEconomy.Size = new System.Drawing.Size(244, 429);
            this.dataGridViewEconomy.TabIndex = 0;
            // 
            // Страна
            // 
            this.Страна.HeaderText = "Страна";
            this.Страна.Name = "Страна";
            // 
            // Экономика
            // 
            this.Экономика.HeaderText = "Экономика";
            this.Экономика.Name = "Экономика";
            // 
            // buttonEconomy
            // 
            this.buttonEconomy.Location = new System.Drawing.Point(12, 435);
            this.buttonEconomy.Name = "buttonEconomy";
            this.buttonEconomy.Size = new System.Drawing.Size(244, 23);
            this.buttonEconomy.TabIndex = 2;
            this.buttonEconomy.Text = "Вывести таблицу";
            this.buttonEconomy.UseVisualStyleBackColor = true;
            this.buttonEconomy.Click += new System.EventHandler(this.buttonEconomy_Click);
            // 
            // openFileDialogEconomy
            // 
            this.openFileDialogEconomy.FileName = "openFileDialog1";
            // 
            // buttonGrafucEconomy
            // 
            this.buttonGrafucEconomy.Location = new System.Drawing.Point(12, 464);
            this.buttonGrafucEconomy.Name = "buttonGrafucEconomy";
            this.buttonGrafucEconomy.Size = new System.Drawing.Size(244, 23);
            this.buttonGrafucEconomy.TabIndex = 3;
            this.buttonGrafucEconomy.Text = "Вывести в график";
            this.buttonGrafucEconomy.UseVisualStyleBackColor = true;
            this.buttonGrafucEconomy.Click += new System.EventHandler(this.buttonGrafucEconomy_Click);
            // 
            // buttonSaveEconomy
            // 
            this.buttonSaveEconomy.Location = new System.Drawing.Point(12, 494);
            this.buttonSaveEconomy.Name = "buttonSaveEconomy";
            this.buttonSaveEconomy.Size = new System.Drawing.Size(244, 23);
            this.buttonSaveEconomy.TabIndex = 4;
            this.buttonSaveEconomy.Text = "Сохранить";
            this.buttonSaveEconomy.UseVisualStyleBackColor = true;
            this.buttonSaveEconomy.Click += new System.EventHandler(this.buttonSaveEconomy_Click);
            // 
            // chartEconomy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEconomy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEconomy.Legends.Add(legend1);
            this.chartEconomy.Location = new System.Drawing.Point(262, 0);
            this.chartEconomy.Name = "chartEconomy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEconomy.Series.Add(series1);
            this.chartEconomy.Size = new System.Drawing.Size(854, 517);
            this.chartEconomy.TabIndex = 1;
            this.chartEconomy.Text = "chart1";
            // 
            // FormEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 684);
            this.Controls.Add(this.chartEconomy);
            this.Controls.Add(this.buttonSaveEconomy);
            this.Controls.Add(this.buttonGrafucEconomy);
            this.Controls.Add(this.buttonEconomy);
            this.Controls.Add(this.dataGridViewEconomy);
            this.Name = "FormEconomy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEconomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEconomy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEconomy;
        private System.Windows.Forms.Button buttonEconomy;
        private System.Windows.Forms.OpenFileDialog openFileDialogEconomy;
        private System.Windows.Forms.Button buttonGrafucEconomy;
        private System.Windows.Forms.Button buttonSaveEconomy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Экономика;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEconomy;
        private System.Windows.Forms.SaveFileDialog saveFileDialogEconomy;
    }
}