using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Club_Management_System.Models
{
    public class SupportStuff
    {
        public int SupportStufId { get; set; }
        public string SupportStufName { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }
    }

    public static class SupportStuffDB
    {
        public static List<SupportStuff> SupportStuffList = new List<SupportStuff>()
        {
            new SupportStuff(){SupportStufId=1,SupportStufName="Chandrakant Pandit",Position="Head Coach",Country="India"},
            new SupportStuff(){SupportStufId=2,SupportStufName="Abhishek Nayar",Position="Assistant Coach ",Country="India"},
            new SupportStuff(){SupportStufId=3,SupportStufName="AR Srikkanth",Position="Talent Scouting & Player Acquisitions",Country="India"},
            new SupportStuff(){SupportStufId=4,SupportStufName="Bharat Arun",Position="Bowling Coach",Country="India"},
            new SupportStuff(){SupportStufId=5,SupportStufName="Chris Donaldson",Position="Strength And Conditioning Coach",Country="New Zealand"},
            new SupportStuff(){SupportStufId=6,SupportStufName="James Foster",Position="Assistant Coach",Country="England"},
            new SupportStuff(){SupportStufId=7,SupportStufName="Omkar Salvi",Position="Assistant Bowling Coach",Country="India"},
            new SupportStuff(){SupportStufId=8,SupportStufName="Ryan Ten Doeschate",Position="Fielding Coach ",Country="Netherlands"},
            new SupportStuff(){SupportStufId=9,SupportStufName="Wayne Bentley",Position="Team Manager",Country="Australia"},
            new SupportStuff(){SupportStufId=10,SupportStufName="Abhishek Sawant",Position="Assistant Physio",Country="India"},
            new SupportStuff(){SupportStufId=11,SupportStufName="Dr. Srikant Narayanswamy",Position="Team Doctor",Country="India"},
            new SupportStuff(){SupportStufId=12,SupportStufName="Nathan Leamon",Position="Team Analyst",Country="England"},
            new SupportStuff(){SupportStufId=13,SupportStufName="Prasanth Panchada",Position="Head Physiotherapist",Country="India"},
            new SupportStuff(){SupportStufId=14,SupportStufName="Sagar V",Position="Asst. Strength And Conditioning Coach",Country="India"},
        };
    }
}
