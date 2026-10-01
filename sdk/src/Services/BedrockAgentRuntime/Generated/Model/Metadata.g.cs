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
    /// Provides information about the execution process for different types of invocations,
    /// such as model invocation, knowledge base invocation, agent collaborator invocation,
    /// guardrail invocation, and code interpreter Invocation.
    /// </summary>
    public partial class Metadata
    {
        /// <summary>
        /// Gets and sets the property ClientRequestId. 
        /// <para>
        /// A unique identifier associated with the downstream invocation. This ID can be used
        /// for tracing, debugging, and identifying specific invocations in customer logs or systems.
        /// </para>
        /// </summary>
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestId property is set.
        /// </summary>
        internal bool IsSetClientRequestId() => this.ClientRequestId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// In the final response, <c>endTime</c> is the end time of the agent invocation operation.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property OperationTotalTimeMs. 
        /// <para>
        /// The total time it took for the agent to complete execution. This field is only set
        /// for the final response.
        /// </para>
        /// </summary>
        public long? OperationTotalTimeMs { get; set; }

        /// <summary>
        /// Checks to see if the OperationTotalTimeMs property is set.
        /// </summary>
        internal bool IsSetOperationTotalTimeMs() => this.OperationTotalTimeMs.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// In the final response, <c>startTime</c> is the start time of the agent invocation
        /// operation.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TotalTimeMs. 
        /// <para>
        ///  The total execution time for the specific invocation being processed (model, knowledge
        /// base, guardrail, agent collaborator, or code interpreter). It represents how long
        /// the individual invocation took.
        /// </para>
        /// </summary>
        public long? TotalTimeMs { get; set; }

        /// <summary>
        /// Checks to see if the TotalTimeMs property is set.
        /// </summary>
        internal bool IsSetTotalTimeMs() => this.TotalTimeMs.HasValue;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Specific to model invocation and contains details about the usage of a foundation
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Usage Usage { get; set; }

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null;
    }
}
