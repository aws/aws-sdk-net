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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// A summarized representation of a plan execution. This structure contains key information
    /// about an execution without all the detailed step data.
    /// </summary>
    public partial class AbbreviatedExecution
    {
        private string _actualRecoveryTime;
        private string _comment;
        private DateTime? _endTime;
        private ExecutionAction _executionAction;
        private string _executionId;
        private string _executionRegion;
        private ExecutionState _executionState;
        private ExecutionMode _mode;
        private string _planArn;
        private DateTime? _startTime;
        private DateTime? _updatedAt;
        private string _version;

        /// <summary>
        /// Gets and sets the property ActualRecoveryTime. 
        /// <para>
        /// The actual recovery time that Region switch calculates for a plan execution. Actual
        /// recovery time includes the time for the plan to run added to the time elapsed until
        /// the application health alarms that you've specified are healthy again.
        /// </para>
        /// </summary>
        public string ActualRecoveryTime
        {
            get { return this._actualRecoveryTime; }
            set { this._actualRecoveryTime = value; }
        }

        // Check to see if ActualRecoveryTime property is set
        internal bool IsSetActualRecoveryTime()
        {
            return this._actualRecoveryTime != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the plan execution.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the plan execution was ended.
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
        /// Gets and sets the property ExecutionAction. 
        /// <para>
        /// The plan execution action. Valid values are <c>Activate</c>, to activate an Amazon
        /// Web Services Region, or <c>Deactivate</c>, to deactivate a Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionAction ExecutionAction
        {
            get { return this._executionAction; }
            set { this._executionAction = value; }
        }

        // Check to see if ExecutionAction property is set
        internal bool IsSetExecutionAction()
        {
            return this._executionAction != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution identifier of a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExecutionRegion. 
        /// <para>
        /// The Amazon Web Services Region for a plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionRegion
        {
            get { return this._executionRegion; }
            set { this._executionRegion = value; }
        }

        // Check to see if ExecutionRegion property is set
        internal bool IsSetExecutionRegion()
        {
            return this._executionRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionState. 
        /// <para>
        /// The plan execution state. Provides the state of a plan execution, for example, In
        /// Progress or Paused by Operator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionState ExecutionState
        {
            get { return this._executionState; }
            set { this._executionState = value; }
        }

        // Check to see if ExecutionState property is set
        internal bool IsSetExecutionState()
        {
            return this._executionState != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The plan execution mode. Valid values are <c>Practice</c>, for testing without making
        /// actual changes, or <c>Recovery</c>, for actual traffic shifting and application recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanArn
        {
            get { return this._planArn; }
            set { this._planArn = value; }
        }

        // Check to see if PlanArn property is set
        internal bool IsSetPlanArn()
        {
            return this._planArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the plan execution was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the plan execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the plan.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}