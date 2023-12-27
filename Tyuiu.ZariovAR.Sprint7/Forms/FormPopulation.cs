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
    public partial class FormPopulation : Form
    {
        public FormPopulation()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void buttonPopul_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogPopul.ShowDialog();
                openFilePath = openFileDialogPopul.FileName;

                string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewPopul.ColumnCount = cols = arrayValues.GetLength(1);
                dataGridViewPopul.RowCount = rows = arrayValues.GetLength(0);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewPopul.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }

            }
            catch { }
        }

        private void buttonPopulGrafic_Click(object sender, EventArgs e)
        {
            chartPopul.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Численость населения");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewPopul.Rows)
            {
                if (!row.IsNewRow && row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddXY(label, hours);
                }
                else if (row.Cells[1] != null && row.Cells[1].Value != null) 
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartPopul.Series.Add(series);
        }

        private void chartPopul_Click(object sender, EventArgs e)
        {
                
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogPopul.FileName = "World.csv";
            saveFileDialogPopul.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogPopul.ShowDialog();


            string path = saveFileDialogPopul.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewPopul.RowCount;
            int columns = dataGridViewPopul.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewPopul.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewPopul.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }
}
