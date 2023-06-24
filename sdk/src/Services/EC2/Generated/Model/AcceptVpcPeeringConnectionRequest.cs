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
    /// Container for the parameters to the AcceptVpcPeeringConnection operation.
    /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
    /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
    /// the peer VPC. Use <a>DescribeVpcPeeringConnections</a> to view your outstanding VPC
    /// peering connection requests.
    /// 
    ///  
    /// <para>
    /// For an inter-Region VPC peering connection request, you must accept the VPC peering
    /// connection in the Region of the accepter VPC.
    /// </para>
    /// </summary>
    public partial class AcceptVpcPeeringConnectionRequest : AmazonEC2Request
    {
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection. You must specify this parameter in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}