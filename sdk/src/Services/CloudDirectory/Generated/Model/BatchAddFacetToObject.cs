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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a batch add facet to object operation.
    /// </summary>
    public partial class BatchAddFacetToObject
    {
        private List<AttributeKeyAndValue> _objectAttributeList = new List<AttributeKeyAndValue>();
        private ObjectReference _objectReference;
        private SchemaFacet _schemaFacet;

        /// <summary>
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// The attributes to set on the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeKeyAndValue> ObjectAttributeList
        {
            get { return this._objectAttributeList; }
            set { this._objectAttributeList = value; }
        }

        // Check to see if ObjectAttributeList property is set
        internal bool IsSetObjectAttributeList()
        {
            return this._objectAttributeList != null && this._objectAttributeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// A reference to the object being mutated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference ObjectReference
        {
            get { return this._objectReference; }
            set { this._objectReference = value; }
        }

        // Check to see if ObjectReference property is set
        internal bool IsSetObjectReference()
        {
            return this._objectReference != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaFacet. 
        /// <para>
        /// Represents the facet being added to the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaFacet SchemaFacet
        {
            get { return this._schemaFacet; }
            set { this._schemaFacet = value; }
        }

        // Check to see if SchemaFacet property is set
        internal bool IsSetSchemaFacet()
        {
            return this._schemaFacet != null;
        }

    }
}