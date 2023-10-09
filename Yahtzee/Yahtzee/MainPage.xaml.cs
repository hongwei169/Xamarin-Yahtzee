// Hong Wei Phang G00388774
using System;
using Xamarin.Forms;

namespace Yahtzee
{
    public partial class MainPage : ContentPage
    {
        //declares variables
        
        int total;
        int bonus = 35;
        int rolls = 3;

        //variables for dice roll
        int diceRoll1 = 0;
        int diceRoll2 = 0;
        int diceRoll3 = 0;
        int diceRoll4 = 0;
        int diceRoll5 = 0;

        //variables for upper scores
        int totalOne;
        int totalTwo;
        int totalThree;
        int totalFour;
        int totalFive;
        int totalSix;
        int upperTotal;

        //variables for lower scores
        int totalThreeOfAKind;
        int totalFourOfAKind;
        int totalHouse;
        int totalSmallStraight;
        int totalLargeStraight;
        int yahtzee;
        int totalChance;
        int lowerTotal;

        //boolean for all the buttons
        bool hold1 = true;
        bool hold2 = true;
        bool hold3 = true;
        bool hold4 = true;
        bool hold5 = true;

        bool keepOne = true;
        bool keepTwo = true;
        bool keepThree = true;
        bool keepFour = true;
        bool keepFive = true;
        bool keepSix = true;
        bool keepThreeOfAKind = true;
        bool keepFourOfAKind = true;
        bool keepFull = true;
        bool keepSmallStraight = true;
        bool keepLargeStraight = true;
        bool keepYahtzee = true;
        bool keepChance = true;

        //variables for random dice roll
        Random random;

        public MainPage()
        {
            InitializeComponent();
        }

        #region Create methods to calculate scores and totals
        /// <summary>
        /// gets the total of all the label scores and adds them
        ///  puts it in the total box
        /// </summary>
        private void UpperSection()
        {
            totalOne = 0;
            totalTwo = 0;
            totalThree = 0;
            totalFour = 0;
            totalFive = 0;
            totalSix = 0;

            //calculation for ones
            if (diceRoll1 == 1)
            {
                totalOne = totalOne + diceRoll1;
            }
            if (diceRoll2 == 1)
            {
                totalOne = totalOne + diceRoll2;
            }
            if (diceRoll3 == 1)
            {
                totalOne = totalOne + diceRoll3;
            }
            if (diceRoll4 == 1)
            {
                totalOne = totalOne + diceRoll4;
            }
            if (diceRoll5 == 1)
            {
                totalOne = totalOne + diceRoll5;
            }
            if (keepOne == true) oneValue.Text = totalOne.ToString();
            if (keepOne == true) oneValue.TextColor = Color.Red;


            //calculation for twos
            if (diceRoll1 == 2)
            {
                totalTwo = totalTwo + diceRoll1;
            }
            if (diceRoll2 == 2)
            {
                totalTwo = totalTwo + diceRoll2;
            }
            if (diceRoll3 == 2)
            {
                totalTwo = totalTwo + diceRoll3;
            }
            if (diceRoll4 == 2)
            {
                totalTwo = totalTwo + diceRoll4;
            }
            if (diceRoll5 == 2)
            {
                totalTwo = totalTwo + diceRoll5;
            }
            if (keepTwo == true) twoValue.Text = totalTwo.ToString();
            if (keepTwo == true) twoValue.TextColor = Color.Red;

            //calculation for threes
            if (diceRoll1 == 3)
            {
                totalThree = totalThree + diceRoll1;
            }
            if (diceRoll2 == 3)
            {
                totalThree = totalThree + diceRoll2;
            }
            if (diceRoll3 == 3)
            {
                totalThree = totalThree + diceRoll3;
            }
            if (diceRoll4 == 3)
            {
                totalThree = totalThree + diceRoll4;
            }
            if (diceRoll5 == 3)
            {
                totalThree = totalThree + diceRoll5;
            }
            if (keepThree == true) threeValue.Text = totalThree.ToString();
            if (keepThree == true) threeValue.TextColor = Color.Red;

            //calculation for fours
            if (diceRoll1 == 4)
            {
                totalFour = totalFour + diceRoll1;
            }
            if (diceRoll2 == 4)
            {
                totalFour = totalFour + diceRoll2;
            }
            if (diceRoll3 == 4)
            {
                totalFour = totalFour + diceRoll3;
            }
            if (diceRoll4 == 4)
            {
                totalFour = totalFour + diceRoll4;
            }
            if (diceRoll5 == 4)
            {
                totalFour = totalFour + diceRoll5;
            }
            if (keepFour == true) fourValue.Text = totalFour.ToString();
            if (keepFour == true) fourValue.TextColor = Color.Red;

            //calculation for fives
            if (diceRoll1 == 5)
            {
                totalFive = totalFive + diceRoll1;
            }
            if (diceRoll2 == 5)
            {
                totalFive = totalFive + diceRoll2;
            }
            if (diceRoll3 == 5)
            {
                totalFive = totalFive + diceRoll3;
            }
            if (diceRoll4 == 5)
            {
                totalFive = totalFive + diceRoll4;
            }
            if (diceRoll5 == 5)
            {
                totalFive = totalFive + diceRoll5;
            }
            if (keepFive == true) fiveValue.Text = totalFive.ToString();
            if (keepFive == true) fiveValue.TextColor = Color.Red;

            //calculation for sixes
            if (diceRoll1 == 6)
            {
                totalSix = totalSix + diceRoll1;
            }
            if (diceRoll2 == 6)
            {
                totalSix = totalSix + diceRoll2;
            }
            if (diceRoll3 == 6)
            {
                totalSix = totalSix + diceRoll3;
            }
            if (diceRoll4 == 6)
            {
                totalSix = totalSix + diceRoll4;
            }
            if (diceRoll5 == 6)
            {
                totalSix = totalSix + diceRoll5;
            }
            if (keepSix == true) sixValue.Text = totalSix.ToString();
            if (keepSix == true) sixValue.TextColor = Color.Red;

        }

        private void lowerSection()
        {
            totalThreeOfAKind = 0;
            totalFourOfAKind = 0;
            totalHouse = 0;
            totalSmallStraight = 0;
            totalLargeStraight = 0;
            yahtzee = 0;
            totalChance = 0;

            // use the upper section to calculate the lower section
            // calculation for ThreeOfAKind 
            if (totalOne == 3 || totalTwo == 6 || totalThree == 9 || totalFour == 12 || totalFive == 15 || totalSix == 18)
            {
                totalThreeOfAKind = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            if (keepThreeOfAKind == true) threeKindValue.Text = totalThreeOfAKind.ToString();
            if (keepThreeOfAKind == true) threeKindValue.TextColor = Color.Red;

            //calculation for FourOfAKind 
            if (totalOne == 4 || totalTwo == 8 || totalThree == 12 || totalFour == 16 || totalFive == 20 || totalSix == 24)
            {
                totalFourOfAKind = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            if (keepFourOfAKind == true) fourKindValue.Text = totalFourOfAKind.ToString();
            if (keepFourOfAKind == true) fourKindValue.TextColor = Color.Red;

            //calculation for full house
            if ((totalOne == 3 || totalTwo == 6 || totalThree == 9 || totalFour == 12 || totalFive == 15 || totalSix == 18)
                && (totalOne == 2 || totalTwo == 4 || totalThree == 6 || totalFour == 8 || totalFive == 10 || totalSix == 12))
            {
                totalHouse = 25;
            }
            if (keepFull == true) houseValue.Text = totalHouse.ToString();
            if (keepFull == true) houseValue.TextColor = Color.Red;

            // calculation for small straight
            if ((totalOne >= 1 && totalTwo >= 2 && totalThree >= 3 && totalFour >= 4) || (totalTwo >= 2 && totalThree >= 3 && totalFour >= 4 && totalFive >= 5)
                || (totalThree >= 3 && totalFour >= 4 && totalFive >= 5 && totalSix >= 6))
            {
                totalSmallStraight = 30;
            }
            if (keepSmallStraight == true) smallStraightValue.Text = totalSmallStraight.ToString();
            if (keepSmallStraight == true) smallStraightValue.TextColor = Color.Red;

            // calculation for large straight 
            if ((totalOne == 1 && totalTwo == 2 && totalThree == 3 && totalFour == 4 && totalFive == 5)
                || (totalTwo == 2 && totalThree == 3 && totalFour == 4 && totalFive == 5 && totalSix == 6))
            {
                totalLargeStraight = 40;
            }
            if (keepLargeStraight == true) largeStraightValue.Text = totalLargeStraight.ToString();
            if (keepLargeStraight == true) largeStraightValue.TextColor = Color.Red;

            // calculation for yahtzee 
            if (diceRoll1 == diceRoll2 && diceRoll2 == diceRoll3 && diceRoll3 == diceRoll4 && diceRoll4 == diceRoll5)
            {
                yahtzee = 50;
            }
            if (keepYahtzee == true) yahtzeeValue.Text = yahtzee.ToString();
            if (keepYahtzee == true) yahtzeeValue.TextColor = Color.Red;

            // calculation for chance 
            totalChance = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            if (keepChance == true) chanceValue.Text = totalChance.ToString();
            if (keepChance == true) chanceValue.TextColor = Color.Red;


        }
        #endregion

        #region  Create a random number generator that is used for the dice roll
        /// <summary>
        ///  Created rolls to count user dice 
        ///  Random generator for dice value
        ///  Displayed dice to user and called calculations
        /// </summary>
        private void BtnDiceRollClicked(object sender, EventArgs e)
        {
            //update the rolls left if user click roll buttons
            rolls--;

            // provide feedback to the user on what roll this is (label)
            Roll.Text = "Roll Dice - You have " + rolls + " throws left.";


            // generate random numbers betweeen 1 to 6
            if (random == null)
            {
                random = new Random();
            }

            if (hold1 == true) diceRoll1 = random.Next(1, 7);
            if (hold2 == true) diceRoll2 = random.Next(1, 7);
            if (hold3 == true) diceRoll3 = random.Next(1, 7);
            if (hold4 == true) diceRoll4 = random.Next(1, 7);
            if (hold5 == true) diceRoll5 = random.Next(1, 7);

            // assign them to the dice
            dice1.Text = diceRoll1.ToString();
            dice2.Text = diceRoll2.ToString();
            dice3.Text = diceRoll3.ToString();
            dice4.Text = diceRoll4.ToString();
            dice5.Text = diceRoll5.ToString();

            UpperSection();
            lowerSection();

            //let user only allows to roll 3 times by using if statement
            if(rolls == 0)
            {
                Roll.IsEnabled = false;
            }

        }
        #endregion

        #region Event Handlers for user clicks hold dice buttons
        /// <summary>
        /// check if user click the hold button without rolling dices, it will display alert
        /// If user clicks the hold button, it will hold the dice from changing value on next roll
        /// </summary>
        private async void btnHold1_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
            else
            {
                if (hold1)
                {
                    hold1 = false;
                    btnHold1.BackgroundColor = Color.Red;
                    btnHold1.Text = "Held";
                }
                else
                {
                    hold1 = true;
                    btnHold1.BackgroundColor = Color.Gray;
                    btnHold1.Text = "Hold";
                }
            }
        }

        private async void btnHold2_Clicked(object sender, EventArgs e)
        {
            if (diceRoll2 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
            else
            {
                if (hold2)
                {
                    hold2 = false;
                    btnHold2.BackgroundColor = Color.Red;
                    btnHold2.Text = "Held";
                }
                else
                {
                    hold2 = true;
                    btnHold2.BackgroundColor = Color.Gray;
                    btnHold2.Text = "Hold";
                }
            }
        }

        private async void btnHold3_Clicked(object sender, EventArgs e)
        {
            if (diceRoll3 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
            else
            {
                if (hold3)
                {
                    hold3 = false;
                    btnHold3.BackgroundColor = Color.Red;
                    btnHold3.Text = "Held";
                }
                else
                {
                    hold3 = true;
                    btnHold3.BackgroundColor = Color.Gray;
                    btnHold3.Text = "Hold";
                }
            }

        }

        private async void btnHold4_Clicked(object sender, EventArgs e)
        {
            if (diceRoll4 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
            else
            {
                if (hold4)
                {
                    hold4 = false;
                    btnHold4.BackgroundColor = Color.Red;
                    btnHold4.Text = "Held";
                }
                else
                {
                    hold4 = true;
                    btnHold4.BackgroundColor = Color.Gray;
                    btnHold4.Text = "Hold";
                }
            }

        }

        private async void btnHold5_Clicked(object sender, EventArgs e)
        {
            if (diceRoll5 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
            else
            {
                if (hold5)
                {
                    hold5 = false;
                    btnHold5.BackgroundColor = Color.Red;
                    btnHold5.Text = "Held";
                }
                else
                {
                    hold5 = true;
                    btnHold5.BackgroundColor = Color.Gray;
                    btnHold5.Text = "Hold";
                }
            }
        }
        #endregion

        #region Event Handlers for user clicks keep score buttons
        /// <summary>
        /// if button clicked adds to toals and reset dice and resets hold and checks if its end of the game
        /// </summary>
        private async void btnOne_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                oneValue.TextColor = Color.Black;
                total = totalOne + total;
                btnOne.IsEnabled = false;
                upperTotal = upperTotal + totalOne;
                keepOne = false;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
            }
            else
            {
                // user has not rolled dice therefore no combos can be calculated
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnTwo_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                twoValue.TextColor = Color.Black;
                total = totalTwo + total;
                btnTwo.IsEnabled = false;
                upperTotal = upperTotal + totalTwo;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepTwo = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnThree_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                threeValue.TextColor = Color.Black;
                total = totalThree + total;
                btnThree.IsEnabled = false;
                upperTotal = upperTotal + totalThree;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepThree = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnFour_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                fourValue.TextColor = Color.Black;
                total = totalFour + total;
                btnFour.IsEnabled = false;
                upperTotal = upperTotal + totalFour;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepFour = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnFive_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                fiveValue.TextColor = Color.Black;
                total = totalFive + total;
                btnFive.IsEnabled = false;
                upperTotal = upperTotal + totalFive;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepFive = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnSix_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                sixValue.TextColor = Color.Black;
                total = totalSix + total;
                btnSix.IsEnabled = false;
                upperTotal = upperTotal + totalSix;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepSix = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnThreeKind_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                threeKindValue.TextColor = Color.Black;
                total = totalThreeOfAKind + total;
                btnThreeKind.IsEnabled = false;
                lowerTotal = lowerTotal + totalThreeOfAKind;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepThreeOfAKind = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnFourKind_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                fourKindValue.TextColor = Color.Black;
                total = totalFourOfAKind + total;
                btnFourKind.IsEnabled = false;
                lowerTotal = lowerTotal + totalFourOfAKind;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepFourOfAKind = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnHouse_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                houseValue.TextColor = Color.Black;
                total = totalHouse + total;
                btnHouse.IsEnabled = false;
                lowerTotal = lowerTotal + totalHouse;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepFull = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnSmallStraight_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                smallStraightValue.TextColor = Color.Black;
                total = totalSmallStraight + total;
                btnSmallStraight.IsEnabled = false;
                lowerTotal = lowerTotal + totalSmallStraight;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepSmallStraight = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnLargeStraight_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                largeStraightValue.TextColor = Color.Black;
                total = totalLargeStraight + total;
                btnLargeStraight.IsEnabled = false;
                lowerTotal = lowerTotal + totalLargeStraight;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepLargeStraight = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnYahtzee_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                yahtzeeValue.TextColor = Color.Black;
                total = yahtzee + total;
                btnYahtzee.IsEnabled = false;
                lowerTotal = lowerTotal + yahtzee;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepYahtzee = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }

        private async void btnChance_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                chanceValue.TextColor = Color.Black;
                total = totalChance + total;
                btnChance.IsEnabled = false;
                lowerTotal = lowerTotal + totalChance;
                updateLower();
                resetDice();
                resetHold();
                endGame();
                keepChance = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet. Please click ROLL DICE button to roll your dices.", "Ok");
            }
        }
        #endregion

        #region Methods to update upper and lower total ,reset all the buttons and restart the game
        // updates upperTotal
        private void updateUpper()
        {
            if (upperTotal >= 63) total = bonus + total;
            userTotal.Text = "Total: " + total;
            userBonus.Text = "Get total of 63: " + upperTotal;
            lblUpperTotal.Text = "Upper Total: " + upperTotal;
        }

        // Updates lowerTotal
        private void updateLower()
        {
            userTotal.Text = "Total: " + total;
            lblLowerTotal.Text = "Lower Total: " + lowerTotal;
        }

        // reset the dice rolls status after cliking keep button for scores
        private void resetHold()
        {
            btnHold1.BackgroundColor = Color.DimGray;
            btnHold2.BackgroundColor = Color.DimGray;
            btnHold3.BackgroundColor = Color.DimGray;
            btnHold4.BackgroundColor = Color.DimGray;
            btnHold5.BackgroundColor = Color.DimGray;
            btnHold1.Text = "Hold";
            btnHold2.Text = "Hold";
            btnHold3.Text = "Hold";
            btnHold4.Text = "Hold";
            btnHold5.Text = "Hold";
            hold1 = true;
            hold2 = true;
            hold3 = true;
            hold4 = true;
            hold5 = true;
        }


        // reset dice and rolls after cliking keep button for scores
        private void resetDice()
        {
            diceRoll1 = 0;
            diceRoll2 = 0;
            diceRoll3 = 0;
            diceRoll4 = 0;
            diceRoll5 = 0;

            rolls = 3;
            Roll.IsEnabled = true;
            Roll.Text = "ROLL DICE";

            dice1.Text = diceRoll1.ToString();
            dice2.Text = diceRoll2.ToString();
            dice3.Text = diceRoll3.ToString();
            dice4.Text = diceRoll4.ToString();
            dice5.Text = diceRoll5.ToString();
        }

        //reset all totals and scores
        private void resetTotal()
        {
            //Upper section
            totalOne = 0;
            totalTwo = 0;
            totalThree = 0;
            totalFour = 0;
            totalFive = 0;
            totalSix = 0;
            upperTotal = 0;

            //Lower Secetion
            totalThreeOfAKind = 0;
            totalFourOfAKind = 0;
            totalHouse = 0;
            totalSmallStraight = 0;
            totalLargeStraight = 0;
            yahtzee = 0;
            totalChance = 0;
            lowerTotal = 0;

            oneValue.Text = totalOne.ToString();
            twoValue.Text = totalTwo.ToString();
            threeValue.Text = totalThree.ToString();
            fourValue.Text = totalFour.ToString();
            fiveValue.Text = totalFive.ToString();
            sixValue.Text = totalSix.ToString();
            lblUpperTotal.Text = "Upper Total: 0";


            threeKindValue.Text = totalThreeOfAKind.ToString();
            fourKindValue.Text = totalFourOfAKind.ToString();
            houseValue.Text = totalHouse.ToString();
            smallStraightValue.Text = totalSmallStraight.ToString();
            largeStraightValue.Text = totalLargeStraight.ToString();
            yahtzeeValue.Text = yahtzee.ToString();
            chanceValue.Text = totalChance.ToString();
            lblLowerTotal.Text = "Lower Total: 0";

            total = 0;
            bonus = 0;
            userTotal.Text = "Total: " + total;
            userBonus.Text = "Get total of 63: " + bonus;

            //reset colour text
            oneValue.TextColor = Color.Black;
            twoValue.TextColor = Color.Black;
            threeValue.TextColor = Color.Black;
            fourValue.TextColor = Color.Black;
            fiveValue.TextColor = Color.Black;
            sixValue.TextColor = Color.Black;
            threeKindValue.TextColor = Color.Black;
            fourKindValue.TextColor = Color.Black;
            houseValue.TextColor = Color.Black;
            smallStraightValue.TextColor = Color.Black;
            largeStraightValue.TextColor = Color.Black;
            yahtzeeValue.TextColor = Color.Black;
            chanceValue.TextColor = Color.Black;
        }

        //resets the game
        private void resetGame()
        {
            resetDice();
            resetHold();
            resetTotal();

            btnOne.IsEnabled = true;
            btnTwo.IsEnabled = true;
            btnThree.IsEnabled = true;
            btnFour.IsEnabled = true;
            btnFive.IsEnabled = true;
            btnSix.IsEnabled = true;
            btnThreeKind.IsEnabled = true;
            btnFourKind.IsEnabled = true;
            btnHouse.IsEnabled = true;
            btnSmallStraight.IsEnabled = true;
            btnLargeStraight.IsEnabled = true;
            btnYahtzee.IsEnabled = true;
            btnChance.IsEnabled = true;
            keepOne = true;
            keepTwo = true;
            keepThree = true;
            keepFour = true;
            keepFive = true;
            keepSix = true;
            keepThreeOfAKind = true;
            keepFourOfAKind = true;
            keepFull = true;
            keepLargeStraight = true;
            keepSmallStraight = true;
            keepYahtzee = true;
            keepChance = true;
        }

        //Create a new game when clicking new game button
        private async void NewGame_Clicked(object sender, EventArgs e)
        {
            var confirmed = await DisplayAlert("Confirm", "Confirm to start new game? Click YES for new game, NO for continue", "YES", "NO");
            if (confirmed)
            {
                resetGame();
            }
        }

        //checks if all the scores button clicked. It will display the total scores and end the game.
        private async void endGame()
        {
            if (btnOne.IsEnabled == false && btnTwo.IsEnabled == false && btnThree.IsEnabled == false && btnFour.IsEnabled == false && btnFive.IsEnabled == false && btnSix.IsEnabled == false
                && btnThreeKind.IsEnabled == false && btnFourKind.IsEnabled == false && btnHouse.IsEnabled == false && btnSmallStraight.IsEnabled == false && btnLargeStraight.IsEnabled == false
                && btnYahtzee.IsEnabled == false && btnChance.IsEnabled == false)
            {
                await DisplayAlert("GAME FINISHED", "Your Total score was " + total + ". \nYou scored " + lowerTotal + " in the Lower Section.\nYou scored " + upperTotal + " in the Upper Section.", "Play again");
                resetGame();
            }
        }
        #endregion

    }//End of public partial class MainPage : ContentPage
}//End namespace Yahtzee
