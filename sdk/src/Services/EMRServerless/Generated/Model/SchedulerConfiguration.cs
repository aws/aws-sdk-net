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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The scheduler configuration for batch and streaming jobs running on this application.
    /// Supported with release labels emr-7.0.0 and above.
    /// </summary>
    public partial class SchedulerConfiguration
    {
        private int? _maxConcurrentRuns;
        private int? _queueTimeoutMinutes;

        /// <summary>
        /// Gets and sets the property MaxConcurrentRuns. 
        /// <para>
        /// The maximum concurrent job runs on this application. If scheduler configuration is
        /// enabled on your application, the default value is 15. The valid range is 1 to 1000.
        /// </para>
        /// </summary>
        public int? MaxConcurrentRuns
        {
            get { return this._maxConcurrentRuns; }
            set { this._maxConcurrentRuns = value; }
        }

        // Check to see if MaxConcurrentRuns property is set
        internal bool IsSetMaxConcurrentRuns()
        {
            return this._maxConcurrentRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueTimeoutMinutes. 
        /// <para>
        /// The maximum duration in minutes for the job in QUEUED state. If scheduler configuration
        /// is enabled on your application, the default value is 360 minutes (6 hours). The valid
        /// range is from 15 to 720.
        /// </para>
        /// </summary>
        public int? QueueTimeoutMinutes
        {
            get { return this._queueTimeoutMinutes; }
            set { this._queueTimeoutMinutes = value; }
        }

        // Check to see if QueueTimeoutMinutes property is set
        internal bool IsSetQueueTimeoutMinutes()
        {
            return this._queueTimeoutMinutes.HasValue; 
        }

    }
}