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
    /// A list of instance attributes.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceAttribute
    {    
        private string instanceIdField;
        private string instanceTypeField;
        private string kernelIdField;
        private string ramdiskIdField;
        private string userDataField;
        private bool? disableApiTerminationField;
        private string instanceInitiatedShutdownBehaviorField;
        private string rootDeviceNameField;
        private List<InstanceBlockDeviceMapping> blockDeviceMappingField;
        private bool? sourceDestCheckField;
        private List<string> groupNameField;
        private List<string> groupIdField;
        private List<ProductCode> productCodesField;
        private bool? ebsOptimizedField;

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Set the ID of the instance.
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithInstanceId(string instanceId)
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
        /// The instance type (e.g., m1.small, c1.medium,
        /// m2.2xlarge, and so on).
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
        /// <param name="instanceType">The instance type (e.g., m1.small, c1.medium,
        /// m2.2xlarge, and so
        /// on).</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithInstanceType(string instanceType)
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
        /// The kernel ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the kernel ID.
        /// </summary>
        /// <param name="kernelId">The kernel ID.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithKernelId(string kernelId)
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
        /// The RAM disk ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the RAM disk ID.
        /// </summary>
        /// <param name="ramdiskId">The RAM disk ID.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithRamdiskId(string ramdiskId)
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
        /// MIME, Base64-encoded user data.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField; }
            set { this.userDataField = value; }
        }

        /// <summary>
        /// Sets the MIME, Base64-encoded user data.
        /// </summary>
        /// <param name="userData">MIME, Base64-encoded user data.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithUserData(string userData)
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
        /// Whether the instance can be terminated.
        /// You must modify this attribute before you can
        /// terminate any "locked" instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "DisableApiTermination")]
        public bool DisableApiTermination
        {
            get { return this.disableApiTerminationField.GetValueOrDefault(); }
            set { this.disableApiTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the instance can be terminated.
        /// </summary>
        /// <param name="disableApiTermination">Specifies whether the instance can be
        /// terminated. You must
        /// modify this attribute before you can
        /// terminate any "locked" instances.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithDisableApiTermination(bool disableApiTermination)
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
        /// Whether the instance's Amazon EBS volumes are deleted when
        /// the instance is shut down.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceInitiatedShutdownBehavior")]
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehaviorField; }
            set { this.instanceInitiatedShutdownBehaviorField = value; }
        }

        /// <summary>
        /// Sets whether the instance's Amazon EBS volumes are deleted when
        /// the instance is shut down.
        /// </summary>
        /// <param name="instanceInitiatedShutdownBehavior">Specifies whether the instance's Amazon EBS
        /// volumes are deleted when the instance is shut down.
        /// </param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithInstanceInitiatedShutdownBehavior(string instanceInitiatedShutdownBehavior)
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
        public InstanceAttribute WithRootDeviceName(string rootDeviceName)
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
        /// Block device mapping set.
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
        /// Sets the block device mapping set.
        /// </summary>
        /// <param name="list">Block device mapping set.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithBlockDeviceMapping(params InstanceBlockDeviceMapping[] list)
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
        /// Whether source/destination checking is enabled on the instance.
        /// A value of true means checking is enabled, and false means checking is disabled. 
        /// The value must be false for the instance to perform NAT. 
        /// </summary>
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
        /// A value of true means checking is enabled, and false means checking is disabled. 
        /// The value must be false for the instance to perform NAT.
        /// </param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithSourceDestCheck(bool sourceDestCheck)
        {
            this.sourceDestCheckField = sourceDestCheck;
            return this;
        }

        /// <summary>
        /// Checks if the SourceDestCheck property is set
        /// </summary>
        /// <returns>true if the SourceDestCheck property is set</returns>
        public bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheckField != null;
        }

        /// <summary>
        /// Names of the security group.
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
        /// Sets names of the security group.
        /// </summary>
        /// <param name="list">Names of the security groups.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithGroupName(params string[] list)
        {
            foreach (string item in list)
            {
                GroupName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the GroupName property is set
        /// </summary>
        /// <returns>true if the GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return (GroupName.Count > 0);
        }

        /// <summary>
        /// IDs of the security groups.
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
        /// Sets IDs of the security groups.
        /// </summary>
        /// <param name="list">IDs of the security groups.</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the GroupId property is set
        /// </summary>
        /// <returns>true if the GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

        /// <summary>
        /// Product codes.
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
        /// Sets the product codes.
        /// </summary>
        /// <param name="list">list of product codes and types</param>
        /// <returns>this instance</returns>
        public InstanceAttribute WithProductCodes(params ProductCode[] list)
        {
            foreach (ProductCode item in list)
            {
                ProductCodes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the ProductCodes property is set
        /// </summary>
        /// <returns>true if the ProductCodes property is set</returns>
        public bool IsSetProductCodes()
        {
            return (ProductCodes.Count > 0);
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
        public InstanceAttribute WithEbsOptimized(bool ebsOptimized)
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
    }
}
