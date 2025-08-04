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
    /// Container for the parameters to the DeleteMemoryRecord operation.
    /// Deletes a memory record from an AgentCore Memory resource. When you delete a memory
    /// record, it is permanently removed.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:DeleteMemoryRecord</c>
    /// permission.
    /// </para>
    /// </summary>
    public partial class DeleteMemoryRecordRequest : AmazonBedrockAgentCoreRequest
    {
        private string _memoryId;
        private string _memoryRecordId;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource from which to delete the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The identifier of the memory record to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MemoryRecordId
        {
            get { return this._memoryRecordId; }
            set { this._memoryRecordId = value; }
        }

        // Check to see if MemoryRecordId property is set
        internal bool IsSetMemoryRecordId()
        {
            return this._memoryRecordId != null;
        }

    }
}