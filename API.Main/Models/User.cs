namespace API.Main.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }=string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
