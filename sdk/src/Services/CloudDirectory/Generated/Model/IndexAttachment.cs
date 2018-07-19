/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents an index and an attached object.
    /// </summary>
    public partial class IndexAttachment
    {
        private List<AttributeKeyAndValue> _indexedAttributes = new List<AttributeKeyAndValue>();
        private string _objectIdentifier;

        /// <summary>
        /// Gets and sets the property IndexedAttributes. 
        /// <para>
        /// The indexed attribute values.
        /// </para>
        /// </summary>
        public List<AttributeKeyAndValue> IndexedAttributes
        {
            get { return this._indexedAttributes; }
            set { this._indexedAttributes = value; }
        }

        // Check to see if IndexedAttributes property is set
        internal bool IsSetIndexedAttributes()
        {
            return this._indexedAttributes != null && this._indexedAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// In response to <a>ListIndex</a>, the <code>ObjectIdentifier</code> of the object attached
        /// to the index. In response to <a>ListAttachedIndices</a>, the <code>ObjectIdentifier</code>
        /// of the index attached to the object. This field will always contain the <code>ObjectIdentifier</code>
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