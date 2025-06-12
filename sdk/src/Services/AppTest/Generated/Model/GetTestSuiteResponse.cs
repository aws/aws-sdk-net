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
    /// This is the response object from the GetTestSuite operation.
    /// </summary>
    public partial class GetTestSuiteResponse : AmazonWebServiceResponse
    {
        private List<Step> _afterSteps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private List<Step> _beforeSteps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _lastUpdateTime;
        private TestSuiteLatestVersion _latestVersion;
        private string _name;
        private TestSuiteLifecycle _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TestCases _testCases;
        private string _testSuiteArn;
        private string _testSuiteId;
        private int? _testSuiteVersion;

        /// <summary>
        /// Gets and sets the property AfterSteps. 
        /// <para>
        /// The after steps of the test suite. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Step> AfterSteps
        {
            get { return this._afterSteps; }
            set { this._afterSteps = value; }
        }

        // Check to see if AfterSteps property is set
        internal bool IsSetAfterSteps()
        {
            return this._afterSteps != null && (this._afterSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BeforeSteps. 
        /// <para>
        /// The before steps of the test suite.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Step> BeforeSteps
        {
            get { return this._beforeSteps; }
            set { this._beforeSteps = value; }
        }

        // Check to see if BeforeSteps property is set
        internal bool IsSetBeforeSteps()
        {
            return this._beforeSteps != null && (this._beforeSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last update time of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The latest version of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestSuiteLatestVersion LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the test suite.
        /// </para>
        /// </summary>
        public TestSuiteLifecycle Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the test suite.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the test suite.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property TestCases. 
        /// <para>
        /// The test cases of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestCases TestCases
        {
            get { return this._testCases; }
            set { this._testCases = value; }
        }

        // Check to see if TestCases property is set
        internal bool IsSetTestCases()
        {
            return this._testCases != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteArn. 
        /// <para>
        /// The test suite Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestSuiteArn
        {
            get { return this._testSuiteArn; }
            set { this._testSuiteArn = value; }
        }

        // Check to see if TestSuiteArn property is set
        internal bool IsSetTestSuiteArn()
        {
            return this._testSuiteArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The response ID of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestSuiteId
        {
            get { return this._testSuiteId; }
            set { this._testSuiteId = value; }
        }

        // Check to see if TestSuiteId property is set
        internal bool IsSetTestSuiteId()
        {
            return this._testSuiteId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteVersion. 
        /// <para>
        /// The version of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TestSuiteVersion
        {
            get { return this._testSuiteVersion; }
            set { this._testSuiteVersion = value; }
        }

        // Check to see if TestSuiteVersion property is set
        internal bool IsSetTestSuiteVersion()
        {
            return this._testSuiteVersion.HasValue; 
        }

    }
}