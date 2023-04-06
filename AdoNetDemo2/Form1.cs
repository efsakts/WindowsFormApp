using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dwgProducts.DataSource = _productDal.GetAll();
        }

        private void dwgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitp.Text),
                Stock = Convert.ToInt32(tbxStock.Text)
            });
           
            LoadProducts();
            MessageBox.Show("added");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dwgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
                    {
                textBoxnameup.Text = dwgProducts.CurrentRow.Cells[1].Value.ToString();
                textBoxunitup.Text = dwgProducts.CurrentRow.Cells[2].Value.ToString();
                textboxstockup.Text = dwgProducts.CurrentRow.Cells[3].Value.ToString();
            }

        }

        //private void textBoxnameup_TextChanged(object sender, EventArgs e)
        //{
        //    textBoxnameup.Text = dwgProducts.CurrentRow.Cells[1].Value.ToString();
        //    textBoxunitup.Text = dwgProducts.CurrentRow.Cells[2].Value.ToString();
        //    textboxstockup.Text = dwgProducts.CurrentRow.Cells[3].Value.ToString();

        //}

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dwgProducts.CurrentRow.Cells[0].Value),
                Name =textBoxnameup.Text,
                UnitPrice=Convert.ToDecimal(textBoxunitup.Text),
                Stock= Convert.ToInt32(textboxstockup.Text)
            };
            
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("updated");        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dwgProducts.CurrentRow.Cells[0].Value);
           
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("deleted");
        }

        private void textBoxnameup_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUnitp_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
