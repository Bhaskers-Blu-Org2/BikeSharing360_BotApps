﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using CustomerServiceApis.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Xml;

namespace CustomerServiceApis.Controllers
{
    public class CustomerServiceController : ApiController
    {
        private const string _bingmapappid = "_YourBingMapId_";
        private const string _bingmapstaticmapwithrouteurl = "http://dev.virtualearth.net/REST/v1/Imagery/Map/Road/{4}%2C{5}/15/Routes/Walking?waypoint.1={2},{3};64;{6}&waypoint.2={0},{1};64;{7}&mapSize=400,300&format=png&key=" + _bingmapappid;
        
        
        [Route("lookupuser")]
        [HttpGet]
        public string LookupUser(string ctype, string value)
        {
            //look up user from the database
            return "";
        }

        [Route("lookupbikeswithuser")]
        [HttpGet]
        public System.Collections.Generic.List<Bike> LookupBikesWithUser(string userid)
        {
            //find bikes rented by the user
            return null;
        }

        [Route("filecase")]
        [HttpGet]
        public string FileCase(string userid, string incidenttype, double lat, double lon)
        {
            //add record to database and return case number
            return "";
        }

        [Route("locatebike")]
        [HttpGet]
        public GeoLocation LocateBike(string bikeid, string datetime = "")
        {
            //find bike locations by the bike id and time
            GeoLocation ret = new GeoLocation();
            if (datetime == "")
            {
                return null;
            }
            else
            {
                return null;
            }
        }

        [Route("getmapwithroute")]
        [HttpGet]
        public string GetMapWithRoute(double latitude1, 
            double longitude1, string name1, double latitude2,
            double longitude2, string name2)
        {
            double midlat = (latitude1 + latitude2) / 2;
            double midlon = (longitude1 + longitude2) / 2;
            return string.Format(_bingmapstaticmapwithrouteurl,
                       latitude1.ToString(), longitude1.ToString(),
                       latitude2.ToString(), longitude2.ToString(),
                       midlat.ToString(), midlon.ToString(), name1.ToLower(),
                       name2.ToLower());
        }
        
        [Route("geteta")]
        [HttpGet]
        public int GetETA(double latitude1, double longitude1, 
            double latitude2, double longitude2)
        {
            //Get the case status and return the ETA
            return -1;
        }        
    }
}
