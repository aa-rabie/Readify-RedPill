using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPill.Business
{
    /// <summary>
    /// TriangleType enum defines possible Triangle Types
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute(Name="TriangleType", Namespace="http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
}
