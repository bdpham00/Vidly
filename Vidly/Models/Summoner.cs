using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Summoner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public int SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
    }
}