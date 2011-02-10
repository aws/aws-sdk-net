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
 *  API Version: 2010-08-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{

    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-08-31/", IsNullable = false)]
    public class TagType
    {    
        private string resourceIdField;
        private string resourceTypeField;
        private string keyField;
        private string valueField;

        /// <summary>
        /// Gets and sets the ResourceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResourceId")]
        public string ResourceId
        {
            get { return this.resourceIdField; }
            set { this.resourceIdField = value; }
        }

        /// <summary>
        /// Sets the ResourceId property
        /// </summary>
        /// <param name="resourceId">ResourceId property</param>
        /// <returns>this instance</returns>
        public TagType WithResourceId(string resourceId)
        {
            this.resourceIdField = resourceId;
            return this;
        }

        /// <summary>
        /// Checks if ResourceId property is set
        /// </summary>
        /// <returns>true if ResourceId property is set</returns>
        public bool IsSetResourceId()
        {
            return this.resourceIdField != null;
        }

        /// <summary>
        /// Gets and sets the ResourceType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResourceType")]
        public string ResourceType
        {
            get { return this.resourceTypeField; }
            set { this.resourceTypeField = value; }
        }

        /// <summary>
        /// Sets the ResourceType property
        /// </summary>
        /// <param name="resourceType">ResourceType property</param>
        /// <returns>this instance</returns>
        public TagType WithResourceType(string resourceType)
        {
            this.resourceTypeField = resourceType;
            return this;
        }

        /// <summary>
        /// Checks if ResourceType property is set
        /// </summary>
        /// <returns>true if ResourceType property is set</returns>
        public bool IsSetResourceType()
        {
            return this.resourceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">Key property</param>
        /// <returns>this instance</returns>
        public TagType WithKey(string key)
        {
            this.keyField = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set
        /// </summary>
        /// <returns>true if Key property is set</returns>
        public bool IsSetKey()
        {
            return this.keyField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
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
        /// <param name="value">Value property</param>
        /// <returns>this instance</returns>
        public TagType WithValue(string value)
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

    }
}
