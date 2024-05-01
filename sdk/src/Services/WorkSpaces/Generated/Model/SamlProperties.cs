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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the enablement status, user access URL, and relay state parameter name that
    /// are used for configuring federation with an SAML 2.0 identity provider.
    /// </summary>
    public partial class SamlProperties
    {
        private string _relayStateParameterName;
        private SamlStatusEnum _status;
        private string _userAccessUrl;

        /// <summary>
        /// Gets and sets the property RelayStateParameterName. 
        /// <para>
        /// The relay state parameter name supported by the SAML 2.0 identity provider (IdP).
        /// When the end user is redirected to the user access URL from the WorkSpaces client
        /// application, this relay state parameter name is appended as a query parameter to the
        /// URL along with the relay state endpoint to return the user to the client application
        /// session.
        /// </para>
        ///  
        /// <para>
        /// To use SAML 2.0 authentication with WorkSpaces, the IdP must support IdP-initiated
        /// deep linking for the relay state URL. Consult your IdP documentation for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RelayStateParameterName
        {
            get { return this._relayStateParameterName; }
            set { this._relayStateParameterName = value; }
        }

        // Check to see if RelayStateParameterName property is set
        internal bool IsSetRelayStateParameterName()
        {
            return this._relayStateParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of SAML 2.0 authentication. These statuses include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the setting is <c>DISABLED</c>, end users will be directed to login with their
        /// directory credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the setting is <c>ENABLED</c>, end users will be directed to login via the user
        /// access URL. Users attempting to connect to WorkSpaces from a client application that
        /// does not support SAML 2.0 authentication will not be able to connect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the setting is <c>ENABLED_WITH_DIRECTORY_LOGIN_FALLBACK</c>, end users will be
        /// directed to login via the user access URL on supported client applications, but will
        /// not prevent clients that do not support SAML 2.0 authentication from connecting as
        /// if SAML 2.0 authentication was disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SamlStatusEnum Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserAccessUrl. 
        /// <para>
        /// The SAML 2.0 identity provider (IdP) user access URL is the URL a user would navigate
        /// to in their web browser in order to federate from the IdP and directly access the
        /// application, without any SAML 2.0 service provider (SP) bindings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=200)]
        public string UserAccessUrl
        {
            get { return this._userAccessUrl; }
            set { this._userAccessUrl = value; }
        }

        // Check to see if UserAccessUrl property is set
        internal bool IsSetUserAccessUrl()
        {
            return this._userAccessUrl != null;
        }

    }
}