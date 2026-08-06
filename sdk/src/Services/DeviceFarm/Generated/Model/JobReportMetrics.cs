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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private double? _averageJobExecutionDurationSeconds;
        private int? _jobsErrored;
        private int? _jobsFailed;
        private int? _jobsPassed;
        private double? _jobsPassedPercentage;
        private int? _jobsSkipped;
        private int? _jobsStopped;
        private int? _jobsTotal;
        private double? _medianJobExecutionDurationSeconds;
        private double? _totalJobExecutionDurationSeconds;

        /// <summary>
        /// Gets and sets the property AverageJobExecutionDurationSeconds. 
        /// <para>
        /// The average execution duration of jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? AverageJobExecutionDurationSeconds
        {
            get { return this._averageJobExecutionDurationSeconds; }
            set { this._averageJobExecutionDurationSeconds = value; }
        }

        // Check to see if AverageJobExecutionDurationSeconds property is set
        internal bool IsSetAverageJobExecutionDurationSeconds()
        {
            return this._averageJobExecutionDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsErrored. 
        /// <para>
        /// The number of jobs that errored.
        /// </para>
        /// </summary>
        public int? JobsErrored
        {
            get { return this._jobsErrored; }
            set { this._jobsErrored = value; }
        }

        // Check to see if JobsErrored property is set
        internal bool IsSetJobsErrored()
        {
            return this._jobsErrored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsFailed. 
        /// <para>
        /// The number of jobs that failed.
        /// </para>
        /// </summary>
        public int? JobsFailed
        {
            get { return this._jobsFailed; }
            set { this._jobsFailed = value; }
        }

        // Check to see if JobsFailed property is set
        internal bool IsSetJobsFailed()
        {
            return this._jobsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsPassed. 
        /// <para>
        /// The number of jobs that passed.
        /// </para>
        /// </summary>
        public int? JobsPassed
        {
            get { return this._jobsPassed; }
            set { this._jobsPassed = value; }
        }

        // Check to see if JobsPassed property is set
        internal bool IsSetJobsPassed()
        {
            return this._jobsPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsPassedPercentage. 
        /// <para>
        /// The percentage of jobs that passed.
        /// </para>
        /// </summary>
        public double? JobsPassedPercentage
        {
            get { return this._jobsPassedPercentage; }
            set { this._jobsPassedPercentage = value; }
        }

        // Check to see if JobsPassedPercentage property is set
        internal bool IsSetJobsPassedPercentage()
        {
            return this._jobsPassedPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsSkipped. 
        /// <para>
        /// The number of jobs that were skipped.
        /// </para>
        /// </summary>
        public int? JobsSkipped
        {
            get { return this._jobsSkipped; }
            set { this._jobsSkipped = value; }
        }

        // Check to see if JobsSkipped property is set
        internal bool IsSetJobsSkipped()
        {
            return this._jobsSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsStopped. 
        /// <para>
        /// The number of jobs that were stopped.
        /// </para>
        /// </summary>
        public int? JobsStopped
        {
            get { return this._jobsStopped; }
            set { this._jobsStopped = value; }
        }

        // Check to see if JobsStopped property is set
        internal bool IsSetJobsStopped()
        {
            return this._jobsStopped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobsTotal. 
        /// <para>
        /// The total number of jobs in the run.
        /// </para>
        /// </summary>
        public int? JobsTotal
        {
            get { return this._jobsTotal; }
            set { this._jobsTotal = value; }
        }

        // Check to see if JobsTotal property is set
        internal bool IsSetJobsTotal()
        {
            return this._jobsTotal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MedianJobExecutionDurationSeconds. 
        /// <para>
        /// The median execution duration of jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? MedianJobExecutionDurationSeconds
        {
            get { return this._medianJobExecutionDurationSeconds; }
            set { this._medianJobExecutionDurationSeconds = value; }
        }

        // Check to see if MedianJobExecutionDurationSeconds property is set
        internal bool IsSetMedianJobExecutionDurationSeconds()
        {
            return this._medianJobExecutionDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalJobExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of all jobs in the run, in seconds.
        /// </para>
        /// </summary>
        public double? TotalJobExecutionDurationSeconds
        {
            get { return this._totalJobExecutionDurationSeconds; }
            set { this._totalJobExecutionDurationSeconds = value; }
        }

        // Check to see if TotalJobExecutionDurationSeconds property is set
        internal bool IsSetTotalJobExecutionDurationSeconds()
        {
            return this._totalJobExecutionDurationSeconds.HasValue; 
        }

    }
}