using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IAMRolesAnywhere;
using Amazon.IAMRolesAnywhere.Model;

namespace AWSSDKDocSamples.Amazon.IAMRolesAnywhere.Generated
{
    class IAMRolesAnywhereSamples : ISample
    {
        public void IAMRolesAnywhereDeleteAttributeMapping()
        {
            #region example-1

            var client = new AmazonIAMRolesAnywhereClient();
            var response = client.DeleteAttributeMapping(new DeleteAttributeMappingRequest 
            {
                CertificateField = "x509Subject",
                ProfileId = "00000000-0000-0000-0000-000000000000",
                Specifiers = new List<string> {
                    "OU"
                }
            });

            ProfileDetail profile = response.Profile;

            #endregion
        }

        public void IAMRolesAnywherePutAttributeMapping()
        {
            #region example-1

            var client = new AmazonIAMRolesAnywhereClient();
            var response = client.PutAttributeMapping(new PutAttributeMappingRequest 
            {
                CertificateField = "x509Subject",
                MappingRules = new List<MappingRule> {
                    new MappingRule { Specifier = "CN" }
                },
                ProfileId = "00000000-0000-0000-0000-000000000000"
            });

            ProfileDetail profile = response.Profile;

            #endregion
        }

        public void IAMRolesAnywherePutNotificationSettings()
        {
            #region example-1

            var client = new AmazonIAMRolesAnywhereClient();
            var response = client.PutNotificationSettings(new PutNotificationSettingsRequest 
            {
                NotificationSettings = new List<NotificationSetting> {
                    new NotificationSetting {
                        Enabled = true,
                        Event = "END_ENTITY_CERTIFICATE_EXPIRY",
                        Threshold = 10
                    }
                },
                TrustAnchorId = "c2505e61-2fc1-4a18-9fcf-94e18a22928b"
            });

            TrustAnchorDetail trustAnchor = response.TrustAnchor;

            #endregion
        }

        public void IAMRolesAnywhereResetNotificationSettings()
        {
            #region example-1

            var client = new AmazonIAMRolesAnywhereClient();
            var response = client.ResetNotificationSettings(new ResetNotificationSettingsRequest 
            {
                NotificationSettingKeys = new List<NotificationSettingKey> {
                    new NotificationSettingKey { Event = "END_ENTITY_CERTIFICATE_EXPIRY" }
                },
                TrustAnchorId = "c2505e61-2fc1-4a18-9fcf-94e18a22928b"
            });

            TrustAnchorDetail trustAnchor = response.TrustAnchor;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}