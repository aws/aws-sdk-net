using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Resources;
using Amazon.IdentityManagement;
using AWSSDK_DotNet.IntegrationTests.Tests.IAM;

namespace AWSSDK_DotNet.IntegrationTests.Tests.ResourcesAPI
{
    [TestClass]
    public class ServiceHasMany : TestBase<AmazonIdentityManagementServiceClient>
    {
        static IdentityManagementService iam = null;

        [ClassInitialize]
        public static void Initialize(TestContext a)
        {
            iam = new IdentityManagementService(Client);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            iam.Dispose();
            BaseClean();
        }

        [TestMethod]
        [TestCategory("ResourcesAPI")]
        public void PageableandReturnsResources()
        {
            var initialUsersCount = Client.ListUsers().Users.Count;
            var usersToCreate = 5;
            var userNames = new List<string>();
            for (int i = 0; i < usersToCreate; i++)
            {
                userNames.Add("sdk-testuser-" + DateTime.Now.Ticks);
                var request = new CreateUserRequest() { UserName = userNames[i], Path = IAMUtil.TEST_PATH };
                var response = Client.CreateUser(request);
            }
            try
            {
                var users = iam.GetUsers(new ListUsersRequest
                {
                    MaxItems = 2
                });

                foreach (var user in userNames)
                {
                    Assert.IsTrue(users.Any(u => u.Name == user));
                }
            }
            finally
            {
                foreach (var user in userNames)
                {
                    Client.DeleteUser(new DeleteUserRequest() { UserName = user });
                }
            }
        }

        [TestMethod]
        [TestCategory("ResourcesAPI")]
        public void NotPageableandDoesNotReturnResources()
        {
            var initialUsersCount = Client.ListSAMLProviders().SAMLProviderList.Count;
            //var usersToCreate = 5;
            //var userNames = new List<string>();
            //for (int i = 0; i < usersToCreate; i++)
            //{
            //    userNames.Add("sdk-testuser-" + DateTime.Now.Ticks);
            //    var request = new CreateUserRequest() { UserName = userNames[i], Path = IAMUtil.TEST_PATH };
            //    var response = Client.CreateUser(request);
            //}
            try
            {
                var users = iam.GetSamlProviders(new ListSAMLProvidersRequest
                {                   
                });

                //foreach (var user in userNames)
                //{
                //    Assert.IsTrue(users.Any(u => u.Name == user));
                //}
            }
            finally
            {
                //foreach (var user in userNames)
                //{
                //    Client.DeleteUser(new DeleteUserRequest() { UserName = user });
                //}
            }
        }
    }
}
