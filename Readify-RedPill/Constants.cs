using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    public class Constants
    {
        internal static Guid Token { get; set; }
        static Constants()
        {
            Token = Guid.Parse("af446f24-ce0a-4b17-8950-08384e1baf21");
        }
    }
}