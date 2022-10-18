using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTask
{
    internal class Software
    {
        public string SoftwareName { get; }
        public string SoftwareCompany { get; }

        public Software(string softwareName, string softwareCompany)
        {
            this.SoftwareName = softwareName;
            this.SoftwareCompany = softwareCompany;
        }

        public virtual void ShowInfo()
        {
        }

        public virtual bool IsAwailable()
        {
            return false;
        }  

    }
}
 