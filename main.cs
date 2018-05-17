using System;
using World.History;

class HistoryOfProgramming : History
{
    public HistoryOfProgramming() 
        : base("History of Programming")
    {
        this.Description = "A Brief Totally Accurate History Of Programming";
        this.AddYearInformation([1980-2018]);

        this.AddExtraData("arrays_start_at_1", false);
    }
}

