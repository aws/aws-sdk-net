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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the RegisterOidcConfig operation.
    /// </summary>
    public partial class RegisterOidcConfigResponse : AmazonWebServiceResponse
    {
        private int? _applicationId;
        private string _applicationName;
        private string _caCertificate;
        private string _clientId;
        private string _clientSecret;
        private string _companyId;
        private string _customUsername;
        private string _extraAuthParams;
        private string _issuer;
        private string _redirectUrl;
        private string _scopes;
        private string _secret;
        private int? _ssoTokenBufferMinutes;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the registered OIDC application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int ApplicationId
        {
            get { return this._applicationId.GetValueOrDefault(); }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the registered OIDC application.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CaCertificate. 
        /// <para>
        /// The CA certificate used for secure communication with the OIDC provider.
        /// </para>
        /// </summary>
        public string CaCertificate
        {
            get { return this._caCertificate; }
            set { this._caCertificate = value; }
        }

        // Check to see if CaCertificate property is set
        internal bool IsSetCaCertificate()
        {
            return this._caCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth client ID assigned to the application.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth client secret for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property CompanyId. 
        /// <para>
        /// Custom identifier your end users will use to sign in with SSO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CompanyId
        {
            get { return this._companyId; }
            set { this._companyId = value; }
        }

        // Check to see if CompanyId property is set
        internal bool IsSetCompanyId()
        {
            return this._companyId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomUsername. 
        /// <para>
        /// The custom field mapping used for extracting the username.
        /// </para>
        /// </summary>
        public string CustomUsername
        {
            get { return this._customUsername; }
            set { this._customUsername = value; }
        }

        // Check to see if CustomUsername property is set
        internal bool IsSetCustomUsername()
        {
            return this._customUsername != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraAuthParams. 
        /// <para>
        /// The additional authentication parameters configured for the OIDC flow.
        /// </para>
        /// </summary>
        public string ExtraAuthParams
        {
            get { return this._extraAuthParams; }
            set { this._extraAuthParams = value; }
        }

        // Check to see if ExtraAuthParams property is set
        internal bool IsSetExtraAuthParams()
        {
            return this._extraAuthParams != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL of the OIDC provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The redirect URL configured for the OAuth flow.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes configured for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null;
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// The client secret for authenticating with the OIDC provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

        /// <summary>
        /// Gets and sets the property SsoTokenBufferMinutes. 
        /// <para>
        /// The buffer time in minutes before the SSO token expires.
        /// </para>
        /// </summary>
        public int SsoTokenBufferMinutes
        {
            get { return this._ssoTokenBufferMinutes.GetValueOrDefault(); }
            set { this._ssoTokenBufferMinutes = value; }
        }

        // Check to see if SsoTokenBufferMinutes property is set
        internal bool IsSetSsoTokenBufferMinutes()
        {
            return this._ssoTokenBufferMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The claim field being used as the user identifier.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}