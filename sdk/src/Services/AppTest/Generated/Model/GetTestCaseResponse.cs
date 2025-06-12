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
    /// This is the response object from the GetTestCase operation.
    /// </summary>
    public partial class GetTestCaseResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _lastUpdateTime;
        private TestCaseLatestVersion _latestVersion;
        private string _name;
        private TestCaseLifecycle _status;
        private string _statusReason;
        private List<Step> _steps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _testCaseArn;
        private string _testCaseId;
        private int? _testCaseVersion;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the test case.
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
        /// The description of the test case.
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
        /// The last update time of the test case.
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
        /// The latest version of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestCaseLatestVersion LatestVersion
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
        /// The name of the test case.
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
        /// The status of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestCaseLifecycle Status
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
        /// The status reason of the test case.
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
        /// Gets and sets the property Steps. 
        /// <para>
        /// The steps of the test case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Step> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the test case.
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
        /// Gets and sets the property TestCaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestCaseArn
        {
            get { return this._testCaseArn; }
            set { this._testCaseArn = value; }
        }

        // Check to see if TestCaseArn property is set
        internal bool IsSetTestCaseArn()
        {
            return this._testCaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The response test ID of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TestCaseVersion. 
        /// <para>
        /// The case version of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TestCaseVersion
        {
            get { return this._testCaseVersion; }
            set { this._testCaseVersion = value; }
        }

        // Check to see if TestCaseVersion property is set
        internal bool IsSetTestCaseVersion()
        {
            return this._testCaseVersion.HasValue; 
        }

    }
}