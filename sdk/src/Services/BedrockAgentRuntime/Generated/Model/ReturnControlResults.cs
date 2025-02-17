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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// An action invocation result.
    /// </summary>
    public partial class ReturnControlResults
    {
        private string _invocationId;
        private List<InvocationResultMember> _returnControlInvocationResults = AWSConfigs.InitializeCollections ? new List<InvocationResultMember>() : null;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The action's invocation ID.
        /// </para>
        /// </summary>
        public string InvocationId
        {
            get { return this._invocationId; }
            set { this._invocationId = value; }
        }

        // Check to see if InvocationId property is set
        internal bool IsSetInvocationId()
        {
            return this._invocationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnControlInvocationResults. 
        /// <para>
        /// The action invocation result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<InvocationResultMember> ReturnControlInvocationResults
        {
            get { return this._returnControlInvocationResults; }
            set { this._returnControlInvocationResults = value; }
        }

        // Check to see if ReturnControlInvocationResults property is set
        internal bool IsSetReturnControlInvocationResults()
        {
            return this._returnControlInvocationResults != null && (this._returnControlInvocationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}