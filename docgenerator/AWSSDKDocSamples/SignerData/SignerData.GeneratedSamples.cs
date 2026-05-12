using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SignerData;
using Amazon.SignerData.Model;

namespace AWSSDKDocSamples.Amazon.SignerData.Generated
{
    class SignerDataSamples : ISample
    {
        public void SignerDataGetRevocationStatus()
        {
            #region example-1

            var client = new AmazonSignerDataClient();
            var response = client.GetRevocationStatus(new GetRevocationStatusRequest 
            {
                CertificateHashes = new List<string> {
                    "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855"
                },
                JobArn = "arn:aws:signer:us-east-1:123456789012:/signing-jobs/my-job-id",
                PlatformId = "Notation-OCI-SHA384-ECDSA",
                ProfileVersionArn = "arn:aws:signer:us-east-1:123456789012:/signing-profiles/my-profile/v1",
                SignatureTimestamp = DateTime.UtcNow
            });

            List<string> revokedEntities = response.RevokedEntities;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}