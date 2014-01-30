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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceAttribute operation.
    /// <para>Modifies the specified attribute of the specified instance. You can specify only one attribute at a time.</para> <para>To modify some
    /// attributes, the instance must be stopped. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html" >Modifying Attributes of a
    /// Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class ModifyInstanceAttributeRequest : AmazonEC2Request
    {
        private string instanceId;
        private InstanceAttributeName attribute;
        private string value;
        private List<InstanceBlockDeviceMappingSpecification> blockDeviceMappings = new List<InstanceBlockDeviceMappingSpecification>();
        private bool? sourceDestCheck;
        private bool? disableApiTermination;
        private string instanceType;
        private string kernel;
        private string ramdisk;
        private string userData;
        private string instanceInitiatedShutdownBehavior;
        private List<string> groups = new List<string>();
        private bool? ebsOptimized;
        private string sriovNetSupport;


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The name of the attribute.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>instanceType, kernel, ramdisk, userData, disableApiTermination, instanceInitiatedShutdownBehavior, rootDeviceName, blockDeviceMapping, productCodes, sourceDestCheck, groupSet, ebsOptimized</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceAttributeName Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

        /// <summary>
        /// A new value for the attribute. Use only with the <c>kernel</c>, <c>ramdisk</c>, <c>userData</c>, <c>disableApiTermination</c>, or
        /// <c>intanceInitiateShutdownBehavior</c> attribute.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// Modifies the <c>DeleteOnTermination</c> attribute for volumes that are currently attached. The volume must be owned by the caller. If no
        /// value is specified for <c>DeleteOnTermination</c>, the default is <c>true</c> and the volume is deleted when the instance is terminated. To
        /// add instance store volumes to an Amazon EBS-backed instance, you must add them when you launch the instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html#Using_OverridingAMIBDM">Updating the Block
        /// Device Mapping when Launching an Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// </summary>
        public List<InstanceBlockDeviceMappingSpecification> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

        /// <summary>
        /// Specifies whether source/destination checking is enabled. A value of <c>true</c> means that checking is enabled, and <c>false</c> means
        /// checking is disabled. This value must be <c>false</c> for a NAT instance to perform NAT.
        ///  
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheck ?? default(bool); }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck.HasValue;
        }

        /// <summary>
        /// Specifies whether to disable the ability to terminate the instance using the Amazon EC2 console, CLI, and API.
        ///  
        /// </summary>
        public bool DisableApiTermination
        {
            get { return this.disableApiTermination ?? default(bool); }
            set { this.disableApiTermination = value; }
        }

        // Check to see if DisableApiTermination property is set
        internal bool IsSetDisableApiTermination()
        {
            return this.disableApiTermination.HasValue;
        }

        /// <summary>
        /// Changes the instance type to the specified value. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Types</a>. If the instance type is not valid, the
        /// error returned is <c>InvalidInstanceAttributeValue</c>.
        ///  
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// Changes the instance's kernel to the specified value.
        ///  
        /// </summary>
        public string Kernel
        {
            get { return this.kernel; }
            set { this.kernel = value; }
        }

        // Check to see if Kernel property is set
        internal bool IsSetKernel()
        {
            return this.kernel != null;
        }

        /// <summary>
        /// Changes the instance's RAM disk to the specified value.
        ///  
        /// </summary>
        public string Ramdisk
        {
            get { return this.ramdisk; }
            set { this.ramdisk = value; }
        }

        // Check to see if Ramdisk property is set
        internal bool IsSetRamdisk()
        {
            return this.ramdisk != null;
        }

        /// <summary>
        /// Changes the instance's user data to the specified value.
        ///  
        /// </summary>
        public string UserData
        {
            get { return this.userData; }
            set { this.userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;
        }

        /// <summary>
        /// Specifies whether an instance stops or terminates when you initiate shutdown from the instance (using the operating system command for
        /// system shutdown).
        ///  
        /// </summary>
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehavior; }
            set { this.instanceInitiatedShutdownBehavior = value; }
        }

        // Check to see if InstanceInitiatedShutdownBehavior property is set
        internal bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehavior != null;
        }

        /// <summary>
        /// [EC2-VPC] Changes the security groups of the instance. You must specify at least one security group, even if it's just the default security
        /// group for the VPC. You must specify the security group ID, not the security group name. For example, if you want the instance to be in
        /// sg-1a1a1a1a and sg-9b9b9b9b, specify <c>GroupId.1=sg-1a1a1a1a</c> and <c>GroupId.2=sg-9b9b9b9b</c>.
        ///  
        /// </summary>
        public List<string> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }

        /// <summary>
        /// Specifies whether the instance is optimized for EBS I/O. This optimization provides dedicated throughput to Amazon EBS and an optimized
        /// configuration stack to provide optimal EBS I/O performance. This optimization isn't available with all instance types. Additional usage
        /// charges apply when using an EBS Optimized instance.
        ///  
        /// </summary>
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string SriovNetSupport
        {
            get { return this.sriovNetSupport; }
            set { this.sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this.sriovNetSupport != null;
        }

    }
}
    
