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
    /// Container for the parameters to the CreateFacet operation.
    /// Creates a new <a>Facet</a> in a schema. Facet creation is allowed only in development
    /// or applied schemas.
    /// </summary>
    public partial class CreateFacetRequest : AmazonCloudDirectoryRequest
    {
        private List<FacetAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<FacetAttribute>() : null;
        private FacetStyle _facetStyle;
        private string _name;
        private ObjectType _objectType;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes that are associated with the <a>Facet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FacetStyle. 
        /// <para>
        /// There are two different styles that you can define on any given facet, <c>Static</c>
        /// and <c>Dynamic</c>. For static facets, all attributes must be defined in the schema.
        /// For dynamic facets, attributes can be defined during data plane operations.
        /// </para>
        /// </summary>
        public FacetStyle FacetStyle
        {
            get { return this._facetStyle; }
            set { this._facetStyle = value; }
        }

        // Check to see if FacetStyle property is set
        internal bool IsSetFacetStyle()
        {
            return this._facetStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>Facet</a>, which is unique for a given schema.
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
        /// Specifies whether a given object created from this facet is of type node, leaf node,
        /// policy or index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Node: Can have multiple children but one parent.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Leaf node: Cannot have children but can have multiple parents.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Policy: Allows you to store a policy document and policy type. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Index: Can be created with the Index API.
        /// </para>
        ///  </li> </ul>
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
        /// The schema ARN in which the new <a>Facet</a> will be created. For more information,
        /// see <a>arns</a>.
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