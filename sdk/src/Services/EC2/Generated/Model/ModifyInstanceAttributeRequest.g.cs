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
    /// Container for the parameters to the ModifyInstanceAttribute operation. Modifies the
    /// specified attribute of the specified instance. You can specify only one attribute
    /// at a time. <para> <b>Note: </b>Using this action to change the security groups associated
    /// with an elastic network interface (ENI) attached to an instance can result in an error
    /// if the instance has more than one ENI. To change the security groups associated with
    /// an ENI attached to an instance that has multiple ENIs, we recommend that you use the
    /// <a>ModifyNetworkInterfaceAttribute</a> action. </para> <para> To modify some attributes,
    /// the instance must be stopped. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modify
    /// a stopped instance</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class ModifyInstanceAttributeRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ModifyInstanceAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifyInstanceAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="attribute">The name of the attribute to modify.   <note>   When changing the instance type: If the original instance type is configured for    configurable bandwidth, and the desired instance type doesn't support configurable    bandwidth, first set the existing bandwidth configuration to <c>default</c>    using the <a>ModifyInstanceNetworkPerformanceOptions</a>    operation.   </note>   <important>   You can modify the following attributes only: <c>disableApiTermination</c> |     <c>instanceType</c> | <c>kernel</c> | <c>ramdisk</c> |     <c>instanceInitiatedShutdownBehavior</c> | <c>blockDeviceMapping</c>    | <c>userData</c> | <c>sourceDestCheck</c> | <c>groupSet</c> |     <c>ebsOptimized</c> | <c>sriovNetSupport</c> |     <c>enaSupport</c> | <c>nvmeSupport</c> | <c>disableApiStop</c>    | <c>enclaveOptions</c>      </important></param>
        public ModifyInstanceAttributeRequest(string instanceId, InstanceAttributeName attribute)
        {
            this.InstanceId = instanceId;
            this.Attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute to modify.
        /// </para>
        ///  <note> 
        /// <para>
        /// When changing the instance type: If the original instance type is configured for configurable
        /// bandwidth, and the desired instance type doesn't support configurable bandwidth, first
        /// set the existing bandwidth configuration to <c>default</c> using the <a>ModifyInstanceNetworkPerformanceOptions</a>
        /// operation.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You can modify the following attributes only: <c>disableApiTermination</c> | <c>instanceType</c>
        /// | <c>kernel</c> | <c>ramdisk</c> | <c>instanceInitiatedShutdownBehavior</c> | <c>blockDeviceMapping</c>
        /// | <c>userData</c> | <c>sourceDestCheck</c> | <c>groupSet</c> | <c>ebsOptimized</c>
        /// | <c>sriovNetSupport</c> | <c>enaSupport</c> | <c>nvmeSupport</c> | <c>disableApiStop</c>
        /// | <c>enclaveOptions</c> 
        /// </para>
        ///  </important>
        /// </summary>
        public InstanceAttributeName Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Modifies the <c>DeleteOnTermination</c> attribute for volumes that are currently attached.
        /// The volume must be owned by the caller. If no value is specified for <c>DeleteOnTermination</c>,
        /// the default is <c>true</c> and the volume is deleted when the instance is terminated.
        /// You can't modify the <c>DeleteOnTermination</c> attribute for volumes that are attached
        /// to Amazon Web Services-managed resources.
        /// </para>
        ///  
        /// <para>
        /// To add instance store volumes to an Amazon EBS-backed instance, you must add them
        /// when you launch the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html#Using_OverridingAMIBDM">Update
        /// the block device mapping when launching an instance</a> in the <i>Amazon EC2 User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceBlockDeviceMappingSpecification> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceBlockDeviceMappingSpecification>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Indicates whether an instance is enabled for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html">Enable
        /// stop protection for your instance</a>.
        /// </para>
        ///  
        /// <para>
        /// 
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
        /// Enable or disable termination protection for the instance. If the value is <c>true</c>,
        /// you can't terminate the instance using the Amazon EC2 console, command line interface,
        /// or API. You can't enable termination protection for Spot Instances.
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
        /// Specifies whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal EBS I/O performance. This optimization isn't available with all instance
        /// types. Additional usage charges apply when using an EBS Optimized instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Set to <c>true</c> to enable enhanced networking with ENA for the instance.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM instances. Specifying this option with a PV
        /// instance can make it unreachable.
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
        /// Enables or disables the instance for Amazon Web Services Nitro Enclaves. For more
        /// information, see the <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves User Guide</a>.
        /// </para>
        /// </summary>
        public EnclaveOptionsRequest EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// Replaces the security groups of the instance with the specified security groups. You
        /// must specify the ID of at least one security group, even if it's just the default
        /// security group for the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Specifies whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        /// </summary>
        public string InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInitiatedShutdownBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInitiatedShutdownBehavior() => this.InstanceInitiatedShutdownBehavior != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Changes the instance type to the specified value. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>. If the instance type is not valid,
        /// the error returned is <c>InvalidInstanceAttributeValue</c>.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Kernel. 
        /// <para>
        /// Changes the instance's kernel to the specified value. We recommend that you use PV-GRUB
        /// instead of kernels and RAM disks. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">PV-GRUB</a>.
        /// </para>
        /// </summary>
        public string Kernel { get; set; }

        /// <summary>
        /// Checks to see if the Kernel property is set.
        /// </summary>
        internal bool IsSetKernel() => this.Kernel != null;

        /// <summary>
        /// Gets and sets the property Ramdisk. 
        /// <para>
        /// Changes the instance's RAM disk to the specified value. We recommend that you use
        /// PV-GRUB instead of kernels and RAM disks. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">PV-GRUB</a>.
        /// </para>
        /// </summary>
        public string Ramdisk { get; set; }

        /// <summary>
        /// Checks to see if the Ramdisk property is set.
        /// </summary>
        internal bool IsSetRamdisk() => this.Ramdisk != null;

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Enable or disable source/destination checks, which ensure that the instance is either
        /// the source or the destination of any traffic that it receives. If the value is <c>true</c>,
        /// source/destination checks are enabled; otherwise, they are disabled. The default value
        /// is <c>true</c>. You must disable source/destination checks if the instance runs services
        /// such as network address translation, routing, or firewalls.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Set to <c>simple</c> to enable enhanced networking with the Intel 82599 Virtual Function
        /// interface for the instance.
        /// </para>
        ///  
        /// <para>
        /// There is no way to disable enhanced networking with the Intel 82599 Virtual Function
        /// interface at this time.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM instances. Specifying this option with a PV
        /// instance can make it unreachable.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// Changes the instance's user data to the specified value. User data must be base64-encoded.
        /// Depending on the tool or SDK that you're using, the base64-encoding might be performed
        /// for you. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instancedata-add-user-data.html">Work
        /// with instance user data</a>.
        /// </para>
        /// </summary>
        public SecureBlobAttributeValue UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A new value for the attribute. Use only with the <c>kernel</c>, <c>ramdisk</c>, <c>userData</c>,
        /// <c>disableApiTermination</c>, or <c>instanceInitiatedShutdownBehavior</c> attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
