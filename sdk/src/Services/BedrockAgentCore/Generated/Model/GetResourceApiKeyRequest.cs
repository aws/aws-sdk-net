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
    /// Container for the parameters to the GetResourceApiKey operation.
    /// Retrieves an API Key associated with an API Key Credential Provider
    /// </summary>
    public partial class GetResourceApiKeyRequest : AmazonBedrockAgentCoreRequest
    {
        private string _resourceCredentialProviderName;
        private string _workloadIdentityToken;

        /// <summary>
        /// Gets and sets the property ResourceCredentialProviderName. 
        /// <para>
        /// The credential provider name of the resource you are retrieving the API Key of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceCredentialProviderName
        {
            get { return this._resourceCredentialProviderName; }
            set { this._resourceCredentialProviderName = value; }
        }

        // Check to see if ResourceCredentialProviderName property is set
        internal bool IsSetResourceCredentialProviderName()
        {
            return this._resourceCredentialProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityToken. 
        /// <para>
        /// The identity token of the workload you want to get the API Key of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=131072)]
        public string WorkloadIdentityToken
        {
            get { return this._workloadIdentityToken; }
            set { this._workloadIdentityToken = value; }
        }

        // Check to see if WorkloadIdentityToken property is set
        internal bool IsSetWorkloadIdentityToken()
        {
            return this._workloadIdentityToken != null;
        }

    }
}