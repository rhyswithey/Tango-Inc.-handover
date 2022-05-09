using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAstronomicalProcessing.handover
{
    // Rhys Withey: 30015888
    // Team: Joseph, Rhys 
    // 18/04/2022
    // Tango Inc. Handover Astronomical Processing
    public partial class TangoInc : Form
    #region Sprint One
    {
        //set the array including size, set sorted boolean

        public TangoInc()
        {
            InitializeComponent();
        }
        static int maxArraySize = 24;
        int[] myNumbers = new int[maxArraySize];

        // Set the array values randomly (10-99) Random(); feature
        private void InitiliseArray()
        {
            Random random = new Random();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                myNumbers[x] = random.Next(10, 100);
            }
        }
        //Send the array calues to the listbox (Arraybox)
        private void DisplayArray()
        {
            ArrayBox.Items.Clear();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                ArrayBox.Items.Add(myNumbers[x]);
            }
        }        
        // Use binary search to find users input. Display found or a error message
        private void FindButton_Click(object sender, EventArgs e)
        {
            int minNum = 0;
            int maxNum = myNumbers.Length;
            int key = int.Parse(InputBox.Text);
            // user sorts find chops list and seaches until found
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == myNumbers[mid])
                {
                    InputBox.Clear();
                    InputBox.Focus();
                    StatusLabel.Text = "Found: " + key + "    *Binary Search(search 1) *";
                    break;
                }
                else if (key < myNumbers[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            //Check if not found and display message
            for (int x = 0; x < myNumbers.Length; x++)
            {
                int mid = (minNum + maxNum) / 2;

                if (key != myNumbers[mid])
                {
                    StatusLabel.Text = "NOT Found: " + key + "    *Binary Search(search 1) *"; 
                    break;
                }
            }
        }

        // User delete's array item then can replace that iteam with input
        private void EditButton_Click(object sender, EventArgs e)
        {
            // if the item is deleted (0) user can input new value
            if (!string.IsNullOrEmpty(InputBox.Text))
            {
                for (int x = 0; x < myNumbers.Length; x++)
                {
                    if (myNumbers[x] == 0)
                    {
                        myNumbers[x] = int.Parse(InputBox.Text);
                        break;
                    }
                }
            }
            else
            {
                StatusLabel.Text = "Delete number then enter a integer";
                   
            }
            DisplayArray();
            // input not empty
            // find element = 0
            // add item to that cell
            // display
        }
        // initilise the array and display it to the Arraybox (listbox)
        // Ask if they would like to sort first since some features need the array sorted, this prevents potential errors.
        // if they click no on the tip message it wont sort it for them
        private void Initilise_Click(object sender, EventArgs e)
        {
            InitiliseArray();
            DisplayArray();
        }
        public void TangoInc_Load(object sender, EventArgs e)
        {
            DisplayArray();
        }
        // user selects one array item then presses delete button to set it to 0 where they can add their own number or keep it at 0
        private void DeletButton_Click(object sender, EventArgs e)
        {
            // selected item set value '0'
            if (ArrayBox.SelectedIndex != -1)
            {
                string currentItem = ArrayBox.SelectedItem.ToString();
                int itemIndex = ArrayBox.FindString(currentItem);

                myNumbers[itemIndex] = 0;
                InputBox.Clear();
                InputBox.Focus();
                DisplayArray();
            }
            else
            {
                StatusLabel.Text = "Select item from";
            }
            DisplayArray();
        }        
        // key down / clears / delete fearture
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                InputBox.Clear();
                InputBox.Focus();
            }
        }
        // Select items in the list box (Arraybox)
        private void ArrayBox_Click(object sender, EventArgs e)
        {
            // Select number from array and assign that a value
            if (ArrayBox.SelectedIndex != -1)
            {
                string currentItem = ArrayBox.SelectedItem.ToString();
                int itemIndex = ArrayBox.FindString(currentItem);
                InputBox.Text = myNumbers[itemIndex].ToString();
            }
            else
            {
                StatusLabel.Text = "Select from list";
            }
        }
        // bubble sort items check if next number is bigger < and if so psuh it down the list until all are sorted.
        private void BubbleSort_Click(object sender, EventArgs e)
        {
            {
                // push larger numbers down list
                for (int x = 0; x < myNumbers.Length - 1; x++)
                {
                    for (int y = 0; y < myNumbers.Length - 1; y++)
                    {
                        if (myNumbers[y] > myNumbers[y + 1])
                        {
                            int temp = myNumbers[y + 1];
                            myNumbers[y + 1] = myNumbers[y];
                            myNumbers[y] = temp;

                        }
                    }
                }
                DisplayArray();
            }
        }
        #endregion

        #region Sprint Two
        // count the sum of numbers (i++) then / by 24 (the arrays size (.length)
        // make average display to 2 deciaml spaces
        private void Average_Click(object sender, EventArgs e)
        {

            int i;
            double sum = 0.00;
            double average = 0.00;

            for (i = 0; i < myNumbers.Length; i++)
            {
                sum += myNumbers[i];
            }

            average = (double)sum / myNumbers.Length;
            AverageBox.Text = (average).ToString("#.##");
                       
        }
       
        // after user sorts take the last number[23] (largest) from the first[0]
        // remember to remind the user to sort before using calculations
        // could auto sort when clicking Initilising to make it easier
        // array length is 0-23 != 1-24
        private void Range_Click(object sender, EventArgs e)
        {
            double range = myNumbers[23] - myNumbers[0];

            RangeBox.Text = (range).ToString("#.##");
                       
        }
        // user must sort
        // check if next number == and count how many times the number shows
        // display the number with the biggest count 

        private void Mode_Click(object sender, EventArgs e)
        {
            int number = myNumbers[0];
            int mode = number;
            int count = 1;
            int countMode = 1;

            for (int i = 1; i < 24; i++)
            {
                if (myNumbers[i] == number)
                {
                    ++count;
                }
                else
                {
                    if (count > countMode)
                    {
                        countMode = count;
                        mode = number;
                    }
                    count = 1;
                    number = myNumbers[i];
                }
                ModeBox.Text = (mode).ToString("#.##");                               
            }
        }
        // mid-extreme = mid-range
        // bimdas** msut have the adition in brackets
        // smallest + largest / 2
        private void Midextreme_Click(object sender, EventArgs e)
        {
            double midex = (myNumbers[0] + myNumbers[23]) / 2.0;
            MidBox.Text = (midex).ToString("#.##");
        }
        // i++ until the user input == mynumbers[i]
        // Displays found + the number thats found
        // displays Input error if not
        // one if() one for()
        private void SequentialSearch_Click(object sender, EventArgs e)
        {

            int key = int.Parse(InputBox.Text);
            for (int i = 0; i < myNumbers.Length; i++)
            {
                if (myNumbers[i] == key)
                {
                    StatusLabel.Text = "Found: " + key + "    *Sequential Search (search 2)* ";
                    break;
                }
                else if (key < myNumbers[i])
                {
                    StatusLabel.Text = " NOT Found: " + key + "    *Sequential Search (search 2)*";
                    break;
                }
            }
            DisplayArray();

        }      
    }
}
#endregion