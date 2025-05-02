namespace IntegerValues
{
    public static class Integer
    {
        public static int Round(double number)
        {
            // Проверка на переполнение
            if (number > int.MaxValue || number < int.MinValue)
            {
                throw new OverflowException($"Число {number} выходит за пределы диапазона int");
            }

            // Получаем целую часть
            int integerPart = (int)number;
            // Получаем дробную часть
            double fractionalPart = number - integerPart;

            // Округляем вверх если дробная часть >= 0.5
            if (fractionalPart >= 0.5)
            {
                // Проверка на переполнение при округлении вверх
                if (number > 0 && integerPart == int.MaxValue)
                    throw new OverflowException("Округление вызывает переполнение");
                return integerPart + 1;
            }
            // Округляем вниз если дробная часть < -0.5
            else if (fractionalPart < -0.5)
            {
                // Проверка на переполнение при округлении вниз
                if (number < 0 && integerPart == int.MinValue)
                    throw new OverflowException("Округление вызывает переполнение");
                return integerPart - 1;
            }

            return integerPart + 1;
        }

        public static bool IsEven(int number)
        {
            // Используем побитовую операцию для проверки четности
            // У четных чисел младший бит всегда 0
            return (number & 1) == 0;
        }

        public static int Absolute(int number)
        {
            // Особый случай - минимальное значение int
            if (number == int.MinValue)
            {
                throw new OverflowException($"Невозможно взять модуль {number}, так как |int.MinValue| > int.MaxValue");
            }

            // Если число отрицательное, возвращаем его с противоположным знаком
            return number < 0 ? -number : number;
        }
    }
}
