using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DirectoryServiceData;
using Amazon.DirectoryServiceData.Model;

namespace AWSSDKDocSamples.Amazon.DirectoryServiceData.Generated
{
    class DirectoryServiceDataSamples : ISample
    {
        public void DirectoryServiceDataAddGroupMember()
        {
            #region AddGroupMember-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.AddGroupMember(new AddGroupMemberRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                GroupName = "Marketing",
                MemberName = "Pat Candella",
                MemberRealm = "europe.example.com"
            });


            #endregion
        }

        public void DirectoryServiceDataCreateGroup()
        {
            #region CreateGroup-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.CreateGroup(new CreateGroupRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                GroupScope = "DomainLocal",
                GroupType = "Distribution",
                OtherAttributes = new Dictionary<string, AttributeValue> {
                    { "description", new AttributeValue { S = "Accounting dept mailing list" } },
                    { "displayName", new AttributeValue { S = "Acctng-mailing-list" } }
                },
                SAMAccountName = "AcctngMail"
            });

            string directoryId = response.DirectoryId;
            string samAccountName = response.SAMAccountName;
            string sid = response.SID;

            #endregion
        }

        public void DirectoryServiceDataCreateUser()
        {
            #region CreateUser-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.CreateUser(new CreateUserRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                EmailAddress = "pcandella@exampledomain.com",
                GivenName = "Pat Candella",
                OtherAttributes = new Dictionary<string, AttributeValue> {
                    { "department", new AttributeValue { S = "HR" } },
                    { "homePhone", new AttributeValue { S = "212-555-0100" } }
                },
                SAMAccountName = "pcandella",
                Surname = "Candella"
            });

            string directoryId = response.DirectoryId;
            string samAccountName = response.SAMAccountName;
            string sid = response.SID;

            #endregion
        }

        public void DirectoryServiceDataDeleteGroup()
        {
            #region DeleteGroup-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.DeleteGroup(new DeleteGroupRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                SAMAccountName = "marketing"
            });


            #endregion
        }

        public void DirectoryServiceDataDeleteUser()
        {
            #region DeleteUser-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.DeleteUser(new DeleteUserRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                SAMAccountName = "pcandella"
            });


            #endregion
        }

        public void DirectoryServiceDataDescribeGroup()
        {
            #region DescribeGroup-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.DescribeGroup(new DescribeGroupRequest
            {
                DirectoryId = "d-12233abcde",
                OtherAttributes = new List<string> {
                    "displayName",
                    "description",
                    "objectGUID"
                },
                Realm = "example.domain.com",
                SAMAccountName = "DevOpsMail"
            });

            string directoryId = response.DirectoryId;
            string distinguishedName = response.DistinguishedName;
            GroupScope groupScope = response.GroupScope;
            GroupType groupType = response.GroupType;
            Dictionary<string, AttributeValue> otherAttributes = response.OtherAttributes;
            string samAccountName = response.SAMAccountName;
            string sid = response.SID;

            #endregion
        }

        public void DirectoryServiceDataDescribeUser()
        {
            #region DescribeUser-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.DescribeUser(new DescribeUserRequest
            {
                DirectoryId = "d-12233abcde",
                OtherAttributes = new List<string> {
                    "department",
                    "manager",
                    "ipPhone",
                    "pwdLastSet"
                },
                Realm = "examplecorp.com",
                SAMAccountName = "twhitlock"
            });

            string directoryId = response.DirectoryId;
            string distinguishedName = response.DistinguishedName;
            string emailAddress = response.EmailAddress;
            bool? enabled = response.Enabled;
            string givenName = response.GivenName;
            Dictionary<string, AttributeValue> otherAttributes = response.OtherAttributes;
            string samAccountName = response.SAMAccountName;
            string sid = response.SID;
            string surname = response.Surname;
            string userPrincipalName = response.UserPrincipalName;

            #endregion
        }

        public void DirectoryServiceDataDisableUser()
        {
            #region DisableUser-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.DisableUser(new DisableUserRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                SAMAccountName = "twhitlock"
            });


            #endregion
        }

        public void DirectoryServiceDataListGroupMembers()
        {
            #region ListGroupMembers-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.ListGroupMembers(new ListGroupMembersRequest
            {
                DirectoryId = "d-12233abcde",
                MemberRealm = "example.local",
                Realm = "examplecorp.com",
                SAMAccountName = "marketing"
            });

            string directoryId = response.DirectoryId;
            List<Member> members = response.Members;

            #endregion
        }

        public void DirectoryServiceDataListGroups()
        {
            #region ListGroups-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.ListGroups(new ListGroupsRequest
            {
                DirectoryId = "d-12233abcde",
                MaxResults = 123,
                NextToken = "123456",
                Realm = "examplecorp.com"
            });

            string directoryId = response.DirectoryId;
            List<GroupSummary> groups = response.Groups;
            string nextToken = response.NextToken;

            #endregion
        }

        public void DirectoryServiceDataListGroupsForMember()
        {
            #region ListGroupsForMember-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.ListGroupsForMember(new ListGroupsForMemberRequest
            {
                DirectoryId = "d-12233abcde",
                MemberRealm = "example.local",
                Realm = "examplecorp.com",
                SAMAccountName = "twhitlock"
            });

            string directoryId = response.DirectoryId;
            List<GroupSummary> groups = response.Groups;

            #endregion
        }

        public void DirectoryServiceDataListUsers()
        {
            #region ListUsers-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.ListUsers(new ListUsersRequest
            {
                DirectoryId = "d-12233abcde",
                Realm = "examplecorp.com"
            });

            string directoryId = response.DirectoryId;
            List<UserSummary> users = response.Users;

            #endregion
        }

        public void DirectoryServiceDataRemoveGroupMember()
        {
            #region RemoveGroupMember-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.RemoveGroupMember(new RemoveGroupMemberRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                GroupName = "DevOps",
                MemberName = "Pat Candella",
                MemberRealm = "example.local"
            });


            #endregion
        }

        public void DirectoryServiceDataSearchGroups()
        {
            #region SearchGroups-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.SearchGroups(new SearchGroupsRequest
            {
                DirectoryId = "d-12233abcde",
                MaxResults = 123,
                NextToken = "123456",
                Realm = "examplecorp.com",
                SearchAttributes = new List<string> {
                    "GroupScope"
                },
                SearchString = "Security"
            });

            string directoryId = response.DirectoryId;
            List<Group> groups = response.Groups;
            string nextToken = response.NextToken;

            #endregion
        }

        public void DirectoryServiceDataSearchUsers()
        {
            #region SearchUsers-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.SearchUsers(new SearchUsersRequest
            {
                DirectoryId = "d-12233abcde",
                Realm = "examplecorp.com",
                SearchAttributes = new List<string> {
                    "department"
                },
                SearchString = "DevOps"
            });

            string directoryId = response.DirectoryId;
            string nextToken = response.NextToken;
            List<User> users = response.Users;

            #endregion
        }

        public void DirectoryServiceDataUpdateGroup()
        {
            #region UpdateGroup-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.UpdateGroup(new UpdateGroupRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                GroupScope = "Global",
                GroupType = "Security",
                OtherAttributes = new Dictionary<string, AttributeValue> {
                    { "co", new AttributeValue { S = "US" } },
                    { "preferredLanguage", new AttributeValue { S = "English" } }
                },
                SAMAccountName = "GuestsLocal",
                UpdateType = "REPLACE"
            });


            #endregion
        }

        public void DirectoryServiceDataUpdateUser()
        {
            #region UpdateUser-1

            var client = new AmazonDirectoryServiceDataClient();
            var response = client.UpdateUser(new UpdateUserRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                DirectoryId = "d-12233abcde",
                EmailAddress = "twhitlock@examplecorp.com",
                GivenName = "Terry",
                OtherAttributes = new Dictionary<string, AttributeValue> {
                    { "co", new AttributeValue { S = "US" } },
                    { "homePhone", new AttributeValue { S = "333-333-3333" } },
                    { "physicalDeliveryOfficeName", new AttributeValue { S = "Example Company" } },
                    { "postalCode", new AttributeValue { S = "54321" } },
                    { "st", new AttributeValue { S = "WA" } },
                    { "streetAddress", new AttributeValue { S = "123 Any Street" } },
                    { "telephoneNumber", new AttributeValue { S = "212-555-1111" } }
                },
                SAMAccountName = "twhitlock",
                Surname = "Whitlock",
                UpdateType = "ADD"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
