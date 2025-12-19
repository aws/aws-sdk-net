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
using System.Net;
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
    /// Response Unmarshaller for SecurityGroupSettings Object
    /// </summary>  
    public class SecurityGroupSettingsUnmarshaller : IUnmarshaller<SecurityGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<SecurityGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SecurityGroupSettings IUnmarshaller<SecurityGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SecurityGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            SecurityGroupSettings unmarshalledObject = new SecurityGroupSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alwaysReauthenticate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AlwaysReauthenticate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("atakPackageValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AtakPackageValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("calling", targetDepth))
                {
                    var unmarshaller = CallingSettingsUnmarshaller.Instance;
                    unmarshalledObject.Calling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("checkForUpdates", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CheckForUpdates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableAtak", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableAtak = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableCrashReports", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableCrashReports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableFileDownload", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableFileDownload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableGuestFederation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableGuestFederation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableNotificationPreview", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableNotificationPreview = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableOpenAccessOption", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableOpenAccessOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enableRestrictedGlobalFederation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableRestrictedGlobalFederation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("federationMode", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FederationMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filesEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FilesEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceDeviceLockout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ForceDeviceLockout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceOpenAccess", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceOpenAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceReadReceipts", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceReadReceipts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("globalFederation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.GlobalFederation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isAtoEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsAtoEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isLinkPreviewEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsLinkPreviewEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("locationAllowMaps", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.LocationAllowMaps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("locationEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.LocationEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lockoutThreshold", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LockoutThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxAutoDownloadSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxAutoDownloadSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxBor", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxBor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxTtl", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxTtl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageForwardingEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MessageForwardingEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("passwordRequirements", targetDepth))
                {
                    var unmarshaller = PasswordRequirementsUnmarshaller.Instance;
                    unmarshalledObject.PasswordRequirements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("permittedNetworks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PermittedNetworks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("permittedWickrAwsNetworks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WickrAwsNetworks, WickrAwsNetworksUnmarshaller>(WickrAwsNetworksUnmarshaller.Instance);
                    unmarshalledObject.PermittedWickrAwsNetworks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("permittedWickrEnterpriseNetworks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PermittedWickrEnterpriseNetwork, PermittedWickrEnterpriseNetworkUnmarshaller>(PermittedWickrEnterpriseNetworkUnmarshaller.Instance);
                    unmarshalledObject.PermittedWickrEnterpriseNetworks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("presenceEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PresenceEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("quickResponses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.QuickResponses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("showMasterRecoveryKey", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ShowMasterRecoveryKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shredder", targetDepth))
                {
                    var unmarshaller = ShredderSettingsUnmarshaller.Instance;
                    unmarshalledObject.Shredder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ssoMaxIdleMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SsoMaxIdleMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SecurityGroupSettingsUnmarshaller _instance = new SecurityGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SecurityGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}