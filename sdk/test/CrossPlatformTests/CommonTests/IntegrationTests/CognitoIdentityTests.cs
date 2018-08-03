using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Amazon.CognitoIdentity;
using CommonTests.Framework;
using Amazon.S3;
using Amazon;
using Amazon.S3.Model;
namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CognitoIdentityTests
    {
        [Test]
        [Category("CognitoIdentity")]
        //test Amazon Cognito Enhanced(Simplified) Flow with unauthenticated role
        public void TestUnAuthorEnhancedFlow()
        {
            string poolId = TestRunner.StoredSettings.UnAuthCognitoPoolId;
            RegionEndpoint regionEndpoint = TestRunner.RegionEndpoint;
            CognitoAWSCredentials cognitoCredentials = new CognitoAWSCredentials(poolId, regionEndpoint);
            VerifyCredentailsProperties(cognitoCredentials, poolId);
            VerifyServiceAccess(cognitoCredentials);
        }

        [Test]
        [Category("CognitoIdentity")]
        //test Amazon Cognito Authentication Basic (Classic) Flow with Unauthenticated role
        public void TesUnAuthorBasedFlow()
        {
            string accountId = TestRunner.StoredSettings.AccountId;
            string poolId = TestRunner.StoredSettings.UnAuthCognitoPoolId;
            RegionEndpoint regionEndpoint = TestRunner.RegionEndpoint;
            string authRole = TestRunner.StoredSettings.UnAuthAuthRole;
            string unauthRole = TestRunner.StoredSettings.UnAuthUnAuthRole;
            CognitoAWSCredentials cognitoCredentials = new CognitoAWSCredentials(accountId, poolId, unauthRole, authRole, regionEndpoint);
            VerifyCredentailsProperties(cognitoCredentials, poolId, accountId,unauthRole,authRole);
            VerifyServiceAccess(cognitoCredentials);
        }

        [Test]
        [Category("CognitoIdentity")]
        //test Amazon Cognito Enhanced (Simplified) Flow with Authenticated role
        public void TestAuthorEnhancedFlow()
        {
            string poolId = TestRunner.StoredSettings.AuthCognitoPoolId;
            RegionEndpoint regionEndpoint = TestRunner.RegionEndpoint;
            string authProvider = TestRunner.StoredSettings.AuthProvider;
            string authToken = TestRunner.StoredSettings.AuthToken;
            CognitoAWSCredentials cognitoCredentials = new CognitoAWSCredentials(poolId, regionEndpoint);
            cognitoCredentials.AddLogin(authProvider, authToken);
            VerifyCredentailsProperties(cognitoCredentials, poolId);
            VerifyServiceAccess(cognitoCredentials);
        }

        [Test]
        [Category("CognitoIdentity")]
        //test Amazon Cognito Authentication Basic (Classic) Flow with Authenticated role
        public void TestAuthorBasedFlow()
        {
            string accountId = TestRunner.StoredSettings.AccountId;
            string poolId = TestRunner.StoredSettings.AuthCognitoPoolId;
            RegionEndpoint regionEndpoint = TestRunner.RegionEndpoint;
            string authRole = TestRunner.StoredSettings.AuthAuthRole;
            string unauthRole = TestRunner.StoredSettings.AuthUnAuthRole;
            string authProvider = TestRunner.StoredSettings.AuthProvider;
            string authToken = TestRunner.StoredSettings.AuthToken;
            CognitoAWSCredentials cognitoCredentials = new CognitoAWSCredentials(accountId, poolId, unauthRole, authRole, regionEndpoint);
            cognitoCredentials.AddLogin(authProvider, authToken);
            VerifyCredentailsProperties(cognitoCredentials, poolId, accountId, unauthRole, authRole);
            VerifyServiceAccess(cognitoCredentials);
        }

        //This api is to save the log file to S3 service
        //We use this api to verify CognitoAWSCredentials object is working
        private void SaveToS3(AmazonS3Client s3, string key, string log)
        {
            try
            { 
                s3.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = Settings.ResultsBucket,
                    Key = key,
                    ContentBody = log
                }).Wait();               
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message); 
            }
        }

        public void VerifyCredentailsProperties(CognitoAWSCredentials credentials, string IdentityPoolId)
        {
            Assert.IsTrue(credentials.IdentityPoolId == IdentityPoolId);             
        }

        public void VerifyCredentailsProperties(CognitoAWSCredentials credentials, string IdentityPoolId, string accountId, string unAuthRoleArn, string AuthRoleArn)
        {
            VerifyCredentailsProperties(credentials, IdentityPoolId);
            Assert.IsTrue(credentials.AccountId == accountId);
            Assert.IsTrue(credentials.UnAuthRoleArn == unAuthRoleArn);
            Assert.IsTrue(credentials.AuthRoleArn == AuthRoleArn);
        }

        //Verify the CognitoAWSCredentials object can be used to access AWS services
        public void VerifyServiceAccess(CognitoAWSCredentials credentials)
        {
            var originalS3Signature = AWSConfigsS3.UseSignatureVersion4;
            AWSConfigsS3.UseSignatureVersion4 = true;
            try
            {
                using (var s3 = TestBase.CreateClient<Amazon.S3.AmazonS3Client>(credentials))
                {                   
                    string timestampFormat = "yyyy-MM-dd-HH-mm-ss";
                    var timestamp = DateTime.Now.ToString(timestampFormat);
                    var key = string.Format("{0}_{1}", "verifycongnito", timestamp);
                    var file = TestRunner.Instance.logfilepath;
                    SaveToS3(s3, key, file);
                    var result = s3.ListBucketsAsync().Result; 
                    if(result != null)
                    {
                        var buckets = s3.ListBucketsAsync().Result.Buckets;
                        Console.WriteLine(buckets.Count);
                    }
                }
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }

            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = originalS3Signature;
            }
        }
    }
}
