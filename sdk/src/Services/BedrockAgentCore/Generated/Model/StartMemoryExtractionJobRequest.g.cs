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
    /// Container for the parameters to the StartMemoryExtractionJob operation. Starts a memory
    /// extraction job that processes events that failed extraction previously in an AgentCore
    /// Memory resource and produces structured memory records. When earlier extraction attempts
    /// have left events unprocessed, this job will pick up and extract those as well. <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:StartMemoryExtractionJob</c>
    /// permission. </para>
    /// </summary>
    public partial class StartMemoryExtractionJobRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotent processing of the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExtractionJob. 
        /// <para>
        /// Extraction job to start in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractionJob ExtractionJob { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionJob property is set.
        /// </summary>
        internal bool IsSetExtractionJob() => this.ExtractionJob != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the memory for which to start extraction jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;
    }
}
