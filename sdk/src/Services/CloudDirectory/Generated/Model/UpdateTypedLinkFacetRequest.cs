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
    /// Container for the parameters to the UpdateTypedLinkFacet operation.
    /// Updates a <a>TypedLinkFacet</a>. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
    /// Links</a>.
    /// </summary>
    public partial class UpdateTypedLinkFacetRequest : AmazonCloudDirectoryRequest
    {
        private List<TypedLinkFacetAttributeUpdate> _attributeUpdates = new List<TypedLinkFacetAttributeUpdate>();
        private List<string> _identityAttributeOrder = new List<string>();
        private string _name;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// Attributes update structure.
        /// </para>
        /// </summary>
        public List<TypedLinkFacetAttributeUpdate> AttributeUpdates
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
        /// Gets and sets the property IdentityAttributeOrder. 
        /// <para>
        /// The order of identity attributes for the facet, from most significant to least significant.
        /// The ability to filter typed links considers the order that the attributes are defined
        /// on the typed link facet. When providing ranges to a typed link selection, any inexact
        /// ranges must be specified at the end. Any attributes that do not have a range specified
        /// are presumed to match the entire range. Filters are interpreted in the order of the
        /// attributes on the typed link facet, not the order in which they are supplied to any
        /// API calls. For more information about identity attributes, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public List<string> IdentityAttributeOrder
        {
            get { return this._identityAttributeOrder; }
            set { this._identityAttributeOrder = value; }
        }

        // Check to see if IdentityAttributeOrder property is set
        internal bool IsSetIdentityAttributeOrder()
        {
            return this._identityAttributeOrder != null && this._identityAttributeOrder.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the typed link facet.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the schema. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// </summary>
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

    }
}