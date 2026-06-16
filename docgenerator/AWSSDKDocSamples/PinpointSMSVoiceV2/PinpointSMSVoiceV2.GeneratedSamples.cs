using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PinpointSMSVoiceV2;
using Amazon.PinpointSMSVoiceV2.Model;

namespace AWSSDKDocSamples.Amazon.PinpointSMSVoiceV2.Generated
{
    class PinpointSMSVoiceV2Samples : ISample
    {
        public void PinpointSMSVoiceV2CarrierLookup()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.CarrierLookup(new CarrierLookupRequest 
            {
                PhoneNumber = "+1 (555) 555-5333"
            });

            string carrier = response.Carrier;
            string country = response.Country;
            string dialingCountryCode = response.DialingCountryCode;
            string e164PhoneNumber = response.E164PhoneNumber;
            string isoCountryCode = response.IsoCountryCode;
            string mcc = response.MCC;
            string mnc = response.MNC;
            string phoneNumberType = response.PhoneNumberType;

            #endregion
        }

        public void PinpointSMSVoiceV2CreateNotifyConfiguration()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.CreateNotifyConfiguration(new CreateNotifyConfigurationRequest 
            {
                DeletionProtectionEnabled = false,
                DisplayName = "MyOTPConfig",
                EnabledChannels = new List<string> {
                    "SMS"
                },
                EnabledCountries = new List<string> {
                    "US",
                    "CA"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Environment",
                        Value = "Production"
                    }
                },
                UseCase = "CODE_VERIFICATION"
            });

            DateTime createdTimestamp = response.CreatedTimestamp;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string displayName = response.DisplayName;
            List<string> enabledChannels = response.EnabledChannels;
            List<string> enabledCountries = response.EnabledCountries;
            string notifyConfigurationArn = response.NotifyConfigurationArn;
            string notifyConfigurationId = response.NotifyConfigurationId;
            string status = response.Status;
            List<Tag> tags = response.Tags;
            string tier = response.Tier;
            string tierUpgradeStatus = response.TierUpgradeStatus;
            string useCase = response.UseCase;

            #endregion
        }

        public void PinpointSMSVoiceV2DeleteNotifyConfiguration()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.DeleteNotifyConfiguration(new DeleteNotifyConfigurationRequest 
            {
                NotifyConfigurationId = "nc-1234567890abcdef0"
            });

            DateTime createdTimestamp = response.CreatedTimestamp;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string displayName = response.DisplayName;
            List<string> enabledChannels = response.EnabledChannels;
            List<string> enabledCountries = response.EnabledCountries;
            string notifyConfigurationArn = response.NotifyConfigurationArn;
            string notifyConfigurationId = response.NotifyConfigurationId;
            string status = response.Status;
            string tier = response.Tier;
            string tierUpgradeStatus = response.TierUpgradeStatus;
            string useCase = response.UseCase;

            #endregion
        }

        public void PinpointSMSVoiceV2DeleteNotifyMessageSpendLimitOverride()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.DeleteNotifyMessageSpendLimitOverride(new DeleteNotifyMessageSpendLimitOverrideRequest 
            {
            });

            long monthlyLimit = response.MonthlyLimit;

            #endregion
        }

        public void PinpointSMSVoiceV2DescribeNotifyConfigurations()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.DescribeNotifyConfigurations(new DescribeNotifyConfigurationsRequest 
            {
                Filters = new List<NotifyConfigurationFilter> {
                    new NotifyConfigurationFilter {
                        Name = "status",
                        Values = new List<string> {
                            "ACTIVE"
                        }
                    }
                },
                MaxResults = 10
            });

            List<NotifyConfigurationInformation> notifyConfigurations = response.NotifyConfigurations;

            #endregion
        }

        public void PinpointSMSVoiceV2DescribeNotifyTemplates()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.DescribeNotifyTemplates(new DescribeNotifyTemplatesRequest 
            {
                Filters = new List<NotifyTemplateFilter> {
                    new NotifyTemplateFilter {
                        Name = "template-type",
                        Values = new List<string> {
                            "OTP_VERIFICATION"
                        }
                    },
                    new NotifyTemplateFilter {
                        Name = "channels",
                        Values = new List<string> {
                            "SMS"
                        }
                    }
                },
                MaxResults = 10
            });

            List<NotifyTemplateInformation> notifyTemplates = response.NotifyTemplates;

            #endregion
        }

        public void PinpointSMSVoiceV2ListNotifyCountries()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.ListNotifyCountries(new ListNotifyCountriesRequest 
            {
                Channels = new List<string> {
                    "SMS"
                },
                MaxResults = 10
            });

            List<NotifyCountryInformation> notifyCountries = response.NotifyCountries;

            #endregion
        }

        public void PinpointSMSVoiceV2SendNotifyTextMessage()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.SendNotifyTextMessage(new SendNotifyTextMessageRequest 
            {
                DestinationPhoneNumber = "+12065550100",
                NotifyConfigurationId = "nc-1234567890abcdef0",
                TemplateVariables = new Dictionary<string, string> {
                    { "code", "123456" },
                    { "expiry", "10" }
                }
            });

            string messageId = response.MessageId;
            string resolvedMessageBody = response.ResolvedMessageBody;
            string templateId = response.TemplateId;

            #endregion
        }

        public void PinpointSMSVoiceV2SendNotifyVoiceMessage()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.SendNotifyVoiceMessage(new SendNotifyVoiceMessageRequest 
            {
                DestinationPhoneNumber = "+12065550100",
                NotifyConfigurationId = "nc-1234567890abcdef0",
                TemplateVariables = new Dictionary<string, string> {
                    { "code", "123456" },
                    { "expiry", "10" }
                },
                VoiceId = "JOANNA"
            });

            string messageId = response.MessageId;
            string resolvedMessageBody = response.ResolvedMessageBody;
            string templateId = response.TemplateId;

            #endregion
        }

        public void PinpointSMSVoiceV2SetNotifyMessageSpendLimitOverride()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.SetNotifyMessageSpendLimitOverride(new SetNotifyMessageSpendLimitOverrideRequest 
            {
                MonthlyLimit = 1000
            });

            long monthlyLimit = response.MonthlyLimit;

            #endregion
        }

        public void PinpointSMSVoiceV2UpdateNotifyConfiguration()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.UpdateNotifyConfiguration(new UpdateNotifyConfigurationRequest 
            {
                DeletionProtectionEnabled = true,
                EnabledChannels = new List<string> {
                    "SMS",
                    "VOICE"
                },
                EnabledCountries = new List<string> {
                    "US",
                    "CA",
                    "GB"
                },
                NotifyConfigurationId = "nc-1234567890abcdef0"
            });

            DateTime createdTimestamp = response.CreatedTimestamp;
            bool deletionProtectionEnabled = response.DeletionProtectionEnabled;
            string displayName = response.DisplayName;
            List<string> enabledChannels = response.EnabledChannels;
            List<string> enabledCountries = response.EnabledCountries;
            string notifyConfigurationArn = response.NotifyConfigurationArn;
            string notifyConfigurationId = response.NotifyConfigurationId;
            string status = response.Status;
            string tier = response.Tier;
            string tierUpgradeStatus = response.TierUpgradeStatus;
            string useCase = response.UseCase;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}