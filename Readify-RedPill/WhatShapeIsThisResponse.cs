using RedPill.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "WhatShapeIsThisResponse", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class WhatShapeIsThisResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public TriangleType WhatShapeIsThisResult;

        public WhatShapeIsThisResponse()
        {
        }

        public WhatShapeIsThisResponse(TriangleType WhatShapeIsThisResult)
        {
            this.WhatShapeIsThisResult = WhatShapeIsThisResult;
        }
    }
}