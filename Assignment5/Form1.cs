using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int id;
        private int points = 0;
        private int count = 0;
        private string category = "";

        List<int> randomNumbers = new List<int>();
        Random rand = new Random();

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Go.Enabled = true;

        }

        private void Go_Click(object sender, EventArgs e)
        {


            int num = 1;
            category = dropdown.SelectedItem.ToString();
            ArrayList list = new ArrayList();
            Question q = new Question();

            dropdown.Enabled = false;
            Go.Enabled = false;
            Submit.Enabled = true;

            id = rand.Next(1, 11);
            randomNumbers.Add(id);
            list = q.getQuestion(id, category);

            if (list.Count > 1)
            {
                ques.Text = list[0].ToString();
                foreach (Control control in options.Controls)
                {
                    RadioButton radio = control as RadioButton;
                    radio.Enabled = true;
                    radio.Text = list[num].ToString();
                    num++;
                }
            }
            else
            {
                error.Visible = true;
                error.Text = list[0].ToString();
                Submit.Enabled = false;
                Next.Enabled = false;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            options.Enabled = false;
            Submit.Enabled = false;
            Next.Enabled = true;

            string result = "NO SELECTION";
            Result res = new Result();

            foreach (Control control in options.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio.Checked)
                {
                    result = res.getResult(radio.Text, id, category);
                }
            }

            if (result == "CORRECT")
            {
                points = points + 10;
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Green;
                explain.Visible = true;
                explain.Text = "Congratulations!! You have selected the correct option.";
                explain.ForeColor = Color.Green;
            }
            else if (result == "WRONG" || result == "NO SELECTION")
            {
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Red;
                explain.Visible = true;
                explain.Text = "oops!! You have selected the wrong option.";
                explain.ForeColor = Color.Red;
            }
            else
            {
                error.Visible = true;
                error.Text = result;
                Submit.Enabled = false;
                Next.Enabled = false;
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {

            int num = 1;
            explain.Visible = false;

            foreach (Control control in options.Controls)
            {
                RadioButton radio = control as RadioButton;
                radio.Checked = false;
            }

            Next.Enabled = false;
            Submit.Enabled = true;
            options.Enabled = true;
            options.Refresh();

            do id = rand.Next(1, 11);
            while (randomNumbers.Contains(id));
            randomNumbers.Add(id);

            Question q = new Question();
            ArrayList list = new ArrayList();
            list = q.getQuestion(id, category);

            if (list.Count > 1)
            {
                if (count < 4)
                {
                    ques.Text = list[0].ToString();
                    foreach (Control control in options.Controls)
                    {
                        RadioButton radio = control as RadioButton;
                        radio.Enabled = true;
                        radio.Text = list[num].ToString();
                        num++;
                    }
                    count++;
                }

                else
                {
                    MessageBox.Show("You have successfully completed the quiz and scored " + points + " points");
                    Submit.Enabled = false;
                    foreach (Control control in options.Controls)
                    {
                        RadioButton radio = control as RadioButton;
                        radio.Enabled = false;
                    }

                }
            }
            else
            {
                error.Visible = true;
                error.Text = list[0].ToString();
                Submit.Enabled = false;
                Next.Enabled = false;
            }


        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INSTRUCTIONS:" + Environment.NewLine +
                            "1. You will be asked 5 Questions on a Topic that you choose." + Environment.NewLine +
                            "2. Select your answer for the question displayed." + Environment.NewLine +
                            "3. Click on Submit to check if your answer is correct." + Environment.NewLine +
                            "4. Click Next for next Question." + Environment.NewLine +
                            "5. You will get 10 points for each correct answer." + Environment.NewLine +
                            "6. No penalty for wrongly answerd question.");
        }

        private void startagain_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
