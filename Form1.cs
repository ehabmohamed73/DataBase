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


namespace studentAndEmployee
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb";
            cmd.Connection = con;
            cmd.CommandText = "select * from dept_teble";
            da.SelectCommand = cmd;
            da.Fill(ds, "depts");
            txtDept.DataBindings.Add("text", ds, "depts.dept_name");
            bm = this.BindingContext[ds, "depts"];
            txtDept.ReadOnly = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bm.AddNew();
            txtDept.ReadOnly = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void Btn_first_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            lblpos.Text = bm.Position.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)
                bm.Position--;
            lblpos.Text = bm.Position.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)
                bm.Position++;
            lblpos.Text = bm.Position.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
            lblpos.Text = bm.Position.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtDept.ReadOnly = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void TnDelete_Click(object sender, EventArgs e)
        {
            if(bm.Count>0)
            {
                bm.RemoveAt(bm.Position);
                OleDbCommandBuilder br = new OleDbCommandBuilder(da);
                bm.EndCurrentEdit();
                da.Update(ds, "depts");
            }
            else
            {
                MessageBox.Show("لا يوجد سجلات");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cd = new OleDbCommandBuilder(da);
            bm.EndCurrentEdit();
            da.Update(ds,"depts");
            txtDept.ReadOnly = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            bm.CancelCurrentEdit();
            txtDept.ReadOnly = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Text = txtDept.Text;
            stu.Tag = txtDept.Tag;
            stu.Show();
        }
    }
}
