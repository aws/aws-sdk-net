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
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
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
namespace Amazon.RestJsonTest.Model
{
    /// <summary>
    /// Container for the parameters to the TestPayload operation.
    /// Post a test payload request.
    /// </summary>
    public partial class TestPayloadRequest : AmazonRestJsonTestRequest
    {
        private PayloadConfig _payloadConfig;
        private string _testId;

        /// <summary>
        /// Gets and sets the property PayloadConfig. 
        /// <para>
        ///  Payload to post 
        /// </para>
        /// </summary>
        public PayloadConfig PayloadConfig
        {
            get { return this._payloadConfig; }
            set { this._payloadConfig = value; }
        }

        // Check to see if PayloadConfig property is set
        internal bool IsSetPayloadConfig()
        {
            return this._payloadConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        ///  Optional test identifier 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=8)]
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