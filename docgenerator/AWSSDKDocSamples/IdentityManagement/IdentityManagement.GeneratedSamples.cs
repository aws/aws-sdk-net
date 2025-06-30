using System;
using System.Collections.Generic;
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
            #region 028e91f4-e2a6-4d59-9e3b-4965a3fb19be

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
            #region c107fac3-edb6-4827-8a71-8863ec91c81f

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
            #region 619c7e6b-09f8-4036-857b-51a6ea5027ca

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
            #region 87551489-86f0-45db-9889-759936778f2b

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
            #region 3e1b8c7c-99c8-4fc4-a20c-131fe3f22c7e

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
            #region 1372ebd8-9475-4b1a-a479-23b6fd4b8b3e

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
            #region 3a80c66f-bffb-46df-947c-1e8fa583b470

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
            #region 1fbb3211-4cf2-41db-8c20-ba58d9f5802d

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
            #region 5adaf6fb-94fc-4ca2-b825-2fbc2062add1

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.CreateAccountAlias(new CreateAccountAliasRequest 
            {
                AccountAlias = "examplecorp"
            });


            #endregion
        }

        public void IdentityManagementServiceCreateGroup()
        {
            #region d5da2a90-5e69-4ef7-8ae8-4c33dc21fd21

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
            #region 5d84e6ae-5921-4e39-8454-10232cd9ff9a

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
            #region c63795bc-3444-40b3-89df-83c474ef88be

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
            #region 4e4a6bff-cc97-4406-922e-0ab4a82cdb63

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
            #region eaaa4b5f-51f1-4f73-b0d3-30127040eff8

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
            #region eb15f90b-e5f5-4af8-a594-e4e82b181a62

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
            #region 61a785a7-d30a-415a-ae18-ab9236e56871

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
            #region 7abeca65-04a8-4500-a890-47f1092bf766

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteAccountAlias(new DeleteAccountAliasRequest 
            {
                AccountAlias = "mycompany"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteAccountPasswordPolicy()
        {
            #region 9ddf755e-495c-49bc-ae3b-ea6cc9b8ebcf

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest 
            {
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteGroupPolicy()
        {
            #region e683f2bd-98a4-4fe0-bb66-33169c692d4a

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
            #region 12d74fb8-3433-49db-8171-a1fc764e354d

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteInstanceProfile(new DeleteInstanceProfileRequest 
            {
                InstanceProfileName = "ExampleInstanceProfile"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteLoginProfile()
        {
            #region 1fe57059-fc73-42e2-b992-517b7d573b5c

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteLoginProfile(new DeleteLoginProfileRequest 
            {
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteRole()
        {
            #region 053cdf74-9bda-44b8-bdbb-140fd5a32603

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteRole(new DeleteRoleRequest 
            {
                RoleName = "Test-Role"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteRolePolicy()
        {
            #region 9c667336-fde3-462c-b8f3-950800821e27

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
            #region e3357586-ba9c-4070-b35b-d1a899b71987

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
            #region a13dc3f9-59fe-42d9-abbb-fb98b204fdf0

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteUser(new DeleteUserRequest 
            {
                UserName = "Bob"
            });


            #endregion
        }

        public void IdentityManagementServiceDeleteUserPolicy()
        {
            #region 34f07ddc-9bc1-4f52-bc59-cd0a3ccd06c8

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
            #region 2933b08b-dbe7-4b89-b8c1-fdf75feea1ee

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.DeleteVirtualMFADevice(new DeleteVirtualMFADeviceRequest 
            {
                SerialNumber = "arn:aws:iam::123456789012:mfa/ExampleName"
            });


            #endregion
        }

        public void IdentityManagementServiceDisableOrganizationsRootCredentialsManagement()
        {
            #region to-disable-the-rootcredentialsmanagement-feature-in-your-organization-1730908292211

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
            #region to-disable-the-rootsessions-feature-in-your-organization-1730908495962

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
            #region to-enable-the-rootcredentialsmanagement-feature-in-your-organization-1730908602395

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
            #region to-enable-the-rootsessions-feature-in-your-organization-1730908736611

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
            #region generateorganizationsaccessreport-ou

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
            #region generateaccessdata-policy-1541695178514

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
            #region 5e4598c7-c425-431f-8af1-19073b3c4a5f

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest 
            {
            });

            PasswordPolicy passwordPolicy = response.PasswordPolicy;

            #endregion
        }

        public void IdentityManagementServiceGetAccountSummary()
        {
            #region 9d8447af-f344-45de-8219-2cebc3cce7f2

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetAccountSummary(new GetAccountSummaryRequest 
            {
            });

            Dictionary<string, int> summaryMap = response.SummaryMap;

            #endregion
        }

        public void IdentityManagementServiceGetInstanceProfile()
        {
            #region 463b9ba5-18cc-4608-9ccb-5a7c6b6e5fe7

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
            #region d6b580cc-909f-4925-9caa-d425cbc1ad47

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
            #region getorganizationsaccessreport-ou

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetOrganizationsAccessReport(new GetOrganizationsAccessReportRequest 
            {
                JobId = "examplea-1234-b567-cde8-90fg123abcd4"
            });

            List<AccessDetail> accessDetails = response.AccessDetails;
            bool isTruncated = response.IsTruncated;
            DateTime jobCompletionDate = response.JobCompletionDate;
            DateTime jobCreationDate = response.JobCreationDate;
            string jobStatus = response.JobStatus;
            int numberOfServicesAccessible = response.NumberOfServicesAccessible;
            int numberOfServicesNotAccessed = response.NumberOfServicesNotAccessed;

            #endregion
        }

        public void IdentityManagementServiceGetRole()
        {
            #region 5b7d03a6-340c-472d-aa77-56425950d8b0

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
            #region getserviceaccessdetails-policy-1541696298085

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetServiceLastAccessedDetails(new GetServiceLastAccessedDetailsRequest 
            {
                JobId = "examplef-1305-c245-eba4-71fe298bcda7"
            });

            bool isTruncated = response.IsTruncated;
            DateTime jobCompletionDate = response.JobCompletionDate;
            DateTime jobCreationDate = response.JobCreationDate;
            string jobStatus = response.JobStatus;
            List<ServiceLastAccessed> servicesLastAccessed = response.ServicesLastAccessed;

            #endregion
        }

        public void IdentityManagementServiceGetServiceLastAccessedDetailsWithEntities()
        {
            #region getserviceaccessdetailsentity-policy-1541697621384

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.GetServiceLastAccessedDetailsWithEntities(new GetServiceLastAccessedDetailsWithEntitiesRequest 
            {
                JobId = "examplef-1305-c245-eba4-71fe298bcda7",
                ServiceNamespace = "iam"
            });

            List<EntityDetails> entityDetailsList = response.EntityDetailsList;
            bool isTruncated = response.IsTruncated;
            DateTime jobCompletionDate = response.JobCompletionDate;
            DateTime jobCreationDate = response.JobCreationDate;
            string jobStatus = response.JobStatus;

            #endregion
        }

        public void IdentityManagementServiceGetUser()
        {
            #region ede000a1-9e4c-40db-bd0a-d4f95e41a6ab

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
            #region 15571463-ebea-411a-a021-1c76bd2a3625

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
            #region e27b457a-16f9-4e05-a006-3df7b3472741

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListAccountAliases(new ListAccountAliasesRequest 
            {
            });

            List<string> accountAliases = response.AccountAliases;

            #endregion
        }

        public void IdentityManagementServiceListGroupPolicies()
        {
            #region 02de5095-2410-4d3a-ac1b-cc40234af68f

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
            #region b3ab1380-2a21-42fb-8e85-503f65512c66

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListGroups(new ListGroupsRequest 
            {
            });

            List<Group> groups = response.Groups;

            #endregion
        }

        public void IdentityManagementServiceListGroupsForUser()
        {
            #region 278ec2ee-fc28-4136-83fb-433af0ae46a2

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
            #region to-list-the-centralized-root-access-features-enabled-for-your-organization-1730908832557

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
            #region listpoliciesaccess-user-1541698749508

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListPoliciesGrantingServiceAccess(new ListPoliciesGrantingServiceAccessRequest 
            {
                Arn = "arn:aws:iam::123456789012:user/ExampleUser01",
                ServiceNamespaces = new List<string> {
                    "iam",
                    "ec2"
                }
            });

            bool isTruncated = response.IsTruncated;
            List<ListPoliciesGrantingServiceAccessEntry> policiesGrantingServiceAccess = response.PoliciesGrantingServiceAccess;

            #endregion
        }

        public void IdentityManagementServiceListRoleTags()
        {
            #region to-list-the-tags-attached-to-an-iam-role-1506719238376

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListRoleTags(new ListRoleTagsRequest 
            {
                RoleName = "taggedrole1"
            });

            bool isTruncated = response.IsTruncated;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void IdentityManagementServiceListSigningCertificates()
        {
            #region b4c10256-4fc9-457e-b3fd-4a110d4d73dc

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
            #region 9edfbd73-03d8-4d8a-9a79-76c85e8c8298

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListUsers(new ListUsersRequest 
            {
            });

            List<User> users = response.Users;

            #endregion
        }

        public void IdentityManagementServiceListUserTags()
        {
            #region to-list-the-tags-attached-to-an-iam-user-1506719473186

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListUserTags(new ListUserTagsRequest 
            {
                UserName = "anika"
            });

            bool isTruncated = response.IsTruncated;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void IdentityManagementServiceListVirtualMFADevices()
        {
            #region 54f9ac18-5100-4070-bec4-fe5f612710d5

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.ListVirtualMFADevices(new ListVirtualMFADevicesRequest 
            {
            });

            List<VirtualMFADevice> virtualMFADevices = response.VirtualMFADevices;

            #endregion
        }

        public void IdentityManagementServicePutGroupPolicy()
        {
            #region 4bc17418-758f-4d0f-ab0c-4d00265fec2e

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
            #region de62fd00-46c7-4601-9e0d-71d5fbb11ecb

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
            #region 2551ffc6-3576-4d39-823f-30b60bffc2c7

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
            #region 6d9f46f1-9f4a-4873-b403-51a85c5c627c

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
            #region fb54d5b4-0caf-41d8-af0e-10a84413f174

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
            #region 61a785a7-d30a-415a-ae18-ab9236e56871

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.SetSecurityTokenServicePreferences(new SetSecurityTokenServicePreferencesRequest 
            {
                GlobalEndpointTokenVersion = "v2Token"
            });


            #endregion
        }

        public void IdentityManagementServiceTagRole()
        {
            #region to-add-a-tag-key-and-value-to-an-iam-role-1506718791513

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
            #region to-add-a-tag-key-and-value-to-an-iam-user-1506719044227

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
            #region to-remove-a-tag-from-an-iam-role-1506719589943

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
            #region to-remove-a-tag-from-an-iam-user-1506719725554

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
            #region 02b556fd-e673-49b7-ab6b-f2f9035967d0

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
            #region c263a1af-37dc-4423-8dba-9790284ef5e0

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
            #region c9150063-d953-4e99-9576-9685872006c6

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
            #region f0cf1662-91ae-4278-a80e-7db54256ccba

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
            #region 036d9498-ecdb-4ed6-a8d8-366c383d1487

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
            #region 829aee7b-efc5-4b3b-84a5-7f899b38018d

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
            #region 275d53ed-347a-44e6-b7d0-a96276154352

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
            #region 06eab6d1-ebf2-4bd9-839d-f7508b9a38b6

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
            #region e67489b6-7b73-4e30-9ed3-9a9e0231e458

            var client = new AmazonIdentityManagementServiceClient();
            var response = client.UploadSigningCertificate(new UploadSigningCertificateRequest 
            {
                CertificateBody = "-----BEGIN CERTIFICATE-----<certificate-body>-----END CERTIFICATE-----",
                UserName = "Bob"
            });

            SigningCertificate certificate = response.Certificate;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}