using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTask
{
    internal class Trial : Software
    {
        public DateTime StartDate { get; }
        public int TrialTime { get; }

        public Trial(string softwareName, string softwareCompany, DateTime startDate, int trialTime) : base(softwareName, softwareCompany)
        {
            this.StartDate = startDate;
            this.TrialTime = trialTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Trial software: {SoftwareName} - {SoftwareCompany}, Start date: {StartDate}, Trial time: {TrialTime} days");
        }

        public override bool IsAwailable()
        {
            return (StartDate + TimeSpan.FromDays(TrialTime) >= DateTime.Now);
        }

    }
}
