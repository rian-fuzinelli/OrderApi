namespace Order.Domain.Validations.Base
{
    public class Response
    {
        public Response()
        {
            Report = new List<Report>();
        }

        public Response(List<Report> reports)
        {
            Report = reports ?? new List<Report>();
        }

        public Response(Report report) : this(new List<Report> { report })
        {
        }
        public List<Report> Report { get; }

        public static Response<T> OK<T>(T data) => new Response<T>(data, new List<Report>());
    }

    public class Response<T> : Response
    {
        public Response()
        {
        }

        public Response(T data, List<Report> reports) : base(reports)
        {
            Data = data; 
        }

        public T Data { get; set; }
    }
}
