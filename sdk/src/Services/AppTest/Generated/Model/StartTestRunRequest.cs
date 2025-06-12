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
    /// Container for the parameters to the StartTestRun operation.
    /// Starts a test run.
    /// </summary>
    public partial class StartTestRunRequest : AmazonAppTestRequest
    {
        private string _clientToken;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _testConfigurationId;
        private string _testSuiteId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token of the test run.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the test run.
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
        /// Gets and sets the property TestConfigurationId. 
        /// <para>
        /// The configuration ID of the test run.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The test suite ID of the test run.
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

    }
}