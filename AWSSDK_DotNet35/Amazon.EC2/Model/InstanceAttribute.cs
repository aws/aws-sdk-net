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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an instance attribute.</para>
    /// </summary>
    public class InstanceAttribute
    {
        
        private string instanceId;
        private string instanceType;
        private string kernelId;
        private string ramdiskId;
        private string userData;
        private bool? disableApiTermination;
        private string instanceInitiatedShutdownBehavior;
        private string rootDeviceName;
        private List<InstanceBlockDeviceMapping> blockDeviceMappings = new List<InstanceBlockDeviceMapping>();
        private List<ProductCode> productCodes = new List<ProductCode>();
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
        /// The instance type.
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
        /// The kernel ID.
        ///  
        /// </summary>
        public string KernelId
        {
            get { return this.kernelId; }
            set { this.kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this.kernelId != null;
        }

        /// <summary>
        /// The RAM disk ID.
        ///  
        /// </summary>
        public string RamdiskId
        {
            get { return this.ramdiskId; }
            set { this.ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;
        }

        /// <summary>
        /// The Base64-encoded MIME user data.
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
        /// If the value is <c>true</c>, you can't terminate the instance through the Amazon EC2 console, CLI, or API; otherwise, you can.
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
        /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance (using the operating system command for
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
        /// The name of the root device (for example, <c>/dev/sda1</c>).
        ///  
        /// </summary>
        public string RootDeviceName
        {
            get { return this.rootDeviceName; }
            set { this.rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this.rootDeviceName != null;
        }

        /// <summary>
        /// The block device mapping of the instance.
        ///  
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings
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
        /// A list of product codes.
        ///  
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }

        /// <summary>
        /// Indicates whether the instance is optimized for EBS I/O.
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
