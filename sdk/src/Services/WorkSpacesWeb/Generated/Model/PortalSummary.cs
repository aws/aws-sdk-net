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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The summary of the portal.
    /// </summary>
    public partial class PortalSummary
    {
        private AuthenticationType _authenticationType;
        private string _browserSettingsArn;
        private BrowserType _browserType;
        private DateTime? _creationDate;
        private string _displayName;
        private string _networkSettingsArn;
        private string _portalArn;
        private string _portalEndpoint;
        private PortalStatus _portalStatus;
        private RendererType _rendererType;
        private string _trustStoreArn;
        private string _userAccessLoggingSettingsArn;
        private string _userSettingsArn;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication integration points used when signing into the web portal.
        /// Defaults to <code>Standard</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Standard</code> web portals are authenticated directly through your identity
        /// provider. You need to call <code>CreateIdentityProvider</code> to integrate your identity
        /// provider with your web portal. User and group access to your web portal is controlled
        /// through your identity provider.
        /// </para>
        ///  
        /// <para>
        ///  <code>IAM_Identity_Center</code> web portals are authenticated through AWS IAM Identity
        /// Center (successor to AWS Single Sign-On). They provide additional features, such as
        /// IdP-initiated authentication. Identity sources (including external identity provider
        /// integration), plus user and group access to your web portal, can be configured in
        /// the IAM Identity Center.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserSettingsArn. 
        /// <para>
        /// The ARN of the browser settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string BrowserSettingsArn
        {
            get { return this._browserSettingsArn; }
            set { this._browserSettingsArn = value; }
        }

        // Check to see if BrowserSettingsArn property is set
        internal bool IsSetBrowserSettingsArn()
        {
            return this._browserSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserType. 
        /// <para>
        /// The browser type of the web portal.
        /// </para>
        /// </summary>
        public BrowserType BrowserType
        {
            get { return this._browserType; }
            set { this._browserType = value; }
        }

        // Check to see if BrowserType property is set
        internal bool IsSetBrowserType()
        {
            return this._browserType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the web portal.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSettingsArn. 
        /// <para>
        /// The ARN of the network settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string NetworkSettingsArn
        {
            get { return this._networkSettingsArn; }
            set { this._networkSettingsArn = value; }
        }

        // Check to see if NetworkSettingsArn property is set
        internal bool IsSetNetworkSettingsArn()
        {
            return this._networkSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalEndpoint. 
        /// <para>
        /// The endpoint URL of the web portal that users access in order to start streaming sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string PortalEndpoint
        {
            get { return this._portalEndpoint; }
            set { this._portalEndpoint = value; }
        }

        // Check to see if PortalEndpoint property is set
        internal bool IsSetPortalEndpoint()
        {
            return this._portalEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The status of the web portal.
        /// </para>
        /// </summary>
        public PortalStatus PortalStatus
        {
            get { return this._portalStatus; }
            set { this._portalStatus = value; }
        }

        // Check to see if PortalStatus property is set
        internal bool IsSetPortalStatus()
        {
            return this._portalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RendererType. 
        /// <para>
        /// The renderer that is used in streaming sessions.
        /// </para>
        /// </summary>
        public RendererType RendererType
        {
            get { return this._rendererType; }
            set { this._rendererType = value; }
        }

        // Check to see if RendererType property is set
        internal bool IsSetRendererType()
        {
            return this._rendererType != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust that is associated with this web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserAccessLoggingSettingsArn. 
        /// <para>
        /// The ARN of the user access logging settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string UserAccessLoggingSettingsArn
        {
            get { return this._userAccessLoggingSettingsArn; }
            set { this._userAccessLoggingSettingsArn = value; }
        }

        // Check to see if UserAccessLoggingSettingsArn property is set
        internal bool IsSetUserAccessLoggingSettingsArn()
        {
            return this._userAccessLoggingSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettingsArn. 
        /// <para>
        /// The ARN of the user settings that is associated with the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string UserSettingsArn
        {
            get { return this._userSettingsArn; }
            set { this._userSettingsArn = value; }
        }

        // Check to see if UserSettingsArn property is set
        internal bool IsSetUserSettingsArn()
        {
            return this._userSettingsArn != null;
        }

    }
}