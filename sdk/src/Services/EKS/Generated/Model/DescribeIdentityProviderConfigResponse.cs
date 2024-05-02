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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the DescribeIdentityProviderConfig operation.
    /// </summary>
    public partial class DescribeIdentityProviderConfigResponse : AmazonWebServiceResponse
    {
        private IdentityProviderConfigResponse _identityProviderConfig;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfig. 
        /// <para>
        /// The object that represents an OpenID Connect (OIDC) identity provider configuration.
        /// </para>
        /// </summary>
        public IdentityProviderConfigResponse IdentityProviderConfig
        {
            get { return this._identityProviderConfig; }
            set { this._identityProviderConfig = value; }
        }

        // Check to see if IdentityProviderConfig property is set
        internal bool IsSetIdentityProviderConfig()
        {
            return this._identityProviderConfig != null;
        }

    }
}