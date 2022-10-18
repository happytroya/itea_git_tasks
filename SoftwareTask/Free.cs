using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTask
{
    internal class Free : Software
    {
        public Free(string softwareName, string softwareCompany) : base(softwareName, softwareCompany)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Free software: {SoftwareName} - {SoftwareCompany}");
        }

        public override bool IsAwailable()
        {
            return true;
        }
    }
}
