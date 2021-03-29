using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Models;

namespace SwissTransportView
{
    class MockData
    {
        public static List<Station> GetStations()
        {
            var stationsList = new List<Station>();

            var s1 = new Station()
            {
                Id = "1",
                Name = "Luzern, Bahnhof",
                Distance = 1.0,
                Score = 1,
                Coordinate = new Coordinate()
                {
                    Type = "Coordinate",
                    XCoordinate = 1.0,
                    YCoordinate = 1.0
                }
            };

            stationsList.Add(s1);

            var s2 = new Station()
            {
                Id = "1",
                Name = "Stans, Bahnhof",
                Distance = 1.0,
                Score = 1,
                Coordinate = new Coordinate()
                {
                    Type = "Coordinate",
                    XCoordinate = 1.0,
                    YCoordinate = 1.0
                }
            };

            stationsList.Add(s2);

            var s3 = new Station()
            {
                Id = "1",
                Name = "Ennetbürgen, Post",
                Distance = 1.0,
                Score = 1,
                Coordinate = new Coordinate()
                {
                    Type = "Coordinate",
                    XCoordinate = 1.0,
                    YCoordinate = 1.0
                }
            };

            stationsList.Add(s3);

            return stationsList;
        
    }
}
