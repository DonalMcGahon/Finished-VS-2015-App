using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<String> _DrinkDes;

        public MainPage()
        {
            this.InitializeComponent();
            setupListsOfDescription();
        }

        private void setupListsOfDescription()
        {
            if (_DrinkDes != null)
            {
                return;
            }
            _DrinkDes = new List<string>();

            _DrinkDes.Add("Soft Drink");
            _DrinkDes.Add("Wine");
            _DrinkDes.Add("Beer");
            _DrinkDes.Add("Spirit");

            int i;
            TextBlock curr;
            for (i = 0; i <= 4; i++)
            {
                curr = (TextBlock)pvtDrinks.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _DrinkDes[i];
                }
            }
        }

        // Buttons for Soft Drink Bottles
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Fanta";
            textBlock.Text = "250 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  73mg    3 %\nTotal Carbs.    62.5g   21 %\nDietary Fiber   0g  0 %\nSugars  62.5g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "69mins Walking\n29mins Jogging\n21mins Swimming\n38mins Cycling";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Classic Coca-Cola";
            textBlock.Text = "202 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  69mg    3 %\nTotal Carbs.    56.3g   19 %\nDietary Fiber   0g  0 %\nSugars  56.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "56mins Walking\n23mins Jogging\n17mins Swimming\n31mins Cycling";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Pepsi";
            textBlock.Text = "211 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  42mg    2 %\nTotal Carbs.    57.7g   19 %\nDietary Fiber   0g  0 %\nSugars  57.7g\nProtein 0g\nPotassium   14.1mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "59mins Walking\n24mins Jogging\n18mins Swimming\n32mins Cycling";
        }

        private void button01_Click(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Club Orange";
            textBlock.Text = "203 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  84mg    3 %\nTotal Carbs.    54.7g   19 %\nDietary Fiber   0g  0 %\nSugars  54.1g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "59mins Walking\n24mins Jogging\n18mins Swimming\n32mins Cycling";
        }

        private void button02_Cidona(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Cidona";
            textBlock.Text = "115 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  42mg    3 %\nTotal Carbs.    50.3g   19 %\nDietary Fiber   0g  0 %\nSugars  50.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "32mins Walking\n13mins Jogging\n10mins Swimming\n18mins Cycling";
        }

        private void button02_DrPepper(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Dr.Pepper";
            textBlock.Text = "211 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  84mg    4 %\nTotal Carbs.    55.7g   19 %\nDietary Fiber   0g  0 %\nSugars  54.1g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "59mins Walking\n24mins Jogging\n18mins Swimming\n32mins Cycling";
        }

        private void button03_DietCoke(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Diet Coke";
            textBlock.Text = "2 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  58mg    2 %\nTotal Carbs.    0.2g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.3g\nProtein 0g\nPotassium   25mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "1mins Walking\n0mins Jogging\n0mins Swimming\n0mins Cycling";
        }

        private void button04_Lucazade(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Lucozade";
            textBlock.Text = "366 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  69mg    3 %\nTotal Carbs.    56.3g   19 %\nDietary Fiber   0g  0 %\nSugars  56.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "101mins Walking\n42mins Jogging\n30mins Swimming\n56mins Cycling";
        }

        private void button05_Ribeana(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Ribena";
            textBlock.Text = "206 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  59mg    3 %\nTotal Carbs.    56.6g   19 %\nDietary Fiber   0g  0 %\nSugars  54.2g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "57mins Walking\n23mins Jogging\n17mins Swimming\n31mins Cycling";
        }

        private void button06_Sprite(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Sprite";
            textBlock.Text = "208 Calories per 500mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  94mg    3 %\nTotal Carbs.    54.2g   18 %\nDietary Fiber   0g  0 %\nSugars  54.2g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "23mins Walking\n10mins Jogging\n7mins Swimming\n12mins Cycling";
        }
        // End of Soft Drink Bottles


        // Buttons for Soft Drinks Cans
        private void button3_CanCoke(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Classic Coca-Cola Can";
            textBlock.Text = "133 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  45mg    2 %\nTotal Carbs.    37.1g   12 %\nDietary Fiber   0g  0 %\nSugars  37.1g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "37mins Walking\n15mins Jogging\n11mins Swimming\n20mins Cycling";
        }

        private void button3copy_CanFanta(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Fanta Can";
            textBlock.Text = "165 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  48mg    2 %\nTotal Carbs.    41.3g   14 %\nDietary Fiber   0g  0 %\nSugars  43.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "46mins Walking\n19mins Jogging\n14mins Swimming\n25mins Cycling";
        }

        private void button01_CanPepsi(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Pepsi Can";
            textBlock.Text = "139 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  28mg    1 %\nTotal Carbs.    38.1g   13 %\nDietary Fiber   0g  0 %\nSugars  38.1g\nProtein 0g\nPotassium   9.3mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "39mins Walking\n16mins Jogging\n12mins Swimming\n21mins Cycling";
        }

        private void button02_CanDrP(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Dr.Pepper Can";
            textBlock.Text = "139 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  56mg    2 %\nTotal Carbs.    36.8g   12 %\nDietary Fiber   0g  0 %\nSugars  35.7g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "39mins Walking\n16mins Jogging\n12mins Swimming\n21mins Cycling";
        }

        private void button03_CanOrange(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Club Orange Can";
            textBlock.Text = "178 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  56mg    3 %\nTotal Carbs.    42.9g   13 %\nDietary Fiber   0g  0 %\nSugars  56.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "47mins Walking\n20mins Jogging\n15mins Swimming\n26mins Cycling";
        }

        private void button04_CanCidona(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Cidona Can";
            textBlock.Text = "76 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  69mg    3 %\nTotal Carbs.    16.3g   10 %\nDietary Fiber   0g  0 %\nSugars  40.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "21mins Walking\n9mins Jogging\n6mins Swimming\n12mins Cycling";
        }

        private void button05_CanDietCoke(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Diet Coca-Cola Can";
            textBlock.Text = "1 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  39mg    2 %\nTotal Carbs.    0.1g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.1g\nProtein 0g\nPotassium   16.5mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "0mins Walking\n0mins Jogging\n0mins Swimming\n0mins Cycling";
        }

        private void button06_CanLucazade(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Lucozade Can";
            textBlock.Text = "250 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  69mg    3 %\nTotal Carbs.    65.4g   19 %\nDietary Fiber   0g  0 %\nSugars  56.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "70mins Walking\n29mins Jogging\n21mins Swimming\n38mins Cycling";
        }

        private void button07_CanRibena(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Ribena Can";
            textBlock.Text = "121 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  60mg    2 %\nTotal Carbs.    26.5g   14 %\nDietary Fiber   0g  0 %\nSugars  50.3g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "34mins Walking\n14mins Jogging\n10mins Swimming\n18mins Cycling";
        }

        private void button08_CanSprite(object sender, RoutedEventArgs e)
        {
            textBlock05.Text = "Sprite Can";
            textBlock.Text = "138 Calories per 330mL ";
            textBlock3.Text = "Nutrition Facts: % = Daily Value";
            textBlock1.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  62mg    3 %\nTotal Carbs.    35.7g   12 %\nDietary Fiber   0g  0 %\nSugars  35.7g\nProtein 0g\nPotassium   0mg";
            textBlock04.Text = "How to burn these calories?";
            textBlock2.Text = "23mins Walking\n10mins Jogging\n7mins Swimming\n12mins Cycling";
        }
        // End of Cans



        // Wines
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "White Wine";
            textBlock5.Text = "121 Calories per 1 glass (5.2 oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  7mg    < 1 %\nTotal Carbs.    3.8g   1 %\nDietary Fiber   0g  0 %\nSugars  1.4g    Alcohol    15.2g\nProtein 0.1g    Calcium   13.3mg\nPotassium   105.1mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "32mins Walking\n14mins Jogging\n10mins Swimming\n16mins Cycling";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Red Wine";
            textBlock5.Text = "126 Calories per 1 glass (5.2 oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  6mg    < 1 %\nTotal Carbs.    3.9g   1 %\nDietary Fiber   0g  0 %\nSugars  0.9g    Alcohol    15.7g\nProtein 0.1g    Calcium   11.8mg\nPotassium   188mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "33mins Walking\n14mins Jogging\n10mins Swimming\n17mins Cycling";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Champagne";
            textBlock5.Text = "78 Calories per 1 glass (4.1 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0mg    < 1 %\nTotal Carbs.    1.2g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    10.3g\nProtein 0.2g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "20mins Walking\n9mins Jogging\n6mins Swimming\n10mins Cycling";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Sangria";
            textBlock5.Text = "150 Calories per 1 glass (8.5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  6mg    < 1 %\nTotal Carbs.    18g   6 %\nDietary Fiber   0g  0 %\nSugars  16g    Alcohol    10.9g\nProtein 0.5g    Calcium   20mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "39mins Walking\n17mins Jogging\n12mins Swimming\n20mins Cycling";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Riesling";
            textBlock5.Text = "120 Calories per 1 glass (5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0mg    < 0 %\nTotal Carbs.    5.5g   2 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    14.1g\nProtein 0.1g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "31mins Walking\n14mins Jogging\n10mins Swimming\n16mins Cycling";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Burgundy Red";
            textBlock5.Text = "129 Calories per 1 glass (5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0mg    < 0 %\nTotal Carbs.    5.5g   2 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    15.2g\nProtein 0.1g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "34mins Walking\n15mins Jogging\n11mins Swimming\n17mins Cycling";
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Merlot Red";
            textBlock5.Text = "124 Calories per 1 glass (5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  6mg    < 1 %\nTotal Carbs.    3.7g   1 %\nDietary Fiber   0g  0 %\nSugars  0.9g    Alcohol    15.7g\nProtein 0.1g    Calcium   11.8mg\nPotassium   188mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "33mins Walking\n14mins Jogging\n10mins Swimming\n17mins Cycling";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Bree Red";
            textBlock5.Text = "130 Calories per 1 glass (5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0mg    0 %\nTotal Carbs.    5.5g   2 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    15.2g\nProtein 0.1g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "34mins Walking\n15mins Jogging\n11mins Swimming\n17mins Cycling";
        }

        private void button14_Zinfandel(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Zinfandel";
            textBlock5.Text = "123 Calories per 1 glass (5.1 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0mg    0 %\nTotal Carbs.    2.9g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    15.6g\nProtein 0.5g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "32mins Walking\n14mins Jogging\n10mins Swimming\n16mins Cycling";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Sweet Vermouth";
            textBlock5.Text = "165 Calories per 1 glass (3.5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  9mg    < 1 %\nTotal Carbs.    14.1g   5 %\nDietary Fiber   0g  0 %\nSugars  8g    Alcohol    15.8g\nProtein 0.2g    Calcium   8.2mg\nPotassium   94.8mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "43mins Walking\n19mins Jogging\n14mins Swimming\n22mins Cycling";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Dry Vermouth";
            textBlock5.Text = "157 Calories per 1 glass (3.5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  9mg    1 %\nTotal Carbs.    12g   4 %\nDietary Fiber   0g  0 %\nSugars  1.1g    Alcohol    15.8g\nProtein 0.2g    Calcium   8.2mg\nPotassium   94.8mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "41mins Walking\n18mins Jogging\n13mins Swimming\n21mins Cycling";
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Sherry";
            textBlock5.Text = "157 Calories per 1 glass (3.5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  9mg    < 1 %\nTotal Carbs.    12g   4 %\nDietary Fiber   0g  0 %\nSugars  1.1g    Alcohol    15.8g\nProtein 0.2g    Calcium   8.2mg\nPotassium   94.8mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "41mins Walking\n18mins Jogging\n13mins Swimming\n21mins Cycling";
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Marsala";
            textBlock5.Text = "165 Calories per 1 glass (3.5 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  9mg    < 1 %\nTotal Carbs.    14.1g   5 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    15.8g\nProtein 0.2g    Calcium   8.2mg\nPotassium   94.8mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "46mins Walking\n19mins Jogging\n14mins Swimming\n25mins Cycling";
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Sparkling White";
            textBlock5.Text = "78 Calories per 1 glass (4.1 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    1.2g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    10.3g\nProtein 0.2g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "20mins Walking\n9mins Jogging\n6mins Swimming\n10mins Cycling";
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Sutter Home Moscato";
            textBlock5.Text = "127 Calories per 1 glass (5.1 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    11.2g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    11.3g\nProtein 0.5g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "33mins Walking\n15mins Jogging\n11mins Swimming\n17mins Cycling";
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            textBlock4.Text = "Takara Plum Wine";
            textBlock5.Text = "326 Calories per 1 glass (8.1 fl.oz) ";
            textBlock6.Text = "Nutrition Facts: % = Daily Value";
            textBlock07.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  5mg    < 1 %\nTotal Carbs.    40.3g   13 %\nDietary Fiber   0g  0 %\nSugars  40.3g    Alcohol    21.6g\nProtein 0.0g    Calcium   0.0mg\nPotassium   0.0mg";
            textBlock08.Text = "How to burn these calories?";
            textBlock09.Text = "91mins Walking\n37mins Jogging\n27mins Swimming\n50mins Cycling";
        }
        // End of Wines

        // Beer
        private void button24_Coors(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Coors";
            textBlock8.Text = "102 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  11mg    < 1 %\nTotal Carbs.    5g   2 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    11.3g\nProtein 0.7g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "27mins Walking\n12mins Jogging\n8mins Swimming\n14mins Cycling";
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Bud Light";
            textBlock8.Text = "110 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    6.6g   2 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    11.4g\nProtein 0.9g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "29mins Walking\n13mins Jogging\n9mins Swimming\n15mins Cycling";
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Bud Light Platinum";
            textBlock8.Text = "137 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    4.4g   1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    16.5g\nProtein 0.9g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "38mins Walking\n16mins Jogging\n11mins Swimming\n21mins Cycling";
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Blue Moon Belgian White Ale";
            textBlock8.Text = "164 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  8mg    0 %\nTotal Carbs.    13g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    14.9g\nProtein 2g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "45mins Walking\n19mins Jogging\n14mins Swimming\n25mins Cycling";
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Stella Artois";
            textBlock8.Text = "153 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    12.8g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol    14g\nProtein 1.2g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "40mins Walking\n17mins Jogging\n13mins Swimming\n21mins Cycling";
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Heineken";
            textBlock8.Text = "148 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  7mg    < 1 %\nTotal Carbs.    11.3g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   13.8g\nProtein 1.5g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "39mins Walking\n17mins Jogging\n12mins Swimming\n21mins Cycling";
        }

        private void button30_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Shock Top Belgian White Beer";
            textBlock8.Text = "167 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  9mg    < 1 %\nTotal Carbs.    14.6g   5 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14.8g\nProtein 2.1g";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "44mins Walking\n19mins Jogging\n14mins Swimming\n22mins Cycling";
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Samuel Adams Boston Lager";
            textBlock8.Text = "180 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  12mg    < 1 %\nTotal Carbs.    18.8g   6 %\nDietary Fiber   0g  0 %\nSugars  1g    Alcohol   14g\nProtein 2g\nPotassium    270mg";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "47mins Walking\n21mins Jogging\n15mins Swimming\n24mins Cycling";
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Rolling Rock Extra Pale Lager";
            textBlock8.Text = "132 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  10mg    3 %\nTotal Carbs.    10g   3 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   12.8g\nProtein 0.5g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "35mins Walking\n15mins Jogging\n11mins Swimming\n18mins Cycling";
        }

        private void button33_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Guinness";
            textBlock8.Text = "126 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  20mg    < 1 %\nTotal Carbs.    10g   3 %\nDietary Fiber   0g  0 %\nSugars  10g    Alcohol   11.7g\nProtein 1g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "33mins Walking\n14mins Jogging\n10mins Swimming\n17mins Cycling";
        }

        private void button34_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Guinness Extra Stout";
            textBlock8.Text = "176 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  25mg    1 %\nTotal Carbs.    14g   5 %\nDietary Fiber   0g  0 %\nSugars  14g    Alcohol   15.4g\nProtein 3g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "36mins Walking\n20mins Jogging\n15mins Swimming\n24mins Cycling";
        }

        private void button35_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Miller";
            textBlock8.Text = "96 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  5mg    < 1 %\nTotal Carbs.    3.2g   1 %\nDietary Fiber   0g  0 %\nSugars  14g    Alcohol   11.6g\nProtein 0.6g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button36_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Peroni";
            textBlock8.Text = "150 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  5mg    < 1 %\nTotal Carbs.    11.4g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14.2g\nProtein 1.3g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "39mins Walking\n17mins Jogging\n12mins Swimming\n20mins Cycling";
        }

        private void button37_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Dos Equis XX Lager";
            textBlock8.Text = "141 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  10mg    < 1 %\nTotal Carbs.    10.5g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0.4g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "37mins Walking\n16mins Jogging\n12mins Swimming\n19mins Cycling";
        }

        private void button38_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Leinenkugel's Summer Shandy Fruit Beer";
            textBlock8.Text = "130 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  5mg    < 1 %\nTotal Carbs.    12g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   11g\nProtein 0.2g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "34mins Walking\n15mins Jogging\n11mins Swimming\n17mins Cycling";
        }

        private void button39_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Corona";
            textBlock8.Text = "130 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    14g   5 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   13.1g\nProtein 0.0g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "37mins Walking\n16mins Jogging\n12mins Swimming\n19mins Cycling";
        }

        private void button40_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Sapporo Premium Lager";
            textBlock8.Text = "130 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    10.3g   3 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   13.7g\nProtein 1.4g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "37mins Walking\n16mins Jogging\n12mins Swimming\n19mins Cycling";
        }

        private void button41_Click(object sender, RoutedEventArgs e)
        {
            textBlock7.Text = "Tecate";
            textBlock8.Text = "142 Calories per 1 bottle (12 fl.oz) ";
            textBlock9.Text = "Nutrition Facts: % = Daily Value";
            textBlock010.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    12g   4 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   13g\nProtein 1g\n";
            textBlock011.Text = "How to burn these calories?";
            textBlock012.Text = "39mins Walking\n17mins Jogging\n13mins Swimming\n20mins Cycling";
        }
        // End of Beer


        // Spirits
        private void button42_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Bacardi Rum";
            textBlock14.Text = "96 Calories per 1 shooter shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   13.8g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button43_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Captain Morgan Parrot Bay Coconut Rum";
            textBlock14.Text = "88 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    9.7g   3 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   7g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "23mins Walking\n10mins Jogging\n7mins Swimming\n12mins Cycling";
        }

        private void button44_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Captain Morgan White Rum";
            textBlock14.Text = "96 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button45_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Captain Morgan Original Spiced Rum ";
            textBlock14.Text = "86 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0.4g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   12g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "22mins Walking\n10mins Jogging\n7mins Swimming\n12mins Cycling";
        }

        private void button46_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Cragganmore Whiskey";
            textBlock14.Text = "147 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   21g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "38mins Walking\n17mins Jogging\n12mins Swimming\n20mins Cycling";
        }

        private void button47_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Bulliet Bourbon Whiskey";
            textBlock14.Text = "109 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   15g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "29mins Walking\n12mins Jogging\n9mins Swimming\n15mins Cycling";
        }

        private void button48_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Gordon's Vodka";
            textBlock14.Text = "96 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button49_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Jack Daniel's Tennessee Whiskey";
            textBlock14.Text = "98 Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button50_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Johnnie Walker Black Label Whiskey";
            textBlock14.Text = "105  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   15g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "27mins Walking\n12mins Jogging\n9mins Swimming\n14mins Cycling";
        }

        private void button51_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Johnnie Walker Red Label Whiskey";
            textBlock14.Text = "105  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   15g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "27mins Walking\n12mins Jogging\n9mins Swimming\n14mins Cycling";
        }

        private void button52_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Jose Cuervo Especial Silver Tequila ";
            textBlock14.Text = "96  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button53_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Jose Cuervo Gold Tequila";
            textBlock14.Text = "96  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   14g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button54_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Ciroc Coconut Vodka";
            textBlock14.Text = "94  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    2.3g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   12g\nProtein 21g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button55_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Ciroc Red Berry Vodka";
            textBlock14.Text = "91  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    1.7g   < 1 %\nDietary Fiber   0g  0 %\nSugars  0.0g    Alcohol   12g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "24mins Walking\n10mins Jogging\n8mins Swimming\n12mins Cycling";
        }

        private void button56_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Malibu Rum Flavored with Fruit Essence";
            textBlock14.Text = "57  Calories per 1 shot glass (1 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    6g   2 %\nDietary Fiber   0g  0 %\nSugars  6g    Alcohol   4.6g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "16mins Walking\n7mins Jogging\n5mins Swimming\n9mins Cycling";
        }

        private void button57_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Seagram Seagram's, 7 Crown Whiskey";
            textBlock14.Text = "97  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0g    Alcohol   13.8g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button58_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Smirnoff Vodka";
            textBlock14.Text = "97  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0g    Alcohol   13.9g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "25mins Walking\n11mins Jogging\n8mins Swimming\n13mins Cycling";
        }

        private void button59_Click(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Tanqueray Gin";
            textBlock14.Text = "115  Calories per 1 shot glass (1.5 fl.oz) ";
            textBlock15.Text = "Nutrition Facts: % = Daily Value";
            textBlock16.Text = "Total Fat	0g	0%\nSat.Fat    0g  0 %\nTrans Fat   0g\nCholesterol 0mg 0 %\nSodium  0.0mg    0 %\nTotal Carbs.    0g   0 %\nDietary Fiber   0g  0 %\nSugars  0g    Alcohol   16.4g\nProtein 0g\n";
            textBlock17.Text = "How to burn these calories?";
            textBlock18.Text = "30mins Walking\n13mins Jogging\n10mins Swimming\n15mins Cycling";
        }
        // End of Spirits

    }
}
