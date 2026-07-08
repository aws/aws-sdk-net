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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOAuth2TokenWithIAM operation.
    /// Grants permission to exchange client credentials for an OAuth 2.0 access token scoped
    /// to a resource that can be used to access AWS services from applications
    /// </summary>
    public partial class CreateOAuth2TokenWithIAMRequest : AmazonSigninRequest
    {
        private string _grantType;
        private string _resource;

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// OAuth 2.0 grant type. Must be &quot;client_credentials&quot;.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GrantType
        {
            get { return this._grantType; }
            set { this._grantType = value; }
        }

        // Check to see if GrantType property is set
        internal bool IsSetGrantType()
        {
            return this._grantType != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The OAuth resource for which the access token is requested. Example: &quot;aws-mcp.amazonaws.com&quot;.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}