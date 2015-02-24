using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "WhatIsYourToken", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class WhatIsYourTokenRequest
    {

        public WhatIsYourTokenRequest()
        {
        }
    }
}