/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Launched EC2 Instance
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class RunningInstance
    {    
        private string instanceIdField;
        private string imageIdField;
        private InstanceState instanceStateField;
        private string privateDnsNameField;
        private string publicDnsNameField;
        private string stateTransitionReasonField;
        private string keyNameField;
        private string amiLaunchIndexField;
        // obsolete, to be removed
        private List<string> productCodeField;
        // replacement for string list of product codes
        private List<ProductCode> productCodesField;
        private string instanceTypeField;
        private string launchTimeField;
        private Placement placementField;
        private string kernelIdField;
        private string ramdiskIdField;
        private string platformField;
        private Monitoring monitoringField;
        private string subnetIdField;
        private string vpcIdField;
        private string privateIpAddressField;
        private string ipAddressField;
        private bool? sourceDestCheckField;
        private List<string> groupIdField;
        private List<string> groupNameField;
        private StateReason stateReasonField;
        private string architectureField;
        private string rootDeviceTypeField;
        private string rootDeviceNameField;
        private List<InstanceBlockDeviceMapping> blockDeviceMappingField;
        private string instanceLifecycleField;
        private string spotInstanceRequestIdField;
        private InstanceLicense licenseField;
        private string virtualizationTypeField;
        private string clientTokenField;
        private List<Tag> tagField;
        private string hypervisorField;
        private List<InstanceNetworkInterface> networkInterfaceSetField;
        private bool? ebsOptimizedField;
        private IAMInstanceProfile instanceProfileField;

        /// <summary>
        /// Unique ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the unique ID of the instance.
        /// </summary>
        /// <param name="instanceId">Unique ID of the instance launched.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithInstanceId(string instanceId)
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
        /// Image ID of the AMI used to launch the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the image ID of the AMI used to launch the instance.
        /// </summary>
        /// <param name="imageId">Image ID of the AMI used to launch the
        /// instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithImageId(string imageId)
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
        /// The current state of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceState")]
        public InstanceState InstanceState
        {
            get { return this.instanceStateField; }
            set { this.instanceStateField = value; }
        }

        /// <summary>
        /// Sets the current state of the instance.
        /// </summary>
        /// <param name="instanceState">The current state of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithInstanceState(InstanceState instanceState)
        {
            this.instanceStateField = instanceState;
            return this;
        }

        /// <summary>
        /// Checks if InstanceState property is set
        /// </summary>
        /// <returns>true if InstanceState property is set</returns>
        public bool IsSetInstanceState()
        {
            return this.instanceStateField != null;
        }

        /// <summary>
        /// The private DNS name assigned to the instance.
        /// This DNS name can only be used inside the Amazon EC2 network.
        /// This element remains empty until the instance enters a running state
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateDnsName")]
        public string PrivateDnsName
        {
            get { return this.privateDnsNameField; }
            set { this.privateDnsNameField = value; }
        }

        /// <summary>
        /// Sets the private DNS name assigned to the instance.
        /// </summary>
        /// <param name="privateDnsName">The private DNS name assigned to the instance.
        /// This DNS name can only be used inside the Amazon EC2 network.
        /// This element remains empty until the instance
        /// enters a running state</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithPrivateDnsName(string privateDnsName)
        {
            this.privateDnsNameField = privateDnsName;
            return this;
        }

        /// <summary>
        /// Checks if PrivateDnsName property is set
        /// </summary>
        /// <returns>true if PrivateDnsName property is set</returns>
        public bool IsSetPrivateDnsName()
        {
            return this.privateDnsNameField != null;
        }

        /// <summary>
        /// The public DNS name assigned to the instance.
        /// This DNS name is contactable from outside the Amazon EC2 network.
        /// This element remains empty until the instance enters a running state
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicDnsName")]
        public string PublicDnsName
        {
            get { return this.publicDnsNameField; }
            set { this.publicDnsNameField = value; }
        }

        /// <summary>
        /// Sets the public DNS name assigned to the instance.
        /// </summary>
        /// <param name="publicDnsName">The public DNS name assigned to the instance.
        /// This DNS name is contactable from
        /// outside the Amazon EC2 network.
        /// This element remains empty until the
        /// instance enters a running state</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithPublicDnsName(string publicDnsName)
        {
            this.publicDnsNameField = publicDnsName;
            return this;
        }

        /// <summary>
        /// Checks if PublicDnsName property is set
        /// </summary>
        /// <returns>true if PublicDnsName property is set</returns>
        public bool IsSetPublicDnsName()
        {
            return this.publicDnsNameField != null;
        }

        /// <summary>
        /// Reason for the most recent state transition.
        /// This might be an empty string.
        /// </summary>
        [XmlElementAttribute(ElementName = "StateTransitionReason")]
        public string StateTransitionReason
        {
            get { return this.stateTransitionReasonField; }
            set { this.stateTransitionReasonField = value; }
        }

        /// <summary>
        /// Sets the reason for the most recent state transition.
        /// </summary>
        /// <param name="stateTransitionReason">Reason for the most recent state transition.
        /// This might be an empty string.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithStateTransitionReason(string stateTransitionReason)
        {
            this.stateTransitionReasonField = stateTransitionReason;
            return this;
        }

        /// <summary>
        /// Checks if StateTransitionReason property is set
        /// </summary>
        /// <returns>true if StateTransitionReason property is set</returns>
        public bool IsSetStateTransitionReason()
        {
            return this.stateTransitionReasonField != null;
        }

        /// <summary>
        /// Name of a key pair associated with this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField; }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the name of a key pair associated with this instance.
        /// </summary>
        /// <param name="keyName">If this instance was launched with an
        /// associated key pair, this
        /// displays the key pair
        /// name.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithKeyName(string keyName)
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
        /// The AMI launch index, which can be used to find this instance
        /// within the launch group.
        /// </summary>
        [XmlElementAttribute(ElementName = "AmiLaunchIndex")]
        public string AmiLaunchIndex
        {
            get { return this.amiLaunchIndexField; }
            set { this.amiLaunchIndexField = value; }
        }

        /// <summary>
        /// Sets the AMI launch index, which can be used to find this instance
        /// within the launch group.
        /// </summary>
        /// <param name="amiLaunchIndex">The AMI launch index, which can be used to find
        /// this instance
        /// within the launch
        /// group.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithAmiLaunchIndex(string amiLaunchIndex)
        {
            this.amiLaunchIndexField = amiLaunchIndex;
            return this;
        }

        /// <summary>
        /// Checks if AmiLaunchIndex property is set
        /// </summary>
        /// <returns>true if AmiLaunchIndex property is set</returns>
        public bool IsSetAmiLaunchIndex()
        {
            return this.amiLaunchIndexField != null;
        }

        /// <summary>
        /// Product codes attached to this instance.
        /// </summary>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the ProductCodes member instead.")]
        [XmlElementAttribute(ElementName = "ProductCodeId")]
        public List<string> ProductCode
        {
            get
            {
                if (this.productCodeField == null)
                {
                    this.productCodeField = new List<string>();
                }
                return this.productCodeField;
            }
            set { this.productCodeField = value; }
        }

        /// <summary>
        /// Sets the product codes attached to this instance.
        /// </summary>
        /// <param name="list">Product codes attached to this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the WithProductCodes member instead.")]
        public RunningInstance WithProductCode(params string[] list)
        {
            foreach (string item in list)
            {
                ProductCode.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCode property is set
        /// </summary>
        /// <returns>true if ProductCode property is set</returns>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the IsSetProductCodes member instead.")]
        public bool IsSetProductCode()
        {
            return (ProductCode.Count > 0);
        }

        /// <summary>
        /// Product codes attached to this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCodes")]
        public List<ProductCode> ProductCodes
        {
            get
            {
                if (this.productCodesField == null)
                {
                    this.productCodesField = new List<ProductCode>();
                }
                return this.productCodesField;
            }
            set { this.productCodesField = value; }
        }

        /// <summary>
        /// Sets the product codes attached to this instance.
        /// </summary>
        /// <param name="list">Product codes attached to this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithProductCodes(params ProductCode[] list)
        {
            foreach (ProductCode item in list)
            {
                ProductCodes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCodes property is set
        /// </summary>
        /// <returns>true if ProductCodes property is set</returns>
        public bool IsSetProductCodes()
        {
            return (ProductCodes.Count > 0);
        }

        /// <summary>
        /// The instance type.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the instance type.
        /// </summary>
        /// <param name="instanceType">The instance type.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithInstanceType(string instanceType)
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
        /// The time the instance launched.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchTime")]
        public string LaunchTime
        {
            get { return this.launchTimeField; }
            set { this.launchTimeField = value; }
        }

        /// <summary>
        /// Sets the time the instance launched.
        /// </summary>
        /// <param name="launchTime">The time the instance launched.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithLaunchTime(string launchTime)
        {
            this.launchTimeField = launchTime;
            return this;
        }

        /// <summary>
        /// Checks if LaunchTime property is set
        /// </summary>
        /// <returns>true if LaunchTime property is set</returns>
        public bool IsSetLaunchTime()
        {
            return this.launchTimeField != null;
        }

        /// <summary>
        /// The location where the instance launched.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public Placement Placement
        {
            get { return this.placementField; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the location where the instance launched.
        /// </summary>
        /// <param name="placement">The location where the instance launched.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithPlacement(Placement placement)
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
        /// Kernel associated with this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the kernel associated with this instance.
        /// </summary>
        /// <param name="kernelId">Kernel associated with this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithKernelId(string kernelId)
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
        /// RAM disk associated with this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the RAM disk associated with this instance.
        /// </summary>
        /// <param name="ramdiskId">RAM disk associated with this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithRamdiskId(string ramdiskId)
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
        /// Platform of the instance (e.g., Windows).
        /// </summary>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platformField; }
            set { this.platformField = value; }
        }

        /// <summary>
        /// Sets the platform of the instance (e.g., Windows).
        /// </summary>
        /// <param name="platform">Platform of the instance (e.g., Windows).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithPlatform(string platform)
        {
            this.platformField = platform;
            return this;
        }

        /// <summary>
        /// Checks if Platform property is set
        /// </summary>
        /// <returns>true if Platform property is set</returns>
        public bool IsSetPlatform()
        {
            return this.platformField != null;
        }

        /// <summary>
        /// Monitoring configuration for the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public Monitoring Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the monitoring configuration for the instance.
        /// </summary>
        /// <param name="monitoring">Specifies whether monitoring is enabled for the
        /// instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithMonitoring(Monitoring monitoring)
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
        /// The subnet ID in which the instance is running (Amazon Virtual Private Cloud).
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the subnet ID in which the instance is running (Amazon Virtual Private Cloud).
        /// </summary>
        /// <param name="subnetId">Specifies the subnet ID in which the instance
        /// is running (Amazon Virtual Private Cloud).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithSubnetId(string subnetId)
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
        /// The VPC in which the instance is running (Amazon Virtual Private Cloud).
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VPC in which the instance is running (Amazon Virtual Private Cloud).
        /// </summary>
        /// <param name="vpcId">Specifies the VPC in which the instance is
        /// running (Amazon Virtual Private Cloud).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithVpcId(string vpcId)
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
        /// The private IP address that is assigned to the instance (Amazon VPC).
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the private IP address that is assigned to the instance (Amazon VPC).
        /// </summary>
        /// <param name="privateIpAddress">Specifies the private IP address that is
        /// assigned to the instance (Amazon VPC).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithPrivateIpAddress(string privateIpAddress)
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
        /// The IP address of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpAddress")]
        public string IpAddress
        {
            get { return this.ipAddressField; }
            set { this.ipAddressField = value; }
        }

        /// <summary>
        /// Sets the IP address of the instance.
        /// </summary>
        /// <param name="ipAddress">Specifies the IP address of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithIpAddress(string ipAddress)
        {
            this.ipAddressField = ipAddress;
            return this;
        }

        /// <summary>
        /// Checks if IpAddress property is set
        /// </summary>
        /// <returns>true if IpAddress property is set</returns>
        public bool IsSetIpAddress()
        {
            return this.ipAddressField != null;
        }

        /// <summary>
        /// Whether source/destination checking is enabled on the instance.
        /// </summary>
        /// <remarks>
        /// A value of true means checking is enabled, and false means checking is
        /// disabled. The value must be false for the instance to perform NAT.
        /// For more information, go to NAT Instances in the Amazon Virtual
        /// Private Cloud User Guide.
        /// </remarks>
        [XmlElementAttribute(ElementName = "SourceDestCheck")]
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheckField.GetValueOrDefault(); }
            set { this.sourceDestCheckField = value; }
        }

        /// <summary>
        /// Sets whether source/destination checking is enabled on the instance.
        /// </summary>
        /// <param name="sourceDestCheck">
        /// A value of true means checking is enabled, and false means checking is
        /// disabled. The value must be false for the instance to perform NAT.
        /// For more information, go to NAT Instances in the Amazon Virtual
        /// Private Cloud User Guide.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithSourceDestCheck(bool sourceDestCheck)
        {
            this.sourceDestCheckField = sourceDestCheck;
            return this;
        }

        /// <summary>
        /// Checks if SourceDestCheck property is set
        /// </summary>
        /// <returns>true if SourceDestCheck property is set</returns>
        public bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheckField.HasValue;
        }

        /// <summary>
        /// A list of VPC security group names the instance is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public List<string> GroupId
        {
            get
            {
                if (this.groupIdField == null)
                {
                    this.groupIdField = new List<string>();
                }
                return this.groupIdField;
            }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the VPC security group names the instance is in.
        /// </summary>
        /// <param name="list">A list of VPC security groups the instance is in.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

        /// <summary>
        /// A list of VPC security group IDs the instance is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public List<string> GroupName
        {
            get
            {
                if (this.groupNameField == null)
                {
                    this.groupNameField = new List<string>();
                }
                return this.groupNameField;
            }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the VPC security group IDs the instance is in.
        /// </summary>
        /// <param name="list">A list of security groups the instance is in.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithGroupName(params string[] list)
        {
            foreach (string item in list)
            {
                GroupName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupName()
        {
            return (GroupName.Count > 0);
        }

        /// <summary>
        /// The reason for the state change.
        /// </summary>
        [XmlElementAttribute(ElementName = "StateReason")]
        public StateReason StateReason
        {
            get { return this.stateReasonField; }
            set { this.stateReasonField = value; }
        }

        /// <summary>
        /// Sets the reason for the state change.
        /// </summary>
        /// <param name="stateReason">The reason for the state change.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithStateReason(StateReason stateReason)
        {
            this.stateReasonField = stateReason;
            return this;
        }

        /// <summary>
        /// Checks if StateReason property is set
        /// </summary>
        /// <returns>true if StateReason property is set</returns>
        public bool IsSetStateReason()
        {
            return this.stateReasonField != null;
        }

        /// <summary>
        /// The architecture of the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Architecture")]
        public string Architecture
        {
            get { return this.architectureField; }
            set { this.architectureField = value; }
        }

        /// <summary>
        /// Sets the architecture of the image.
        /// </summary>
        /// <param name="architecture">The architecture of the image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithArchitecture(string architecture)
        {
            this.architectureField = architecture;
            return this;
        }

        /// <summary>
        /// Checks if Architecture property is set
        /// </summary>
        /// <returns>true if Architecture property is set</returns>
        public bool IsSetArchitecture()
        {
            return this.architectureField != null;
        }

        /// <summary>
        /// The root device type used by the AMI.
        /// The AMI can use an Amazon EBS or instance store root device.
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceType")]
        public string RootDeviceType
        {
            get { return this.rootDeviceTypeField; }
            set { this.rootDeviceTypeField = value; }
        }

        /// <summary>
        /// Sets the root device type used by the AMI.
        /// </summary>
        /// <param name="rootDeviceType">The root device type used by the AMI. The AMI
        /// can use an Amazon EBS or instance store root device.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithRootDeviceType(string rootDeviceType)
        {
            this.rootDeviceTypeField = rootDeviceType;
            return this;
        }

        /// <summary>
        /// Checks if RootDeviceType property is set
        /// </summary>
        /// <returns>true if RootDeviceType property is set</returns>
        public bool IsSetRootDeviceType()
        {
            return this.rootDeviceTypeField != null;
        }

        /// <summary>
        /// The root device name (e.g., /dev/sda1).
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceName")]
        public string RootDeviceName
        {
            get { return this.rootDeviceNameField; }
            set { this.rootDeviceNameField = value; }
        }

        /// <summary>
        /// Sets the root device name (e.g., /dev/sda1).
        /// </summary>
        /// <param name="rootDeviceName">The root device name (e.g., /dev/sda1).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithRootDeviceName(string rootDeviceName)
        {
            this.rootDeviceNameField = rootDeviceName;
            return this;
        }

        /// <summary>
        /// Checks if RootDeviceName property is set
        /// </summary>
        /// <returns>true if RootDeviceName property is set</returns>
        public bool IsSetRootDeviceName()
        {
            return this.rootDeviceNameField != null;
        }

        /// <summary>
        /// Block device mapping configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<InstanceBlockDeviceMapping> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<InstanceBlockDeviceMapping>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets the block device mapping configuration.
        /// </summary>
        /// <param name="list">Block device mapping set.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithBlockDeviceMapping(params InstanceBlockDeviceMapping[] list)
        {
            foreach (InstanceBlockDeviceMapping item in list)
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
        /// Whether this is a Spot Instance.
        /// Valid values: spot | blank (no value)
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceLifecycle")]
        public string InstanceLifecycle
        {
            get { return this.instanceLifecycleField; }
            set { this.instanceLifecycleField = value; }
        }

        /// <summary>
        /// Sets whether this is a Spot Instance.
        /// Valid values: spot | blank (no value)
        /// </summary>
        /// <param name="instanceLifecycle">InstanceLifecycle property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithInstanceLifecycle(string instanceLifecycle)
        {
            this.instanceLifecycleField = instanceLifecycle;
            return this;
        }

        /// <summary>
        /// Checks if InstanceLifecycle property is set
        /// </summary>
        /// <returns>true if InstanceLifecycle property is set</returns>
        public bool IsSetInstanceLifecycle()
        {
            return this.instanceLifecycleField != null;
        }

        /// <summary>
        /// The ID of the Spot Instance request that started this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotInstanceRequestId")]
        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestIdField; }
            set { this.spotInstanceRequestIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Spot Instance request that started this instance.
        /// </summary>
        /// <param name="spotInstanceRequestId">The ID of the Spot Instance request that
        /// started this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithSpotInstanceRequestId(string spotInstanceRequestId)
        {
            this.spotInstanceRequestIdField = spotInstanceRequestId;
            return this;
        }

        /// <summary>
        /// Checks if SpotInstanceRequestId property is set
        /// </summary>
        /// <returns>true if SpotInstanceRequestId property is set</returns>
        public bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestIdField != null;
        }

        /// <summary>
        /// The active license that is in use and attached to the Amazon EC2 instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "License")]
        public InstanceLicense License
        {
            get { return this.licenseField; }
            set { this.licenseField = value; }
        }

        /// <summary>
        /// Sets the active license that is in use and attached to the Amazon EC2 instance.
        /// </summary>
        /// <param name="license">The active license in use and attached to the
        /// Amazon EC2 instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithLicense(InstanceLicense license)
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
        /// Whether the Amazon EC2 instance is a hardware virtual machine
        /// (HVM) or a para-virtual machine (PVM).
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualizationType")]
        public string VirtualizationType
        {
            get { return this.virtualizationTypeField; }
            set { this.virtualizationTypeField = value; }
        }

        /// <summary>
        /// Sets whether the Amazon EC2 instance is a hardware virtual machine
        /// (HVM) or a para-virtual machine (PVM).
        /// </summary>
        /// <param name="virtualizationType">Specifies whether the Amazon EC2 instance is a
        /// hardware virtual machine
        /// (HVM) or a para-virtual machine (PVM).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithVirtualizationType(string virtualizationType)
        {
            this.virtualizationTypeField = virtualizationType;
            return this;
        }

        /// <summary>
        /// Checks if VirtualizationType property is set
        /// </summary>
        /// <returns>true if VirtualizationType property is set</returns>
        public bool IsSetVirtualizationType()
        {
            return this.virtualizationTypeField != null;
        }

        /// <summary>
        /// The idempotency token provided when you launched the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Sets the idempotency token provided when you launched the instance.
        /// </summary>
        /// <param name="clientToken">ClientToken property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithClientToken(string clientToken)
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
        /// A list of tags for the RunningInstance.
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
        /// Sets the tags for the RunningInstance.
        /// </summary>
        /// <param name="list">A list of tags for the RunningInstance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithTag(params Tag[] list)
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

        /// <summary>
        /// The instance's hypervisor type.
        /// </summary>
        [XmlElementAttribute(ElementName = "Hypervisor")]
        private string Hypervisor
        {
            get { return this.hypervisorField; }
            set { this.hypervisorField = value; }
        }

        /// <summary>
        /// Sets the instance's hypervisor type.
        /// </summary>
        /// <param name="hypervisor">The instance's hypervisor type.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithHypervisor(string hypervisor)
        {
            this.hypervisorField = hypervisor;
            return this;
        }

        /// <summary>
        /// Checks if the Hypervisor property is set.
        /// </summary>
        /// <returns>true if the Hypervisor property is set</returns>
        public bool IsSetHypervisor()
        {
            return !string.IsNullOrEmpty(this.hypervisorField);
        }

        /// <summary>
        /// The network interfaces for the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceSet")]
        public List<InstanceNetworkInterface> NetworkInterfaceSet
        {
            get
            {
                if (this.networkInterfaceSetField == null)
                {
                    this.networkInterfaceSetField = new List<InstanceNetworkInterface>();
                }
                return this.networkInterfaceSetField;
            }
            set { this.networkInterfaceSetField = value; }
        }

        /// <summary>
        /// Sets the network interfaces for the instance.
        /// </summary>
        /// <param name="list">Collection of InstanceNetworkInterface items</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithNetworkInterfaceSet(params InstanceNetworkInterface[] list)
        {
            foreach (InstanceNetworkInterface item in list)
            {
                this.NetworkInterfaceSet.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the NetworkInterfaceSet property is set
        /// </summary>
        /// <returns>true if the NetworkInterfaceSet property is set</returns>
        public bool IsSetNetworkInterfaceSet()
        {
            return (this.NetworkInterfaceSet.Count > 0);
        }

        /// <summary>
        /// Whether to use the EBS IOPS optimized option.
        /// </summary>
        [XmlElementAttribute(ElementName = "EbsOptimized")]
        public bool EbsOptimized
        {
            get { return this.ebsOptimizedField.GetValueOrDefault(); }
            set { this.ebsOptimizedField = value; }
        }

        /// <summary>
        /// Sets whether to use the EBS IOPS optimized option.
        /// </summary>
        /// <param name="ebsOptimized">Specifies whether to use the EBS
        /// IOPS optimized option.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithEbsOptimized(bool ebsOptimized)
        {
            this.ebsOptimizedField = ebsOptimized;
            return this;
        }

        /// <summary>
        /// Checks if EbsOptimized property is set
        /// </summary>
        /// <returns>true if EbsOptimized property is set</returns>
        public bool IsSetEbsOptimized()
        {
            return this.ebsOptimizedField.HasValue;
        }

        /// <summary>
        /// The IAM Instance Profile (IIP) associated with the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceProfile")]
        public IAMInstanceProfile InstanceProfile
        {
            get { return this.instanceProfileField; }
            set { this.instanceProfileField = value; }
        }

        /// <summary>
        /// Sets the IAM Instance Profile (IIP) associated with the instance.
        /// </summary>
        /// <param name="instanceProfile">An Identity and Access Management Instance Profile</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunningInstance WithInstanceProfile(IAMInstanceProfile instanceProfile)
        {
            this.instanceProfileField = instanceProfile;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceProfile property is set
        /// </summary>
        /// <returns>true if the InstanceProfile property is set</returns>
        public bool IsSetInstanceProfile()
        {
            return this.instanceProfileField != null;
        }

    }
}
