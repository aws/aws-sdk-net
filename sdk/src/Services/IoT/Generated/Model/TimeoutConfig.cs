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
    /// Specifies the amount of time each device has to finish its execution of the job. A
    /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
    /// job execution status is not set to another terminal state before the timer expires,
    /// it will be automatically set to <c>TIMED_OUT</c>.
    /// </summary>
    public partial class TimeoutConfig
    {
        private long? _inProgressTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property InProgressTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time, in minutes, this device has to finish execution of this
        /// job. The timeout interval can be anywhere between 1 minute and 7 days (1 to 10080
        /// minutes). The in progress timer can't be updated and will apply to all job executions
        /// for the job. Whenever a job execution remains in the IN_PROGRESS status for longer
        /// than this interval, the job execution will fail and switch to the terminal <c>TIMED_OUT</c>
        /// status.
        /// </para>
        /// </summary>
        public long? InProgressTimeoutInMinutes
        {
            get { return this._inProgressTimeoutInMinutes; }
            set { this._inProgressTimeoutInMinutes = value; }
        }

        // Check to see if InProgressTimeoutInMinutes property is set
        internal bool IsSetInProgressTimeoutInMinutes()
        {
            return this._inProgressTimeoutInMinutes.HasValue; 
        }

    }
}