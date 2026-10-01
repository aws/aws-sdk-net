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

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Provides the test case run.
    /// </summary>
    public partial class TestCaseRun
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Provides test case run end time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Failure. 
        /// <para>
        /// Provides test case run failure result.
        /// </para>
        /// </summary>
        public string Failure { get; set; }

        /// <summary>
        /// Checks to see if the Failure property is set.
        /// </summary>
        internal bool IsSetFailure() => this.Failure != null;

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        /// Provides test case run log URL.
        /// </para>
        /// </summary>
        public string LogUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogUrl property is set.
        /// </summary>
        internal bool IsSetLogUrl() => this.LogUrl != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Provides test case run start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestCaseDefinitionId. 
        /// <para>
        /// Provides the test case run definition ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseDefinitionId property is set.
        /// </summary>
        internal bool IsSetTestCaseDefinitionId() => this.TestCaseDefinitionId != null;

        /// <summary>
        /// Gets and sets the property TestCaseDefinitionName. 
        /// <para>
        /// Provides the test case run definition name.
        /// </para>
        /// </summary>
        public string TestCaseDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseDefinitionName property is set.
        /// </summary>
        internal bool IsSetTestCaseDefinitionName() => this.TestCaseDefinitionName != null;

        /// <summary>
        /// Gets and sets the property TestCaseRunId. 
        /// <para>
        /// Provides the test case run ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string TestCaseRunId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseRunId property is set.
        /// </summary>
        internal bool IsSetTestCaseRunId() => this.TestCaseRunId != null;

        /// <summary>
        /// Gets and sets the property TestScenarios. 
        /// <para>
        ///  Provides the test scenarios for the test case run. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TestCaseScenario> TestScenarios { get; set; } = AWSConfigs.InitializeCollections ? new List<TestCaseScenario>() : null;

        /// <summary>
        /// Checks to see if the TestScenarios property is set.
        /// </summary>
        internal bool IsSetTestScenarios() => this.TestScenarios != null && (this.TestScenarios.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Provides test case run warnings.
        /// </para>
        /// </summary>
        public string Warnings { get; set; }

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null;
    }
}
