namespace POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnpos = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btnuseraccount = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(703, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Expiration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "NOTIFICATIONS";
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DataGridView1.Location = new System.Drawing.Point(695, 215);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(616, 222);
            this.DataGridView1.TabIndex = 18;
            // 
            // btnpos
            // 
            this.btnpos.BackColor = System.Drawing.Color.Transparent;
            this.btnpos.BackgroundImage = global::POS.Properties.Resources.pos_icon;
            this.btnpos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpos.FlatAppearance.BorderSize = 0;
            this.btnpos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpos.Location = new System.Drawing.Point(68, 144);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(127, 119);
            this.btnpos.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnpos, "POS");
            this.btnpos.UseVisualStyleBackColor = false;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            this.btnpos.MouseEnter += new System.EventHandler(this.btnpos_MouseEnter);
            this.btnpos.MouseLeave += new System.EventHandler(this.btnpos_MouseLeave);
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.Color.Transparent;
            this.btninventory.BackgroundImage = global::POS.Properties.Resources.inv_icon;
            this.btninventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btninventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninventory.FlatAppearance.BorderSize = 0;
            this.btninventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btninventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory.Location = new System.Drawing.Point(320, 247);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(127, 119);
            this.btninventory.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btninventory, "INVENTORY");
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            this.btninventory.MouseEnter += new System.EventHandler(this.btninventory_MouseEnter);
            this.btninventory.MouseLeave += new System.EventHandler(this.btninventory_MouseLeave);
            // 
            // btnuseraccount
            // 
            this.btnuseraccount.BackColor = System.Drawing.Color.Transparent;
            this.btnuseraccount.BackgroundImage = global::POS.Properties.Resources.accsetting_icon;
            this.btnuseraccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnuseraccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuseraccount.FlatAppearance.BorderSize = 0;
            this.btnuseraccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnuseraccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnuseraccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuseraccount.Location = new System.Drawing.Point(320, 403);
            this.btnuseraccount.Name = "btnuseraccount";
            this.btnuseraccount.Size = new System.Drawing.Size(127, 119);
            this.btnuseraccount.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnuseraccount, "ACCOUNT SETTINGS");
            this.btnuseraccount.UseVisualStyleBackColor = false;
            this.btnuseraccount.MouseEnter += new System.EventHandler(this.btnuseraccount_MouseEnter);
            this.btnuseraccount.MouseLeave += new System.EventHandler(this.btnuseraccount_MouseLeave);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Transparent;
            this.btnreport.BackgroundImage = global::POS.Properties.Resources.reports_icon;
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Location = new System.Drawing.Point(68, 312);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(127, 119);
            this.btnreport.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnreport, "REPORTS");
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.MouseEnter += new System.EventHandler(this.btnreport_MouseEnter);
            this.btnreport.MouseLeave += new System.EventHandler(this.btnreport_MouseLeave);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(1207, 27);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(47, 16);
            this.lbltime.TabIndex = 55;
            this.lbltime.Text = "Time:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(1207, 8);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(45, 16);
            this.lbldate.TabIndex = 54;
            this.lbldate.Text = "Date:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(703, 489);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(93, 16);
            this.linkLabel2.TabIndex = 56;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Restock Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnpos);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.btnuseraccount);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnpos;
        internal System.Windows.Forms.Button btninventory;
        internal System.Windows.Forms.Button btnuseraccount;
        internal System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

