using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for GetUserTest
    /// </summary>
    [TestFixture]
    public class UserTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [SetUp]
        public void PreTestRun()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [Test]
        [Category("IAM")]
        public void TestGetUserImplicit()
        {
            GetUserRequest request = new GetUserRequest();

            GetUserResponse response = Client.GetUserAsync(request).Result;
            Assert.IsFalse(string.IsNullOrEmpty(response.User.Arn));

            // The assert will succeed if you run with root credentials.
            //Assert.AreEqual(string.Format("arn:aws:iam::{0}:root", response.User.UserId), response.User.Arn);
        }

        [Test]
        [Category("IAM")]
        public void TestCreateGetUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                CreateUserRequest request = new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH };
                CreateUserResponse response = Client.CreateUserAsync(request).Result;
                Assert.AreEqual(username, response.User.UserName);
                GetUserResponse getResponse = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.AreEqual(username, getResponse.User.UserName);
                Assert.AreNotEqual(DateTime.MinValue, getResponse.User.CreateDate);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListUsers()
        {
            string username1 = IAMUtil.CreateTestUser(Client);
            string username2 = IAMUtil.CreateTestUser(Client);
            string username3 = IAMUtil.CreateTestUser(Client);
            try
            {
                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = IAMUtil.TEST_PATH }).Result;

                Assert.AreEqual(3, response.Users.Count());

                int matches = 0;
                foreach(User user in response.Users)
                {
                    if (user.UserName.Equals(username1))
                        matches |= 1;
                    if (user.UserName.Equals(username2))
                        matches |= 2;
                    if (user.UserName.Equals(username3))
                        matches |= 4;
                }
                Assert.AreEqual(7, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestUserWithPath()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            string path = IAMUtil.MakePath("one", "two", "three");
            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = path }).Wait();
                GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.AreEqual(username, response.User.UserName);
                Assert.AreEqual(path, response.User.Path);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListUsersByPath()
        {
            string username1 = "sdk-testuser1-" + DateTime.Now.Ticks;
            string username2 = "sdk-testuser2-" + DateTime.Now.Ticks;
            string username3 = "sdk-testuser3-" + DateTime.Now.Ticks;
            string username4 = "sdk-testuser4-" + DateTime.Now.Ticks;

            string pathA = IAMUtil.MakePath("A");
            string pathB = IAMUtil.MakePath("B");

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = pathB }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username4, Path = pathA }).Wait();

                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = pathA }).Result;

                Assert.AreEqual(3, response.Users.Count());

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 4;
                    if (u.UserName.Equals(username3))
                        Assert.Fail();
                }
                Assert.AreEqual(7, matches);

                response = Client.ListUsersAsync(new ListUsersRequest(){ PathPrefix = pathB }).Result;

                Assert.AreEqual(1, response.Users.Count());
               
                matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        Assert.Fail();
                    if (u.UserName.Equals(username2))
                        Assert.Fail();
                    if (u.UserName.Equals(username4))
                        Assert.Fail();
                    if (u.UserName.Equals(username3))
                        matches = 1;
                }
                Assert.AreEqual(1, matches);

                response = Client.ListUsersAsync(new ListUsersRequest(){ PathPrefix = IAMUtil.TEST_PATH }).Result;
                Assert.AreEqual(4, response.Users.Count());

            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestListUsersMaxResults()
        {
            string username1 = IAMUtil.CreateTestUser(Client);
            string username2 = IAMUtil.CreateTestUser(Client);
            string username3 = IAMUtil.CreateTestUser(Client);
            string username4 = IAMUtil.CreateTestUser(Client);

            try
            {
                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { MaxItems = 2, PathPrefix = IAMUtil.TEST_PATH }).Result;

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(true, response.IsTruncated);

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                string marker = response.Marker;

                response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = IAMUtil.TEST_PATH, Marker = marker }).Result;

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.AreEqual(7, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [Test]
        [Category("IAM")]
        public void TestUpdateUser()
        {
            string
                username    = "sdk-testuser-" + DateTime.Now.Ticks,
                newusername = "sdk-testnewuser-" + DateTime.Now.Ticks;
            string
                firstPath  = IAMUtil.MakePath("first"),
                secondPath = IAMUtil.MakePath("second");

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = firstPath }).Wait();

                GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.AreEqual(firstPath, response.User.Path);

                string id = response.User.UserId;

                Client.UpdateUserAsync(new UpdateUserRequest() { UserName = username, NewPath = secondPath, NewUserName = newusername }).Wait();

                response = Client.GetUserAsync(new GetUserRequest() { UserName = newusername }).Result;

                Assert.AreEqual(newusername, response.User.UserName);
                Assert.AreEqual(secondPath, response.User.Path);
                Assert.AreEqual(id, response.User.UserId);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = newusername }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();

            GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
            Assert.AreEqual(username, response.User.UserName);

            Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.GetUserAsync(new GetUserRequest() { UserName = username })).Wait();
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestDoubleCreateUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<EntityAlreadyExistsException>(ae);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
        }

        [Test]
        [Category("IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestUpdateNonexistantUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            AssertExtensions.ExpectExceptionAsync(Client.UpdateUserAsync(new UpdateUserRequest() { UserName = username, NewPath = "/lala/" })).Wait();
        }
        


    }
}
