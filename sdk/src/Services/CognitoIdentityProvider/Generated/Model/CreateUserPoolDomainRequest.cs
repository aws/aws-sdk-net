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
    /// Container for the parameters to the CreateUserPoolDomain operation.
    /// Creates a new domain for a user pool.
    /// </summary>
    public partial class CreateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
    {
        private CustomDomainConfigType _customDomainConfig;
        private string _domain;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain that hosts the sign-up and sign-in webpages
        /// for your application.
        /// </para>
        ///  
        /// <para>
        /// Provide this parameter only if you want to use own custom domain for your user pool.
        /// Otherwise, you can exclude this parameter and use the Amazon Cognito hosted domain
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// For more information about the hosted domain and custom domains, see <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-assign-domain.html">Configuring
        /// a User Pool Domain</a>.
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
        /// The domain string.
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
        /// The user pool ID.
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