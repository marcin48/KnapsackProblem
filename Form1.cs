using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


 
  
        public Form1()
        {
            InitializeComponent();
        }


        private void solve_btn_Click(object sender, EventArgs e)
        {   
            //int seed = int.Parse(Seed.Text);
            //int n = int.Parse(item_number.Text);
            //int cap = int.Parse(Capacity.Text);
            bool Verification = true;

            if(!int.TryParse(Seed.Text, out int seed) || seed < 0)
            {
                Seed.BackColor = Color.Red;
                Verification = false;
            }

            if (!int.TryParse(item_number.Text, out int n) || n < 0)
            {
                item_number.BackColor = Color.Red;
                Verification = false;
            }

            if (!int.TryParse(Capacity.Text, out int cap) || cap < 0)
            {
                Capacity.BackColor = Color.Red;
                Verification = false;
            }

            if (!Verification)
            {
                MessageBox.Show("INCORRECT NUMBERS!!!!!");
                return;
            }
            else
            {
                Seed.BackColor = Color.White;
                item_number.BackColor = Color.White;
                Capacity.BackColor = Color.White;

                BackpackProblem plecak = new BackpackProblem(n, seed);

                Result result = plecak.Solve(cap);

                instance_box.Text = plecak.ToString().Replace("\n", Environment.NewLine);
                result_box.Text = result.ToString().Replace("\n", Environment.NewLine);
            }


        }
    }
}
