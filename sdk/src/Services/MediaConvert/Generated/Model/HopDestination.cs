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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Optional. Configuration for a destination queue to which the job can hop once a customer-defined
    /// minimum wait time has passed.
    /// </summary>
    public partial class HopDestination
    {
        private int? _priority;
        private string _queue;
        private int? _waitMinutes;

        /// <summary>
        /// Gets and sets the property Priority. Optional. When you set up a job to use queue
        /// hopping, you can specify a different relative priority for the job in the destination
        /// queue. If you don't specify, the relative priority will remain the same as in the
        /// previous queue.
        /// </summary>
        [AWSProperty(Min=-50, Max=50)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queue. Optional unless the job is submitted on the default
        /// queue. When you set up a job to use queue hopping, you can specify a destination queue.
        /// This queue cannot be the original queue to which the job is submitted. If the original
        /// queue isn't the default queue and you don't specify the destination queue, the job
        /// will move to the default queue.
        /// </summary>
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property WaitMinutes. Required for setting up a job to use queue
        /// hopping. Minimum wait time in minutes until the job can hop to the destination queue.
        /// Valid range is 1 to 4320 minutes, inclusive.
        /// </summary>
        public int? WaitMinutes
        {
            get { return this._waitMinutes; }
            set { this._waitMinutes = value; }
        }

        // Check to see if WaitMinutes property is set
        internal bool IsSetWaitMinutes()
        {
            return this._waitMinutes.HasValue; 
        }

    }
}