namespace Webapp.Infrastructure.Opgaver.Contract.Dtos;

public class CreateRequestDtoOpgaver
{
    public int ProjektId { get; set; }
    public int KompetenceId { get;  set; }
    public string Title { get;  set; }
    public string Process_Kategori { get;  set; }
    public int TimeEstimat { get;  set; }
    public string Kommentar { get;  set; }
}