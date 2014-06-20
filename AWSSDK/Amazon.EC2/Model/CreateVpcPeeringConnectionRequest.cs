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
    /// Container for the parameters to the DeleteVolume operation.
    /// <para>Deletes the specified Amazon EBS volume. The volume must be in the <c>available</c> state (not attached to an instance).</para>
    /// <para><b>NOTE:</b> The volume may remain in the deleting state for several minutes. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html" >Deleting an Amazon EBS Volume</a> in the <i>Amazon
    /// Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVpcPeeringConnectionRequest : EC2Request
    {
        private string vpcIdField;
        private string peerVpcIdField;
        private string peerOwnerIdField;

        /// <summary>
        /// The ID of the requester VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }
        
        /// <summary>
        /// Sets the VpcId
        /// <param name="vpcId">The VpcId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVpcPeeringConnectionRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }
        
        /// <summary>
        /// Checks if VpcId is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// The ID of the VPC with which you are creating the VPC peering connection.
        ///  
        /// </summary>
        public string PeerVpcId
        {
            get { return this.peerVpcIdField; }
            set { this.peerVpcIdField = value; }
        }
        
        /// <summary>
        /// Sets the PeerVpcId
        /// <param name="peerVpcId">The PeerVpcId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVpcPeeringConnectionRequest WithPeerVpcId(string peerVpcId)
        {
            this.peerVpcIdField = peerVpcId;
            return this;
        }
        
        /// <summary>
        /// Checks if PeerVpcId is set
        /// </summary>
        /// <returns>true if PeerVpcId property is set</returns>
        public bool IsSetPeerVpcId()
        {
            return this.peerVpcIdField != null;
        }

        /// <summary>
        /// The AWS account ID of the owner of the peer VPC. Default: Your AWS account ID
        ///  
        /// </summary>
        public string PeerOwnerId
        {
            get { return this.peerOwnerIdField; }
            set { this.peerOwnerIdField = value; }
        }
        
        /// <summary>
        /// Sets the PeerOwnerId
        /// <param name="peerOwnerId">The PeerOwnerId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVpcPeeringConnectionRequest WithPeerOwnerId(string peerOwnerId)
        {
            this.peerOwnerIdField = peerOwnerId;
            return this;
        }
        
        /// <summary>
        /// Checks if PeerOwnerId is set
        /// </summary>
        /// <returns>true if PeerOwnerId property is set</returns>
        public bool IsSetPeerOwnerId()
        {
            return this.peerOwnerIdField != null;
        }
        
    }
}
