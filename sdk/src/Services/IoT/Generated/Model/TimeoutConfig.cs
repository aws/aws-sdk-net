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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Specifies the amount of time each device has to finish its execution of the job. A
    /// timer is started when the job execution status is set to <code>IN_PROGRESS</code>.
    /// If the job execution status is not set to another terminal state before the timer
    /// expires, it will be automatically set to <code>TIMED_OUT</code>.
    /// </summary>
    public partial class TimeoutConfig
    {
        private long? _inProgressTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property InProgressTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time, in minutes, this device has to finish execution of this
        /// job. A timer is started, or restarted, whenever this job's execution status is specified
        /// as <code>IN_PROGRESS</code> with this field populated. If the job execution status
        /// is not set to a terminal state before the timer expires, or before another job execution
        /// status update is sent with this field populated, the status will be automatically
        /// set to <code>TIMED_OUT</code>. Note that setting/resetting this timer has no effect
        /// on the job execution timeout timer which may have been specified when the job was
        /// created (<code>CreateJobExecution</code> using the field <code>timeoutConfig</code>).
        /// </para>
        /// </summary>
        public long InProgressTimeoutInMinutes
        {
            get { return this._inProgressTimeoutInMinutes.GetValueOrDefault(); }
            set { this._inProgressTimeoutInMinutes = value; }
        }

        // Check to see if InProgressTimeoutInMinutes property is set
        internal bool IsSetInProgressTimeoutInMinutes()
        {
            return this._inProgressTimeoutInMinutes.HasValue; 
        }

    }
}