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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.AlwaysReauthenticate);
            }

            if(requestObject.IsSetAtakPackageValues())
            {
                context.Writer.WritePropertyName("atakPackageValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAtakPackageValuesListValue in requestObject.AtakPackageValues)
                {
                        context.Writer.Write(requestObjectAtakPackageValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCalling())
            {
                context.Writer.WritePropertyName("calling");
                context.Writer.WriteObjectStart();

                var marshaller = CallingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Calling, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCheckForUpdates())
            {
                context.Writer.WritePropertyName("checkForUpdates");
                context.Writer.Write(requestObject.CheckForUpdates);
            }

            if(requestObject.IsSetEnableAtak())
            {
                context.Writer.WritePropertyName("enableAtak");
                context.Writer.Write(requestObject.EnableAtak);
            }

            if(requestObject.IsSetEnableCrashReports())
            {
                context.Writer.WritePropertyName("enableCrashReports");
                context.Writer.Write(requestObject.EnableCrashReports);
            }

            if(requestObject.IsSetEnableFileDownload())
            {
                context.Writer.WritePropertyName("enableFileDownload");
                context.Writer.Write(requestObject.EnableFileDownload);
            }

            if(requestObject.IsSetEnableGuestFederation())
            {
                context.Writer.WritePropertyName("enableGuestFederation");
                context.Writer.Write(requestObject.EnableGuestFederation);
            }

            if(requestObject.IsSetEnableNotificationPreview())
            {
                context.Writer.WritePropertyName("enableNotificationPreview");
                context.Writer.Write(requestObject.EnableNotificationPreview);
            }

            if(requestObject.IsSetEnableOpenAccessOption())
            {
                context.Writer.WritePropertyName("enableOpenAccessOption");
                context.Writer.Write(requestObject.EnableOpenAccessOption);
            }

            if(requestObject.IsSetEnableRestrictedGlobalFederation())
            {
                context.Writer.WritePropertyName("enableRestrictedGlobalFederation");
                context.Writer.Write(requestObject.EnableRestrictedGlobalFederation);
            }

            if(requestObject.IsSetFederationMode())
            {
                context.Writer.WritePropertyName("federationMode");
                context.Writer.Write(requestObject.FederationMode);
            }

            if(requestObject.IsSetFilesEnabled())
            {
                context.Writer.WritePropertyName("filesEnabled");
                context.Writer.Write(requestObject.FilesEnabled);
            }

            if(requestObject.IsSetForceDeviceLockout())
            {
                context.Writer.WritePropertyName("forceDeviceLockout");
                context.Writer.Write(requestObject.ForceDeviceLockout);
            }

            if(requestObject.IsSetForceOpenAccess())
            {
                context.Writer.WritePropertyName("forceOpenAccess");
                context.Writer.Write(requestObject.ForceOpenAccess);
            }

            if(requestObject.IsSetForceReadReceipts())
            {
                context.Writer.WritePropertyName("forceReadReceipts");
                context.Writer.Write(requestObject.ForceReadReceipts);
            }

            if(requestObject.IsSetGlobalFederation())
            {
                context.Writer.WritePropertyName("globalFederation");
                context.Writer.Write(requestObject.GlobalFederation);
            }

            if(requestObject.IsSetIsAtoEnabled())
            {
                context.Writer.WritePropertyName("isAtoEnabled");
                context.Writer.Write(requestObject.IsAtoEnabled);
            }

            if(requestObject.IsSetIsLinkPreviewEnabled())
            {
                context.Writer.WritePropertyName("isLinkPreviewEnabled");
                context.Writer.Write(requestObject.IsLinkPreviewEnabled);
            }

            if(requestObject.IsSetLocationAllowMaps())
            {
                context.Writer.WritePropertyName("locationAllowMaps");
                context.Writer.Write(requestObject.LocationAllowMaps);
            }

            if(requestObject.IsSetLocationEnabled())
            {
                context.Writer.WritePropertyName("locationEnabled");
                context.Writer.Write(requestObject.LocationEnabled);
            }

            if(requestObject.IsSetLockoutThreshold())
            {
                context.Writer.WritePropertyName("lockoutThreshold");
                context.Writer.Write(requestObject.LockoutThreshold);
            }

            if(requestObject.IsSetMaxAutoDownloadSize())
            {
                context.Writer.WritePropertyName("maxAutoDownloadSize");
                context.Writer.Write(requestObject.MaxAutoDownloadSize);
            }

            if(requestObject.IsSetMaxBor())
            {
                context.Writer.WritePropertyName("maxBor");
                context.Writer.Write(requestObject.MaxBor);
            }

            if(requestObject.IsSetMaxTtl())
            {
                context.Writer.WritePropertyName("maxTtl");
                context.Writer.Write(requestObject.MaxTtl);
            }

            if(requestObject.IsSetMessageForwardingEnabled())
            {
                context.Writer.WritePropertyName("messageForwardingEnabled");
                context.Writer.Write(requestObject.MessageForwardingEnabled);
            }

            if(requestObject.IsSetPasswordRequirements())
            {
                context.Writer.WritePropertyName("passwordRequirements");
                context.Writer.WriteObjectStart();

                var marshaller = PasswordRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.PasswordRequirements, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPermittedNetworks())
            {
                context.Writer.WritePropertyName("permittedNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedNetworksListValue in requestObject.PermittedNetworks)
                {
                        context.Writer.Write(requestObjectPermittedNetworksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPermittedWickrAwsNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrAwsNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedWickrAwsNetworksListValue in requestObject.PermittedWickrAwsNetworks)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WickrAwsNetworksMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrAwsNetworksListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPermittedWickrEnterpriseNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrEnterpriseNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedWickrEnterpriseNetworksListValue in requestObject.PermittedWickrEnterpriseNetworks)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PermittedWickrEnterpriseNetworkMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrEnterpriseNetworksListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPresenceEnabled())
            {
                context.Writer.WritePropertyName("presenceEnabled");
                context.Writer.Write(requestObject.PresenceEnabled);
            }

            if(requestObject.IsSetQuickResponses())
            {
                context.Writer.WritePropertyName("quickResponses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectQuickResponsesListValue in requestObject.QuickResponses)
                {
                        context.Writer.Write(requestObjectQuickResponsesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetShowMasterRecoveryKey())
            {
                context.Writer.WritePropertyName("showMasterRecoveryKey");
                context.Writer.Write(requestObject.ShowMasterRecoveryKey);
            }

            if(requestObject.IsSetShredder())
            {
                context.Writer.WritePropertyName("shredder");
                context.Writer.WriteObjectStart();

                var marshaller = ShredderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Shredder, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSsoMaxIdleMinutes())
            {
                context.Writer.WritePropertyName("ssoMaxIdleMinutes");
                context.Writer.Write(requestObject.SsoMaxIdleMinutes);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SecurityGroupSettingsMarshaller Instance = new SecurityGroupSettingsMarshaller();

    }
}