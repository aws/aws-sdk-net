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
 * Do not modify this file. This file is generated from the bearer-token-auth-test-2022-03-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.BearerTokenAuthTest.Model
{
    /// <summary>
    /// Container for the parameters to the OverrideAuthToSigV4Operation operation.
    /// An operation that overrides auth to Sigv4.
    /// </summary>
    public partial class OverrideAuthToSigV4OperationRequest : AmazonBearerTokenAuthTestRequest
    {
        private string _testId;

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        ///  The unique ID for a test. 
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

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }
    }
}