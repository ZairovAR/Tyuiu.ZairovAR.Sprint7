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
    }
}
