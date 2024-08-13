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
    /// Specifies a test configuration summary.
    /// </summary>
    public partial class TestConfigurationSummary
    {
        private DateTime? _creationTime;
        private DateTime? _lastUpdateTime;
        private int? _latestVersion;
        private string _name;
        private TestConfigurationLifecycle _status;
        private string _statusReason;
        private string _testConfigurationArn;
        private string _testConfigurationId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the test configuration summary.
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
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last update time of the test configuration summary.
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
        /// The latest version of the test configuration summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the test configuration summary.
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
        /// The status of the test configuration summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestConfigurationLifecycle Status
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
        /// The status reason of the test configuration summary.
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
        /// Gets and sets the property TestConfigurationArn. 
        /// <para>
        /// The test configuration ARN of the test configuration summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestConfigurationArn
        {
            get { return this._testConfigurationArn; }
            set { this._testConfigurationArn = value; }
        }

        // Check to see if TestConfigurationArn property is set
        internal bool IsSetTestConfigurationArn()
        {
            return this._testConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestConfigurationId. 
        /// <para>
        /// The test configuration ID of the test configuration summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestConfigurationId
        {
            get { return this._testConfigurationId; }
            set { this._testConfigurationId = value; }
        }

        // Check to see if TestConfigurationId property is set
        internal bool IsSetTestConfigurationId()
        {
            return this._testConfigurationId != null;
        }

    }
}