using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CommonTests.Framework;
using System.Threading;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for LoginProfileTests
    /// </summary>
    [TestFixture]
    public class LoginProfileTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void TestSetup()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [Test]
        [Category("IAM")]
        public void TestCreateGetLoginProfile()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strongpassword";

            try
            {
                CreateLoginProfileResponse createRes =
                    Client.CreateLoginProfileAsync(new CreateLoginProfileRequest
                    {
                        UserName = username,
                        Password = password,
                        PasswordResetRequired = true
                    }).Result;

                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));

                Assert.AreEqual(username, createRes.LoginProfile.UserName);

                GetLoginProfileResponse getRes =
                    Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
                Assert.AreNotEqual(DateTime.MinValue, getRes.LoginProfile.CreateDate);

                var login = getRes.LoginProfile;
                Assert.AreEqual(username, login.UserName);
                Assert.IsTrue(login.PasswordResetRequired);


                Client.UpdateLoginProfileAsync(new UpdateLoginProfileRequest
                {
                    UserName = username,
                    Password = password,
                    PasswordResetRequired = false
                }).Wait();

                Assert.AreEqual(username, createRes.LoginProfile.UserName);

                getRes = Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
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

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestCreateLoginProfileTwiceException()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strong-password";

            try
            {
                Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<EntityAlreadyExistsException>(ae);
            }
            finally 
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteLoginProfile()
        {
            string username = IAMUtil.CreateTestUser(Client);
            string password = "strong-password";

            try
            {
                Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                Client.DeleteLoginProfileAsync(new DeleteLoginProfileRequest() { UserName = username }).Wait();
                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                GetLoginProfileResponse getRes =
                    Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

    }
}
