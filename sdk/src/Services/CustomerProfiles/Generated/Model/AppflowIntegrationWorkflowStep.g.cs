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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Workflow step details for <c>APPFLOW_INTEGRATION</c> workflow.
    /// </summary>
    public partial class AppflowIntegrationWorkflowStep
    {
        /// <summary>
        /// Gets and sets the property BatchRecordsEndTime. 
        /// <para>
        /// End datetime of records pulled in batch during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BatchRecordsEndTime { get; set; }

        /// <summary>
        /// Checks to see if the BatchRecordsEndTime property is set.
        /// </summary>
        internal bool IsSetBatchRecordsEndTime() => this.BatchRecordsEndTime != null;

        /// <summary>
        /// Gets and sets the property BatchRecordsStartTime. 
        /// <para>
        /// Start datetime of records pulled in batch during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BatchRecordsStartTime { get; set; }

        /// <summary>
        /// Checks to see if the BatchRecordsStartTime property is set.
        /// </summary>
        internal bool IsSetBatchRecordsStartTime() => this.BatchRecordsStartTime != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Creation timestamp of workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionMessage. 
        /// <para>
        /// Message indicating execution of workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ExecutionMessage { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMessage property is set.
        /// </summary>
        internal bool IsSetExecutionMessage() => this.ExecutionMessage != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// Name of the flow created during execution of workflow step. <c>APPFLOW_INTEGRATION</c>
        /// workflow type creates an appflow flow during workflow step execution on the customers
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Last updated timestamp for workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        /// Total number of records processed during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? RecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the RecordsProcessed property is set.
        /// </summary>
        internal bool IsSetRecordsProcessed() => this.RecordsProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Workflow step status for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
