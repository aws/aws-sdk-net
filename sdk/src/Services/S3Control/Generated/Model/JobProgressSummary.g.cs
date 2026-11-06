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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property NumberOfTasksFailed. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? NumberOfTasksFailed { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTasksFailed property is set.
        /// </summary>
        internal bool IsSetNumberOfTasksFailed() => this.NumberOfTasksFailed.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfTasksSucceeded. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? NumberOfTasksSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTasksSucceeded property is set.
        /// </summary>
        internal bool IsSetNumberOfTasksSucceeded() => this.NumberOfTasksSucceeded.HasValue;

        /// <summary>
        /// Gets and sets the property Timers. 
        /// <para>
        /// The JobTimers attribute of a job's progress summary.
        /// </para>
        /// </summary>
        public JobTimers Timers { get; set; }

        /// <summary>
        /// Checks to see if the Timers property is set.
        /// </summary>
        internal bool IsSetTimers() => this.Timers != null;

        /// <summary>
        /// Gets and sets the property TotalNumberOfTasks. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalNumberOfTasks { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfTasks property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfTasks() => this.TotalNumberOfTasks.HasValue;
    }
}
