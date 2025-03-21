namespace MathLibrary
{
    public class MathOperation
    {
        //метод выполнения операции нахождения факториала
        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Нельзя вычислить факториал для отрицательных чисел");
            }
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n-1);
        }

        //метод выполнения операции нахождения степени
        public double Power(double number, double degree)
        {
            return Math.Pow(number, degree);
        }

        //метод выполнения операции нахождения корня (не только квадратного)
        public double Root(double number, double degree)
        {
            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentException("Нельзя вычислить корень для отрицательного числа");
            }
            return Math.Pow(number, (1/degree));
        }

        //метод выполнения операции нахождения логорифма
        public double Logarithm(double number, double footing)
        {
            if (number <= 0 || footing <= 0 || footing == 1)
            {
                throw new ArgumentException("Нельзя вычислить логарифм для данных значений");
            }
            return Math.Log(number, footing);
        }
    }
}
