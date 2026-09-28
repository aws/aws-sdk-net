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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The summary of the portal.
    /// </summary>
    public partial class PortalSummary
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication integration points used when signing into the web portal.
        /// Defaults to <c>Standard</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Standard</c> web portals are authenticated directly through your identity provider.
        /// You need to call <c>CreateIdentityProvider</c> to integrate your identity provider
        /// with your web portal. User and group access to your web portal is controlled through
        /// your identity provider.
        /// </para>
        ///  
        /// <para>
        ///  <c>IAM Identity Center</c> web portals are authenticated through IAM Identity Center.
        /// Identity sources (including external identity provider integration), plus user and
        /// group access to your web portal, can be configured in the IAM Identity Center.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property BrowserSettingsArn. 
        /// <para>
        /// The ARN of the browser settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string BrowserSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the BrowserSettingsArn property is set.
        /// </summary>
        internal bool IsSetBrowserSettingsArn() => this.BrowserSettingsArn != null;

        /// <summary>
        /// Gets and sets the property BrowserType. 
        /// <para>
        /// The browser type of the web portal.
        /// </para>
        /// </summary>
        public BrowserType BrowserType { get; set; }

        /// <summary>
        /// Checks to see if the BrowserType property is set.
        /// </summary>
        internal bool IsSetBrowserType() => this.BrowserType != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the web portal.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DataProtectionSettingsArn. 
        /// <para>
        /// The ARN of the data protection settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataProtectionSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the DataProtectionSettingsArn property is set.
        /// </summary>
        internal bool IsSetDataProtectionSettingsArn() => this.DataProtectionSettingsArn != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type and resources of the underlying instance.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property IpAccessSettingsArn. 
        /// <para>
        /// The ARN of the IP access settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IpAccessSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the IpAccessSettingsArn property is set.
        /// </summary>
        internal bool IsSetIpAccessSettingsArn() => this.IpAccessSettingsArn != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrentSessions. 
        /// <para>
        /// The maximum number of concurrent sessions for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public int? MaxConcurrentSessions { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrentSessions property is set.
        /// </summary>
        internal bool IsSetMaxConcurrentSessions() => this.MaxConcurrentSessions.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkSettingsArn. 
        /// <para>
        /// The ARN of the network settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string NetworkSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSettingsArn property is set.
        /// </summary>
        internal bool IsSetNetworkSettingsArn() => this.NetworkSettingsArn != null;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;

        /// <summary>
        /// Gets and sets the property PortalCustomDomain. 
        /// <para>
        /// The custom domain of the web portal that users access in order to start streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string PortalCustomDomain { get; set; }

        /// <summary>
        /// Checks to see if the PortalCustomDomain property is set.
        /// </summary>
        internal bool IsSetPortalCustomDomain() => this.PortalCustomDomain != null;

        /// <summary>
        /// Gets and sets the property PortalEndpoint. 
        /// <para>
        /// The endpoint URL of the web portal that users access in order to start streaming sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string PortalEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PortalEndpoint property is set.
        /// </summary>
        internal bool IsSetPortalEndpoint() => this.PortalEndpoint != null;

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The status of the web portal.
        /// </para>
        /// </summary>
        public PortalStatus PortalStatus { get; set; }

        /// <summary>
        /// Checks to see if the PortalStatus property is set.
        /// </summary>
        internal bool IsSetPortalStatus() => this.PortalStatus != null;

        /// <summary>
        /// Gets and sets the property RendererType. 
        /// <para>
        /// The renderer that is used in streaming sessions.
        /// </para>
        /// </summary>
        public RendererType RendererType { get; set; }

        /// <summary>
        /// Checks to see if the RendererType property is set.
        /// </summary>
        internal bool IsSetRendererType() => this.RendererType != null;

        /// <summary>
        /// Gets and sets the property SessionLoggerArn. 
        /// <para>
        /// The ARN of the session logger that is assocaited with the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SessionLoggerArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionLoggerArn property is set.
        /// </summary>
        internal bool IsSetSessionLoggerArn() => this.SessionLoggerArn != null;

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust that is associated with this web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TrustStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreArn property is set.
        /// </summary>
        internal bool IsSetTrustStoreArn() => this.TrustStoreArn != null;

        /// <summary>
        /// Gets and sets the property UserAccessLoggingSettingsArn. 
        /// <para>
        /// The ARN of the user access logging settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string UserAccessLoggingSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the UserAccessLoggingSettingsArn property is set.
        /// </summary>
        internal bool IsSetUserAccessLoggingSettingsArn() => this.UserAccessLoggingSettingsArn != null;

        /// <summary>
        /// Gets and sets the property UserSettingsArn. 
        /// <para>
        /// The ARN of the user settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string UserSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the UserSettingsArn property is set.
        /// </summary>
        internal bool IsSetUserSettingsArn() => this.UserSettingsArn != null;
    }
}
