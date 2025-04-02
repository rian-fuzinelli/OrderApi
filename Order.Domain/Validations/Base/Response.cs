public class Response
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; }

    public Response(bool success, string message)
    {
        Success = success;
        Message = message;
        Errors = new List<string>();
    }
}

public class Response<T> : Response
{
    public T Data { get; set; }

    public Response(bool success, string message, T data)
        : base(success, message)
    {
        Data = data;
    }

}
