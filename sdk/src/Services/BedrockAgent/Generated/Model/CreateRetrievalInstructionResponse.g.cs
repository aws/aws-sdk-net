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
    /// This is the response object from the CreateRetrievalInstruction operation.
    /// </summary>
    public partial class CreateRetrievalInstructionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When you created the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastTransitionStatus. 
        /// <para>
        /// Always CREATING on this response. Poll GetRetrievalInstruction until this member is
        /// neither CREATING nor UPDATING, then read the outcome from it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalInstructionLastTransitionStatus LastTransitionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastTransitionStatus property is set.
        /// </summary>
        internal bool IsSetLastTransitionStatus() => this.LastTransitionStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionArn. 
        /// <para>
        /// The ARN of the newly created retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RetrievalInstructionArn { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionArn property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionArn() => this.RetrievalInstructionArn != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the newly created retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Always INACTIVE on this response. The content review has not run when this call returns,
        /// so the resource is not yet usable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalInstructionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// When the retrieval instruction was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
