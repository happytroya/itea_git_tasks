using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTask
{
    internal class Commercial : Software
    {
        public DateTime StartDate { get; }
        public int TermOfUse { get; }

        public Commercial(string softwareName, string softwareCompany, DateTime startDate, int termOfUse) : base(softwareName, softwareCompany)
        {
            this.StartDate = startDate;
            this.TermOfUse = termOfUse;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Trial software: {SoftwareName} - {SoftwareCompany}, Start date: {StartDate}, Term of use: {TermOfUse} days");
        }

        public override bool IsAwailable()
        {
            return (StartDate + TimeSpan.FromDays(TermOfUse) >= DateTime.Now);
        }
    }
}
