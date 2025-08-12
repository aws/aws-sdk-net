using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Organizations;
using Amazon.Organizations.Model;

namespace AWSSDKDocSamples.Amazon.Organizations.Generated
{
    class OrganizationsSamples : ISample
    {
        public void OrganizationsAcceptHandshake()
        {
            #region to-accept-a-handshake-from-another-account-1472500561150

            var client = new AmazonOrganizationsClient();
            var response = client.AcceptHandshake(new AcceptHandshakeRequest 
            {
                HandshakeId = "h-examplehandshakeid111"
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsAttachPolicy()
        {
            #region to-attach-a-policy-to-an-ou

            var client = new AmazonOrganizationsClient();
            var response = client.AttachPolicy(new AttachPolicyRequest 
            {
                PolicyId = "p-examplepolicyid111",
                TargetId = "ou-examplerootid111-exampleouid111"
            });


            #endregion
        }

        public void OrganizationsAttachPolicy()
        {
            #region to-attach-a-policy-to-an-account

            var client = new AmazonOrganizationsClient();
            var response = client.AttachPolicy(new AttachPolicyRequest 
            {
                PolicyId = "p-examplepolicyid111",
                TargetId = "333333333333"
            });


            #endregion
        }

        public void OrganizationsCancelHandshake()
        {
            #region to-cancel-a-handshake-sent-to-a-member-account-1472501320506

            var client = new AmazonOrganizationsClient();
            var response = client.CancelHandshake(new CancelHandshakeRequest 
            {
                HandshakeId = "h-examplehandshakeid111"
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsCreateAccount()
        {
            #region to-create-a-new-account-that-is-automatically-part-of-the-organization-1472501463507

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
            #region to-create-a-new-organization-with-all-features enabled

            var client = new AmazonOrganizationsClient();
            var response = client.CreateOrganization(new CreateOrganizationRequest 
            {
            });

            Organization organization = response.Organization;

            #endregion
        }

        public void OrganizationsCreateOrganization()
        {
            #region to-create-a-new-organization-with-consolidated-billing-features-only

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
            #region to-create-a-new-organizational-unit

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
            #region to-create-a-service-control-policy

            var client = new AmazonOrganizationsClient();
            var response = client.CreatePolicy(new CreatePolicyRequest 
            {
                Content = "{\\"Version\\":\\"2012-10-17\\",\\"Statement\\":{\\"Effect\\":\\"Allow\\",\\"Action\\":\\"s3:*\\"}}",
                Description = "Enables admins of attached accounts to delegate all S3 permissions",
                Name = "AllowAllS3Actions",
                Type = "SERVICE_CONTROL_POLICY"
            });

            Policy policy = response.Policy;

            #endregion
        }

        public void OrganizationsDeclineHandshake()
        {
            #region to-decline-a-handshake-sent-from-the-master-account-1472502666967

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
            #region to-delete-an-organizational-unit

            var client = new AmazonOrganizationsClient();
            var response = client.DeleteOrganizationalUnit(new DeleteOrganizationalUnitRequest 
            {
                OrganizationalUnitId = "ou-examplerootid111-exampleouid111"
            });


            #endregion
        }

        public void OrganizationsDeletePolicy()
        {
            #region to-delete-a-policy

            var client = new AmazonOrganizationsClient();
            var response = client.DeletePolicy(new DeletePolicyRequest 
            {
                PolicyId = "p-examplepolicyid111"
            });


            #endregion
        }

        public void OrganizationsDescribeAccount()
        {
            #region to-get-the-details-about-an-account-1472503166868

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
            #region to-get-information-about-a-request-to-create-an-account-1472503727223

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
            #region to-get-information-about-a-handshake-1472503400505

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
            #region to-get-information-about-an-organization-1472503400505

            var client = new AmazonOrganizationsClient();
            var response = client.DescribeOrganization(new DescribeOrganizationRequest 
            {
            });

            Organization organization = response.Organization;

            #endregion
        }

        public void OrganizationsDescribeOrganizationalUnit()
        {
            #region to-get-information-about-an-organizational-unit

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
            #region to-get-information-about-a-policy

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
            #region to-detach-a-policy-from-a-root-ou-or-account

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
            #region to-disable-a-policy-type-in-a-root

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
            #region to-enable-all-features-in-an-organization

            var client = new AmazonOrganizationsClient();
            var response = client.EnableAllFeatures(new EnableAllFeaturesRequest 
            {
            });

            Handshake handshake = response.Handshake;

            #endregion
        }

        public void OrganizationsEnablePolicyType()
        {
            #region to-enable-a-policy-type-in-a-root

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
            #region to-invite-an-account-to-join-an-organization-1472508594110

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
            #region to-leave-an-organization-as-a-member-account-1472508784736

            var client = new AmazonOrganizationsClient();
            var response = client.LeaveOrganization(new LeaveOrganizationRequest 
            {
            });


            #endregion
        }

        public void OrganizationsListAccounts()
        {
            #region to-retrieve-a-list-of-all-of-the-accounts-in-an-organization-1472509590974

            var client = new AmazonOrganizationsClient();
            var response = client.ListAccounts(new ListAccountsRequest 
            {
            });

            List<Account> accounts = response.Accounts;

            #endregion
        }

        public void OrganizationsListAccountsForParent()
        {
            #region to-retrieve-a-list-of-all-of-the-accounts-in-a-root-or-ou-1472509590974

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
            #region to-list-all-accounts-in-an-organization-with-invalid-effective-policy

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
            #region to-retrieve-a-list-of-all-of-the-child-accounts-and-OUs-in-a-parent-container

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
            #region to-get-a-list-of-completed-account-creation-requests-made-in-the-organization

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

        public void OrganizationsListCreateAccountStatus()
        {
            #region to-get-a-list-of-all-account-creation-requests-made-in-the-organization-1472509174532

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

        public void OrganizationsListEffectivePolicyValidationErrors()
        {
            #region to-list-all-effective-policy-validation-errors-for-an-account-policy-type

            var client = new AmazonOrganizationsClient();
            var response = client.ListEffectivePolicyValidationErrors(new ListEffectivePolicyValidationErrorsRequest 
            {
                AccountId = "111111111111",
                PolicyType = "BACKUP_POLICY"
            });

            string accountId = response.AccountId;
            List<EffectivePolicyValidationError> effectivePolicyValidationErrors = response.EffectivePolicyValidationErrors;
            DateTime evaluationTimestamp = response.EvaluationTimestamp;
            string path = response.Path;
            string policyType = response.PolicyType;

            #endregion
        }

        public void OrganizationsListHandshakesForAccount()
        {
            #region to-retrieve-a-list-of-the-handshakes-sent-to-an-account-1472510214747

            var client = new AmazonOrganizationsClient();
            var response = client.ListHandshakesForAccount(new ListHandshakesForAccountRequest 
            {
            });

            List<Handshake> handshakes = response.Handshakes;

            #endregion
        }

        public void OrganizationsListHandshakesForOrganization()
        {
            #region to-retrieve-a-list-of-the-handshakes-associated-with-an-organization-1472511206653

            var client = new AmazonOrganizationsClient();
            var response = client.ListHandshakesForOrganization(new ListHandshakesForOrganizationRequest 
            {
            });

            List<Handshake> handshakes = response.Handshakes;

            #endregion
        }

        public void OrganizationsListOrganizationalUnitsForParent()
        {
            #region to-retrieve-a-list-of-all-of-the-OUs-in-a-parent-container

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
            #region to-retrieve-a-list-of-all-of-the-parents-of-a-child-ou-or-account

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
            #region to-retrieve-a-list-of--policies-in-the-organization

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
            #region to-retrieve-a-list-of-policies-attached-to-a-root-ou-or-account

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
            #region to-retrieve-a-list-of-roots-in-the-organization

            var client = new AmazonOrganizationsClient();
            var response = client.ListRoots(new ListRootsRequest 
            {
            });

            List<Root> roots = response.Roots;

            #endregion
        }

        public void OrganizationsListTargetsForPolicy()
        {
            #region to-retrieve-a-list-of-roots-ous-and-accounts-to-which-a-policy-is-attached

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
            #region to-move-an-ou-or-account-to-another-ou-or-the-root

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
            #region to-remove-an-account-from-an-organization-as-the-master-account

            var client = new AmazonOrganizationsClient();
            var response = client.RemoveAccountFromOrganization(new RemoveAccountFromOrganizationRequest 
            {
                AccountId = "333333333333"
            });


            #endregion
        }

        public void OrganizationsUpdateOrganizationalUnit()
        {
            #region to-rename-an-organizational-unit

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
            #region to-update-the-details-of-a-policy

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

        public void OrganizationsUpdatePolicy()
        {
            #region to-update-the-content-of-a-policy

            var client = new AmazonOrganizationsClient();
            var response = client.UpdatePolicy(new UpdatePolicyRequest 
            {
                Content = "{ \\"Version\\": \\"2012-10-17\\", \\"Statement\\": {\\"Effect\\": \\"Allow\\", \\"Action\\": \\"s3:*\\", \\"Resource\\": \\"*\\" } }",
                PolicyId = "p-examplepolicyid111"
            });

            Policy policy = response.Policy;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}