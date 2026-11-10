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
    /// Container for the parameters to the RunInstances operation. Launches the specified
    /// number of instances using an AMI for which you have permissions. <para> You can specify
    /// a number of options, or leave the default options. The following rules apply: </para>
    /// <ul> <li> <para> If you don't specify a subnet ID, we choose a default subnet from
    /// your default VPC for you. If you don't have a default VPC, you must specify a subnet
    /// ID in the request. </para> </li> <li> <para> All instances have a network interface
    /// with a primary private IPv4 address. If you don't specify this address, we choose
    /// one from the IPv4 range of your subnet. </para> </li> <li> <para> Not all instance
    /// types support IPv6 addresses. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
    /// types</a>. </para> </li> <li> <para> If you don't specify a security group ID, we
    /// use the default security group for the VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
    /// groups</a>. </para> </li> <li> <para> If any of the AMIs have a product code attached
    /// for which the user has not subscribed, the request fails. </para> </li> </ul> <para>
    /// You can create a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
    /// template</a>, which is a resource that contains the parameters to launch an instance.
    /// When you launch an instance using <a>RunInstances</a>, you can specify the launch
    /// template instead of specifying the launch parameters. </para> <para> To ensure faster
    /// instance launches, break up large requests into smaller batches. For example, create
    /// five separate launch requests for 100 instances each instead of one launch request
    /// for 500 instances. </para> <para> <c>RunInstances</c> is subject to both request rate
    /// limiting and resource rate limiting. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-throttling.html">Request
    /// throttling</a>. </para> <para> An instance is ready for you to use when it's in the
    /// <c>running</c> state. You can check the state of your instance using <a>DescribeInstances</a>.
    /// You can tag instances and EBS volumes during launch, after launch, or both. For more
    /// information, see <a>CreateTags</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// your Amazon EC2 resources</a>. </para> <para> Linux instances have access to the public
    /// key of the key pair at boot. You can use this key to provide secure access to the
    /// instance. Amazon EC2 public images use this feature to provide secure access without
    /// passwords. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// pairs</a>. </para> <para> For troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
    /// to do if an instance immediately terminates</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
    /// connecting to your instance</a>. </para>
    /// </summary>
    public partial class RunInstancesRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public RunInstancesRequest() { }

        /// <summary>
        /// Instantiates RunInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI. An AMI ID is required to launch an instance and must be specified   here or in a launch template.</param>
        /// <param name="minCount">The minimum number of instances to launch. If you specify a value that is more   capacity than Amazon EC2 can provide in the target Availability Zone, Amazon EC2 does   not launch any instances.   Constraints: Between 1 and the quota for the specified instance type for your account for this Region.   For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon EC2 instance type quotas</a>.</param>
        /// <param name="maxCount">The maximum number of instances to launch. If you specify a value that is more   capacity than Amazon EC2 can launch in the target Availability Zone, Amazon EC2    launches the largest possible number of instances above the specified minimum   count.   Constraints: Between 1 and the quota for the specified instance type for your account for this Region.    For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon EC2 instance type quotas</a>.</param>
        public RunInstancesRequest(string imageId, int? minCount, int? maxCount)
        {
            this.ImageId = imageId;
            this.MinCount = minCount;
            this.MaxCount = maxCount;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping, which defines the EBS volumes and instance store volumes
        /// to attach to the instance at launch. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// device mappings</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option. If you do not specify
        /// this parameter, the instance's Capacity Reservation preference defaults to <c>open</c>,
        /// which enables it to run in any open Capacity Reservation that has matching attributes
        /// (instance type, platform, Availability Zone, and tenancy).
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, a randomly generated token is used for the request
        /// to ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency in Amazon EC2 API requests</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 64 ASCII characters
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
        /// The CPU options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">Optimize
        /// CPU options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public CpuOptionsRequest CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// The credit option for CPU usage of the burstable performance instance. Valid values
        /// are <c>standard</c> and <c>unlimited</c>. To change this attribute after launch, use
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceCreditSpecification.html">
        /// ModifyInstanceCreditSpecification</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>standard</c> (T2 instances) or <c>unlimited</c> (T3/T3a/T4g instances)
        /// </para>
        ///  
        /// <para>
        /// For T3 instances with <c>host</c> tenancy, only <c>standard</c> is supported.
        /// </para>
        /// </summary>
        public CreditSpecificationRequest CreditSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CreditSpecification property is set.
        /// </summary>
        internal bool IsSetCreditSpecification() => this.CreditSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Indicates whether an instance is enabled for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html">Enable
        /// stop protection for your EC2 instances</a>.
        /// </para>
        /// </summary>
        public bool? DisableApiStop { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiStop property is set.
        /// </summary>
        internal bool IsSetDisableApiStop() => this.DisableApiStop.HasValue;

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// Indicates whether termination protection is enabled for the instance. The default
        /// is <c>false</c>, which means that you can terminate the instance using the Amazon
        /// EC2 console, command line tools, or API. You can enable termination protection when
        /// you launch an instance, while the instance is running, or while the instance is stopped.
        /// </para>
        /// </summary>
        public bool? DisableApiTermination { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiTermination property is set.
        /// </summary>
        internal bool IsSetDisableApiTermination() => this.DisableApiTermination.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal Amazon EBS I/O performance. This optimization isn't available with
        /// all instance types. Additional usage charges apply when using an EBS-optimized instance.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticGpuSpecification. 
        /// <para>
        /// An elastic GPU to associate with the instance.
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
        [Obsolete("Specifying Elastic Graphics accelerators is no longer supported on the RunInstances API.")]
        public List<ElasticGpuSpecification> ElasticGpuSpecification { get; set; } = AWSConfigs.InitializeCollections ? new List<ElasticGpuSpecification>() : null;

        /// <summary>
        /// Checks to see if the ElasticGpuSpecification property is set.
        /// </summary>
        internal bool IsSetElasticGpuSpecification() => this.ElasticGpuSpecification != null && (this.ElasticGpuSpecification.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElasticInferenceAccelerators. 
        /// <para>
        /// An elastic inference accelerator to associate with the instance.
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
        [Obsolete("Specifying Elastic Inference accelerators is no longer supported on the RunInstances API.")]
        public List<ElasticInferenceAccelerator> ElasticInferenceAccelerators { get; set; } = AWSConfigs.InitializeCollections ? new List<ElasticInferenceAccelerator>() : null;

        /// <summary>
        /// Checks to see if the ElasticInferenceAccelerators property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAccelerators() => this.ElasticInferenceAccelerators != null && (this.ElasticInferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// If you’re launching an instance into a dual-stack or IPv6-only subnet, you can enable
        /// assigning a primary IPv6 address. A primary IPv6 address is an IPv6 GUA address associated
        /// with an ENI that you have enabled to use a primary IPv6 address. Use this option if
        /// an instance relies on its IPv6 address not changing. When you launch the instance,
        /// Amazon Web Services will automatically assign an IPv6 address associated with the
        /// ENI attached to your instance to be the primary IPv6 address. Once you enable an IPv6
        /// GUA address to be a primary IPv6, you cannot disable it. When you enable an IPv6 GUA
        /// address to be a primary IPv6, the first IPv6 GUA will be made the primary IPv6 address
        /// until the instance is terminated or the network interface is detached. If you have
        /// multiple IPv6 addresses associated with an ENI attached to your instance and you enable
        /// a primary IPv6 address, the first IPv6 GUA address associated with the ENI becomes
        /// the primary IPv6 address.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrimaryIpv6 property is set.
        /// </summary>
        internal bool IsSetEnablePrimaryIpv6() => this.EnablePrimaryIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/">Amazon
        /// Web Services Nitro Enclaves User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can't enable Amazon Web Services Nitro Enclaves and hibernation on the same instance.
        /// </para>
        /// </summary>
        public EnclaveOptionsRequest EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Indicates whether an instance is enabled for hibernation. This parameter is valid
        /// only if the instance meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html">hibernation
        /// prerequisites</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't enable hibernation and Amazon Web Services Nitro Enclaves on the same instance.
        /// </para>
        /// </summary>
        public HibernationOptionsRequest HibernationOptions { get; set; }

        /// <summary>
        /// Checks to see if the HibernationOptions property is set.
        /// </summary>
        internal bool IsSetHibernationOptions() => this.HibernationOptions != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of an IAM instance profile.
        /// </para>
        /// </summary>
        public IamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI. An AMI ID is required to launch an instance and must be specified
        /// here or in a launch template.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        ///  
        /// <para>
        /// Default: <c>stop</c> 
        /// </para>
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInitiatedShutdownBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInitiatedShutdownBehavior() => this.InstanceInitiatedShutdownBehavior != null;

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// The market (purchasing) option for the instances.
        /// </para>
        ///  
        /// <para>
        /// For <a>RunInstances</a>, persistent Spot Instance requests are only supported when
        /// <b>InstanceInterruptionBehavior</b> is set to either <c>hibernate</c> or <c>stop</c>.
        /// </para>
        /// </summary>
        public InstanceMarketOptionsRequest InstanceMarketOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMarketOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMarketOptions() => this.InstanceMarketOptions != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/instance-types.html">Amazon
        /// EC2 Instance Types Guide</a>.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// The number of IPv6 addresses to associate with the primary network interface. Amazon
        /// EC2 chooses the IPv6 addresses from the range of your subnet. You cannot specify this
        /// option and the option to assign specific IPv6 addresses in the same request. You can
        /// specify this option if you've specified a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// </summary>
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressCount property is set.
        /// </summary>
        internal bool IsSetIpv6AddressCount() => this.Ipv6AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses from the range of the subnet to associate with the primary network
        /// interface. You cannot specify this option and the option to assign a number of IPv6
        /// addresses in the same request. You cannot specify this option if you've specified
        /// a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">PV-GRUB</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-key-pairs.html">Create
        /// a key pair for your EC2 instance</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you do not specify a key pair, you can't connect to the instance unless you choose
        /// an AMI that is configured to allow users another way to log in.
        /// </para>
        ///  </important>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template. Any additional parameters that you specify for the new instance
        /// overwrite the corresponding parameters included in the launch template.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The license configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseConfigurationRequest> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseConfigurationRequest>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// The maintenance and recovery options for the instance.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptionsRequest MaintenanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceOptions property is set.
        /// </summary>
        internal bool IsSetMaintenanceOptions() => this.MaintenanceOptions != null;

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of instances to launch. If you specify a value that is more capacity
        /// than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches the
        /// largest possible number of instances above the specified minimum count.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the quota for the specified instance type for your account
        /// for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon
        /// EC2 instance type quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
        /// the Instance Metadata Service options</a>.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsRequest MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property MinCount. 
        /// <para>
        /// The minimum number of instances to launch. If you specify a value that is more capacity
        /// than Amazon EC2 can provide in the target Availability Zone, Amazon EC2 does not launch
        /// any instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the quota for the specified instance type for your account
        /// for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon
        /// EC2 instance type quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinCount { get; set; }

        /// <summary>
        /// Checks to see if the MinCount property is set.
        /// </summary>
        internal bool IsSetMinCount() => this.MinCount.HasValue;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// Specifies whether detailed monitoring is enabled for the instance.
        /// </para>
        /// </summary>
        public bool? Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces to associate with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceNetworkInterfaceSpecification>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Contains settings for the network performance options for the instance.
        /// </para>
        /// </summary>
        public InstanceNetworkPerformanceOptionsRequest NetworkPerformanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformanceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkPerformanceOptions() => this.NetworkPerformanceOptions != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement for the instance.
        /// </para>
        /// </summary>
        public Placement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname. The default values are inherited from the subnet.
        /// Applies only if creating a network interface, not attaching an existing one.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsRequest PrivateDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptions() => this.PrivateDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The primary IPv4 address. You must specify a value from the IPv4 address range of
        /// the subnet.
        /// </para>
        ///  
        /// <para>
        /// Only one private IP address can be designated as primary. You can't specify this option
        /// if you've specified the option to designate a private IP address as the primary IP
        /// address in a network interface specification. You cannot specify this option if you're
        /// launching more than one instance in the request.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk to select. Some kernels require additional drivers at launch.
        /// Check the kernel requirements for information about whether you need to specify a
        /// RAM disk. To find kernel requirements, go to the Amazon Web Services Resource Center
        /// and search for the kernel ID.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">PV-GRUB</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property SecondaryInterfaces. 
        /// <para>
        /// The secondary interfaces to associate with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceSecondaryInterfaceSpecificationRequest> SecondaryInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceSecondaryInterfaceSpecificationRequest>() : null;

        /// <summary>
        /// Checks to see if the SecondaryInterfaces property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaces() => this.SecondaryInterfaces != null && (this.SecondaryInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface instead of using this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// [Default VPC] The names of the security groups.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface instead of using this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon EC2 uses the default security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to launch the instance into.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any subnets as part of the network
        /// interface instead of using this parameter.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the resources that are created during instance launch.
        /// </para>
        ///  
        /// <para>
        /// You can specify tags for the following resources only:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Volumes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Instance requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network interfaces
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To tag a resource after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data to make available to the instance. User data must be base64-encoded.
        /// Depending on the tool or SDK that you're using, the base64-encoding might be performed
        /// for you. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html">Run
        /// commands at launch using instance user data</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}
