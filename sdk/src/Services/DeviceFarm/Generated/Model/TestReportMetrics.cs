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
    /// Contains aggregated metrics across all tests in a job.
    /// </summary>
    public partial class TestReportMetrics
    {
        private double? _medianTestExecutionDurationSeconds;
        private int? _testsErrored;
        private int? _testsFailed;
        private int? _testsOther;
        private int? _testsPassed;
        private double? _testsPassedPercentage;
        private int? _testsSkipped;
        private int? _testsTotal;
        private double? _totalTestExecutionDurationSeconds;

        /// <summary>
        /// Gets and sets the property MedianTestExecutionDurationSeconds. 
        /// <para>
        /// The median execution duration of tests in the job, in seconds.
        /// </para>
        /// </summary>
        public double? MedianTestExecutionDurationSeconds
        {
            get { return this._medianTestExecutionDurationSeconds; }
            set { this._medianTestExecutionDurationSeconds = value; }
        }

        // Check to see if MedianTestExecutionDurationSeconds property is set
        internal bool IsSetMedianTestExecutionDurationSeconds()
        {
            return this._medianTestExecutionDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsErrored. 
        /// <para>
        /// The number of tests that errored.
        /// </para>
        /// </summary>
        public int? TestsErrored
        {
            get { return this._testsErrored; }
            set { this._testsErrored = value; }
        }

        // Check to see if TestsErrored property is set
        internal bool IsSetTestsErrored()
        {
            return this._testsErrored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsFailed. 
        /// <para>
        /// The number of tests that failed.
        /// </para>
        /// </summary>
        public int? TestsFailed
        {
            get { return this._testsFailed; }
            set { this._testsFailed = value; }
        }

        // Check to see if TestsFailed property is set
        internal bool IsSetTestsFailed()
        {
            return this._testsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsOther. 
        /// <para>
        /// The number of tests with other result types.
        /// </para>
        /// </summary>
        public int? TestsOther
        {
            get { return this._testsOther; }
            set { this._testsOther = value; }
        }

        // Check to see if TestsOther property is set
        internal bool IsSetTestsOther()
        {
            return this._testsOther.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsPassed. 
        /// <para>
        /// The number of tests that passed.
        /// </para>
        /// </summary>
        public int? TestsPassed
        {
            get { return this._testsPassed; }
            set { this._testsPassed = value; }
        }

        // Check to see if TestsPassed property is set
        internal bool IsSetTestsPassed()
        {
            return this._testsPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsPassedPercentage. 
        /// <para>
        /// The percentage of tests that passed.
        /// </para>
        /// </summary>
        public double? TestsPassedPercentage
        {
            get { return this._testsPassedPercentage; }
            set { this._testsPassedPercentage = value; }
        }

        // Check to see if TestsPassedPercentage property is set
        internal bool IsSetTestsPassedPercentage()
        {
            return this._testsPassedPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsSkipped. 
        /// <para>
        /// The number of tests that were skipped.
        /// </para>
        /// </summary>
        public int? TestsSkipped
        {
            get { return this._testsSkipped; }
            set { this._testsSkipped = value; }
        }

        // Check to see if TestsSkipped property is set
        internal bool IsSetTestsSkipped()
        {
            return this._testsSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestsTotal. 
        /// <para>
        /// The total number of tests in the job.
        /// </para>
        /// </summary>
        public int? TestsTotal
        {
            get { return this._testsTotal; }
            set { this._testsTotal = value; }
        }

        // Check to see if TestsTotal property is set
        internal bool IsSetTestsTotal()
        {
            return this._testsTotal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalTestExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of all tests in the job, in seconds.
        /// </para>
        /// </summary>
        public double? TotalTestExecutionDurationSeconds
        {
            get { return this._totalTestExecutionDurationSeconds; }
            set { this._totalTestExecutionDurationSeconds = value; }
        }

        // Check to see if TotalTestExecutionDurationSeconds property is set
        internal bool IsSetTotalTestExecutionDurationSeconds()
        {
            return this._totalTestExecutionDurationSeconds.HasValue; 
        }

    }
}