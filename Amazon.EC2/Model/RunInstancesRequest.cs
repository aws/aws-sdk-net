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
    /// <summary>
    /// Launches a specified number of instances of an
    /// AMI for which you have
    /// permissions.
    ///
    /// If Amazon EC2 cannot launch the
    /// minimum number AMIs you request, no
    /// instances will be launched. If
    /// there is insufficient capacity to
    /// launch the
    /// maximum number of AMIs
    /// you request, Amazon EC2 launches the minimum
    /// number specified for
    /// each AMI and allocate the remaining available
    /// instances using round robin.
    ///
    /// In the following example, Libby generates a request to
    /// launch two images (database and web_server):
    ///
    /// Libby runs the RunInstances operation to launch database instances
    /// (min. 10, max. 15) and web_server instances (min. 30, max. 40).
    ///
    /// Because there are currently 30 instances available and Libby needs a
    /// minimum of 40, no instances are launched.
    ///
    /// Libby adjusts the number of instances she needs and runs the
    /// RunInstances operation to launch database
    /// instances (min. 5, max. 10) and web_server
    /// instances (min. 20, max. 40).
    ///
    /// Amazon EC2 launches the minimum number of instances for each
    /// AMI (5 database, 20 web_server).
    ///
    /// The remaining 5 instances are
    /// allocated using round robin.
    ///
    /// Libby adjusts the number of instances
    /// she needs and runs the RunInstances
    /// operation again to launch
    /// database instances (min. 5, max. 10) and
    /// web_server instances (min.
    /// 20, max. 40).
    ///
    /// Note - every instance is launched in a security group
    /// (created using the CreateSecurityGroup operation.)
    ///
    /// You can provide
    /// an optional key pair ID for each image in the launch request
    /// (created using the CreateKeyPair operation). All instances that
    /// are created from images that use this key pair will have access to
    /// the associated public key at boot. You can use this key to provide
    /// secure access to an instance of
    /// an image on a per-instance basis.
    /// Amazon EC2 public images use this
    /// feature to provide secure access
    /// without passwords.
    ///
    /// Important - launching public images without a
    /// key pair ID will leave them
    /// inaccessible.
    ///
    /// The public key material is
    /// made available to the instance at boot
    /// time by placing it in the
    /// openssh_id.pub file on a logical device that is exposed
    /// to the instance as /dev/sda2 (the instance store). The format of this
    /// file is suitable
    /// for use as an entry within ~/.ssh/authorized_keys
    /// (the OpenSSH format).
    /// This can be done at boot (e.g., as part of
    /// rc.local) allowing for secure access
    /// without passwords.
    ///
    /// Optional user data can be provided in the launch request. All instances that
    /// collectively comprise the launch request have access to this data.
    /// For more information, go the Amazon Elastic Compute Cloud Developer
    /// Guide.
    ///
    /// Note - if any of the AMIs have a product code attached for
    /// which the user has not subscribed, the RunInstances call will fail.
    ///
    /// Important - we strongly recommend using the 2.6.18 Xen stock
    /// kernel with High-CPU and High-Memory instances. Although the
    /// default Amazon EC2
    /// kernels will work, the new kernels provide
    /// greater stability and performance
    /// for these instance types. For more
    /// information about kernels, go the Amazon
    /// Elastic Compute Cloud
    /// Developer Guide
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class RunInstancesRequest
    {    
        private string imageIdField;
        private Decimal? minCountField;
        private Decimal? maxCountField;
        private string keyNameField;
        private List<string> securityGroupField;
        private List<string> securityGroupIdField;
        private string userDataField;
        private string instanceTypeField;
        private Placement placementField;
        private string kernelIdField;
        private string ramdiskIdField;
        private List<BlockDeviceMapping> blockDeviceMappingField;
        private MonitoringSpecification monitoringField;
        private string subnetIdField;
        private string additionalInfoField;
        private bool? disableApiTerminationField;
        private string instanceInitiatedShutdownBehaviorField;
        private InstanceLicenseSpecification licenseField;
        private string privateIpAddressField;
        private string clientTokenField;
        private string hypervisorField;

        /// <summary>
        /// Gets and sets the ImageId property.
        /// Unique ID of a machine image,
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
        /// <param name="imageId">Unique ID of a machine image,</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithImageId(string imageId)
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
        /// Gets and sets the MinCount property.
        /// Minimum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, no instances are launched at all.
        ///
        /// Constraints: Between 1 and the maximum number
        /// allowed for your account (default: 20).
        /// </summary>
        [XmlElementAttribute(ElementName = "MinCount")]
        public Decimal MinCount
        {
            get { return this.minCountField.GetValueOrDefault(); }
            set { this.minCountField = value; }
        }

        /// <summary>
        /// Sets the MinCount property
        /// </summary>
        /// <param name="minCount">Minimum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, no instances are launched at all.
        ///
        /// Constraints: Between 1 and the maximum number
        /// allowed for your account (default: 20).</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithMinCount(Decimal minCount)
        {
            this.minCountField = minCount;
            return this;
        }

        /// <summary>
        /// Checks if MinCount property is set
        /// </summary>
        /// <returns>true if MinCount property is set</returns>
        public bool IsSetMinCount()
        {
            return this.minCountField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MaxCount property.
        /// Maximum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, the largest possible
        /// number above minCount will be launched instead.
        ///
        /// Constraints:
        /// Between 1 and the maximum number allowed for your account
        /// (default: 20).
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxCount")]
        public Decimal MaxCount
        {
            get { return this.maxCountField.GetValueOrDefault(); }
            set { this.maxCountField = value; }
        }

        /// <summary>
        /// Sets the MaxCount property
        /// </summary>
        /// <param name="maxCount">Maximum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, the largest possible
        /// number above minCount will be launched instead.
        ///
        /// Constraints:
        /// Between 1 and the maximum number allowed for your account
        /// (default: 20).</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithMaxCount(Decimal maxCount)
        {
            this.maxCountField = maxCount;
            return this;
        }

        /// <summary>
        /// Checks if MaxCount property is set
        /// </summary>
        /// <returns>true if MaxCount property is set</returns>
        public bool IsSetMaxCount()
        {
            return this.maxCountField.HasValue;
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
        public RunInstancesRequest WithKeyName(string keyName)
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
        /// Names of the security group.
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
        /// <param name="list">Names of the security group.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithSecurityGroup(params string[] list)
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
        public RunInstancesRequest WithSecurityGroupId(params string[] list)
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
        public RunInstancesRequest WithUserData(string userData)
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
        /// Gets and sets the InstanceType property.
        /// Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge |
        /// m2.2xlarge | m2.4xlarge
        ///
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
        /// <param name="instanceType">Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge |
        /// m2.2xlarge | m2.4xlarge
        ///
        /// Default: m1.small</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithInstanceType(string instanceType)
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
        public RunInstancesRequest WithPlacement(Placement placement)
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
        /// The ID of the kernel with which to launch the
        /// instance.
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
        /// <param name="kernelId">The ID of the kernel with which to launch the
        /// instance.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithKernelId(string kernelId)
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
        /// The ID of the RAM disk with which to launch
        /// the instance. Some kernels
        /// require additional drivers at launch.
        /// Check the kernel requirements for
        /// information on whether you need
        /// to specify a RAM disk. To find kernel
        /// requirements, go to the
        /// Resource Center and search for the
        /// kernel ID.
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
        /// <param name="ramdiskId">The ID of the RAM disk with which to launch
        /// the instance. Some kernels
        /// require additional drivers at launch.
        /// Check the kernel requirements for
        /// information on whether you need
        /// to specify a RAM disk. To find kernel
        /// requirements, go to the
        /// Resource Center and search for the
        /// kernel ID.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithRamdiskId(string ramdiskId)
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
        /// Block device mapping.
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
        /// <param name="list">Block device mapping.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithBlockDeviceMapping(params BlockDeviceMapping[] list)
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
        /// Enables monitoring for the instance.
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
        /// <param name="monitoring">Enables monitoring for the instance.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithMonitoring(MonitoringSpecification monitoring)
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
        /// Specifies the subnet ID within which to launch
        /// the instance(s) for
        /// Amazon Virtual Private Cloud.
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
        /// <param name="subnetId">Specifies the subnet ID within which to launch
        /// the instance(s) for
        /// Amazon Virtual Private Cloud.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithSubnetId(string subnetId)
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
        /// Gets and sets the AdditionalInfo property.
        /// Specifies additional information to make
        /// available to the instance(s)
        /// </summary>
        [XmlElementAttribute(ElementName = "AdditionalInfo")]
        public string AdditionalInfo
        {
            get { return this.additionalInfoField; }
            set { this.additionalInfoField = value; }
        }

        /// <summary>
        /// Sets the AdditionalInfo property
        /// </summary>
        /// <param name="additionalInfo">Specifies additional information to make
        /// available to the instance(s)</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithAdditionalInfo(string additionalInfo)
        {
            this.additionalInfoField = additionalInfo;
            return this;
        }

        /// <summary>
        /// Checks if AdditionalInfo property is set
        /// </summary>
        /// <returns>true if AdditionalInfo property is set</returns>
        public bool IsSetAdditionalInfo()
        {
            return this.additionalInfoField != null;
        }

        /// <summary>
        /// Gets and sets the DisableApiTermination property.
        /// Specifies whether the instance can be
        /// terminated using the APIs. You must modify this attribute before
        /// you can terminate any "locked" instances from the APIs.
        /// </summary>
        [XmlElementAttribute(ElementName = "DisableApiTermination")]
        public bool DisableApiTermination
        {
            get { return this.disableApiTerminationField.GetValueOrDefault(); }
            set { this.disableApiTerminationField = value; }
        }

        /// <summary>
        /// Sets the DisableApiTermination property
        /// </summary>
        /// <param name="disableApiTermination">Specifies whether the instance can be
        /// terminated using the APIs. You must modify this attribute before
        /// you can terminate any "locked" instances from the APIs.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithDisableApiTermination(bool disableApiTermination)
        {
            this.disableApiTerminationField = disableApiTermination;
            return this;
        }

        /// <summary>
        /// Checks if DisableApiTermination property is set
        /// </summary>
        /// <returns>true if DisableApiTermination property is set</returns>
        public bool IsSetDisableApiTermination()
        {
            return this.disableApiTerminationField.HasValue;
        }

        /// <summary>
        /// Gets and sets the InstanceInitiatedShutdownBehavior property.
        /// Specifies whether the instance's Amazon EBS
        /// volumes are stopped or terminated when the instance is shut
        /// down.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceInitiatedShutdownBehavior")]
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehaviorField; }
            set { this.instanceInitiatedShutdownBehaviorField = value; }
        }

        /// <summary>
        /// Sets the InstanceInitiatedShutdownBehavior property
        /// </summary>
        /// <param name="instanceInitiatedShutdownBehavior">Specifies whether the instance's Amazon EBS
        /// volumes are stopped or terminated when the instance is shut
        /// down.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithInstanceInitiatedShutdownBehavior(string instanceInitiatedShutdownBehavior)
        {
            this.instanceInitiatedShutdownBehaviorField = instanceInitiatedShutdownBehavior;
            return this;
        }

        /// <summary>
        /// Checks if InstanceInitiatedShutdownBehavior property is set
        /// </summary>
        /// <returns>true if InstanceInitiatedShutdownBehavior property is set</returns>
        public bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehaviorField != null;
        }

        /// <summary>
        /// Gets and sets the License property.
        /// Specifies active licenses in use and attached
        /// to an Amazon EC2 instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "License")]
        public InstanceLicenseSpecification License
        {
            get { return this.licenseField; }
            set { this.licenseField = value; }
        }

        /// <summary>
        /// Sets the License property
        /// </summary>
        /// <param name="license">Specifies active licenses in use and attached
        /// to an Amazon EC2 instance.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithLicense(InstanceLicenseSpecification license)
        {
            this.licenseField = license;
            return this;
        }

        /// <summary>
        /// Checks if License property is set
        /// </summary>
        /// <returns>true if License property is set</returns>
        public bool IsSetLicense()
        {
            return this.licenseField != null;
        }

        /// <summary>
        /// Gets and sets the PrivateIpAddress property.
        /// If you're using Amazon Virtual Private Cloud,
        /// you can optionally use this
        /// parameter to assign the instance a
        /// specific available IP address from the
        /// subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the PrivateIpAddress property
        /// </summary>
        /// <param name="privateIpAddress">If you're using Amazon Virtual Private Cloud,
        /// you can optionally use this
        /// parameter to assign the instance a
        /// specific available IP address from the
        /// subnet.</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithPrivateIpAddress(string privateIpAddress)
        {
            this.privateIpAddressField = privateIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if PrivateIpAddress property is set
        /// </summary>
        /// <returns>true if PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddressField != null;
        }

        /// <summary>
        /// Gets and sets the ClientToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Sets the ClientToken property
        /// </summary>
        /// <param name="clientToken">ClientToken property</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithClientToken(string clientToken)
        {
            this.clientTokenField = clientToken;
            return this;
        }

        /// <summary>
        /// Checks if ClientToken property is set
        /// </summary>
        /// <returns>true if ClientToken property is set</returns>
        public bool IsSetClientToken()
        {
            return this.clientTokenField != null;
        }

        /// <summary>
        /// Gets and sets the Hypervisor property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Hypervisor")]
        public string Hypervisor
        {
            get { return this.hypervisorField; }
            set { this.hypervisorField = value; }
        }

        /// <summary>
        /// Sets the Hypervisor property
        /// </summary>
        /// <param name="hypervisor">Hypervisor property</param>
        /// <returns>this instance</returns>
        public RunInstancesRequest WithHypervisor(string hypervisor)
        {
            this.hypervisorField = hypervisor;
            return this;
        }

        /// <summary>
        /// Checks if Hypervisor property is set
        /// </summary>
        /// <returns>true if Hypervisor property is set</returns>
        public bool IsSetHypervisor()
        {
            return this.hypervisorField != null;
        }

    }
}
