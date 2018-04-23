using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    class IAMUtil
    {
        public static string TEST_PATH = "/IntegrationTests/IAM/";

        public static string MakePath(params string[] elements)
        {
            string path = TEST_PATH;
            foreach (string s in elements)
            {
                path = string.Format("{0}{1}/", path, s);
            }

            return path;
        }

        public static void DeleteUsersAndGroupsInTestNameSpace(AmazonIdentityManagementServiceClient client)
        {
            ListGroupsResponse lgRes = client.ListGroups(new ListGroupsRequest() { PathPrefix = TEST_PATH });
            foreach (Group g in lgRes.Groups)
            {
                GetGroupResponse ggRes = client.GetGroup(new GetGroupRequest() { GroupName = g.GroupName });
                foreach (User u in ggRes.Users)
                {
                    client.RemoveUserFromGroup(new RemoveUserFromGroupRequest() { GroupName = g.GroupName, UserName = u.UserName });
                }
                client.DeleteGroup(new DeleteGroupRequest() { GroupName = g.GroupName });
            }

            ListUsersResponse luRes = client.ListUsers(new ListUsersRequest() { PathPrefix = TEST_PATH });
            foreach (User u in luRes.Users)
            {
                DeleteTestUsers(client, u.UserName);
            }
        }

        public static void DeleteAccessKeysForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListAccessKeysResponse response = client.ListAccessKeys(new ListAccessKeysRequest() { UserName = username });
            foreach (AccessKeyMetadata akm in response.AccessKeyMetadata)
            {
                client.DeleteAccessKey(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = akm.AccessKeyId });
            }
        }

        public static void DeleteUserPoliciesForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListUserPoliciesResponse response =
                client.ListUserPolicies(new ListUserPoliciesRequest() { UserName = username });
            foreach (string pName in response.PolicyNames)
            {
                client.DeleteUserPolicy(new DeleteUserPolicyRequest() { UserName = username, PolicyName = pName });
            }
        }

        public static void DeleteCertificatesForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListSigningCertificatesResponse response =
                client.ListSigningCertificates(new ListSigningCertificatesRequest() { UserName = username });
            foreach (SigningCertificate cert in response.Certificates)
            {
                client.DeleteSigningCertificate(new DeleteSigningCertificateRequest() { UserName = username, CertificateId = cert.CertificateId });
            }
        }

        public static string CreateTestUser(AmazonIdentityManagementServiceClient client)
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            client.CreateUser(new CreateUserRequest() { UserName = username, Path = TEST_PATH });
            return username;
        }

        public static void DeleteTestUsers(AmazonIdentityManagementServiceClient client, params string[] usernames)
        {
            UtilityMethods.WaitUntilSuccess(() => {
                foreach (string s in usernames)
                {
                    DeleteAccessKeysForUser(client, s);
                    DeleteUserPoliciesForUser(client, s);
                    DeleteCertificatesForUser(client, s);
                    try 
                    {
                        client.DeleteLoginProfile(new DeleteLoginProfileRequest() { UserName = s }); 
                    } catch { }
                
                   client.DeleteUser(new DeleteUserRequest() { UserName = s });
                }
            });
        }
    }
}
