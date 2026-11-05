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
    /// This is the response object from the UpdateAgentRuntimeEndpoint operation.
    /// </summary>
    public partial class UpdateAgentRuntimeEndpointResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property AgentRuntimeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AgentCore Runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeEndpointArn() => this.AgentRuntimeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime endpoint was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LiveVersion. 
        /// <para>
        /// The currently deployed version of the AgentCore Runtime on the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string LiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the LiveVersion property is set.
        /// </summary>
        internal bool IsSetLiveVersion() => this.LiveVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated AgentCore Runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentRuntimeEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The target version of the AgentCore Runtime for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;
    }
}
