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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the TestBodyStructure operation.
    /// This example operation serializes a structure in the HTTP body.
    /// 
    ///  
    /// <para>
    /// It should ensure Content-Type: application/json is used in all requests and that an
    /// &quot;empty&quot; body is an empty JSON document ({}).
    /// </para>
    /// </summary>
    public partial class TestBodyStructureRequest : AmazonRestJsonProtocolRequest
    {
        private TestConfig _testConfig;
        private string _testId;

        /// <summary>
        /// Gets and sets the property TestConfig.
        /// </summary>
        public TestConfig TestConfig
        {
            get { return this._testConfig; }
            set { this._testConfig = value; }
        }

        // Check to see if TestConfig property is set
        internal bool IsSetTestConfig()
        {
            return this._testConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TestId.
        /// </summary>
        public string TestId
        {
            get { return this._testId; }
            set { this._testId = value; }
        }

        // Check to see if TestId property is set
        internal bool IsSetTestId()
        {
            return this._testId != null;
        }

    }
}