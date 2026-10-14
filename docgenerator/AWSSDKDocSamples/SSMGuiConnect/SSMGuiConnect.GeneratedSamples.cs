using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SSMGuiConnect;
using Amazon.SSMGuiConnect.Model;

namespace AWSSDKDocSamples.Amazon.SSMGuiConnect.Generated
{
    class SSMGuiConnectSamples : ISample
    {
        public void SSMGuiConnectDeleteConnectionRecordingPreferences()
        {
            #region DeleteConnectionRecordingPreferences-1

            var client = new AmazonSSMGuiConnectClient();
            var response = client.DeleteConnectionRecordingPreferences(new DeleteConnectionRecordingPreferencesRequest
            {
            });

            string clientToken = response.ClientToken;

            #endregion
        }

        public void SSMGuiConnectGetConnectionRecordingPreferences()
        {
            #region GetConnectionRecordingPreferences-1

            var client = new AmazonSSMGuiConnectClient();
            var response = client.GetConnectionRecordingPreferences(new GetConnectionRecordingPreferencesRequest
            {
            });

            string clientToken = response.ClientToken;
            ConnectionRecordingPreferences connectionRecordingPreferences = response.ConnectionRecordingPreferences;

            #endregion
        }

        public void SSMGuiConnectUpdateConnectionRecordingPreferences()
        {
            #region UpdateConnectionRecordingPreferences-1

            var client = new AmazonSSMGuiConnectClient();
            var response = client.UpdateConnectionRecordingPreferences(new UpdateConnectionRecordingPreferencesRequest
            {
                ConnectionRecordingPreferences = new ConnectionRecordingPreferences {
                    KMSKeyArn = "arn:aws:kms:region:account_id:key/sample_key_id",
                    RecordingDestinations = new RecordingDestinations { S3Buckets = new List<S3Bucket> {
                        new S3Bucket {
                            BucketName = "sample-connection-recording-bucket",
                            BucketOwner = "123456789012"
                        }
                    } }
                }
            });

            string clientToken = response.ClientToken;
            ConnectionRecordingPreferences connectionRecordingPreferences = response.ConnectionRecordingPreferences;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
