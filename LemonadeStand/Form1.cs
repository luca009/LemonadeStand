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
    public partial class Form1 : Form
    {
        public int costLemonade = 2;
        public int costSign = 5;
        public Random random = new Random();
        public int weather = 0;
        public int rainChance = 0;
        public int round = 1;
        public int special = 0;
        public string specialText = "";
        public int money = 500;
        public int aiMoney = 500;
        public int visitProbability;
        public Int32 glassesSold;
        public int glassesSoldAI;
        public bool hasRained = false;
        public int visitProbabilityAI;
        public Int32 returnMoneyEarned;
        public bool blindAI = false;
        public bool sharedMarket = false;
        public int aiAmount;
        public int glassesMadeAI = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void anyNud_ValueChanged(object sender, EventArgs e)
        {
            tbDebrief.Text = "This will cost you " + ((costLemonade * nudAmount.Value) + (costSign * nudSigns.Value)) + " cents. You have " + money + " cents.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recalculate();
        }

        public void recalculate()
        {
            random = new Random();

            weather = random.Next(0, 50);
            rainChance = random.Next(0, 80);
            special = random.Next(0, 30);

            if (rainChance < 25)
                rainChance /= random.Next(1, 20);
            if (rainChance > 40)
                rainChance /= random.Next(1, 6);

            if (weather < 15)
                rainChance *= random.Next(0, 2);
            if (weather > 35)
                rainChance /= random.Next(2, 6);

            specialText = "There are no special events today.";
            if (special <= 21)
                specialText = "There are no special events today.";
            if (special == 22 && weather < 20)
                specialText = "Thunderstorms are expected today!";
            if (special == 23)
                specialText = "There's construction work today. You will get less sales.";
            if (special >= 24 && weather > 35)
                specialText = "A heat wave is going on today!";

            if (round <= random.Next(2, 5))
            {
                costLemonade = 5;
                costSign = 20;
            }
            else if (round <= random.Next(7, 10))
            {
                costLemonade = 10;
                costSign = 20;
            }
            else
            {
                costLemonade = random.Next(14, 16);
                costSign = random.Next(22, 25);
            }

            tbWeather.Text = "It is " + weather + "°C warm. There is a " + rainChance + "% chance of rain.";
            tbCosts.Text = "Lemonade costs " + costLemonade + " cents. A sign costs " + costSign + " cents.";
            tbSpecial.Text = specialText;
        }

        public int simulate()
        {
            glassesSold = 0;
            random = new Random();
            Int32 moneyEarned;

            visitProbability = random.Next(80, 120) * (Decimal.ToInt32(nudSigns.Value) * 20 + 1) * weather / Decimal.ToInt32(nudCost.Value);

            if (special == 23)
                visitProbability /= 10;
            if (special >= 24 && weather > 35)
                visitProbability *= 3;
            if (special == 22 && weather < 20)
                visitProbability = 0;

            visitProbability /= 100;

            if (visitProbability > 95)
                visitProbability = 95;

            for (int i = 0; i < Decimal.ToInt32(nudAmount.Value); i++)
            {
                if (random.Next(1, 101) <= visitProbability)
                {
                    glassesSold++;
                }
            }

            moneyEarned = glassesSold * (Decimal.ToInt32(nudCost.Value));
            moneyEarned -= (glassesSold * costLemonade);
            moneyEarned -= (Decimal.ToInt32(nudSigns.Value)) * costSign;

            if (random.Next(1, 101) <= rainChance)
            {
                moneyEarned = 0;
                moneyEarned -= (glassesSold * costLemonade);
                moneyEarned -= Decimal.ToInt32(nudSigns.Value) * costSign;
                hasRained = true;
            }
            else
            {
                hasRained = false;
            }

            return moneyEarned;
        }

        public int simulateAI()
        {
            glassesSold = 0;
            glassesSoldAI = 0;
            glassesMadeAI = 0;
            random = new Random();
            int signsAI;
            Int32 moneyEarned;
            Int32 moneyEarnedAI;
            int aiCost;

            aiCost = Decimal.ToInt32(nudCost.Value) - random.Next(0, 2);
            signsAI = (Decimal.ToInt32(nudSigns.Value) + 1);
            if (aiCost <= costLemonade + 1)
                aiCost = costLemonade + 1;
            visitProbability = random.Next(80, 120) * (Decimal.ToInt32(nudSigns.Value) * 20 + 1) * weather / Decimal.ToInt32(nudCost.Value);
            visitProbabilityAI = random.Next(80, 120) * (signsAI * 20 + 1) * weather / aiCost;
            aiAmount = weather / 8 * Convert.ToInt32(Convert.ToDouble(aiMoney / costLemonade) * 0.75) + (Decimal.ToInt32(nudCost.Value) / 10);
            if (blindAI)
            {
                aiCost = random.Next((costLemonade + 1), (costLemonade + 5));
                signsAI = (random.Next((weather / 25 - 1), (weather / 25 + 2)));
                if (signsAI < 0)
                    signsAI = 0;
                if (aiCost <= costLemonade + 1)
                    aiCost = costLemonade + 1;
                visitProbabilityAI = random.Next(80, 120) * (signsAI * 20 + 1) * weather / aiCost;
                aiAmount = weather / 8 * Convert.ToInt32(Convert.ToDouble(aiMoney / costLemonade) * 0.75) + random.Next(0, 16);
            }

            if (aiAmount > (aiMoney / costLemonade) - Convert.ToInt32(Convert.ToDouble(aiMoney / costLemonade) * 0.05))
                aiAmount = (aiMoney / costLemonade) - Convert.ToInt32(Convert.ToDouble(aiMoney / costLemonade) * 0.05);
            if (aiAmount < 10)
                aiAmount = 10;
            if (rainChance > random.Next(22, 31))
            {
                aiAmount /= 2;
                signsAI /= 2;
            }

            if (special == 23)
                visitProbability /= 10;
            if (special >= 24 && weather > 35)
                visitProbability *= 3;
            if (special == 22 && weather < 20)
                visitProbability = 0;

            visitProbability /= 100;
            visitProbabilityAI /= 100;

            if (visitProbability > 95)
                visitProbability = 95;
            if (visitProbabilityAI > 95)
                visitProbabilityAI = 95;

            if (sharedMarket)
            {
                if (visitProbability < visitProbabilityAI)
                    visitProbability -= ((visitProbabilityAI - visitProbability) * 2);
                if (visitProbability > visitProbabilityAI)
                    visitProbabilityAI -= ((visitProbability - visitProbabilityAI) * 2);
            }

            if (visitProbability < 0)
                visitProbability = 0;
            if (visitProbabilityAI < 0)
                visitProbabilityAI = 0;

            for (int i = 0; i < Decimal.ToInt32(nudAmount.Value); i++)
            {
                if (random.Next(1, 101) <= visitProbability)
                {
                    glassesSold++;
                }
            }
            for (int i = 0; i < aiAmount; i++)
            {
                if (random.Next(1, 101) <= visitProbabilityAI)
                {
                    glassesSoldAI++;
                }
            }

            moneyEarned = glassesSold * (Decimal.ToInt32(nudCost.Value));
            moneyEarned -= (glassesSold * costLemonade);
            moneyEarned -= (Decimal.ToInt32(nudSigns.Value)) * costSign;
            moneyEarnedAI = glassesSoldAI * aiCost;
            moneyEarnedAI -= (glassesSoldAI * costLemonade);
            moneyEarnedAI -= signsAI * costSign;

            if (random.Next(1, 101) <= rainChance)
            {
                moneyEarned = 0;
                moneyEarned -= (Decimal.ToInt32(nudAmount.Value) * costLemonade);
                moneyEarned -= (Decimal.ToInt32(nudSigns.Value) * costSign);
                moneyEarnedAI = 0;
                moneyEarnedAI -= (glassesSoldAI * costLemonade);
                moneyEarnedAI -= signsAI * costSign;
                hasRained = true;
            }
            else
            {
                hasRained = false;
            }

            returnMoneyEarned = moneyEarned;
            return moneyEarnedAI;
        }

        private void bAI_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            int difference;
            int differenceAI;

            if (((costLemonade * nudAmount.Value) + (costSign * nudSigns.Value)) > money)
            {
                MessageBox.Show("You don't have enough money for that.", "Not enough money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            differenceAI = simulateAI();
            difference = returnMoneyEarned;
            money += difference;
            aiMoney += differenceAI;
            result.setTextAI(difference, differenceAI, glassesSold, glassesSoldAI, Decimal.ToInt32(nudAmount.Value), aiAmount, aiMoney, hasRained);
            result.Show();
            recalculate();
            if (aiMoney <= 0)
            {
                MessageBox.Show("The AI went bankrupt. Stats will now be reset.", "You won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //restart restart = new restart();
                //restart.Show();
                //Application.DoEvents();
                //this.Close(); 
                Application.Restart();
            }
            if (money <= 0)
            {
                MessageBox.Show("You went bankrupt. Stats will now be reset.", "Bankrupt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //restart restart = new restart();
                //restart.Show();
                //Application.DoEvents();
                //this.Close(); 
                Application.Restart();
            }
            nudAmount.Value = 0;
            nudCost.Value = 1;
            nudSigns.Value = 0;
            tbDebrief.Text = "This will cost you " + ((costLemonade * nudAmount.Value) + (costSign * nudSigns.Value)) + " cents. You have " + money + " cents.";
        }

        private void bAlone_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            int difference;

            if (((costLemonade * nudAmount.Value) + (costSign * nudSigns.Value)) > money)
            {
                MessageBox.Show("You don't have enough money for that.", "Not enough money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            difference = simulate();
            result.setText(difference, glassesSold, Decimal.ToInt32(nudAmount.Value), hasRained);
            result.Show();
            money += difference;
            recalculate();
            nudAmount.Value = 0;
            nudCost.Value = 1;
            nudSigns.Value = 0;
            tbDebrief.Text = "This will cost you " + ((costLemonade * nudAmount.Value) + (costSign * nudSigns.Value)) + " cents. You have " + money + " cents.";
        }

        private void cbShareSteal_CheckedChanged(object sender, EventArgs e)
        {
            sharedMarket = cbShareSteal.Checked;
        }

        private void cbBlind_CheckedChanged(object sender, EventArgs e)
        {
            blindAI = cbBlind.Checked;
        }
    }
}
