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
    /// This is the response object from the StartTestRun operation.
    /// </summary>
    public partial class StartTestRunResponse : AmazonWebServiceResponse
    {
        private string _testRunId;
        private TestRunStatus _testRunStatus;

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The test run ID of the test run.
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
        /// Gets and sets the property TestRunStatus. 
        /// <para>
        /// The test run status of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestRunStatus TestRunStatus
        {
            get { return this._testRunStatus; }
            set { this._testRunStatus = value; }
        }

        // Check to see if TestRunStatus property is set
        internal bool IsSetTestRunStatus()
        {
            return this._testRunStatus != null;
        }

    }
}