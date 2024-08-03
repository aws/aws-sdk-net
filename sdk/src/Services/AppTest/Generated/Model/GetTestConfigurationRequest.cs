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
    /// Container for the parameters to the GetTestConfiguration operation.
    /// Gets a test configuration.
    /// </summary>
    public partial class GetTestConfigurationRequest : AmazonAppTestRequest
    {
        private string _testConfigurationId;
        private int? _testConfigurationVersion;

        /// <summary>
        /// Gets and sets the property TestConfigurationId. 
        /// <para>
        /// The request test configuration ID.
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

        /// <summary>
        /// Gets and sets the property TestConfigurationVersion. 
        /// <para>
        /// The test configuration version.
        /// </para>
        /// </summary>
        public int? TestConfigurationVersion
        {
            get { return this._testConfigurationVersion; }
            set { this._testConfigurationVersion = value; }
        }

        // Check to see if TestConfigurationVersion property is set
        internal bool IsSetTestConfigurationVersion()
        {
            return this._testConfigurationVersion.HasValue; 
        }

    }
}