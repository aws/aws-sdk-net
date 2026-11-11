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
    /// Contains aggregated metrics across all tests in a job.
    /// </summary>
    public partial class TestReportMetrics
    {
        /// <summary>
        /// Gets and sets the property MedianTestExecutionDurationSeconds. 
        /// <para>
        /// The median execution duration of tests in the job, in seconds.
        /// </para>
        /// </summary>
        public double? MedianTestExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MedianTestExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetMedianTestExecutionDurationSeconds() => this.MedianTestExecutionDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TestsErrored. 
        /// <para>
        /// The number of tests that errored.
        /// </para>
        /// </summary>
        public int? TestsErrored { get; set; }

        /// <summary>
        /// Checks to see if the TestsErrored property is set.
        /// </summary>
        internal bool IsSetTestsErrored() => this.TestsErrored.HasValue;

        /// <summary>
        /// Gets and sets the property TestsFailed. 
        /// <para>
        /// The number of tests that failed.
        /// </para>
        /// </summary>
        public int? TestsFailed { get; set; }

        /// <summary>
        /// Checks to see if the TestsFailed property is set.
        /// </summary>
        internal bool IsSetTestsFailed() => this.TestsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property TestsOther. 
        /// <para>
        /// The number of tests with other result types.
        /// </para>
        /// </summary>
        public int? TestsOther { get; set; }

        /// <summary>
        /// Checks to see if the TestsOther property is set.
        /// </summary>
        internal bool IsSetTestsOther() => this.TestsOther.HasValue;

        /// <summary>
        /// Gets and sets the property TestsPassed. 
        /// <para>
        /// The number of tests that passed.
        /// </para>
        /// </summary>
        public int? TestsPassed { get; set; }

        /// <summary>
        /// Checks to see if the TestsPassed property is set.
        /// </summary>
        internal bool IsSetTestsPassed() => this.TestsPassed.HasValue;

        /// <summary>
        /// Gets and sets the property TestsPassedPercentage. 
        /// <para>
        /// The percentage of tests that passed.
        /// </para>
        /// </summary>
        public double? TestsPassedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the TestsPassedPercentage property is set.
        /// </summary>
        internal bool IsSetTestsPassedPercentage() => this.TestsPassedPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property TestsSkipped. 
        /// <para>
        /// The number of tests that were skipped.
        /// </para>
        /// </summary>
        public int? TestsSkipped { get; set; }

        /// <summary>
        /// Checks to see if the TestsSkipped property is set.
        /// </summary>
        internal bool IsSetTestsSkipped() => this.TestsSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property TestsTotal. 
        /// <para>
        /// The total number of tests in the job.
        /// </para>
        /// </summary>
        public int? TestsTotal { get; set; }

        /// <summary>
        /// Checks to see if the TestsTotal property is set.
        /// </summary>
        internal bool IsSetTestsTotal() => this.TestsTotal.HasValue;

        /// <summary>
        /// Gets and sets the property TotalTestExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of all tests in the job, in seconds.
        /// </para>
        /// </summary>
        public double? TotalTestExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalTestExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetTotalTestExecutionDurationSeconds() => this.TotalTestExecutionDurationSeconds.HasValue;
    }
}
