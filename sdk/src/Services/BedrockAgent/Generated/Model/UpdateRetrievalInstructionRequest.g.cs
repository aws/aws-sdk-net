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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRetrievalInstruction operation. Updates
    /// the content of a retrieval instruction. The update is processed asynchronously; the
    /// stored content is a candidate until content review passes, and the served content
    /// does not change while the update is in flight. The service rejects the request with
    /// ConflictException while lastTransitionStatus is CREATING or UPDATING.
    /// </summary>
    public partial class UpdateRetrievalInstructionRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A replacement description; applied together with the content when the review passes.
        /// Omit to clear.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// The replacement instruction content. This is a full replacement of all four fields,
        /// not a patch. During UPDATING, Get continues to return the previously-served content
        /// until the update review passes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RetrievalInstructionContent Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the retrieval instruction to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;
    }
}
