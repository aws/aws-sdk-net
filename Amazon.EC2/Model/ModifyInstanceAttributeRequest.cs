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
    /// <summary>
    /// Modifies an attribute of an instance.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class ModifyInstanceAttributeRequest
    {    
        private string instanceIdField;
        private string attributeField;
        private string valueField;
        private List<InstanceBlockDeviceMappingParameter> blockDeviceMappingField;
        private List<string> groupIdField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The instance ID.
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
        /// <param name="instanceId">The instance ID.</param>
        /// <returns>this instance</returns>
        public ModifyInstanceAttributeRequest WithInstanceId(string instanceId)
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
        /// Gets and sets the Attribute property.
        /// Name of the attribute to modify. Values are
        /// "instanceType", "kernel", "ramdisk",
        /// "userData", "disableApiTermination",
        /// "instanceInitiatedShutdownBehavior",
        /// "sourceDestCheck",
        /// "rootDeviceName", and "blockDeviceMapping"
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public string Attribute
        {
            get { return this.attributeField; }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="attribute">Name of the attribute to modify. Values are
        /// "instanceType", "kernel", "ramdisk",
        /// "userData", "disableApiTermination",
        /// "instanceInitiatedShutdownBehavior",
        /// "sourceDestCheck",
        /// "rootDeviceName", and "blockDeviceMapping"</param>
        /// <returns>this instance</returns>
        public ModifyInstanceAttributeRequest WithAttribute(string attribute)
        {
            this.attributeField = attribute;
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return this.attributeField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// New value of the attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">New value of the attribute.</param>
        /// <returns>this instance</returns>
        public ModifyInstanceAttributeRequest WithValue(string value)
        {
            this.valueField = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return this.valueField != null;
        }

        /// <summary>
        /// Gets and sets the BlockDeviceMapping property.
        /// Modifies the mapping that defines native device names
        /// to use when exposing virtual devices.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<InstanceBlockDeviceMappingParameter> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<InstanceBlockDeviceMappingParameter>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets the BlockDeviceMapping property
        /// </summary>
        /// <param name="list">Modifies the mapping that defines native device names
        /// to use when exposing virtual devices.</param>
        /// <returns>this instance</returns>
        public ModifyInstanceAttributeRequest WithBlockDeviceMapping(params InstanceBlockDeviceMappingParameter[] list)
        {
            foreach (InstanceBlockDeviceMappingParameter item in list)
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
        /// Gets and sets the GroupId property.
        /// This is applicable only to instances running in a VPC. Use
        /// this parameter when you want to change the security
        /// groups an instance is in. The new set of groups you specify
        /// replaces the current set. You must specify at least one
        /// group, even if it's just the default security group in the VPC.
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
        /// Sets the GroupId property
        /// </summary>
        /// <param name="list">This is applicable only to instances running in a VPC. Use
        /// this parameter when you want to change the security
        /// groups an instance is in. The new set of groups you specify
        /// replaces the current set. You must specify at least one
        /// group, even if it's just the default security group in the VPC.</param>
        /// <returns>this instance</returns>
        public ModifyInstanceAttributeRequest WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

    }
}
