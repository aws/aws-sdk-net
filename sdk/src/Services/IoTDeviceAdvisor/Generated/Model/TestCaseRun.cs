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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
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
namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Provides the test case run.
    /// </summary>
    public partial class TestCaseRun
    {
        private DateTime? _endTime;
        private string _failure;
        private string _logUrl;
        private DateTime? _startTime;
        private Status _status;
        private string _testCaseDefinitionId;
        private string _testCaseDefinitionName;
        private string _testCaseRunId;
        private List<TestCaseScenario> _testScenarios = AWSConfigs.InitializeCollections ? new List<TestCaseScenario>() : null;
        private string _warnings;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Provides test case run end time.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failure. 
        /// <para>
        /// Provides test case run failure result.
        /// </para>
        /// </summary>
        public string Failure
        {
            get { return this._failure; }
            set { this._failure = value; }
        }

        // Check to see if Failure property is set
        internal bool IsSetFailure()
        {
            return this._failure != null;
        }

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        /// Provides test case run log URL.
        /// </para>
        /// </summary>
        public string LogUrl
        {
            get { return this._logUrl; }
            set { this._logUrl = value; }
        }

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this._logUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Provides test case run start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the test case run status. Status is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PASS</c>: Test passed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAIL</c>: Test failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: Test has not started running but is scheduled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: Test is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c>: Test is performing cleanup steps. You will see this status only
        /// if you stop a suite run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> Test is stopped. You will see this status only if you stop a suite
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASS_WITH_WARNINGS</c>: Test passed with warnings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERORR</c>: Test faced an error when running due to an internal issue.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status
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
        /// Gets and sets the property TestCaseDefinitionId. 
        /// <para>
        /// Provides the test case run definition ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string TestCaseDefinitionId
        {
            get { return this._testCaseDefinitionId; }
            set { this._testCaseDefinitionId = value; }
        }

        // Check to see if TestCaseDefinitionId property is set
        internal bool IsSetTestCaseDefinitionId()
        {
            return this._testCaseDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseDefinitionName. 
        /// <para>
        /// Provides the test case run definition name.
        /// </para>
        /// </summary>
        public string TestCaseDefinitionName
        {
            get { return this._testCaseDefinitionName; }
            set { this._testCaseDefinitionName = value; }
        }

        // Check to see if TestCaseDefinitionName property is set
        internal bool IsSetTestCaseDefinitionName()
        {
            return this._testCaseDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseRunId. 
        /// <para>
        /// Provides the test case run ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string TestCaseRunId
        {
            get { return this._testCaseRunId; }
            set { this._testCaseRunId = value; }
        }

        // Check to see if TestCaseRunId property is set
        internal bool IsSetTestCaseRunId()
        {
            return this._testCaseRunId != null;
        }

        /// <summary>
        /// Gets and sets the property TestScenarios. 
        /// <para>
        ///  Provides the test scenarios for the test case run. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TestCaseScenario> TestScenarios
        {
            get { return this._testScenarios; }
            set { this._testScenarios = value; }
        }

        // Check to see if TestScenarios property is set
        internal bool IsSetTestScenarios()
        {
            return this._testScenarios != null && (this._testScenarios.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Provides test case run warnings.
        /// </para>
        /// </summary>
        public string Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null;
        }

    }
}