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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about the timeout configuration for a job.
    /// </summary>
    public partial class IoTJobTimeoutConfig
    {
        private long? _inProgressTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property InProgressTimeoutInMinutes. 
        /// <para>
        /// The amount of time, in minutes, that devices have to complete the job. The timer starts
        /// when the job status is set to <c>IN_PROGRESS</c>. If the job status doesn't change
        /// to a terminal state before the time expires, then the job status is set to <c>TIMED_OUT</c>.
        /// </para>
        ///  
        /// <para>
        /// The timeout interval must be between 1 minute and 7 days (10080 minutes).
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