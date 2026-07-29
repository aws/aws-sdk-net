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
    /// Contains detailed execution information for a compute node within a pipeline execution.
    /// </summary>
    public partial class ComputeNodeExecutionDetails
    {
        private string _computeNodeName;
        private List<string> _dependsOn = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endTime;
        private Dictionary<string, string> _executionEnvironmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _startTime;
        private ComputeNodeExecutionStatus _status;
        private string _taskArn;
        private string _taskName;
        private string _taskVersion;

        /// <summary>
        /// Gets and sets the property ComputeNodeName. 
        /// <para>
        /// The name of the compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ComputeNodeName
        {
            get { return this._computeNodeName; }
            set { this._computeNodeName = value; }
        }

        // Check to see if ComputeNodeName property is set
        internal bool IsSetComputeNodeName()
        {
            return this._computeNodeName != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of compute node names that this node depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && (this._dependsOn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the compute node execution completed, in Unix epoch time.
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
        /// Gets and sets the property ExecutionEnvironmentVariables. 
        /// <para>
        /// The fully resolved environment variables used for this compute node execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public Dictionary<string, string> ExecutionEnvironmentVariables
        {
            get { return this._executionEnvironmentVariables; }
            set { this._executionEnvironmentVariables = value; }
        }

        // Check to see if ExecutionEnvironmentVariables property is set
        internal bool IsSetExecutionEnvironmentVariables()
        {
            return this._executionEnvironmentVariables != null && (this._executionEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the compute node execution started, in Unix epoch time.
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
        /// The current execution status of the compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeNodeExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the task executed for this compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskVersion. 
        /// <para>
        /// The task version that executed for this compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string TaskVersion
        {
            get { return this._taskVersion; }
            set { this._taskVersion = value; }
        }

        // Check to see if TaskVersion property is set
        internal bool IsSetTaskVersion()
        {
            return this._taskVersion != null;
        }

    }
}