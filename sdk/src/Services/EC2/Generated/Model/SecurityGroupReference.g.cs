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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a VPC with a security group that references your security group.
    /// </summary>
    public partial class SecurityGroupReference
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of your security group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property ReferencingVpcId. 
        /// <para>
        /// The ID of the VPC with the referencing security group.
        /// </para>
        /// </summary>
        public string ReferencingVpcId { get; set; }

        /// <summary>
        /// Checks to see if the ReferencingVpcId property is set.
        /// </summary>
        internal bool IsSetReferencingVpcId() => this.ReferencingVpcId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway (if applicable).
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection (if applicable). For more information about security
        /// group referencing for peering connections, see <a href="https://docs.aws.amazon.com/vpc/latest/peering/vpc-peering-security-groups.html">Update
        /// your security groups to reference peer security groups</a> in the <i>VPC Peering Guide</i>.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetVpcPeeringConnectionId() => this.VpcPeeringConnectionId != null;
    }
}
