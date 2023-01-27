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
    /// Container for the parameters to the UpdatePortal operation.
    /// Updates a web portal.
    /// </summary>
    public partial class UpdatePortalRequest : AmazonWorkSpacesWebRequest
    {
        private AuthenticationType _authenticationType;
        private string _displayName;
        private string _portalArn;

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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the web portal. This is not visible to users who log into the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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

    }
}