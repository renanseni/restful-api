using restful_api.Interfaces;

namespace restful_api.Services
{
    public class MathService : IMathService
    {
        public decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        public bool IsNumeric(string strNumber)
        {
            double number;
            return double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }
    }
}
