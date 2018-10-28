namespace restful_api.Interfaces
{
    public interface IMathService
    {
        decimal ConvertToDecimal(string number);

        bool IsNumeric(string strNumber);
    }
}
