/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SecurityGroupSettings Marshaller
    /// </summary>
    public class SecurityGroupSettingsMarshaller : IRequestMarshaller<SecurityGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SecurityGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlwaysReauthenticate())
            {
                context.Writer.WritePropertyName("alwaysReauthenticate");
                context.Writer.WriteBooleanValue(requestObject.AlwaysReauthenticate.Value);
            }

            if(requestObject.IsSetAtakPackageValues())
            {
                context.Writer.WritePropertyName("atakPackageValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAtakPackageValuesListValue in requestObject.AtakPackageValues)
                {
                        context.Writer.WriteStringValue(requestObjectAtakPackageValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCalling())
            {
                context.Writer.WritePropertyName("calling");
                context.Writer.WriteStartObject();

                var marshaller = CallingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Calling, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCheckForUpdates())
            {
                context.Writer.WritePropertyName("checkForUpdates");
                context.Writer.WriteBooleanValue(requestObject.CheckForUpdates.Value);
            }

            if(requestObject.IsSetEnableAtak())
            {
                context.Writer.WritePropertyName("enableAtak");
                context.Writer.WriteBooleanValue(requestObject.EnableAtak.Value);
            }

            if(requestObject.IsSetEnableCrashReports())
            {
                context.Writer.WritePropertyName("enableCrashReports");
                context.Writer.WriteBooleanValue(requestObject.EnableCrashReports.Value);
            }

            if(requestObject.IsSetEnableFileDownload())
            {
                context.Writer.WritePropertyName("enableFileDownload");
                context.Writer.WriteBooleanValue(requestObject.EnableFileDownload.Value);
            }

            if(requestObject.IsSetEnableGuestFederation())
            {
                context.Writer.WritePropertyName("enableGuestFederation");
                context.Writer.WriteBooleanValue(requestObject.EnableGuestFederation.Value);
            }

            if(requestObject.IsSetEnableNotificationPreview())
            {
                context.Writer.WritePropertyName("enableNotificationPreview");
                context.Writer.WriteBooleanValue(requestObject.EnableNotificationPreview.Value);
            }

            if(requestObject.IsSetEnableOpenAccessOption())
            {
                context.Writer.WritePropertyName("enableOpenAccessOption");
                context.Writer.WriteBooleanValue(requestObject.EnableOpenAccessOption.Value);
            }

            if(requestObject.IsSetEnableRestrictedGlobalFederation())
            {
                context.Writer.WritePropertyName("enableRestrictedGlobalFederation");
                context.Writer.WriteBooleanValue(requestObject.EnableRestrictedGlobalFederation.Value);
            }

            if(requestObject.IsSetFederationMode())
            {
                context.Writer.WritePropertyName("federationMode");
                context.Writer.WriteNumberValue(requestObject.FederationMode.Value);
            }

            if(requestObject.IsSetFilesEnabled())
            {
                context.Writer.WritePropertyName("filesEnabled");
                context.Writer.WriteBooleanValue(requestObject.FilesEnabled.Value);
            }

            if(requestObject.IsSetForceDeviceLockout())
            {
                context.Writer.WritePropertyName("forceDeviceLockout");
                context.Writer.WriteNumberValue(requestObject.ForceDeviceLockout.Value);
            }

            if(requestObject.IsSetForceOpenAccess())
            {
                context.Writer.WritePropertyName("forceOpenAccess");
                context.Writer.WriteBooleanValue(requestObject.ForceOpenAccess.Value);
            }

            if(requestObject.IsSetForceReadReceipts())
            {
                context.Writer.WritePropertyName("forceReadReceipts");
                context.Writer.WriteBooleanValue(requestObject.ForceReadReceipts.Value);
            }

            if(requestObject.IsSetGlobalFederation())
            {
                context.Writer.WritePropertyName("globalFederation");
                context.Writer.WriteBooleanValue(requestObject.GlobalFederation.Value);
            }

            if(requestObject.IsSetIsAtoEnabled())
            {
                context.Writer.WritePropertyName("isAtoEnabled");
                context.Writer.WriteBooleanValue(requestObject.IsAtoEnabled.Value);
            }

            if(requestObject.IsSetIsLinkPreviewEnabled())
            {
                context.Writer.WritePropertyName("isLinkPreviewEnabled");
                context.Writer.WriteBooleanValue(requestObject.IsLinkPreviewEnabled.Value);
            }

            if(requestObject.IsSetLocationAllowMaps())
            {
                context.Writer.WritePropertyName("locationAllowMaps");
                context.Writer.WriteBooleanValue(requestObject.LocationAllowMaps.Value);
            }

            if(requestObject.IsSetLocationEnabled())
            {
                context.Writer.WritePropertyName("locationEnabled");
                context.Writer.WriteBooleanValue(requestObject.LocationEnabled.Value);
            }

            if(requestObject.IsSetLockoutThreshold())
            {
                context.Writer.WritePropertyName("lockoutThreshold");
                context.Writer.WriteNumberValue(requestObject.LockoutThreshold.Value);
            }

            if(requestObject.IsSetMaxAutoDownloadSize())
            {
                context.Writer.WritePropertyName("maxAutoDownloadSize");
                context.Writer.WriteNumberValue(requestObject.MaxAutoDownloadSize.Value);
            }

            if(requestObject.IsSetMaxBor())
            {
                context.Writer.WritePropertyName("maxBor");
                context.Writer.WriteNumberValue(requestObject.MaxBor.Value);
            }

            if(requestObject.IsSetMaxTtl())
            {
                context.Writer.WritePropertyName("maxTtl");
                context.Writer.WriteNumberValue(requestObject.MaxTtl.Value);
            }

            if(requestObject.IsSetMessageForwardingEnabled())
            {
                context.Writer.WritePropertyName("messageForwardingEnabled");
                context.Writer.WriteBooleanValue(requestObject.MessageForwardingEnabled.Value);
            }

            if(requestObject.IsSetPasswordRequirements())
            {
                context.Writer.WritePropertyName("passwordRequirements");
                context.Writer.WriteStartObject();

                var marshaller = PasswordRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.PasswordRequirements, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPermittedNetworks())
            {
                context.Writer.WritePropertyName("permittedNetworks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPermittedNetworksListValue in requestObject.PermittedNetworks)
                {
                        context.Writer.WriteStringValue(requestObjectPermittedNetworksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPermittedWickrAwsNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrAwsNetworks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPermittedWickrAwsNetworksListValue in requestObject.PermittedWickrAwsNetworks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WickrAwsNetworksMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrAwsNetworksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPermittedWickrEnterpriseNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrEnterpriseNetworks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPermittedWickrEnterpriseNetworksListValue in requestObject.PermittedWickrEnterpriseNetworks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PermittedWickrEnterpriseNetworkMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrEnterpriseNetworksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPresenceEnabled())
            {
                context.Writer.WritePropertyName("presenceEnabled");
                context.Writer.WriteBooleanValue(requestObject.PresenceEnabled.Value);
            }

            if(requestObject.IsSetQuickResponses())
            {
                context.Writer.WritePropertyName("quickResponses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQuickResponsesListValue in requestObject.QuickResponses)
                {
                        context.Writer.WriteStringValue(requestObjectQuickResponsesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetShowMasterRecoveryKey())
            {
                context.Writer.WritePropertyName("showMasterRecoveryKey");
                context.Writer.WriteBooleanValue(requestObject.ShowMasterRecoveryKey.Value);
            }

            if(requestObject.IsSetShredder())
            {
                context.Writer.WritePropertyName("shredder");
                context.Writer.WriteStartObject();

                var marshaller = ShredderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Shredder, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSsoMaxIdleMinutes())
            {
                context.Writer.WritePropertyName("ssoMaxIdleMinutes");
                context.Writer.WriteNumberValue(requestObject.SsoMaxIdleMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SecurityGroupSettingsMarshaller Instance = new SecurityGroupSettingsMarshaller();

    }
}