using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.CognitoSync;
using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
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
        [TestCleanup]
        public void Cleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("CognitoSync")]
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
    }
}
