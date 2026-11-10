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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes an instance.
    /// </summary>
    public partial class Instance
    {
        /// <summary>
        /// Gets and sets the property AmiLaunchIndex. 
        /// <para>
        /// The AMI launch index, which can be used to find this instance in the launch group.
        /// </para>
        /// </summary>
        public int? AmiLaunchIndex { get; set; }

        /// <summary>
        /// Checks to see if the AmiLaunchIndex property is set.
        /// </summary>
        internal bool IsSetAmiLaunchIndex() => this.AmiLaunchIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the image.
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Any block device mapping entries for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceBlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode that was specified by the AMI. If the value is <c>uefi-preferred</c>,
        /// the AMI supports both UEFI and Legacy BIOS. The <c>currentInstanceBootMode</c> parameter
        /// is the boot mode that is used to boot the instance at launch or start.
        /// </para>
        ///  <note> 
        /// <para>
        /// The operating system contained in the AMI must be configured to support the specified
        /// boot mode.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public BootModeValues BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block.
        /// </para>
        ///  <note> 
        /// <para>
        /// For P5 instances, a Capacity Block ID refers to a group of instances. For Trn2u instances,
        /// a capacity block ID refers to an EC2 UltraServer.
        /// </para>
        ///  </note>
        /// </summary>
        public string CapacityBlockId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockId() => this.CapacityBlockId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option.
        /// </para>
        /// </summary>
        public CapacityReservationSpecificationResponse CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token you provided when you launched the instance, if applicable.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU options for the instance.
        /// </para>
        /// </summary>
        public CpuOptions CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property CurrentInstanceBootMode. 
        /// <para>
        /// The boot mode that is used to boot the instance at launch or start. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceBootModeValues CurrentInstanceBootMode { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInstanceBootMode property is set.
        /// </summary>
        internal bool IsSetCurrentInstanceBootMode() => this.CurrentInstanceBootMode != null;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal I/O performance. This optimization isn't available with all instance
        /// types. Additional usage charges apply when using an EBS Optimized instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociations. 
        /// <para>
        /// Deprecated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Elastic Graphics reached end of life on January 8, 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ElasticGpuAssociation> ElasticGpuAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<ElasticGpuAssociation>() : null;

        /// <summary>
        /// Checks to see if the ElasticGpuAssociations property is set.
        /// </summary>
        internal bool IsSetElasticGpuAssociations() => this.ElasticGpuAssociations != null && (this.ElasticGpuAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociations. 
        /// <para>
        /// Deprecated
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Elastic Inference is no longer available.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ElasticInferenceAcceleratorAssociation> ElasticInferenceAcceleratorAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<ElasticInferenceAcceleratorAssociation>() : null;

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorAssociations property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorAssociations() => this.ElasticInferenceAcceleratorAssociations != null && (this.ElasticInferenceAcceleratorAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Specifies whether enhanced networking with ENA is enabled.
        /// </para>
        /// </summary>
        public bool? EnaSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnaSupport property is set.
        /// </summary>
        internal bool IsSetEnaSupport() => this.EnaSupport.HasValue;

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// </para>
        /// </summary>
        public EnclaveOptions EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for hibernation.
        /// </para>
        /// </summary>
        public HibernationOptions HibernationOptions { get; set; }

        /// <summary>
        /// Checks to see if the HibernationOptions property is set.
        /// </summary>
        internal bool IsSetHibernationOptions() => this.HibernationOptions != null;

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor type of the instance. The value <c>xen</c> is used for both Xen and
        /// Nitro hypervisors.
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor { get; set; }

        /// <summary>
        /// Checks to see if the Hypervisor property is set.
        /// </summary>
        internal bool IsSetHypervisor() => this.Hypervisor != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile associated with the instance, if applicable.
        /// </para>
        /// </summary>
        public IamInstanceProfile IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI used to launch the instance.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceLifecycle. 
        /// <para>
        /// Indicates whether this is a Spot Instance or a Scheduled Instance.
        /// </para>
        /// </summary>
        public InstanceLifecycleType InstanceLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLifecycle property is set.
        /// </summary>
        internal bool IsSetInstanceLifecycle() => this.InstanceLifecycle != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address assigned to the instance.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The kernel associated with this instance, if applicable.
        /// </para>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair, if this instance was launched with an associated key pair.
        /// </para>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time that the instance was last launched. To determine the time that instance
        /// was first launched, see the attachment time for the primary network interface.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property Licenses. 
        /// <para>
        /// The license configurations for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseConfiguration> Licenses { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Licenses property is set.
        /// </summary>
        internal bool IsSetLicenses() => this.Licenses != null && (this.Licenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// Provides information on the recovery and maintenance options of your instance.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptions MaintenanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceOptions property is set.
        /// </summary>
        internal bool IsSetMaintenanceOptions() => this.MaintenanceOptions != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instance.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsResponse MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring for the instance.
        /// </para>
        /// </summary>
        public Monitoring Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceNetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceNetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Contains settings for the network performance options for your instance.
        /// </para>
        /// </summary>
        public InstanceNetworkPerformanceOptions NetworkPerformanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformanceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkPerformanceOptions() => this.NetworkPerformanceOptions != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the instance.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The location where the instance launched, if applicable.
        /// </para>
        /// </summary>
        public Placement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform. This value is <c>windows</c> for Windows instances; otherwise, it is
        /// empty.
        /// </para>
        /// </summary>
        public PlatformValues Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PlatformDetails. 
        /// <para>
        /// The platform details value for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html">AMI
        /// billing information fields</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformDetails { get; set; }

        /// <summary>
        /// Checks to see if the PlatformDetails property is set.
        /// </summary>
        internal bool IsSetPlatformDetails() => this.PlatformDetails != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// [IPv4 only] The private DNS hostname name assigned to the instance. This DNS hostname
        /// can only be used inside the Amazon EC2 network. This name is not available until the
        /// instance enters the <c>running</c> state. 
        /// </para>
        ///  
        /// <para>
        /// The Amazon-provided DNS server resolves Amazon-provided private DNS hostnames if you've
        /// enabled DNS resolution and DNS hostnames in your VPC. If you are not using the Amazon-provided
        /// DNS server in your VPC, your custom domain name servers must resolve the hostname
        /// as appropriate.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsResponse PrivateDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptions() => this.PrivateDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IPv4 address assigned to the instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes attached to this instance, if applicable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Checks to see if the ProductCodes property is set.
        /// </summary>
        internal bool IsSetProductCodes() => this.ProductCodes != null && (this.ProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name assigned to the instance. This name is not available until the
        /// instance enters the <c>running</c> state. This name is only available if you've enabled
        /// DNS hostnames for your VPC. The format of this name depends on the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hostname-types.html#public-hostnames">public
        /// hostname type</a>.
        /// </para>
        /// </summary>
        public string PublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PublicDnsName property is set.
        /// </summary>
        internal bool IsSetPublicDnsName() => this.PublicDnsName != null;

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IPv4 address, or the Carrier IP address assigned to the instance, if applicable.
        /// </para>
        ///  
        /// <para>
        /// A Carrier IP address only applies to an instance launched in a subnet associated with
        /// a Wavelength Zone.
        /// </para>
        /// </summary>
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpAddress property is set.
        /// </summary>
        internal bool IsSetPublicIpAddress() => this.PublicIpAddress != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk associated with this instance, if applicable.
        /// </para>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The device name of the root device volume (for example, <c>/dev/sda1</c>).
        /// </para>
        /// </summary>
        public string RootDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceName property is set.
        /// </summary>
        internal bool IsSetRootDeviceName() => this.RootDeviceName != null;

        /// <summary>
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The root device type used by the AMI. The AMI can use an EBS volume or an instance
        /// store volume.
        /// </para>
        /// </summary>
        public DeviceType RootDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceType property is set.
        /// </summary>
        internal bool IsSetRootDeviceType() => this.RootDeviceType != null;

        /// <summary>
        /// Gets and sets the property SecondaryInterfaces. 
        /// <para>
        /// The secondary interfaces for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceSecondaryInterface> SecondaryInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceSecondaryInterface>() : null;

        /// <summary>
        /// Checks to see if the SecondaryInterfaces property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaces() => this.SecondaryInterfaces != null && (this.SecondaryInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupIdentifier> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupIdentifier>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// If the request is a Spot Instance request, the ID of the request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceRequestId property is set.
        /// </summary>
        internal bool IsSetSpotInstanceRequestId() => this.SpotInstanceRequestId != null;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Specifies whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        /// </summary>
        public InstanceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the most recent state transition.
        /// </para>
        /// </summary>
        public StateReason StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason for the most recent state transition. This might be an empty string.
        /// </para>
        /// </summary>
        public string StateTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionReason property is set.
        /// </summary>
        internal bool IsSetStateTransitionReason() => this.StateTransitionReason != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the instance is running.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the instance is configured for NitroTPM support, the value is <c>v2.0</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string TpmSupport { get; set; }

        /// <summary>
        /// Checks to see if the TpmSupport property is set.
        /// </summary>
        internal bool IsSetTpmSupport() => this.TpmSupport != null;

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation value for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html">AMI
        /// billing information fields</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;

        /// <summary>
        /// Gets and sets the property UsageOperationUpdateTime. 
        /// <para>
        /// The time that the usage operation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UsageOperationUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperationUpdateTime property is set.
        /// </summary>
        internal bool IsSetUsageOperationUpdateTime() => this.UsageOperationUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The virtualization type of the instance.
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualizationType property is set.
        /// </summary>
        internal bool IsSetVirtualizationType() => this.VirtualizationType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the instance is running.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
