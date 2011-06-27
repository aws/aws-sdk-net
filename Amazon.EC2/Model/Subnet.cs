/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Subnet
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class Subnet
    {    
        private string subnetIdField;
        private string subnetStateField;
        private string vpcIdField;
        private string cidrBlockField;
        private Decimal? availableIpAddressCountField;
        private string availabilityZoneField;
        private List<Tag> tagField;

        /// <summary>
        /// Gets and sets the SubnetId property.
        /// The subnet's ID
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the SubnetId property
        /// </summary>
        /// <param name="subnetId">The subnet's ID</param>
        /// <returns>this instance</returns>
        public Subnet WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

        /// <summary>
        /// Gets and sets the SubnetState property.
        /// The current state of the subnet (pending or
        /// available).
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetState")]
        public string SubnetState
        {
            get { return this.subnetStateField; }
            set { this.subnetStateField = value; }
        }

        /// <summary>
        /// Sets the SubnetState property
        /// </summary>
        /// <param name="subnetState">The current state of the subnet (pending or
        /// available).</param>
        /// <returns>this instance</returns>
        public Subnet WithSubnetState(string subnetState)
        {
            this.subnetStateField = subnetState;
            return this;
        }

        /// <summary>
        /// Checks if SubnetState property is set
        /// </summary>
        /// <returns>true if SubnetState property is set</returns>
        public bool IsSetSubnetState()
        {
            return this.subnetStateField != null;
        }

        /// <summary>
        /// Gets and sets the VpcId property.
        /// The ID of the VPC the subnet is in
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The ID of the VPC the subnet is in</param>
        /// <returns>this instance</returns>
        public Subnet WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// Gets and sets the CidrBlock property.
        /// The CIDR block assigned to the subnet
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrBlock")]
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CidrBlock property
        /// </summary>
        /// <param name="cidrBlock">The CIDR block assigned to the subnet</param>
        /// <returns>this instance</returns>
        public Subnet WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if CidrBlock property is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }

        /// <summary>
        /// Gets and sets the AvailableIpAddressCount property.
        /// The number of unused IP addresses in the
        /// subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailableIpAddressCount")]
        public Decimal AvailableIpAddressCount
        {
            get { return this.availableIpAddressCountField.GetValueOrDefault(); }
            set { this.availableIpAddressCountField = value; }
        }

        /// <summary>
        /// Sets the AvailableIpAddressCount property
        /// </summary>
        /// <param name="availableIpAddressCount">The number of unused IP addresses in the
        /// subnet.</param>
        /// <returns>this instance</returns>
        public Subnet WithAvailableIpAddressCount(Decimal availableIpAddressCount)
        {
            this.availableIpAddressCountField = availableIpAddressCount;
            return this;
        }

        /// <summary>
        /// Checks if AvailableIpAddressCount property is set
        /// </summary>
        /// <returns>true if AvailableIpAddressCount property is set</returns>
        public bool IsSetAvailableIpAddressCount()
        {
            return this.availableIpAddressCountField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZone property.
        /// The Availability Zone the subnet is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone the subnet is in.</param>
        /// <returns>this instance</returns>
        public Subnet WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// Gets and sets the Tag property.
        /// A list of tags for the Subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">A list of tags for the Subnet.</param>
        /// <returns>this instance</returns>
        public Subnet WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
