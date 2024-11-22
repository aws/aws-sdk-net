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
    /// Updates the Secure Sockets Layer (SSL) certificate for the custom domain for your
    /// user pool.
    /// 
    ///  
    /// <para>
    /// You can use this operation to provide the Amazon Resource Name (ARN) of a new certificate
    /// to Amazon Cognito. You can't use it to change the domain for a user pool.
    /// </para>
    ///  
    /// <para>
    /// A custom domain is used to host the Amazon Cognito hosted UI, which provides sign-up
    /// and sign-in pages for your application. When you set up a custom domain, you provide
    /// a certificate that you manage with Certificate Manager (ACM). When necessary, you
    /// can use this operation to change the certificate that you applied to your custom domain.
    /// </para>
    ///  
    /// <para>
    /// Usually, this is unnecessary following routine certificate renewal with ACM. When
    /// you renew your existing certificate in ACM, the ARN for your certificate remains the
    /// same, and your custom domain uses the new certificate automatically.
    /// </para>
    ///  
    /// <para>
    /// However, if you replace your existing certificate with a new one, ACM gives the new
    /// certificate a new ARN. To apply the new certificate to your custom domain, you must
    /// provide this ARN to Amazon Cognito.
    /// </para>
    ///  
    /// <para>
    /// When you add your new certificate in ACM, you must choose US East (N. Virginia) as
    /// the Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    /// After you submit your request, Amazon Cognito requires up to 1 hour to distribute
    /// your new certificate to your custom domain.
    /// </para>
    ///  
    /// <para>
    /// For more information about adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
    /// Your Own Domain for the Hosted UI</a>.
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
        /// The configuration for a custom domain that hosts the sign-up and sign-in pages for
        /// your application. Use this object to specify an SSL certificate that is managed by
        /// ACM.
        /// </para>
        ///  
        /// <para>
        /// When you create a custom domain, the passkey RP ID defaults to the custom domain.
        /// If you had a prefix domain active, this will cause passkey integration for your prefix
        /// domain to stop working due to a mismatch in RP ID. To keep the prefix domain passkey
        /// integration working, you can explicitly set RP ID to the prefix domain. Update the
        /// RP ID in a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserPoolMfaConfig.html">SetUserPoolMfaConfig</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The domain name for the custom domain that hosts the sign-up and sign-in pages for
        /// your application. One example might be <c>auth.example.com</c>. 
        /// </para>
        ///  
        /// <para>
        /// This string can include only lowercase letters, numbers, and hyphens. Don't use a
        /// hyphen for the first or last character. Use periods to separate subdomain names.
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
        /// the branding designer. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">Managed
        /// login</a>.
        /// </para>
        /// </summary>
        public int ManagedLoginVersion
        {
            get { return this._managedLoginVersion.GetValueOrDefault(); }
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
        /// The ID of the user pool that is associated with the custom domain whose certificate
        /// you're updating.
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