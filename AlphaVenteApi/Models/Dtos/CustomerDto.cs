namespace AlphaVenteApi.Models.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string? codeClient { get; set; }
        public string? FullName { get; set; }
        public string? adress { get; set; }
        public string? email { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
    }
}
