/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpcPeeringConnections operation.
    /// Describes one or more of your VPC peering connections.
    /// </summary>
    public partial class DescribeVpcPeeringConnectionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _vpcPeeringConnectionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>accepter-vpc-info.cidr-block</code> - The CIDR block of the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>accepter-vpc-info.owner-id</code> - The AWS account ID of the owner of the peer
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>accepter-vpc-info.vpc-id</code> - The ID of the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>expiration-time</code> - The expiration date and time for the VPC peering connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>requester-vpc-info.cidr-block</code> - The CIDR block of the requester's VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>requester-vpc-info.owner-id</code> - The AWS account ID of the owner of the
        /// requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>requester-vpc-info.vpc-id</code> - The ID of the requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status-code</code> - The status of the VPC peering connection (<code>pending-acceptance</code>
        /// | <code>failed</code> | <code>expired</code> | <code>provisioning</code> | <code>active</code>
        /// | <code>deleted</code> | <code>rejected</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status-message</code> - A message that provides more information about the status
        /// of the VPC peering connection, if applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-peering-connection-id</code> - The ID of the VPC peering connection.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionIds. 
        /// <para>
        /// One or more VPC peering connection IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your VPC peering connections.
        /// </para>
        /// </summary>
        public List<string> VpcPeeringConnectionIds
        {
            get { return this._vpcPeeringConnectionIds; }
            set { this._vpcPeeringConnectionIds = value; }
        }

        // Check to see if VpcPeeringConnectionIds property is set
        internal bool IsSetVpcPeeringConnectionIds()
        {
            return this._vpcPeeringConnectionIds != null && this._vpcPeeringConnectionIds.Count > 0; 
        }

    }
}