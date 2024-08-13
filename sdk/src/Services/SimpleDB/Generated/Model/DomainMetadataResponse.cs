/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// This is the response object from the DomainMetadata operation.
    /// </summary>
    public partial class DomainMetadataResponse : AmazonWebServiceResponse
    {
        private int? _attributeNameCount;
        private long? _attributeNamesSizeBytes;
        private int? _attributeValueCount;
        private long? _attributeValuesSizeBytes;
        private int? _itemCount;
        private long? _itemNamesSizeBytes;
        private int? _timestamp;

        /// <summary>
        /// Gets and sets the property AttributeNameCount. The number of unique attribute names
        /// in the domain.
        /// </summary>
        public int? AttributeNameCount
        {
            get { return this._attributeNameCount; }
            set { this._attributeNameCount = value; }
        }

        // Check to see if AttributeNameCount property is set
        internal bool IsSetAttributeNameCount()
        {
            return this._attributeNameCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttributeNamesSizeBytes. The total size of all unique attribute
        /// names in the domain, in bytes.
        /// </summary>
        public long? AttributeNamesSizeBytes
        {
            get { return this._attributeNamesSizeBytes; }
            set { this._attributeNamesSizeBytes = value; }
        }

        // Check to see if AttributeNamesSizeBytes property is set
        internal bool IsSetAttributeNamesSizeBytes()
        {
            return this._attributeNamesSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttributeValueCount. The number of all attribute name/value
        /// pairs in the domain.
        /// </summary>
        public int? AttributeValueCount
        {
            get { return this._attributeValueCount; }
            set { this._attributeValueCount = value; }
        }

        // Check to see if AttributeValueCount property is set
        internal bool IsSetAttributeValueCount()
        {
            return this._attributeValueCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttributeValuesSizeBytes. The total size of all attribute
        /// values in the domain, in bytes.
        /// </summary>
        public long? AttributeValuesSizeBytes
        {
            get { return this._attributeValuesSizeBytes; }
            set { this._attributeValuesSizeBytes = value; }
        }

        // Check to see if AttributeValuesSizeBytes property is set
        internal bool IsSetAttributeValuesSizeBytes()
        {
            return this._attributeValuesSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ItemCount. The number of all items in the domain.
        /// </summary>
        public int? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ItemNamesSizeBytes. The total size of all item names in
        /// the domain, in bytes.
        /// </summary>
        public long? ItemNamesSizeBytes
        {
            get { return this._itemNamesSizeBytes; }
            set { this._itemNamesSizeBytes = value; }
        }

        // Check to see if ItemNamesSizeBytes property is set
        internal bool IsSetItemNamesSizeBytes()
        {
            return this._itemNamesSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. The data and time when metadata was calculated,
        /// in Epoch (UNIX) seconds.
        /// </summary>
        public int? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}