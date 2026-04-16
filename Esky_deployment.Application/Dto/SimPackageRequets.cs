namespace Esky_deployment.Esky_deployment.Application.Dto;

public class SimPackageRequest
{
    public string? telco {get;set;}
    public string? supplier{get;set;}
    public DateTime? activationDate{get;set;}
    public DateTime? nextRenewalDate{get;set;}
    public int simQuantity{get;set;}
}