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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOAuth2TokenWithIAM operation. Exchanges
    /// client credentials for an OAuth 2.0 access token scoped to a resource, which you can
    /// use to access AWS services from applications.
    /// </summary>
    public partial class CreateOAuth2TokenWithIAMRequest : AmazonSigninRequest
    {
        /// <summary>
        /// Gets and sets the property GrantType. The OAuth 2.0 grant type. Must be "client_credentials".
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property Resource. The OAuth resource for which the access token
        /// is requested. Example: "aws-mcp.amazonaws.com".
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
