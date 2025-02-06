namespace SpreadEx.Widget.Coding.Challenge.Validation;

public static class Guard
{
    public static void IsValidWidth(int width) 
        => CheckIfPositiveValue(width, nameof(width));
    
    public static void IsValidHeight(int height) 
        => CheckIfPositiveValue(height, nameof(height));
    
    public static void IsValidDiameter(int diameter) 
        => CheckIfPositiveValue(diameter, nameof(diameter));

    public static void ThrowIfNullEmptyOrWhiteSpace(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value cannot be empty, null or whitespace.");
    }

    private static void CheckIfPositiveValue(int value, string sourceParam) 
    {
        if (value < 0)
            throw new ArgumentException($"{sourceParam} must be a positive number.");
    }
}