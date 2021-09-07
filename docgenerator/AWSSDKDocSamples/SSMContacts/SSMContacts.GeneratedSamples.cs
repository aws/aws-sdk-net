using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SSMContacts;
using Amazon.SSMContacts.Model;

namespace AWSSDKDocSamples.Amazon.SSMContacts.Generated
{
    class SSMContactsSamples : ISample
    {
        public void SSMContactsAcceptPage()
        {
            #region to-accept-a-page-during-and-engagement-1630357840187

            var client = new AmazonSSMContactsClient();
            var response = client.AcceptPage(new AcceptPageRequest 
            {
                AcceptCode = "425440",
                AcceptType = "READ",
                PageId = "arn:aws:ssm-contacts:us-east-2:682428703967:page/akuam/94ea0c7b-56d9-46c3-b84a-a37c8b067ad3"
            });


            #endregion
        }

        public void SSMContactsActivateContactChannel()
        {
            #region activate-a-contacts-contact-channel-1630359780075

            var client = new AmazonSSMContactsClient();
            var response = client.ActivateContactChannel(new ActivateContactChannelRequest 
            {
                ActivationCode = "466136",
                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/fc7405c4-46b2-48b7-87b2-93e2f225b90d"
            });


            #endregion
        }

        public void SSMContactsCreateContact()
        {
            #region to-create-a-contact-1630360152750

            var client = new AmazonSSMContactsClient();
            var response = client.CreateContact(new CreateContactRequest 
            {
                Alias = "akuam",
                DisplayName = "Akua Mansa",
                Plan = new Plan { Stages = new List<Stage> {
                    
                } },
                Type = "PERSONAL"
            });

            string contactArn = response.ContactArn;

            #endregion
        }

        public void SSMContactsCreateContactChannel()
        {
            #region to-create-a-contact-channel-1630360447010

            var client = new AmazonSSMContactsClient();
            var response = client.CreateContactChannel(new CreateContactChannelRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam",
                DeliveryAddress = new ContactChannelAddress { SimpleAddress = "+15005550199" },
                Name = "akuas sms-test",
                Type = "SMS"
            });

            string contactChannelArn = response.ContactChannelArn;

            #endregion
        }

        public void SSMContactsDeactivateContactChannel()
        {
            #region to-deactivate-a-contact-channel-1630360853894

            var client = new AmazonSSMContactsClient();
            var response = client.DeactivateContactChannel(new DeactivateContactChannelRequest 
            {
                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/fc7405c4-46b2-48b7-87b2-93e2f225b90d"
            });


            #endregion
        }

        public void SSMContactsDeleteContact()
        {
            #region to-delete-a-contact-1630361093863

            var client = new AmazonSSMContactsClient();
            var response = client.DeleteContact(new DeleteContactRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/alejr"
            });


            #endregion
        }

        public void SSMContactsDeleteContactChannel()
        {
            #region to-delete-a-contact-channel-1630364616682

            var client = new AmazonSSMContactsClient();
            var response = client.DeleteContactChannel(new DeleteContactChannelRequest 
            {
                ContactChannelId = "arn:aws:ssm-contacts:us-east-1:111122223333:contact-channel/akuam/13149bad-52ee-45ea-ae1e-45857f78f9b2"
            });


            #endregion
        }

        public void SSMContactsDescribeEngagement()
        {
            #region to-describe-the-details-of-an-engagement-1630364719475

            var client = new AmazonSSMContactsClient();
            var response = client.DescribeEngagement(new DescribeEngagementRequest 
            {
                EngagementId = "arn:aws:ssm-contacts:us-east-2:111122223333:engagement/example_escalation/69e40ce1-8dbb-4d57-8962-5fbe7fc53356"
            });

            string contactArn = response.ContactArn;
            string content = response.Content;
            string engagementArn = response.EngagementArn;
            string publicContent = response.PublicContent;
            string publicSubject = response.PublicSubject;
            string sender = response.Sender;
            DateTime startTime = response.StartTime;
            string subject = response.Subject;

            #endregion
        }

        public void SSMContactsDescribePage()
        {
            #region to-list-the-details-of-a-page-to-a-contact-channel-1630364907282

            var client = new AmazonSSMContactsClient();
            var response = client.DescribePage(new DescribePageRequest 
            {
                PageId = "arn:aws:ssm-contacts:us-east-2:111122223333:page/akuam/ad0052bd-e606-498a-861b-25726292eb93"
            });

            string contactArn = response.ContactArn;
            string content = response.Content;
            DateTime deliveryTime = response.DeliveryTime;
            string engagementArn = response.EngagementArn;
            string pageArn = response.PageArn;
            string publicContent = response.PublicContent;
            string publicSubject = response.PublicSubject;
            DateTime readTime = response.ReadTime;
            string sender = response.Sender;
            DateTime sentTime = response.SentTime;
            string subject = response.Subject;

            #endregion
        }

        public void SSMContactsGetContact()
        {
            #region example-1-to-describe-a-contact-plan-1630365360005

            var client = new AmazonSSMContactsClient();
            var response = client.GetContact(new GetContactRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/akuam"
            });

            string alias = response.Alias;
            string contactArn = response.ContactArn;
            string displayName = response.DisplayName;
            Plan plan = response.Plan;
            string type = response.Type;

            #endregion
        }

        public void SSMContactsGetContact()
        {
            #region example-2-to-describe-an-escalation-plan-1630365515731

            var client = new AmazonSSMContactsClient();
            var response = client.GetContact(new GetContactRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/example_escalation"
            });

            string alias = response.Alias;
            string contactArn = response.ContactArn;
            string displayName = response.DisplayName;
            Plan plan = response.Plan;
            string type = response.Type;

            #endregion
        }

        public void SSMContactsGetContactChannel()
        {
            #region to-list-the-details-of-a-contact-channel-1630365682730

            var client = new AmazonSSMContactsClient();
            var response = client.GetContactChannel(new GetContactChannelRequest 
            {
                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/fc7405c4-46b2-48b7-87b2-93e2f225b90d"
            });

            string activationStatus = response.ActivationStatus;
            string contactArn = response.ContactArn;
            string contactChannelArn = response.ContactChannelArn;
            ContactChannelAddress deliveryAddress = response.DeliveryAddress;
            string name = response.Name;
            string type = response.Type;

            #endregion
        }

        public void SSMContactsGetContactPolicy()
        {
            #region to-list-the-details-of-a-contact-channel-1630365682730

            var client = new AmazonSSMContactsClient();
            var response = client.GetContactPolicy(new GetContactPolicyRequest 
            {
                ContactArn = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam"
            });

            string contactArn = response.ContactArn;
            string policy = response.Policy;

            #endregion
        }

        public void SSMContactsListContactChannels()
        {
            #region to-list-the-contact-channels-of-a-contact-1630366544252

            var client = new AmazonSSMContactsClient();
            var response = client.ListContactChannels(new ListContactChannelsRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/akuam"
            });

            List<ContactChannel> contactChannels = response.ContactChannels;

            #endregion
        }

        public void SSMContactsListContacts()
        {
            #region to-list-all-escalation-plans-and-contacts-1630367103082

            var client = new AmazonSSMContactsClient();
            var response = client.ListContacts(new ListContactsRequest 
            {
            });

            List<Contact> contacts = response.Contacts;

            #endregion
        }

        public void SSMContactsListEngagements()
        {
            #region to-list-all-engagements-1630367432635

            var client = new AmazonSSMContactsClient();
            var response = client.ListEngagements(new ListEngagementsRequest 
            {
            });

            List<Engagement> engagements = response.Engagements;

            #endregion
        }

        public void SSMContactsListPageReceipts()
        {
            #region to-list-page-receipts-1630367706869

            var client = new AmazonSSMContactsClient();
            var response = client.ListPageReceipts(new ListPageReceiptsRequest 
            {
                PageId = "arn:aws:ssm-contacts:us-east-2:111122223333:page/akuam/94ea0c7b-56d9-46c3-b84a-a37c8b067ad3"
            });

            List<Receipt> receipts = response.Receipts;

            #endregion
        }

        public void SSMContactsListPagesByContact()
        {
            #region to-list-pages-by-contact-1630435789132

            var client = new AmazonSSMContactsClient();
            var response = client.ListPagesByContact(new ListPagesByContactRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/akuam"
            });

            List<Page> pages = response.Pages;

            #endregion
        }

        public void SSMContactsListPagesByEngagement()
        {
            #region to-list-pages-to-contact-channels-started-from-an-engagement-1630435864674

            var client = new AmazonSSMContactsClient();
            var response = client.ListPagesByEngagement(new ListPagesByEngagementRequest 
            {
                EngagementId = "arn:aws:ssm-contacts:us-east-2:111122223333:engagement/akuam/78a29753-3674-4ac5-9f83-0468563567f0"
            });

            List<Page> pages = response.Pages;

            #endregion
        }

        public void SSMContactsListTagsForResource()
        {
            #region to-list-tags-for-a-contact-1630436051681

            var client = new AmazonSSMContactsClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void SSMContactsPutContactPolicy()
        {
            #region to-share-a-contact-and-engagements-1630436278898

            var client = new AmazonSSMContactsClient();
            var response = client.PutContactPolicy(new PutContactPolicyRequest 
            {
                ContactArn = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam",
                Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"ExampleResourcePolicy\",\"Action\":[\"ssm-contacts:GetContact\",\"ssm-contacts:StartEngagement\",\"ssm-contacts:DescribeEngagement\",\"ssm-contacts:ListPagesByEngagement\",\"ssm-contacts:StopEngagement\"],\"Principal\":{\"AWS\":\"222233334444\"},\"Effect\":\"Allow\",\"Resource\":[\"arn:aws:ssm-contacts:*:111122223333:contact/akuam\",\"arn:aws:ssm-contacts:*:111122223333:engagement/akuam/*\"]}]}"
            });


            #endregion
        }

        public void SSMContactsSendActivationCode()
        {
            #region to-send-an-activation-code-1630436453574

            var client = new AmazonSSMContactsClient();
            var response = client.SendActivationCode(new SendActivationCodeRequest 
            {
                ContactChannelId = "arn:aws:ssm-contacts:us-east-1:111122223333:contact-channel/akuam/8ddae2d1-12c8-4e45-b852-c8587266c400"
            });


            #endregion
        }

        public void SSMContactsStartEngagement()
        {
            #region example-1-to-page-a-contacts-contact-channels-1630436634872

            var client = new AmazonSSMContactsClient();
            var response = client.StartEngagement(new StartEngagementRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/akuam",
                Content = "Testing engagements",
                PublicContent = "Testing engagements",
                PublicSubject = "test",
                Sender = "tester",
                Subject = "test"
            });

            string engagementArn = response.EngagementArn;

            #endregion
        }

        public void SSMContactsStartEngagement()
        {
            #region example-2-to-page-a-contact-in-the-provided-escalation-plan-1630436808480

            var client = new AmazonSSMContactsClient();
            var response = client.StartEngagement(new StartEngagementRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/example_escalation",
                Content = "Testing engagements",
                PublicContent = "Testing engagements",
                PublicSubject = "test",
                Sender = "tester",
                Subject = "test"
            });

            string engagementArn = response.EngagementArn;

            #endregion
        }

        public void SSMContactsStopEngagement()
        {
            #region to-stop-an-engagement-1630436882864

            var client = new AmazonSSMContactsClient();
            var response = client.StopEngagement(new StopEngagementRequest 
            {
                EngagementId = "arn:aws:ssm-contacts:us-east-2:111122223333:engagement/example_escalation/69e40ce1-8dbb-4d57-8962-5fbe7fc53356"
            });


            #endregion
        }

        public void SSMContactsTagResource()
        {
            #region to-tag-a-contact-1630437124572

            var client = new AmazonSSMContactsClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "group1",
                        Value = "1"
                    }
                }
            });


            #endregion
        }

        public void SSMContactsUntagResource()
        {
            #region to-remove-tags-from-a-contact-1630437251110

            var client = new AmazonSSMContactsClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:ssm-contacts:us-east-1:111122223333:contact/akuam",
                TagKeys = new List<string> {
                    "group1"
                }
            });


            #endregion
        }

        public void SSMContactsUpdateContact()
        {
            #region to-update-the-engagement-plan-of-contact-1630437436599

            var client = new AmazonSSMContactsClient();
            var response = client.UpdateContact(new UpdateContactRequest 
            {
                ContactId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact/akuam",
                Plan = new Plan { Stages = new List<Stage> {
                    new Stage {
                        DurationInMinutes = 5,
                        Targets = new List<Target> {
                            new Target { ChannelTargetInfo = new ChannelTargetInfo {
                                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/beb25840-5ac8-4644-95cc-7a8de390fa65",
                                RetryIntervalInMinutes = 1
                            } }
                        }
                    },
                    new Stage {
                        DurationInMinutes = 5,
                        Targets = new List<Target> {
                            new Target { ChannelTargetInfo = new ChannelTargetInfo {
                                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/49f3c24d-5f9f-4638-ae25-3f49e04229ad",
                                RetryIntervalInMinutes = 1
                            } }
                        }
                    },
                    new Stage {
                        DurationInMinutes = 5,
                        Targets = new List<Target> {
                            new Target { ChannelTargetInfo = new ChannelTargetInfo {
                                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/77d4f447-f619-4954-afff-85551e369c2a",
                                RetryIntervalInMinutes = 1
                            } }
                        }
                    }
                } }
            });


            #endregion
        }

        public void SSMContactsUpdateContactChannel()
        {
            #region to-update-a-contact-channel-1630437610256

            var client = new AmazonSSMContactsClient();
            var response = client.UpdateContactChannel(new UpdateContactChannelRequest 
            {
                ContactChannelId = "arn:aws:ssm-contacts:us-east-2:111122223333:contact-channel/akuam/49f3c24d-5f9f-4638-ae25-3f49e04229ad",
                DeliveryAddress = new ContactChannelAddress { SimpleAddress = "+15005550198" },
                Name = "akuas voice channel"
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