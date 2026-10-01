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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFacet operation. Creates a new <a>Facet</a>
    /// in a schema. Facet creation is allowed only in development or applied schemas.
    /// </summary>
    public partial class CreateFacetRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes that are associated with the <a>Facet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetAttribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<FacetAttribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FacetStyle. 
        /// <para>
        /// There are two different styles that you can define on any given facet, <c>Static</c>
        /// and <c>Dynamic</c>. For static facets, all attributes must be defined in the schema.
        /// For dynamic facets, attributes can be defined during data plane operations.
        /// </para>
        /// </summary>
        public FacetStyle FacetStyle { get; set; }

        /// <summary>
        /// Checks to see if the FacetStyle property is set.
        /// </summary>
        internal bool IsSetFacetStyle() => this.FacetStyle != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>Facet</a>, which is unique for a given schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectType property is set.
        /// </summary>
        internal bool IsSetObjectType() => this.ObjectType != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The schema ARN in which the new <a>Facet</a> will be created. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the SchemaArn property is set.
        /// </summary>
        internal bool IsSetSchemaArn() => this.SchemaArn != null;
    }
}
