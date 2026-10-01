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
    /// Container for the parameters to the AddFacetToObject operation. Adds a new <a>Facet</a>
    /// to an object. An object can have more than one facet applied on it.
    /// </summary>
    public partial class AddFacetToObjectRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> where
        /// the object resides. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// Attributes on the facet that you are adding to the object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeKeyAndValue> ObjectAttributeList { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;

        /// <summary>
        /// Checks to see if the ObjectAttributeList property is set.
        /// </summary>
        internal bool IsSetObjectAttributeList() => this.ObjectAttributeList != null && (this.ObjectAttributeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// A reference to the object you are adding the specified facet to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ObjectReference { get; set; }

        /// <summary>
        /// Checks to see if the ObjectReference property is set.
        /// </summary>
        internal bool IsSetObjectReference() => this.ObjectReference != null;

        /// <summary>
        /// Gets and sets the property SchemaFacet. 
        /// <para>
        /// Identifiers for the facet that you are adding to the object. See <a>SchemaFacet</a>
        /// for details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaFacet SchemaFacet { get; set; }

        /// <summary>
        /// Checks to see if the SchemaFacet property is set.
        /// </summary>
        internal bool IsSetSchemaFacet() => this.SchemaFacet != null;
    }
}
