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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
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
    /// Updates a given typed link’s attributes inside a <a>BatchRead</a> operation. Attributes
    /// to be updated must not contribute to the typed link’s identity, as defined by its
    /// <code>IdentityAttributeOrder</code>. For more information, see <a>UpdateLinkAttributes</a>
    /// and <a>BatchReadRequest$Operations</a>.
    /// </summary>
    public partial class BatchUpdateLinkAttributes
    {
        private List<LinkAttributeUpdate> _attributeUpdates = new List<LinkAttributeUpdate>();
        private TypedLinkSpecifier _typedLinkSpecifier;

        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// The attributes update structure.
        /// </para>
        /// </summary>
        public List<LinkAttributeUpdate> AttributeUpdates
        {
            get { return this._attributeUpdates; }
            set { this._attributeUpdates = value; }
        }

        // Check to see if AttributeUpdates property is set
        internal bool IsSetAttributeUpdates()
        {
            return this._attributeUpdates != null && this._attributeUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TypedLinkSpecifier. 
        /// <para>
        /// Allows a typed link specifier to be accepted as input.
        /// </para>
        /// </summary>
        public TypedLinkSpecifier TypedLinkSpecifier
        {
            get { return this._typedLinkSpecifier; }
            set { this._typedLinkSpecifier = value; }
        }

        // Check to see if TypedLinkSpecifier property is set
        internal bool IsSetTypedLinkSpecifier()
        {
            return this._typedLinkSpecifier != null;
        }

    }
}