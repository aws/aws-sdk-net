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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Describes the total number of tasks that the specified job has started, the number
    /// of tasks that succeeded, and the number of tasks that failed.
    /// </summary>
    public partial class JobProgressSummary
    {
        private long? _numberOfTasksFailed;
        private long? _numberOfTasksSucceeded;
        private JobTimers _timers;
        private long? _totalNumberOfTasks;

        /// <summary>
        /// Gets and sets the property NumberOfTasksFailed.
        /// </summary>
        [AWSProperty(Min=0)]
        public long? NumberOfTasksFailed
        {
            get { return this._numberOfTasksFailed; }
            set { this._numberOfTasksFailed = value; }
        }

        // Check to see if NumberOfTasksFailed property is set
        internal bool IsSetNumberOfTasksFailed()
        {
            return this._numberOfTasksFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTasksSucceeded.
        /// </summary>
        [AWSProperty(Min=0)]
        public long? NumberOfTasksSucceeded
        {
            get { return this._numberOfTasksSucceeded; }
            set { this._numberOfTasksSucceeded = value; }
        }

        // Check to see if NumberOfTasksSucceeded property is set
        internal bool IsSetNumberOfTasksSucceeded()
        {
            return this._numberOfTasksSucceeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timers. 
        /// <para>
        /// The JobTimers attribute of a job's progress summary.
        /// </para>
        /// </summary>
        public JobTimers Timers
        {
            get { return this._timers; }
            set { this._timers = value; }
        }

        // Check to see if Timers property is set
        internal bool IsSetTimers()
        {
            return this._timers != null;
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfTasks.
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalNumberOfTasks
        {
            get { return this._totalNumberOfTasks; }
            set { this._totalNumberOfTasks = value; }
        }

        // Check to see if TotalNumberOfTasks property is set
        internal bool IsSetTotalNumberOfTasks()
        {
            return this._totalNumberOfTasks.HasValue; 
        }

    }
}