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
    ///Specifies additional launch instance information.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class LaunchSpecification
    {    
        private string imageIdField;
        private string keyNameField;
        private List<string> securityGroupField;
        private List<string> securityGroupIdField;
        private string userDataField;
        private string addressingTypeField;
        private string instanceTypeField;
        private Placement placementField;
        private string kernelIdField;
        private string ramdiskIdField;
        private List<BlockDeviceMapping> blockDeviceMappingField;
        private MonitoringSpecification monitoringField;
        private string subnetIdField;

        /// <summary>
        /// Gets and sets the ImageId property.
        /// The AMI ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">The AMI ID.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithImageId(string imageId)
        {
            this.imageIdField = imageId;
            return this;
        }

        /// <summary>
        /// Checks if ImageId property is set
        /// </summary>
        /// <returns>true if ImageId property is set</returns>
        public bool IsSetImageId()
        {
            return this.imageIdField != null;
        }

        /// <summary>
        /// Gets and sets the KeyName property.
        /// The name of the key pair.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField; }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="keyName">The name of the key pair.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithKeyName(string keyName)
        {
            this.keyNameField = keyName;
            return this;
        }

        /// <summary>
        /// Checks if KeyName property is set
        /// </summary>
        /// <returns>true if KeyName property is set</returns>
        public bool IsSetKeyName()
        {
            return this.keyNameField != null;
        }

        /// <summary>
        /// Gets and sets the SecurityGroup property.
        /// The Security Groups to associate the launched
        /// instance with.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroup")]
        public List<string> SecurityGroup
        {
            get
            {
                if (this.securityGroupField == null)
                {
                    this.securityGroupField = new List<string>();
                }
                return this.securityGroupField;
            }
            set { this.securityGroupField = value; }
        }

        /// <summary>
        /// Sets the SecurityGroup property
        /// </summary>
        /// <param name="list">The Security Groups to associate the launched
        /// instance with.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithSecurityGroup(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroup property is set
        /// </summary>
        /// <returns>true if SecurityGroup property is set</returns>
        public bool IsSetSecurityGroup()
        {
            return (SecurityGroup.Count > 0);
        }

        /// <summary>
        /// Gets and sets the SecurityGroupId property.
        /// IDs of the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroupId")]
        public List<string> SecurityGroupId
        {
            get
            {
                if (this.securityGroupIdField == null)
                {
                    this.securityGroupIdField = new List<string>();
                }
                return this.securityGroupIdField;
            }
            set { this.securityGroupIdField = value; }
        }

        /// <summary>
        /// Sets the SecurityGroupId property
        /// </summary>
        /// <param name="list">IDs of the security group.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithSecurityGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroupId property is set
        /// </summary>
        /// <returns>true if SecurityGroupId property is set</returns>
        public bool IsSetSecurityGroupId()
        {
            return (SecurityGroupId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the UserData property.
        /// MIME, Base64-encoded user data.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField; }
            set { this.userDataField = value; }
        }

        /// <summary>
        /// Sets the UserData property
        /// </summary>
        /// <param name="userData">MIME, Base64-encoded user data.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithUserData(string userData)
        {
            this.userDataField = userData;
            return this;
        }

        /// <summary>
        /// Checks if UserData property is set
        /// </summary>
        /// <returns>true if UserData property is set</returns>
        public bool IsSetUserData()
        {
            return this.userDataField != null;
        }

        /// <summary>
        /// Gets and sets the AddressingType property.
        /// Deprecated.
        /// </summary>
        [XmlElementAttribute(ElementName = "AddressingType")]
        public string AddressingType
        {
            get { return this.addressingTypeField; }
            set { this.addressingTypeField = value; }
        }

        /// <summary>
        /// Sets the AddressingType property
        /// </summary>
        /// <param name="addressingType">Deprecated.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithAddressingType(string addressingType)
        {
            this.addressingTypeField = addressingType;
            return this;
        }

        /// <summary>
        /// Checks if AddressingType property is set
        /// </summary>
        /// <returns>true if AddressingType property is set</returns>
        public bool IsSetAddressingType()
        {
            return this.addressingTypeField != null;
        }

        /// <summary>
        /// Gets and sets the InstanceType property.
        /// Specifies the instance type. Valid values are:
        /// m1.small | m1.large | m1.xlarge |
        /// c1.medium | c1.xlarge |
        /// m2.2xlarge | m2.4xlarge.
        /// Default: m1.small
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">Specifies the instance type. Valid values are:
        /// m1.small | m1.large | m1.xlarge |
        /// c1.medium | c1.xlarge |
        /// m2.2xlarge | m2.4xlarge.
        /// Default: m1.small</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithInstanceType(string instanceType)
        {
            this.instanceTypeField = instanceType;
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the Placement property.
        /// Specifies the placement constraints.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public Placement Placement
        {
            get { return this.placementField; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the Placement property
        /// </summary>
        /// <param name="placement">Specifies the placement constraints.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithPlacement(Placement placement)
        {
            this.placementField = placement;
            return this;
        }

        /// <summary>
        /// Checks if Placement property is set
        /// </summary>
        /// <returns>true if Placement property is set</returns>
        public bool IsSetPlacement()
        {
            return this.placementField != null;
        }

        /// <summary>
        /// Gets and sets the KernelId property.
        /// The ID of the kernel to select.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the KernelId property
        /// </summary>
        /// <param name="kernelId">The ID of the kernel to select.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithKernelId(string kernelId)
        {
            this.kernelIdField = kernelId;
            return this;
        }

        /// <summary>
        /// Checks if KernelId property is set
        /// </summary>
        /// <returns>true if KernelId property is set</returns>
        public bool IsSetKernelId()
        {
            return this.kernelIdField != null;
        }

        /// <summary>
        /// Gets and sets the RamdiskId property.
        /// The ID of the RAM disk to select. Some kernels
        /// require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to
        /// specify a RAM
        /// disk.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the RamdiskId property
        /// </summary>
        /// <param name="ramdiskId">The ID of the RAM disk to select. Some kernels
        /// require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to
        /// specify a RAM
        /// disk.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithRamdiskId(string ramdiskId)
        {
            this.ramdiskIdField = ramdiskId;
            return this;
        }

        /// <summary>
        /// Checks if RamdiskId property is set
        /// </summary>
        /// <returns>true if RamdiskId property is set</returns>
        public bool IsSetRamdiskId()
        {
            return this.ramdiskIdField != null;
        }

        /// <summary>
        /// Gets and sets the BlockDeviceMapping property.
        /// Specifies how block devices are exposed to the
        /// instance. Each mapping is made up of a virtualName
        /// and a deviceName.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<BlockDeviceMapping> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<BlockDeviceMapping>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets the BlockDeviceMapping property
        /// </summary>
        /// <param name="list">Specifies how block devices are exposed to the
        /// instance. Each mapping is made up of a virtualName
        /// and a deviceName.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithBlockDeviceMapping(params BlockDeviceMapping[] list)
        {
            foreach (BlockDeviceMapping item in list)
            {
                BlockDeviceMapping.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BlockDeviceMapping property is set
        /// </summary>
        /// <returns>true if BlockDeviceMapping property is set</returns>
        public bool IsSetBlockDeviceMapping()
        {
            return (BlockDeviceMapping.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Monitoring property.
        /// Specifies whether to enable monitoring for the Spot Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public MonitoringSpecification Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the Monitoring property
        /// </summary>
        /// <param name="monitoring">Specifies whether to enable monitoring for the Spot Instance.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithMonitoring(MonitoringSpecification monitoring)
        {
            this.monitoringField = monitoring;
            return this;
        }

        /// <summary>
        /// Checks if Monitoring property is set
        /// </summary>
        /// <returns>true if Monitoring property is set</returns>
        public bool IsSetMonitoring()
        {
            return this.monitoringField != null;
        }

        /// <summary>
        /// Gets and sets the SubnetId property.
        /// Specifies the Amazon VPC subnet ID within which to
        /// launch the instance(s) for Amazon Virtual Private Cloud.
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
        /// <param name="subnetId">Specifies the Amazon VPC subnet ID within which to
        /// launch the instance(s) for Amazon Virtual Private Cloud.</param>
        /// <returns>this instance</returns>
        public LaunchSpecification WithSubnetId(string subnetId)
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

    }
}
