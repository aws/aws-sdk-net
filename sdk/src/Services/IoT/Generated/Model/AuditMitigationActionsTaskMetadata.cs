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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about an audit mitigation actions task that is returned by <c>ListAuditMitigationActionsTasks</c>.
    /// </summary>
    public partial class AuditMitigationActionsTaskMetadata
    {
        private DateTime? _startTime;
        private string _taskId;
        private AuditMitigationActionsTaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the audit mitigation actions task was started.
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
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier for the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The current state of the audit mitigation actions task.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}