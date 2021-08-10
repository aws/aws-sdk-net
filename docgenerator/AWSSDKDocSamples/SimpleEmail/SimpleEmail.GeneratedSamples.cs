using System;
using System.Collections.Generic;
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
            #region clonereceiptruleset-1469055039770

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
            #region createreceiptfilter-1469122681253

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
            #region createreceiptrule-1469122946515

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
            #region createreceiptruleset-1469058761646

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.CreateReceiptRuleSet(new CreateReceiptRuleSetRequest 
            {
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteIdentity()
        {
            #region deleteidentity-1469047858906

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteIdentity(new DeleteIdentityRequest 
            {
                Identity = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteIdentityPolicy()
        {
            #region deleteidentitypolicy-1469055282499

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
            #region deletereceiptfilter-1469055456835

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteReceiptFilter(new DeleteReceiptFilterRequest 
            {
                FilterName = "MyFilter"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteReceiptRule()
        {
            #region deletereceiptrule-1469055563599

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
            #region deletereceiptruleset-1469055713690

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteReceiptRuleSet(new DeleteReceiptRuleSetRequest 
            {
                RuleSetName = "MyRuleSet"
            });


            #endregion
        }

        public void SimpleEmailServiceDeleteVerifiedEmailAddress()
        {
            #region deleteverifiedemailaddress-1469051086444

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.DeleteVerifiedEmailAddress(new DeleteVerifiedEmailAddressRequest 
            {
                EmailAddress = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceDescribeActiveReceiptRuleSet()
        {
            #region describeactivereceiptruleset-1469121611502

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
            #region describereceiptrule-1469055813118

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
            #region describereceiptruleset-1469121240385

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
            #region getaccountsendingenabled-1469047741333

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetAccountSendingEnabled(new GetAccountSendingEnabledRequest 
            {
            });

            bool enabled = response.Enabled;

            #endregion
        }

        public void SimpleEmailServiceGetIdentityDkimAttributes()
        {
            #region getidentitydkimattributes-1469050695628

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
            #region getidentitymailfromdomainattributes-1469123114860

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
            #region getidentitynotificationattributes-1469123466947

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
            #region getidentitypolicies-1469123949351

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
            #region getidentityverificationattributes-1469124205897

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
            #region getsendquota-1469047324508

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetSendQuota(new GetSendQuotaRequest 
            {
            });

            double max24HourSend = response.Max24HourSend;
            double maxSendRate = response.MaxSendRate;
            double sentLast24Hours = response.SentLast24Hours;

            #endregion
        }

        public void SimpleEmailServiceGetSendStatistics()
        {
            #region getsendstatistics-1469047741329

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.GetSendStatistics(new GetSendStatisticsRequest 
            {
            });

            List<SendDataPoint> sendDataPoints = response.SendDataPoints;

            #endregion
        }

        public void SimpleEmailServiceListIdentities()
        {
            #region listidentities-1469048638493

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
            #region listidentitypolicies-1469124417674

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
            #region listreceiptfilters-1469120786789

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListReceiptFilters(new ListReceiptFiltersRequest 
            {
            });

            List<ReceiptFilter> filters = response.Filters;

            #endregion
        }

        public void SimpleEmailServiceListReceiptRuleSets()
        {
            #region listreceiptrulesets-1469121037235

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
            #region listverifiedemailaddresses-1469051402570

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest 
            {
            });

            List<string> verifiedEmailAddresses = response.VerifiedEmailAddresses;

            #endregion
        }

        public void SimpleEmailServicePutIdentityPolicy()
        {
            #region putidentitypolicy-1469124560016

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
            #region reorderreceiptruleset-1469058156806

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
            #region sendemail-1469049656296

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
            #region sendrawemail-1469118548649

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
            #region setactivereceiptruleset-1469058391329

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.SetActiveReceiptRuleSet(new SetActiveReceiptRuleSetRequest 
            {
                RuleSetName = "RuleSetToActivate"
            });


            #endregion
        }

        public void SimpleEmailServiceSetIdentityDkimEnabled()
        {
            #region setidentitydkimenabled-1469057485202

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
            #region setidentityfeedbackforwardingenabled-1469056811329

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
            #region setidentityheadersinnotificationsenabled-1469057295001

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
            #region setidentitymailfromdomain-1469057693908

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
            #region setidentitynotificationtopic-1469057854966

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
            #region setreceiptruleposition-1469058530550

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
            #region updateaccountsendingenabled-1469047741333

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.UpdateAccountSendingEnabled(new UpdateAccountSendingEnabledRequest 
            {
                Enabled = true
            });


            #endregion
        }

        public void SimpleEmailServiceUpdateConfigurationSetReputationMetricsEnabled()
        {
            #region updateconfigurationsetreputationmetricsenabled-2362747741333

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
            #region updateconfigurationsetsendingenabled-2362747741333

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
            #region updatereceiptrule-1469051756940

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
            #region verifydomaindkim-1469049503083

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
            #region verifydomainidentity-1469049165936

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
            #region verifyemailaddress-1469048849187

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyEmailAddress(new VerifyEmailAddressRequest 
            {
                EmailAddress = "user@example.com"
            });


            #endregion
        }

        public void SimpleEmailServiceVerifyEmailIdentity()
        {
            #region verifyemailidentity-1469049068623

            var client = new AmazonSimpleEmailServiceClient();
            var response = client.VerifyEmailIdentity(new VerifyEmailIdentityRequest 
            {
                EmailAddress = "user@example.com"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}