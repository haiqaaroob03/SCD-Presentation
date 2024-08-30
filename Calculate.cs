namespace SimpleCalculator;

public static class Calculate
{
    public static double DoCalculation(double firstNum, double secondNum, string operatorMath)
    {
        double result = 0;

        switch (operatorMath)
        {
            case "+":
                result = firstNum + secondNum;
                break;
            case "-":
                result = firstNum - secondNum;
                break;
            case "*":
                result = firstNum * secondNum;
                break;
            case "/":
                result = firstNum / secondNum;
                break;
        }

        return result;
    }
}
