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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing authorization data for an Amazon ECR registry.
    /// </summary>
    public partial class AuthorizationData
    {
        /// <summary>
        /// Gets and sets the property AuthorizationToken. 
        /// <para>
        /// A base64-encoded string that contains authorization data for the specified Amazon
        /// ECR registry. When the string is decoded, it is presented in the format <c>user:password</c>
        /// for private registry authentication using <c>docker login</c>.
        /// </para>
        /// </summary>
        public string AuthorizationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationToken property is set.
        /// </summary>
        internal bool IsSetAuthorizationToken() => this.AuthorizationToken != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The Unix time in seconds and milliseconds when the authorization token expires. Authorization
        /// tokens are valid for 12 hours.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property ProxyEndpoint. 
        /// <para>
        /// The registry URL to use for this authorization token in a <c>docker login</c> command.
        /// The Amazon ECR registry URL format is <c>https://aws_account_id.dkr.ecr.region.amazonaws.com</c>.
        /// For example, <c>https://012345678910.dkr.ecr.us-east-1.amazonaws.com</c>.. 
        /// </para>
        /// </summary>
        public string ProxyEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProxyEndpoint property is set.
        /// </summary>
        internal bool IsSetProxyEndpoint() => this.ProxyEndpoint != null;
    }
}
