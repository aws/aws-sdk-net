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
        public void SecurityTokenServiceAssumeRole()
        {
            #region to-assume-a-role-1480532402212

            var client = new AmazonSecurityTokenServiceClient();
            var response = client.AssumeRole(new AssumeRoleRequest 
            {
                ExternalId = "123ABC",
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Stmt1\",\"Effect\":\"Allow\",\"Action\":\"s3:ListAllMyBuckets\",\"Resource\":\"*\"}]}",
                RoleArn = "arn:aws:iam::123456789012:role/demo",
                RoleSessionName = "testAssumeRoleSession",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Project",
                        Value = "Unicorn"
                    },
                    new Tag {
                        Key = "Team",
                        Value = "Automation"
                    },
                    new Tag {
                        Key = "Cost-Center",
                        Value = "12345"
                    }
                },
                TransitiveTagKeys = new List<string> {
                    "Project",
                    "Cost-Center"
                }
            });

            AssumedRoleUser assumedRoleUser = response.AssumedRoleUser;
            Credentials credentials = response.Credentials;
            int packedPolicySize = response.PackedPolicySize;

            #endregion
        }

        public void SecurityTokenServiceAssumeRoleWithSAML()
        {
            #region to-assume-role-with-saml-14882749597814

            var client = new AmazonSecurityTokenServiceClient();
            var response = client.AssumeRoleWithSAML(new AssumeRoleWithSAMLRequest 
            {
                DurationSeconds = 3600,
                PrincipalArn = "arn:aws:iam::123456789012:saml-provider/SAML-test",
                RoleArn = "arn:aws:iam::123456789012:role/TestSaml",
                SAMLAssertion = "VERYLONGENCODEDASSERTIONEXAMPLExzYW1sOkF1ZGllbmNlPmJsYW5rPC9zYW1sOkF1ZGllbmNlPjwvc2FtbDpBdWRpZW5jZVJlc3RyaWN0aW9uPjwvc2FtbDpDb25kaXRpb25zPjxzYW1sOlN1YmplY3Q+PHNhbWw6TmFtZUlEIEZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOm5hbWVpZC1mb3JtYXQ6dHJhbnNpZW50Ij5TYW1sRXhhbXBsZTwvc2FtbDpOYW1lSUQ+PHNhbWw6U3ViamVjdENvbmZpcm1hdGlvbiBNZXRob2Q9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpjbTpiZWFyZXIiPjxzYW1sOlN1YmplY3RDb25maXJtYXRpb25EYXRhIE5vdE9uT3JBZnRlcj0iMjAxOS0xMS0wMVQyMDoyNTowNS4xNDVaIiBSZWNpcGllbnQ9Imh0dHBzOi8vc2lnbmluLmF3cy5hbWF6b24uY29tL3NhbWwiLz48L3NhbWw6U3ViamVjdENvbmZpcm1hdGlvbj48L3NhbWw6U3ViamVjdD48c2FtbDpBdXRoblN0YXRlbWVudCBBdXRoPD94bWwgdmpSZXNwb25zZT4="
            });

            AssumedRoleUser assumedRoleUser = response.AssumedRoleUser;
            string audience = response.Audience;
            Credentials credentials = response.Credentials;
            string issuer = response.Issuer;
            string nameQualifier = response.NameQualifier;
            int packedPolicySize = response.PackedPolicySize;
            string subject = response.Subject;
            string subjectType = response.SubjectType;

            #endregion
        }

        public void SecurityTokenServiceAssumeRoleWithWebIdentity()
        {
            #region to-assume-a-role-as-an-openid-connect-federated-user-1480533445696

            var client = new AmazonSecurityTokenServiceClient();
            var response = client.AssumeRoleWithWebIdentity(new AssumeRoleWithWebIdentityRequest 
            {
                DurationSeconds = 3600,
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Stmt1\",\"Effect\":\"Allow\",\"Action\":\"s3:ListAllMyBuckets\",\"Resource\":\"*\"}]}",
                ProviderId = "www.amazon.com",
                RoleArn = "arn:aws:iam::123456789012:role/FederatedWebIdentityRole",
                RoleSessionName = "app1",
                WebIdentityToken = "Atza%7CIQEBLjAsAhRFiXuWpUXuRvQ9PZL3GMFcYevydwIUFAHZwXZXXXXXXXXJnrulxKDHwy87oGKPznh0D6bEQZTSCzyoCtL_8S07pLpr0zMbn6w1lfVZKNTBdDansFBmtGnIsIapjI6xKR02Yc_2bQ8LZbUXSGm6Ry6_BG7PrtLZtj_dfCTj92xNGed-CrKqjG7nPBjNIL016GGvuS5gSvPRUxWES3VYfm1wl7WTI7jn-Pcb6M-buCgHhFOzTQxod27L9CqnOLio7N3gZAGpsp6n1-AJBOCJckcyXe2c6uD0srOJeZlKUm2eTDVMf8IehDVI0r1QOnTV6KzzAI3OY87Vd_cVMQ"
            });

            AssumedRoleUser assumedRoleUser = response.AssumedRoleUser;
            string audience = response.Audience;
            Credentials credentials = response.Credentials;
            int packedPolicySize = response.PackedPolicySize;
            string provider = response.Provider;
            string subjectFromWebIdentityToken = response.SubjectFromWebIdentityToken;

            #endregion
        }

        public void SecurityTokenServiceAssumeRoot()
        {
            #region to-launch-a-privileged-session-1731335424565

            var client = new AmazonSecurityTokenServiceClient();
            var response = client.AssumeRoot(new AssumeRootRequest 
            {
                DurationSeconds = 900,
                TargetPrincipal = "111122223333",
                TaskPolicyArn = new PolicyDescriptorType { Arn = "arn:aws:iam::aws:policy/root-task/S3UnlockBucketPolicy" }
            });

            Credentials credentials = response.Credentials;
            string sourceIdentity = response.SourceIdentity;

            #endregion
        }

        public void SecurityTokenServiceDecodeAuthorizationMessage()
        {
            #region to-decode-information-about-an-authorization-status-of-a-request-1480533854499

            var client = new AmazonSecurityTokenServiceClient();
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

            var client = new AmazonSecurityTokenServiceClient();
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

            var client = new AmazonSecurityTokenServiceClient();
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

            var client = new AmazonSecurityTokenServiceClient();
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

            var client = new AmazonSecurityTokenServiceClient();
            var response = client.GetFederationToken(new GetFederationTokenRequest 
            {
                DurationSeconds = 3600,
                Name = "testFedUserSession",
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Stmt1\",\"Effect\":\"Allow\",\"Action\":\"s3:ListAllMyBuckets\",\"Resource\":\"*\"}]}",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Project",
                        Value = "Pegasus"
                    },
                    new Tag {
                        Key = "Cost-Center",
                        Value = "98765"
                    }
                }
            });

            Credentials credentials = response.Credentials;
            FederatedUser federatedUser = response.FederatedUser;
            int packedPolicySize = response.PackedPolicySize;

            #endregion
        }

        public void SecurityTokenServiceGetSessionToken()
        {
            #region to-get-temporary-credentials-for-an-iam-user-or-an-aws-account-1480540814038

            var client = new AmazonSecurityTokenServiceClient();
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