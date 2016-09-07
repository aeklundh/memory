using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övningar_WinForms
{
    public partial class frmExc9 : Form
    {

        Button previousButton = null;
        Button lastRound1 = null;
        Button lastRound2 = null;

        public void ShowButtonString(Button button)
        {
            button.Text = PairIdToString(button);
        }

        public void HideButtonString(Button button)
        {
            button.Text = "";
        }

        public string PairIdToString(Button button)
        {
            string output = button.Tag.ToString()[0].ToString();
            return output;
        }

        public void Compare(Button justPressed)
        {
            if (previousButton.Tag.ToString()[0] == justPressed.Tag.ToString()[0])
            {
                if (previousButton.Tag.ToString()[1] != justPressed.Tag.ToString()[1])
                {
                    previousButton.Hide();
                    justPressed.Hide();
                    previousButton = null;
                }
                else
                {
                    previousButton = null;
                }
            }
            else
            {
                previousButton = null;
            }
        }

        public frmExc9()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            if (previousButton == null)
            {
                try
                {
                    HideButtonString(lastRound1);
                    HideButtonString(lastRound2);
                }
                catch (Exception)
                {
                }
                ShowButtonString((sender as Button));
                previousButton = (sender as Button);
            }
            else
            {
                ShowButtonString((sender as Button));
                lastRound1 = previousButton;
                lastRound2 = (Button)sender;
                //HideButtonString((sender as Button));
                //HideButtonString(previousButton);
                Compare((sender as Button));
            }

        }
    }
}
