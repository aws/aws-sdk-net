using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

namespace AWSSDKDocSamples.Amazon.SimpleEmail.Generated
{
    class SimpleEmailServiceSamples : ISample
    {
        public void SimpleEmailServiceCloneReceiptRuleSet()
        {
            #region CloneReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.CloneReceiptRuleSet(new CloneReceiptRuleSetRequest
            {
                OriginalRuleSetName = "RuleSetToClone",
                RuleSetName = "RuleSetToCreate"
            });


            #endregion
        }

        public void SimpleEmailServiceCreateReceiptFilter()
        {
            #region CreateReceiptFilter-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.CreateReceiptFilter(new CreateReceiptFilterRequest
            {
                Filter = new ReceiptFilter {
                    IpFilter = new ReceiptIpFilter {
                        Cidr = "1.2.3.4/24",
                        Policy = "Allow"
                    },
                    Name = "MyFilter"
                }
            });


            #endregion
        }

        public void SimpleEmailServiceCreateReceiptRule()
        {
            #region CreateReceiptRule-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.CreateReceiptRule(new CreateReceiptRuleRequest
            {
                After = "",
                Rule = new ReceiptRule {
                    Actions = new List<ReceiptAction> {
                        new ReceiptAction { S3Action = new S3Action {
                            BucketName = "MyBucket",
                            ObjectKeyPrefix = "email"
                        } }
                    },
                    Enabled = true,
                    Name = "MyRule",
                    ScanEnabled = true,
                    TlsPolicy = "Optional"
                },
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceCreateReceiptRuleSet()
        {
            #region CreateReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.CreateReceiptRuleSet(new CreateReceiptRuleSetRequest
            {
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteIdentity()
        {
            #region DeleteIdentity-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteIdentity(new DeleteIdentityRequest
            {
                Identity = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteIdentityPolicy()
        {
            #region DeleteIdentityPolicy-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteIdentityPolicy(new DeleteIdentityPolicyRequest
            {
                Identity = "user@example.com",
                PolicyName = "MyPolicy"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteReceiptFilter()
        {
            #region DeleteReceiptFilter-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteReceiptFilter(new DeleteReceiptFilterRequest
            {
                FilterName = "MyFilter"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteReceiptRule()
        {
            #region DeleteReceiptRule-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteReceiptRule(new DeleteReceiptRuleRequest
            {
                RuleName = "MyRule",
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteReceiptRuleSet()
        {
            #region DeleteReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteReceiptRuleSet(new DeleteReceiptRuleSetRequest
            {
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteVerifiedEmailAddress()
        {
            #region DeleteVerifiedEmailAddress-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteVerifiedEmailAddress(new DeleteVerifiedEmailAddressRequest
            {
                EmailAddress = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceDescribeActiveReceiptRuleSet()
        {
            #region DescribeActiveReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DescribeActiveReceiptRuleSet(new DescribeActiveReceiptRuleSetRequest
            {
            });

            ReceiptRuleSetMetadata metadata = response.Metadata;
            List<ReceiptRule> rules = response.Rules;

            #endregion
        }

        public void SimpleEmailServiceDescribeReceiptRule()
        {
            #region DescribeReceiptRule-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DescribeReceiptRule(new DescribeReceiptRuleRequest
            {
                RuleName = "MyRule",
                RuleSetName = "MyRuleSet"
            });

            ReceiptRule rule = response.Rule;

            #endregion
        }

        public void SimpleEmailServiceDescribeReceiptRuleSet()
        {
            #region DescribeReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DescribeReceiptRuleSet(new DescribeReceiptRuleSetRequest
            {
                RuleSetName = "MyRuleSet"
            });

            ReceiptRuleSetMetadata metadata = response.Metadata;
            List<ReceiptRule> rules = response.Rules;

            #endregion
        }

        public void SimpleEmailServiceGetAccountSendingEnabled()
        {
            #region GetAccountSendingEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetAccountSendingEnabled(new GetAccountSendingEnabledRequest
            {
            });

            bool? enabled = response.Enabled;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityDkimAttributes()
        {
            #region GetIdentityDkimAttributes-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetIdentityDkimAttributes(new GetIdentityDkimAttributesRequest
            {
                Identities = new List<string> {
                    "example.com",
                    "user@example.com"
                }
            });

            Dictionary<string, IdentityDkimAttributes> dkimAttributes = response.DkimAttributes;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityMailFromDomainAttributes()
        {
            #region GetIdentityMailFromDomainAttributes-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetIdentityMailFromDomainAttributes(new GetIdentityMailFromDomainAttributesRequest
            {
                Identities = new List<string> {
                    "example.com"
                }
            });

            Dictionary<string, IdentityMailFromDomainAttributes> mailFromDomainAttributes = response.MailFromDomainAttributes;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityNotificationAttributes()
        {
            #region GetIdentityNotificationAttributes-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetIdentityNotificationAttributes(new GetIdentityNotificationAttributesRequest
            {
                Identities = new List<string> {
                    "example.com"
                }
            });

            Dictionary<string, IdentityNotificationAttributes> notificationAttributes = response.NotificationAttributes;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityPolicies()
        {
            #region GetIdentityPolicies-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetIdentityPolicies(new GetIdentityPoliciesRequest
            {
                Identity = "example.com",
                PolicyNames = new List<string> {
                    "MyPolicy"
                }
            });

            Dictionary<string, string> policies = response.Policies;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityVerificationAttributes()
        {
            #region GetIdentityVerificationAttributes-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetIdentityVerificationAttributes(new GetIdentityVerificationAttributesRequest
            {
                Identities = new List<string> {
                    "example.com"
                }
            });

            Dictionary<string, IdentityVerificationAttributes> verificationAttributes = response.VerificationAttributes;

            #endregion
        }

        public void SimpleEmailServiceGetSendQuota()
        {
            #region GetSendQuota-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetSendQuota(new GetSendQuotaRequest
            {
            });

            double? max24HourSend = response.Max24HourSend;
            double? maxSendRate = response.MaxSendRate;
            double? sentLast24Hours = response.SentLast24Hours;

            #endregion
        }

        public void SimpleEmailServiceGetSendStatistics()
        {
            #region GetSendStatistics-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetSendStatistics(new GetSendStatisticsRequest
            {
            });

            List<SendDataPoint> sendDataPoints = response.SendDataPoints;

            #endregion
        }

        public void SimpleEmailServiceListIdentities()
        {
            #region ListIdentities-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListIdentities(new ListIdentitiesRequest
            {
                IdentityType = "EmailAddress",
                MaxItems = 123,
                NextToken = ""
            });

            List<string> identities = response.Identities;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SimpleEmailServiceListIdentityPolicies()
        {
            #region ListIdentityPolicies-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListIdentityPolicies(new ListIdentityPoliciesRequest
            {
                Identity = "example.com"
            });

            List<string> policyNames = response.PolicyNames;

            #endregion
        }

        public void SimpleEmailServiceListReceiptFilters()
        {
            #region ListReceiptFilters-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListReceiptFilters(new ListReceiptFiltersRequest
            {
            });

            List<ReceiptFilter> filters = response.Filters;

            #endregion
        }

        public void SimpleEmailServiceListReceiptRuleSets()
        {
            #region ListReceiptRuleSets-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListReceiptRuleSets(new ListReceiptRuleSetsRequest
            {
                NextToken = ""
            });

            string nextToken = response.NextToken;
            List<ReceiptRuleSetMetadata> ruleSets = response.RuleSets;

            #endregion
        }

        public void SimpleEmailServiceListVerifiedEmailAddresses()
        {
            #region ListVerifiedEmailAddresses-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest
            {
            });

            List<string> verifiedEmailAddresses = response.VerifiedEmailAddresses;

            #endregion
        }

        public void SimpleEmailServicePutIdentityPolicy()
        {
            #region PutIdentityPolicy-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.PutIdentityPolicy(new PutIdentityPolicyRequest
            {
                Identity = "example.com",
                Policy = "{\"Version\":\"2008-10-17\",\"Statement\":[{\"Sid\":\"stmt1469123904194\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::123456789012:root\"},\"Action\":[\"ses:SendEmail\",\"ses:SendRawEmail\"],\"Resource\":\"arn:aws:ses:us-east-1:EXAMPLE65304:identity/example.com\"}]}",
                PolicyName = "MyPolicy"
            });


            #endregion
        }

        public void SimpleEmailServiceReorderReceiptRuleSet()
        {
            #region ReorderReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ReorderReceiptRuleSet(new ReorderReceiptRuleSetRequest
            {
                RuleNames = new List<string> {
                    "MyRule",
                    "MyOtherRule"
                },
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceSendEmail()
        {
            #region SendEmail-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SendEmail(new SendEmailRequest
            {
                Destination = new Destination {
                    BccAddresses = new List<string> {
                    },
                    CcAddresses = new List<string> {
                        "recipient3@example.com"
                    },
                    ToAddresses = new List<string> {
                        "recipient1@example.com",
                        "recipient2@example.com"
                    }
                },
                Message = new Message {
                    Body = new Body {
                        Html = new Content {
                            Charset = "UTF-8",
                            Data = "This message body contains HTML formatting. It can, for example, contain links like this one: <a class=\"ulink\" href=\"http://docs.aws.amazon.com/ses/latest/DeveloperGuide\" target=\"_blank\">Amazon SES Developer Guide</a>."
                        },
                        Text = new Content {
                            Charset = "UTF-8",
                            Data = "This is the message body in text format."
                        }
                    },
                    Subject = new Content {
                        Charset = "UTF-8",
                        Data = "Test email"
                    }
                },
                ReplyToAddresses = new List<string> {
                },
                ReturnPath = "",
                ReturnPathArn = "",
                Source = "sender@example.com",
                SourceArn = ""
            });

            string messageId = response.MessageId;

            #endregion
        }

        public void SimpleEmailServiceSendRawEmail()
        {
            #region SendRawEmail-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SendRawEmail(new SendRawEmailRequest
            {
                Destinations = new List<string> {
                },
                FromArn = "",
                RawMessage = new RawMessage { Data = new MemoryStream(From: sender@example.com\nTo: recipient@example.com\nSubject: Test email (contains an attachment)\nMIME-Version: 1.0\nContent-type: Multipart/Mixed; boundary="NextPart"\n\n--NextPart\nContent-Type: text/plain\n\nThis is the message body.\n\n--NextPart\nContent-Type: text/plain;\nContent-Disposition: attachment; filename="attachment.txt"\n\nThis is the text in the attachment.\n\n--NextPart--) },
                ReturnPathArn = "",
                Source = "",
                SourceArn = ""
            });

            string messageId = response.MessageId;

            #endregion
        }

        public void SimpleEmailServiceSetActiveReceiptRuleSet()
        {
            #region SetActiveReceiptRuleSet-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetActiveReceiptRuleSet(new SetActiveReceiptRuleSetRequest
            {
                RuleSetName = "RuleSetToActivate"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityDkimEnabled()
        {
            #region SetIdentityDkimEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetIdentityDkimEnabled(new SetIdentityDkimEnabledRequest
            {
                DkimEnabled = true,
                Identity = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityFeedbackForwardingEnabled()
        {
            #region SetIdentityFeedbackForwardingEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetIdentityFeedbackForwardingEnabled(new SetIdentityFeedbackForwardingEnabledRequest
            {
                ForwardingEnabled = true,
                Identity = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityHeadersInNotificationsEnabled()
        {
            #region SetIdentityHeadersInNotificationsEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetIdentityHeadersInNotificationsEnabled(new SetIdentityHeadersInNotificationsEnabledRequest
            {
                Enabled = true,
                Identity = "user@example.com",
                NotificationType = "Bounce"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityMailFromDomain()
        {
            #region SetIdentityMailFromDomain-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetIdentityMailFromDomain(new SetIdentityMailFromDomainRequest
            {
                BehaviorOnMXFailure = "UseDefaultValue",
                Identity = "user@example.com",
                MailFromDomain = "bounces.example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityNotificationTopic()
        {
            #region SetIdentityNotificationTopic-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetIdentityNotificationTopic(new SetIdentityNotificationTopicRequest
            {
                Identity = "user@example.com",
                NotificationType = "Bounce",
                SnsTopic = "arn:aws:sns:us-west-2:111122223333:MyTopic"
            });


            #endregion
        }

        public void SimpleEmailServiceSetReceiptRulePosition()
        {
            #region SetReceiptRulePosition-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetReceiptRulePosition(new SetReceiptRulePositionRequest
            {
                After = "PutRuleAfterThisRule",
                RuleName = "RuleToReposition",
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceUpdateAccountSendingEnabled()
        {
            #region UpdateAccountSendingEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.UpdateAccountSendingEnabled(new UpdateAccountSendingEnabledRequest
            {
                Enabled = true
            });


            #endregion
        }

        public void SimpleEmailServiceUpdateConfigurationSetReputationMetricsEnabled()
        {
            #region UpdateConfigurationSetReputationMetricsEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.UpdateConfigurationSetReputationMetricsEnabled(new UpdateConfigurationSetReputationMetricsEnabledRequest
            {
                ConfigurationSetName = "foo",
                Enabled = true
            });


            #endregion
        }

        public void SimpleEmailServiceUpdateConfigurationSetSendingEnabled()
        {
            #region UpdateConfigurationSetSendingEnabled-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.UpdateConfigurationSetSendingEnabled(new UpdateConfigurationSetSendingEnabledRequest
            {
                ConfigurationSetName = "foo",
                Enabled = true
            });


            #endregion
        }

        public void SimpleEmailServiceUpdateReceiptRule()
        {
            #region UpdateReceiptRule-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.UpdateReceiptRule(new UpdateReceiptRuleRequest
            {
                Rule = new ReceiptRule {
                    Actions = new List<ReceiptAction> {
                        new ReceiptAction { S3Action = new S3Action {
                            BucketName = "MyBucket",
                            ObjectKeyPrefix = "email"
                        } }
                    },
                    Enabled = true,
                    Name = "MyRule",
                    ScanEnabled = true,
                    TlsPolicy = "Optional"
                },
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceVerifyDomainDkim()
        {
            #region VerifyDomainDkim-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyDomainDkim(new VerifyDomainDkimRequest
            {
                Domain = "example.com"
            });

            List<string> dkimTokens = response.DkimTokens;

            #endregion
        }

        public void SimpleEmailServiceVerifyDomainIdentity()
        {
            #region VerifyDomainIdentity-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyDomainIdentity(new VerifyDomainIdentityRequest
            {
                Domain = "example.com"
            });

            string verificationToken = response.VerificationToken;

            #endregion
        }

        public void SimpleEmailServiceVerifyEmailAddress()
        {
            #region VerifyEmailAddress-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyEmailAddress(new VerifyEmailAddressRequest
            {
                EmailAddress = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceVerifyEmailIdentity()
        {
            #region VerifyEmailIdentity-1

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyEmailIdentity(new VerifyEmailIdentityRequest
            {
                EmailAddress = "user@example.com"
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
