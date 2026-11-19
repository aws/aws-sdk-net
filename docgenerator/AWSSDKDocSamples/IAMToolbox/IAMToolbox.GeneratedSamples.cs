using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IAMToolbox;
using Amazon.IAMToolbox.Model;

namespace AWSSDKDocSamples.Amazon.IAMToolbox.Generated
{
    class IAMToolboxSamples : ISample
    {
        public void IAMToolboxGetRequestAuthorizationPolicy()
        {
            #region GetRequestAuthorizationPolicy-1

            var client = new AmazonIAMToolboxClient();
            var response = client.GetRequestAuthorizationPolicy(new GetRequestAuthorizationPolicyRequest
            {
                AuthorizationId = "1a2b3c4d5e6f7g8h9i0j1k2l3",
                PolicyUri = "arn:aws:iam::aws:policy/AWSDenyAll"
            });

            global::Amazon.Runtime.Documents.Document policyDocument = response.PolicyDocument;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
