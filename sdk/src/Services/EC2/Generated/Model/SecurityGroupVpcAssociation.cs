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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A security group association with a VPC that you made with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateSecurityGroupVpc.html">AssociateSecurityGroupVpc</a>.
    /// </summary>
    public partial class SecurityGroupVpcAssociation
    {
        private string _groupId;
        private string _groupOwnerId;
        private SecurityGroupVpcAssociationState _state;
        private string _stateReason;
        private string _vpcId;
        private string _vpcOwnerId;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The association's security group ID.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the security group.
        /// </para>
        /// </summary>
        public string GroupOwnerId
        {
            get { return this._groupOwnerId; }
            set { this._groupOwnerId = value; }
        }

        // Check to see if GroupOwnerId property is set
        internal bool IsSetGroupOwnerId()
        {
            return this._groupOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The association's state.
        /// </para>
        /// </summary>
        public SecurityGroupVpcAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The association's state reason.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The association's VPC ID.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the VPC.
        /// </para>
        /// </summary>
        public string VpcOwnerId
        {
            get { return this._vpcOwnerId; }
            set { this._vpcOwnerId = value; }
        }

        // Check to see if VpcOwnerId property is set
        internal bool IsSetVpcOwnerId()
        {
            return this._vpcOwnerId != null;
        }

    }
}