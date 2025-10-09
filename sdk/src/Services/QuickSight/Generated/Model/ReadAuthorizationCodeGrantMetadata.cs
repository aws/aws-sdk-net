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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Read-only metadata for OAuth2 authorization code grant authentication configuration.
    /// </summary>
    public partial class ReadAuthorizationCodeGrantMetadata
    {
        private AuthorizationCodeGrantCredentialsSource _authorizationCodeGrantCredentialsSource;
        private string _baseEndpoint;
        private ReadAuthorizationCodeGrantCredentialsDetails _readAuthorizationCodeGrantCredentialsDetails;
        private string _redirectUrl;

        /// <summary>
        /// Gets and sets the property AuthorizationCodeGrantCredentialsSource. 
        /// <para>
        /// The source of credentials for the authorization code grant flow.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrantCredentialsSource AuthorizationCodeGrantCredentialsSource
        {
            get { return this._authorizationCodeGrantCredentialsSource; }
            set { this._authorizationCodeGrantCredentialsSource = value; }
        }

        // Check to see if AuthorizationCodeGrantCredentialsSource property is set
        internal bool IsSetAuthorizationCodeGrantCredentialsSource()
        {
            return this._authorizationCodeGrantCredentialsSource != null;
        }

        /// <summary>
        /// Gets and sets the property BaseEndpoint. 
        /// <para>
        /// The base endpoint URL for the OAuth2 authorization code grant flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string BaseEndpoint
        {
            get { return this._baseEndpoint; }
            set { this._baseEndpoint = value; }
        }

        // Check to see if BaseEndpoint property is set
        internal bool IsSetBaseEndpoint()
        {
            return this._baseEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReadAuthorizationCodeGrantCredentialsDetails. 
        /// <para>
        /// The read-only credentials details for the authorization code grant flow.
        /// </para>
        /// </summary>
        public ReadAuthorizationCodeGrantCredentialsDetails ReadAuthorizationCodeGrantCredentialsDetails
        {
            get { return this._readAuthorizationCodeGrantCredentialsDetails; }
            set { this._readAuthorizationCodeGrantCredentialsDetails = value; }
        }

        // Check to see if ReadAuthorizationCodeGrantCredentialsDetails property is set
        internal bool IsSetReadAuthorizationCodeGrantCredentialsDetails()
        {
            return this._readAuthorizationCodeGrantCredentialsDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The redirect URL where the authorization server will send the user after authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string RedirectUrl
        {
            get { return this._redirectUrl; }
            set { this._redirectUrl = value; }
        }

        // Check to see if RedirectUrl property is set
        internal bool IsSetRedirectUrl()
        {
            return this._redirectUrl != null;
        }

    }
}