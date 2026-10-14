using System;
using System.Collections.Generic;
using System.IO;
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
            #region BatchGetMemberAccountDetails-1

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
            #region CancelMembership-1

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
            #region CloseCase-1

            var client = new AmazonSecurityIRClient();
            var response = client.CloseCase(new CloseCaseRequest
            {
                CaseId = "8403556009"
            });

            CaseStatus caseStatus = response.CaseStatus;
            DateTime? closedDate = response.ClosedDate;

            #endregion
        }

        public void SecurityIRCreateCase()
        {
            #region CreateCase-1

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
                ReportedIncidentStartDate = new DateTime(2023, 3, 27, 15, 32, 1, 789, DateTimeKind.Utc),
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
                        Email = "alice@example.com",
                        JobTitle = "CEO",
                        Name = "Alice"
                    },
                    new Watcher {
                        Email = "bob@example.com",
                        JobTitle = "CFO",
                        Name = "Bob"
                    }
                }
            });


            #endregion
        }

        public void SecurityIRCreateCaseComment()
        {
            #region CreateCaseComment-1

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
            #region CreateMembership-1

            var client = new AmazonSecurityIRClient();
            var response = client.CreateMembership(new CreateMembershipRequest
            {
                IncidentResponseTeam = new List<IncidentResponder> {
                    new IncidentResponder {
                        Email = "bob.jones@gmail.com",
                        JobTitle = "Security Responder",
                        Name = "Bob Jones"
                    },
                    new IncidentResponder {
                        Email = "alice@example.com",
                        JobTitle = "CEO",
                        Name = "Alice"
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
            #region GetCase-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetCase(new GetCaseRequest
            {
                CaseId = "8403556009"
            });

            DateTime? actualIncidentStartDate = response.ActualIncidentStartDate;
            string caseArn = response.CaseArn;
            CaseStatus caseStatus = response.CaseStatus;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            EngagementType engagementType = response.EngagementType;
            List<string> impactedAccounts = response.ImpactedAccounts;
            List<ImpactedAwsRegion> impactedAwsRegions = response.ImpactedAwsRegions;
            List<string> impactedServices = response.ImpactedServices;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            PendingAction pendingAction = response.PendingAction;
            DateTime? reportedIncidentStartDate = response.ReportedIncidentStartDate;
            ResolverType resolverType = response.ResolverType;
            List<ThreatActorIp> threatActorIpAddresses = response.ThreatActorIpAddresses;
            string title = response.Title;
            List<Watcher> watchers = response.Watchers;

            #endregion
        }

        public void SecurityIRGetCaseAttachmentDownloadUrl()
        {
            #region GetCaseAttachmentDownloadUrl-1

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
            #region GetCaseAttachmentUploadUrl-1

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

        public void SecurityIRGetFindingMetrics()
        {
            #region GetFindingMetrics-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetFindingMetrics(new GetFindingMetricsRequest
            {
                EndDate = new DateTime(2026, 8, 18, 0, 0, 0, DateTimeKind.Utc),
                MembershipId = "m-a1b2c3d4e5f",
                StartDate = new DateTime(2026, 8, 1, 0, 0, 0, DateTimeKind.Utc)
            });

            long? findingsEscalated = response.FindingsEscalated;
            long? findingsEscalatedFalsePositive = response.FindingsEscalatedFalsePositive;
            long? findingsEscalatedInProgress = response.FindingsEscalatedInProgress;
            long? findingsIngestedGuardDuty = response.FindingsIngestedGuardDuty;
            long? findingsIngestedSecurityHub = response.FindingsIngestedSecurityHub;
            long? findingsInvestigated = response.FindingsInvestigated;
            long? findingsInvestigatedFalsePositive = response.FindingsInvestigatedFalsePositive;
            long? findingsInvestigatedInProgress = response.FindingsInvestigatedInProgress;
            long? findingsTriaged = response.FindingsTriaged;
            long? findingsTriagedFalsePositive = response.FindingsTriagedFalsePositive;
            long? findingsTruePositive = response.FindingsTruePositive;

            #endregion
        }

        public void SecurityIRGetMembership()
        {
            #region GetMembership-1

            var client = new AmazonSecurityIRClient();
            var response = client.GetMembership(new GetMembershipRequest
            {
                MembershipId = "m-abcd1234efgh"
            });

            string accountId = response.AccountId;
            CustomerType customerType = response.CustomerType;
            List<IncidentResponder> incidentResponseTeam = response.IncidentResponseTeam;
            DateTime? membershipActivationTimestamp = response.MembershipActivationTimestamp;
            string membershipArn = response.MembershipArn;
            DateTime? membershipDeactivationTimestamp = response.MembershipDeactivationTimestamp;
            string membershipId = response.MembershipId;
            string membershipName = response.MembershipName;
            MembershipStatus membershipStatus = response.MembershipStatus;
            long? numberOfAccountsCovered = response.NumberOfAccountsCovered;
            List<OptInFeature> optInFeatures = response.OptInFeatures;
            AwsRegion region = response.Region;

            #endregion
        }

        public void SecurityIRListCaseEdits()
        {
            #region ListCaseEdits-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListCaseEdits(new ListCaseEditsRequest
            {
                CaseId = "8403556009"
            });

            List<CaseEditItem> items = response.Items;
            int? total = response.Total;

            #endregion
        }

        public void SecurityIRListCases()
        {
            #region ListCases-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListCases(new ListCasesRequest
            {
                MaxResults = 10
            });

            List<ListCasesItem> items = response.Items;
            long? total = response.Total;

            #endregion
        }

        public void SecurityIRListComments()
        {
            #region ListComments-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListComments(new ListCommentsRequest
            {
                CaseId = "8403556009"
            });

            List<ListCommentsItem> items = response.Items;
            int? total = response.Total;

            #endregion
        }

        public void SecurityIRListInvestigations()
        {
            #region ListInvestigations-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListInvestigations(new ListInvestigationsRequest
            {
                CaseId = "8403556009",
                MaxResults = 10
            });

            List<InvestigationAction> investigationActions = response.InvestigationActions;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SecurityIRListMemberships()
        {
            #region ListMemberships-1

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
            #region ListTagsForResource-1

            var client = new AmazonSecurityIRClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:security-ir:us-west-1:123456789012:membership/m-abcd1234efgh"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void SecurityIRSendFeedback()
        {
            #region SendFeedback-1

            var client = new AmazonSecurityIRClient();
            var response = client.SendFeedback(new SendFeedbackRequest
            {
                CaseId = "8403556009",
                Comment = "The CloudTrail analysis was very helpful in identifying the root cause of the security incident.",
                ResultId = "inv-polkjhyuty",
                Usefulness = "USEFUL"
            });


            #endregion
        }

        public void SecurityIRSendFeedback()
        {
            #region SendFeedback-2

            var client = new AmazonSecurityIRClient();
            var response = client.SendFeedback(new SendFeedbackRequest
            {
                CaseId = "8403556009",
                Comment = "The investigation results were too generic and didn't provide actionable insights for our specific incident.",
                ResultId = "inv-irutjfhgjk",
                Usefulness = "NOT_USEFUL"
            });


            #endregion
        }

        public void SecurityIRTagResource()
        {
            #region TagResource-1

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
            #region UntagResource-1

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
            #region UpdateCase-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateCase(new UpdateCaseRequest
            {
                ActualIncidentStartDate = new DateTime(2023, 3, 25, 15, 32, 1, 789, DateTimeKind.Utc),
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
                ReportedIncidentStartDate = new DateTime(2023, 3, 27, 15, 32, 1, 789, DateTimeKind.Utc),
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
                        Email = "Sam@example.com",
                        JobTitle = "CEO",
                        Name = "Same"
                    }
                },
                WatchersToDelete = new List<Watcher> {
                    new Watcher {
                        Email = "bob@example.com",
                        JobTitle = "CFO",
                        Name = "Bob"
                    }
                }
            });


            #endregion
        }

        public void SecurityIRUpdateCaseComment()
        {
            #region UpdateCaseComment-1

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
            #region UpdateCaseStatus-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateCaseStatus(new UpdateCaseStatusRequest
            {
                CaseId = "8403556009",
                CaseStatus = "Post-incident Activities"
            });

            SelfManagedCaseStatus caseStatus = response.CaseStatus;

            #endregion
        }

        public void SecurityIRUpdateMembership()
        {
            #region UpdateMembership-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateMembership(new UpdateMembershipRequest
            {
                IncidentResponseTeam = new List<IncidentResponder> {
                    new IncidentResponder {
                        Email = "bob.jones@gmail.com",
                        JobTitle = "Security Responder",
                        Name = "Bob Jones"
                    },
                    new IncidentResponder {
                        Email = "alice@example.com",
                        JobTitle = "CEO",
                        Name = "Alice"
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
            #region UpdateResolverType-1

            var client = new AmazonSecurityIRClient();
            var response = client.UpdateResolverType(new UpdateResolverTypeRequest
            {
                CaseId = "8403556009",
                ResolverType = "AWS"
            });

            string caseId = response.CaseId;
            CaseStatus caseStatus = response.CaseStatus;
            ResolverType resolverType = response.ResolverType;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
