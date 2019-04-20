/*
 *** Designer Notes 
 * Author Justin Lee Schnees
 * Website: jschnees.com
 
Added a background image. A generic green felt background from google. I did this to give it something extra.
You can find all the images in the "cardimages" folder located in the solutions folder.
Made the draw button disable when the game ends to prevent errors.

Below is the assignment objective and Acceptance Criteria.

The objectives of this lab assignment are as follows:

-Develop a Windows Forms Graphical User Interface (GUI).
-Implement the picture box control on a form.
-Work with files (images) external to the application.
-Work with arrays (multiple arrays).
-Work with arrays in parallel with one another.
-Work with nested for loops.
-Assignment User Story: As a user I want a new Windows application so that I can play a modified version of the card game called War.

Acceptance Criteria: 

-A Windows Forms GUI will be developed.
Required form controls include: 
-two PictureBox controls each holding the computer's and player's card, 
-two TextBox controls for the computer's and player's scores, 
-a TextBox control for the text status of the last hand dealt.
-In addition to the controls noted above, there will be three button controls: New Game, Draw,  and Close. 
-When the clicks New Game, all of the variables will be initialized and the deck of cards will be shuffled. 
-The Draw button will cause random cards to be drawn for both the computer and the user, and the code will determine which of the two cards represents the higher value awarding a point to the winning hand.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Schnees_Lab4
{
    public partial class WarForm : Form
    {
        // Global declarations
        Random rnd = new Random(); // generates a random number for variable rnd
        int scoreCPU, scoreUser, cardIndex, numberCPU, numberUser; // declares integers for player score (scoreCPU and scoreUser) and card picked for battle (numberCPU and numberUser)
        int[] cardNumber = new int[52]; // declares cardNumber as an value array
        Image[] picCards = new Image[52]; // delcares picCards as an indexed image array

        public WarForm()
        {
            InitializeComponent();
        }

        // indexed array of card images
        private void WarForm_Load(object sender, EventArgs e)
        {
            // indexed array of card images
            picCards[0] = Properties.Resources.p2;
            picCards[1] = Properties.Resources.p3;
            picCards[2] = Properties.Resources.p4;
            picCards[3] = Properties.Resources.p5;
            picCards[4] = Properties.Resources.p6;
            picCards[5] = Properties.Resources.p7;
            picCards[6] = Properties.Resources.p8;
            picCards[7] = Properties.Resources.p9;
            picCards[8] = Properties.Resources.p10;
            picCards[9] = Properties.Resources.pJ;
            picCards[10] = Properties.Resources.pQ;
            picCards[11] = Properties.Resources.pK;
            picCards[12] = Properties.Resources.pA;
            picCards[13] = Properties.Resources.c2;
            picCards[14] = Properties.Resources.c3;
            picCards[15] = Properties.Resources.c4;
            picCards[16] = Properties.Resources.c5;
            picCards[17] = Properties.Resources.c6;
            picCards[18] = Properties.Resources.c7;
            picCards[19] = Properties.Resources.c8;
            picCards[20] = Properties.Resources.c9;
            picCards[21] = Properties.Resources.c10;
            picCards[22] = Properties.Resources.cJ;
            picCards[23] = Properties.Resources.cQ;
            picCards[24] = Properties.Resources.cK;
            picCards[25] = Properties.Resources.cA;
            picCards[26] = Properties.Resources.r2;
            picCards[27] = Properties.Resources.r3;
            picCards[28] = Properties.Resources.r4;
            picCards[29] = Properties.Resources.r5;
            picCards[30] = Properties.Resources.r6;
            picCards[31] = Properties.Resources.r7;
            picCards[32] = Properties.Resources.r8;
            picCards[33] = Properties.Resources.r9;
            picCards[34] = Properties.Resources.r10;
            picCards[35] = Properties.Resources.rJ;
            picCards[36] = Properties.Resources.rQ;
            picCards[37] = Properties.Resources.rK;
            picCards[38] = Properties.Resources.rA;
            picCards[39] = Properties.Resources.s2;
            picCards[40] = Properties.Resources.s3;
            picCards[41] = Properties.Resources.s4;
            picCards[42] = Properties.Resources.s5;
            picCards[43] = Properties.Resources.s6;
            picCards[44] = Properties.Resources.s7;
            picCards[45] = Properties.Resources.s8;
            picCards[46] = Properties.Resources.s9;
            picCards[47] = Properties.Resources.s10;
            picCards[48] = Properties.Resources.sJ;
            picCards[49] = Properties.Resources.sQ;
            picCards[50] = Properties.Resources.sK;
            picCards[51] = Properties.Resources.sA;
        }

        // controls - textboxes and ui buttons
        private void ComputerWinsTextBox_TextChanged(object sender, EventArgs e)
        {
            // textbox for computer total wins
        }

        // textbox for player total wins
        private void PlayerWinsTextBox_TextChanged(object sender, EventArgs e)
        {
            // textbox for player total wins
        }

        // textbox to show who won the round
        private void WinTexBox_TextChanged(object sender, EventArgs e)
        {
            // textbox to show who won the round
        }

        // card image box for computer
        private void ComputerPictureBox_Click(object sender, EventArgs e)
        {
            // allows the user to call the RunGame function by clicking on the card instead of the button
            RunGame();
        }

        // card image box for player
        private void PlayerPictureBox_Click(object sender, EventArgs e)
        {
            // allows the user to call the RunGame function by clicking on the card instead of the button
            RunGame();
        }

        // Draw Card button
        private void DrawButton_Click(object sender, EventArgs e)
        {
            // RunGame function button. calls the function to run the random draw
            RunGame();
        }

        // New Game button
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // new game button. calls the function to create a new game
            NewGame();
        }

        // Close button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // button that closes the program
            this.Close();
        }

        // this function resets the current game and create a new game
        void NewGame()
        {
            ComputerWinsTextBox.Text = ""; // clear the computer score
            PlayerWinsTextBox.Text = ""; // clear the player score
            WinTexBox.Text = ""; // clear the who won the round texbox
            WinTexBox.Font = new Font("BankGothic Lt BT", 27); // resets the font size

            // sets the card to the original cardback for the computer
            ComputerPictureBox.Image = Schnees_Lab4.Properties.Resources.card;
            // sets the card to the original cardback for the player
            PlayerPictureBox.Image = Schnees_Lab4.Properties.Resources.card;

            scoreUser = 0; // resets the player score to 0
            scoreCPU = 0; // resets the computer score to 0
            cardIndex = 0; // resets the card index to 0

            DrawButton.Enabled = true; // re-enable the draw button on new game
            ComputerPictureBox.Enabled = true; // re-enable the computer card button at end of game
            PlayerPictureBox.Enabled = true; // re-enable the player card button at end of game

            GameOverLabel.Visible = false; // disables the "game over" label
        }

        // RunGame function calls the DrawCard function and then outputs the results
        void RunGame()
        {
            DrawCard(); // calls the DrawCard function that assigns card values and compares the two

            // Win: User gets a point for having the higher card value
            if (numberCPU > numberUser)
            {
                scoreCPU += 1; // incriment computer score by 1
                PlayerWinsTextBox.Text = scoreCPU.ToString();
                WinTexBox.Text = "You won";
            }
            // Lose: Computer gets a point for having the higher card value
            else if (numberCPU < numberUser)
            {
                scoreUser += 1; // incriment player score by 1
                ComputerWinsTextBox.Text = scoreUser.ToString();
                WinTexBox.Text = "You lost";
            }
            // Tie: User and computer get a point for having equal card values
            else
            {
                scoreUser++; // incriment player score by 1
                scoreCPU++; // incriment computer score by 1
                PlayerWinsTextBox.Text = scoreUser.ToString();
                ComputerWinsTextBox.Text = scoreCPU.ToString();
                WinTexBox.Text = "Tie";
            }

            cardIndex++; // incriment the card index count until it gets to 25, ending the game

            // Check if all cards have been drawn
            if (cardIndex > 25)
            {
                DrawButton.Enabled = false; // disables the draw button at end of game
                ComputerPictureBox.Enabled = false; // disables the computer card button at end of game
                PlayerPictureBox.Enabled = false; // disables the player card button at end of game
                GameOverLabel.Visible = true; // shows the "game over" label

                // if statements to show who won the game
                if (scoreUser > scoreCPU)
                {
                    // shrink font of the textbox to show the full message
                    WinTexBox.Font = new Font("BankGothic Lt BT", 15);
                    // shows if the player won the game
                    WinTexBox.Text = "Computer won the game!";
                }
                else if (scoreUser < scoreCPU)
                {
                    // shrink font of the textbox to show the full message
                    WinTexBox.Font = new Font("BankGothic Lt BT", 15);
                    // shows if the computer won the game
                    WinTexBox.Text = "You won the game!";
                }
                else
                {
                    // shrink font of the textbox to show the full message
                    WinTexBox.Font = new Font("BankGothic Lt BT", 15);
                    // shows both players tied
                    WinTexBox.Text = "You tied with the computer!";
                }
            }
        }
        //  DrawCard function that assigns card values and compares the two
        void DrawCard()
        {
            // Assign cards 1-52
            for (int i = 0; i < 52; i++)
            {
                cardNumber[i] = i;
            }

            // Shuffle the deck / numbers in the array by swapping random cards with the bottom card
            for (int remaining = 52; remaining >= 1; remaining--)
            {
                // Pick an item at random
                int itemPicked = rnd.Next(remaining);
                //int itemPicked = rnd.Next(remaining);
                // Swap picked item with bottom item
                int tempValue = cardNumber[itemPicked];
                cardNumber[itemPicked] = cardNumber[remaining - 1];
                cardNumber[remaining - 1] = tempValue;

                // Assign a card to each player
                numberUser = cardNumber[cardIndex]; // Player uses second half of 52-card deck
                numberCPU = cardNumber[cardIndex + 26]; // Computer uses second half of 52-card deck

                // Display image of assigned cards
                ComputerPictureBox.Image = picCards[numberUser];
                PlayerPictureBox.Image = picCards[numberCPU];

                // Assign new numbers based on suit and rank (A-10 and face cards)
                if (cardNumber[cardIndex] >= 0 && cardNumber[cardIndex] <= 12) numberUser = cardNumber[cardIndex];
                else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 25) numberUser = cardNumber[cardIndex] - 13;
                else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 38) numberUser = cardNumber[cardIndex] - 26;
                else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 51) numberUser = cardNumber[cardIndex] - 39;

                if (cardNumber[cardIndex + 26] >= 0 && cardNumber[cardIndex + 26] <= 12) numberCPU = cardNumber[cardIndex + 26];
                else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 25) numberCPU = cardNumber[cardIndex + 26] - 13;
                else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 38) numberCPU = cardNumber[cardIndex + 26] - 26;
                else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 51) numberCPU = cardNumber[cardIndex + 26] - 39;
            }

        }
    }

}
