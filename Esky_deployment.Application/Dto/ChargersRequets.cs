namespace Esky_deployment.Esky_deployment.Application.Dto;

public class ChargersRequets
{
    public int stationId{get;set;}
    public string? chargeCode{get;set;}
    public int powerKw{get;set;}
    public string? brand{get;set;}
    public string? chargerIp {get;set;}
    public int simId{get;set;}
}