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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the DescribeTestCase operation.
    /// </summary>
    public partial class DescribeTestCaseResponse : AmazonWebServiceResponse
    {
        private TestCase _testCase;

        /// <summary>
        /// Gets and sets the property TestCase. 
        /// <para>
        /// The test case object containing all test case information.
        /// </para>
        /// </summary>
        public TestCase TestCase
        {
            get { return this._testCase; }
            set { this._testCase = value; }
        }

        // Check to see if TestCase property is set
        internal bool IsSetTestCase()
        {
            return this._testCase != null;
        }

    }
}