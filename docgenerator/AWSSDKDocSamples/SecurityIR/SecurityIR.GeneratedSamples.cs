using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SecurityIR;
using Amazon.SecurityIR.Model;

namespace AWSSDKDocSamples.Amazon.SecurityIR.Generated
{
    class SecurityIRSamples : ISample
    {
        public void SecurityIRBatchGetMemberAccountDetails()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.BatchGetMemberAccountDetails(new BatchGetMemberAccountDetailsRequest 
            {
                AccountIds = new List<string> {
                    "123412341234"
                },
                MembershipId = "m-abcd1234efgh"
            });

            List<GetMembershipAccountDetailItem> items = response.Items;

            #endregion
        }

        public void SecurityIRCancelMembership()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.CancelMembership(new CancelMembershipRequest 
            {
                MembershipId = "m-abcd1234efgh"
            });

            string membershipId = response.MembershipId;

            #endregion
        }

        public void SecurityIRCloseCase()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.CloseCase(new CloseCaseRequest 
            {
                CaseId = "8403556009"
            });

            string caseStatus = response.CaseStatus;
            DateTime closedDate = response.ClosedDate;

            #endregion
        }

        public void SecurityIRCreateCase()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.CreateCase(new CreateCaseRequest 
            {
                Description = "Case description",
                EngagementType = "Investigation",
                ImpactedAccounts = new List<string> {
                    "000000000000",
                    "111111111111"
                },
                ImpactedAwsRegions = new List<ImpactedAwsRegion> {
                    new ImpactedAwsRegion { Region = "ap-southeast-1" }
                },
                ImpactedServices = new List<string> {
                    "Amazon EC2",
                    "Amazon EKS"
                },
                ReportedIncidentStartDate = new DateTime(2023, 3, 27, 3, 32, 1, DateTimeKind.Utc),
                ResolverType = "Self",
                ThreatActorIpAddresses = new List<ThreatActorIp> {
                    new ThreatActorIp {
                        IpAddress = "192.168.192.168",
                        UserAgent = "Browser"
                    }
                },
                Title = "My sample case",
                Watchers = new List<Watcher> {
                    new Watcher {
                        Name = "Alice",
                        Email = "alice@example.com",
                        JobTitle = "CEO"
                    },
                    new Watcher {
                        Name = "Bob",
                        Email = "bob@example.com",
                        JobTitle = "CFO"
                    }
                }
            });


            #endregion
        }

        public void SecurityIRCreateCaseComment()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.CreateCaseComment(new CreateCaseCommentRequest 
            {
                Body = "Case comment body.",
                CaseId = "8403556009"
            });

            string commentId = response.CommentId;

            #endregion
        }

        public void SecurityIRCreateMembership()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.CreateMembership(new CreateMembershipRequest 
            {
                IncidentResponseTeam = new List<IncidentResponder> {
                    new IncidentResponder {
                        Name = "Bob Jones",
                        Email = "bob.jones@gmail.com",
                        JobTitle = "Security Responder"
                    },
                    new IncidentResponder {
                        Name = "Alice",
                        Email = "alice@example.com",
                        JobTitle = "CEO"
                    }
                },
                MembershipName = "Example Membership Name.",
                OptInFeatures = new List<OptInFeature> {
                    new OptInFeature {
                        FeatureName = "Triage",
                        IsEnabled = true
                    }
                }
            });

            string membershipId = response.MembershipId;

            #endregion
        }

        public void SecurityIRGetCase()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetCase(new GetCaseRequest 
            {
                CaseId = "8403556009"
            });

            DateTime actualIncidentStartDate = response.ActualIncidentStartDate;
            string caseArn = response.CaseArn;
            string caseStatus = response.CaseStatus;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            string engagementType = response.EngagementType;
            List<string> impactedAccounts = response.ImpactedAccounts;
            List<ImpactedAwsRegion> impactedAwsRegions = response.ImpactedAwsRegions;
            List<string> impactedServices = response.ImpactedServices;
            DateTime lastUpdatedDate = response.LastUpdatedDate;
            string pendingAction = response.PendingAction;
            DateTime reportedIncidentStartDate = response.ReportedIncidentStartDate;
            string resolverType = response.ResolverType;
            List<ThreatActorIp> threatActorIpAddresses = response.ThreatActorIpAddresses;
            string title = response.Title;
            List<Watcher> watchers = response.Watchers;

            #endregion
        }

        public void SecurityIRGetCaseAttachmentDownloadUrl()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetCaseAttachmentDownloadUrl(new GetCaseAttachmentDownloadUrlRequest 
            {
                AttachmentId = "3C5A6B89-1DEF-4C2D-A5B6-123456789ABC",
                CaseId = "8403556009"
            });

            string attachmentPresignedUrl = response.AttachmentPresignedUrl;

            #endregion
        }

        public void SecurityIRGetCaseAttachmentUploadUrl()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetCaseAttachmentUploadUrl(new GetCaseAttachmentUploadUrlRequest 
            {
                CaseId = "8403556009",
                ContentLength = 1500,
                FileName = "TestFileName"
            });

            string attachmentPresignedUrl = response.AttachmentPresignedUrl;

            #endregion
        }

        public void SecurityIRGetMembership()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetMembership(new GetMembershipRequest 
            {
                MembershipId = "m-abcd1234efgh"
            });

            string accountId = response.AccountId;
            string customerType = response.CustomerType;
            List<IncidentResponder> incidentResponseTeam = response.IncidentResponseTeam;
            DateTime membershipActivationTimestamp = response.MembershipActivationTimestamp;
            string membershipArn = response.MembershipArn;
            DateTime membershipDeactivationTimestamp = response.MembershipDeactivationTimestamp;
            string membershipId = response.MembershipId;
            string membershipName = response.MembershipName;
            string membershipStatus = response.MembershipStatus;
            long numberOfAccountsCovered = response.NumberOfAccountsCovered;
            List<OptInFeature> optInFeatures = response.OptInFeatures;
            string region = response.Region;

            #endregion
        }

        public void SecurityIRListCaseEdits()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListCaseEdits(new ListCaseEditsRequest 
            {
                CaseId = "8403556009"
            });

            List<CaseEditItem> items = response.Items;
            int total = response.Total;

            #endregion
        }

        public void SecurityIRListCases()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListCases(new ListCasesRequest 
            {
                MaxResults = 10
            });

            List<ListCasesItem> items = response.Items;
            long total = response.Total;

            #endregion
        }

        public void SecurityIRListComments()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListComments(new ListCommentsRequest 
            {
                CaseId = "8403556009"
            });

            List<ListCommentsItem> items = response.Items;
            int total = response.Total;

            #endregion
        }

        public void SecurityIRListMemberships()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListMemberships(new ListMembershipsRequest 
            {
                MaxResults = 10
            });

            List<ListMembershipItem> items = response.Items;

            #endregion
        }

        public void SecurityIRListTagsForResource()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:security-ir:us-west-1:123456789012:membership/m-abcd1234efgh"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void SecurityIRTagResource()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:security-ir:us-west-1:123456789012:membership/m-abcd1234efgh",
                Tags = new Dictionary<string, string> {
                    { "key", "example-tag-key" },
                    { "value", "example-tag-value" }
                }
            });


            #endregion
        }

        public void SecurityIRUntagResource()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:security-ir:us-west-1:123456789012:membership/m-abcd1234efgh",
                TagKeys = new List<string> {
                    "example-tag-key"
                }
            });


            #endregion
        }

        public void SecurityIRUpdateCase()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateCase(new UpdateCaseRequest 
            {
                ActualIncidentStartDate = new DateTime(2023, 3, 25, 3, 32, 1, DateTimeKind.Utc),
                CaseId = "8403556009",
                Description = "Case description",
                EngagementType = "Investigation",
                ImpactedAccountsToAdd = new List<string> {
                    "000000000000"
                },
                ImpactedAccountsToDelete = new List<string> {
                    "111111111111"
                },
                ImpactedAwsRegionsToAdd = new List<ImpactedAwsRegion> {
                    new ImpactedAwsRegion { Region = "ap-southeast-1" }
                },
                ImpactedAwsRegionsToDelete = new List<ImpactedAwsRegion> {
                    new ImpactedAwsRegion { Region = "us-east-1" }
                },
                ImpactedServicesToAdd = new List<string> {
                    "Amazon EC2"
                },
                ImpactedServicesToDelete = new List<string> {
                    "Amazon EKS"
                },
                ReportedIncidentStartDate = new DateTime(2023, 3, 27, 3, 32, 1, DateTimeKind.Utc),
                ThreatActorIpAddressesToAdd = new List<ThreatActorIp> {
                    new ThreatActorIp {
                        IpAddress = "190.160.190.160",
                        UserAgent = "Browser"
                    }
                },
                ThreatActorIpAddressesToDelete = new List<ThreatActorIp> {
                    new ThreatActorIp {
                        IpAddress = "192.168.192.168",
                        UserAgent = "Browser"
                    }
                },
                Title = "My sample case",
                WatchersToAdd = new List<Watcher> {
                    new Watcher {
                        Name = "Same",
                        Email = "Sam@example.com",
                        JobTitle = "CEO"
                    }
                },
                WatchersToDelete = new List<Watcher> {
                    new Watcher {
                        Name = "Bob",
                        Email = "bob@example.com",
                        JobTitle = "CFO"
                    }
                }
            });


            #endregion
        }

        public void SecurityIRUpdateCaseComment()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateCaseComment(new UpdateCaseCommentRequest 
            {
                Body = "Updated case comment.",
                CaseId = "8403556009",
                CommentId = "000000"
            });

            string body = response.Body;
            string commentId = response.CommentId;

            #endregion
        }

        public void SecurityIRUpdateCaseStatus()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateCaseStatus(new UpdateCaseStatusRequest 
            {
                CaseId = "8403556009",
                CaseStatus = "Post-incident Activities"
            });

            string caseStatus = response.CaseStatus;

            #endregion
        }

        public void SecurityIRUpdateMembership()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateMembership(new UpdateMembershipRequest 
            {
                IncidentResponseTeam = new List<IncidentResponder> {
                    new IncidentResponder {
                        Name = "Bob Jones",
                        Email = "bob.jones@gmail.com",
                        JobTitle = "Security Responder"
                    },
                    new IncidentResponder {
                        Name = "Alice",
                        Email = "alice@example.com",
                        JobTitle = "CEO"
                    }
                },
                MembershipId = "m-abcd1234efgh",
                MembershipName = "New membership name",
                OptInFeatures = new List<OptInFeature> {
                    new OptInFeature {
                        FeatureName = "Triage",
                        IsEnabled = true
                    }
                }
            });


            #endregion
        }

        public void SecurityIRUpdateResolverType()
        {
            #region example-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateResolverType(new UpdateResolverTypeRequest 
            {
                CaseId = "8403556009",
                ResolverType = "AWS"
            });

            string caseId = response.CaseId;
            string caseStatus = response.CaseStatus;
            string resolverType = response.ResolverType;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}