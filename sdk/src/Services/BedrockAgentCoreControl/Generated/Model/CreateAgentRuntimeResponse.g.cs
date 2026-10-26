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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the CreateAgentRuntime operation.
    /// </summary>
    public partial class CreateAgentRuntimeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArn() => this.AgentRuntimeArn != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeId property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeId() => this.AgentRuntimeId != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string AgentRuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeVersion property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeVersion() => this.AgentRuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentRuntimeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityDetails property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityDetails() => this.WorkloadIdentityDetails != null;
    }
}
