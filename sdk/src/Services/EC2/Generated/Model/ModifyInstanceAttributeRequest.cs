/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceAttribute operation.
    /// Modifies the specified attribute of the specified instance. You can specify only one
    /// attribute at a time.
    /// 
    ///  
    /// <para>
    ///  <b>Note: </b>Using this action to change the security groups associated with an elastic
    /// network interface (ENI) attached to an instance in a VPC can result in an error if
    /// the instance has more than one ENI. To change the security groups associated with
    /// an ENI attached to an instance that has multiple ENIs, we recommend that you use the
    /// <a>ModifyNetworkInterfaceAttribute</a> action.
    /// </para>
    ///  
    /// <para>
    /// To modify some attributes, the instance must be stopped. For more information, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying
    /// Attributes of a Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyInstanceAttributeRequest : AmazonEC2Request
    {
        private InstanceAttributeName _attribute;
        private List<InstanceBlockDeviceMappingSpecification> _blockDeviceMappings = new List<InstanceBlockDeviceMappingSpecification>();
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private bool? _enaSupport;
        private List<string> _groups = new List<string>();
        private string _instanceId;
        private string _instanceInitiatedShutdownBehavior;
        private string _instanceType;
        private string _kernel;
        private string _ramdisk;
        private bool? _sourceDestCheck;
        private string _sriovNetSupport;
        private string _userData;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyInstanceAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifyInstanceAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="attribute">The name of the attribute.</param>
        public ModifyInstanceAttributeRequest(string instanceId, InstanceAttributeName attribute)
        {
            _instanceId = instanceId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        /// </summary>
        public InstanceAttributeName Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Modifies the <code>DeleteOnTermination</code> attribute for volumes that are currently
        /// attached. The volume must be owned by the caller. If no value is specified for <code>DeleteOnTermination</code>,
        /// the default is <code>true</code> and the volume is deleted when the instance is terminated.
        /// </para>
        ///  
        /// <para>
        /// To add instance store volumes to an Amazon EBS-backed instance, you must add them
        /// when you launch the instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html#Using_OverridingAMIBDM">Updating
        /// the Block Device Mapping when Launching an Instance</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public List<InstanceBlockDeviceMappingSpecification> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// If the value is <code>true</code>, you can't terminate the instance using the Amazon
        /// EC2 console, CLI, or API; otherwise, you can. You cannot use this parameter for Spot
        /// Instances.
        /// </para>
        /// </summary>
        public bool DisableApiTermination
        {
            get { return this._disableApiTermination.GetValueOrDefault(); }
            set { this._disableApiTermination = value; }
        }

        // Check to see if DisableApiTermination property is set
        internal bool IsSetDisableApiTermination()
        {
            return this._disableApiTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal EBS I/O performance. This optimization isn't available with all instance
        /// types. Additional usage charges apply when using an EBS Optimized instance.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Set to <code>true</code> to enable enhanced networking with ENA for the instance.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM instances. Specifying this option with a PV
        /// instance can make it unreachable.
        /// </para>
        /// </summary>
        public bool EnaSupport
        {
            get { return this._enaSupport.GetValueOrDefault(); }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// [EC2-VPC] Changes the security groups of the instance. You must specify at least one
        /// security group, even if it's just the default security group for the VPC. You must
        /// specify the security group ID, not the security group name.
        /// </para>
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Specifies whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        /// </summary>
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this._instanceInitiatedShutdownBehavior; }
            set { this._instanceInitiatedShutdownBehavior = value; }
        }

        // Check to see if InstanceInitiatedShutdownBehavior property is set
        internal bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this._instanceInitiatedShutdownBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Changes the instance type to the specified value. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a>. If the instance type is not valid, the error returned is <code>InvalidInstanceAttributeValue</code>.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Kernel. 
        /// <para>
        /// Changes the instance's kernel to the specified value. We recommend that you use PV-GRUB
        /// instead of kernels and RAM disks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">PV-GRUB</a>.
        /// </para>
        /// </summary>
        public string Kernel
        {
            get { return this._kernel; }
            set { this._kernel = value; }
        }

        // Check to see if Kernel property is set
        internal bool IsSetKernel()
        {
            return this._kernel != null;
        }

        /// <summary>
        /// Gets and sets the property Ramdisk. 
        /// <para>
        /// Changes the instance's RAM disk to the specified value. We recommend that you use
        /// PV-GRUB instead of kernels and RAM disks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">PV-GRUB</a>.
        /// </para>
        /// </summary>
        public string Ramdisk
        {
            get { return this._ramdisk; }
            set { this._ramdisk = value; }
        }

        // Check to see if Ramdisk property is set
        internal bool IsSetRamdisk()
        {
            return this._ramdisk != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Specifies whether source/destination checking is enabled. A value of <code>true</code>
        /// means that checking is enabled, and <code>false</code> means that checking is disabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT.
        /// </para>
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this._sourceDestCheck.GetValueOrDefault(); }
            set { this._sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this._sourceDestCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Set to <code>simple</code> to enable enhanced networking with the Intel 82599 Virtual
        /// Function interface for the instance.
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
        public string SriovNetSupport
        {
            get { return this._sriovNetSupport; }
            set { this._sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this._sriovNetSupport != null;
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// Changes the instance's user data to the specified value. If you are using an AWS SDK
        /// or command line tool, base64-encoding is performed for you, and you can load the text
        /// from a file. Otherwise, you must provide base64-encoded text.
        /// </para>
        /// </summary>
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A new value for the attribute. Use only with the <code>kernel</code>, <code>ramdisk</code>,
        /// <code>userData</code>, <code>disableApiTermination</code>, or <code>instanceInitiatedShutdownBehavior</code>
        /// attribute.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}