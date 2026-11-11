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
    /// A security group association with a VPC that you made with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateSecurityGroupVpc.html">AssociateSecurityGroupVpc</a>.
    /// </summary>
    public partial class SecurityGroupVpcAssociation
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The association's security group ID.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the security group.
        /// </para>
        /// </summary>
        public string GroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the GroupOwnerId property is set.
        /// </summary>
        internal bool IsSetGroupOwnerId() => this.GroupOwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The association's state.
        /// </para>
        /// </summary>
        public SecurityGroupVpcAssociationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The association's state reason.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The association's VPC ID.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpcOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the VPC.
        /// </para>
        /// </summary>
        public string VpcOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the VpcOwnerId property is set.
        /// </summary>
        internal bool IsSetVpcOwnerId() => this.VpcOwnerId != null;
    }
}
