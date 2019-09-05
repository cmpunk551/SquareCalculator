using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareСalculatorLibrary
{
    public class SquareСalculator
    {
        public static double CalculateSquare(double radius)
        {
            double squareOfCircle = Math.PI * Math.Pow(radius, 2);

            return squareOfCircle;
        }

        public static double CalculateSquare(double firstSide, double secondSide, double thirdSide)
        {
            double longestSide = Math.Max(Math.Max(firstSide, secondSide), thirdSide);
            double sumOfOtherSides = (firstSide + secondSide + thirdSide) - longestSide;
            
            // проверка условия существования треугольника 
            if (longestSide >= sumOfOtherSides)
            {
                return 0;
            }

            double squareOfTriangle = 0;

            // square здесь подразумевается как "квадрат"
            double sumOfSquaresOfOtherSides = (Math.Pow(firstSide,2) + Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) - Math.Pow(longestSide,2);
            
            // в случае прямоугольного треугольника площадь вычислиятся по его формуле
            if(Math.Pow(longestSide,2) == sumOfSquaresOfOtherSides)
            {
                squareOfTriangle = (0.5 * firstSide * secondSide * thirdSide) / longestSide;
                return squareOfTriangle;
            }

            double halfOfPerimeter = 0.5 * (firstSide + secondSide + thirdSide);

            squareOfTriangle = GetSquareWithHeronsFormula(halfOfPerimeter, firstSide, secondSide, thirdSide);

            return squareOfTriangle;

        }

        public static double GetSquareWithHeronsFormula(double halfOfPerimeter, double firstSide, double secondSide, double thirdSide)
        {
            double square = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - firstSide) * (halfOfPerimeter - secondSide) * (halfOfPerimeter - thirdSide));

            return square;
        }
    }
}
