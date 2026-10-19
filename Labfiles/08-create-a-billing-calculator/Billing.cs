namespace Billing
{
    public static class Calculator
    {
        public static decimal CalculateTax(decimal subtotal, decimal taxRate)
        {
            return subtotal * taxRate;
        }

        public static decimal CalculateTotal(decimal subtotal, decimal tax)
        {
            return subtotal + tax;
        }
        

    }
}
