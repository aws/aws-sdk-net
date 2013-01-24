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
    /// Gets information about an attribute of an instance.
    /// Only one attribute can be specified per call.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeInstanceAttributeRequest
    {    
        private string instanceIdField;
        private string attributeField;

        /// <summary>
        /// Instance ID to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance ID to describe.
        /// </summary>
        /// <param name="instanceId">Instance IDs to describe.</param>
        /// <returns>this instance</returns>
        public DescribeInstanceAttributeRequest WithInstanceId(string instanceId)
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
        /// The attribute to return.
        /// </summary>
        /// <remarks>
        /// Valid values are
        /// "instanceType", "kernel", "ramdisk", "userData",
        /// "disableApiTermination", "instanceInitiatedShutdownBehavior",
        /// "sourceDestCheck", "groupSet",
        /// "rootDeviceName", "blockDeviceMapping", "productCodes" and "ebsOptimized"
        /// </remarks>
        [XmlElementAttribute(ElementName = "Attribute")]
        public string Attribute
        {
            get { return this.attributeField; }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the attribute to return.
        /// </summary>
        /// <param name="attribute">Specifies the attribute to return. Values are
        /// "instanceType", "kernel", "ramdisk", "userData",
        /// "disableApiTermination", "instanceInitiatedShutdownBehavior",
        /// "sourceDestCheck", "groupSet",
        /// "rootDeviceName", "blockDeviceMapping", "productCodes" and "ebsOptimized"</param>
        /// <returns>this instance</returns>
        public DescribeInstanceAttributeRequest WithAttribute(string attribute)
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

    }
}
