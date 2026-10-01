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
    /// Container for the parameters to the UpdateFacet operation. Does the following: <ol>
    /// <li> <para> Adds new <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>. </para>
    /// </li> <li> <para> Updates existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
    /// </para> </li> <li> <para> Deletes existing <c>Attributes</c>, <c>Rules</c>, or <c>ObjectTypes</c>.
    /// </para> </li> </ol>
    /// </summary>
    public partial class UpdateFacetRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// List of attributes that need to be updated in a given schema <a>Facet</a>. Each attribute
        /// is followed by <c>AttributeAction</c>, which specifies the type of update operation
        /// to perform. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetAttributeUpdate> AttributeUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<FacetAttributeUpdate>() : null;

        /// <summary>
        /// Checks to see if the AttributeUpdates property is set.
        /// </summary>
        internal bool IsSetAttributeUpdates() => this.AttributeUpdates != null && (this.AttributeUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the facet.
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
        /// The object type that is associated with the facet. See <a>CreateFacetRequest$ObjectType</a>
        /// for more details.
        /// </para>
        /// </summary>
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectType property is set.
        /// </summary>
        internal bool IsSetObjectType() => this.ObjectType != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Facet</a>. For more
        /// information, see <a>arns</a>.
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
