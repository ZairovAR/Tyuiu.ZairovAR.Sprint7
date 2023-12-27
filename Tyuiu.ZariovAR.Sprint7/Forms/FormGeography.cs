using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ZariovAR.Sprint7.Lib;
namespace Tyuiu.ZariovAR.Sprint7
{
    public partial class FormGeography : Form
    {
        public FormGeography()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void buttonGrafucGeography_Click(object sender, EventArgs e)
        {
            chartGeography.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Численость населения");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewGeography.Rows)
            {
                if (!row.IsNewRow && row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartGeography.Series.Add(series);
        }
        
        private void buttonSaveGeography_Click(object sender, EventArgs e)
        {
            saveFileDialogGeography.FileName = "World.csv";
            saveFileDialogGeography.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogGeography.ShowDialog();


            string path = saveFileDialogGeography.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewGeography.RowCount;
            int columns = dataGridViewGeography.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewGeography.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewGeography.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonGeography_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogGeography.ShowDialog();
                openFilePath = openFileDialogGeography.FileName;

                string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewGeography.ColumnCount = cols = arrayValues.GetLength(1);
                dataGridViewGeography.RowCount = rows = arrayValues.GetLength(0);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewGeography.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }

            }
            catch { }
        }
    }
}
