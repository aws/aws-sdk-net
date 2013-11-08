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
    /// <para> Modifies an attribute of an instance. </para>
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


        /// <summary>
        /// The ID of the instance whose attribute is being modified.
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
        /// The name of the attribute being modified. Available attribute names: <c>instanceType</c>, <c>kernel</c>, <c>ramdisk</c>, <c>userData</c>,
        /// <c>disableApiTermination</c>, <c>instanceInitiatedShutdownBehavior</c>, <c>rootDevice</c>, <c>blockDeviceMapping</c>
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
        /// The new value of the instance attribute being modified. Only valid when <c>kernel</c>, <c>ramdisk</c>, <c>userData</c>,
        /// <c>disableApiTermination</c> or <c>instanceInitiateShutdownBehavior</c> is specified as the attribute being modified.
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
        /// The new block device mappings for the instance whose attributes are being modified. Only valid when blockDeviceMapping is specified as the
        /// attribute being modified.
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
        /// Boolean value
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
        /// Boolean value
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
        /// String value
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
        /// String value
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
        /// String value
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
        /// String value
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
        /// String value
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
        /// Boolean value
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

    }
}
    
