using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDKDocSamples.Amazon.SecurityToken.Generated
{
    class SecurityTokenServiceSamples : ISample
    {
        static IAmazonSecurityTokenService client = new AmazonSecurityTokenServiceClient();
        public void SecurityTokenServiceAssumeRole()
        {
            #region to-assume-a-role-1480532402212

            var response = client.AssumeRole(new AssumeRoleRequest 
            {
                DurationSeconds = 3600,
                ExternalId = "123ABC",
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Stmt1\",\"Effect\":\"Allow\",\"Action\":\"s3:*\",\"Resource\":\"*\"}]}",
                RoleArn = "arn:aws:iam::123456789012:role/demo",
                RoleSessionName = "Bob"
            });

            AssumedRoleUser assumedRoleUser = response.AssumedRoleUser;
            Credentials credentials = response.Credentials;
            integer packedPolicySize = response.PackedPolicySize;

            #endregion
        }

        public void SecurityTokenServiceAssumeRoleWithWebIdentity()
        {
            #region to-assume-a-role-as-an-openid-connect-federated-user-1480533445696

            var response = client.AssumeRoleWithWebIdentity(new AssumeRoleWithWebIdentityRequest 
            {
                DurationSeconds = 3600,
                ProviderId = "www.amazon.com",
                RoleArn = "arn:aws:iam::123456789012:role/FederatedWebIdentityRole",
                RoleSessionName = "app1",
                WebIdentityToken = "Atza%7CIQEBLjAsAhRFiXuWpUXuRvQ9PZL3GMFcYevydwIUFAHZwXZXXXXXXXXJnrulxKDHwy87oGKPznh0D6bEQZTSCzyoCtL_8S07pLpr0zMbn6w1lfVZKNTBdDansFBmtGnIsIapjI6xKR02Yc_2bQ8LZbUXSGm6Ry6_BG7PrtLZtj_dfCTj92xNGed-CrKqjG7nPBjNIL016GGvuS5gSvPRUxWES3VYfm1wl7WTI7jn-Pcb6M-buCgHhFOzTQxod27L9CqnOLio7N3gZAGpsp6n1-AJBOCJckcyXe2c6uD0srOJeZlKUm2eTDVMf8IehDVI0r1QOnTV6KzzAI3OY87Vd_cVMQ"
            });

            AssumedRoleUser assumedRoleUser = response.AssumedRoleUser;
            string audience = response.Audience;
            Credentials credentials = response.Credentials;
            integer packedPolicySize = response.PackedPolicySize;
            string provider = response.Provider;
            string subjectFromWebIdentityToken = response.SubjectFromWebIdentityToken;

            #endregion
        }

        public void SecurityTokenServiceDecodeAuthorizationMessage()
        {
            #region to-decode-information-about-an-authorization-status-of-a-request-1480533854499

            var response = client.DecodeAuthorizationMessage(new DecodeAuthorizationMessageRequest 
            {
                EncodedMessage = "<encoded-message>"
            });

            string decodedMessage = response.DecodedMessage;

            #endregion
        }

        public void SecurityTokenServiceGetCallerIdentity()
        {
            #region to-get-details-about-a-calling-iam-user-1480540050376

            var response = client.GetCallerIdentity(new GetCallerIdentityRequest 
            {
            });

            string account = response.Account;
            string arn = response.Arn;
            string userId = response.UserId;

            #endregion
        }

        public void SecurityTokenServiceGetCallerIdentity()
        {
            #region to-get-details-about-a-calling-user-federated-with-assumerole-1480540158545

            var response = client.GetCallerIdentity(new GetCallerIdentityRequest 
            {
            });

            string account = response.Account;
            string arn = response.Arn;
            string userId = response.UserId;

            #endregion
        }

        public void SecurityTokenServiceGetCallerIdentity()
        {
            #region to-get-details-about-a-calling-user-federated-with-getfederationtoken-1480540231316

            var response = client.GetCallerIdentity(new GetCallerIdentityRequest 
            {
            });

            string account = response.Account;
            string arn = response.Arn;
            string userId = response.UserId;

            #endregion
        }

        public void SecurityTokenServiceGetFederationToken()
        {
            #region to-get-temporary-credentials-for-a-role-by-using-getfederationtoken-1480540749900

            var response = client.GetFederationToken(new GetFederationTokenRequest 
            {
                DurationSeconds = 3600,
                Name = "Bob",
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Stmt1\",\"Effect\":\"Allow\",\"Action\":\"s3:*\",\"Resource\":\"*\"}]}"
            });

            Credentials credentials = response.Credentials;
            FederatedUser federatedUser = response.FederatedUser;
            integer packedPolicySize = response.PackedPolicySize;

            #endregion
        }

        public void SecurityTokenServiceGetSessionToken()
        {
            #region to-get-temporary-credentials-for-an-iam-user-or-an-aws-account-1480540814038

            var response = client.GetSessionToken(new GetSessionTokenRequest 
            {
                DurationSeconds = 3600,
                SerialNumber = "YourMFASerialNumber",
                TokenCode = "123456"
            });

            Credentials credentials = response.Credentials;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}