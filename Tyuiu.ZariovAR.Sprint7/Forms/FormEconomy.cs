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
    public partial class FormEconomy : Form
    {
        public FormEconomy()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void buttonGrafucEconomy_Click(object sender, EventArgs e)
        {
            chartEconomy.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Численость населения");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewEconomy.Rows)
            {
                if (!row.IsNewRow && row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[1].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartEconomy.Series.Add(series);
        }

        private void buttonEconomy_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogEconomy.ShowDialog();
                openFilePath = openFileDialogEconomy.FileName;

                string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewEconomy.ColumnCount = cols = arrayValues.GetLength(1);
                dataGridViewEconomy.RowCount = rows = arrayValues.GetLength(0);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewEconomy.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }

            }
            catch { }
        }

        private void buttonSaveEconomy_Click(object sender, EventArgs e)
        {
            saveFileDialogEconomy.FileName = "World.csv";
            saveFileDialogEconomy.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogEconomy.ShowDialog();


            string path = saveFileDialogEconomy.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewEconomy.RowCount;
            int columns = dataGridViewEconomy.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewEconomy.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewEconomy.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }
}
