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
    /// This is the response object from the DescribeTestExecution operation.
    /// </summary>
    public partial class DescribeTestExecutionResponse : AmazonWebServiceResponse
    {
        private TestExecutionApiMode _apiMode;
        private DateTime? _creationDateTime;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// Indicates whether we use streaming or non-streaming APIs are used for the test set
        /// execution. For streaming, <c>StartConversation</c> Amazon Lex Runtime API is used.
        /// Whereas for non-streaming, <c>RecognizeUtterance</c> and <c>RecognizeText</c> Amazon
        /// Lex Runtime API is used.
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
        /// The execution creation date and time for the test set execution.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Reasons for the failure of the test set execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time of the last update for the execution.
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
        /// The target bot for the test set execution details.
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
        /// The execution Id for the test set execution.
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
        /// Indicates whether test set is audio or text.
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
        /// The test execution status for the test execution.
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
        /// The test set Id for the test set execution.
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
        /// The test set name of the test set execution.
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