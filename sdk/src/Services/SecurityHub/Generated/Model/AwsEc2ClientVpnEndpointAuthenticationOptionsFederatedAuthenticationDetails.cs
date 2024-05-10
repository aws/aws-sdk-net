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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Describes the IAM SAML identity providers used for federated authentication.
    /// </summary>
    public partial class AwsEc2ClientVpnEndpointAuthenticationOptionsFederatedAuthenticationDetails
    {
        private string _samlProviderArn;
        private string _selfServiceSamlProviderArn;

        /// <summary>
        /// Gets and sets the property SamlProviderArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM SAML identity provider. 
        /// </para>
        /// </summary>
        public string SamlProviderArn
        {
            get { return this._samlProviderArn; }
            set { this._samlProviderArn = value; }
        }

        // Check to see if SamlProviderArn property is set
        internal bool IsSetSamlProviderArn()
        {
            return this._samlProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property SelfServiceSamlProviderArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM SAML identity provider for the self-service
        /// portal. 
        /// </para>
        /// </summary>
        public string SelfServiceSamlProviderArn
        {
            get { return this._selfServiceSamlProviderArn; }
            set { this._selfServiceSamlProviderArn = value; }
        }

        // Check to see if SelfServiceSamlProviderArn property is set
        internal bool IsSetSelfServiceSamlProviderArn()
        {
            return this._selfServiceSamlProviderArn != null;
        }

    }
}