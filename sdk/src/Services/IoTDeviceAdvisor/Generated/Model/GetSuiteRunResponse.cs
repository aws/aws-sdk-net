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
    /// This is the response object from the GetSuiteRun operation.
    /// </summary>
    public partial class GetSuiteRunResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private string _errorReason;
        private DateTime? _startTime;
        private SuiteRunStatus _status;
        private string _suiteDefinitionId;
        private string _suiteDefinitionVersion;
        private string _suiteRunArn;
        private SuiteRunConfiguration _suiteRunConfiguration;
        private string _suiteRunId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TestResult _testResult;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Date (in Unix epoch time) when the test suite run ended.
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
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// Error reason for any test suite run failure.
        /// </para>
        /// </summary>
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Date (in Unix epoch time) when the test suite run started.
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
        /// Status for the test suite run.
        /// </para>
        /// </summary>
        public SuiteRunStatus Status
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
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string SuiteDefinitionId
        {
            get { return this._suiteDefinitionId; }
            set { this._suiteDefinitionId = value; }
        }

        // Check to see if SuiteDefinitionId property is set
        internal bool IsSetSuiteDefinitionId()
        {
            return this._suiteDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=255)]
        public string SuiteDefinitionVersion
        {
            get { return this._suiteDefinitionVersion; }
            set { this._suiteDefinitionVersion = value; }
        }

        // Check to see if SuiteDefinitionVersion property is set
        internal bool IsSetSuiteDefinitionVersion()
        {
            return this._suiteDefinitionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteRunArn. 
        /// <para>
        /// The ARN of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SuiteRunArn
        {
            get { return this._suiteRunArn; }
            set { this._suiteRunArn = value; }
        }

        // Check to see if SuiteRunArn property is set
        internal bool IsSetSuiteRunArn()
        {
            return this._suiteRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteRunConfiguration. 
        /// <para>
        /// Suite run configuration for the test suite run.
        /// </para>
        /// </summary>
        public SuiteRunConfiguration SuiteRunConfiguration
        {
            get { return this._suiteRunConfiguration; }
            set { this._suiteRunConfiguration = value; }
        }

        // Check to see if SuiteRunConfiguration property is set
        internal bool IsSetSuiteRunConfiguration()
        {
            return this._suiteRunConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteRunId. 
        /// <para>
        /// Suite run ID for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string SuiteRunId
        {
            get { return this._suiteRunId; }
            set { this._suiteRunId = value; }
        }

        // Check to see if SuiteRunId property is set
        internal bool IsSetSuiteRunId()
        {
            return this._suiteRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the suite run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property TestResult. 
        /// <para>
        /// Test results for the test suite run.
        /// </para>
        /// </summary>
        public TestResult TestResult
        {
            get { return this._testResult; }
            set { this._testResult = value; }
        }

        // Check to see if TestResult property is set
        internal bool IsSetTestResult()
        {
            return this._testResult != null;
        }

    }
}