using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;


using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using CommonTests.Framework;
using NUnit.Framework;

using System.IO.Compression;
using System.Text;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class LambdaTests : TestBase<AmazonLambdaClient>
	{
        static IAmazonIdentityManagementService iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        static List<string> createdFunctionNames = new List<string>();

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [TearDown]
        public void TestCleanup()
        {
            DeleteCreatedFunctions(Client);
        }

        public static void DeleteCreatedFunctions(IAmazonLambda lambdaClient)
        {
            var deletedFunctions = new List<string>();
            foreach(var function in createdFunctionNames)
            {
                try
                {
                    lambdaClient.DeleteFunctionAsync(function).Wait();
                    deletedFunctions.Add(function);
                }
                catch { }
            }

            foreach (var df in deletedFunctions)
                createdFunctionNames.Remove(df);
        }

        [Test]
        public void ListFunctionsTest()
        {
            var result = Client.ListFunctionsAsync().Result;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ResponseMetadata);
            Assert.IsNotNull(result.ResponseMetadata.RequestId);
        }
    }
}