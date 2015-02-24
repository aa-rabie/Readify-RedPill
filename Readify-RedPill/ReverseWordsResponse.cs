using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ReverseWordsResponse", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class ReverseWordsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public string ReverseWordsResult;

        public ReverseWordsResponse()
        {
        }

        public ReverseWordsResponse(string ReverseWordsResult)
        {
            this.ReverseWordsResult = ReverseWordsResult;
        }
    }
}