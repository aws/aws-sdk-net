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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2InstanceConnect.Model
{
    /// <summary>
    /// This is the response object from the SendSSHPublicKey operation.
    /// </summary>
    public partial class SendSSHPublicKeyResponse : AmazonWebServiceResponse
    {
        private string _requestId;
        private bool? _success;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID as logged by EC2 Connect. Please provide this when contacting AWS Support.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// Indicates request success.
        /// </para>
        /// </summary>
        public bool Success
        {
            get { return this._success.GetValueOrDefault(); }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success.HasValue; 
        }

    }
}