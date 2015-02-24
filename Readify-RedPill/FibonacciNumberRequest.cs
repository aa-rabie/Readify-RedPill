using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "FibonacciNumber", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class FibonacciNumberRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public long n;

        public FibonacciNumberRequest()
        {
        }

        public FibonacciNumberRequest(long n)
        {
            this.n = n;
        }
    }
}