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
    /// This is the response object from the UpdateTestSuite operation.
    /// </summary>
    public partial class UpdateTestSuiteResponse : AmazonWebServiceResponse
    {
        private string _testSuiteId;
        private int? _testSuiteVersion;

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The test suite ID of the test suite.
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
        /// The test suite version of the test suite.
        /// </para>
        /// </summary>
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