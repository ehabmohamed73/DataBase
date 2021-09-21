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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                        +Application.StartupPath+"Database.accdb";
        DataTable dt;
        OleDbDataAdapter da;
        BindingManagerBase bmb;
        int p,op; string sql;
        void loadData()
        {
            txtName.DataBindings.Clear();
            radFamle.DataBindings.Clear();
            radMale.DataBindings.Clear();
            cmbLevel.DataBindings.Clear();
            cmbLevel.Items.Clear();
            sql = "select stu_id,dept_id , stu_name, stu_sex,not(stu_sex) as fe,stu_level" +
                " from stu_table  where dept_id=" + this.Tag;
            da = new OleDbDataAdapter(sql, conStr);
            dt = new DataTable();
            da.Fill(dt);

            txtName.DataBindings.Add("text", dt, "stu_name");
            txtName.DataBindings.Add("tag", tnDelete, "stu_id");
            cmbLevel.Items.Add("اول");
            cmbLevel.Items.Add("ثاني");
            cmbLevel.Items.Add("ثالث");
            cmbLevel.Items.Add("رابع");
            cmbLevel.DataBindings.Add("SelectedIndex", dt, "stu_level");
            radMale.DataBindings.Add("Checked", dt, "stu_sex");
            radFamle.DataBindings.Add("Checked", dt, "fe");
            bmb = BindingContext[dt];
            sex.Enabled = false;
            groupShow.Enabled = true;

        }

        private void Student_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Btn_first_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bmb.Position > 0)
                bmb.Position--;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (bmb.Position < bmb.Count - 1)
                bmb.Position++;
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count - 1;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(op==1)
            {
                sql = "insert into stu_table (stu_name,dept_id,stu_sex,stu_level) values ('"
                    + txtName.Text + "," + this.Tag + "," + radMale.Checked + ","
                    + cmbLevel.SelectedIndex + ")";
            }
            else if(op==2)
            {
                sql = "update stu_table set stu_name= '" + txtName.Text + ", dept_id=" + Tag
                    + ", stu_sex=" + radMale.Checked + "stu_level=" + cmbLevel.SelectedIndex
                    + "where stu_id=" + txtName.Tag;
            }
            else
            {
                sql = "delete from stu_table where stu_id=" + txtName.Tag;
                OleDbConnection con = new OleDbConnection(conStr);
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();
                if(op==1)
                 p = bmb.Count - 1;
                bmb.Position = p;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            p = bmb.Position;op = 2;
            sex.Enabled = true;
            groupCommit.Enabled = true;
            groupShow.Enabled = false;

        }

        private void TnDelete_Click(object sender, EventArgs e)
        {
            p = bmb.Position; op = 3;
            sex.Enabled = false;
            groupCommit.Enabled = false;
            groupShow.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            p = bmb.Position;
            op = 1;
            sex.Enabled = true;
            groupShow.Enabled = false;
            groupCommit.Enabled = true;txtName.Text = null;
            cmbLevel.SelectedIndex = 0;
            radFamle.Checked = true;
            
        }
    }
}
