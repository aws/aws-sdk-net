//#define INCLUDE_FACEBOOK_TESTS
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.CognitoSync.SyncManager;
using Amazon.Runtime;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace AWSSDK.IntegrationTests.SyncManager
{
    [TestFixture(TestOf = typeof(SyncManagerTests))]
    [Category("SyncManager")]
    [Category("Integration")]
    public class SyncManagerTests : TestBase<AmazonCognitoIdentityClient>
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

        [OneTimeSetUp]
        public void Setup()
        {
            // Initialize these now instead of attemping to create them on the main thread when creating a sync mananger
            _UnauthCredentials = UnAuthCredentials;
#if INCLUDE_FACEBOOK_TESTS
            _AuthCredentials = AuthCredentials;
#endif
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            if (poolid != null)
            {
                DeleteIdentityPool(poolid);
            }
            CleanupCreatedRoles();

#if INCLUDE_FACEBOOK_TESTS
            if (facebookUser != null)
                FacebookUtilities.DeleteFacebookUser(facebookUser);
#endif
        }

        [TearDown]
        public void TearDown()
        {
            if (_UnauthCredentials != null) { _UnauthCredentials.Clear(); }
#if INCLUDE_FACEBOOK_TESTS
            if (_AuthCredentials != null) { _AuthCredentials.Clear(); }
#endif
        }


#if INCLUDE_FACEBOOK_TESTS
        [Test]
        public void AuthenticatedCredentialsTest()
        {
            CognitoAWSCredentials authCred = AuthCredentials;

            string identityId = authCred.GetIdentityId();
            Utils.AssertStringIsNotNullOrEmpty(identityId);
            ImmutableCredentials cred = authCred.GetCredentials();
            Utils.AssertFalse(cred == null);
        }
#endif

        [Test]
        public void DatasetLocalStorageTest()
        {
            {
                CognitoSyncManager syncManager = null;
                AutoResetEvent mainThreadArs = new AutoResetEvent(false);
                Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                    mainThreadArs.Set();
                });
                mainThreadArs.WaitOne();
                syncManager.WipeData(false);
                Dataset d = syncManager.OpenOrCreateDataset("testDataset");
                d.Put("testKey", "testValue");
                syncManager.Dispose();
            }
            {
                CognitoSyncManager syncManager = null;
                AutoResetEvent mainThreadArs = new AutoResetEvent(false);
                Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                    mainThreadArs.Set();
                });
                mainThreadArs.WaitOne();
                try
                {
                    Dataset d = syncManager.OpenOrCreateDataset("testDataset");
                    Utils.AssertTrue("testValue" == d.Get("testKey"));
                }
                finally
                {
                    syncManager.Dispose();
                }
            }
        }

        // <summary>
        /// Test case: Store a value in a dataset and sync it. Wipe all local data.
        /// After synchronizing the dataset we should have our stored value back.
        /// </summary>
        [Test]
        public void DatasetCloudStorageTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            syncManager.WipeData(false);
            Thread.Sleep(2000);
            Dataset d = syncManager.OpenOrCreateDataset("testDataset2");

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
                    ars.Set();
                };
                d.OnSyncFailure += delegate (object sender2, SyncFailureEventArgs e2)
                {
                    failureMessage += "sync failed\n";
                    ars.Set();
                };
                d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            };
            d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
            {
                failureMessage += "sync failed\n";
                ars.Set();
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
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            d.Dispose();
            syncManager.Dispose();

            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }

#if INCLUDE_FACEBOOK_TESTS
        /// <summary>
        /// Test Case: 
        /// </summary>
        [Test]
        public void MergeTest()
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            string uniqueName = ((DateTime.UtcNow - epoch).TotalSeconds).ToString();
            string uniqueName2 = uniqueName + "_";

            UnAuthCredentials.Clear();

            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;

            CognitoSyncManager sm1 = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                sm1 = new CognitoSyncManager(AuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            sm1.WipeData(false);
            Thread.Sleep(2000);
            Dataset d = sm1.OpenOrCreateDataset("test");
            d.Put(uniqueName, uniqueName);
            d.OnSyncSuccess += delegate (object s1, SyncSuccessEventArgs e1)
            {
                ars.Set();
            };
            d.OnSyncFailure += delegate (object s, SyncFailureEventArgs e)
            {
                failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                ars.Set();
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
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            d.Dispose();
            sm1.Dispose();
            Utils.AssertStringIsNullOrEmpty(failureMessage);

            UnAuthCredentials.Clear();

            CognitoSyncManager sm2 = null;
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                sm2 = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            Thread.Sleep(2000);

            Dataset d2 = sm2.OpenOrCreateDataset("test");
            d2.Put(uniqueName2, uniqueName2);
            d2.OnSyncSuccess += delegate (object s2, SyncSuccessEventArgs e2)
            {
                ars.Set();
            };
            d2.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
            {
                failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                ars.Set();
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
            d2.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            d2.Dispose();
            sm2.Dispose();
            Utils.AssertStringIsNullOrEmpty(failureMessage);

            AuthCredentials.Clear();
            UnAuthCredentials.Clear();

            CognitoSyncManager sm3 = null;
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                sm3 = new CognitoSyncManager(AuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();

            Thread.Sleep(2000);

            Dataset d3 = sm3.OpenOrCreateDataset("test");
            bool mergeTriggered = false;
            d3.OnSyncSuccess += (object sender, SyncSuccessEventArgs e) =>
            {
                if (!mergeTriggered)
                {
                    failureMessage += "Expecting DatasetMerged instead of OnSyncSuccess\n";
                }
                ars.Set();
            };
            d3.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
            {
                failureMessage += string.Format("Not expecting OnSyncFailure Got exception {0}\n", e.Exception.Message);
                ars.Set();
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
            d3.OnDatasetMerged += delegate (Dataset ds, List<string> datasetNames)
            {
                mergeTriggered = true;
                return true;
            };
            d3.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }
#endif

        /// <summary>
        /// Test case: Check that the dataset metadata is modified appropriately when calling Synchronize.
        /// We test for the dirty bit, the sync count and the last modified timmestamp.
        /// </summary>
        [Test]
        public void MetadataTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
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
                        Debug.LogWarning(initialDate);
                        Debug.LogWarning(synchronizedDate);
                        failureMessage += "Expected initialDate == synchronizedDate\n";
                    }
                    ars.Set();
                };
                d.OnSyncFailure += (object sender, SyncFailureEventArgs e) =>
                {
                    failureMessage += e.Exception.ToString() + "\n";
                    ars.Set();
                };
                d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
            }
            syncManager.Dispose();
            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }


        /// <summary>
        /// Test case: Produce a conflict and check that SyncConflict is triggered.
        /// Also check that by returning false in SyncConflict, the Synchronize operation
        /// is aborted and nothing else gets called. 
        /// </summary>
        [Test]
        public void ConflictTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            syncManager.WipeData(false);
            Dataset d = syncManager.OpenOrCreateDataset("testDataset3");
            Dataset d2 = null;
            d.Put("testKey3", "the initial value");
            d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
            {
                d.ClearAllDelegates();
                syncManager.WipeData(false);
                d2 = syncManager.OpenOrCreateDataset("testDataset3");

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
                    ars.Set();
                };
                d2.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
                {
                    if (!conflictTriggered)
                    {
                        failureMessage += "Expecting OnSyncConflict instead of OnSyncFailure\n";
                    }
                    ars.Set();
                };
                d2.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            };
            d.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
            {
                failureMessage += "Expecting OnSyncSuccess instead of OnSyncFailure\n";
                ars.Set();
            };
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            if (d2 != null)
            {
                d2.Dispose();
            }
            d.Dispose();
            syncManager.Dispose();

            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }

        /// <summary>
        /// Test case: Produce a conflict and check that the three ways provided by the SDK
        /// for resolving a conflict (local wins, remote wins, and override) work. We also check
        /// that returning true in SyncConflict allows the Synchronization operationn to continue.
        /// </summary>
        [Test]
        public void ResolveConflictTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            syncManager.WipeData(false);
            Dataset d = syncManager.OpenOrCreateDataset("testDataset4");
            Dataset d2 = null;
            d.Put("a", "1");
            d.Put("b", "2");
            d.Put("c", "3");
            d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
            {
                d.ClearAllDelegates();
                syncManager.WipeData(false);
                d2 = syncManager.OpenOrCreateDataset("testDataset4");
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
                    ars.Set();
                };
                d2.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
                {
                    failureMessage += "Expecting SyncConflict instead of SyncFailure\n";
                    ars.Set();
                };
                d2.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            };
            d.OnSyncFailure += delegate (object sender4, SyncFailureEventArgs e4)
            {
                failureMessage += "Expecting SyncConflict instead of SyncFailure\n";
                ars.Set();
            };
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            d.Dispose();
            if (d2 != null)
            {
                d2.Dispose();
            }
            syncManager.Dispose();
            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }


        /// <summary>
        /// Test case: Add and synchronize a dataset, then wipe data. Wiping data (while
        /// using unauthorized credentials) should wipe the dataset and the identity,
        /// so that the information in the dataset should no longer be retrievable.
        /// Check that the dataset is no longer in local memory and that syncing a
        /// dataset with the same record key does not cause a conflict.
        /// </summary>
        [Test]
        public void WipeDataTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
            syncManager.WipeData(false);
            Dataset d = syncManager.OpenOrCreateDataset("testDataset5");
            Dataset d2 = null;
            d.Put("testKey", "testValue");
            d.OnSyncConflict += delegate (Dataset dataset, List<SyncConflict> conflicts)
            {
                failureMessage += "Expecting SyncSuccess instead of SyncConflict\n";
                return false;
            };
            d.OnSyncFailure += delegate (object sender, SyncFailureEventArgs e)
            {
                failureMessage += "Expecting SyncSuccess instead of SyncFailure\n";
                ars.Set();
            };

            d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
            {
                syncManager.WipeData();
                d2 = syncManager.OpenOrCreateDataset("testDataset5");
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
                    ars.Set();
                };
                d2.OnSyncSuccess += delegate (object sender2, SyncSuccessEventArgs e2)
                {
                    if (d2.Get("testKey") != "newTestValue")
                    {
                        failureMessage += "Value for key 'testKey' should be 'newTestValue'\n";
                    }
                    ars.Set();
                };
                d2.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            };
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            syncManager.Dispose();
            d.Dispose();
            if (d2 != null)
            {
                d2.Dispose();
            }
            Utils.AssertStringIsNullOrEmpty(failureMessage);
        }

        [Test]
        public void RemoveEntryTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            string failureMessage = string.Empty;
            CognitoSyncManager syncManager = null;
            AutoResetEvent mainThreadArs = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                syncManager = new CognitoSyncManager(UnAuthCredentials, TestRunner.RegionEndpoint);
                mainThreadArs.Set();
            });
            mainThreadArs.WaitOne();
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
                ars.Set();
            };

            d.OnSyncSuccess += delegate (object sender, SyncSuccessEventArgs e)
            {
                ars.Set();
            };
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertStringIsNullOrEmpty(failureMessage);

            d.Remove("testKey");
            d.SynchronizeAsync(new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            if (d.Metadata.RecordCount != originalCount)
            {
                failureMessage += "d.Metadata.RecordCount != originalCount\n";
            }

            syncManager.Dispose();
            d.Dispose();
            Utils.AssertStringIsNullOrEmpty(failureMessage);
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

                _AuthCredentials = new CognitoAWSCredentials(poolid, TestRunner.RegionEndpoint);
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

                _UnauthCredentials = new CognitoAWSCredentials(poolid, TestRunner.RegionEndpoint);
                return _UnauthCredentials;
            }
        }

        private void CreateIdentityPool(out string poolId, out string poolName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            poolName = "unityTestPool" + DateTime.Now.ToFileTime();
            var request = new CreateIdentityPoolRequest
            {
                IdentityPoolName = poolName,
                AllowUnauthenticatedIdentities = true
#if INCLUDE_FACEBOOK_TESTS
,
                SupportedLoginProviders = new Dictionary<string, string>() { { FacebookProvider, FacebookAppId } }
#endif
            };
            string identityPoolId = null;
            string identityPoolName = null;
            bool allowUnauthenticatedIdentities = false;
            Client.CreateIdentityPoolAsync(request, (response) =>
            {
                responseException = response.Exception;
                if (response.Exception == null)
                {
                    identityPoolId = response.Response.IdentityPoolId;
                    identityPoolName = response.Response.IdentityPoolName;
                    allowUnauthenticatedIdentities = response.Response.AllowUnauthenticatedIdentities;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
            Utils.AssertStringIsNotNullOrEmpty(identityPoolId);
            Utils.AssertStringIsNotNullOrEmpty(identityPoolName);
            Utils.AssertTrue(request.AllowUnauthenticatedIdentities == allowUnauthenticatedIdentities);
            poolId = identityPoolId;
            allPoolIds.Add(poolId);

            Client.DescribeIdentityPoolAsync(new DescribeIdentityPoolRequest
            {
                IdentityPoolId = poolId
            }, (response) =>
            {
                responseException = response.Exception;
                if (response.Exception == null)
                {
                    identityPoolId = response.Response.IdentityPoolId;
                    identityPoolName = response.Response.IdentityPoolName;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
            Utils.AssertTrue(poolId == identityPoolId);
            Utils.AssertTrue(poolName == identityPoolName);

            Dictionary<string, string> roles = null;
            Client.GetIdentityPoolRolesAsync(poolId, (response) =>
            {
                responseException = response.Exception;
                if (response.Exception == null)
                {
                    identityPoolId = response.Response.IdentityPoolId;
                    roles = response.Response.Roles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
            Utils.AssertTrue(poolId == identityPoolId);
            Utils.AssertFalse(roles == null);
            Utils.AssertTrue(0 == roles.Count);

            roles = new Dictionary<string, string>(StringComparer.Ordinal);
            if ((poolRoles & PoolRoles.Unauthenticated) == PoolRoles.Unauthenticated)
                roles["unauthenticated"] = PrepareRole();
            if ((poolRoles & PoolRoles.Authenticated) == PoolRoles.Authenticated)
                roles["authenticated"] = PrepareRole();

            Client.SetIdentityPoolRolesAsync(new SetIdentityPoolRolesRequest
            {
                IdentityPoolId = poolId,
                Roles = roles
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);

            Client.GetIdentityPoolRolesAsync(poolId, (response) =>
            {
                responseException = response.Exception;
                if (response.Exception == null)
                {
                    identityPoolId = response.Response.IdentityPoolId;
                    roles = response.Response.Roles;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
            Utils.AssertTrue(poolId == identityPoolId);
            Utils.AssertTrue(NumberOfPoolRoles == roles.Count);

            //Thread.Sleep(2000);
        }

        private IEnumerable<IdentityPoolShortDescription> GetAllPoolsHelper()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            var request = new ListIdentityPoolsRequest { MaxResults = MaxResults };

            string nextToken = null;
            do
            {
                List<IdentityPoolShortDescription> identityPools = null;
                Client.ListIdentityPoolsAsync(request, (response) =>
                {
                    responseException = response.Exception;
                    if (response.Exception == null)
                    {
                        identityPools = response.Response.IdentityPools;
                        nextToken = response.Response.NextToken;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException); ;
                foreach (var pool in identityPools)
                {
                    Utils.AssertFalse(pool == null);
                    Utils.AssertStringIsNotNullOrEmpty(pool.IdentityPoolId);
                    Utils.AssertStringIsNotNullOrEmpty(pool.IdentityPoolName);
                    yield return pool;
                }

                request.NextToken = nextToken;
            } while (!string.IsNullOrEmpty(nextToken));
        }

        private IEnumerable<IdentityDescription> GetAllIdentitiesHelper(string poolId)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            var request = new ListIdentitiesRequest
            {
                MaxResults = MaxResults,
                IdentityPoolId = poolId
            };
            string nextToken = null;
            do
            {
                List<IdentityDescription> identities = null;
                Client.ListIdentitiesAsync(request, (response) =>
                {
                    responseException = response.Exception;
                    if (response.Exception == null)
                    {
                        identities = response.Response.Identities;
                        nextToken = response.Response.NextToken;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                foreach (var ident in identities)
                {
                    Utils.AssertFalse(ident == null);
                    Utils.AssertStringIsNotNullOrEmpty(ident.IdentityId);
                    Utils.AssertFalse(ident.Logins == null);
                    yield return ident;
                }
                request.NextToken = nextToken;
            } while (!string.IsNullOrEmpty(nextToken));
        }


        public List<IdentityPoolShortDescription> GetAllPools()
        {
            var pools = new List<IdentityPoolShortDescription>();
            foreach (var pool in GetAllPoolsHelper())
            {
                pools.Add(pool);
            }
            return pools;
        }

        public List<IdentityDescription> GetAllIdentities(string poolId)
        {
            var identities = new List<IdentityDescription>();
            foreach (var idenitity in GetAllIdentitiesHelper(poolId))
            {
                identities.Add(idenitity);
            }
            return identities;
        }

        public void DeleteIdentityPool(string poolId)
        {
            if (!string.IsNullOrEmpty(poolId))
            {
                IdentityPoolShortDescription pool = null;
                foreach (var p in GetAllPoolsHelper())
                {
                    if (string.Equals(poolId, p.IdentityPoolId, StringComparison.Ordinal))
                    {
                        pool = p;
                        break;
                    }
                }

                if (pool != null)
                {
                    Console.WriteLine("Found pool with id [{0}], deleting", poolId);

                    AutoResetEvent ars = new AutoResetEvent(false);
                    Exception responseException = new Exception();

                    Client.DeleteIdentityPoolAsync(new DeleteIdentityPoolRequest
                    {
                        IdentityPoolId = poolId
                    }, (response) =>
                    {
                        responseException = response.Exception;
                        ars.Set();
                    }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                    ars.WaitOne();
                    if (responseException != null)
                    {
                        Debug.LogWarning(string.Format(@"failed to delete [{0}]", poolId));
                        Debug.LogException(responseException);
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

        //        public void UpdateIdentityPool(string poolId, string poolName, Dictionary<string, string> providers)
        //        {
        //            var updateRequest = new UpdateIdentityPoolRequest
        //            {
        //                IdentityPoolName = poolName,
        //                IdentityPoolId = poolId,
        //                AllowUnauthenticatedIdentities = true,
        //            };
        //            if (providers != null && providers.Count > 0)
        //                updateRequest.SupportedLoginProviders = providers;

        //            Client.UpdateIdentityPool(updateRequest);
        //        }


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
            string roleArn = null;
            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient(TestRunner.Credentials))
            {
                AutoResetEvent ars = new AutoResetEvent(false);
                Exception responseException = new Exception();

                string roleName = "UnityWebIdentityRole" + DateTime.Now.Ticks;
                identityClient.CreateRoleAsync(new Amazon.IdentityManagement.Model.CreateRoleRequest
                {
                    AssumeRolePolicyDocument = assumeRolePolicy,
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        roleArn = response.Response.Role.Arn;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);

                Thread.Sleep(2000);
                identityClient.PutRolePolicyAsync(new Amazon.IdentityManagement.Model.PutRolePolicyRequest
                {
                    PolicyDocument = allowPolicy,
                    PolicyName = policyName,
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);

                Thread.Sleep(2000);
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
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            using (var identityClient = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient(TestRunner.Credentials))
            {
                identityClient.DeleteRolePolicyAsync(new Amazon.IdentityManagement.Model.DeleteRolePolicyRequest
                {
                    PolicyName = policyName,
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                Thread.Sleep(2000);
                identityClient.DeleteRoleAsync(new Amazon.IdentityManagement.Model.DeleteRoleRequest
                {
                    RoleName = roleName
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                Thread.Sleep(2000);
            }
        }
    }
}
