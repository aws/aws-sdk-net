//#define INCLUDE_FACEBOOK_TESTS

using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.CognitoSync;
using Amazon.CognitoSync.SyncManager;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.Runtime;
using System.IO;
using System.Data.SQLite;
using System.Threading;
#if BCL45
using System.Threading.Tasks;
#endif
using Amazon.Util.Internal;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    // Test methods in this class disabled due to lack of platform emulation for running tests build server
    [TestClass]
    public class SyncManager : TestBase<AmazonCognitoIdentityClient>
    {
        //tests that require facebook app id and secret are currently disabled.

        //identity related components
        public static int MaxResults = 15;

        private List<string> allPoolIds = new List<string>();
        private const PoolRoles poolRoles = PoolRoles.Unauthenticated | PoolRoles.Authenticated;

        [Flags]
        enum PoolRoles
        {
            None = 0,
            Authenticated = 1,
            Unauthenticated = 2
        }

#if INCLUDE_FACEBOOK_TESTS
        // Facebook information required to run Facebook tests
        public const string FacebookAppId = "";
        public const string FacebookAppSecret = "";
        private const string FacebookProvider = "graph.facebook.com";
        FacebookUtilities.FacebookCreateUserResponse facebookUser = null;
#endif

        private List<string> roleNames = new List<string>();
        private const string policyName = "TestPolicy";

        string poolid = null;
        string poolName = null;

        internal const string DB_FILE_NAME = "aws_cognito_sync.db";

#if BCL45
        protected static void RunAsSync(Func<Task> asyncFunc)
        {
            try
            {
                asyncFunc().Wait();
            }
            finally
            {

            }
        }
#endif

        [TestCleanup]
        public void Cleanup()
        {
            if (poolid != null)
                DeleteIdentityPool(poolid);

            CleanupCreatedRoles();

#if INCLUDE_FACEBOOK_TESTS
            if (facebookUser != null)
                FacebookUtilities.DeleteFacebookUser(facebookUser);
#endif
            //drop all the tables from the db
#if !BCL35
            var filePath = InternalSDKUtils.DetermineAppLocalStoragePath(DB_FILE_NAME);
            if (File.Exists(filePath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", filePath)))
                {
                    connection.Open();

                    SQLiteCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "DROP TABLE IF EXISTS records";
                    cmd.ExecuteNonQuery();

                    cmd = connection.CreateCommand();
                    cmd.CommandText = "DROP TABLE IF EXISTS datasets";
                    cmd.ExecuteNonQuery();

                    cmd = connection.CreateCommand();
                    cmd.CommandText = "DROP TABLE IF EXISTS kvstore";
                    cmd.ExecuteNonQuery();
                }
            }
#endif
            BaseClean();
        }

#if INCLUDE_FACEBOOK_TESTS
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void AuthenticatedCredentialsTest()
        {
            CognitoAWSCredentials authCred = AuthCredentials;

            string identityId = authCred.GetIdentityId();
            Assert.IsTrue(!string.IsNullOrEmpty(identityId));
            ImmutableCredentials cred = authCred.GetCredentials();
            Assert.IsNotNull(cred);
        }
#endif

        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void DatasetLocalStorageTest()
        {
            {
                using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
                {
                    syncManager.WipeData(false);
                    Dataset d = syncManager.OpenOrCreateDataset("testDataset");
                    d.Put("testKey", "testValue");
                }
            }
            {
                using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
                {
                    Dataset d = syncManager.OpenOrCreateDataset("testDataset");
                    Assert.AreEqual("testValue", d.Get("testKey"));
                }
            }
        }

        // <summary>
        /// Test case: Store a value in a dataset and sync it. Wipe all local data.
        /// After synchronizing the dataset we should have our stored value back.
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void DatasetCloudStorageTest()
        {
            string failureMessage = string.Empty;
            using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
            {
                syncManager.WipeData(false);
                Thread.Sleep(2000);
                using (Dataset d = syncManager.OpenOrCreateDataset("testDataset2"))
                {
                    d.Put("key", "he who must not be named");

                    d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
                    {
                        d.ClearAllDelegates();
                        string erasedValue = d.Get("key");
                        syncManager.WipeData(false);
                        d.OnSyncSuccess += delegate (object sender2, SyncSuccessEventArgs e2)
                        {
                            string restoredValues = d.Get("key");
                            if (erasedValue == null)
                            {
                                failureMessage += "erasedValue should not be null\n";
                            }
                            if (restoredValues == null)
                            {
                                failureMessage += "restoredValues should not be null\n";
                            }
                            if (erasedValue != restoredValues)
                            {
                                failureMessage += "erasedValue should equal restoredValues\n";
                            }
                        };
                        d.OnSyncFailure += delegate (object sender2, SyncFailureEventArgs e2)
                        {
                            failureMessage += "sync failed\n";
                        };
#if BCL35
                        d.Synchronize();
#else
                        RunAsSync(async () => await d.SynchronizeAsync());
#endif
                    };
                    d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
                    {
                        failureMessage += "sync failed\n";
                    };
                    d.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
                    {
                        failureMessage += "Expected SyncSuccess instead of SyncConflict\n";
                        return false;
                    };
                    d.OnDatasetMerged += (Dataset dataset, List<string> datasetNames) =>
                    {
                        failureMessage += "Did not expect DatasetMerged\n";
                        return false;
                    };
                    d.OnDatasetDeleted += (Dataset dataset) =>
                    {
                        failureMessage += "Did not expect DatasetDeleted\n";
                        return false;
                    };
#if BCL35
                    d.Synchronize();
#else
                    RunAsSync(async () => await d.SynchronizeAsync());
#endif
                }
            }
            if (!string.IsNullOrEmpty(failureMessage))
            {
                Assert.Fail(failureMessage);
            }
        }

#if INCLUDE_FACEBOOK_TESTS
        /// <summary>
        /// Test Case: 
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void MergeTest()
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            string uniqueName = ((DateTime.UtcNow - epoch).TotalSeconds).ToString();
            string uniqueName2 = uniqueName + "_";

            string failureMessage = string.Empty;
            UnAuthCredentials.Clear();

            using (CognitoSyncManager sm1 = new CognitoSyncManager(AuthCredentials))
            {
                sm1.WipeData(false);
                Thread.Sleep(2000);
                using (Dataset d = sm1.OpenOrCreateDataset("test"))
                {
                    d.Put(uniqueName, uniqueName);
                    d.OnSyncSuccess += delegate (object s1, SyncSuccessEventArgs e1)
                    {
                        UnAuthCredentials.Clear();

                        using (CognitoSyncManager sm2 = new CognitoSyncManager(UnAuthCredentials))
                        {
                            Thread.Sleep(2000);
                            using (Dataset d2 = sm2.OpenOrCreateDataset("test"))
                            {
                                d2.Put(uniqueName2, uniqueName2);
                                d2.OnSyncSuccess += delegate (object s2, SyncSuccessEventArgs e2)
                                {
                                    AuthCredentials.Clear();
                                    UnAuthCredentials.Clear();
                                    //now we will use auth credentials.
                                    using (CognitoSyncManager sm3 = new CognitoSyncManager(AuthCredentials))
                                    {
                                        Thread.Sleep(2000);
                                        using (Dataset d3 = sm3.OpenOrCreateDataset("test"))
                                        {
                                            bool mergeTriggered = false;
                                            d3.OnSyncSuccess += (object sender, SyncSuccessEventArgs e) =>
                                            {
                                                if (!mergeTriggered)
                                                {
                                                    failureMessage += "Expecting DatasetMerged instead of OnSyncSuccess\n";
                                                }
                                            };
                                            d3.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
                                            {
                                                failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                                            };
                                            d3.OnSyncConflict += (Dataset dataset, List<SyncConflict> syncConflicts) =>
                                            {
                                                failureMessage += "Not expecting OnSyncConflict\n";
                                                return false;
                                            };
                                            d3.OnDatasetDeleted += (Dataset dataset) =>
                                            {
                                                failureMessage += "Not expecting OnDatasetDeleted\n";
                                                return false;
                                            };
                                            d3.OnDatasetMerged += (Dataset ds, List<string> datasetNames) =>
                                            {
                                                mergeTriggered = true;
                                                return true;
                                            };
#if BCL35
                                            d3.Synchronize();
#else
                                            RunAsSync(async () => await d3.SynchronizeAsync());
#endif
                                        }
                                    }
                                };
                                d2.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
                                {
                                    failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                                };
                                d2.OnSyncConflict += (Dataset dataset, List<SyncConflict> conflicts) =>
                                {
                                    failureMessage += "Not expecting OnSyncConflict\n";
                                    return false;
                                };
                                d2.OnDatasetDeleted += (Dataset dataset) =>
                                {
                                    failureMessage += "Not expecting OnDatasetDeleted\n";
                                    return false;
                                };
                                d2.OnDatasetMerged += (Dataset dataset, List<string> datasetNames) =>
                                {
                                    failureMessage += "Not expecting OnDatasetMerged\n";
                                    return false;
                                };
#if BCL35
                                d2.Synchronize();
#else
                                RunAsSync(async () => await d2.SynchronizeAsync());
#endif
                            }
                        }
                    };
                    d.OnSyncFailure += delegate (object s, SyncFailureEventArgs e)
                    {
                        failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                    };
                    d.OnSyncConflict += (Dataset dataset, List<SyncConflict> syncConflicts) =>
                    {
                        failureMessage += "Not expecting OnSyncConflict\n";
                        return false;
                    };
                    d.OnDatasetDeleted += (Dataset dataset) =>
                    {
                        failureMessage += "Not expecting OnDatasetDeleted\n";
                        return false;
                    };
                    d.OnDatasetMerged += (Dataset dataset, List<string> datasetNames) =>
                    {
                        failureMessage += "Not expecting OnDatasetMerged\n";
                        return false;
                    };
#if BCL35
                    d.Synchronize();
#else
                    RunAsSync(async () => await d.SynchronizeAsync());
#endif
                }
            }
            if (!string.IsNullOrEmpty(failureMessage))
            {
                Assert.Fail(failureMessage);
            }
        }
#endif

        /// <summary>
        /// Test case: Check that the dataset metadata is modified appropriately when calling Synchronize.
        /// We test for the dirty bit, the sync count and the last modified timmestamp.
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void MetadataTest()
        {
            string failureMessage = string.Empty;
            using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
            {
                syncManager.WipeData(false);
                using (Dataset d = syncManager.OpenOrCreateDataset("testDataset6"))
                {
                    d.Put("testKey3", "the initial value");

                    //Initial properties
                    var records = d.Records;
                    Record r = d.Records[records.Count - 1];
                    long initialSyncCount = r.SyncCount;
                    bool initialDirty = r.IsModified;
                    DateTime initialDate = r.DeviceLastModifiedDate.Value;

                    d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
                    {
                        //Properties after Synchronize
                        Record r2 = d.Records[records.Count - 1];
                        long synchronizedSyncCount = r2.SyncCount;
                        bool synchronizedDirty = r2.IsModified;
                        DateTime synchronizedDate = r2.DeviceLastModifiedDate.Value;

                        d.Put("testKey3", "a new value");

                        //Properties after changing the content again
                        Record r3 = d.Records[records.Count - 1];
                        long finalSyncCount = r3.SyncCount;
                        bool finalDirty = r3.IsModified;
                        DateTime finalDate = r3.DeviceLastModifiedDate.Value;

                        if (!initialDirty)
                        {
                            failureMessage += "Expected 'initialDirty' to be true\n";
                        }
                        if (synchronizedDirty)
                        {
                            failureMessage += "Expected 'synchronizedDirty' to be false\n";
                        }
                        if (!finalDirty)
                        {
                            failureMessage += "Expected 'finalDirty' to be true\n";
                        }
                        if (synchronizedSyncCount <= initialSyncCount)
                        {
                            failureMessage += "Expected synchronizedSyncCount > initialSyncCount\n";
                        }
                        if (synchronizedSyncCount != finalSyncCount)
                        {
                            failureMessage += "Expected synchronizedSyncCount == finalSyncCount\n";
                        }
                        if (finalDate <= initialDate)
                        {
                            failureMessage += "Expected finalDate > initialDate\n";
                        }
                        if (initialDate != synchronizedDate)
                        {
                            failureMessage += "Expected initialDate == synchronizedDate\n";
                        }
                    };
                    d.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
                    {
                        failureMessage += e.Exception.ToString() + "\n";
                    };
#if BCL35
                    d.Synchronize();
#else
                    RunAsSync(async () => await d.SynchronizeAsync());
#endif
                    if (!string.IsNullOrEmpty(failureMessage))
                    {
                        Assert.Fail(failureMessage);
                    }
                }
            }
        }


        /// <summary>
        /// Test case: Produce a conflict and check that SyncConflict is triggered.
        /// Also check that by returning false in SyncConflict, the Synchronize operation
        /// is aborted and nothing else gets called. 
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void ConflictTest()
        {
            string failureMessage = string.Empty;
            using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
            {
                syncManager.WipeData(false);
                using (Dataset d = syncManager.OpenOrCreateDataset("testDataset3"))
                {
                    d.Put("testKey3", "the initial value");
                    d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
                    {
                        d.ClearAllDelegates();
                        syncManager.WipeData(false);
                        using (Dataset d2 = syncManager.OpenOrCreateDataset("testDataset3"))
                        {
                            bool conflictTriggered = false;
                            d2.Put("testKey3", "a different value");

                            d2.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
                            {
                                conflictTriggered = true;
                                return false;
                            };
                            d2.OnSyncSuccess += delegate (object sender4, SyncSuccessEventArgs e4)
                            {
                                failureMessage += "Expecting OnSyncConflict instead of OnSyncSuccess\n";
                            };
                            d2.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
                            {
                                if (!conflictTriggered)
                                {
                                    failureMessage += "Expecting OnSyncConflict instead of OnSyncFailure\n";
                                }
                            };
#if BCL35
                            d2.Synchronize();
#else
                            RunAsSync(async () => await d2.SynchronizeAsync());
#endif
                        }
                    };
                    d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
                    {
                        failureMessage += "Expecting OnSyncSuccess instead of OnSyncFailure\n";
                    };
#if BCL35
                    d.Synchronize();
#else
                    RunAsSync(async () => await d.SynchronizeAsync());
#endif
                }
            }
            if (!string.IsNullOrEmpty(failureMessage))
            {
                Assert.Fail(failureMessage);
            }
        }

        /// <summary>
        /// Test case: Produce a conflict and check that the three ways provided by the SDK
        /// for resolving a conflict (local wins, remote wins, and override) work. We also check
        /// that returning true in SyncConflict allows the Synchronization operationn to continue.
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void ResolveConflictTest()
        {
            string failureMessage = string.Empty;
            using (CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials))
            {
                syncManager.WipeData(false);
                using (Dataset d = syncManager.OpenOrCreateDataset("testDataset4"))
                {
                    d.Put("a", "1");
                    d.Put("b", "2");
                    d.Put("c", "3");
                    d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
                    {
                        d.ClearAllDelegates();
                        syncManager.WipeData(false);
                        using (Dataset d2 = syncManager.OpenOrCreateDataset("testDataset4"))
                        {
                            d2.Put("a", "10");
                            d2.Put("b", "20");
                            d2.Put("c", "30");

                            bool resolved = false;
                            d2.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
                            {
                                List<Amazon.CognitoSync.SyncManager.Record> resolvedRecords = new List<Amazon.CognitoSync.SyncManager.Record>();
                                int i = 0;
                                foreach (SyncConflict conflictRecord in conflicts)
                                {
                                    if (i == 0) resolvedRecords.Add(conflictRecord.ResolveWithLocalRecord());
                                    else if (i == 1) resolvedRecords.Add(conflictRecord.ResolveWithValue("42"));
                                    else resolvedRecords.Add(conflictRecord.ResolveWithRemoteRecord());
                                    i++;
                                }
                                dataset.Resolve(resolvedRecords);
                                resolved = true;
                                return true;
                            };
                            d2.OnSyncSuccess += delegate (object sender4, SyncSuccessEventArgs e4)
                            {
                                if (resolved)
                                {
                                    if (d2.Get("a") != "10")
                                    {
                                        failureMessage += "Value for key 'a' should be '10'\n";
                                    }
                                    if (d2.Get("b") != "42")
                                    {
                                        failureMessage += "Value for key 'b' should be '42'\n";
                                    }
                                    if (d2.Get("c") != "3")
                                    {
                                        failureMessage += "Value for key 'c' should be '3'\n";
                                    }
                                }
                                else
                                {
                                    failureMessage += "Expecting SyncConflict instead of SyncSuccess\n";
                                }

                            };
                            d2.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
                            {
                                failureMessage += "Expecting SyncConflict instead of SyncFailure\n";
                            };
#if BCL35
                            d2.Synchronize();
#else
                            RunAsSync(async () => await d2.SynchronizeAsync());
#endif
                        }
                    };
#if BCL35
                    d.Synchronize();
#else
                    RunAsSync(async () => await d.SynchronizeAsync());
#endif
                }
            }
            if (!string.IsNullOrEmpty(failureMessage))
            {
                Assert.Fail(failureMessage);
            }
        }


        /// <summary>
        /// Test case: Add and synchronize a dataset, then wipe data. Wiping data (while
        /// using unauthorized credentials) should wipe the dataset and the identity,
        /// so that the information in the dataset should no longer be retrievable.
        /// Check that the dataset is no longer in local memory and that syncing a
        /// dataset with the same record key does not cause a conflict.
        /// </summary>
        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void WipeDataTest()
        {
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = new CognitoSyncManager(UnAuthCredentials);
            syncManager.WipeData(false);
            Dataset d = syncManager.OpenOrCreateDataset("testDataset5");
            d.Put("testKey", "testValue");
            d.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
            {
                failureMessage += "Expecting SyncSuccess instead of SyncConflict\n";
                return false;
            };
            d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
            {
                failureMessage += "Expecting SyncSuccess instead of SyncFailure\n";
            };

            d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
            {
                syncManager.WipeData();
                Dataset d2 = syncManager.OpenOrCreateDataset("testDataset5");
                if (d2.Records.Count != 0)
                {
                    failureMessage += "Expecting dataset to be empty due to local data wipe.\n";
                }
                d2.Put("testKey", "newTestValue");
                d2.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
                {
                    failureMessage += "Expecting SyncSuccess instead of SyncConflict\n";
                    return false;
                };
                d2.OnSyncFailure += delegate (object sender2, SyncFailureEventArgs e2)
                {
                    failureMessage += "Expecting SyncSuccess instead of SyncFailure\n";
                };
                d2.OnSyncSuccess += delegate (object sender2, SyncSuccessEventArgs e2)
                {
                    if (d2.Get("testKey") != "newTestValue")
                    {
                        failureMessage += "Value for key 'testKey' should be 'newTestValue'\n";
                    }
                };
#if BCL35
                d2.Synchronize();
#else
                RunAsSync(async () => await d2.SynchronizeAsync());
#endif
            };
#if BCL35
            d.Synchronize();
#else
            RunAsSync(async () => await d.SynchronizeAsync());
#endif
            if (!string.IsNullOrEmpty(failureMessage))
            {
                Assert.Fail(failureMessage);
            }
        }

        //[TestMethod]
        //[TestCategory("SyncManager")]
        public void RemoveEntryTest()
        {
            string failureMessage = string.Empty;
            using (var syncManager = new CognitoSyncManager(UnAuthCredentials))
            {
                syncManager.WipeData(false);
                Dataset d = syncManager.OpenOrCreateDataset("testRemoveDataset");
                long originalCount = d.Metadata.RecordCount;
                d.Put("testKey", "testValue");
                d.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
                {
                    failureMessage += "Expecting SyncSuccess instead of SyncConflict\n";
                    return false;
                };
                d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
                {
                    failureMessage += "Expecting SyncSuccess instead of SyncFailure\n";
                };
#if BCL35
                d.Synchronize();
#else
                RunAsSync(async () => await d.SynchronizeAsync());
#endif
                if (!string.IsNullOrEmpty(failureMessage))
                {
                    Assert.Fail(failureMessage);
                }
                d.Remove("testKey");
#if BCL35
                d.Synchronize();
#else
                RunAsSync(async () => await d.SynchronizeAsync());
#endif
                if (d.Metadata.RecordCount != originalCount)
                {
                    failureMessage += "d.Metadata.RecordCount != originalCount\n";
                }

                d.Dispose();
                if (!string.IsNullOrEmpty(failureMessage))
                {
                    Assert.Fail(failureMessage);
                }
            }
        }

#if INCLUDE_FACEBOOK_TESTS
        private CognitoAWSCredentials _AuthCredentials;
        private CognitoAWSCredentials AuthCredentials
        {
            get
            {
                if (_AuthCredentials != null)
                {
                    if (_AuthCredentials.LoginsCount == 0 && facebookUser != null)
                    {
                        _AuthCredentials.AddLogin(FacebookProvider, facebookUser.AccessToken);
                    }
                    return _AuthCredentials;
                }


                if (poolid == null)
                {
                    CreateIdentityPool(out poolid, out poolName);
                    Thread.Sleep(2000);
                }
                facebookUser = FacebookUtilities.CreateFacebookUser(FacebookAppId, FacebookAppSecret);

                _AuthCredentials = new SQLiteCognitoAWSCredentials(poolid, Client.Config.RegionEndpoint);
                _AuthCredentials.AddLogin(FacebookProvider, facebookUser.AccessToken);
                //create facebook token
                return _AuthCredentials;
            }
        }
#endif


        private CognitoAWSCredentials _UnauthCredentials;
        private CognitoAWSCredentials UnAuthCredentials
        {
            get
            {
                if (_UnauthCredentials != null)
                    return _UnauthCredentials;

                if (poolid == null)
                    CreateIdentityPool(out poolid, out poolName);

                _UnauthCredentials = new SQLiteCognitoAWSCredentials(poolid, Client.Config.RegionEndpoint);
                return _UnauthCredentials;
            }
        }


        private void CreateIdentityPool(out string poolId, out string poolName)
        {
            poolName = "netTestPool" + DateTime.Now.ToFileTime();
            var request = new CreateIdentityPoolRequest
            {
                IdentityPoolName = poolName,
                AllowUnauthenticatedIdentities = true
#if INCLUDE_FACEBOOK_TESTS
,
                SupportedLoginProviders = new Dictionary<string, string>() { { FacebookProvider, FacebookAppId } }
#endif
            };

            var createPoolResult = Client.CreateIdentityPool(request);
            Assert.IsNotNull(createPoolResult.IdentityPoolId);
            Assert.IsNotNull(createPoolResult.IdentityPoolName);
            Assert.AreEqual(request.AllowUnauthenticatedIdentities, createPoolResult.AllowUnauthenticatedIdentities);
            poolId = createPoolResult.IdentityPoolId;
            allPoolIds.Add(poolId);

            var describePoolResult = Client.DescribeIdentityPool(new DescribeIdentityPoolRequest
            {
                IdentityPoolId = poolId
            });
            Assert.AreEqual(poolId, describePoolResult.IdentityPoolId);
            Assert.AreEqual(poolName, describePoolResult.IdentityPoolName);

            var getIdentityPoolRolesResult = Client.GetIdentityPoolRoles(poolId);
            Assert.AreEqual(poolId, getIdentityPoolRolesResult.IdentityPoolId);
            Assert.AreEqual(0, getIdentityPoolRolesResult.Roles.Count);

            var roles = new Dictionary<string, string>(StringComparer.Ordinal);
            if ((poolRoles & PoolRoles.Unauthenticated) == PoolRoles.Unauthenticated)
                roles["unauthenticated"] = PrepareRole();
            if ((poolRoles & PoolRoles.Authenticated) == PoolRoles.Authenticated)
                roles["authenticated"] = PrepareRole();

            Client.SetIdentityPoolRoles(new SetIdentityPoolRolesRequest
            {
                IdentityPoolId = poolId,
                Roles = roles
            });

            getIdentityPoolRolesResult = Client.GetIdentityPoolRoles(poolId);
            Assert.AreEqual(poolId, getIdentityPoolRolesResult.IdentityPoolId);
            Assert.AreEqual(NumberOfPoolRoles, getIdentityPoolRolesResult.Roles.Count);

            Thread.Sleep(2000);
        }


        private IEnumerable<IdentityPoolShortDescription> GetAllPoolsHelper()
        {
            var request = new ListIdentityPoolsRequest { MaxResults = MaxResults };
            ListIdentityPoolsResponse result;
            do
            {
                result = Client.ListIdentityPools(request);
                foreach (var pool in result.IdentityPools)
                {
                    Assert.IsNotNull(pool);
                    Assert.IsFalse(string.IsNullOrEmpty(pool.IdentityPoolId));
                    Assert.IsFalse(string.IsNullOrEmpty(pool.IdentityPoolName));
                    yield return pool;
                }

                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }

        private IEnumerable<IdentityDescription> GetAllIdentitiesHelper(string poolId)
        {
            var request = new ListIdentitiesRequest
            {
                MaxResults = MaxResults,
                IdentityPoolId = poolId
            };
            ListIdentitiesResponse result;
            do
            {
                result = Client.ListIdentities(request);
                foreach (var ident in result.Identities)
                {
                    Assert.IsNotNull(ident);
                    Assert.IsFalse(string.IsNullOrEmpty(ident.IdentityId));
                    Assert.IsNotNull(ident.Logins);
                    yield return ident;
                }
                request.NextToken = result.NextToken;
            } while (!string.IsNullOrEmpty(result.NextToken));
        }


        public List<IdentityPoolShortDescription> GetAllPools()
        {
            return GetAllPoolsHelper().ToList();
        }

        public List<IdentityDescription> GetAllIdentities(string poolId)
        {
            return GetAllIdentitiesHelper(poolId).ToList();
        }

        public void DeleteIdentityPool(string poolId)
        {
            if (!string.IsNullOrEmpty(poolId))
            {
                var allPools = GetAllPools();
                var pool = allPools.SingleOrDefault(p => string.Equals(poolId, p.IdentityPoolId, StringComparison.Ordinal));

                if (pool != null)
                {
                    Console.WriteLine("Found pool with id [{0}], deleting", poolId);

                    try
                    {
                        Client.DeleteIdentityPool(new DeleteIdentityPoolRequest
                        {
                            IdentityPoolId = poolId
                        });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("failed to delete [{0}]", poolId);
                        Console.WriteLine("exception e" + e.Message);
                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
        }

        private int NumberOfPoolRoles
        {
            get
            {
                int count = 0;
                if ((poolRoles & PoolRoles.Authenticated) == PoolRoles.Authenticated)
                    count++;
                if ((poolRoles & PoolRoles.Unauthenticated) == PoolRoles.Unauthenticated)
                    count++;
                return count;
            }
        }

        public void UpdateIdentityPool(string poolId, string poolName, Dictionary<string, string> providers)
        {
            var updateRequest = new UpdateIdentityPoolRequest
            {
                IdentityPoolName = poolName,
                IdentityPoolId = poolId,
                AllowUnauthenticatedIdentities = true,
            };
            if (providers != null && providers.Count > 0)
                updateRequest.SupportedLoginProviders = providers;

            Client.UpdateIdentityPool(updateRequest);
        }


        public string PrepareRole()
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

                Thread.Sleep(2000);

                identityClient.PutRolePolicy(new Amazon.IdentityManagement.Model.PutRolePolicyRequest
                {
                    PolicyDocument = allowPolicy,
                    PolicyName = policyName,
                    RoleName = response.Role.RoleName
                });

                Thread.Sleep(2000);

                roleArn = response.Role.Arn;
                roleNames.Add(roleName);
            }

            return roleArn;
        }

        public void CleanupCreatedRoles()
        {
            foreach (var roleName in roleNames)
            {
                DeleteRole(roleName);
            }
            roleNames.Clear();
        }

        private void DeleteRole(string roleName)
        {
            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient())
            {
                identityClient.DeleteRolePolicy(new Amazon.IdentityManagement.Model.DeleteRolePolicyRequest
                {
                    PolicyName = policyName,
                    RoleName = roleName
                });
                Thread.Sleep(2000);
                identityClient.DeleteRole(new Amazon.IdentityManagement.Model.DeleteRoleRequest
                {
                    RoleName = roleName
                });
                Thread.Sleep(2000);
            }
        }
    }
}
