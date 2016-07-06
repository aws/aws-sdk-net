using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for GroupTests
    /// </summary>
    [TestClass]
    public class GroupTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        public GroupTests()
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
        public  void PreTestRun()
        {
            IAMUtil.DeleteUsersAndGroupsInTestNameSpace(Client);
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestCreateGetGroup()
        {
            string groupname = Guid.NewGuid().ToString().Replace('-', '0');

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname });
                GetGroupResponse response = Client.GetGroup(new GetGroupRequest() { GroupName = groupname });
                Assert.AreNotEqual(DateTime.MinValue, response.Group.CreateDate);
                Assert.AreEqual(0, response.Users.Count());
            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestGroupWithUsers()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH });

                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });

                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 });

                GetGroupResponse response =
                    Client.GetGroup(new GetGroupRequest() { GroupName = groupname });

                Assert.AreEqual(3, response.Users.Count());
                Assert.AreEqual(false, response.IsTruncated);

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.AreEqual(7, matches);
            }
            finally
            {
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username1 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username2 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username3 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestRemoveUsersFromGroup()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH });

                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });

                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 });

                GetGroupResponse response =
                    Client.GetGroup(new GetGroupRequest() { GroupName = groupname });

                Assert.AreEqual(3, response.Users.Count());

                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 });

                response =
                    Client.GetGroup(new GetGroupRequest() { GroupName = groupname });

                Assert.AreEqual(2, response.Users.Count());

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        Assert.Fail();
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.AreEqual(5, matches);
            }
            finally
            {
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username1 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username2 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username3 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestGroupPaging()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                username4 = "user4" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;


            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH });
                Client.CreateUser(new CreateUserRequest() { UserName = username4, Path = IAMUtil.TEST_PATH });

                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH });

                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = groupname, UserName = username4 });

                GetGroupResponse response =
                    Client.GetGroup(new GetGroupRequest() { GroupName = groupname, MaxItems = 2 });

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(true, response.IsTruncated);

                string marker = response.Marker;

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                    if (u.UserName.Equals(username4))
                        matches |= 8;
                }

                response = Client.GetGroup(new GetGroupRequest() { GroupName = groupname, Marker = marker });

                Assert.AreEqual(2, response.Users.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                    if (u.UserName.Equals(username4))
                        matches |= 8;
                }

                Assert.AreEqual(15, matches);
            }
            finally
            {
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 });
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username4 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username1 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username2 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username3 });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username4 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname });

            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListGroupWithPaths()
        {

            string
                groupname1 = "group1" + DateTime.Now.Ticks,
                groupname2 = "group2" + DateTime.Now.Ticks,
                groupname3 = "group3" + DateTime.Now.Ticks,
                groupname4 = "group4" + DateTime.Now.Ticks;

            string
                pathA = IAMUtil.MakePath("A"),
                pathB = IAMUtil.MakePath("B");

            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname1, Path = pathA });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname2, Path = pathA });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname3, Path = pathB });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname4, Path = pathB });

                ListGroupsResponse response =
                    Client.ListGroups(new ListGroupsRequest() { PathPrefix = pathA });

                Assert.AreEqual(2, response.Groups.Count());

                int matches = 0;

                foreach (Group g in response.Groups)
                {
                    if(g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if(g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if(g.GroupName.Equals(groupname3))
                        Assert.Fail();
                    if(g.GroupName.Equals(groupname4))
                        Assert.Fail();
                }

                response = Client.ListGroups(new ListGroupsRequest() { PathPrefix = pathB });
                
                Assert.AreEqual(2, response.Groups.Count());

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        Assert.Fail();
                    if (g.GroupName.Equals(groupname2))
                        Assert.Fail();
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                Assert.AreEqual(15, matches);

            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname1 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname2 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname3 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname4 });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        public void TestListGroupsPaging()
        {
            string
                groupname1 = "group1" + DateTime.Now.Ticks,
                groupname2 = "group2" + DateTime.Now.Ticks,
                groupname3 = "group3" + DateTime.Now.Ticks,
                groupname4 = "group4" + DateTime.Now.Ticks;


            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname1, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname2, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname3, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = groupname4, Path = IAMUtil.TEST_PATH });

                ListGroupsResponse response =
                    Client.ListGroups(new ListGroupsRequest());
                Assert.IsTrue(response.Groups.Count >= 4);

                response =
                    Client.ListGroups(new ListGroupsRequest() { MaxItems = 2, PathPrefix = IAMUtil.TEST_PATH });

                Assert.AreEqual(2, response.Groups.Count());
                Assert.AreEqual(true, response.IsTruncated);

                string marker = response.Marker;

                int matches = 0;

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if (g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                response = Client.ListGroups(new ListGroupsRequest() { Marker = marker, PathPrefix = IAMUtil.TEST_PATH });

                Assert.AreEqual(2, response.Groups.Count());
                Assert.AreEqual(false, response.IsTruncated);

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if (g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                Assert.AreEqual(15, matches);

            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname1 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname2 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname3 });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = groupname4 });
            }

        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(NoSuchEntityException))]
        public void AddUserToNonExistentGroup()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;
            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH });
                Client.AddUserToGroup(new AddUserToGroupRequest() { GroupName = grpname, UserName = username });
            }
            finally
            {
                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestDoubleCreation()
        {
            string
                grpname = "group" + DateTime.Now.Ticks;
           
            try
            {
                Client.CreateGroup(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH });
            }
            finally
            {
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = grpname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(DeleteConflictException))]
        public void TestDeleteUserInGroupThrowsException()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH });
                Client.AddUserToGroup(new AddUserToGroupRequest() { UserName = username, GroupName = grpname });

                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
            }
            finally
            {
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { UserName = username, GroupName = grpname });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = grpname });
            }
        }

        [TestMethod]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(DeleteConflictException))]
        public void TestDeleteGroupWithUsersThrowsException()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;


            try
            {
                Client.CreateUser(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH });
                Client.CreateGroup(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH });
                Client.AddUserToGroup(new AddUserToGroupRequest() { UserName = username, GroupName = grpname });

                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = grpname });
            }
            finally
            {
                Client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { UserName = username, GroupName = grpname });
                Client.DeleteUser(new DeleteUserRequest() { UserName = username });
                Client.DeleteGroup(new DeleteGroupRequest() { GroupName = grpname });
            }
        }

    }
}
