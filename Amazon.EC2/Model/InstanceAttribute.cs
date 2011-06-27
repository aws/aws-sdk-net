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
    ///<summary>
    ///A list of instance attributes.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
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

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
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
        /// Gets and sets the InstanceType property.
        /// The instance type (e.g., m1.small, c1.medium,
        /// m2.2xlarge, and so
        /// on).
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
        /// Gets and sets the KernelId property.
        /// The kernel ID.
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
        /// Gets and sets the RamdiskId property.
        /// The RAM disk ID.
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
        /// Gets and sets the DisableApiTermination property.
        /// Specifies whether the instance can be
        /// terminated. You must
        /// modify this attribute before you can
        /// terminate any "locked" instances.
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
        /// Gets and sets the InstanceInitiatedShutdownBehavior property.
        /// Specifies whether the instance's Amazon EBS
        /// volumes are deleted when the instance is shut down.
        /// Type:
        /// NullableAttributeBooleanValueType
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
        /// volumes are deleted when the instance is shut down.
        /// Type:
        /// NullableAttributeBooleanValueType</param>
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
        /// Gets and sets the RootDeviceName property.
        /// The root device name (e.g., /dev/sda1).
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceName")]
        public string RootDeviceName
        {
            get { return this.rootDeviceNameField; }
            set { this.rootDeviceNameField = value; }
        }

        /// <summary>
        /// Sets the RootDeviceName property
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
        /// Gets and sets the BlockDeviceMapping property.
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
        /// Sets the BlockDeviceMapping property
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

    }
}
