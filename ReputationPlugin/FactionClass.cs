using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Faction
{
    public string name { get; set; }
    public int rank { get; set; }
    public int rep { get; set; }
    public int requiredRep { get; set; }
    public int remainingRep { get; set; }
    public int rank10Remaining { get; set; }
    public int totalRep { get; set; }


    public Faction(string name, int rank, int rep, int requiredRep, int remainingRep, int rank10Remaining, int totalRep)
    {
        this.name = name;
        this.rank = rank;
        this.rep = rep;
        this.requiredRep = requiredRep;
        this.remainingRep = remainingRep;
        this.rank10Remaining = rank10Remaining;
        this.totalRep = totalRep;
    }

    public Faction(string name)
    {
        this.name = name;
        this.rank = 1;
        this.rep = 0;
        this.requiredRep = 900;
        this.remainingRep = 900;
        this.rank10Remaining = 302500;
        this.totalRep = 0;
    }
}

