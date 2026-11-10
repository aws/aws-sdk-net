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
    /// Describes a security group and Amazon Web Services account ID pair.
    /// </summary>
    public partial class UserIdGroupPair
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the security group rule that references this user ID group pair.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. Allowed characters are a-z, A-Z, 0-9,
        /// spaces, and ._-:/()#,@[]+=;{}!$*
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// [Default VPC] The name of the security group. For a security group in a nondefault
        /// VPC, use the security group ID. 
        /// </para>
        ///  
        /// <para>
        /// For a referenced security group in another VPC, this value is not returned if the
        /// referenced security group is deleted.
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
