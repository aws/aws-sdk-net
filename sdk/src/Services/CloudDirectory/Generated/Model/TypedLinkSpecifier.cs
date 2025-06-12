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
    /// Contains all the information that is used to uniquely identify a typed link. The parameters
    /// discussed in this topic are used to uniquely specify the typed link being operated
    /// on. The <a>AttachTypedLink</a> API returns a typed link specifier while the <a>DetachTypedLink</a>
    /// API accepts one as input. Similarly, the <a>ListIncomingTypedLinks</a> and <a>ListOutgoingTypedLinks</a>
    /// API operations provide typed link specifiers as output. You can also construct a typed
    /// link specifier from scratch.
    /// </summary>
    public partial class TypedLinkSpecifier
    {
        private List<AttributeNameAndValue> _identityAttributeValues = AWSConfigs.InitializeCollections ? new List<AttributeNameAndValue>() : null;
        private ObjectReference _sourceObjectReference;
        private ObjectReference _targetObjectReference;
        private TypedLinkSchemaAndFacetName _typedLinkFacet;

        /// <summary>
        /// Gets and sets the property IdentityAttributeValues. 
        /// <para>
        /// Identifies the attribute value to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeNameAndValue> IdentityAttributeValues
        {
            get { return this._identityAttributeValues; }
            set { this._identityAttributeValues = value; }
        }

        // Check to see if IdentityAttributeValues property is set
        internal bool IsSetIdentityAttributeValues()
        {
            return this._identityAttributeValues != null && (this._identityAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceObjectReference. 
        /// <para>
        /// Identifies the source object that the typed link will attach to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference SourceObjectReference
        {
            get { return this._sourceObjectReference; }
            set { this._sourceObjectReference = value; }
        }

        // Check to see if SourceObjectReference property is set
        internal bool IsSetSourceObjectReference()
        {
            return this._sourceObjectReference != null;
        }

        /// <summary>
        /// Gets and sets the property TargetObjectReference. 
        /// <para>
        /// Identifies the target object that the typed link will attach to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference TargetObjectReference
        {
            get { return this._targetObjectReference; }
            set { this._targetObjectReference = value; }
        }

        // Check to see if TargetObjectReference property is set
        internal bool IsSetTargetObjectReference()
        {
            return this._targetObjectReference != null;
        }

        /// <summary>
        /// Gets and sets the property TypedLinkFacet. 
        /// <para>
        /// Identifies the typed link facet that is associated with the typed link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TypedLinkSchemaAndFacetName TypedLinkFacet
        {
            get { return this._typedLinkFacet; }
            set { this._typedLinkFacet = value; }
        }

        // Check to see if TypedLinkFacet property is set
        internal bool IsSetTypedLinkFacet()
        {
            return this._typedLinkFacet != null;
        }

    }
}