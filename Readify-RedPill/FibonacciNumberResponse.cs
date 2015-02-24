using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_RedPill
{
    [System.ServiceModel.MessageContractAttribute(WrapperName = "FibonacciNumberResponse", WrapperNamespace = "http://KnockKnock.readify.net", IsWrapped = true)]
    public partial class FibonacciNumberResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://KnockKnock.readify.net", Order = 0)]
        public long FibonacciNumberResult;

        public FibonacciNumberResponse()
        {
        }

        public FibonacciNumberResponse(long FibonacciNumberResult)
        {
            this.FibonacciNumberResult = FibonacciNumberResult;
        }
    }
}