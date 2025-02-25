using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_13._3_v_Gurina
{
    public partial class Form1 : Form
    {
        private SuitCollection suitCollection;


        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;

        private List<Suit> costumes = new List<Suit>();

        public Form1()
        {
            InitializeComponent();
            suitCollection = new SuitCollection();
            UpdateSuitList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.AutoResizeColumns();
        }
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Название";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Материал";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Цена";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }
        private void addCostum(string title, string material, string price)
        {
            showListInGrid();
        }
        private void deleteCostum(int elementIndex)
        {
            showListInGrid();
        }
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Suit s in costumes)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s.getTitle();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getMaterial();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getPrice();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                dataGridView1.Rows.Add(row);
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить костюм?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteCostum(selectedRow);
                }
                catch
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var suit = new Suit(txtBrand.Text, txtColor.Text, txtSize.Text, txtPrice.Text, datePostup.Value);
            suitCollection.AddSuit(suit);
            UpdateSuitList();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBoxSuits.SelectedItem is Suit selectedSuit)
        }
    }
}
