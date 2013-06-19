using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace POS
{
    public partial class Form2 : Form
    {
        Form3 a = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
        //    a.MdiParent = this;
        //    a.Show();
        //    a.Dock = DockStyle.Fill;
        //    a.Location = new Point(200, 0);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Transition b = new Transition(new TransitionType_EaseInEaseOut(1000));
            b.add(this, "Opacity", 1.0);
            b.run();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            //foodquantity.Hide();
            List<ProductPopulate> productPopulate = new List<ProductPopulate>();
            using (var myContext = new PosContext())
            {
                var prod = from s in myContext.Products select s;

                foreach (var p in prod)
                {
                   productPopulate.Add(new ProductPopulate(p.ProductName, p.CategoryName, p.Price));
                   //MessageBox.Show(p.ProductName);

                }
            }
            this.objectListView2.SetObjects(productPopulate);

        }

        private void txtsearch_MouseEnter(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void objectListView2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("aaaa");
            //MessageBox.Show(objectListView2.SelectedItems[0].SubItems[0].Text);
        }

        private void objectListView2_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            MessageBox.Show(objectListView2.SelectedItems[0].SubItems[0].Text);
        }

        

      
    }
}
