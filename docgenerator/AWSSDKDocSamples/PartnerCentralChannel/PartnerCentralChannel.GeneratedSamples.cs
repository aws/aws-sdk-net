using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PartnerCentralChannel;
using Amazon.PartnerCentralChannel.Model;

namespace AWSSDKDocSamples.Amazon.PartnerCentralChannel.Generated
{
    class PartnerCentralChannelSamples : ISample
    {
        public void PartnerCentralChannelAcceptChannelHandshake()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.AcceptChannelHandshake(new AcceptChannelHandshakeRequest 
            {
                Catalog = "AWS",
                Identifier = "ch-4fj3bd2o3vb91"
            });

            AcceptChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCancelChannelHandshake()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CancelChannelHandshake(new CancelChannelHandshakeRequest 
            {
                Catalog = "AWS",
                Identifier = "ch-4fj3bd2o3vb91"
            });

            CancelChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateChannelHandshake()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateChannelHandshake(new CreateChannelHandshakeRequest 
            {
                AssociatedResourceIdentifier = "rs-abc123def456g",
                Catalog = "AWS",
                ClientToken = "clientToken",
                HandshakeType = "START_SERVICE_PERIOD",
                Payload = new ChannelHandshakePayload { StartServicePeriodPayload = new StartServicePeriodPayload {
                    MinimumNoticeDays = "14",
                    Note = "Optional Note",
                    ProgramManagementAccountIdentifier = "pma-abcdef123456g",
                    ServicePeriodType = "MINIMUM_NOTICE_PERIOD"
                } }
            });

            CreateChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateChannelHandshake()
        {
            #region example-2

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateChannelHandshake(new CreateChannelHandshakeRequest 
            {
                AssociatedResourceIdentifier = "rs-abc123def456g",
                Catalog = "AWS",
                ClientToken = "clientToken",
                HandshakeType = "START_SERVICE_PERIOD",
                Payload = new ChannelHandshakePayload { StartServicePeriodPayload = new StartServicePeriodPayload {
                    EndDate = new DateTime(2026, 7, 1, 12, 0, 0, DateTimeKind.Utc),
                    Note = "Optional Note",
                    ProgramManagementAccountIdentifier = "pma-abcdef123456g",
                    ServicePeriodType = "FIXED_COMMITMENT_PERIOD"
                } }
            });

            CreateChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateChannelHandshake()
        {
            #region example-3

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateChannelHandshake(new CreateChannelHandshakeRequest 
            {
                AssociatedResourceIdentifier = "rs-abc123def456g",
                Catalog = "AWS",
                ClientToken = "clientToken",
                HandshakeType = "REVOKE_SERVICE_PERIOD",
                Payload = new ChannelHandshakePayload { RevokeServicePeriodPayload = new RevokeServicePeriodPayload {
                    Note = "Optional Note",
                    ProgramManagementAccountIdentifier = "pma-abcdef123456g"
                } }
            });

            CreateChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateChannelHandshake()
        {
            #region example-4

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateChannelHandshake(new CreateChannelHandshakeRequest 
            {
                AssociatedResourceIdentifier = "pma-123abc456def7",
                Catalog = "AWS",
                ClientToken = "clientToken",
                HandshakeType = "PROGRAM_MANAGEMENT_ACCOUNT"
            });

            CreateChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateProgramManagementAccount()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateProgramManagementAccount(new CreateProgramManagementAccountRequest 
            {
                AccountId = "111122223333",
                Catalog = "AWS",
                ClientToken = "clientToken",
                DisplayName = "TestDisplayName",
                Program = "SOLUTION_PROVIDER"
            });

            CreateProgramManagementAccountDetail programManagementAccountDetail = response.ProgramManagementAccountDetail;

            #endregion
        }

        public void PartnerCentralChannelCreateRelationship()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.CreateRelationship(new CreateRelationshipRequest 
            {
                AssociatedAccountId = "987654321012",
                AssociationType = "DOWNSTREAM_SELLER",
                Catalog = "AWS",
                ClientToken = "clientToken",
                DisplayName = "TestDisplayName",
                ProgramManagementAccountIdentifier = "pma-u8ic702rtzng8",
                ResaleAccountModel = "END_CUSTOMER",
                Sector = "COMMERCIAL"
            });

            CreateRelationshipDetail relationshipDetail = response.RelationshipDetail;

            #endregion
        }

        public void PartnerCentralChannelDeleteProgramManagementAccount()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.DeleteProgramManagementAccount(new DeleteProgramManagementAccountRequest 
            {
                Catalog = "AWS",
                ClientToken = "clientToken",
                Identifier = "pma-u8ic702rtzng8"
            });


            #endregion
        }

        public void PartnerCentralChannelDeleteRelationship()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.DeleteRelationship(new DeleteRelationshipRequest 
            {
                Catalog = "AWS",
                ClientToken = "clientToken",
                Identifier = "rs-l9o4fj3b5zb91",
                ProgramManagementAccountIdentifier = "pma-u8ic702rtzng8"
            });


            #endregion
        }

        public void PartnerCentralChannelGetRelationship()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.GetRelationship(new GetRelationshipRequest 
            {
                Catalog = "AWS",
                Identifier = "rs-l9o4fj3b5zb91",
                ProgramManagementAccountIdentifier = "pma-u8ic702rtzng8"
            });

            RelationshipDetail relationshipDetail = response.RelationshipDetail;

            #endregion
        }

        public void PartnerCentralChannelListChannelHandshakes()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListChannelHandshakes(new ListChannelHandshakesRequest 
            {
                AssociatedResourceIdentifiers = new List<string> {
                    "rs-123abc456def7"
                },
                Catalog = "AWS",
                HandshakeType = "START_SERVICE_PERIOD",
                HandshakeTypeFilters = new ListChannelHandshakesTypeFilters { StartServicePeriodTypeFilters = new StartServicePeriodTypeFilters { ServicePeriodTypes = new List<string> {
                    "FIXED_COMMITMENT_PERIOD"
                } } },
                HandshakeTypeSort = new ListChannelHandshakesTypeSort { StartServicePeriodTypeSort = new StartServicePeriodTypeSort {
                    SortBy = "UpdatedAt",
                    SortOrder = "Descending"
                } },
                ParticipantType = "SENDER",
                Statuses = new List<string> {
                    "ACCEPTED"
                }
            });

            List<ChannelHandshakeSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void PartnerCentralChannelListChannelHandshakes()
        {
            #region example-2

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListChannelHandshakes(new ListChannelHandshakesRequest 
            {
                AssociatedResourceIdentifiers = new List<string> {
                    "rs-123abc456def7"
                },
                Catalog = "AWS",
                HandshakeType = "REVOKE_SERVICE_PERIOD",
                HandshakeTypeFilters = new ListChannelHandshakesTypeFilters { RevokeServicePeriodTypeFilters = new RevokeServicePeriodTypeFilters { ServicePeriodTypes = new List<string> {
                    "MINIMUM_NOTICE_PERIOD"
                } } },
                HandshakeTypeSort = new ListChannelHandshakesTypeSort { RevokeServicePeriodTypeSort = new RevokeServicePeriodTypeSort {
                    SortBy = "UpdatedAt",
                    SortOrder = "Descending"
                } },
                ParticipantType = "SENDER",
                Statuses = new List<string> {
                    "ACCEPTED"
                }
            });

            List<ChannelHandshakeSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void PartnerCentralChannelListChannelHandshakes()
        {
            #region example-3

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListChannelHandshakes(new ListChannelHandshakesRequest 
            {
                AssociatedResourceIdentifiers = new List<string> {
                    "pma-123abc456def7"
                },
                Catalog = "AWS",
                HandshakeType = "PROGRAM_MANAGEMENT_ACCOUNT",
                HandshakeTypeFilters = new ListChannelHandshakesTypeFilters { ProgramManagementAccountTypeFilters = new ProgramManagementAccountTypeFilters { Programs = new List<string> {
                    "SOLUTION_PROVIDER"
                } } },
                HandshakeTypeSort = new ListChannelHandshakesTypeSort { ProgramManagementAccountTypeSort = new ProgramManagementAccountTypeSort {
                    SortBy = "UpdatedAt",
                    SortOrder = "Descending"
                } },
                MaxResults = 20,
                NextToken = "nextToken",
                ParticipantType = "SENDER",
                Statuses = new List<string> {
                    "ACCEPTED"
                }
            });

            List<ChannelHandshakeSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void PartnerCentralChannelListProgramManagementAccounts()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListProgramManagementAccounts(new ListProgramManagementAccountsRequest 
            {
                AccountIds = new List<string> {
                    "111122223333"
                },
                Catalog = "AWS",
                DisplayNames = new List<string> {
                    "TestDisplayName"
                },
                MaxResults = 20,
                Programs = new List<string> {
                    "SOLUTION_PROVIDER"
                },
                Sort = new ListProgramManagementAccountsSortBase {
                    SortBy = "UpdatedAt",
                    SortOrder = "Descending"
                },
                Statuses = new List<string> {
                    "PENDING"
                }
            });

            List<ProgramManagementAccountSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void PartnerCentralChannelListRelationships()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListRelationships(new ListRelationshipsRequest 
            {
                AssociatedAccountIds = new List<string> {
                    "123456789012"
                },
                AssociationTypes = new List<string> {
                    "DOWNSTREAM_SELLER"
                },
                Catalog = "AWS",
                DisplayNames = new List<string> {
                    "TestDisplayName"
                },
                MaxResults = 100,
                NextToken = "nextToken",
                ProgramManagementAccountIdentifiers = new List<string> {
                    "pma-u8ic702rtzng8"
                },
                Sort = new ListRelationshipsSortBase {
                    SortBy = "UpdatedAt",
                    SortOrder = "Descending"
                }
            });

            List<RelationshipSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void PartnerCentralChannelListTagsForResource()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:partnercentral:us-east-1:123456789012:catalog/AWS/program-management-account/pma-u8ic702rtzng8"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void PartnerCentralChannelRejectChannelHandshake()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.RejectChannelHandshake(new RejectChannelHandshakeRequest 
            {
                Catalog = "AWS",
                Identifier = "ch-4fj3bd2o3vb91"
            });

            RejectChannelHandshakeDetail channelHandshakeDetail = response.ChannelHandshakeDetail;

            #endregion
        }

        public void PartnerCentralChannelTagResource()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:partnercentral:us-east-1:123456789012:catalog/AWS/program-management-account/pma-u8ic702rtzng8/relationship/rs-l9o4fj3b5zb91",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "ExampleKey",
                        Value = "ExampleValue"
                    }
                }
            });


            #endregion
        }

        public void PartnerCentralChannelUntagResource()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:partnercentral:us-east-1:123456789012:catalog/AWS/channel-handshake/ch-4fj3bd2o3vb91",
                TagKeys = new List<string> {
                    "ExampleKey"
                }
            });


            #endregion
        }

        public void PartnerCentralChannelUpdateProgramManagementAccount()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.UpdateProgramManagementAccount(new UpdateProgramManagementAccountRequest 
            {
                Catalog = "AWS",
                DisplayName = "TestDisplayName",
                Identifier = "pma-u8ic702rtzng8",
                Revision = "3"
            });

            UpdateProgramManagementAccountDetail programManagementAccountDetail = response.ProgramManagementAccountDetail;

            #endregion
        }

        public void PartnerCentralChannelUpdateRelationship()
        {
            #region example-1

            var client = new AmazonPartnerCentralChannelClient();
            var response = client.UpdateRelationship(new UpdateRelationshipRequest 
            {
                Catalog = "AWS",
                DisplayName = "TestDisplayName",
                Identifier = "rs-l9o4fj3b5zb91",
                ProgramManagementAccountIdentifier = "pma-u8ic702rtzng8",
                Revision = "3"
            });

            UpdateRelationshipDetail relationshipDetail = response.RelationshipDetail;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}