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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
        private DateTime? _endTime;
        private string _executionId;
        private string _flowName;
        private string _instanceId;
        private string _message;
        private DataIntegrationFlowExecutionOutputMetadata _outputMetadata;
        private DataIntegrationFlowExecutionSourceInfo _sourceInfo;
        private DateTime? _startTime;
        private DataIntegrationFlowExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The flow execution end timestamp.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The flow executionId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The flow execution's flowName.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The flow execution's instanceId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The failure message (if any) of failed flow execution.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property OutputMetadata. 
        /// <para>
        /// The flow execution output metadata.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionOutputMetadata OutputMetadata
        {
            get { return this._outputMetadata; }
            set { this._outputMetadata = value; }
        }

        // Check to see if OutputMetadata property is set
        internal bool IsSetOutputMetadata()
        {
            return this._outputMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SourceInfo. 
        /// <para>
        /// The source information for a flow execution.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionSourceInfo SourceInfo
        {
            get { return this._sourceInfo; }
            set { this._sourceInfo = value; }
        }

        // Check to see if SourceInfo property is set
        internal bool IsSetSourceInfo()
        {
            return this._sourceInfo != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The flow execution start timestamp.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of flow execution.
        /// </para>
        /// </summary>
        public DataIntegrationFlowExecutionStatus Status
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