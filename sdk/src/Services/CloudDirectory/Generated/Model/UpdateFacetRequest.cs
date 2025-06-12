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
    /// Container for the parameters to the UpdateFacet operation.
    /// Does the following:
    /// 
    ///  <ol> <li> 
    /// <para>
    /// Adds new <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Updates existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deletes existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateFacetRequest : AmazonCloudDirectoryRequest
    {
        private List<FacetAttributeUpdate> _attributeUpdates = AWSConfigs.InitializeCollections ? new List<FacetAttributeUpdate>() : null;
        private string _name;
        private ObjectType _objectType;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// List of attributes that need to be updated in a given schema <a>Facet</a>. Each attribute
        /// is followed by <c>AttributeAction</c>, which specifies the type of update operation
        /// to perform. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetAttributeUpdate> AttributeUpdates
        {
            get { return this._attributeUpdates; }
            set { this._attributeUpdates = value; }
        }

        // Check to see if AttributeUpdates property is set
        internal bool IsSetAttributeUpdates()
        {
            return this._attributeUpdates != null && (this._attributeUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the facet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ObjectType. 
        /// <para>
        /// The object type that is associated with the facet. See <a>CreateFacetRequest$ObjectType</a>
        /// for more details.
        /// </para>
        /// </summary>
        public ObjectType ObjectType
        {
            get { return this._objectType; }
            set { this._objectType = value; }
        }

        // Check to see if ObjectType property is set
        internal bool IsSetObjectType()
        {
            return this._objectType != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Facet</a>. For more
        /// information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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