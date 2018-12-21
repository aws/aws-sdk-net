/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// to Amazon Cognito. You cannot use it to change the domain for a user pool.
    /// </para>
    ///  
    /// <para>
    /// A custom domain is used to host the Amazon Cognito hosted UI, which provides sign-up
    /// and sign-in pages for your application. When you set up a custom domain, you provide
    /// a certificate that you manage with AWS Certificate Manager (ACM). When necessary,
    /// you can use this operation to change the certificate that you applied to your custom
    /// domain.
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
    /// the AWS Region.
    /// </para>
    ///  
    /// <para>
    /// After you submit your request, Amazon Cognito requires up to 1 hour to distribute
    /// your new certificate to your custom domain.
    /// </para>
    ///  
    /// <para>
    /// For more information about adding a custom domain to your user pool, see <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Using
    /// Your Own Domain for the Hosted UI</a>.
    /// </para>
    /// </summary>
    public partial class UpdateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
    {
        private CustomDomainConfigType _customDomainConfig;
        private string _domain;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain that hosts the sign-up and sign-in pages for
        /// your application. Use this object to specify an SSL certificate that is managed by
        /// ACM.
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
        /// The domain name for the custom domain that hosts the sign-up and sign-in pages for
        /// your application. For example: <code>auth.example.com</code>. 
        /// </para>
        ///  
        /// <para>
        /// This string can include only lowercase letters, numbers, and hyphens. Do not use a
        /// hyphen for the first or last character. Use periods to separate subdomain names.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that is associated with the custom domain that you are updating
        /// the certificate for.
        /// </para>
        /// </summary>
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