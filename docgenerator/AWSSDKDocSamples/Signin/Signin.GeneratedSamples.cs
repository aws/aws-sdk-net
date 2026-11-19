using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Signin;
using Amazon.Signin.Model;

namespace AWSSDKDocSamples.Amazon.Signin.Generated
{
    class SigninSamples : ISample
    {
        public void SigninBatchRevokeSessions()
        {
            #region BatchRevokeSessions-1

            var client = new AmazonSigninClient();
            var response = client.BatchRevokeSessions(new BatchRevokeSessionsRequest
            {
                Reason = "Signed out of a lost device",
                SessionArns = new List<string> {
                    "arn:aws:signin:us-east-1:123456789012:session/3b0a6152-ba23-447d-83cf-b3b3cc7b95f7"
                }
            });

            List<BatchRevokeSessionError> errors = response.Errors;
            List<RevokedSession> revokedSessions = response.RevokedSessions;

            #endregion
        }

        public void SigninBatchRevokeSessions()
        {
            #region BatchRevokeSessions-2

            var client = new AmazonSigninClient();
            var response = client.BatchRevokeSessions(new BatchRevokeSessionsRequest
            {
                PrincipalArn = "arn:aws:iam::123456789012:*",
                Reason = "Revoked by account administrator",
                SessionArns = new List<string> {
                    "arn:aws:signin:us-east-1:123456789012:session/5dbdd43b-4135-4c59-ad06-5ddbcc2c1d77"
                }
            });

            List<BatchRevokeSessionError> errors = response.Errors;
            List<RevokedSession> revokedSessions = response.RevokedSessions;

            #endregion
        }

        public void SigninBatchRevokeSessions()
        {
            #region BatchRevokeSessions-3

            var client = new AmazonSigninClient();
            var response = client.BatchRevokeSessions(new BatchRevokeSessionsRequest
            {
                SessionArns = new List<string> {
                    "arn:aws:signin:us-east-1:123456789012:session/ac148df8-7f37-48eb-b0cf-8987fc4a55a4",
                    "arn:aws:signin:us-east-1:123456789012:session/36b6ae9d-4fa9-40d9-8eff-eeeb4d15f79d"
                }
            });

            List<BatchRevokeSessionError> errors = response.Errors;
            List<RevokedSession> revokedSessions = response.RevokedSessions;

            #endregion
        }

        public void SigninGetSession()
        {
            #region GetSession-1

            var client = new AmazonSigninClient();
            var response = client.GetSession(new GetSessionRequest
            {
                SessionArn = "arn:aws:signin:us-east-1:123456789012:session/3b0a6152-ba23-447d-83cf-b3b3cc7b95f7"
            });

            string clientId = response.ClientId;
            ClientType clientType = response.ClientType;
            long? expiresAt = response.ExpiresAt;
            long? issuedAt = response.IssuedAt;
            string issuedInRegion = response.IssuedInRegion;
            string principalArn = response.PrincipalArn;
            string role = response.Role;
            string sessionArn = response.SessionArn;
            SessionStatus status = response.Status;

            #endregion
        }

        public void SigninGetSession()
        {
            #region GetSession-2

            var client = new AmazonSigninClient();
            var response = client.GetSession(new GetSessionRequest
            {
                PrincipalArn = "arn:aws:iam::123456789012:*",
                SessionArn = "arn:aws:signin:us-east-1:123456789012:session/5dbdd43b-4135-4c59-ad06-5ddbcc2c1d77"
            });

            string clientId = response.ClientId;
            ClientType clientType = response.ClientType;
            long? expiresAt = response.ExpiresAt;
            long? issuedAt = response.IssuedAt;
            string issuedInRegion = response.IssuedInRegion;
            string principalArn = response.PrincipalArn;
            string role = response.Role;
            string sessionArn = response.SessionArn;
            SessionStatus status = response.Status;

            #endregion
        }

        public void SigninListSessions()
        {
            #region ListSessions-1

            var client = new AmazonSigninClient();
            var response = client.ListSessions(new ListSessionsRequest
            {
            });

            List<Session> items = response.Items;

            #endregion
        }

        public void SigninListSessions()
        {
            #region ListSessions-2

            var client = new AmazonSigninClient();
            var response = client.ListSessions(new ListSessionsRequest
            {
                MaxResults = 1,
                Status = "ACTIVE"
            });

            List<Session> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
