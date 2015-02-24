using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ReverseWords", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class ReverseWordsRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public string s;

        public ReverseWordsRequest()
        {
        }

        public ReverseWordsRequest(string s)
        {
            this.s = s;
        }
    }
}