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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private string _batchRecordsEndTime;
        private string _batchRecordsStartTime;
        private DateTime? _createdAt;
        private string _executionMessage;
        private string _flowName;
        private DateTime? _lastUpdatedAt;
        private long? _recordsProcessed;
        private Status _status;

        /// <summary>
        /// Gets and sets the property BatchRecordsEndTime. 
        /// <para>
        /// End datetime of records pulled in batch during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BatchRecordsEndTime
        {
            get { return this._batchRecordsEndTime; }
            set { this._batchRecordsEndTime = value; }
        }

        // Check to see if BatchRecordsEndTime property is set
        internal bool IsSetBatchRecordsEndTime()
        {
            return this._batchRecordsEndTime != null;
        }

        /// <summary>
        /// Gets and sets the property BatchRecordsStartTime. 
        /// <para>
        /// Start datetime of records pulled in batch during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BatchRecordsStartTime
        {
            get { return this._batchRecordsStartTime; }
            set { this._batchRecordsStartTime = value; }
        }

        // Check to see if BatchRecordsStartTime property is set
        internal bool IsSetBatchRecordsStartTime()
        {
            return this._batchRecordsStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Creation timestamp of workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionMessage. 
        /// <para>
        /// Message indicating execution of workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ExecutionMessage
        {
            get { return this._executionMessage; }
            set { this._executionMessage = value; }
        }

        // Check to see if ExecutionMessage property is set
        internal bool IsSetExecutionMessage()
        {
            return this._executionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// Name of the flow created during execution of workflow step. <c>APPFLOW_INTEGRATION</c>
        /// workflow type creates an appflow flow during workflow step execution on the customers
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Last updated timestamp for workflow step for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        /// Total number of records processed during execution of workflow step for <c>APPFLOW_INTEGRATION</c>
        /// workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RecordsProcessed
        {
            get { return this._recordsProcessed; }
            set { this._recordsProcessed = value; }
        }

        // Check to see if RecordsProcessed property is set
        internal bool IsSetRecordsProcessed()
        {
            return this._recordsProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Workflow step status for <c>APPFLOW_INTEGRATION</c> workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}