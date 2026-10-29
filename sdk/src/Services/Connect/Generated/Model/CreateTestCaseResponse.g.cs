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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the CreateTestCase operation.
    /// </summary>
    public partial class CreateTestCaseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TestCaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the test.
        /// </para>
        /// </summary>
        public string TestCaseArn { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseArn property is set.
        /// </summary>
        internal bool IsSetTestCaseArn() => this.TestCaseArn != null;

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The identifier of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseId property is set.
        /// </summary>
        internal bool IsSetTestCaseId() => this.TestCaseId != null;
    }
}
