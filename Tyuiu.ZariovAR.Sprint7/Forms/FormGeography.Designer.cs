namespace Tyuiu.ZariovAR.Sprint7
{
    partial class FormGeography
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGeography = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSaveGeography = new System.Windows.Forms.Button();
            this.buttonGrafucGeography = new System.Windows.Forms.Button();
            this.buttonGeography = new System.Windows.Forms.Button();
            this.dataGridViewGeography = new System.Windows.Forms.DataGridView();
            this.openFileDialogGeography = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogGeography = new System.Windows.Forms.SaveFileDialog();
            this.Страна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Территория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeography)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeography)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGeography
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGeography.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGeography.Legends.Add(legend2);
            this.chartGeography.Location = new System.Drawing.Point(263, 12);
            this.chartGeography.Name = "chartGeography";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGeography.Series.Add(series2);
            this.chartGeography.Size = new System.Drawing.Size(854, 517);
            this.chartGeography.TabIndex = 6;
            this.chartGeography.Text = "chart1";
            // 
            // buttonSaveGeography
            // 
            this.buttonSaveGeography.Location = new System.Drawing.Point(13, 506);
            this.buttonSaveGeography.Name = "buttonSaveGeography";
            this.buttonSaveGeography.Size = new System.Drawing.Size(244, 23);
            this.buttonSaveGeography.TabIndex = 9;
            this.buttonSaveGeography.Text = "Сохранить";
            this.buttonSaveGeography.UseVisualStyleBackColor = true;
            this.buttonSaveGeography.Click += new System.EventHandler(this.buttonSaveGeography_Click);
            // 
            // buttonGrafucGeography
            // 
            this.buttonGrafucGeography.Location = new System.Drawing.Point(13, 476);
            this.buttonGrafucGeography.Name = "buttonGrafucGeography";
            this.buttonGrafucGeography.Size = new System.Drawing.Size(244, 23);
            this.buttonGrafucGeography.TabIndex = 8;
            this.buttonGrafucGeography.Text = "Вывести в график";
            this.buttonGrafucGeography.UseVisualStyleBackColor = true;
            this.buttonGrafucGeography.Click += new System.EventHandler(this.buttonGrafucGeography_Click);
            // 
            // buttonGeography
            // 
            this.buttonGeography.Location = new System.Drawing.Point(13, 447);
            this.buttonGeography.Name = "buttonGeography";
            this.buttonGeography.Size = new System.Drawing.Size(244, 23);
            this.buttonGeography.TabIndex = 7;
            this.buttonGeography.Text = "Вывести таблицу";
            this.buttonGeography.UseVisualStyleBackColor = true;
            this.buttonGeography.Click += new System.EventHandler(this.buttonGeography_Click);
            // 
            // dataGridViewGeography
            // 
            this.dataGridViewGeography.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeography.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Страна,
            this.Территория});
            this.dataGridViewGeography.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewGeography.Name = "dataGridViewGeography";
            this.dataGridViewGeography.Size = new System.Drawing.Size(244, 429);
            this.dataGridViewGeography.TabIndex = 5;
            // 
            // openFileDialogGeography
            // 
            this.openFileDialogGeography.FileName = "openFileDialog1";
            // 
            // Страна
            // 
            this.Страна.HeaderText = "Страна";
            this.Страна.Name = "Страна";
            // 
            // Территория
            // 
            this.Территория.HeaderText = "Территория";
            this.Территория.Name = "Территория";
            // 
            // FormGeography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 684);
            this.Controls.Add(this.chartGeography);
            this.Controls.Add(this.buttonSaveGeography);
            this.Controls.Add(this.buttonGrafucGeography);
            this.Controls.Add(this.buttonGeography);
            this.Controls.Add(this.dataGridViewGeography);
            this.Name = "FormGeography";
            ((System.ComponentModel.ISupportInitialize)(this.chartGeography)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeography)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeography;
        private System.Windows.Forms.Button buttonSaveGeography;
        private System.Windows.Forms.Button buttonGrafucGeography;
        private System.Windows.Forms.Button buttonGeography;
        private System.Windows.Forms.DataGridView dataGridViewGeography;
        private System.Windows.Forms.OpenFileDialog openFileDialogGeography;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGeography;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Территория;
    }
}