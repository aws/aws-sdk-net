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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The criteria that are used to filter the task runs for the machine learning transform.
    /// </summary>
    public partial class TaskRunFilterCriteria
    {
        private DateTime? _startedAfter;
        private DateTime? _startedBefore;
        private TaskStatusType _status;
        private TaskType _taskRunType;

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter on task runs started after this date.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter
        {
            get { return this._startedAfter; }
            set { this._startedAfter = value; }
        }

        // Check to see if StartedAfter property is set
        internal bool IsSetStartedAfter()
        {
            return this._startedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter on task runs started before this date.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore
        {
            get { return this._startedBefore; }
            set { this._startedBefore = value; }
        }

        // Check to see if StartedBefore property is set
        internal bool IsSetStartedBefore()
        {
            return this._startedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the task run.
        /// </para>
        /// </summary>
        public TaskStatusType Status
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
        /// Gets and sets the property TaskRunType. 
        /// <para>
        /// The type of task run.
        /// </para>
        /// </summary>
        public TaskType TaskRunType
        {
            get { return this._taskRunType; }
            set { this._taskRunType = value; }
        }

        // Check to see if TaskRunType property is set
        internal bool IsSetTaskRunType()
        {
            return this._taskRunType != null;
        }

    }
}