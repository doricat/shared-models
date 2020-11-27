namespace WebApi.Models
{
    public class InnerErrorObject
    {
        public string Code { get; set; }

        public InnerErrorObject InnerError { get; set; }
    }
}