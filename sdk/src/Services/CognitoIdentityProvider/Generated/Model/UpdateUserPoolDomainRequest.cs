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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserPoolDomain operation.
    /// A user pool domain hosts managed login, an authorization server and web server for
    /// authentication in your application. This operation updates the branding version for
    /// user pool domains between <c>1</c> for hosted UI (classic) and <c>2</c> for managed
    /// login. It also updates the SSL certificate for user pool custom domains.
    /// 
    ///  
    /// <para>
    /// Changes to the domain branding version take up to one minute to take effect for a
    /// prefix domain and up to five minutes for a custom domain.
    /// </para>
    ///  
    /// <para>
    /// This operation doesn't change the name of your user pool domain. To change your domain,
    /// delete it with <c>DeleteUserPoolDomain</c> and create a new domain with <c>CreateUserPoolDomain</c>.
    /// </para>
    ///  
    /// <para>
    /// You can pass the ARN of a new Certificate Manager certificate in this request. Typically,
    /// ACM certificates automatically renew and you user pool can continue to use the same
    /// ARN. But if you generate a new certificate for your custom domain name, replace the
    /// original configuration with the new ARN in this request.
    /// </para>
    ///  
    /// <para>
    /// ACM certificates for custom domains must be in the US East (N. Virginia) Amazon Web
    /// Services Region. After you submit your request, Amazon Cognito requires up to 1 hour
    /// to distribute your new certificate to your custom domain.
    /// </para>
    ///  
    /// <para>
    /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Configuring
    /// a user pool domain</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
    {
        private CustomDomainConfigType _customDomainConfig;
        private string _domain;
        private int? _managedLoginVersion;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain that hosts managed login for your application.
        /// In an <c>UpdateUserPoolDomain</c> request, this parameter specifies an SSL certificate
        /// for the managed login hosted webserver. The certificate must be an ACM ARN in <c>us-east-1</c>.
        /// </para>
        ///  
        /// <para>
        /// When you create a custom domain, the passkey RP ID defaults to the custom domain.
        /// If you had a prefix domain active, this will cause passkey integration for your prefix
        /// domain to stop working due to a mismatch in RP ID. To keep the prefix domain passkey
        /// integration working, you can explicitly set RP ID to the prefix domain.
        /// </para>
        /// </summary>
        public CustomDomainConfigType CustomDomainConfig
        {
            get { return this._customDomainConfig; }
            set { this._customDomainConfig = value; }
        }

        // Check to see if CustomDomainConfig property is set
        internal bool IsSetCustomDomainConfig()
        {
            return this._customDomainConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that you want to update. For custom domains, this is the fully-qualified
        /// domain name, for example <c>auth.example.com</c>. For prefix domains, this is the
        /// prefix alone, such as <c>myprefix</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedLoginVersion. 
        /// <para>
        /// A version number that indicates the state of managed login for your domain. Version
        /// <c>1</c> is hosted UI (classic). Version <c>2</c> is the newer managed login with
        /// the branding editor. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">Managed
        /// login</a>.
        /// </para>
        /// </summary>
        public int? ManagedLoginVersion
        {
            get { return this._managedLoginVersion; }
            set { this._managedLoginVersion = value; }
        }

        // Check to see if ManagedLoginVersion property is set
        internal bool IsSetManagedLoginVersion()
        {
            return this._managedLoginVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that is associated with the domain you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}