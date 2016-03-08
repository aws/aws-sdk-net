using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AWSSDK.IntegrationTests.CognitoIdentity
{
    [TestFixture]
    public class CognitoIdentityTests : TestBase<AmazonCognitoIdentityClient>
    {
        public static int MaxResults = 15;
        private string poolName = null;
        private string poolId = null;
        private List<string> allPoolIds = new List<string>();
        private const PoolRoles poolRoles = PoolRoles.Unauthenticated | PoolRoles.Authenticated;

        [Flags]
        enum PoolRoles
        {
            None = 0,
            Authenticated = 1,
            Unauthenticated = 2
        }

        [OneTimeSetUp]
        public void CreatePool()
        {
            string responsePoolName = null;
            poolName = "unitytestpool" + DateTime.UtcNow.Ticks;
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.CreateIdentityPoolAsync(new CreateIdentityPoolRequest()
            {
                AllowUnauthenticatedIdentities = true,
                IdentityPoolName = poolName,
            }, (result) =>
            {
                poolId = result.Response.IdentityPoolId;
                responsePoolName = result.Response.IdentityPoolName;
                allPoolIds.Add(poolId);
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(poolId);
            Utils.AssertFalse(string.IsNullOrEmpty(poolId));
            CollectionAssert.IsNotEmpty(allPoolIds);
            Assert.AreEqual(poolName, responsePoolName);
        }

        [Test]
        [Category("WWW")]
        public void GetIdentityTests()
        {
            string identityId = null;
            ManualResetEvent mrs = new ManualResetEvent(false);
            Client.GetIdAsync(new GetIdRequest()
            {
                IdentityPoolId = poolId
            }, (result) =>
            {
                identityId = result.Response.IdentityId;
                mrs.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            mrs.WaitOne();

            Utils.AssertFalse(string.IsNullOrEmpty(identityId));
        }

        [Test]
        [Category("WWW")]
        public void CredentialsTests()
        {
            CognitoAWSCredentials cred1 = new CognitoAWSCredentials(poolId, ActualEndpoint);
            string id1 = null, id2 = null, id3 = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            cred1.GetIdentityIdAsync((result) =>
            {
                id1 = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            Utils.AssertFalse(string.IsNullOrEmpty(id1));
            var cred2 = new CognitoAWSCredentials(poolId, ActualEndpoint);
            cred2.GetIdentityIdAsync((result) =>
            {
                id2 = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertFalse(string.IsNullOrEmpty(id2));

            Assert.AreEqual(id1, id2);

            cred1.Clear();

            Utils.AssertStringIsNullOrEmpty(cred1.GetCachedIdentityId());

            cred1.GetIdentityIdAsync((result) =>
            {
                id3 = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();

            Assert.IsNotNull(id3);

            Assert.AreNotEqual(id1, id3);

            cred1.Clear();
            cred2.Clear();
        }

        [Test]
        [Category("WWW")]
        public void MultipleIdentityPoolTests()
        {
            CreatePool();
            Utils.AssertTrue(allPoolIds.Count == 2);
            var pool1 = allPoolIds[0];
            var pool2 = allPoolIds[1];

            var cred1 = new CognitoAWSCredentials(pool1, ActualEndpoint);
            var cred2 = new CognitoAWSCredentials(pool2, ActualEndpoint);
            string id1 = null, id2 = null;

            AutoResetEvent ars = new AutoResetEvent(false);

            cred1.GetIdentityIdAsync((result) =>
            {
                id1 = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            Utils.AssertFalse(string.IsNullOrEmpty(id1));
            cred2.GetIdentityIdAsync((result) =>
            {
                id2 = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            Utils.AssertFalse(string.IsNullOrEmpty(id2));
            Assert.AreNotEqual(id1, id2);
            cred1.Clear();
            Utils.AssertStringIsNullOrEmpty(cred1.GetCachedIdentityId());

            cred2.Clear();
            cred1.Clear();
        }


        [OneTimeTearDown]
        public void Clear()
        {
            for (int i = 0; i < allPoolIds.Count; i++)
            {
                var pool = allPoolIds[i];
                DeletePool(pool);
            }
            allPoolIds.Clear();
        }

        private void DeletePool(string poolId)
        {
            int statusCode = 1000;
            ManualResetEvent mrs = new ManualResetEvent(false);
            Client.DeleteIdentityPoolAsync(new DeleteIdentityPoolRequest()
            {
                IdentityPoolId = poolId
            }, (result) =>
            {
                statusCode = (int)result.Response.HttpStatusCode;
                mrs.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            mrs.WaitOne();
            Utils.AssertTrue(statusCode < 300);
        }


    }
}
