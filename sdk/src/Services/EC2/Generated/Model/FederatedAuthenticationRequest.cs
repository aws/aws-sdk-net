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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The IAM SAML identity provider used for federated authentication.
    /// </summary>
    public partial class FederatedAuthenticationRequest
    {
        private string _samlProviderArn;
        private string _selfServiceSAMLProviderArn;

        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM SAML identity provider.
        /// </para>
        /// </summary>
        public string SAMLProviderArn
        {
            get { return this._samlProviderArn; }
            set { this._samlProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this._samlProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property SelfServiceSAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM SAML identity provider for the self-service
        /// portal.
        /// </para>
        /// </summary>
        public string SelfServiceSAMLProviderArn
        {
            get { return this._selfServiceSAMLProviderArn; }
            set { this._selfServiceSAMLProviderArn = value; }
        }

        // Check to see if SelfServiceSAMLProviderArn property is set
        internal bool IsSetSelfServiceSAMLProviderArn()
        {
            return this._selfServiceSAMLProviderArn != null;
        }

    }
}