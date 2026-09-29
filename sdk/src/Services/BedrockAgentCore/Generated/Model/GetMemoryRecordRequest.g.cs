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
    /// Container for the parameters to the GetMemoryRecord operation. Retrieves a specific
    /// memory record from an AgentCore Memory resource. <para> To use this operation, you
    /// must have the <c>bedrock-agentcore:GetMemoryRecord</c> permission. </para>
    /// </summary>
    public partial class GetMemoryRecordRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource containing the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The identifier of the memory record to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 50)]
        public string MemoryRecordId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryRecordId property is set.
        /// </summary>
        internal bool IsSetMemoryRecordId() => this.MemoryRecordId != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the memory record to retrieve. This value is used for IAM condition
        /// key authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;
    }
}
