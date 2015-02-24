using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "WhatIsYourTokenResponse", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class WhatIsYourTokenResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public System.Guid WhatIsYourTokenResult;

        public WhatIsYourTokenResponse()
        {
        }

        public WhatIsYourTokenResponse(System.Guid WhatIsYourTokenResult)
        {
            this.WhatIsYourTokenResult = WhatIsYourTokenResult;
        }
    }
}