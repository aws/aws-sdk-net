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
    /// <para>Describes a VPC in a VPC peering connection.</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpcPeeringConnectionVpcInfo
    {
        private string ownerIdField;
        private string vpcIdField;
        private string cidrBlockField;

        /// <summary>
        /// The AWS account ID of the VPC owner.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }
        
        /// <summary>
        /// Sets the OwnerId
        /// <param name="ownerId">The OwnerId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnectionVpcInfo WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }
        
        /// <summary>
        /// Checks if OwnerId is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// The ID of the VPC.
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
        public VpcPeeringConnectionVpcInfo WithVpcId(string vpcId)
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
        /// The CIDR block for the VPC.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }
        
        /// <summary>
        /// Sets the CidrBlock
        /// <param name="cidrBlock">The CidrBlock.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnectionVpcInfo WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }
        
        /// <summary>
        /// Checks if CidrBlock is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }
        
    }
}
