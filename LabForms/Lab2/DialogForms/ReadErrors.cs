namespace LabForms.Lab2.DialogForms;

public static class ReadErrorTool
{
    private static readonly string[] errorsStrings = [
        "номер",
        "сумма к уплате",
        "стоимость"
        ];

    public static string GenerateReadErrorString(List<ReadErrors> errors)
    {
        string errorString = string.Empty;

        foreach (var error in errors)
        {
            if (errorString != string.Empty)
            {
                errorString += $", {errorsStrings[(int)error]}";
            }
            else
            {
                errorString += errorsStrings[(int)error];
            }
        }
        return errorString;
    }
}

public enum ReadErrors
{
    CountError,
    ValueError,
    CostError
}