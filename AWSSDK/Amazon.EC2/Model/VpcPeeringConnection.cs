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
    /// <para>Describes a VPC peering connection.</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpcPeeringConnection
    {
        private string vpcPeeringConnectionIdField;
        private VpcPeeringConnectionVpcInfo requesterVpcInfoField;
        private VpcPeeringConnectionVpcInfo accepterVpcInfoField;
        private VpcPeeringConnectionStateReason statusField;
        private DateTime expirationTimeField;
        private List<ResourceTag> resourceTagsField;

        /// <summary>
        /// The ID of the VPC peering connection.
        ///  
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this.vpcPeeringConnectionIdField; }
            set { this.vpcPeeringConnectionIdField = value; }
        }
        
        /// <summary>
        /// Sets the VpcPeeringConnectionId
        /// <param name="vpcPeeringConnectionId">The VpcPeeringConnectionId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithVpcPeeringConnectionId(string vpcPeeringConnectionId)
        {
            this.vpcPeeringConnectionIdField = vpcPeeringConnectionId;
            return this;
        }
        
        /// <summary>
        /// Checks if VpcPeeringConnectionId is set
        /// </summary>
        /// <returns>true if VpcPeeringConnectionId property is set</returns>
        public bool IsSetVpcPeeringConnectionId()
        {
            return this.vpcPeeringConnectionIdField != null;
        }
        
        /// <summary>
        /// The information of the requester VPC.
        ///  
        /// </summary>
        public VpcPeeringConnectionVpcInfo RequesterVpcInfo
        {
            get { return this.requesterVpcInfoField; }
            set { this.requesterVpcInfoField = value; }
        }
        
        /// <summary>
        /// Sets the RequesterVpcInfo
        /// <param name="requesterVpcInfo">The RequesterVpcInfo.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithRequesterVpcInfo(VpcPeeringConnectionVpcInfo requesterVpcInfo)
        {
            this.requesterVpcInfoField = requesterVpcInfo;
            return this;
        }
        
        /// <summary>
        /// Checks if RequesterVpcInfo is set
        /// </summary>
        /// <returns>true if RequesterVpcInfo property is set</returns>
        public bool IsSetRequesterVpcInfo()
        {
            return this.requesterVpcInfoField != null;
        }
        
        /// <summary>
        /// The information of the peer VPC.
        ///  
        /// </summary>
        public VpcPeeringConnectionVpcInfo AccepterVpcInfo
        {
            get { return this.accepterVpcInfoField; }
            set { this.accepterVpcInfoField = value; }
        }
        
        /// <summary>
        /// Sets the AccepterVpcInfo
        /// <param name="accepterVpcInfo">The AccepterVpcInfo.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithAccepterVpcInfo(VpcPeeringConnectionVpcInfo accepterVpcInfo)
        {
            this.accepterVpcInfoField = accepterVpcInfo;
            return this;
        }
        
        /// <summary>
        /// Checks if AccepterVpcInfo is set
        /// </summary>
        /// <returns>true if AccepterVpcInfo property is set</returns>
        public bool IsSetAccepterVpcInfo()
        {
            return this.accepterVpcInfoField != null;
        }
        
        /// <summary>
        /// The status of the VPC peering connection.
        ///  
        /// </summary>
        public VpcPeeringConnectionStateReason Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
        
        /// <summary>
        /// Sets the Status
        /// <param name="status">The Status.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithStatus(VpcPeeringConnectionStateReason status)
        {
            this.statusField = status;
            return this;
        }
        
        /// <summary>
        /// Checks if Status is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// The time that an unaccepted VPC peering connection will expire.
        ///  
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this.expirationTimeField; }
            set { this.expirationTimeField = value; }
        }
        
        /// <summary>
        /// Sets the ExpirationTime
        /// <param name="expirationTime">The ExpirationTime.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithExpirationTime(DateTime expirationTime)
        {
            this.expirationTimeField = expirationTime;
            return this;
        }
        
        /// <summary>
        /// Checks if ExpirationTime is set
        /// </summary>
        /// <returns>true if ExpirationTime property is set</returns>
        public bool IsSetExpirationTime()
        {
            return this.expirationTimeField != null;
        }
        
        /// <summary>
        /// Any tags assigned to the resource.
        ///  
        /// </summary>
        public List<ResourceTag> ResourceTags
        {
            get
            {
                if (this.resourceTagsField == null)
                {
                    this.resourceTagsField = new List<ResourceTag>();
                }
                return this.resourceTagsField;
            }
            set { this.resourceTagsField = value; }
        }
        
        /// <summary>
        /// Sets the ResourceTags
        /// <param name="list">The ResourceTags.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnection WithResourceTags(params ResourceTag[] list)
        {
            foreach (ResourceTag item in list)
            {
                ResourceTags.Add(item);
            }
            return this;
        }
        
        /// <summary>
        /// Checks if ResourceTags is set
        /// </summary>
        /// <returns>true if ResourceTags property is set</returns>
        public bool IsSetResourceTags()
        {
            return (ResourceTags.Count > 0);
        }
        
    }
}
