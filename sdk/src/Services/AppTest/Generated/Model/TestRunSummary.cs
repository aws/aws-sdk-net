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
    /// Specifies a test run summary.
    /// </summary>
    public partial class TestRunSummary
    {
        private DateTime? _runEndTime;
        private DateTime? _runStartTime;
        private TestRunStatus _status;
        private string _statusReason;
        private string _testConfigurationId;
        private int? _testConfigurationVersion;
        private string _testRunArn;
        private string _testRunId;
        private string _testSuiteId;
        private int? _testSuiteVersion;

        /// <summary>
        /// Gets and sets the property RunEndTime. 
        /// <para>
        /// The run end time of the test run summary.
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
        /// The run start time of the test run summary.
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
        /// The status of the test run summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestRunStatus Status
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
        /// The status reason of the test run summary.
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
        /// Gets and sets the property TestConfigurationId. 
        /// <para>
        /// The test configuration ID of the test run summary.
        /// </para>
        /// </summary>
        public string TestConfigurationId
        {
            get { return this._testConfigurationId; }
            set { this._testConfigurationId = value; }
        }

        // Check to see if TestConfigurationId property is set
        internal bool IsSetTestConfigurationId()
        {
            return this._testConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property TestConfigurationVersion. 
        /// <para>
        /// The test configuration version of the test run summary.
        /// </para>
        /// </summary>
        public int? TestConfigurationVersion
        {
            get { return this._testConfigurationVersion; }
            set { this._testConfigurationVersion = value; }
        }

        // Check to see if TestConfigurationVersion property is set
        internal bool IsSetTestConfigurationVersion()
        {
            return this._testConfigurationVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestRunArn. 
        /// <para>
        /// The test run ARN of the test run summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestRunArn
        {
            get { return this._testRunArn; }
            set { this._testRunArn = value; }
        }

        // Check to see if TestRunArn property is set
        internal bool IsSetTestRunArn()
        {
            return this._testRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The test run ID of the test run summary.
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
        /// The test suite ID of the test run summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The test suite version of the test run summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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