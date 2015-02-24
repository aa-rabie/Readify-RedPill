using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "WhatShapeIsThis", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class WhatShapeIsThisRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public int a;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 1)]
        public int b;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 2)]
        public int c;

        public WhatShapeIsThisRequest()
        {
        }

        public WhatShapeIsThisRequest(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

}