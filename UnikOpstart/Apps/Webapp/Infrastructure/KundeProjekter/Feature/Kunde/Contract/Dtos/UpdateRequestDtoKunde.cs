namespace Webapp.Infrastructure.Kunde.Contract.Dtos;

public class UpdateRequestDtoKunde
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int TlfNr { get; set; }
}