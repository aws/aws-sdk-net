using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync;
using Amazon.CognitoSync.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CognitoSync : TestBase<AmazonCognitoSyncClient>
    {
        public static int MaxResults = 10;
        private string poolName = null;
        private string poolId = null;
        private const string policyName = "TestPolicy";
        private static List<string> roleNames = new List<string>();
        FacebookUtilities.FacebookCreateUserResponse facebookUser = null;
        private const string FacebookProvider = "graph.facebook.com";

        // Facebook information required to run Facebook tests
        public const string FacebookAppId = "999999999999999";
        public const string FacebookAppSecret = "ffffffffffffffffffffffffffffffff";


        [TestCleanup]
        public void Cleanup()
        {
            CognitoIdentity.CleanupIdentityPools();

            foreach (var roleName in roleNames)
            {
                DeleteRole(roleName);
            }
            roleNames.Clear();

            if (facebookUser != null)
            {
                FacebookUtilities.DeleteFacebookUser(facebookUser);
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            CognitoIdentity.BaseClean();
            BaseClean();
        }

        [TestMethod]
        public void CacheTest()
        {
            var syncRequestType = typeof(AmazonCognitoSyncRequest);
            var syncClientType = typeof(AmazonCognitoSyncClient);

            var allTypes = syncClientType.Assembly.GetTypes();
            var syncRequestTypes = allTypes.Where(t => t != syncRequestType && syncRequestType.IsAssignableFrom(t)).ToList();

            var cacheType = syncClientType.Assembly.GetType("Amazon.CognitoSync.Internal.CognitoCredentialsRetriever+CSRequestCache");
            var dictionary = cacheType.GetField("requestCache", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null) as System.Collections.IDictionary;

            Assert.AreEqual(syncRequestTypes.Count, dictionary.Count);
            foreach (var syncRequest in syncRequestTypes)
            {
                Assert.IsTrue(dictionary.Contains(syncRequest), "Method cache does not contain EC2 request type {0}", syncRequest.Name);
            }
        }


        [TestMethod]
        [TestCategory("CognitoSync")]
        public void IdentityTests()
        {
            CognitoIdentity.CreateIdentityPool(out poolId, out poolName);

            var usages = GetAllIdentityPoolUsages();
            Assert.IsNotNull(usages);
            Assert.AreNotEqual(0, usages.Count);
            int usagesCount = usages.Count;

            usages = GetAllIdentityPoolUsages();
            Assert.IsNotNull(usages);
            Assert.AreNotEqual(0, usages.Count);
            Assert.AreEqual(usagesCount, usages.Count);

            // Some operations require an authenticated client
            CognitoAWSCredentials credentials;
            using (var authenticatedClient = CreateAuthenticatedClient(poolId, out credentials))
            {
                var datasets = GetAllDatasets(Client, poolId, credentials.GetIdentityId());
                Assert.AreEqual(0, datasets.Count);

                datasets = GetAllDatasets(authenticatedClient, poolId, credentials.GetIdentityId());
                Assert.AreEqual(0, datasets.Count);

                string datasetName = "sample-dataset";
                TestDataCalls(datasetName, authenticatedClient);

                var describeRequest = new DescribeDatasetRequest
                {
                    DatasetName = datasetName,
                    //IdentityId = identityId,
                    //IdentityPoolId = poolId
                };
                var dataset = authenticatedClient.DescribeDataset(describeRequest).Dataset;
                Assert.IsNotNull(dataset);
                Assert.AreEqual(datasetName, dataset.DatasetName);

                // Use unauthenticated client to get usage info
                {
                    var poolUsage = Client.DescribeIdentityPoolUsage(new DescribeIdentityPoolUsageRequest
                    {
                        IdentityPoolId = poolId
                    }).IdentityPoolUsage;
                    Assert.IsNotNull(poolUsage.LastModifiedDate);

                    var identityUsage = Client.DescribeIdentityUsage(new DescribeIdentityUsageRequest
                    {
                        IdentityId = credentials.GetIdentityId(),
                        IdentityPoolId = poolId
                    }).IdentityUsage;

                    Assert.IsNotNull(identityUsage);
                    Assert.AreEqual(credentials.GetIdentityId(), identityUsage.IdentityId);
                    Assert.AreEqual(poolId, identityUsage.IdentityPoolId);
                }

                datasets = GetAllDatasets(authenticatedClient, poolId, credentials.GetIdentityId());
                Assert.AreEqual(1, datasets.Count);

                authenticatedClient.DeleteDataset(new DeleteDatasetRequest
                {
                    DatasetName = datasetName,
                    IdentityPoolId = poolId,
                    IdentityId = credentials.GetIdentityId()
                });

                datasets = GetAllDatasets(authenticatedClient, poolId, credentials.GetIdentityId());
                Assert.AreEqual(0, datasets.Count);

                AssertExtensions.ExpectException(() => authenticatedClient.DescribeDataset(describeRequest));
            }
        }

        [TestMethod]
        [TestCategory("CognitoSync")]
        public void CredentialsTests()
        {
            CognitoIdentity.CreateIdentityPool(out poolId, out poolName);

            var credentials = GetCognitoCredentials(poolId);
            using (var client = new Amazon.S3.AmazonS3Client(credentials))
            {
                // Retries to handle credentials not being full propagated yet.
                for (int retries = 0; retries <= 5; retries++ )
                {
                    Thread.Sleep(1000 * retries);               
                    try
                    {
                        client.ListBuckets();
                        break;
                    }
                    catch (Amazon.S3.AmazonS3Exception e)
                    {
                        if (e.StatusCode == System.Net.HttpStatusCode.Forbidden && retries != 5)
                            continue;
                    }
                }
            }
        }

        // This test is disabled.
        // To run it, put correct information into FacebookAppId and FacebookAppSecret
        // and uncomment the TestMethod attribute below.
        //[TestMethod]
        [TestCategory("CognitoSync")]
        public void LoginsTests()
        {
            CognitoIdentity.CreateIdentityPool(out poolId, out poolName);

            int credentialsChanges = 0;
            CognitoAWSCredentials credentials;
            using (var authenticatedClient = CreateAuthenticatedClient(poolId, out credentials))
            {
                // Log and count identity changes
                credentials.IdentityChangedEvent += (sender, args) =>
                {
                    credentialsChanges++;
                    Console.WriteLine("Identity changed: [{0}] => [{1}]", args.OldIdentityId, args.NewIdentityId);
                };

                string datasetName = "sample-dataset";

                // Test calls using unauthenticated role
                TestDataCalls(datasetName, authenticatedClient);

                // Configure IdentityPool to support Facebook logins
                CognitoIdentity.UpdateIdentityPool(poolId, poolName,
                    new Dictionary<string, string> { { FacebookProvider, FacebookAppId } });

                // Create a Facebook user and supply this information to the credentials
                facebookUser = FacebookUtilities.CreateFacebookUser(FacebookAppId, FacebookAppSecret);
                var facebookAccessToken = facebookUser.AccessToken;

                // Logins was updated, clear the current credentials
                credentials.AddLogin(FacebookProvider, facebookAccessToken);

                // Test calls using authenticated role
                TestDataCalls(datasetName, authenticatedClient);
            }

            Assert.AreEqual(2, credentialsChanges);
        }

        private void TestDataCalls(string datasetName, AmazonCognitoSyncClient authenticatedClient)
        {
            var recordsResult = authenticatedClient.ListRecords(new ListRecordsRequest
            {
                DatasetName = datasetName,
                // When using CognitoAWSCredentials with a client, IdentityPoolId and IdentityId
                // do not have to be specified

                //IdentityPoolId = poolId,
                //IdentityId = identityId,
                MaxResults = 1
            });
            Assert.IsNotNull(recordsResult);
            Assert.AreEqual(0, recordsResult.Count);
            Assert.IsFalse(recordsResult.DatasetDeletedAfterRequestedSyncCount);
            Assert.IsFalse(recordsResult.DatasetExists);
            Assert.AreEqual(0, recordsResult.DatasetSyncCount);
            Assert.IsNull(recordsResult.LastModifiedBy);
            Assert.AreEqual(0, recordsResult.MergedDatasetNames.Count);
            Assert.AreEqual(0, recordsResult.Records.Count);
            Assert.IsFalse(string.IsNullOrEmpty(recordsResult.SyncSessionToken));

            string key1 = "key1";
            var updateRequest = new UpdateRecordsRequest
            {
                DatasetName = datasetName,
                //IdentityPoolId = poolId,
                //IdentityId = identityId,
                RecordPatches = new List<RecordPatch>
                    {
                        new RecordPatch
                        {
                            Op = Operation.Replace,
                            SyncCount = 0,
                            Key = key1,
                            Value = key1
                        }
                    },
                SyncSessionToken = recordsResult.SyncSessionToken
            };
            var records = authenticatedClient.UpdateRecords(updateRequest).Records;
            Assert.AreEqual(1, records.Count);

            recordsResult = authenticatedClient.ListRecords(new ListRecordsRequest
            {
                DatasetName = datasetName,
                //IdentityPoolId = poolId,
                //IdentityId = identityId,
                MaxResults = 1
            });
            Assert.IsNotNull(recordsResult);
            Assert.AreEqual(1, recordsResult.Count);
            Assert.IsFalse(recordsResult.DatasetDeletedAfterRequestedSyncCount);
            Assert.IsTrue(recordsResult.DatasetExists);
            Assert.AreEqual(1, recordsResult.DatasetSyncCount);
            Assert.AreEqual(0, recordsResult.MergedDatasetNames.Count);
            Assert.AreEqual(1, recordsResult.Records.Count);
            Assert.IsFalse(string.IsNullOrEmpty(recordsResult.SyncSessionToken));

            updateRequest = new UpdateRecordsRequest
            {
                DatasetName = datasetName,
                //IdentityPoolId = poolId,
                //IdentityId = identityId,
                RecordPatches = new List<RecordPatch>
                    {
                        new RecordPatch
                        {
                            Op = Operation.Replace,
                            SyncCount = 1,
                            Key = key1,
                            Value = key1
                        }
                    },
                SyncSessionToken = recordsResult.SyncSessionToken
            };
            records = authenticatedClient.UpdateRecords(updateRequest).Records;

            var allRecords = GetAllRecords(authenticatedClient, datasetName, poolId, identityId: null);
            Assert.AreEqual(1, records.Count);
        }

        private static AmazonCognitoSyncClient CreateAuthenticatedClient(string poolId, out CognitoAWSCredentials credentials)
        {
            credentials = GetCognitoCredentials(poolId);

            var authenticatedClient = new AmazonCognitoSyncClient(credentials);
            return authenticatedClient;
        }
        private static CognitoAWSCredentials GetCognitoCredentials(string poolId)
        {
            string roleArn = PrepareRole();

            CognitoAWSCredentials credentials = new CognitoAWSCredentials(
                UtilityMethods.AccountId, poolId,
                roleArn,    // The same role is used for unAuthRoleArn
                roleArn,    // and authRoleArn
                AWSConfigs.RegionEndpoint);

            return credentials;
        }
        private static string PrepareRole()
        {
            // Assume role policy which accepts OAuth tokens from Google, Facebook or Cognito, and allows AssumeRoleWithWebIdentity action.
            string assumeRolePolicy = @"{
    ""Version"":""2012-10-17"",
    ""Statement"":[
        {
            ""Effect"":""Allow"",
            ""Principal"":{
                ""Federated"":[""accounts.google.com"",""graph.facebook.com"", ""cognito-identity.amazonaws.com""]
            },
            ""Action"":[""sts:AssumeRoleWithWebIdentity""]
        }
    ]
}";
            // Role policy that allows all operations for a number of services
            var allowPolicy = @"{
    ""Version"" : ""2012-10-17"",
    ""Statement"" : [
        {
            ""Effect"" : ""Allow"",
            ""Action"" : [
                ""ec2:*"",
                ""iam:*"",
                ""cloudwatch:*"",
                ""cognito-identity:*"",
                ""cognito-sync:*"",
                ""s3:*""
            ],
            ""Resource"" : ""*""
        }
    ]
}";
            string roleArn;
            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient())
            {
                string roleName = "NetWebIdentityRole" + new Random().Next();
                var response = identityClient.CreateRole(new Amazon.IdentityManagement.Model.CreateRoleRequest
                {
                    AssumeRolePolicyDocument = assumeRolePolicy,
                    RoleName = roleName
                });

                identityClient.PutRolePolicy(new Amazon.IdentityManagement.Model.PutRolePolicyRequest
                {
                    PolicyDocument = allowPolicy,
                    PolicyName = policyName,
                    RoleName = response.Role.RoleName
                });

                roleArn = response.Role.Arn;
                roleNames.Add(roleName);
            }

            // Allow time for policy to be configured
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return roleArn;
        }
        private static void DeleteRole(string roleName)
        {
            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient())
            {
                identityClient.DeleteRolePolicy(new Amazon.IdentityManagement.Model.DeleteRolePolicyRequest
                {
                    PolicyName = policyName,
                    RoleName = roleName
                });

                identityClient.DeleteRole(new Amazon.IdentityManagement.Model.DeleteRoleRequest
                {
                    RoleName = roleName
                });
            }
        }

        public static List<IdentityPoolUsage> GetAllIdentityPoolUsages()
        {
            return GetAllIdentityPoolUsagesHelper().ToList();
        }
        public static List<Record> GetAllRecords(IAmazonCognitoSync client, string datasetName, string poolId, string identityId)
        {
            return GetAllRecordsHelper(client, datasetName, poolId, identityId).ToList();
        }
        public static List<Dataset> GetAllDatasets(IAmazonCognitoSync client, string poolId, string identityId)
        {
            return GetAllDatasetsHelper(client, poolId, identityId).ToList();
        }

        private static IEnumerable<Record> GetAllRecordsHelper(IAmazonCognitoSync client, string datasetName, string poolId, string identityId)
        {
            var request = new ListRecordsRequest
            {
                MaxResults = MaxResults,
                DatasetName = datasetName,
                IdentityPoolId = poolId,
                IdentityId = identityId,
            };
            ListRecordsResult result;
            do
            {
                result = client.ListRecords(request);
                foreach (var record in result.Records)
                {
                    yield return record;
                }

                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }
        private static IEnumerable<IdentityPoolUsage> GetAllIdentityPoolUsagesHelper()
        {
            var request = new ListIdentityPoolUsageRequest { MaxResults = MaxResults };
            ListIdentityPoolUsageResult result;
            do
            {
                result = Client.ListIdentityPoolUsage(request);
                foreach (var usage in result.IdentityPoolUsages)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(usage.IdentityPoolId));
                    yield return usage;
                }
                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }
        private static IEnumerable<Dataset> GetAllDatasetsHelper(IAmazonCognitoSync client, string poolId, string identityId)
        {
            var request = new ListDatasetsRequest
            {
                MaxResults = MaxResults,
                IdentityPoolId = poolId,
                IdentityId = identityId
            };
            ListDatasetsResult result;
            do
            {
                result = client.ListDatasets(request);
                foreach (var ds in result.Datasets)
                {
                    yield return ds;
                }

                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }

    }
}
