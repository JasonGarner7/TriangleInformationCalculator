using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TriangleInformationCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double lengthA, lengthB, lengthC = 0;
        private bool validA, validB, validC = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        // Validate user input. Non-numbers cannot be entered.
        private void BlockInvalidEntry(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9.]+").IsMatch(e.Text);
        }

        // Reads user input, validates, and initiates calculations.
        private void HandleChange(object sender, TextChangedEventArgs e)
        {
            // If the textboxes are not empty, validate that a number has been entered, that it is non-zero, and then test triangle
            if (!SideA.Text.Equals(""))
            {
                validA = double.TryParse(SideA.Text, out lengthA);
            }
            if (!SideB.Text.Equals(""))
            {
                validB = double.TryParse(SideB.Text, out lengthB);
            }
            if (!SideC.Text.Equals(""))
            {
                validC = double.TryParse(SideC.Text, out lengthC);
            }

            if (validA && validB && validC)
            {
                if (lengthA == 0 || lengthB == 0 || lengthC == 0)
                {
                    Result.Text = "Side length cannot be zero";
                    AngleResult.Text = "";
                }
                else
                {
                    Result.Text = lengthA + ", " + lengthB + ", " + lengthC;
                    TestTriangle(lengthA, lengthB, lengthC);
                }
            }
        }

        // Create triangle object and run operations
        private void TestTriangle(double a, double b, double c) 
        {
            Triangle triangle = new Triangle(a, b, c);
            if (triangle.isValid())
            {
                triangle.Classify();

                string angleType = triangle.GetAngleType();
                string sideType = triangle.GetSideType();
                double[] angleMeasurments = triangle.GetAngleMeasurements();

                Result.Text = "These side lengths produce a valid\n" +
                    angleType + " " + sideType + " Triangle\n";
                AngleResult.Text = "Angle ∠A: " + String.Format("{0:0.00}", angleMeasurments[0]) + "°\n" +
                    "Angle ∠B: " + String.Format("{0:0.00}", angleMeasurments[1]) + "°\n" +
                    "Angle ∠C: " + String.Format("{0:0.00}", angleMeasurments[2]) + "°";
            }
            else
            {
                Result.Text = "Triangle is invalid";
                AngleResult.Text = "";
            }
        }
    }
}
