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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Resets an attribute of an instance to its default
    /// value.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class ResetInstanceAttributeRequest
    {    
        private string instanceIdField;
        private string attributeField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// ID of the instance on which the attribute will
        /// be reset.
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
        /// <param name="instanceId">ID of the instance on which the attribute will
        /// be reset.</param>
        /// <returns>this instance</returns>
        public ResetInstanceAttributeRequest WithInstanceId(string instanceId)
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
        /// Name of the attribute to reset. Values are
        /// "kernel" and "ramdisk".
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
        /// <param name="attribute">Name of the attribute to reset. Values are
        /// "kernel" and "ramdisk".</param>
        /// <returns>this instance</returns>
        public ResetInstanceAttributeRequest WithAttribute(string attribute)
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
