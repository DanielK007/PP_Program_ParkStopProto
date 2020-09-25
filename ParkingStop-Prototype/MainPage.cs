using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingStop_Prototype
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Working with the entrance time
            DateTime intime = DateTime.Parse(dTimePickIn.Text);
            DateTime outtime = DateTime.Parse(dTimePickOut.Text);
            float duration = float.Parse((outtime - intime).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            txBxDuration.Text = hour + ":" + " " + minute;
            
            if((duration / 60) > 0)
            {
                if ((duration / 60) <= 0.5)
                {
                    txBxPayment.Text = "$" + 0 + "";
                }
                else
                {
                    txBxPayment.Text = "$" + (duration / 60) * 1 + "";
                }
            }

            int n = dGrdViewList.Rows.Add();
            dGrdViewList.Rows[n].Cells[0].Value = txBxTag.Text;
            dGrdViewList.Rows[n].Cells[1].Value = cmbBxType.Text;
            dGrdViewList.Rows[n].Cells[2].Value = cmbBxModel.Text;
            dGrdViewList.Rows[n].Cells[3].Value = txBxDuration.Text;
            dGrdViewList.Rows[n].Cells[4].Value = txBxPayment.Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dGrdViewList.Rows.Count > 0)
            {
                dGrdViewList.Rows.RemoveAt(dGrdViewList.CurrentRow.Index);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBxUser.Text == "user" && txtBxPassword.Text == "123")
            {
                pnlLogin.Visible = false;
            }
            else
            {
                txtBxUser.Clear();
                txtBxPassword.Clear();
                MessageBox.Show("Wrong User or Password");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit?", "ParkStop", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
