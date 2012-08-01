/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Creates an AMI that uses an Amazon EBS root device from a "running" or
    /// "stopped" instance. AMIs that use an Amazon EBS root device boot
    /// faster than AMIs that use instance stores. They can be up to 1 TiB in size,
    /// use storage that persists on instance failure, and can be stopped
    /// and started.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateImageRequest
    {    
        private string instanceIdField;
        private string nameField;
        private string descriptionField;
        private bool? noRebootField;
        private List<BlockDeviceMapping> blockDeviceMappingField;


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
        public CreateImageRequest WithInstanceId(string instanceId)
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
        /// Gets and sets the Name property.
        /// The name of the AMI that was provided during image
        /// creation. Must be 3-128 alphanumeric characters,
        /// parenthesis (()), commas (,), slashes (/), dashes (-), or
        /// underscores(_).
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the AMI that was provided during image
        /// creation. Must be 3-128 alphanumeric characters,
        /// parenthesis (()), commas (,), slashes (/), dashes (-), or
        /// underscores(_).</param>
        /// <returns>this instance</returns>
        public CreateImageRequest WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// The description of the AMI that was provided
        /// during
        /// image creation. Can be up to 255 characters.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The description of the AMI that was provided
        /// during
        /// image creation. Can be up to 255 characters.</param>
        /// <returns>this instance</returns>
        public CreateImageRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// Gets and sets the NoReboot property.
        /// By default this property is set to false, which means
        /// Amazon EC2 attempts to cleanly shut down the
        /// instance before image creation and reboots the instance
        /// afterwards. When set to true, Amazon EC2 does not shut down the
        /// instance before creating the image. When this option is used,
        /// file system integrity on the created image cannot be guaranteed.
        /// Default is FALSE.
        /// </summary>
        [XmlElementAttribute(ElementName = "NoReboot")]
        public bool NoReboot
        {
            get { return this.noRebootField.GetValueOrDefault(); }
            set { this.noRebootField = value; }
        }

        /// <summary>
        /// Sets the NoReboot property
        /// </summary>
        /// <param name="noReboot">By default this property is set to false, which means
        /// Amazon EC2 attempts to cleanly shut down the
        /// instance before image creation and reboots the instance
        /// afterwards. When set to true, Amazon EC2 does not shut down the
        /// instance before creating the image. When this option is used,
        /// file system integrity on the created image cannot be guaranteed.
        /// Default is FALSE.</param>
        /// <returns>this instance</returns>
        public CreateImageRequest WithNoReboot(bool noReboot)
        {
            this.noRebootField = noReboot;
            return this;
        }

        /// <summary>
        /// Checks if NoReboot property is set
        /// </summary>
        /// <returns>true if NoReboot property is set</returns>
        public bool IsSetNoReboot()
        {
            return this.noRebootField.HasValue;
        }

        /// <summary>
        /// Gets and sets the BlockDeviceMapping property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<BlockDeviceMapping> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<BlockDeviceMapping>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets the BlockDeviceMapping property
        /// </summary>
        /// <param name="list">BlockDeviceMapping property</param>
        /// <returns>this instance</returns>
        public CreateImageRequest WithBlockDeviceMapping(params BlockDeviceMapping[] list)
        {
            foreach (BlockDeviceMapping item in list)
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
