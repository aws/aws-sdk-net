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
    /// Contains the execution summary of the computation model.
    /// </summary>
    public partial class ExecutionSummary
    {
        private string _actionType;
        private DateTime? _executionEndTime;
        private string _executionEntityVersion;
        private string _executionId;
        private DateTime? _executionStartTime;
        private ExecutionStatus _executionStatus;
        private ResolveTo _resolveTo;
        private TargetResource _targetResource;
        private string _targetResourceVersion;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action exectued.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The time the process ended.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime
        {
            get { return this._executionEndTime; }
            set { this._executionEndTime = value; }
        }

        // Check to see if ExecutionEndTime property is set
        internal bool IsSetExecutionEndTime()
        {
            return this._executionEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionEntityVersion. 
        /// <para>
        /// The execution entity version associated with the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ExecutionEntityVersion
        {
            get { return this._executionEntityVersion; }
            set { this._executionEntityVersion = value; }
        }

        // Check to see if ExecutionEntityVersion property is set
        internal bool IsSetExecutionEntityVersion()
        {
            return this._executionEntityVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The ID of the execution.
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
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// The time the process started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExecutionStartTime
        {
            get { return this._executionStartTime; }
            set { this._executionStartTime = value; }
        }

        // Check to see if ExecutionStartTime property is set
        internal bool IsSetExecutionStartTime()
        {
            return this._executionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The status of the execution process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this execution resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo
        {
            get { return this._resolveTo; }
            set { this._resolveTo = value; }
        }

        // Check to see if ResolveTo property is set
        internal bool IsSetResolveTo()
        {
            return this._resolveTo != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource.
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetResource TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceVersion. 
        /// <para>
        /// The version of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string TargetResourceVersion
        {
            get { return this._targetResourceVersion; }
            set { this._targetResourceVersion = value; }
        }

        // Check to see if TargetResourceVersion property is set
        internal bool IsSetTargetResourceVersion()
        {
            return this._targetResourceVersion != null;
        }

    }
}