using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeGameForm
{
    public partial class Form1 : Form
    {
        //creating instance of Dice class
        private Dice DiceTime; //declaring object of Dice
        private ScoreCard CalculateScores;  //declaring object of ScoreCard to calculate scores
        private ScoreCard ActualScores;  //declaring object of ScoreCard to hold scores

        System.ComponentModel.ComponentResourceManager resources; 

        public Form1()
        {     

            InitializeComponent();

            //initializing objects
            DiceTime = new Dice(new RandomWrapper()); 
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CalculateScores = new ScoreCard(DiceTime);
            ActualScores = new ScoreCard(DiceTime);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDice1Hold_Click(object sender, EventArgs e)
        {

        }

        public void buttonRoll_Click(object sender, EventArgs e)
        {
            //check boxes get value of check boxes
            DiceTime.HoldDie1 = checkBoxHold1.Checked;
            DiceTime.HoldDie2 = checkBoxHold2.Checked;
            DiceTime.HoldDie3 = checkBoxHold3.Checked;
            DiceTime.HoldDie4 = checkBoxHold4.Checked;
            DiceTime.HoldDie5 = checkBoxHold5.Checked;

            //roll the dice
            DiceTime.Roll();
            label1.Text = DiceTime.GetDieValue(1).ToString();
            label2.Text = DiceTime.GetDieValue(2).ToString();
            label3.Text = DiceTime.GetDieValue(3).ToString();
            label4.Text = DiceTime.GetDieValue(4).ToString();
            label5.Text = DiceTime.GetDieValue(5).ToString();
            SetDieImage(DiceTime.GetDieValue(1), pictureDie1);
            SetDieImage(DiceTime.GetDieValue(2), pictureDie2);
            SetDieImage(DiceTime.GetDieValue(3), pictureDie3);
            SetDieImage(DiceTime.GetDieValue(4), pictureDie4);
            SetDieImage(DiceTime.GetDieValue(5), pictureDie5);

            //calculating ones through sixes and total of upper numbers
            CalculateScores.CalculateOnes(DiceTime);
            CalculateScores.CalculateTwos(DiceTime);
            CalculateScores.CalculateThrees(DiceTime);
            CalculateScores.CalculateFours(DiceTime);
            CalculateScores.CalculateFives(DiceTime);
            CalculateScores.CalculateSixes(DiceTime);
            ActualScores.UpperTotal += CalculateScores.CalculateUpperTotal(DiceTime);

            //calculate lower numbers
            ActualScores.ThreeOfAKind = CalculateScores.CalculateThreeOfAKind(DiceTime);
            CalculateScores.CalculateFourOfAKind(DiceTime);
            CalculateScores.CalculateFullHouse(DiceTime);
            CalculateScores.CalculateSmallStraight(DiceTime);
            CalculateScores.CalculateLargeStraight(DiceTime);
            CalculateScores.CalculateYahtzee(DiceTime);
            CalculateScores.CalculateChance(DiceTime);
            ActualScores.LowerTotal += CalculateScores.CalculateLowerTotal();



            //printing labels to form for ones through sixes and upper total
            if (buttonScoreOnes.Enabled)
            { labelOnes.Text = CalculateScores.Ones.ToString(); }

            if (buttonScoreTwos.Enabled)
            { labelTwos.Text = CalculateScores.Twos.ToString(); }

            if (buttonScoreThrees.Enabled)
            { labelThrees.Text = CalculateScores.Threes.ToString(); }

            if (buttonScoreFours.Enabled)
            { labelFours.Text = CalculateScores.Fours.ToString(); }

            if (buttonScoreFives.Enabled)
            { labelFives.Text = CalculateScores.Fives.ToString(); }

            if (buttonScoreSixes.Enabled)
            {   labelSixes.Text = CalculateScores.Sixes.ToString(); }


            //printing upper total
            labelActualUpperTotal.Text = CalculateScores.UpperTotal.ToString();

            //printing labels to form lower numbers
            if (buttonScoreThreeOfAKind.Enabled)
                labelThreeOfAKind.Text = CalculateScores.ThreeOfAKind.ToString();

            if (buttonScoreFourOfAKind.Enabled)
                labelFourOfAKind.Text = CalculateScores.FourOfAKind.ToString();

            if (buttonScoreSixes.Enabled)
                labelFullHouse.Text = CalculateScores.FullHouse.ToString();

            if (buttonScoreSmallStraight.Enabled)
                labelSmallStraight.Text = CalculateScores.SmallStraight.ToString();

            if (buttonScoreLargeStraight.Enabled)
                labelLargeStraight.Text = CalculateScores.LargeStraight.ToString();

            if (buttonScoreChance.Enabled)
                labelChance.Text = CalculateScores.Chance.ToString();

            if (buttonScoreYahtzee.Enabled)
                labelYahtzee.Text = CalculateScores.Yahtzee.ToString();


            if (ActualScores.UpperTotal > 63)
            {
                int bonus;
                ActualScores.TotalScore += 35;

                bonus = ActualScores.TotalScore;
            }


            //not actually using
            labelActualLowerTotal.Text = ActualScores.LowerTotal.ToString();

        }
        //setting the dice images with the rolls
        private void SetDieImage(int dieValue, PictureBox pictureBox)
        {
            switch (dieValue)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources.Dice6;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        //method to uncheck check boxes and set dice status to not held
        private void SetHoldCheckBoxesToFalse()
        {  
            //check box set to unchecked
            checkBoxHold1.Checked = false;
            checkBoxHold2.Checked = false;
            checkBoxHold3.Checked = false;
            checkBoxHold4.Checked = false;
            checkBoxHold5.Checked = false; 
        }

        private void buttonScoreOnes_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Ones;
            buttonScoreOnes.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
            

        }

        private void buttonScoreTwos_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Twos;
            buttonScoreTwos.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreThrees_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Threes;
            buttonScoreThrees.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreFours_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Fours;
            buttonScoreFours.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreFives_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Fives;
            buttonScoreFives.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreSixes_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Sixes;
            buttonScoreSixes.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreThreeOfAKind_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.ThreeOfAKind;
            buttonScoreThreeOfAKind.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
            labelThreeOfAKind.Text = ActualScores.ThreeOfAKind.ToString();
        }

        private void buttonScoreFourOfAKind_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.FourOfAKind;
            buttonScoreFourOfAKind.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonSCoreFullHouse_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.FullHouse;
            buttonSCoreFullHouse.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreSmallStraight_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.SmallStraight;
            buttonScoreSmallStraight.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreLargeStraight_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.LargeStraight;
            buttonScoreLargeStraight.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreYahtzee_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Yahtzee;
            buttonScoreYahtzee.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void buttonScoreChance_Click(object sender, EventArgs e)
        {
            ActualScores.TotalScore += CalculateScores.Chance;
            buttonScoreChance.Enabled = false;
            labelActualTotalScore.Text = ActualScores.TotalScore.ToString();
            DiceTime.RollCount = 0;
            SetHoldCheckBoxesToFalse();
            DiceTime.SetHoldDiceStatusToFalse();
        }

        private void checkBoxHold4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
