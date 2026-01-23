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
    /// Contains information about a test case execution.
    /// </summary>
    public partial class TestCaseExecution
    {
        private DateTime? _endTime;
        private DateTime? _startTime;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _testCaseExecutionId;
        private TestCaseExecutionStatus _testCaseExecutionStatus;
        private string _testCaseId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the test case execution ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the test case execution started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property TestCaseExecutionStatus. 
        /// <para>
        /// The status of the test case execution.
        /// </para>
        /// </summary>
        public TestCaseExecutionStatus TestCaseExecutionStatus
        {
            get { return this._testCaseExecutionStatus; }
            set { this._testCaseExecutionStatus = value; }
        }

        // Check to see if TestCaseExecutionStatus property is set
        internal bool IsSetTestCaseExecutionStatus()
        {
            return this._testCaseExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The identifier of the test case.
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