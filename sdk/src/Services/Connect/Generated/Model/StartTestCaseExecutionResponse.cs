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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the StartTestCaseExecution operation.
    /// </summary>
    public partial class StartTestCaseExecutionResponse : AmazonWebServiceResponse
    {
        private TestCaseExecutionStatus _status;
        private string _testCaseExecutionId;
        private string _testCaseId;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public TestCaseExecutionStatus Status
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
        /// Gets and sets the property TestCaseExecutionId. 
        /// <para>
        /// The identifier of the test case execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string TestCaseExecutionId
        {
            get { return this._testCaseExecutionId; }
            set { this._testCaseExecutionId = value; }
        }

        // Check to see if TestCaseExecutionId property is set
        internal bool IsSetTestCaseExecutionId()
        {
            return this._testCaseExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The identifier of the test case resource that was executed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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

    }
}