/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a VPC.</para>
    /// </summary>
    public class Vpc
    {
        
        private string vpcId;
        private VpcState state;
        private string cidrBlock;
        private string dhcpOptionsId;
        private List<Tag> tags = new List<Tag>();
        private Tenancy instanceTenancy;
        private bool? isDefault;


        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The current state of the VPC.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, available</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VpcState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The CIDR block for the VPC.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// The ID of the set of DHCP options you've associated with the VPC (or <c>default</c> if the default options are associated with the VPC).
        ///  
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsId; }
            set { this.dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this.dhcpOptionsId != null;
        }

        /// <summary>
        /// Any tags assigned to the VPC.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// The allowed tenancy of instances launched into the VPC.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>default, dedicated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this.instanceTenancy; }
            set { this.instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this.instanceTenancy != null;
        }

        /// <summary>
        /// Indicates whether the VPC is the default VPC.
        ///  
        /// </summary>
        public bool IsDefault
        {
            get { return this.isDefault ?? default(bool); }
            set { this.isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this.isDefault.HasValue;
        }
    }
}
