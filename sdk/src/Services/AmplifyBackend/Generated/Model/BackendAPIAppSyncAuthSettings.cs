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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The authentication settings for accessing provisioned data models in your Amplify
    /// project.
    /// </summary>
    public partial class BackendAPIAppSyncAuthSettings
    {
        private string _cognitoUserPoolId;
        private string _description;
        private double? _expirationTime;
        private string _openIDAuthTTL;
        private string _openIDClientId;
        private string _openIDIatTTL;
        private string _openIDIssueURL;
        private string _openIDProviderName;

        /// <summary>
        /// Gets and sets the property CognitoUserPoolId. 
        /// <para>
        /// The Amazon Cognito user pool ID, if Amazon Cognito was used as an authentication setting
        /// to access your data models.
        /// </para>
        /// </summary>
        public string CognitoUserPoolId
        {
            get { return this._cognitoUserPoolId; }
            set { this._cognitoUserPoolId = value; }
        }

        // Check to see if CognitoUserPoolId property is set
        internal bool IsSetCognitoUserPoolId()
        {
            return this._cognitoUserPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The API key description for API_KEY, if it was used as an authentication mechanism
        /// to access your data models.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The API key expiration time for API_KEY, if it was used as an authentication mechanism
        /// to access your data models.
        /// </para>
        /// </summary>
        public double? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenIDAuthTTL. 
        /// <para>
        /// The expiry time for the OpenID authentication mechanism.
        /// </para>
        /// </summary>
        public string OpenIDAuthTTL
        {
            get { return this._openIDAuthTTL; }
            set { this._openIDAuthTTL = value; }
        }

        // Check to see if OpenIDAuthTTL property is set
        internal bool IsSetOpenIDAuthTTL()
        {
            return this._openIDAuthTTL != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDClientId. 
        /// <para>
        /// The clientID for openID, if openID was used as an authentication setting to access
        /// your data models.
        /// </para>
        /// </summary>
        public string OpenIDClientId
        {
            get { return this._openIDClientId; }
            set { this._openIDClientId = value; }
        }

        // Check to see if OpenIDClientId property is set
        internal bool IsSetOpenIDClientId()
        {
            return this._openIDClientId != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDIatTTL. 
        /// <para>
        /// The expiry time for the OpenID authentication mechanism.
        /// </para>
        /// </summary>
        public string OpenIDIatTTL
        {
            get { return this._openIDIatTTL; }
            set { this._openIDIatTTL = value; }
        }

        // Check to see if OpenIDIatTTL property is set
        internal bool IsSetOpenIDIatTTL()
        {
            return this._openIDIatTTL != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDIssueURL. 
        /// <para>
        /// The openID issuer URL, if openID was used as an authentication setting to access your
        /// data models.
        /// </para>
        /// </summary>
        public string OpenIDIssueURL
        {
            get { return this._openIDIssueURL; }
            set { this._openIDIssueURL = value; }
        }

        // Check to see if OpenIDIssueURL property is set
        internal bool IsSetOpenIDIssueURL()
        {
            return this._openIDIssueURL != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDProviderName. 
        /// <para>
        /// The OpenID provider name, if OpenID was used as an authentication mechanism to access
        /// your data models.
        /// </para>
        /// </summary>
        public string OpenIDProviderName
        {
            get { return this._openIDProviderName; }
            set { this._openIDProviderName = value; }
        }

        // Check to see if OpenIDProviderName property is set
        internal bool IsSetOpenIDProviderName()
        {
            return this._openIDProviderName != null;
        }

    }
}