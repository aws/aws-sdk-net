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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents an index and an attached object.
    /// </summary>
    public partial class IndexAttachment
    {
        private List<AttributeKeyAndValue> _indexedAttributes = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;
        private string _objectIdentifier;

        /// <summary>
        /// Gets and sets the property IndexedAttributes. 
        /// <para>
        /// The indexed attribute values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeKeyAndValue> IndexedAttributes
        {
            get { return this._indexedAttributes; }
            set { this._indexedAttributes = value; }
        }

        // Check to see if IndexedAttributes property is set
        internal bool IsSetIndexedAttributes()
        {
            return this._indexedAttributes != null && (this._indexedAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// In response to <a>ListIndex</a>, the <c>ObjectIdentifier</c> of the object attached
        /// to the index. In response to <a>ListAttachedIndices</a>, the <c>ObjectIdentifier</c>
        /// of the index attached to the object. This field will always contain the <c>ObjectIdentifier</c>
        /// of the object on the opposite side of the attachment specified in the query.
        /// </para>
        /// </summary>
        public string ObjectIdentifier
        {
            get { return this._objectIdentifier; }
            set { this._objectIdentifier = value; }
        }

        // Check to see if ObjectIdentifier property is set
        internal bool IsSetObjectIdentifier()
        {
            return this._objectIdentifier != null;
        }

    }
}