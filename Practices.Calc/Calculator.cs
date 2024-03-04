namespace Practices.Calc
{
    /// <summary>Кастомный калькулятор </summary>
    public class Calculator
    {
        /// <summary>Сумма двух аргументов.</summary>
        /// <param name="a">Первый аргумент</param>
        /// <param name="b">Второй аргумент</param>
        /// <returns>Возвращаем результат</returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>Разность двух аргументов.</summary>
        /// <param name="a">Первый аргумент</param>
        /// <param name="b">Второй аргумент</param>
        /// <returns>Возвращаем результат</returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>Произведение двух аргументов.</summary>
        /// <param name="a">Первый аргумент</param>
        /// <param name="b">Второй аргумент</param>
        /// <returns>Возвращаем результат</returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>Частное двух аргументов.</summary>
        /// <param name="a">Первый аргумент</param>
        /// <param name="b">Второй аргумент</param>
        /// <returns>Возвращаем результат</returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
