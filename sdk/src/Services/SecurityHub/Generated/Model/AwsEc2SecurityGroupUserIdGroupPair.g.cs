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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A relationship between a security group and a user.
    /// </summary>
    public partial class AwsEc2SecurityGroupUserIdGroupPair
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the security group.
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property PeeringStatus. 
        /// <para>
        /// The status of a VPC peering connection, if applicable.
        /// </para>
        /// </summary>
        public string PeeringStatus { get; set; }

        /// <summary>
        /// Checks to see if the PeeringStatus property is set.
        /// </summary>
        internal bool IsSetPeeringStatus() => this.PeeringStatus != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of an Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// For a referenced security group in another VPC, the account ID of the referenced security
        /// group is returned in the response. If the referenced security group is deleted, this
        /// value is not returned.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] Required when adding or removing rules that reference a security group
        /// in another VPC. 
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the referenced security group, if applicable.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection, if applicable.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetVpcPeeringConnectionId() => this.VpcPeeringConnectionId != null;
    }
}
