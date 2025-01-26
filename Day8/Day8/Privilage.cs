using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace Day8
{
    [Flags]
    public enum Privilage
    {
        Guest = 1,             
        Developer = 2,         
        Secretary = 4,        
        DBA = 8,              
        securityofficer = 15
    }
}
