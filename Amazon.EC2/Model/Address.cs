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
    ///A static public IP address designed for dynamic
    ///cloud computing. Any elastic IP addresses that you associate with
    ///your account remains associated with your account until you
    ///explicitly release them. Unlike traditional static IP
    ///addresses, however, elastic IP addresses allow you to mask instance or
    ///Availability Zone failures by rapidly remapping your public IP
    ///addresses to any instance in your account. The Address type contains
    ///an Elastic IP associated with your account
    ///and the InstanceId of the instance it is associated with.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class Address
    {    
        private string instanceIdField;
        private string publicIpField;
        private string allocationIdField;
        private string associationIdField;
        private string domainField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <returns>this instance</returns>
        public Address WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the PublicIp property.
        /// The public IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the PublicIp property
        /// </summary>
        /// <param name="publicIp">The public IP address.</param>
        /// <returns>this instance</returns>
        public Address WithPublicIp(string publicIp)
        {
            this.publicIpField = publicIp;
            return this;
        }

        /// <summary>
        /// Checks if PublicIp property is set
        /// </summary>
        /// <returns>true if PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return this.publicIpField != null;
        }

        /// <summary>
        /// Gets and sets the AllocationId property.
        /// The ID representing the allocation of the address for use with Amazon
        /// VPC
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets the AllocationId property
        /// </summary>
        /// <param name="allocationId">The ID representing the allocation of the address for use with Amazon
        /// VPC</param>
        /// <returns>this instance</returns>
        public Address WithAllocationId(string allocationId)
        {
            this.allocationIdField = allocationId;
            return this;
        }

        /// <summary>
        /// Checks if AllocationId property is set
        /// </summary>
        /// <returns>true if AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return this.allocationIdField != null;
        }

        /// <summary>
        /// Gets and sets the AssociationId property.
        /// The ID representing the association of a VPC elastic IP address with
        /// an instance in a VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the AssociationId property
        /// </summary>
        /// <param name="associationId">The ID representing the association of a VPC elastic IP address with
        /// an instance in a VPC.</param>
        /// <returns>this instance</returns>
        public Address WithAssociationId(string associationId)
        {
            this.associationIdField = associationId;
            return this;
        }

        /// <summary>
        /// Checks if AssociationId property is set
        /// </summary>
        /// <returns>true if AssociationId property is set</returns>
        public bool IsSetAssociationId()
        {
            return this.associationIdField != null;
        }

        /// <summary>
        /// Gets and sets the Domain property.
        /// Whether this elastic IP address is for instances in EC2 (i.e., standard)
        /// or Amazon VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "Domain")]
        public string Domain
        {
            get { return this.domainField; }
            set { this.domainField = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">Whether this elastic IP address is for instances in EC2 (i.e., standard)
        /// or Amazon VPC.</param>
        /// <returns>this instance</returns>
        public Address WithDomain(string domain)
        {
            this.domainField = domain;
            return this;
        }

        /// <summary>
        /// Checks if Domain property is set
        /// </summary>
        /// <returns>true if Domain property is set</returns>
        public bool IsSetDomain()
        {
            return this.domainField != null;
        }

    }
}
