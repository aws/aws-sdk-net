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

#pragma warning disable CS0612,CS0618,CS1570
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
        private InstanceType _instanceType;
        private int? _maxConcurrentSessions;
        private string _portalArn;

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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type and resources of the underlying instance.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentSessions. 
        /// <para>
        /// The maximum number of concurrent sessions for the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? MaxConcurrentSessions
        {
            get { return this._maxConcurrentSessions; }
            set { this._maxConcurrentSessions = value; }
        }

        // Check to see if MaxConcurrentSessions property is set
        internal bool IsSetMaxConcurrentSessions()
        {
            return this._maxConcurrentSessions.HasValue; 
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