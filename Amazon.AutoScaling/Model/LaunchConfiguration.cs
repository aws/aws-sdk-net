/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    ///<summary>
    ///A Launch Configuration captures the parameters necessary to create new EC2 Instances. Only one launch configuration
    ///can be attached to an AutoScalingGroup at a time. When you attach a new or updated launch configuration to your
    ///AutoScalingGroup, any new instances will be launched using the new configuration parameters.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class LaunchConfiguration
    {
        private string launchConfigurationNameField;
        private string imageIdField;
        private string keyNameField;
        private List<string> securityGroupsField;
        private string userDataField;
        private string instanceTypeField;
        private string kernelIdField;
        private string ramdiskIdField;
        private List<BlockDeviceMapping> blockDeviceMappingsField;
        private DateTime? createdTimeField;

        /// <summary>
        /// Gets and sets the LaunchConfigurationName property.
        /// Name of the Launch Configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchConfigurationName")]
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationNameField ; }
            set { this.launchConfigurationNameField= value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">Name of the Launch Configuration.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithLaunchConfigurationName(string launchConfigurationName)
        {
            this.launchConfigurationNameField = launchConfigurationName;
            return this;
        }

        /// <summary>
        /// Checks if LaunchConfigurationName property is set
        /// </summary>
        /// <returns>true if LaunchConfigurationName property is set</returns>
        public bool IsSetLaunchConfigurationName()
        {
            return  this.launchConfigurationNameField != null;
        }

        /// <summary>
        /// Gets and sets the ImageId property.
        /// Unique ID of the Amazon Machine Image (AMI) that was assigned during registration.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField ; }
            set { this.imageIdField= value; }
        }

        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">Unique ID of the Amazon Machine Image (AMI) that was assigned during registration.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithImageId(string imageId)
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
            return  this.imageIdField != null;
        }

        /// <summary>
        /// Gets and sets the KeyName property.
        /// The name of the EC2 key pair.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField ; }
            set { this.keyNameField= value; }
        }

        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="keyName">The name of the EC2 key pair.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithKeyName(string keyName)
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
            return  this.keyNameField != null;
        }

        /// <summary>
        /// Gets and sets the SecurityGroups property.
        /// Description of the security groups to associate with the EC2 instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroups")]
        public List<string> SecurityGroups
        {
            get
            {
                if (this.securityGroupsField == null)
                {
                    this.securityGroupsField = new List<string>();
                }
                return this.securityGroupsField;
            }
            set { this.securityGroupsField = value; }
        }

        /// <summary>
        /// Sets the SecurityGroups property
        /// </summary>
        /// <param name="list">Description of the security groups to associate with the EC2 instances.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithSecurityGroups(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroups.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroups property is set
        /// </summary>
        /// <returns>true if SecurityGroups property is set</returns>
        public bool IsSetSecurityGroups()
        {
            return (SecurityGroups.Count > 0);
        }

        /// <summary>
        /// Gets and sets the UserData property.
        /// The user data available to the launched EC2 instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField ; }
            set { this.userDataField= value; }
        }

        /// <summary>
        /// Sets the UserData property
        /// </summary>
        /// <param name="userData">The user data available to the launched EC2 instances.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithUserData(string userData)
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
            return  this.userDataField != null;
        }

        /// <summary>
        /// Gets and sets the InstanceType property.
        /// This species the instance type of the EC2 instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField ; }
            set { this.instanceTypeField= value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">This species the instance type of the EC2 instance.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithInstanceType(string instanceType)
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
            return  this.instanceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the KernelId property.
        /// ID of the kernel associated with the EC2 AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField ; }
            set { this.kernelIdField= value; }
        }

        /// <summary>
        /// Sets the KernelId property
        /// </summary>
        /// <param name="kernelId">ID of the kernel associated with the EC2 AMI.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithKernelId(string kernelId)
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
            return  this.kernelIdField != null;
        }

        /// <summary>
        /// Gets and sets the RamdiskId property.
        /// ID of the RAM disk associated with the EC2 AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField ; }
            set { this.ramdiskIdField= value; }
        }

        /// <summary>
        /// Sets the RamdiskId property
        /// </summary>
        /// <param name="ramdiskId">ID of the RAM disk associated with the EC2 AMI.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithRamdiskId(string ramdiskId)
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
            return  this.ramdiskIdField != null;
        }
        /// <summary>
        /// Gets and sets the BlockDeviceMappings property.
        /// Specifies how block devices are exposed to the instance. Each mapping is made up of a virtualName and a deviceName.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMappings")]
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get
            {
                if (this.blockDeviceMappingsField == null)
                {
                    this.blockDeviceMappingsField = new List<BlockDeviceMapping>();
                }
                return this.blockDeviceMappingsField;
            }
            set { this.blockDeviceMappingsField = value; }
        }

        /// <summary>
        /// Sets the BlockDeviceMappings property
        /// </summary>
        /// <param name="list">Specifies how block devices are exposed to the instance. Each mapping is made up of a virtualName and a deviceName.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithBlockDeviceMappings(params BlockDeviceMapping[] list)
        {
            foreach (BlockDeviceMapping item in list)
            {
                BlockDeviceMappings.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BlockDeviceMappings property is set
        /// </summary>
        /// <returns>true if BlockDeviceMappings property is set</returns>
        public bool IsSetBlockDeviceMappings()
        {
            return (BlockDeviceMappings.Count > 0);
        }

        /// <summary>
        /// Gets and sets the CreatedTime property.
        /// The creation date and time for this launch configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreatedTime")]
        public DateTime CreatedTime
        {
            get { return this.createdTimeField.GetValueOrDefault() ; }
            set { this.createdTimeField= value; }
        }

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The creation date and time for this launch configuration.</param>
        /// <returns>this instance</returns>
        public LaunchConfiguration WithCreatedTime(DateTime createdTime)
        {
            this.createdTimeField = createdTime;
            return this;
        }

        /// <summary>
        /// Checks if CreatedTime property is set
        /// </summary>
        /// <returns>true if CreatedTime property is set</returns>
        public bool IsSetCreatedTime()
        {
            return  this.createdTimeField.HasValue;
        }

    }
}
