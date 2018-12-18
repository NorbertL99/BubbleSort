// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                               // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class MainWindow : Form
    {
        int[] randomNumbers = new int[6];                                                       // This table store generated random numbers
        int[] numbersToSort = new int[6];                                                       // This table store numbers to sort
        public MainWindow()                                                                     // This method run when window open
        {
            InitializeComponent();                                                              // Initialize window components
        }
        // This method is used to generate random numbers to sort
        private void generateButton_Click(object sender, EventArgs e)                           // This method run when generateButton click 
        {
            Random random = new Random();                                                       // Creating new object of Random class
            for(int i = 0; i < 6; i++)                                                          // This loop doing 6 repeats
            {
                randomNumbers[i] = random.Next(1, 99);                                          // For each index in table generating numbers
            }
            numbersToSort = randomNumbers;                                                      // Seting value of table numbersToSort with generated numbers
            refreshLabelsWithNumbers();                                                         // Refreshing labels
        }
        // This method is used to start sorting algorithm
        private async void sortButton_Click(object sender, EventArgs e)                         // This method run when sortButton click
        {
            generateButton.Enabled = false;                                                     // Disable button
            sortButton.Enabled = false;                                                         // Disable button
            delayTextBox.Enabled = false;                                                       // Disable TextBox
            int delay = Convert.ToInt32(delayTextBox.Text);                                     // Set value of delay variable with delay given by user
            #region Bubble sort algorithm
            int temporary = 0;                                                                  // Create temporary helping variable, with will store value of changing index
            for (int i = 0; i < numbersToSort.Length; i++)                                      // This loop doing as many times as many elements in table to sort
            {
                for (int j = 0; j < numbersToSort.Length - 1; j++)                              // This loop doing as many times as many elements in table to sort - 1
                {
                    if (numbersToSort[j] > numbersToSort[j + 1])                                // If current index is biger than current index + 1
                    {
                        temporary = numbersToSort[j + 1];                                       // Temporary value set as a value from current sorting index + 1
                        numbersToSort[j + 1] = numbersToSort[j];                                // Next index from current value is a value of current index
                        numbersToSort[j] = temporary;                                           // Current index is a value from temporary variable so a value with was in current index + 1 before
                    }
                    refreshLabelsWithNumbers();                                                 // ITS NOT PART OF ALGORITHM ! Refreshing labels                                                                     
                    await Task.Delay(delay);                                                    // ITS NOT PART OF ALGORITHM ! Waiting for given by user delay
                }
            }
            #endregion
            generateButton.Enabled = true;                                                      // Enable button
            sortButton.Enabled = true;                                                          // Enable button
            delayTextBox.Enabled = true;                                                        // Enable TextBox
            MessageBox.Show("Sorting ended successfull", "Inforamtion",                         // Inform user about sorting ended
                MessageBoxButtons.OK, MessageBoxIcon.Information);                              // Set buttons and icon of messagebox
        }
        // This method refreshing labels with numbers
        private void refreshLabelsWithNumbers()
        {
            numberOne.Text = numbersToSort[0].ToString();                                       // Seting numbers as a text of labels
            numberTwo.Text = numbersToSort[1].ToString();                                       // Seting numbers as a text of labels
            numberThree.Text = numbersToSort[2].ToString();                                     // Seting numbers as a text of labels
            numberFour.Text = numbersToSort[3].ToString();                                      // Seting numbers as a text of labels
            numberFive.Text = numbersToSort[4].ToString();                                      // Seting numbers as a text of labels
            numberSix.Text = numbersToSort[5].ToString();                                       // Seting numbers as a text of labels
        }
    }
}
