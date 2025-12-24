namespace Result;

public record Error
{
    public ErrorType Type { get; }
    public string Code { get; }
    public string Message { get; }
    private Error (string code, string message, ErrorType type = ErrorType.Failure)
    {
        Type = type;
        Code = code;
        Message = message;
    }
    public static readonly Error None = new (string.Empty, string.Empty);
    //public static readonly Error ErrorName = new ("General.ErrorName", "Error message");
    public static readonly Error NullValue = new ("General.Null", "Null value was provided");
    public static Error Failure (string code, string description) =>
        new (code = "General.Failure",
             description = "A 'Failure' has ocurred");
    public static Error NullValue2 (string code, string description) =>
        new (code = "General.NullValue",
             description = "Null value was provided", ErrorType.NullValue);
    public static Error Validation (string code, string description) =>
        new (code = "General.Validation",
             description = "An 'Validation' error has ocurred", ErrorType.Validation);
    public static Error NotFound (string code, string description) =>
        new (code = "General.NotFound",
             description = "An 'NotFound' error has ocurred", ErrorType.NotFound);    
    public static Error Unauthorized (string code, string description) =>
        new (code = "General.Unauthorized",
             description = "An 'Unauthorized' error has ocurred", ErrorType.Unauthorized);
    public static Error Forbidden (string code, string description) =>
       new (code = "General.Forbidden",
            description = "An 'Forbidden' error has ocurred", ErrorType.Forbidden);
    public static Error Unexpected (string code, string description) =>
       new (code = "General.Unexpected",
            description = "An 'Unexpected' error has ocurred", ErrorType.Unexpected);        
}