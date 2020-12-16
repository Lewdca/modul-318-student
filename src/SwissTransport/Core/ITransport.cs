namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using System;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string station, int ende);

        StationBoardRoot GetStationBoard(string station, string id, DateTime zeit, int ende);

        Connections GetConnections(string fromStation, string toStation, DateTime Zeit, DateTime datum, int ende);
    }
}