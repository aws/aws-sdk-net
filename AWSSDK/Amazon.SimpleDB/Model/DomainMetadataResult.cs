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
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Returns information about the domain, including when the domain was created, the number of items and
    /// attributes, and the size of attribute names and values.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class DomainMetadataResult
    {
        private string itemCountField;
        private string itemNamesSizeBytesField;
        private string attributeNameCountField;
        private string attributeNamesSizeBytesField;
        private string attributeValueCountField;
        private string attributeValuesSizeBytesField;
        private string timestampField;

        /// <summary>
        /// Gets and sets the ItemCount property.
        /// The number of all items in the domain.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemCount")]
        public string ItemCount
        {
            get { return this.itemCountField; }
            set { this.itemCountField = value; }
        }

        /// <summary>
        /// Sets the ItemCount property
        /// </summary>
        /// <param name="itemCount">The number of all items in the domain.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithItemCount(string itemCount)
        {
            this.itemCountField = itemCount;
            return this;
        }

        /// <summary>
        /// Checks if ItemCount property is set
        /// </summary>
        /// <returns>true if ItemCount property is set</returns>
        public bool IsSetItemCount()
        {
            return this.itemCountField != null;
        }

        /// <summary>
        /// Gets and sets the ItemNamesSizeBytes property.
        /// The total size of all item names in the domain, in bytes.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemNamesSizeBytes")]
        public string ItemNamesSizeBytes
        {
            get { return this.itemNamesSizeBytesField; }
            set { this.itemNamesSizeBytesField = value; }
        }

        /// <summary>
        /// Sets the ItemNamesSizeBytes property
        /// </summary>
        /// <param name="itemNamesSizeBytes">The total size of all item names in the domain, in bytes.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithItemNamesSizeBytes(string itemNamesSizeBytes)
        {
            this.itemNamesSizeBytesField = itemNamesSizeBytes;
            return this;
        }

        /// <summary>
        /// Checks if ItemNamesSizeBytes property is set
        /// </summary>
        /// <returns>true if ItemNamesSizeBytes property is set</returns>
        public bool IsSetItemNamesSizeBytes()
        {
            return this.itemNamesSizeBytesField != null;
        }

        /// <summary>
        /// Gets and sets the AttributeNameCount property.
        /// The number of unique attribute names in the domain.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeNameCount")]
        public string AttributeNameCount
        {
            get { return this.attributeNameCountField; }
            set { this.attributeNameCountField = value; }
        }

        /// <summary>
        /// Sets the AttributeNameCount property
        /// </summary>
        /// <param name="attributeNameCount">The number of unique attribute names in the domain.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithAttributeNameCount(string attributeNameCount)
        {
            this.attributeNameCountField = attributeNameCount;
            return this;
        }

        /// <summary>
        /// Checks if AttributeNameCount property is set
        /// </summary>
        /// <returns>true if AttributeNameCount property is set</returns>
        public bool IsSetAttributeNameCount()
        {
            return this.attributeNameCountField != null;
        }

        /// <summary>
        /// Gets and sets the AttributeNamesSizeBytes property.
        /// The total size of all unique attribute names, in bytes.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeNamesSizeBytes")]
        public string AttributeNamesSizeBytes
        {
            get { return this.attributeNamesSizeBytesField; }
            set { this.attributeNamesSizeBytesField = value; }
        }

        /// <summary>
        /// Sets the AttributeNamesSizeBytes property
        /// </summary>
        /// <param name="attributeNamesSizeBytes">The total size of all unique attribute names, in bytes.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithAttributeNamesSizeBytes(string attributeNamesSizeBytes)
        {
            this.attributeNamesSizeBytesField = attributeNamesSizeBytes;
            return this;
        }

        /// <summary>
        /// Checks if AttributeNamesSizeBytes property is set
        /// </summary>
        /// <returns>true if AttributeNamesSizeBytes property is set</returns>
        public bool IsSetAttributeNamesSizeBytes()
        {
            return this.attributeNamesSizeBytesField != null;
        }

        /// <summary>
        /// Gets and sets the AttributeValueCount property.
        /// The number of all attribute name/value pairs in the domain.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValueCount")]
        public string AttributeValueCount
        {
            get { return this.attributeValueCountField; }
            set { this.attributeValueCountField = value; }
        }

        /// <summary>
        /// Sets the AttributeValueCount property
        /// </summary>
        /// <param name="attributeValueCount">The number of all attribute name/value pairs in the domain.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithAttributeValueCount(string attributeValueCount)
        {
            this.attributeValueCountField = attributeValueCount;
            return this;
        }

        /// <summary>
        /// Checks if AttributeValueCount property is set
        /// </summary>
        /// <returns>true if AttributeValueCount property is set</returns>
        public bool IsSetAttributeValueCount()
        {
            return this.attributeValueCountField != null;
        }

        /// <summary>
        /// Gets and sets the AttributeValuesSizeBytes property.
        /// The total size of all attribute values, in bytes.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValuesSizeBytes")]
        public string AttributeValuesSizeBytes
        {
            get { return this.attributeValuesSizeBytesField; }
            set { this.attributeValuesSizeBytesField = value; }
        }

        /// <summary>
        /// Sets the AttributeValuesSizeBytes property
        /// </summary>
        /// <param name="attributeValuesSizeBytes">The total size of all attribute values, in bytes.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithAttributeValuesSizeBytes(string attributeValuesSizeBytes)
        {
            this.attributeValuesSizeBytesField = attributeValuesSizeBytes;
            return this;
        }

        /// <summary>
        /// Checks if AttributeValuesSizeBytes property is set
        /// </summary>
        /// <returns>true if AttributeValuesSizeBytes property is set</returns>
        public bool IsSetAttributeValuesSizeBytes()
        {
            return this.attributeValuesSizeBytesField != null;
        }

        /// <summary>
        /// Gets and sets the Timestamp property.
        /// The data and time when metadata was calculated in Epoch (UNIX) time.
        /// </summary>
        [XmlElementAttribute(ElementName = "Timestamp")]
        public string Timestamp
        {
            get { return this.timestampField; }
            set { this.timestampField = value; }
        }

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The data and time when metadata was calculated in Epoch (UNIX) time.</param>
        /// <returns>this instance</returns>
        public DomainMetadataResult WithTimestamp(string timestamp)
        {
            this.timestampField = timestamp;
            return this;
        }

        /// <summary>
        /// Checks if Timestamp property is set
        /// </summary>
        /// <returns>true if Timestamp property is set</returns>
        public bool IsSetTimestamp()
        {
            return this.timestampField != null;
        }

    }
}
