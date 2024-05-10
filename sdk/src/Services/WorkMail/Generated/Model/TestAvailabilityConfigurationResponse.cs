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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the TestAvailabilityConfiguration operation.
    /// </summary>
    public partial class TestAvailabilityConfigurationResponse : AmazonWebServiceResponse
    {
        private string _failureReason;
        private bool? _testPassed;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// String containing the reason for a failed test if <c>TestPassed</c> is false.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property TestPassed. 
        /// <para>
        /// Boolean indicating whether the test passed or failed.
        /// </para>
        /// </summary>
        public bool? TestPassed
        {
            get { return this._testPassed; }
            set { this._testPassed = value; }
        }

        // Check to see if TestPassed property is set
        internal bool IsSetTestPassed()
        {
            return this._testPassed.HasValue; 
        }

    }
}