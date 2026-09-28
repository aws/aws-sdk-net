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
    /// Container for the parameters to the CreateObject operation. Creates an object in a
    /// <a>Directory</a>. Additionally attaches the object to a parent, if a parent reference
    /// and <c>LinkName</c> is specified. An object is simply a collection of <a>Facet</a>
    /// attributes. You can also use this API call to create a policy object, if the facet
    /// from which you create the object is a policy facet.
    /// </summary>
    public partial class CreateObjectRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> in which
        /// the object will be created. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of link that is used to attach this object to a parent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LinkName { get; set; }

        /// <summary>
        /// Checks to see if the LinkName property is set.
        /// </summary>
        internal bool IsSetLinkName() => this.LinkName != null;

        /// <summary>
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// The attribute map whose attribute ARN contains the key and attribute value as the
        /// map value.
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
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// If specified, the parent reference to which this object will be attached.
        /// </para>
        /// </summary>
        public ObjectReference ParentReference { get; set; }

        /// <summary>
        /// Checks to see if the ParentReference property is set.
        /// </summary>
        internal bool IsSetParentReference() => this.ParentReference != null;

        /// <summary>
        /// Gets and sets the property SchemaFacets. 
        /// <para>
        /// A list of schema facets to be associated with the object. Do not provide minor version
        /// components. See <a>SchemaFacet</a> for details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SchemaFacet> SchemaFacets { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaFacet>() : null;

        /// <summary>
        /// Checks to see if the SchemaFacets property is set.
        /// </summary>
        internal bool IsSetSchemaFacets() => this.SchemaFacets != null && (this.SchemaFacets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
