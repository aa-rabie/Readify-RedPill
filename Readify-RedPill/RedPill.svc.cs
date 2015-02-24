using RedPill.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Readify_RedPill
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public WhatIsYourTokenResponse WhatIsYourToken(WhatIsYourTokenRequest request)
        {
            return new WhatIsYourTokenResponse(Constants.Token);

        }
        public async Task<WhatIsYourTokenResponse> WhatIsYourTokenAsync(WhatIsYourTokenRequest request)
        {
            return await Task.Run<WhatIsYourTokenResponse>(() => new WhatIsYourTokenResponse(Constants.Token));
            
        }

        public ReverseWordsResponse ReverseWords(ReverseWordsRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>( new ArgumentNullException("request"),"null arguments are invalid");
            }
            try
            {
                var result = new ReverseWordsResponse(ReverseWordsManager.Reverse(request.s));
                return result;
            }
            catch (ArgumentNullException exp)
            {
                throw new FaultException<ArgumentNullException>(exp,exp.Message);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public async Task<ReverseWordsResponse> ReverseWordsAsync(ReverseWordsRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("request"), "null arguments are invalid");
            }
            return await Task.Run<ReverseWordsResponse>(() => {
                try
                {
                    var result = new ReverseWordsResponse(ReverseWordsManager.Reverse(request.s));
                    return result;
                }
                catch (ArgumentNullException exp)
                {
                    throw new FaultException<ArgumentNullException>(exp, exp.Message);
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }
            );
        }

        public FibonacciNumberResponse FibonacciNumber(FibonacciNumberRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("request"), "null arguments are invalid");
            }
            try
            {
                var result = new FibonacciNumberResponse(FibonacciManager.Calculate(request.n));
                return result;
            }
            catch (ArgumentOutOfRangeException exp)
            {
                throw new FaultException<ArgumentOutOfRangeException>(exp, exp.Message);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public async Task<FibonacciNumberResponse> FibonacciNumberAsync(FibonacciNumberRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("request"), "null arguments are invalid");
            }

            return await Task.Run<FibonacciNumberResponse>(() =>
            {
                try
                {
                    var result = new FibonacciNumberResponse(FibonacciManager.Calculate(request.n));
                    return result;
                }
                catch (ArgumentOutOfRangeException exp)
                {
                    throw new FaultException<ArgumentOutOfRangeException>(exp, exp.Message);
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            });
        }

       
        public WhatShapeIsThisResponse WhatShapeIsThis(WhatShapeIsThisRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("request"), "null arguments are invalid");
            }
            return new WhatShapeIsThisResponse(TrianglesManager.GetType(request.a, request.b, request.c));
        }

        public async Task<WhatShapeIsThisResponse> WhatShapeIsThisAsync(WhatShapeIsThisRequest request)
        {
            if (request == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("request"), "null arguments are invalid");
            }
            return  await Task.Run<WhatShapeIsThisResponse>(() => 
                new WhatShapeIsThisResponse(TrianglesManager.GetType(request.a, request.b, request.c))
                );
        }
    }
}
