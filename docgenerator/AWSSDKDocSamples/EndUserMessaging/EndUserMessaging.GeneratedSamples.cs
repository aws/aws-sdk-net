using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.EndUserMessaging;
using Amazon.EndUserMessaging.Model;

namespace AWSSDKDocSamples.Amazon.EndUserMessaging.Generated
{
    class EndUserMessagingSamples : ISample
    {
        public void EndUserMessagingCreateBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.CreateBrandProfile(new CreateBrandProfileRequest 
            {
                BrandProfileName = "AcmeCorp",
                DeletionProtectionEnabled = true
            });

            int attributesCreated = response.AttributesCreated;
            string brandProfileArn = response.BrandProfileArn;
            string brandProfileId = response.BrandProfileId;
            string brandProfileName = response.BrandProfileName;
            DateTime createdAt = response.CreatedAt;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingCreateBrandProfileAttributes()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.CreateBrandProfileAttributes(new CreateBrandProfileAttributesRequest 
            {
                Attributes = new List<BrandProfileAttributeInput> {
                    new BrandProfileAttributeInput {
                        AttributeName = "SupportEmail",
                        AttributeType = "TEXT",
                        AttributeValue = "support@example.com",
                        Category = "CONTACT"
                    }
                },
                BrandProfileId = "bp-abc12345678901234"
            });

            List<BrandProfileAttributeOutput> attributes = response.Attributes;

            #endregion
        }

        public void EndUserMessagingCreateBrandProfileFromRegistration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.CreateBrandProfileFromRegistration(new CreateBrandProfileFromRegistrationRequest 
            {
                BrandProfileName = "AcmeCorp",
                RegistrationId = "reg-abc12345678901234",
                SmartMatch = true
            });

            List<JobResult> results = response.Results;

            #endregion
        }

        public void EndUserMessagingCreateNotifyCodeConfiguration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.CreateNotifyCodeConfiguration(new CreateNotifyCodeConfigurationRequest 
            {
                ChannelParameters = new ChannelParameters { Text = new TextParameters { InlineTemplateBody = "Your verification code is {{code}}." } },
                CodeConfigurationParameters = new CodeConfigurationParameters {
                    CodeLength = 6,
                    CodeType = "NUMERIC",
                    MaxAttempts = 3,
                    ValidityPeriodMinutes = 10
                },
                NotifyCodeConfigurationName = "SignupOtp"
            });

            NotifyCodeConfiguration notifyCodeConfiguration = response.NotifyCodeConfiguration;

            #endregion
        }

        public void EndUserMessagingCreateRegistrationsFromBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.CreateRegistrationsFromBrandProfile(new CreateRegistrationsFromBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                RegistrationTypes = new List<string> {
                    "US_TOLL_FREE_REGISTRATION"
                },
                SmartMatch = true
            });

            List<JobResult> results = response.Results;

            #endregion
        }

        public void EndUserMessagingDeleteBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.DeleteBrandProfile(new DeleteBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234"
            });

            string brandProfileArn = response.BrandProfileArn;
            string brandProfileId = response.BrandProfileId;

            #endregion
        }

        public void EndUserMessagingDeleteBrandProfileAttribute()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.DeleteBrandProfileAttribute(new DeleteBrandProfileAttributeRequest 
            {
                AttributeName = "SupportEmail",
                BrandProfileId = "bp-abc12345678901234"
            });

            string attributeName = response.AttributeName;
            string brandProfileId = response.BrandProfileId;

            #endregion
        }

        public void EndUserMessagingDeleteNotifyCodeConfiguration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.DeleteNotifyCodeConfiguration(new DeleteNotifyCodeConfigurationRequest 
            {
                NotifyCodeConfigurationId = "ncc-abc12345678901234"
            });


            #endregion
        }

        public void EndUserMessagingGetBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.GetBrandProfile(new GetBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234"
            });

            string brandProfileArn = response.BrandProfileArn;
            string brandProfileId = response.BrandProfileId;
            string brandProfileName = response.BrandProfileName;
            DateTime createdAt = response.CreatedAt;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingGetBrandProfileAttribute()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.GetBrandProfileAttribute(new GetBrandProfileAttributeRequest 
            {
                AttributeName = "SupportEmail",
                BrandProfileId = "bp-abc12345678901234"
            });

            string attributeName = response.AttributeName;
            string attributeType = response.AttributeType;
            string attributeValue = response.AttributeValue;
            string category = response.Category;
            DateTime createdAt = response.CreatedAt;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingGetJob()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.GetJob(new GetJobRequest 
            {
                JobId = "job-abc12345678901234"
            });

            string brandProfileId = response.BrandProfileId;
            DateTime createdAt = response.CreatedAt;
            string jobId = response.JobId;
            string operationType = response.OperationType;
            List<JobResource> resources = response.Resources;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingGetNotifyCodeConfiguration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.GetNotifyCodeConfiguration(new GetNotifyCodeConfigurationRequest 
            {
                NotifyCodeConfigurationId = "ncc-abc12345678901234"
            });

            NotifyCodeConfiguration notifyCodeConfiguration = response.NotifyCodeConfiguration;

            #endregion
        }

        public void EndUserMessagingListBrandProfileAttributes()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListBrandProfileAttributes(new ListBrandProfileAttributesRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                MaxResults = 10
            });

            List<BrandProfileAttributeSummary> brandProfileAttributes = response.BrandProfileAttributes;

            #endregion
        }

        public void EndUserMessagingListBrandProfiles()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListBrandProfiles(new ListBrandProfilesRequest 
            {
                MaxResults = 10
            });

            List<BrandProfileInfo> brandProfiles = response.BrandProfiles;

            #endregion
        }

        public void EndUserMessagingListJobs()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListJobs(new ListJobsRequest 
            {
                MaxResults = 10,
                Status = "SUCCESS"
            });

            List<JobSummary> jobs = response.Jobs;

            #endregion
        }

        public void EndUserMessagingListNotifyCodeConfigurations()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListNotifyCodeConfigurations(new ListNotifyCodeConfigurationsRequest 
            {
                MaxResults = 10
            });

            List<NotifyCodeConfiguration> notifyCodeConfigurations = response.NotifyCodeConfigurations;

            #endregion
        }

        public void EndUserMessagingListRegistrationsFromBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListRegistrationsFromBrandProfile(new ListRegistrationsFromBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                MaxResults = 10
            });

            List<RegistrationAssociationSummary> registrationAssociations = response.RegistrationAssociations;

            #endregion
        }

        public void EndUserMessagingListTagsForResource()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:end-user-messaging:us-east-1:123456789012:brand-profile/bp-abc12345678901234"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void EndUserMessagingSendNotifyCodeVerification()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.SendNotifyCodeVerification(new SendNotifyCodeVerificationRequest 
            {
                Channel = "TEXT",
                DestinationIdentity = "+14255550100",
                NotifyCodeConfiguration = "ncc-abc12345678901234",
                OriginationIdentity = "arn:aws:sms-voice:us-east-1:123456789012:phone-number/pn-abc123",
                ReferenceId = "signup-flow-42"
            });

            string messageId = response.MessageId;
            string verificationId = response.VerificationId;

            #endregion
        }

        public void EndUserMessagingTagResource()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:end-user-messaging:us-east-1:123456789012:brand-profile/bp-abc12345678901234",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Environment",
                        Value = "Production"
                    }
                }
            });


            #endregion
        }

        public void EndUserMessagingUntagResource()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:end-user-messaging:us-east-1:123456789012:brand-profile/bp-abc12345678901234",
                TagKeys = new List<string> {
                    "Environment"
                }
            });


            #endregion
        }

        public void EndUserMessagingUpdateBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UpdateBrandProfile(new UpdateBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                BrandProfileName = "AcmeCorpUpdated",
                DeletionProtectionEnabled = false
            });

            string brandProfileArn = response.BrandProfileArn;
            string brandProfileId = response.BrandProfileId;
            string brandProfileName = response.BrandProfileName;
            DateTime createdAt = response.CreatedAt;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingUpdateBrandProfileAttribute()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UpdateBrandProfileAttribute(new UpdateBrandProfileAttributeRequest 
            {
                AttributeName = "SupportEmail",
                AttributeValue = "help@example.com",
                BrandProfileId = "bp-abc12345678901234",
                Category = "CONTACT"
            });

            string attributeName = response.AttributeName;
            string attributeType = response.AttributeType;
            string attributeValue = response.AttributeValue;
            string category = response.Category;
            DateTime createdAt = response.CreatedAt;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void EndUserMessagingUpdateBrandProfileFromRegistration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UpdateBrandProfileFromRegistration(new UpdateBrandProfileFromRegistrationRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                OnAttributeConflict = "REPLACE",
                RegistrationId = "reg-abc12345678901234",
                SmartMatch = true
            });

            List<JobResult> results = response.Results;

            #endregion
        }

        public void EndUserMessagingUpdateNotifyCodeConfiguration()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UpdateNotifyCodeConfiguration(new UpdateNotifyCodeConfigurationRequest 
            {
                CodeConfigurationParameters = new UpdateCodeConfigurationParameters {
                    CodeLength = 8,
                    ValidityPeriodMinutes = 15
                },
                NotifyCodeConfigurationId = "ncc-abc12345678901234"
            });

            NotifyCodeConfiguration notifyCodeConfiguration = response.NotifyCodeConfiguration;

            #endregion
        }

        public void EndUserMessagingUpdateRegistrationsFromBrandProfile()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.UpdateRegistrationsFromBrandProfile(new UpdateRegistrationsFromBrandProfileRequest 
            {
                BrandProfileId = "bp-abc12345678901234",
                OnAttributeConflict = "PRESERVE",
                RegistrationIds = new List<string> {
                    "reg-abc12345678901234"
                },
                SmartMatch = true
            });

            List<JobResult> results = response.Results;

            #endregion
        }

        public void EndUserMessagingValidateNotifyCodeVerification()
        {
            #region example-1

            var client = new AmazonEndUserMessagingClient();
            var response = client.ValidateNotifyCodeVerification(new ValidateNotifyCodeVerificationRequest 
            {
                Code = "123456",
                DestinationIdentity = "+14255550100",
                ReferenceId = "signup-flow-42"
            });

            string status = response.Status;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}