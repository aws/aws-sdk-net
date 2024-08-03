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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies a test run step summary.
    /// </summary>
    public partial class TestRunStepSummary
    {
        private bool? _afterStep;
        private bool? _beforeStep;
        private DateTime? _runEndTime;
        private DateTime? _runStartTime;
        private StepRunStatus _status;
        private string _statusReason;
        private string _stepName;
        private string _testCaseId;
        private int? _testCaseVersion;
        private string _testRunId;
        private string _testSuiteId;
        private int? _testSuiteVersion;

        /// <summary>
        /// Gets and sets the property AfterStep. 
        /// <para>
        /// The after step of the test run step summary.
        /// </para>
        /// </summary>
        public bool? AfterStep
        {
            get { return this._afterStep; }
            set { this._afterStep = value; }
        }

        // Check to see if AfterStep property is set
        internal bool IsSetAfterStep()
        {
            return this._afterStep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeStep. 
        /// <para>
        /// The before step of the test run step summary.
        /// </para>
        /// </summary>
        public bool? BeforeStep
        {
            get { return this._beforeStep; }
            set { this._beforeStep = value; }
        }

        // Check to see if BeforeStep property is set
        internal bool IsSetBeforeStep()
        {
            return this._beforeStep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunEndTime. 
        /// <para>
        /// The run end time of the test run step summary.
        /// </para>
        /// </summary>
        public DateTime? RunEndTime
        {
            get { return this._runEndTime; }
            set { this._runEndTime = value; }
        }

        // Check to see if RunEndTime property is set
        internal bool IsSetRunEndTime()
        {
            return this._runEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunStartTime. 
        /// <para>
        /// The run start time of the test run step summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? RunStartTime
        {
            get { return this._runStartTime; }
            set { this._runStartTime = value; }
        }

        // Check to see if RunStartTime property is set
        internal bool IsSetRunStartTime()
        {
            return this._runStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the test run step summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StepRunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the test run step summary.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The step name of the test run step summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The test case ID of the test run step summary.
        /// </para>
        /// </summary>
        public string TestCaseId
        {
            get { return this._testCaseId; }
            set { this._testCaseId = value; }
        }

        // Check to see if TestCaseId property is set
        internal bool IsSetTestCaseId()
        {
            return this._testCaseId != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseVersion. 
        /// <para>
        /// The test case version of the test run step summary.
        /// </para>
        /// </summary>
        public int? TestCaseVersion
        {
            get { return this._testCaseVersion; }
            set { this._testCaseVersion = value; }
        }

        // Check to see if TestCaseVersion property is set
        internal bool IsSetTestCaseVersion()
        {
            return this._testCaseVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The test run ID of the test run step summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestRunId
        {
            get { return this._testRunId; }
            set { this._testRunId = value; }
        }

        // Check to see if TestRunId property is set
        internal bool IsSetTestRunId()
        {
            return this._testRunId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The test suite ID of the test run step summary.
        /// </para>
        /// </summary>
        public string TestSuiteId
        {
            get { return this._testSuiteId; }
            set { this._testSuiteId = value; }
        }

        // Check to see if TestSuiteId property is set
        internal bool IsSetTestSuiteId()
        {
            return this._testSuiteId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteVersion. 
        /// <para>
        /// The test suite version of the test run step summary.
        /// </para>
        /// </summary>
        public int? TestSuiteVersion
        {
            get { return this._testSuiteVersion; }
            set { this._testSuiteVersion = value; }
        }

        // Check to see if TestSuiteVersion property is set
        internal bool IsSetTestSuiteVersion()
        {
            return this._testSuiteVersion.HasValue; 
        }

    }
}