namespace Esky_deployment.Esky_deployment.Application.Dto;


public class StationRequest
{
    public string? stationName{get;set;}
    public string? stationCode{get;set;}
    public string? stationAddress{get;set;}
    public string? province{get;set;}
    public Boolean isActive {get;set;} = false;
    public string? subnet{get;set;}
    public string? vpnInternalIp{get;set;}
    public string? vpnFileName{get;set;}
}