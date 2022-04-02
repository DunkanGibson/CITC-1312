using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.accountsDataSet.Account);

        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);

        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void accountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
