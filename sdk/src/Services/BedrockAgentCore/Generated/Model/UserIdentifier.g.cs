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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The OAuth2.0 token or user ID that was used to generate the workload access token
    /// used for initiating the user authorization flow to retrieve OAuth2.0 tokens.
    /// </summary>
    public partial class UserIdentifier
    {
        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user for whom you have retrieved a workload access token for
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserToken. 
        /// <para>
        /// The OAuth2.0 token issued by the user’s identity provider that was used to generate
        /// the workload access token
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 131072)]
        public string UserToken { get; set; }

        /// <summary>
        /// Checks to see if the UserToken property is set.
        /// </summary>
        internal bool IsSetUserToken() => this.UserToken != null;
    }
}
