/*******************************************************************************
 * Copyright 2008-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpcPeeringConnections operation.
    /// <para>Describes one or more of your VPC peering connections.</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVpcPeeringConnectionsRequest : EC2Request
    {
        private List<string> vpcPeeringConnectionIdsField;
        private List<Filter> filtersField;

        /// <summary>
        /// One or more VPC peering connection IDs. Default: Describes all your VPC peering connections.
        ///  
        /// </summary>
        public List<string> VpcPeeringConnectionIds
        {
            get
            {
                if (this.vpcPeeringConnectionIdsField == null)
                {
                    this.vpcPeeringConnectionIdsField = new List<string>();
                }
                return this.vpcPeeringConnectionIdsField;
            }
            set { this.vpcPeeringConnectionIdsField = value; }
        }
        
        /// <summary>
        /// Sets the VpcPeeringConnectionIds
        /// <param name="list">The VpcPeeringConnectionIds.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVpcPeeringConnectionsRequest WithVpcPeeringConnectionIds(params string[] list)
        {
            foreach (string item in list)
            {
                VpcPeeringConnectionIds.Add(item);
            }
            return this;
        }
        
        /// <summary>
        /// Checks if VpcPeeringConnectionIds is set
        /// </summary>
        /// <returns>true if VpcPeeringConnectionIds property is set</returns>
        public bool IsSetVpcPeeringConnectionIds()
        {
            return (VpcPeeringConnectionIds.Count > 0);
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>accepter-vpc-info.cidr-block</c> - The CIDR block of the peer VPC. </li> <li>
        /// <c>accepter-vpc-info.owner-id</c> - The AWS account ID of the owner of the peer VPC. </li> <li> <c>accepter-vpc-info.vpc-id</c> - The ID of
        /// the peer VPC. </li> <li> <c>expiration-time</c> - The expiration date and time for the VPC peering connection. </li> <li>
        /// <c>requester-vpc-info.cidr-block</c> - The CIDR block of the requester's VPC. </li> <li> <c>requester-vpc-info.owner-id</c> - The AWS
        /// account ID of the owner of the requester VPC. </li> <li> <c>requester-vpc-info.vpc-id</c> - The ID of the requester VPC. </li> <li>
        /// <c>status-code</c> - The status of the VPC peering connection (<c>pending-acceptance</c> | <c>failed</c> | <c>expired</c> |
        /// <c>provisioning</c> | <c>active</c> | <c>deleted</c> | <c>rejected</c>). </li> <li> <c>status-message</c> - A message that provides more
        /// information about the status of the VPC peering connection, if applicable. </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value
        /// combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you get
        /// any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the tag's
        /// key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>vpc-peering-connection-id</c> - The ID of the VPC peering connection. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get
            {
                if (this.filtersField == null)
                {
                    this.filtersField = new List<Filter>();
                }
                return this.filtersField;
            }
            set { this.filtersField = value; }
        }
        
        /// <summary>
        /// Sets the Filters
        /// <param name="list">The Filters.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVpcPeeringConnectionsRequest WithFilters(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filters.Add(item);
            }
            return this;
        }
        
        /// <summary>
        /// Checks if Filters is set
        /// </summary>
        /// <returns>true if Filters property is set</returns>
        public bool IsSetFilters()
        {
            return (Filters.Count > 0);
        }
        
    }
}
