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

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// A metadata entry for a folder or object.
    /// </summary>
    public partial class Item
    {
        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// The length of the item in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Checks to see if the ContentLength property is set.
        /// </summary>
        internal bool IsSetContentLength() => this.ContentLength.HasValue;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the item.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag that represents a unique instance of the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the item was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the item.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The item type (folder or object).
        /// </para>
        /// </summary>
        public ItemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
