/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.SimpleDB.Model
{
    /// <summary>Domain Metadata Result
    /// </summary>
    public partial class DomainMetadataResult : AmazonWebServiceResponse
    {
        
        private int? itemCount;
        private long? itemNamesSizeBytes;
        private int? attributeNameCount;
        private long? attributeNamesSizeBytes;
        private int? attributeValueCount;
        private long? attributeValuesSizeBytes;
        private int? timestamp;

        /// <summary>
        /// The number of all items in the domain.
        ///  
        /// </summary>
        public int ItemCount
        {
            get { return this.itemCount ?? default(int); }
            set { this.itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this.itemCount.HasValue;
        }

        /// <summary>
        /// The total size of all item names in the domain, in bytes.
        ///  
        /// </summary>
        public long ItemNamesSizeBytes
        {
            get { return this.itemNamesSizeBytes ?? default(long); }
            set { this.itemNamesSizeBytes = value; }
        }

        // Check to see if ItemNamesSizeBytes property is set
        internal bool IsSetItemNamesSizeBytes()
        {
            return this.itemNamesSizeBytes.HasValue;
        }

        /// <summary>
        /// The number of unique attribute names in the domain.
        ///  
        /// </summary>
        public int AttributeNameCount
        {
            get { return this.attributeNameCount ?? default(int); }
            set { this.attributeNameCount = value; }
        }

        // Check to see if AttributeNameCount property is set
        internal bool IsSetAttributeNameCount()
        {
            return this.attributeNameCount.HasValue;
        }

        /// <summary>
        /// The total size of all unique attribute names in the domain, in bytes.
        ///  
        /// </summary>
        public long AttributeNamesSizeBytes
        {
            get { return this.attributeNamesSizeBytes ?? default(long); }
            set { this.attributeNamesSizeBytes = value; }
        }

        // Check to see if AttributeNamesSizeBytes property is set
        internal bool IsSetAttributeNamesSizeBytes()
        {
            return this.attributeNamesSizeBytes.HasValue;
        }

        /// <summary>
        /// The number of all attribute name/value pairs in the domain.
        ///  
        /// </summary>
        public int AttributeValueCount
        {
            get { return this.attributeValueCount ?? default(int); }
            set { this.attributeValueCount = value; }
        }

        // Check to see if AttributeValueCount property is set
        internal bool IsSetAttributeValueCount()
        {
            return this.attributeValueCount.HasValue;
        }

        /// <summary>
        /// The total size of all attribute values in the domain, in bytes.
        ///  
        /// </summary>
        public long AttributeValuesSizeBytes
        {
            get { return this.attributeValuesSizeBytes ?? default(long); }
            set { this.attributeValuesSizeBytes = value; }
        }

        // Check to see if AttributeValuesSizeBytes property is set
        internal bool IsSetAttributeValuesSizeBytes()
        {
            return this.attributeValuesSizeBytes.HasValue;
        }

        /// <summary>
        /// The data and time when metadata was calculated, in Epoch (UNIX) seconds.
        ///  
        /// </summary>
        public int Timestamp
        {
            get { return this.timestamp ?? default(int); }
            set { this.timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;
        }
    }
}
