namespace Proj_API_EF.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
