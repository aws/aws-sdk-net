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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The authentication settings for accessing provisioned data models in your Amplify
    /// project.
    /// </summary>
    public partial class BackendAPIAppSyncAuthSettings
    {
        /// <summary>
        /// Gets and sets the property CognitoUserPoolId. 
        /// <para>
        /// The Amazon Cognito user pool ID, if Amazon Cognito was used as an authentication setting
        /// to access your data models.
        /// </para>
        /// </summary>
        public string CognitoUserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the CognitoUserPoolId property is set.
        /// </summary>
        internal bool IsSetCognitoUserPoolId() => this.CognitoUserPoolId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The API key description for API_KEY, if it was used as an authentication mechanism
        /// to access your data models.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The API key expiration time for API_KEY, if it was used as an authentication mechanism
        /// to access your data models.
        /// </para>
        /// </summary>
        public double? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property OpenIDAuthTTL. 
        /// <para>
        /// The expiry time for the OpenID authentication mechanism.
        /// </para>
        /// </summary>
        public string OpenIDAuthTTL { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDAuthTTL property is set.
        /// </summary>
        internal bool IsSetOpenIDAuthTTL() => this.OpenIDAuthTTL != null;

        /// <summary>
        /// Gets and sets the property OpenIDClientId. 
        /// <para>
        /// The clientID for openID, if openID was used as an authentication setting to access
        /// your data models.
        /// </para>
        /// </summary>
        public string OpenIDClientId { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDClientId property is set.
        /// </summary>
        internal bool IsSetOpenIDClientId() => this.OpenIDClientId != null;

        /// <summary>
        /// Gets and sets the property OpenIDIatTTL. 
        /// <para>
        /// The expiry time for the OpenID authentication mechanism.
        /// </para>
        /// </summary>
        public string OpenIDIatTTL { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDIatTTL property is set.
        /// </summary>
        internal bool IsSetOpenIDIatTTL() => this.OpenIDIatTTL != null;

        /// <summary>
        /// Gets and sets the property OpenIDIssueURL. 
        /// <para>
        /// The openID issuer URL, if openID was used as an authentication setting to access your
        /// data models.
        /// </para>
        /// </summary>
        public string OpenIDIssueURL { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDIssueURL property is set.
        /// </summary>
        internal bool IsSetOpenIDIssueURL() => this.OpenIDIssueURL != null;

        /// <summary>
        /// Gets and sets the property OpenIDProviderName. 
        /// <para>
        /// The OpenID provider name, if OpenID was used as an authentication mechanism to access
        /// your data models.
        /// </para>
        /// </summary>
        public string OpenIDProviderName { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDProviderName property is set.
        /// </summary>
        internal bool IsSetOpenIDProviderName() => this.OpenIDProviderName != null;
    }
}
