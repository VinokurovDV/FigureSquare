using System;


namespace FigureSquare
{
    public class Figure
    {
        public virtual double CalculateSquare(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }
        public double CalculateSquare(double a, double b, double c)
        {
            //если треугольник прямоугольный (проверяем по т. Пифагора), то его площадь равна половине произведения катетов
            if(a>b)
            {
                if (a > c) 
                {
                    
                    if (a*a==b*b+c*c)
                        return b*c/2;
                }
                else
                {
                    if(c*c==b*b+a*a)
                        return a*b/2;
                }
            }
            else
            {
                if (b>c)
                { if (b * b == a * a + c * c)
                        return a * c / 2;
                 }
                else 
                {
                    if (c * c == b * b + a * a)
                            return a * b / 2;
                }
            }
            //иначе площадь равна корню из произведения полупериметра на на разности полупериметра и каждой из его сторон
            double pp =(a+b+c)/2;
            double s=Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
            return s;
        }
    }
}
