namespace UnikOpstart.Services.KundeProjekter.Application.Dtos.Kunde
{
    public class QueryResultDtoKunde
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int TlfNr { get; set; }
    }
}