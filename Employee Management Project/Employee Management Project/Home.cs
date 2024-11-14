using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Management_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadTable();

            pictureboxLogout.ImageLocation = Application.StartupPath + "\\logout.png";
            pictureboxLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxLogout.BackColor = Color.Transparent;

            pictureboxExit.ImageLocation = Application.StartupPath + "\\power.png";
            pictureboxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxExit.BackColor = Color.Transparent;
        }

        DataTable dt = new DataTable();
        private int id = 107;
        private void LoadTable()
        {
            DataColumn idCol = dt.Columns.Add("ID", typeof(int));
            DataColumn positionCol = dt.Columns.Add("Position", typeof(string));
            DataColumn FirstNameCol = dt.Columns.Add("First Name", typeof(string));
            DataColumn LastNameCol = dt.Columns.Add("Last Name", typeof(string));
            DataColumn AgeCol = dt.Columns.Add("Age", typeof(int));
            DataColumn SalaryCol = dt.Columns.Add("Salary", typeof(int));
            DataColumn StatusCol = dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add(101, "Engineer","Jonathan", "Patel", 20, 35000, "Working");
            dt.Rows.Add(102, "Engineer", "Aaron", "Hunt", 22, 35000, "Working");
            dt.Rows.Add(103, "Accountant", "Corey", "Hudson", 22, 20000, "Working");
            dt.Rows.Add(104, "Accountant", "Xzavier", "Vance", 28, 20000, "Working");
            dt.Rows.Add(105, "Marketing Manager", "Alejandro", "Lara", 36, 65000, "Working");
            dt.Rows.Add(106, "Product Manager", "Alejandro", "Lara", 34, 65000, "Working");
            dt.Rows.Add(107, "Engineer", "Dominick", "Wallace", 29, 35000, "Working");



            dt.PrimaryKey = new DataColumn[] { idCol };
            EmployeeTable.DataSource = dt;
        }

        private void pictureboxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureboxLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddData(string position, string firstname, string lastname, string age, string salary, string status)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!int.TryParse(age, out int newAge))
                {
                    MessageBox.Show("กรุณากรอกอายุเป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(salary, out int newSalary))
                {
                    MessageBox.Show("กรุณากรอกเงินเดือนเป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                id += 1;
                dt.Rows.Add(id, position, firstname, lastname, age, salary, status);
                MessageBox.Show("Add Complete!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxAddPosition.Text = "";
                txtboxAddFirstname.Text = "";
                txtboxAddLastname.Text = "";
                txtboxAddAge.Text = "";
                txtboxAddSalary.Text = "";
                comboboxAddStatus.Text = "";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData(comboboxAddPosition.Text, txtboxAddFirstname.Text, txtboxAddLastname.Text, txtboxAddAge.Text, txtboxAddSalary.Text, comboboxAddStatus.Text);
        }

        private void EditData(string SelectedId, string position, string firstname, string lastname, string age, string salary, string status)
        {
            if (string.IsNullOrEmpty(SelectedId) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!int.TryParse(age, out int newAge))
                {
                    MessageBox.Show("กรุณากรอกอายุเป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(salary, out int newSalary))
                {
                    MessageBox.Show("กรุณากรอกเงินเดือนเป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(SelectedId, out int newSelectedId))
                {
                    MessageBox.Show("กรุณากรอกIDเป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow rowToEdit = dt.Rows.Find(SelectedId);
                if (rowToEdit != null)
                {
                    rowToEdit["Position"] = position;
                    rowToEdit["First Name"] = firstname;
                    rowToEdit["Last Name"] = lastname;
                    rowToEdit["Age"] = age;
                    rowToEdit["Salary"] = salary;
                    rowToEdit["Status"] = status;

                    MessageBox.Show("Edit Complete!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxEditId.Text = "";
                    comboboxEditPosition.Text = "";
                    txtboxEditFirstname.Text = "";
                    txtboxEditLastname.Text = "";
                    txtboxEditAge.Text = "";
                    txtboxEditSalary.Text = "";
                    comboboxEditStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("ไม่พบ ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            EditData(txtboxEditId.Text, comboboxEditPosition.Text, txtboxEditFirstname.Text, txtboxEditLastname.Text, txtboxEditAge.Text, txtboxEditSalary.Text, comboboxEditStatus.Text);
        }

        private void RemoveData(string SelectedId)
        {
            if (string.IsNullOrEmpty(SelectedId))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                if (!int.TryParse(SelectedId, out int newSelectedId))
                {
                    MessageBox.Show("กรุณากรอก ID เป็นตัวเลข!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DataRow rowToremove = dt.Rows.Find(SelectedId);
                    if (rowToremove != null)
                    {
                        DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "Remove", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            dt.Rows.Remove(rowToremove);
                            MessageBox.Show("Remove Complete!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบ ID", "Warning", MessageBoxButtons.OK);
                    }
                }
                
            }
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveData(txtboxRemoveId.Text);
        }
    }
}
