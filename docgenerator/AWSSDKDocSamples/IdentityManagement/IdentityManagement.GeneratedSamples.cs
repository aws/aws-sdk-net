using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDKDocSamples.Amazon.IdentityManagement.Generated
{
    class IdentityManagementServiceSamples : ISample
    {
        public void IdentityManagementServiceAddClientIDToOpenIDConnectProvider()
        {
            #region AddClientIDToOpenIDConnectProvider-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AddClientIDToOpenIDConnectProvider(new AddClientIDToOpenIDConnectProviderRequest
            {
                ClientID = "my-application-ID",
                OpenIDConnectProviderArn = "arn:aws:iam::123456789012:oidc-provider/server.example.com"
            });


            #endregion
        }

        public void IdentityManagementServiceAddRoleToInstanceProfile()
        {
            #region AddRoleToInstanceProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AddRoleToInstanceProfile(new AddRoleToInstanceProfileRequest
            {
                InstanceProfileName = "Webserver",
                RoleName = "S3Access"
            });


            #endregion
        }

        public void IdentityManagementServiceAddUserToGroup()
        {
            #region AddUserToGroup-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AddUserToGroup(new AddUserToGroupRequest
            {
                GroupName = "Admins",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceAttachGroupPolicy()
        {
            #region AttachGroupPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AttachGroupPolicy(new AttachGroupPolicyRequest
            {
                GroupName = "Finance",
                PolicyArn = "arn:aws:iam::aws:policy/ReadOnlyAccess"
            });


            #endregion
        }

        public void IdentityManagementServiceAttachRolePolicy()
        {
            #region AttachRolePolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AttachRolePolicy(new AttachRolePolicyRequest
            {
                PolicyArn = "arn:aws:iam::aws:policy/ReadOnlyAccess",
                RoleName = "ReadOnlyRole"
            });


            #endregion
        }

        public void IdentityManagementServiceAttachUserPolicy()
        {
            #region AttachUserPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.AttachUserPolicy(new AttachUserPolicyRequest
            {
                PolicyArn = "arn:aws:iam::aws:policy/AdministratorAccess",
                UserName = "Alice"
            });


            #endregion
        }

        public void IdentityManagementServiceChangePassword()
        {
            #region ChangePassword-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ChangePassword(new ChangePasswordRequest
            {
                NewPassword = "]35d/{pB9Fo9wJ",
                OldPassword = "3s0K_;xh4~8XXI"
            });


            #endregion
        }

        public void IdentityManagementServiceCreateAccessKey()
        {
            #region CreateAccessKey-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateAccessKey(new CreateAccessKeyRequest
            {
                UserName = "Bob"
            });

            AccessKey accessKey = response.AccessKey;

            #endregion
        }

        public void IdentityManagementServiceCreateAccountAlias()
        {
            #region CreateAccountAlias-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateAccountAlias(new CreateAccountAliasRequest
            {
                AccountAlias = "examplecorp"
            });


            #endregion
        }

        public void IdentityManagementServiceCreateGroup()
        {
            #region CreateGroup-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateGroup(new CreateGroupRequest
            {
                GroupName = "Admins"
            });

            Group group = response.Group;

            #endregion
        }

        public void IdentityManagementServiceCreateInstanceProfile()
        {
            #region CreateInstanceProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateInstanceProfile(new CreateInstanceProfileRequest
            {
                InstanceProfileName = "Webserver"
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void IdentityManagementServiceCreateLoginProfile()
        {
            #region CreateLoginProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateLoginProfile(new CreateLoginProfileRequest
            {
                Password = "h]6EszR}vJ*m",
                PasswordResetRequired = true,
                UserName = "Bob"
            });

            LoginProfile loginProfile = response.LoginProfile;

            #endregion
        }

        public void IdentityManagementServiceCreateOpenIDConnectProvider()
        {
            #region CreateOpenIDConnectProvider-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateOpenIDConnectProvider(new CreateOpenIDConnectProviderRequest
            {
                ClientIDList = new List<string> {
                    "my-application-id"
                },
                ThumbprintList = new List<string> {
                    "3768084dfb3d2b68b7897bf5f565da8efEXAMPLE"
                },
                Url = "https://server.example.com"
            });

            string openIDConnectProviderArn = response.OpenIDConnectProviderArn;

            #endregion
        }

        public void IdentityManagementServiceCreateRole()
        {
            #region CreateRole-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateRole(new CreateRoleRequest
            {
                AssumeRolePolicyDocument = "<Stringified-JSON>",
                Path = "/",
                RoleName = "Test-Role"
            });

            Role role = response.Role;

            #endregion
        }

        public void IdentityManagementServiceCreateUser()
        {
            #region CreateUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateUser(new CreateUserRequest
            {
                UserName = "Bob"
            });

            User user = response.User;

            #endregion
        }

        public void IdentityManagementServiceDeleteAccessKey()
        {
            #region DeleteAccessKey-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteAccessKey(new DeleteAccessKeyRequest
            {
                AccessKeyId = "AKIDPMS9RO4H3FEXAMPLE",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteAccountAlias()
        {
            #region DeleteAccountAlias-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteAccountAlias(new DeleteAccountAliasRequest
            {
                AccountAlias = "mycompany"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteAccountPasswordPolicy()
        {
            #region DeleteAccountPasswordPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest
            {
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteGroupPolicy()
        {
            #region DeleteGroupPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteGroupPolicy(new DeleteGroupPolicyRequest
            {
                GroupName = "Admins",
                PolicyName = "ExamplePolicy"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteInstanceProfile()
        {
            #region DeleteInstanceProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteInstanceProfile(new DeleteInstanceProfileRequest
            {
                InstanceProfileName = "ExampleInstanceProfile"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteLoginProfile()
        {
            #region DeleteLoginProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteLoginProfile(new DeleteLoginProfileRequest
            {
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteRole()
        {
            #region DeleteRole-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteRole(new DeleteRoleRequest
            {
                RoleName = "Test-Role"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteRolePolicy()
        {
            #region DeleteRolePolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteRolePolicy(new DeleteRolePolicyRequest
            {
                PolicyName = "ExamplePolicy",
                RoleName = "Test-Role"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteSigningCertificate()
        {
            #region DeleteSigningCertificate-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteSigningCertificate(new DeleteSigningCertificateRequest
            {
                CertificateId = "TA7SMP42TDN5Z26OBPJE7EXAMPLE",
                UserName = "Anika"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteUser()
        {
            #region DeleteUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteUser(new DeleteUserRequest
            {
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteUserPolicy()
        {
            #region DeleteUserPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteUserPolicy(new DeleteUserPolicyRequest
            {
                PolicyName = "ExamplePolicy",
                UserName = "Juan"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteVirtualMFADevice()
        {
            #region DeleteVirtualMFADevice-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteVirtualMFADevice(new DeleteVirtualMFADeviceRequest
            {
                SerialNumber = "arn:aws:iam::123456789012:mfa/ExampleName"
            });


            #endregion
        }

        public void IdentityManagementServiceDisableOrganizationsRootCredentialsManagement()
        {
            #region DisableOrganizationsRootCredentialsManagement-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DisableOrganizationsRootCredentialsManagement(new DisableOrganizationsRootCredentialsManagementRequest
            {
            });

            List<string> enabledFeatures = response.EnabledFeatures;
            string organizationId = response.OrganizationId;

            #endregion
        }

        public void IdentityManagementServiceDisableOrganizationsRootSessions()
        {
            #region DisableOrganizationsRootSessions-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DisableOrganizationsRootSessions(new DisableOrganizationsRootSessionsRequest
            {
            });

            List<string> enabledFeatures = response.EnabledFeatures;
            string organizationId = response.OrganizationId;

            #endregion
        }

        public void IdentityManagementServiceEnableOrganizationsRootCredentialsManagement()
        {
            #region EnableOrganizationsRootCredentialsManagement-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.EnableOrganizationsRootCredentialsManagement(new EnableOrganizationsRootCredentialsManagementRequest
            {
            });

            List<string> enabledFeatures = response.EnabledFeatures;
            string organizationId = response.OrganizationId;

            #endregion
        }

        public void IdentityManagementServiceEnableOrganizationsRootSessions()
        {
            #region EnableOrganizationsRootSessions-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.EnableOrganizationsRootSessions(new EnableOrganizationsRootSessionsRequest
            {
            });

            List<string> enabledFeatures = response.EnabledFeatures;
            string organizationId = response.OrganizationId;

            #endregion
        }

        public void IdentityManagementServiceGenerateOrganizationsAccessReport()
        {
            #region GenerateOrganizationsAccessReport-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GenerateOrganizationsAccessReport(new GenerateOrganizationsAccessReportRequest
            {
                EntityPath = "o-a1b2c3d4e5/r-f6g7h8i9j0example/ou-1a2b3c-k9l8m7n6o5example"
            });

            string jobId = response.JobId;

            #endregion
        }

        public void IdentityManagementServiceGenerateServiceLastAccessedDetails()
        {
            #region GenerateServiceLastAccessedDetails-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GenerateServiceLastAccessedDetails(new GenerateServiceLastAccessedDetailsRequest
            {
                Arn = "arn:aws:iam::123456789012:policy/ExamplePolicy1"
            });

            string jobId = response.JobId;

            #endregion
        }

        public void IdentityManagementServiceGetAccountPasswordPolicy()
        {
            #region GetAccountPasswordPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest
            {
            });

            PasswordPolicy passwordPolicy = response.PasswordPolicy;

            #endregion
        }

        public void IdentityManagementServiceGetAccountSummary()
        {
            #region GetAccountSummary-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetAccountSummary(new GetAccountSummaryRequest
            {
            });

            Dictionary<string, int> summaryMap = response.SummaryMap;

            #endregion
        }

        public void IdentityManagementServiceGetInstanceProfile()
        {
            #region GetInstanceProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetInstanceProfile(new GetInstanceProfileRequest
            {
                InstanceProfileName = "ExampleInstanceProfile"
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void IdentityManagementServiceGetLoginProfile()
        {
            #region GetLoginProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetLoginProfile(new GetLoginProfileRequest
            {
                UserName = "Anika"
            });

            LoginProfile loginProfile = response.LoginProfile;

            #endregion
        }

        public void IdentityManagementServiceGetOrganizationsAccessReport()
        {
            #region GetOrganizationsAccessReport-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetOrganizationsAccessReport(new GetOrganizationsAccessReportRequest
            {
                JobId = "examplea-1234-b567-cde8-90fg123abcd4"
            });

            List<AccessDetail> accessDetails = response.AccessDetails;
            bool? isTruncated = response.IsTruncated;
            DateTime? jobCompletionDate = response.JobCompletionDate;
            DateTime? jobCreationDate = response.JobCreationDate;
            JobStatusType jobStatus = response.JobStatus;
            int? numberOfServicesAccessible = response.NumberOfServicesAccessible;
            int? numberOfServicesNotAccessed = response.NumberOfServicesNotAccessed;

            #endregion
        }

        public void IdentityManagementServiceGetRole()
        {
            #region GetRole-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetRole(new GetRoleRequest
            {
                RoleName = "Test-Role"
            });

            Role role = response.Role;

            #endregion
        }

        public void IdentityManagementServiceGetServiceLastAccessedDetails()
        {
            #region GetServiceLastAccessedDetails-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetServiceLastAccessedDetails(new GetServiceLastAccessedDetailsRequest
            {
                JobId = "examplef-1305-c245-eba4-71fe298bcda7"
            });

            bool? isTruncated = response.IsTruncated;
            DateTime? jobCompletionDate = response.JobCompletionDate;
            DateTime? jobCreationDate = response.JobCreationDate;
            JobStatusType jobStatus = response.JobStatus;
            List<ServiceLastAccessed> servicesLastAccessed = response.ServicesLastAccessed;

            #endregion
        }

        public void IdentityManagementServiceGetServiceLastAccessedDetailsWithEntities()
        {
            #region GetServiceLastAccessedDetailsWithEntities-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetServiceLastAccessedDetailsWithEntities(new GetServiceLastAccessedDetailsWithEntitiesRequest
            {
                JobId = "examplef-1305-c245-eba4-71fe298bcda7",
                ServiceNamespace = "iam"
            });

            List<EntityDetails> entityDetailsList = response.EntityDetailsList;
            bool? isTruncated = response.IsTruncated;
            DateTime? jobCompletionDate = response.JobCompletionDate;
            DateTime? jobCreationDate = response.JobCreationDate;
            JobStatusType jobStatus = response.JobStatus;

            #endregion
        }

        public void IdentityManagementServiceGetUser()
        {
            #region GetUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetUser(new GetUserRequest
            {
                UserName = "Bob"
            });

            User user = response.User;

            #endregion
        }

        public void IdentityManagementServiceListAccessKeys()
        {
            #region ListAccessKeys-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListAccessKeys(new ListAccessKeysRequest
            {
                UserName = "Alice"
            });

            List<AccessKeyMetadata> accessKeyMetadata = response.AccessKeyMetadata;

            #endregion
        }

        public void IdentityManagementServiceListAccountAliases()
        {
            #region ListAccountAliases-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListAccountAliases(new ListAccountAliasesRequest
            {
            });

            List<string> accountAliases = response.AccountAliases;

            #endregion
        }

        public void IdentityManagementServiceListGroupPolicies()
        {
            #region ListGroupPolicies-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListGroupPolicies(new ListGroupPoliciesRequest
            {
                GroupName = "Admins"
            });

            List<string> policyNames = response.PolicyNames;

            #endregion
        }

        public void IdentityManagementServiceListGroups()
        {
            #region ListGroups-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListGroups(new ListGroupsRequest
            {
            });

            List<Group> groups = response.Groups;

            #endregion
        }

        public void IdentityManagementServiceListGroupsForUser()
        {
            #region ListGroupsForUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListGroupsForUser(new ListGroupsForUserRequest
            {
                UserName = "Bob"
            });

            List<Group> groups = response.Groups;

            #endregion
        }

        public void IdentityManagementServiceListOrganizationsFeatures()
        {
            #region ListOrganizationsFeatures-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListOrganizationsFeatures(new ListOrganizationsFeaturesRequest
            {
            });

            List<string> enabledFeatures = response.EnabledFeatures;
            string organizationId = response.OrganizationId;

            #endregion
        }

        public void IdentityManagementServiceListPoliciesGrantingServiceAccess()
        {
            #region ListPoliciesGrantingServiceAccess-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListPoliciesGrantingServiceAccess(new ListPoliciesGrantingServiceAccessRequest
            {
                Arn = "arn:aws:iam::123456789012:user/ExampleUser01",
                ServiceNamespaces = new List<string> {
                    "iam",
                    "ec2"
                }
            });

            bool? isTruncated = response.IsTruncated;
            List<ListPoliciesGrantingServiceAccessEntry> policiesGrantingServiceAccess = response.PoliciesGrantingServiceAccess;

            #endregion
        }

        public void IdentityManagementServiceListRoleTags()
        {
            #region ListRoleTags-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListRoleTags(new ListRoleTagsRequest
            {
                RoleName = "taggedrole1"
            });

            bool? isTruncated = response.IsTruncated;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void IdentityManagementServiceListSigningCertificates()
        {
            #region ListSigningCertificates-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListSigningCertificates(new ListSigningCertificatesRequest
            {
                UserName = "Bob"
            });

            List<SigningCertificate> certificates = response.Certificates;

            #endregion
        }

        public void IdentityManagementServiceListUsers()
        {
            #region ListUsers-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListUsers(new ListUsersRequest
            {
            });

            List<User> users = response.Users;

            #endregion
        }

        public void IdentityManagementServiceListUserTags()
        {
            #region ListUserTags-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListUserTags(new ListUserTagsRequest
            {
                UserName = "anika"
            });

            bool? isTruncated = response.IsTruncated;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void IdentityManagementServiceListVirtualMFADevices()
        {
            #region ListVirtualMFADevices-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListVirtualMFADevices(new ListVirtualMFADevicesRequest
            {
            });

            List<VirtualMFADevice> virtualMFADevices = response.VirtualMFADevices;

            #endregion
        }

        public void IdentityManagementServicePutGroupPolicy()
        {
            #region PutGroupPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.PutGroupPolicy(new PutGroupPolicyRequest
            {
                GroupName = "PowerUsers",
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":{\"Effect\":\"Allow\",\"Action\":[\"iam:Get*\",\"iam:List*\",\"iam:Generate*\"],\"Resource\":\"*\"}}",
                PolicyName = "IAMReadAccess"
            });


            #endregion
        }

        public void IdentityManagementServicePutRolePolicy()
        {
            #region PutRolePolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.PutRolePolicy(new PutRolePolicyRequest
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":{\"Effect\":\"Allow\",\"Action\":\"s3:*\",\"Resource\":\"*\"}}",
                PolicyName = "S3AccessPolicy",
                RoleName = "S3Access"
            });


            #endregion
        }

        public void IdentityManagementServicePutUserPolicy()
        {
            #region PutUserPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.PutUserPolicy(new PutUserPolicyRequest
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":{\"Effect\":\"Allow\",\"Action\":\"*\",\"Resource\":\"*\"}}",
                PolicyName = "AllAccessPolicy",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceRemoveRoleFromInstanceProfile()
        {
            #region RemoveRoleFromInstanceProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.RemoveRoleFromInstanceProfile(new RemoveRoleFromInstanceProfileRequest
            {
                InstanceProfileName = "ExampleInstanceProfile",
                RoleName = "Test-Role"
            });


            #endregion
        }

        public void IdentityManagementServiceRemoveUserFromGroup()
        {
            #region RemoveUserFromGroup-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.RemoveUserFromGroup(new RemoveUserFromGroupRequest
            {
                GroupName = "Admins",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceSetSecurityTokenServicePreferences()
        {
            #region SetSecurityTokenServicePreferences-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.SetSecurityTokenServicePreferences(new SetSecurityTokenServicePreferencesRequest
            {
                GlobalEndpointTokenVersion = "v2Token"
            });


            #endregion
        }

        public void IdentityManagementServiceTagRole()
        {
            #region TagRole-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.TagRole(new TagRoleRequest
            {
                RoleName = "taggedrole",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Dept",
                        Value = "Accounting"
                    },
                    new Tag {
                        Key = "CostCenter",
                        Value = "12345"
                    }
                }
            });


            #endregion
        }

        public void IdentityManagementServiceTagUser()
        {
            #region TagUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.TagUser(new TagUserRequest
            {
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Dept",
                        Value = "Accounting"
                    },
                    new Tag {
                        Key = "CostCenter",
                        Value = "12345"
                    }
                },
                UserName = "anika"
            });


            #endregion
        }

        public void IdentityManagementServiceUntagRole()
        {
            #region UntagRole-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UntagRole(new UntagRoleRequest
            {
                RoleName = "taggedrole",
                TagKeys = new List<string> {
                    "Dept"
                }
            });


            #endregion
        }

        public void IdentityManagementServiceUntagUser()
        {
            #region UntagUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UntagUser(new UntagUserRequest
            {
                TagKeys = new List<string> {
                    "Dept"
                },
                UserName = "anika"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateAccessKey()
        {
            #region UpdateAccessKey-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateAccessKey(new UpdateAccessKeyRequest
            {
                AccessKeyId = "AKIAIOSFODNN7EXAMPLE",
                Status = "Inactive",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateAccountPasswordPolicy()
        {
            #region UpdateAccountPasswordPolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest
            {
                MinimumPasswordLength = 8,
                RequireNumbers = true
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateAssumeRolePolicy()
        {
            #region UpdateAssumeRolePolicy-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateAssumeRolePolicy(new UpdateAssumeRolePolicyRequest
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"Allow\",\"Principal\":{\"Service\":[\"ec2.amazonaws.com\"]},\"Action\":[\"sts:AssumeRole\"]}]}",
                RoleName = "S3AccessForEC2Instances"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateGroup()
        {
            #region UpdateGroup-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateGroup(new UpdateGroupRequest
            {
                GroupName = "Test",
                NewGroupName = "Test-1"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateLoginProfile()
        {
            #region UpdateLoginProfile-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateLoginProfile(new UpdateLoginProfileRequest
            {
                Password = "SomeKindOfPassword123!@#",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateSigningCertificate()
        {
            #region UpdateSigningCertificate-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateSigningCertificate(new UpdateSigningCertificateRequest
            {
                CertificateId = "TA7SMP42TDN5Z26OBPJE7EXAMPLE",
                Status = "Inactive",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceUpdateUser()
        {
            #region UpdateUser-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UpdateUser(new UpdateUserRequest
            {
                NewUserName = "Robert",
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceUploadServerCertificate()
        {
            #region UploadServerCertificate-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UploadServerCertificate(new UploadServerCertificateRequest
            {
                CertificateBody = "-----BEGIN CERTIFICATE-----<a very long certificate text string>-----END CERTIFICATE-----",
                Path = "/company/servercerts/",
                PrivateKey = "-----BEGIN DSA PRIVATE KEY-----<a very long private key string>-----END DSA PRIVATE KEY-----",
                ServerCertificateName = "ProdServerCert"
            });

            ServerCertificateMetadata serverCertificateMetadata = response.ServerCertificateMetadata;

            #endregion
        }

        public void IdentityManagementServiceUploadSigningCertificate()
        {
            #region UploadSigningCertificate-1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UploadSigningCertificate(new UploadSigningCertificateRequest
            {
                CertificateBody = "-----BEGIN CERTIFICATE-----<certificate-body>-----END CERTIFICATE-----",
                UserName = "Bob"
            });

            SigningCertificate certificate = response.Certificate;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
