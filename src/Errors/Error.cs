namespace Result;

public readonly record struct Error
{
    public ErrorType Type { get; }
    public string Code { get; }
    public string Message { get; }
    private Error (ErrorType type, string code, string message)
    {
        Type = type;
        Code = code;
        Message = message;
    }

    public static Error Validation (
        string code = "General.Validation",
        string description = "A 'validation' error has occurred.") => 
        
        new (ErrorType.Validation, code, description);


    public static Error Unexpected (
        string code = "General.Unexpected", 
        string message = "An 'unexpected' error has ocurred") =>
    
        new (ErrorType.Unexpected, code, message);

    public static Error Unauthorized (
        string code = "General.Unauthorized",
        string description = "An 'unauthorized' error has occurred.") =>
            
        new (ErrorType.Unauthorized, code, description);
    
    public static Error Forbidden (
        string code = "General.Forbidden",
        string description = "A 'forbidden' error has occurred.") =>
        
        new (ErrorType.Forbidden, code, description);
    
    public static Error Custom (
        int type,
        string code,
        string description) =>
            
        new ((ErrorType)type, code, description);
}