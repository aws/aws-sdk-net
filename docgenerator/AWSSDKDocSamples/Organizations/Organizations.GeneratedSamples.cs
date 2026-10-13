using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Organizations;
using Amazon.Organizations.Model;

namespace AWSSDKDocSamples.Amazon.Organizations.Generated
{
    class OrganizationsSamples : ISample
    {
        public void OrganizationsAttachPolicy()
        {
            #region AttachPolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.AttachPolicy(new AttachPolicyRequest
            {
                PolicyId = "p-examplepolicyid111",
                TargetId = "333333333333"
            });


            #endregion
        }

        public void OrganizationsAttachPolicy()
        {
            #region AttachPolicy-2

            var client = new AmazonOrganizationsClient();
            var response = client.AttachPolicy(new AttachPolicyRequest
            {
                PolicyId = "p-examplepolicyid111",
                TargetId = "ou-examplerootid111-exampleouid111"
            });


            #endregion
        }

        public void OrganizationsCreateAccount()
        {
            #region CreateAccount-1

            var client = new AmazonOrganizationsClient();
            var response = client.CreateAccount(new CreateAccountRequest
            {
                AccountName = "Production Account",
                Email = "susan@example.com"
            });

            CreateAccountStatus createAccountStatus = response.CreateAccountStatus;

            #endregion
        }

        public void OrganizationsCreateOrganization()
        {
            #region CreateOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.CreateOrganization(new CreateOrganizationRequest
            {
            });

            Organization organization = response.Organization;

            #endregion
        }

        public void OrganizationsCreateOrganization()
        {
            #region CreateOrganization-2

            var client = new AmazonOrganizationsClient();
            var response = client.CreateOrganization(new CreateOrganizationRequest
            {
                FeatureSet = "CONSOLIDATED_BILLING"
            });

            Organization organization = response.Organization;

            #endregion
        }

        public void OrganizationsCreateOrganizationalUnit()
        {
            #region CreateOrganizationalUnit-1

            var client = new AmazonOrganizationsClient();
            var response = client.CreateOrganizationalUnit(new CreateOrganizationalUnitRequest
            {
                Name = "AccountingOU",
                ParentId = "r-examplerootid111"
            });

            OrganizationalUnit organizationalUnit = response.OrganizationalUnit;

            #endregion
        }

        public void OrganizationsCreatePolicy()
        {
            #region CreatePolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.CreatePolicy(new CreatePolicyRequest
            {
                Content = "{\\\"Version\\\":\\\"2012-10-17\\\",\\\"Statement\\\":{\\\"Effect\\\":\\\"Allow\\\",\\\"Action\\\":\\\"s3:*\\\"}}",
                Description = "Enables admins of attached accounts to delegate all S3 permissions",
                Name = "AllowAllS3Actions",
                Type = "SERVICE_CONTROL_POLICY"
            });

            Policy policy = response.Policy;

            #endregion
        }

        public void OrganizationsDeclineHandshake()
        {
            #region DeclineHandshake-1

            var client = new AmazonOrganizationsClient();
            var response = client.DeclineHandshake(new DeclineHandshakeRequest
            {
                HandshakeId = "h-examplehandshakeid111"
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsDeleteOrganizationalUnit()
        {
            #region DeleteOrganizationalUnit-1

            var client = new AmazonOrganizationsClient();
            var response = client.DeleteOrganizationalUnit(new DeleteOrganizationalUnitRequest
            {
                OrganizationalUnitId = "ou-examplerootid111-exampleouid111"
            });


            #endregion
        }

        public void OrganizationsDeletePolicy()
        {
            #region DeletePolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.DeletePolicy(new DeletePolicyRequest
            {
                PolicyId = "p-examplepolicyid111"
            });


            #endregion
        }

        public void OrganizationsDescribeAccount()
        {
            #region DescribeAccount-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeAccount(new DescribeAccountRequest
            {
                AccountId = "555555555555"
            });

            Account account = response.Account;

            #endregion
        }

        public void OrganizationsDescribeCreateAccountStatus()
        {
            #region DescribeCreateAccountStatus-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeCreateAccountStatus(new DescribeCreateAccountStatusRequest
            {
                CreateAccountRequestId = "car-exampleaccountcreationrequestid"
            });

            CreateAccountStatus createAccountStatus = response.CreateAccountStatus;

            #endregion
        }

        public void OrganizationsDescribeHandshake()
        {
            #region DescribeHandshake-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeHandshake(new DescribeHandshakeRequest
            {
                HandshakeId = "h-examplehandshakeid111"
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsDescribeOrganization()
        {
            #region DescribeOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeOrganization(new DescribeOrganizationRequest
            {
            });

            Organization organization = response.Organization;

            #endregion
        }

        public void OrganizationsDescribeOrganizationalUnit()
        {
            #region DescribeOrganizationalUnit-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeOrganizationalUnit(new DescribeOrganizationalUnitRequest
            {
                OrganizationalUnitId = "ou-examplerootid111-exampleouid111"
            });

            OrganizationalUnit organizationalUnit = response.OrganizationalUnit;

            #endregion
        }

        public void OrganizationsDescribePolicy()
        {
            #region DescribePolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.DescribePolicy(new DescribePolicyRequest
            {
                PolicyId = "p-examplepolicyid111"
            });

            Policy policy = response.Policy;

            #endregion
        }

        public void OrganizationsDetachPolicy()
        {
            #region DetachPolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.DetachPolicy(new DetachPolicyRequest
            {
                PolicyId = "p-examplepolicyid111",
                TargetId = "ou-examplerootid111-exampleouid111"
            });


            #endregion
        }

        public void OrganizationsDisablePolicyType()
        {
            #region DisablePolicyType-1

            var client = new AmazonOrganizationsClient();
            var response = client.DisablePolicyType(new DisablePolicyTypeRequest
            {
                PolicyType = "SERVICE_CONTROL_POLICY",
                RootId = "r-examplerootid111"
            });

            Root root = response.Root;

            #endregion
        }

        public void OrganizationsEnableAllFeatures()
        {
            #region EnableAllFeatures-1

            var client = new AmazonOrganizationsClient();
            var response = client.EnableAllFeatures(new EnableAllFeaturesRequest
            {
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsEnablePolicyType()
        {
            #region EnablePolicyType-1

            var client = new AmazonOrganizationsClient();
            var response = client.EnablePolicyType(new EnablePolicyTypeRequest
            {
                PolicyType = "SERVICE_CONTROL_POLICY",
                RootId = "r-examplerootid111"
            });

            Root root = response.Root;

            #endregion
        }

        public void OrganizationsInviteAccountToOrganization()
        {
            #region InviteAccountToOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.InviteAccountToOrganization(new InviteAccountToOrganizationRequest
            {
                Notes = "This is a request for Juan's account to join Bill's organization",
                Target = new HandshakeParty {
                    Id = "juan@example.com",
                    Type = "EMAIL"
                }
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsLeaveOrganization()
        {
            #region LeaveOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.LeaveOrganization(new LeaveOrganizationRequest
            {
            });


            #endregion
        }

        public void OrganizationsListAccountsForParent()
        {
            #region ListAccountsForParent-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListAccountsForParent(new ListAccountsForParentRequest
            {
                ParentId = "ou-examplerootid111-exampleouid111"
            });

            List<Account> accounts = response.Accounts;

            #endregion
        }

        public void OrganizationsListAccountsWithInvalidEffectivePolicy()
        {
            #region ListAccountsWithInvalidEffectivePolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListAccountsWithInvalidEffectivePolicy(new ListAccountsWithInvalidEffectivePolicyRequest
            {
                PolicyType = "BACKUP_POLICY"
            });

            List<Account> accounts = response.Accounts;

            #endregion
        }

        public void OrganizationsListChildren()
        {
            #region ListChildren-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListChildren(new ListChildrenRequest
            {
                ChildType = "ORGANIZATIONAL_UNIT",
                ParentId = "ou-examplerootid111-exampleouid111"
            });

            List<Child> children = response.Children;

            #endregion
        }

        public void OrganizationsListCreateAccountStatus()
        {
            #region ListCreateAccountStatus-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListCreateAccountStatus(new ListCreateAccountStatusRequest
            {
                States = new List<string> {
                    "IN_PROGRESS"
                }
            });

            List<CreateAccountStatus> createAccountStatuses = response.CreateAccountStatuses;

            #endregion
        }

        public void OrganizationsListCreateAccountStatus()
        {
            #region ListCreateAccountStatus-2

            var client = new AmazonOrganizationsClient();
            var response = client.ListCreateAccountStatus(new ListCreateAccountStatusRequest
            {
                States = new List<string> {
                    "SUCCEEDED"
                }
            });

            List<CreateAccountStatus> createAccountStatuses = response.CreateAccountStatuses;

            #endregion
        }

        public void OrganizationsListHandshakesForAccount()
        {
            #region ListHandshakesForAccount-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListHandshakesForAccount(new ListHandshakesForAccountRequest
            {
            });

            List<Handshake> handshakes = response.Handshakes;

            #endregion
        }

        public void OrganizationsListHandshakesForOrganization()
        {
            #region ListHandshakesForOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListHandshakesForOrganization(new ListHandshakesForOrganizationRequest
            {
            });

            List<Handshake> handshakes = response.Handshakes;

            #endregion
        }

        public void OrganizationsListOrganizationalUnitsForParent()
        {
            #region ListOrganizationalUnitsForParent-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListOrganizationalUnitsForParent(new ListOrganizationalUnitsForParentRequest
            {
                ParentId = "r-examplerootid111"
            });

            List<OrganizationalUnit> organizationalUnits = response.OrganizationalUnits;

            #endregion
        }

        public void OrganizationsListParents()
        {
            #region ListParents-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListParents(new ListParentsRequest
            {
                ChildId = "444444444444"
            });

            List<Parent> parents = response.Parents;

            #endregion
        }

        public void OrganizationsListPolicies()
        {
            #region ListPolicies-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListPolicies(new ListPoliciesRequest
            {
                Filter = "SERVICE_CONTROL_POLICY"
            });

            List<PolicySummary> policies = response.Policies;

            #endregion
        }

        public void OrganizationsListPoliciesForTarget()
        {
            #region ListPoliciesForTarget-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListPoliciesForTarget(new ListPoliciesForTargetRequest
            {
                Filter = "SERVICE_CONTROL_POLICY",
                TargetId = "444444444444"
            });

            List<PolicySummary> policies = response.Policies;

            #endregion
        }

        public void OrganizationsListRoots()
        {
            #region ListRoots-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListRoots(new ListRootsRequest
            {
            });

            List<Root> roots = response.Roots;

            #endregion
        }

        public void OrganizationsListTargetsForPolicy()
        {
            #region ListTargetsForPolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.ListTargetsForPolicy(new ListTargetsForPolicyRequest
            {
                PolicyId = "p-FullAWSAccess"
            });

            List<PolicyTargetSummary> targets = response.Targets;

            #endregion
        }

        public void OrganizationsMoveAccount()
        {
            #region MoveAccount-1

            var client = new AmazonOrganizationsClient();
            var response = client.MoveAccount(new MoveAccountRequest
            {
                AccountId = "333333333333",
                DestinationParentId = "ou-examplerootid111-exampleouid111",
                SourceParentId = "r-examplerootid111"
            });


            #endregion
        }

        public void OrganizationsRemoveAccountFromOrganization()
        {
            #region RemoveAccountFromOrganization-1

            var client = new AmazonOrganizationsClient();
            var response = client.RemoveAccountFromOrganization(new RemoveAccountFromOrganizationRequest
            {
                AccountId = "333333333333"
            });


            #endregion
        }

        public void OrganizationsUpdateOrganizationalUnit()
        {
            #region UpdateOrganizationalUnit-1

            var client = new AmazonOrganizationsClient();
            var response = client.UpdateOrganizationalUnit(new UpdateOrganizationalUnitRequest
            {
                Name = "AccountingOU",
                OrganizationalUnitId = "ou-examplerootid111-exampleouid111"
            });

            OrganizationalUnit organizationalUnit = response.OrganizationalUnit;

            #endregion
        }

        public void OrganizationsUpdatePolicy()
        {
            #region UpdatePolicy-1

            var client = new AmazonOrganizationsClient();
            var response = client.UpdatePolicy(new UpdatePolicyRequest
            {
                Content = "{ \\\"Version\\\": \\\"2012-10-17\\\", \\\"Statement\\\": {\\\"Effect\\\": \\\"Allow\\\", \\\"Action\\\": \\\"s3:*\\\", \\\"Resource\\\": \\\"*\\\" } }",
                PolicyId = "p-examplepolicyid111"
            });

            Policy policy = response.Policy;

            #endregion
        }

        public void OrganizationsUpdatePolicy()
        {
            #region UpdatePolicy-2

            var client = new AmazonOrganizationsClient();
            var response = client.UpdatePolicy(new UpdatePolicyRequest
            {
                Description = "This description replaces the original.",
                Name = "Renamed-Policy",
                PolicyId = "p-examplepolicyid111"
            });

            Policy policy = response.Policy;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
