/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Workflow run statistics provides statistics about the workflow run.
    /// </summary>
    public partial class WorkflowRunStatistics
    {
        private int? _failedActions;
        private int? _runningActions;
        private int? _stoppedActions;
        private int? _succeededActions;
        private int? _timeoutActions;
        private int? _totalActions;

        /// <summary>
        /// Gets and sets the property FailedActions. 
        /// <para>
        /// Total number of Actions which have failed.
        /// </para>
        /// </summary>
        public int FailedActions
        {
            get { return this._failedActions.GetValueOrDefault(); }
            set { this._failedActions = value; }
        }

        // Check to see if FailedActions property is set
        internal bool IsSetFailedActions()
        {
            return this._failedActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningActions. 
        /// <para>
        /// Total number Actions in running state.
        /// </para>
        /// </summary>
        public int RunningActions
        {
            get { return this._runningActions.GetValueOrDefault(); }
            set { this._runningActions = value; }
        }

        // Check to see if RunningActions property is set
        internal bool IsSetRunningActions()
        {
            return this._runningActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppedActions. 
        /// <para>
        /// Total number of Actions which have stopped.
        /// </para>
        /// </summary>
        public int StoppedActions
        {
            get { return this._stoppedActions.GetValueOrDefault(); }
            set { this._stoppedActions = value; }
        }

        // Check to see if StoppedActions property is set
        internal bool IsSetStoppedActions()
        {
            return this._stoppedActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SucceededActions. 
        /// <para>
        /// Total number of Actions which have succeeded.
        /// </para>
        /// </summary>
        public int SucceededActions
        {
            get { return this._succeededActions.GetValueOrDefault(); }
            set { this._succeededActions = value; }
        }

        // Check to see if SucceededActions property is set
        internal bool IsSetSucceededActions()
        {
            return this._succeededActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutActions. 
        /// <para>
        /// Total number of Actions which timed out.
        /// </para>
        /// </summary>
        public int TimeoutActions
        {
            get { return this._timeoutActions.GetValueOrDefault(); }
            set { this._timeoutActions = value; }
        }

        // Check to see if TimeoutActions property is set
        internal bool IsSetTimeoutActions()
        {
            return this._timeoutActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalActions. 
        /// <para>
        /// Total number of Actions in the workflow run.
        /// </para>
        /// </summary>
        public int TotalActions
        {
            get { return this._totalActions.GetValueOrDefault(); }
            set { this._totalActions = value; }
        }

        // Check to see if TotalActions property is set
        internal bool IsSetTotalActions()
        {
            return this._totalActions.HasValue; 
        }

    }
}