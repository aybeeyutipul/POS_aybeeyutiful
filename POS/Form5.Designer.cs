namespace POS
{
    partial class Form5
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
            this.metrotab = new MetroFramework.Controls.MetroTabControl();
            this.tabcreate = new System.Windows.Forms.TabPage();
            this.btnadduser = new System.Windows.Forms.Button();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtconpw = new System.Windows.Forms.TextBox();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnedt_pword = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txteditempid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpeditacct = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.TextBox();
            this.tabposi = new System.Windows.Forms.TabPage();
            this.btnaddpos = new System.Windows.Forms.Button();
            this.btneditcancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsavepos = new System.Windows.Forms.Button();
            this.txtposname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtposno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picback = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metrotab.SuspendLayout();
            this.tabcreate.SuspendLayout();
            this.tabedit.SuspendLayout();
            this.grpeditacct.SuspendLayout();
            this.tabposi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picback)).BeginInit();
            this.SuspendLayout();
            // 
            // metrotab
            // 
            this.metrotab.Controls.Add(this.tabcreate);
            this.metrotab.Controls.Add(this.tabposi);
            this.metrotab.Controls.Add(this.tabedit);
            this.metrotab.Location = new System.Drawing.Point(17, 39);
            this.metrotab.Name = "metrotab";
            this.metrotab.SelectedIndex = 2;
            this.metrotab.Size = new System.Drawing.Size(658, 439);
            this.metrotab.Style = MetroFramework.MetroColorStyle.Red;
            this.metrotab.TabIndex = 4;
            this.metrotab.UseSelectable = true;
            // 
            // tabcreate
            // 
            this.tabcreate.BackColor = System.Drawing.Color.Transparent;
            this.tabcreate.Controls.Add(this.btnadduser);
            this.tabcreate.Controls.Add(this.txtpos);
            this.tabcreate.Controls.Add(this.txtemployeeid);
            this.tabcreate.Controls.Add(this.label20);
            this.tabcreate.Controls.Add(this.txtlname);
            this.tabcreate.Controls.Add(this.label14);
            this.tabcreate.Controls.Add(this.label19);
            this.tabcreate.Controls.Add(this.label15);
            this.tabcreate.Controls.Add(this.txtusername);
            this.tabcreate.Controls.Add(this.label16);
            this.tabcreate.Controls.Add(this.label17);
            this.tabcreate.Controls.Add(this.txtpw);
            this.tabcreate.Controls.Add(this.txtfname);
            this.tabcreate.Controls.Add(this.label18);
            this.tabcreate.Controls.Add(this.txtconpw);
            this.tabcreate.Location = new System.Drawing.Point(4, 35);
            this.tabcreate.Name = "tabcreate";
            this.tabcreate.Size = new System.Drawing.Size(650, 400);
            this.tabcreate.TabIndex = 1;
            this.tabcreate.Text = "Create Account";
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.Transparent;
            this.btnadduser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadduser.FlatAppearance.BorderSize = 0;
            this.btnadduser.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadduser.Image = global::POS.Properties.Resources.Add_user;
            this.btnadduser.Location = new System.Drawing.Point(498, 287);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(97, 76);
            this.btnadduser.TabIndex = 133;
            this.toolTip1.SetToolTip(this.btnadduser, "Add User");
            this.btnadduser.UseVisualStyleBackColor = false;
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(304, 147);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(199, 20);
            this.txtpos.TabIndex = 146;
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Location = new System.Drawing.Point(304, 53);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(97, 20);
            this.txtemployeeid.TabIndex = 132;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(108, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 16);
            this.label20.TabIndex = 136;
            this.label20.Text = "Employee Id:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(304, 120);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(199, 20);
            this.txtlname.TabIndex = 135;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 145;
            this.label14.Text = "Username:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(108, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 137;
            this.label19.Text = "First Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(108, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 16);
            this.label15.TabIndex = 143;
            this.label15.Text = "Confirm Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(304, 174);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(199, 20);
            this.txtusername.TabIndex = 144;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(108, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 142;
            this.label16.Text = "Password:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(108, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 139;
            this.label17.Text = "Position";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(304, 201);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(199, 20);
            this.txtpw.TabIndex = 140;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(304, 92);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(199, 20);
            this.txtfname.TabIndex = 134;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(108, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 16);
            this.label18.TabIndex = 138;
            this.label18.Text = "Last Name:";
            // 
            // txtconpw
            // 
            this.txtconpw.Location = new System.Drawing.Point(304, 227);
            this.txtconpw.Name = "txtconpw";
            this.txtconpw.Size = new System.Drawing.Size(199, 20);
            this.txtconpw.TabIndex = 141;
            this.txtconpw.UseSystemPasswordChar = true;
            // 
            // tabedit
            // 
            this.tabedit.BackColor = System.Drawing.Color.Transparent;
            this.tabedit.Controls.Add(this.button2);
            this.tabedit.Controls.Add(this.btnedt_pword);
            this.tabedit.Controls.Add(this.btnsave);
            this.tabedit.Controls.Add(this.txteditempid);
            this.tabedit.Controls.Add(this.label5);
            this.tabedit.Controls.Add(this.grpeditacct);
            this.tabedit.Location = new System.Drawing.Point(4, 35);
            this.tabedit.Name = "tabedit";
            this.tabedit.Size = new System.Drawing.Size(650, 400);
            this.tabedit.TabIndex = 2;
            this.tabedit.Text = "Edit Account";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::POS.Properties.Resources.Cute_Ball_Stop;
            this.button2.Location = new System.Drawing.Point(466, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 45);
            this.button2.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button2, "Cancel");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnedt_pword
            // 
            this.btnedt_pword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnedt_pword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedt_pword.FlatAppearance.BorderSize = 0;
            this.btnedt_pword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnedt_pword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnedt_pword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedt_pword.Image = global::POS.Properties.Resources.Edit_item;
            this.btnedt_pword.Location = new System.Drawing.Point(118, 327);
            this.btnedt_pword.Name = "btnedt_pword";
            this.btnedt_pword.Size = new System.Drawing.Size(62, 43);
            this.btnedt_pword.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnedt_pword, "Update");
            this.btnedt_pword.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::POS.Properties.Resources.save;
            this.btnsave.Location = new System.Drawing.Point(294, 325);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 44);
            this.btnsave.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnsave, "Save");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txteditempid
            // 
            this.txteditempid.Location = new System.Drawing.Point(293, 31);
            this.txteditempid.Name = "txteditempid";
            this.txteditempid.Size = new System.Drawing.Size(156, 20);
            this.txteditempid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee ID:";
            // 
            // grpeditacct
            // 
            this.grpeditacct.Controls.Add(this.label4);
            this.grpeditacct.Controls.Add(this.textBox5);
            this.grpeditacct.Controls.Add(this.textBox3);
            this.grpeditacct.Controls.Add(this.textBox1);
            this.grpeditacct.Controls.Add(this.textBox2);
            this.grpeditacct.Controls.Add(this.label3);
            this.grpeditacct.Controls.Add(this.label9);
            this.grpeditacct.Controls.Add(this.label2);
            this.grpeditacct.Controls.Add(this.label1);
            this.grpeditacct.Controls.Add(this.textBox8);
            this.grpeditacct.Controls.Add(this.label8);
            this.grpeditacct.Controls.Add(this.pos);
            this.grpeditacct.Location = new System.Drawing.Point(52, 60);
            this.grpeditacct.Name = "grpeditacct";
            this.grpeditacct.Size = new System.Drawing.Size(547, 237);
            this.grpeditacct.TabIndex = 3;
            this.grpeditacct.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, -28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Position:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, -33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 110;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 109;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 107;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 106;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 105;
            this.label9.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Old Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 71);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 20);
            this.textBox8.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 103;
            this.label8.Text = "Position:";
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(242, 44);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(156, 20);
            this.pos.TabIndex = 102;
            // 
            // tabposi
            // 
            this.tabposi.BackColor = System.Drawing.Color.Transparent;
            this.tabposi.Controls.Add(this.btnaddpos);
            this.tabposi.Controls.Add(this.btneditcancel);
            this.tabposi.Controls.Add(this.btnedit);
            this.tabposi.Controls.Add(this.btnsavepos);
            this.tabposi.Controls.Add(this.txtposname);
            this.tabposi.Controls.Add(this.label7);
            this.tabposi.Controls.Add(this.txtposno);
            this.tabposi.Controls.Add(this.label6);
            this.tabposi.Location = new System.Drawing.Point(4, 35);
            this.tabposi.Name = "tabposi";
            this.tabposi.Size = new System.Drawing.Size(650, 400);
            this.tabposi.TabIndex = 3;
            this.tabposi.Text = "Position";
            // 
            // btnaddpos
            // 
            this.btnaddpos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnaddpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddpos.FlatAppearance.BorderSize = 0;
            this.btnaddpos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaddpos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnaddpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpos.Image = global::POS.Properties.Resources.Button_Add;
            this.btnaddpos.Location = new System.Drawing.Point(77, 282);
            this.btnaddpos.Name = "btnaddpos";
            this.btnaddpos.Size = new System.Drawing.Size(68, 44);
            this.btnaddpos.TabIndex = 112;
            this.btnaddpos.Text = "Add";
            this.btnaddpos.UseVisualStyleBackColor = true;
            // 
            // btneditcancel
            // 
            this.btneditcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneditcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditcancel.FlatAppearance.BorderSize = 0;
            this.btneditcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btneditcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneditcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditcancel.Image = global::POS.Properties.Resources.Cute_Ball_Stop;
            this.btneditcancel.Location = new System.Drawing.Point(491, 282);
            this.btneditcancel.Name = "btneditcancel";
            this.btneditcancel.Size = new System.Drawing.Size(62, 45);
            this.btneditcancel.TabIndex = 111;
            this.btneditcancel.Text = "Cancel";
            this.btneditcancel.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Image = global::POS.Properties.Resources.Edit_item;
            this.btnedit.Location = new System.Drawing.Point(220, 282);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(62, 43);
            this.btnedit.TabIndex = 109;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsavepos
            // 
            this.btnsavepos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsavepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavepos.FlatAppearance.BorderSize = 0;
            this.btnsavepos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsavepos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsavepos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavepos.Image = global::POS.Properties.Resources.save;
            this.btnsavepos.Location = new System.Drawing.Point(356, 282);
            this.btnsavepos.Name = "btnsavepos";
            this.btnsavepos.Size = new System.Drawing.Size(62, 44);
            this.btnsavepos.TabIndex = 110;
            this.btnsavepos.Text = "Save";
            this.btnsavepos.UseVisualStyleBackColor = true;
            // 
            // txtposname
            // 
            this.txtposname.Location = new System.Drawing.Point(281, 145);
            this.txtposname.Name = "txtposname";
            this.txtposname.Size = new System.Drawing.Size(156, 20);
            this.txtposname.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Position:";
            // 
            // txtposno
            // 
            this.txtposno.Location = new System.Drawing.Point(282, 112);
            this.txtposno.Name = "txtposno";
            this.txtposno.Size = new System.Drawing.Size(156, 20);
            this.txtposno.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Position No:";
            // 
            // picback
            // 
            this.picback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picback.Image = global::POS.Properties.Resources._12065699261710976909pitr_green_single_arrows_set_4_svg_hi;
            this.picback.Location = new System.Drawing.Point(631, 8);
            this.picback.Name = "picback";
            this.picback.Size = new System.Drawing.Size(28, 25);
            this.picback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picback.TabIndex = 104;
            this.picback.TabStop = false;
            this.toolTip1.SetToolTip(this.picback, "BACK");
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 516);
            this.Controls.Add(this.picback);
            this.Controls.Add(this.metrotab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.metrotab.ResumeLayout(false);
            this.tabcreate.ResumeLayout(false);
            this.tabcreate.PerformLayout();
            this.tabedit.ResumeLayout(false);
            this.tabedit.PerformLayout();
            this.grpeditacct.ResumeLayout(false);
            this.grpeditacct.PerformLayout();
            this.tabposi.ResumeLayout(false);
            this.tabposi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metrotab;
        private System.Windows.Forms.TabPage tabcreate;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtconpw;
        private System.Windows.Forms.TabPage tabedit;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button btnedt_pword;
        internal System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txteditempid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpeditacct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.TabPage tabposi;
        internal System.Windows.Forms.Button btnaddpos;
        internal System.Windows.Forms.Button btneditcancel;
        internal System.Windows.Forms.Button btnedit;
        internal System.Windows.Forms.Button btnsavepos;
        private System.Windows.Forms.TextBox txtposname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtposno;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.PictureBox picback;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}