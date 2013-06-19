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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Transition b = new Transition(new TransitionType_EaseInEaseOut(1000));
            b.add(this, "Opacity", 1.0);
            b.run();

            lbldate.Text = DateTime.Now.ToString("MM" + "/" + "dd" + "/" + "yyyy");// + "  " + "HH" + ":" + "mm" + " :" + "ss");
            timer1.Start();
        }

        private void btnpos_Click(object sender, EventArgs e)
        {

            Transition a = new Transition(new TransitionType_EaseInEaseOut(1000));
            a.add(this, "Opacity", 0.2);
            a.run();
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {

            Transition a = new Transition(new TransitionType_EaseInEaseOut(1000));
            a.add(this, "Opacity", 0.2);
            a.run();
            Form4 form = new Form4();
            form.ShowDialog();
            this.Hide();
        }


//events
        private void btnpos_MouseEnter(object sender, EventArgs e)
        {
            btnpos.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnpos_MouseLeave(object sender, EventArgs e)
        {
            btnpos.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btninventory_MouseEnter(object sender, EventArgs e)
        {
            btninventory.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btninventory_MouseLeave(object sender, EventArgs e)
        {
            btninventory.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnreport_MouseEnter(object sender, EventArgs e)
        {
            btnreport.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnreport_MouseLeave(object sender, EventArgs e)
        {
            btnreport.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnuseraccount_MouseEnter(object sender, EventArgs e)
        {
            btnuseraccount.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnuseraccount_MouseLeave(object sender, EventArgs e)
        {
            btnuseraccount.BackgroundImageLayout = ImageLayout.Center;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH" + ":" + "mm" + " :" + "ss");
        }
    }
}
