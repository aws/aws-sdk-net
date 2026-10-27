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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The retrieval instruction, identified by its ID and optional version, to apply to
    /// this request.
    /// </summary>
    public partial class AgenticRetrieveInstructionConfiguration
    {
        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the retrieval instruction. The instruction must exist in the caller's
        /// account and its status must be ACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the retrieval instruction to apply: a version number, or DRAFT for
        /// the instruction's current reviewed content. When omitted, DRAFT is used. This default
        /// is permanent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
