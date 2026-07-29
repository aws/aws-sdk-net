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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains summary information about a pipeline execution.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
        private DateTime? _endTime;
        private int? _executionPriority;
        private string _pipelineExecutionId;
        private string _pipelineVersion;
        private DateTime? _startTime;
        private PipelineExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the pipeline execution completed, in Unix epoch time.
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
        /// Gets and sets the property ExecutionPriority. 
        /// <para>
        /// Scheduling priority for the execution. When not specified, defaults to lowest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int? ExecutionPriority
        {
            get { return this._executionPriority; }
            set { this._executionPriority = value; }
        }

        // Check to see if ExecutionPriority property is set
        internal bool IsSetExecutionPriority()
        {
            return this._executionPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The unique identifier of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The pipeline version this execution ran against.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string PipelineVersion
        {
            get { return this._pipelineVersion; }
            set { this._pipelineVersion = value; }
        }

        // Check to see if PipelineVersion property is set
        internal bool IsSetPipelineVersion()
        {
            return this._pipelineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the pipeline execution started, in Unix epoch time.
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
        /// The current execution status of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PipelineExecutionStatus Status
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