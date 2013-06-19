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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Transition b = new Transition(new TransitionType_EaseInEaseOut(1000));
            b.add(this, "Opacity", 1.0);
            b.run();
        }




        private void btnsave_Click(object sender, EventArgs e)
        {
            using (var myContext = new PosContext())
            {
                var prod1 = new Product { Price = double.Parse(txtprice.Text), ProductName = txtfoodname.Text, CategoryName = txtcatiname.Text };
                myContext.Products.Add(prod1);
                myContext.SaveChanges();

                MessageBox.Show("Save");
                txtcatiname.Clear();
                txtfoodname.Clear();
                txtprice.Clear();
            }
        }
    }
}