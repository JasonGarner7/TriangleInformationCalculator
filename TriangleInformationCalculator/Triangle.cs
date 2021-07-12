using System;

namespace TriangleInformationCalculator
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double angleA;
        private double angleB;
        private double angleC;
        private string angleType;
        private string sideType;

        public Triangle (double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.angleA = -1;
            this.angleB = -1;
            this.angleC = -1;
            this.sideType = "Undetermined";
            this.angleType = "Undetermined";
        }
        
        // Verifies that the sides of the triangle are valid (invalid ex. (sideA + sideB) < sideC)
        public bool isValid()
        {
            if (((this.sideA + this.sideB) <= this.sideC) || 
                ((this.sideA + this.sideC) <= this.sideB) ||
                ((this.sideB + this.sideC) <= this.sideA))
            {
                return false;
            }
            
            return true;
        }

        private double LawOfCosines(double a, double b, double c)
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
        }

        // Calculates the angles of a Triangle, converts from radians to degrees
        private void CalculateAngles()
        {
            this.angleA = LawOfCosines(this.sideA, this.sideB, this.sideC) * (180 / Math.PI);
            this.angleB = LawOfCosines(this.sideB, this.sideA, this.sideC) * (180 / Math.PI);
            this.angleC = 180 - (this.angleA + this.angleB);
        }

        // Determines the type of triangle
        public void Classify()
        {
            CalculateAngles();
            
            // Classify angle type
            if (this.angleA < 90 && this.angleB < 90 && this.angleC < 90)
            {
                this.angleType = "Acute";
            }
            else if (this.angleA > 90 || this.angleB > 90 || this.angleC > 90)
            {
                this.angleType = "Obtuse";
            }
            else
            {
                this.angleType = "Right";
            }

            // Classify side type
            if (this.sideA == this.sideB && this.sideB == this.sideC)
            {
                this.sideType = "Equalateral";
            }
            else if (this.sideA == this.sideB || this.sideA == this.sideC || this.sideB == this.sideC)
            {
                this.sideType = "Isosceles";
            }
            else
            {
                this.sideType = "Scalene";
            }
        }

        public string GetSideType()
        {
            return this.sideType;
        }

        public string GetAngleType()
        {
            return this.angleType;
        }

        public double[] GetAngleMeasurements()
        {
            double[] angleMeasurments = { this.angleA, this.angleB, this.angleC };
            return angleMeasurments;
        }
    }
}
