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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The flow execution details.
    /// </summary>
    public partial class DataIntegrationFlowExecution
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The flow execution end timestamp.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The flow executionId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The flow execution's flowName.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The flow execution's instanceId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The failure message (if any) of failed flow execution.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OutputMetadata. 
        /// <para>
        /// The flow execution output metadata.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionOutputMetadata OutputMetadata { get; set; }

        /// <summary>
        /// Checks to see if the OutputMetadata property is set.
        /// </summary>
        internal bool IsSetOutputMetadata() => this.OutputMetadata != null;

        /// <summary>
        /// Gets and sets the property SourceInfo. 
        /// <para>
        /// The source information for a flow execution.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionSourceInfo SourceInfo { get; set; }

        /// <summary>
        /// Checks to see if the SourceInfo property is set.
        /// </summary>
        internal bool IsSetSourceInfo() => this.SourceInfo != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The flow execution start timestamp.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of flow execution.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
