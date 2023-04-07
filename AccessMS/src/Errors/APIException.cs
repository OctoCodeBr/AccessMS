namespace AccessMS.Errors;

public class APIException: Exception {

    public APIException(long _code, string _message) {
        code = _code;
        message = _message;
    }

    public APIException(string _message) {
        code = 1001;
        message = _message;
    }

    public long code { get; set; }
    public string message { get; set; } = string.Empty;
}