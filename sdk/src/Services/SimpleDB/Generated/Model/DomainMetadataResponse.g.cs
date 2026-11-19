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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AttributeNameCount. The number of unique attribute names
        /// in the domain.
        /// </summary>
        public int? AttributeNameCount { get; set; }

        /// <summary>
        /// Checks to see if the AttributeNameCount property is set.
        /// </summary>
        internal bool IsSetAttributeNameCount() => this.AttributeNameCount.HasValue;

        /// <summary>
        /// Gets and sets the property AttributeNamesSizeBytes. The total size of all unique attribute
        /// names in the domain, in bytes.
        /// </summary>
        public long? AttributeNamesSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the AttributeNamesSizeBytes property is set.
        /// </summary>
        internal bool IsSetAttributeNamesSizeBytes() => this.AttributeNamesSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property AttributeValueCount. The number of all attribute name/value
        /// pairs in the domain.
        /// </summary>
        public int? AttributeValueCount { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValueCount property is set.
        /// </summary>
        internal bool IsSetAttributeValueCount() => this.AttributeValueCount.HasValue;

        /// <summary>
        /// Gets and sets the property AttributeValuesSizeBytes. The total size of all attribute
        /// values in the domain, in bytes.
        /// </summary>
        public long? AttributeValuesSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValuesSizeBytes property is set.
        /// </summary>
        internal bool IsSetAttributeValuesSizeBytes() => this.AttributeValuesSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ItemCount. The number of all items in the domain.
        /// </summary>
        public int? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property ItemNamesSizeBytes. The total size of all item names in
        /// the domain, in bytes.
        /// </summary>
        public long? ItemNamesSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the ItemNamesSizeBytes property is set.
        /// </summary>
        internal bool IsSetItemNamesSizeBytes() => this.ItemNamesSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. The data and time when metadata was calculated,
        /// in Epoch (UNIX) seconds.
        /// </summary>
        public int? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
