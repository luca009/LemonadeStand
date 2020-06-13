using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonadeStand
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        public void setText(int moneyEarned, int glassesSold, int glassesMade, bool hasRained)
        {
            tbMain.Text = "You've earned " + moneyEarned + " cents today. You sold " + glassesSold + "/" + glassesMade + " glasses.";
            if (hasRained)
                tbMain.Text += "\n It has rained today (your stand was forced to close for the day).";
        }

        public void setTextAI(int moneyEarned, int moneyEarnedAI, int glassesSold, int glassesSoldAI, int glassesMade, int glassesMadeAI, int moneyAI, bool hasRained)
        {
            tbMain.Text = "You've earned " + moneyEarned + " cents today. You sold " + glassesSold + "/" + glassesMade + " glasses. \nThe AI earned " + moneyEarnedAI + " cents. It sold " + glassesSoldAI + "/" + glassesMadeAI + " glasses. The AI now has " + moneyAI + " cents.";
            if (hasRained)
                tbMain.Text += "\n It has rained today (your and your opponents stand was forced to close for the day). ";
        }
    }
}
