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
    /// Information about the suite run.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SuiteRunInformation</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class SuiteRunInformation
    {
        private DateTime? _createdAt;
        private DateTime? _endAt;
        private int? _failed;
        private int? _passed;
        private DateTime? _startedAt;
        private SuiteRunStatus _status;
        private string _suiteDefinitionId;
        private string _suiteDefinitionName;
        private string _suiteDefinitionVersion;
        private string _suiteRunId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run ended.
        /// </para>
        /// </summary>
        public DateTime? EndAt
        {
            get { return this._endAt; }
            set { this._endAt = value; }
        }

        // Check to see if EndAt property is set
        internal bool IsSetEndAt()
        {
            return this._endAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Number of test cases that failed in the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// Number of test cases that passed in the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? Passed
        {
            get { return this._passed; }
            set { this._passed = value; }
        }

        // Check to see if Passed property is set
        internal bool IsSetPassed()
        {
            return this._passed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the suite run.
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
        /// Suite definition ID of the suite run.
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
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Suite definition name of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SuiteDefinitionName
        {
            get { return this._suiteDefinitionName; }
            set { this._suiteDefinitionName = value; }
        }

        // Check to see if SuiteDefinitionName property is set
        internal bool IsSetSuiteDefinitionName()
        {
            return this._suiteDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version of the suite run.
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
        /// Gets and sets the property SuiteRunId. 
        /// <para>
        /// Suite run ID of the suite run.
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

    }
}