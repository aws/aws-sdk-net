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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateMacSecKey operation. Removes the association
    /// between a MAC Security (MACsec) security key and a Direct Connect connection.
    /// </summary>
    public partial class DisassociateMacSecKeyRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the dedicated connection (dxcon-xxxx), interconnect (dxcon-xxxx), or LAG
        /// (dxlag-xxxx).
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeConnections</a>, <a>DescribeInterconnects</a>, or <a>DescribeLags</a>
        /// to retrieve connection ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property SecretARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MAC Security (MACsec) secret key.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeConnections</a> to retrieve the ARN of the MAC Security (MACsec)
        /// secret key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretARN { get; set; }

        /// <summary>
        /// Checks to see if the SecretARN property is set.
        /// </summary>
        internal bool IsSetSecretARN() => this.SecretARN != null;
    }
}
