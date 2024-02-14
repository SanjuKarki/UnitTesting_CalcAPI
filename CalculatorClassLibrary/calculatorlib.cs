namespace CalculatorClassLibrary
{
    public class calculatorlib
    {
        public decimal Add(decimal num1, decimal num2)
        {
            decimal addResult = num1 + num2;
            return addResult;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            decimal subtractResult = num1 - num2;
            return subtractResult;
        }
        public decimal Multiply(decimal num1, decimal num2)
        {
            decimal MultiplyResult = num1 * num2;
            return MultiplyResult;
        }
        public decimal Divide(decimal num1, decimal num2)
        {
            decimal DivideResult = num1 / num2;
            return DivideResult;
        }
        public decimal Modulo(decimal num1, decimal num2)
        {
            decimal ModResult = num1 % num2;
            return ModResult;
        }
    }
}
