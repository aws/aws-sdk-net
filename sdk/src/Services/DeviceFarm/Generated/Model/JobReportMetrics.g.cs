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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Contains aggregated metrics across all jobs in a run.
    /// </summary>
    public partial class JobReportMetrics
    {
        /// <summary>
        /// Gets and sets the property AverageJobExecutionDurationSeconds. 
        /// <para>
        /// The average execution duration of jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? AverageJobExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AverageJobExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetAverageJobExecutionDurationSeconds() => this.AverageJobExecutionDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property JobsErrored. 
        /// <para>
        /// The number of jobs that errored.
        /// </para>
        /// </summary>
        public int? JobsErrored { get; set; }

        /// <summary>
        /// Checks to see if the JobsErrored property is set.
        /// </summary>
        internal bool IsSetJobsErrored() => this.JobsErrored.HasValue;

        /// <summary>
        /// Gets and sets the property JobsFailed. 
        /// <para>
        /// The number of jobs that failed.
        /// </para>
        /// </summary>
        public int? JobsFailed { get; set; }

        /// <summary>
        /// Checks to see if the JobsFailed property is set.
        /// </summary>
        internal bool IsSetJobsFailed() => this.JobsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property JobsPassed. 
        /// <para>
        /// The number of jobs that passed.
        /// </para>
        /// </summary>
        public int? JobsPassed { get; set; }

        /// <summary>
        /// Checks to see if the JobsPassed property is set.
        /// </summary>
        internal bool IsSetJobsPassed() => this.JobsPassed.HasValue;

        /// <summary>
        /// Gets and sets the property JobsPassedPercentage. 
        /// <para>
        /// The percentage of jobs that passed.
        /// </para>
        /// </summary>
        public double? JobsPassedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the JobsPassedPercentage property is set.
        /// </summary>
        internal bool IsSetJobsPassedPercentage() => this.JobsPassedPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property JobsSkipped. 
        /// <para>
        /// The number of jobs that were skipped.
        /// </para>
        /// </summary>
        public int? JobsSkipped { get; set; }

        /// <summary>
        /// Checks to see if the JobsSkipped property is set.
        /// </summary>
        internal bool IsSetJobsSkipped() => this.JobsSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property JobsStopped. 
        /// <para>
        /// The number of jobs that were stopped.
        /// </para>
        /// </summary>
        public int? JobsStopped { get; set; }

        /// <summary>
        /// Checks to see if the JobsStopped property is set.
        /// </summary>
        internal bool IsSetJobsStopped() => this.JobsStopped.HasValue;

        /// <summary>
        /// Gets and sets the property JobsTotal. 
        /// <para>
        /// The total number of jobs in the run.
        /// </para>
        /// </summary>
        public int? JobsTotal { get; set; }

        /// <summary>
        /// Checks to see if the JobsTotal property is set.
        /// </summary>
        internal bool IsSetJobsTotal() => this.JobsTotal.HasValue;

        /// <summary>
        /// Gets and sets the property MedianJobExecutionDurationSeconds. 
        /// <para>
        /// The median execution duration of jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? MedianJobExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MedianJobExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetMedianJobExecutionDurationSeconds() => this.MedianJobExecutionDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TotalJobExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of all jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? TotalJobExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalJobExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetTotalJobExecutionDurationSeconds() => this.TotalJobExecutionDurationSeconds.HasValue;
    }
}
