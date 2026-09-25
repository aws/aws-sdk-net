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
    /// Provides test case scenario.
    /// </summary>
    public partial class TestCaseScenario
    {
        /// <summary>
        /// Gets and sets the property Failure. 
        /// <para>
        /// Provides test case scenario failure result.
        /// </para>
        /// </summary>
        public string Failure { get; set; }

        /// <summary>
        /// Checks to see if the Failure property is set.
        /// </summary>
        internal bool IsSetFailure() => this.Failure != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the test case scenario status. Status is one of the following:
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
        public TestCaseScenarioStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemMessage. 
        /// <para>
        /// Provides test case scenario system messages if any.
        /// </para>
        /// </summary>
        public string SystemMessage { get; set; }

        /// <summary>
        /// Checks to see if the SystemMessage property is set.
        /// </summary>
        internal bool IsSetSystemMessage() => this.SystemMessage != null;

        /// <summary>
        /// Gets and sets the property TestCaseScenarioId. 
        /// <para>
        /// Provides test case scenario ID.
        /// </para>
        /// </summary>
        public string TestCaseScenarioId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseScenarioId property is set.
        /// </summary>
        internal bool IsSetTestCaseScenarioId() => this.TestCaseScenarioId != null;

        /// <summary>
        /// Gets and sets the property TestCaseScenarioType. 
        /// <para>
        /// Provides test case scenario type. Type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Advanced
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Basic
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TestCaseScenarioType TestCaseScenarioType { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseScenarioType property is set.
        /// </summary>
        internal bool IsSetTestCaseScenarioType() => this.TestCaseScenarioType != null;
    }
}
