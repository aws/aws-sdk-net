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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the TestNoPayload operation.
    /// This example operation serializes a request without an HTTP body.
    /// 
    ///  
    /// <para>
    /// These tests are to ensure we do not attach a body or related headers (Content-Length,
    /// Content-Type) to operations that semantically cannot produce an HTTP body.
    /// </para>
    /// </summary>
    public partial class TestNoPayloadRequest : AmazonRestJsonProtocolRequest
    {
        private string _testId;

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