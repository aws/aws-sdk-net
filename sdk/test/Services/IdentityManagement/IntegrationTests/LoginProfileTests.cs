using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for LoginProfileTests
    /// </summary>
    [TestClass]
    public class LoginProfileTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public LoginProfileTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCreateGetLoginProfile()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strongpassword";

            try
            {
                CreateLoginProfileResponse createRes =
                    Client.CreateLoginProfile(new CreateLoginProfileRequest
                    {
                        UserName = username,
                        Password = password,
                        PasswordResetRequired = true
                    });

                Thread.Sleep(3 * 3600);

                Assert.AreEqual(username, createRes.LoginProfile.UserName);

                GetLoginProfileResponse getRes =
                    Client.GetLoginProfile(new GetLoginProfileRequest() { UserName = username });
                Assert.AreNotEqual(DateTime.MinValue, getRes.LoginProfile.CreateDate);

                var login = getRes.LoginProfile;
                Assert.AreEqual(username, login.UserName);
                Assert.IsTrue(login.PasswordResetRequired);


                Client.UpdateLoginProfile(new UpdateLoginProfileRequest
                {
                    UserName = username,
                    Password = password,
                    PasswordResetRequired = false
                });

                Assert.AreEqual(username, createRes.LoginProfile.UserName);

                getRes = Client.GetLoginProfile(new GetLoginProfileRequest() { UserName = username });
                Assert.AreNotEqual(DateTime.MinValue, getRes.LoginProfile.CreateDate);

                login = getRes.LoginProfile;
                Assert.AreEqual(username, login.UserName);
                Assert.IsFalse(login.PasswordResetRequired);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestCreateLoginProfileTwiceException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strong-password";

            try
            {
                Client.CreateLoginProfile(new CreateLoginProfileRequest() { UserName = username, Password = password });
                Thread.Sleep(3 * 3600);
                Client.CreateLoginProfile(new CreateLoginProfileRequest() { UserName = username, Password = password });
            }
            finally 
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteLoginProfile()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strong-password";

            try
            {
                Client.CreateLoginProfile(new CreateLoginProfileRequest() { UserName = username, Password = password });
                Thread.Sleep(3 * 3600);
                Client.DeleteLoginProfile(new DeleteLoginProfileRequest() { UserName = username });
                Thread.Sleep(3 * 3600);
                GetLoginProfileResponse getRes =
                    Client.GetLoginProfile(new GetLoginProfileRequest() { UserName = username });
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

    }
}
