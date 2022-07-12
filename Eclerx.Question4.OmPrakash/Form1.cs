using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.Question4.OmPrakash
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private SqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using(con=new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using(cmd=new SqlCommand("usp_AddEmployee",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId",TxtEmployeeNo.Text);
                    cmd.Parameters.AddWithValue("@Employeename",TxtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Employeesalary",TxtSalary.Text);

                    MessageBox.Show("New Employee Created");
                    if(TxtSalary.Text >=25000 )
                    {
                        MessageBox.Show("valid Salary");
                    }
                    else
                    {
                    MessageBox.Show("Invalid Salary");
                    }
                }
                public void ClearEmployee()
                {
                    TxtEmployeeName.Text="";
                    TxtEmployeeNo.Text="";
                    TxtSalary.Text="";
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearEmployee();
        }
    }
    
}
