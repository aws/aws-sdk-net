using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CognitoSync;
using Amazon.CognitoSync.Model;
using Amazon;
using Amazon.Runtime;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CognitoSync : TestBase<AmazonCognitoSyncClient>
    {
        public static int MaxResults = 10;
        private string poolName = null;
        private string poolId = null;
        private string roleName = null;
        private const string policyName = "TestPolicy";

        [TestCleanup]
        public void Cleanup()
        {
            CognitoIdentity.CleanupIdentityPools();
            if (!string.IsNullOrEmpty(roleName))
            {
                DeleteRole(roleName);
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            CognitoIdentity.BaseClean();
            BaseClean();
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

            var identityId = CognitoIdentity.CreateIdentity(poolId, poolName);

            usages = GetAllIdentityPoolUsages();
            Assert.IsNotNull(usages);
            Assert.AreNotEqual(0, usages.Count);
            Assert.AreEqual(usagesCount, usages.Count);

            var datasets = GetAllDatasets(poolId, identityId);
            Assert.AreEqual(0, datasets.Count);

            string datasetName = "sample-dataset";

            var recordsResult = Client.ListRecords(new ListRecordsRequest
            {
                DatasetName = datasetName,
                IdentityPoolId = poolId,
                IdentityId = identityId,
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

            // Some operations require an authenticated client
            using (var authenticatedClient = CreateAuthenticatedClient(poolId, poolName, identityId, out roleName))
            {
                string key1 = "key1";
                var updateRequest = new UpdateRecordsRequest
                {
                    DatasetName = datasetName,
                    IdentityPoolId = poolId,
                    IdentityId = identityId,
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

                // Add retries in case the identity pool is not ready yet.
                List<Record> records = null;
                for (int retries = 0; retries < 5 && records == null; retries++)
                {
                    Thread.Sleep(1000 * retries);

                    try
                    {
                        records = authenticatedClient.UpdateRecords(updateRequest).Records;
                    }
                    catch(AmazonCognitoSyncException e)
                    {
                        if (e.StatusCode == System.Net.HttpStatusCode.Forbidden)
                            continue;
                        throw;
                    }
                }
                Assert.AreEqual(1, records.Count);

                recordsResult = Client.ListRecords(new ListRecordsRequest
                {
                    DatasetName = datasetName,
                    IdentityPoolId = poolId,
                    IdentityId = identityId,
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
                    IdentityPoolId = poolId,
                    IdentityId = identityId,
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
                var allRecords = GetAllRecords(datasetName, poolId, identityId);
                Assert.AreEqual(1, records.Count);
            }

            var describeRequest = new DescribeDatasetRequest
            {
                DatasetName = datasetName,
                IdentityId = identityId,
                IdentityPoolId = poolId
            };
            var dataset = Client.DescribeDataset(describeRequest).Dataset;
            Assert.IsNotNull(dataset);
            Assert.AreEqual(datasetName, dataset.DatasetName);

            var poolUsage = Client.DescribeIdentityPoolUsage(new DescribeIdentityPoolUsageRequest
            {
                IdentityPoolId = poolId
            }).IdentityPoolUsage;
            Assert.IsNotNull(poolUsage.LastModifiedDate);

            var identityUsage = Client.DescribeIdentityUsage(new DescribeIdentityUsageRequest
            {
                IdentityId = identityId,
                IdentityPoolId = poolId
            }).IdentityUsage;

            Assert.IsNotNull(identityUsage);
            Assert.AreEqual(identityId, identityUsage.IdentityId);
            Assert.AreEqual(poolId, identityUsage.IdentityPoolId);

            datasets = GetAllDatasets(poolId, identityId);
            Assert.AreEqual(1, datasets.Count);

            Client.DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = datasetName,
                IdentityPoolId = poolId,
                IdentityId = identityId
            });

            datasets = GetAllDatasets(poolId, identityId);
            Assert.AreEqual(0, datasets.Count);

            AssertExtensions.ExpectException(() => Client.DescribeDataset(describeRequest));
        }

        private static AmazonCognitoSyncClient CreateAuthenticatedClient(string poolId, string poolName, string identityId, out string roleName)
        {
            string token;
            using (var cibClient = new Amazon.CognitoIdentity.AmazonCognitoIdentityClient(new AnonymousAWSCredentials()))
            {
                var getOpenIdResult = cibClient.GetOpenIdToken(new Amazon.CognitoIdentity.Model.GetOpenIdTokenRequest
                {
                    IdentityId = identityId,
                });
                token = getOpenIdResult.Token;
            }

            AWSCredentials credentials = null;
            using (var stsClient = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient(new AnonymousAWSCredentials()))
            {
                string roleArn;
                PrepareRole("RolePolicy", out roleName, out roleArn);

                // Add retries to allow the roles and identity to propagate
                for (int retries = 0; retries < 5; retries++)
                {
                    Thread.Sleep(1000 * retries);
                    try
                    {
                        var assumeRoleResult = stsClient.AssumeRoleWithWebIdentity(new Amazon.SecurityToken.Model.AssumeRoleWithWebIdentityRequest
                        {
                            WebIdentityToken = token,
                            RoleArn = roleArn,
                            RoleSessionName = "ProviderSession",
                        });
                        credentials = assumeRoleResult.Credentials;
                        break;
                    }
                    catch(Amazon.SecurityToken.AmazonSecurityTokenServiceException e)
                    {
                        if (!e.Message.Contains("Not authorized"))
                            throw;
                    }
                }
            }

            var authenticatedClient = new AmazonCognitoSyncClient(credentials);
            return authenticatedClient;
        }
        private static void PrepareRole(string rolePolicyName, out string roleName, out string roleArn)
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

            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient())
            {
                roleName = "NetWebIdentityRole" + new Random().Next();
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
            }

            // Allow time for policy to be configured
            Thread.Sleep(TimeSpan.FromSeconds(5));
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
        public static List<Record> GetAllRecords(string datasetName, string poolId, string identityId)
        {
            return GetAllRecordsHelper(datasetName, poolId, identityId).ToList();
        }
        public static List<Dataset> GetAllDatasets(string poolId, string identityId)
        {
            return GetAllDatasetsHelper(poolId, identityId).ToList();
        }

        private static IEnumerable<Record> GetAllRecordsHelper(string datasetName, string poolId, string identityId)
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
                result = Client.ListRecords(request);
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
        private static IEnumerable<Dataset> GetAllDatasetsHelper(string poolId, string identityId)
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
                result = Client.ListDatasets(request);
                foreach (var ds in result.Datasets)
                {
                    yield return ds;
                }

                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }
    }
}
