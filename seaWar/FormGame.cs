using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seaWar
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int cellSize = 40;
            dataGridMy.RowHeadersVisible = false;
            
            dataGridMy.Columns.Add("index", "");
            dataGridMy.Columns[0].Width = cellSize;
            for (int i = 0; i < 10; i++)
            {
                //DataGridViewImageColumn tempColumn = new DataGridViewImageColumn();
                //dataGridMy.Columns.Add(tempColumn);
  
                dataGridMy.Columns.Add(new DataGridViewImageColumn());
                //dataGridMy.Columns.Add("index", Convert.ToChar(Convert.ToInt32('A') + i).ToString());
                dataGridMy.Columns[i + 1].Width = cellSize;
               // dataGridMy.Columns[i + 1].ValueType = DataGridViewImageColumn;

            }

            dataGridMy.RowTemplate.Height = cellSize;
            for (int i = 0; i < 10; i++)
            {
                dataGridMy.Rows.Add();
                dataGridMy.Rows[i].Cells[0].Value = (i + 1).ToString();
            }

            Image img_ship = new Bitmap("ship_small.png");
            Image img_sea = new Bitmap("sea_small.png");
            for (int x = 1; x < 11; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    dataGridMy.Rows[y].Cells[x].Value = img_sea;
                }
            }

            dataGridMy.Rows[5].Cells[3].Value = img_ship;


        }
    }
}
