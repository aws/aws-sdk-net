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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Provides information about your DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">task
    /// schedule</a>.
    /// </summary>
    public partial class TaskScheduleDetails
    {
        private ScheduleDisabledBy _disabledBy;
        private string _disabledReason;
        private DateTime? _statusUpdateTime;

        /// <summary>
        /// Gets and sets the property DisabledBy. 
        /// <para>
        /// Indicates how your task schedule was disabled.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>USER</c> - Your schedule was manually disabled by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_UpdateTask.html">UpdateTask</a>
        /// operation or DataSync console.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE</c> - Your schedule was automatically disabled by DataSync because the
        /// task failed repeatedly with the same error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScheduleDisabledBy DisabledBy
        {
            get { return this._disabledBy; }
            set { this._disabledBy = value; }
        }

        // Check to see if DisabledBy property is set
        internal bool IsSetDisabledBy()
        {
            return this._disabledBy != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// Provides a reason if the task schedule is disabled.
        /// </para>
        ///  
        /// <para>
        /// If your schedule is disabled by <c>USER</c>, you see a <c>Manually disabled by user.</c>
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If your schedule is disabled by <c>SERVICE</c>, you see an error message to help you
        /// understand why the task keeps failing. For information on resolving DataSync errors,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">Troubleshooting
        /// issues with DataSync transfers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string DisabledReason
        {
            get { return this._disabledReason; }
            set { this._disabledReason = value; }
        }

        // Check to see if DisabledReason property is set
        internal bool IsSetDisabledReason()
        {
            return this._disabledReason != null;
        }

        /// <summary>
        /// Gets and sets the property StatusUpdateTime. 
        /// <para>
        /// Indicates the last time the status of your task schedule changed. For example, if
        /// DataSync automatically disables your schedule because of a repeated error, you can
        /// see when the schedule was disabled.
        /// </para>
        /// </summary>
        public DateTime? StatusUpdateTime
        {
            get { return this._statusUpdateTime; }
            set { this._statusUpdateTime = value; }
        }

        // Check to see if StatusUpdateTime property is set
        internal bool IsSetStatusUpdateTime()
        {
            return this._statusUpdateTime.HasValue; 
        }

    }
}