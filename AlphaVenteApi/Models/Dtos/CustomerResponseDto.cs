namespace AlphaVenteApi.Models.Dtos
{
    public class CustomerResponseDto
    {
        public Boolean IsSucsses { get; set; } = true;
        public Object? Result { get; set; }
        public String DisplayMessage { get; set; } = String.Empty;
        public List<String>? ErrorMessage { get; set; }
    }
}
