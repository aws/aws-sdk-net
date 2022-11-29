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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetVerifiedAccessEndpointPolicy operation.
    /// Get the Verified Access policy associated with the endpoint.
    /// </summary>
    public partial class GetVerifiedAccessEndpointPolicyRequest : AmazonEC2Request
    {
        private string _verifiedAccessEndpointId;

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessEndpointId
        {
            get { return this._verifiedAccessEndpointId; }
            set { this._verifiedAccessEndpointId = value; }
        }

        // Check to see if VerifiedAccessEndpointId property is set
        internal bool IsSetVerifiedAccessEndpointId()
        {
            return this._verifiedAccessEndpointId != null;
        }

    }
}