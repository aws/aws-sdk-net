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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Container for the parameters to the GetWorkloadAccessTokenForJWT operation.
    /// Obtains an Workload access token for agentic workloads acting on behalf of user with
    /// JWT token
    /// </summary>
    public partial class GetWorkloadAccessTokenForJWTRequest : AmazonBedrockAgentCoreRequest
    {
        private string _userToken;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property UserToken. 
        /// <para>
        /// OAuth2 token issued by the user's identity provider
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=131072)]
        public string UserToken
        {
            get { return this._userToken; }
            set { this._userToken = value; }
        }

        // Check to see if UserToken property is set
        internal bool IsSetUserToken()
        {
            return this._userToken != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// Unique identifier for the registered agent
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}