using HomeWork.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeWork
{
    public partial class Form1 : Form
    {

        List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();
        }
        private void NameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void SoyadText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void VezifeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void MaashText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }   
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            employeeList = new List<Employee>();
            Employee newEmp = new Employee();
           
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (nameText.Text == " " || soyadText.Text == "" || emailText.Text == "" || vezifeText.Text == "" || maashText.Text == "")
            {
                MessageBox.Show("Zehmet olmasa xanalari bos buraxmayin.");
            }
            else if (!Regex.IsMatch(emailText.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else
            {
                newEmp.ID = newEmp.GetId();
                newEmp.Name = nameText.Text;
                newEmp.SurName = soyadText.Text;
                newEmp.Email = emailText.Text;
                newEmp.Position = vezifeText.Text;
                newEmp.Salary = Convert.ToInt32(maashText.Text);

                GridRow.Rows.Add(newEmp.ID, newEmp.Name, newEmp.SurName, newEmp.Email, newEmp.Position, newEmp.Salary);

                foreach (var item in Panel.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }
            employeeList.Add(newEmp);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.GridRow.SelectedRows)
            {
                GridRow.Rows.RemoveAt(item.Index);
            }
        }

        private void GridRow_DoubleClick(object sender, EventArgs e)
        {
        foreach (DataGridViewRow row in GridRow.SelectedRows)
        {
            nameText.Text = row.Cells[1].Value.ToString();
            soyadText.Text = row.Cells[2].Value.ToString();
            emailText.Text = row.Cells[3].Value.ToString();
            vezifeText.Text = row.Cells[4].Value.ToString();
            maashText.Text = row.Cells[5].Value.ToString();
        }
        }

        public void Edit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridRow.SelectedRows.Count; i++)
            {
                DataGridViewRow newRow = GridRow.SelectedRows[i]; 
                {
                        newRow.Cells[1].Value = nameText.Text;    
                      
                        newRow.Cells[2].Value = soyadText.Text;  
                    
                        newRow.Cells[3].Value = emailText.Text;  

                        newRow.Cells[4].Value = vezifeText.Text;

                        newRow.Cells[5].Value = maashText.Text;
                }
                nameText.Clear();
                soyadText.Clear();
                emailText.Clear();
                vezifeText.Clear();
                maashText.Clear();
            }


        }

      
    }
}
