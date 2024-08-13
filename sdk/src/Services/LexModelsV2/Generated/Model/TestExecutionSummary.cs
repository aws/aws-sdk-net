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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Summarizes metadata about the test execution.
    /// </summary>
    public partial class TestExecutionSummary
    {
        private TestExecutionApiMode _apiMode;
        private DateTime? _creationDateTime;
        private DateTime? _lastUpdatedDateTime;
        private TestExecutionTarget _target;
        private string _testExecutionId;
        private TestExecutionModality _testExecutionModality;
        private TestExecutionStatus _testExecutionStatus;
        private string _testSetId;
        private string _testSetName;

        /// <summary>
        /// Gets and sets the property ApiMode. 
        /// <para>
        /// Specifies whether the API mode for the test execution is streaming or non-streaming.
        /// </para>
        /// </summary>
        public TestExecutionApiMode ApiMode
        {
            get { return this._apiMode; }
            set { this._apiMode = value; }
        }

        // Check to see if ApiMode property is set
        internal bool IsSetApiMode()
        {
            return this._apiMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time at which the test execution was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time at which the test execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Contains information about the bot used for the test execution..
        /// </para>
        /// </summary>
        public TestExecutionTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TestExecutionId. 
        /// <para>
        /// The unique identifier of the test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestExecutionId
        {
            get { return this._testExecutionId; }
            set { this._testExecutionId = value; }
        }

        // Check to see if TestExecutionId property is set
        internal bool IsSetTestExecutionId()
        {
            return this._testExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property TestExecutionModality. 
        /// <para>
        /// Specifies whether the data used for the test execution is written or spoken.
        /// </para>
        /// </summary>
        public TestExecutionModality TestExecutionModality
        {
            get { return this._testExecutionModality; }
            set { this._testExecutionModality = value; }
        }

        // Check to see if TestExecutionModality property is set
        internal bool IsSetTestExecutionModality()
        {
            return this._testExecutionModality != null;
        }

        /// <summary>
        /// Gets and sets the property TestExecutionStatus. 
        /// <para>
        /// The current status of the test execution.
        /// </para>
        /// </summary>
        public TestExecutionStatus TestExecutionStatus
        {
            get { return this._testExecutionStatus; }
            set { this._testExecutionStatus = value; }
        }

        // Check to see if TestExecutionStatus property is set
        internal bool IsSetTestExecutionStatus()
        {
            return this._testExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The unique identifier of the test set used in the test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestSetId
        {
            get { return this._testSetId; }
            set { this._testSetId = value; }
        }

        // Check to see if TestSetId property is set
        internal bool IsSetTestSetId()
        {
            return this._testSetId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The name of the test set used in the test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TestSetName
        {
            get { return this._testSetName; }
            set { this._testSetName = value; }
        }

        // Check to see if TestSetName property is set
        internal bool IsSetTestSetName()
        {
            return this._testSetName != null;
        }

    }
}