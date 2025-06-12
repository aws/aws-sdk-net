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
    /// Container for the parameters to the CreateObject operation.
    /// Creates an object in a <a>Directory</a>. Additionally attaches the object to a parent,
    /// if a parent reference and <c>LinkName</c> is specified. An object is simply a collection
    /// of <a>Facet</a> attributes. You can also use this API call to create a policy object,
    /// if the facet from which you create the object is a policy facet.
    /// </summary>
    public partial class CreateObjectRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private string _linkName;
        private List<AttributeKeyAndValue> _objectAttributeList = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;
        private ObjectReference _parentReference;
        private List<SchemaFacet> _schemaFacets = AWSConfigs.InitializeCollections ? new List<SchemaFacet>() : null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> in which
        /// the object will be created. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of link that is used to attach this object to a parent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LinkName
        {
            get { return this._linkName; }
            set { this._linkName = value; }
        }

        // Check to see if LinkName property is set
        internal bool IsSetLinkName()
        {
            return this._linkName != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// The attribute map whose attribute ARN contains the key and attribute value as the
        /// map value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeKeyAndValue> ObjectAttributeList
        {
            get { return this._objectAttributeList; }
            set { this._objectAttributeList = value; }
        }

        // Check to see if ObjectAttributeList property is set
        internal bool IsSetObjectAttributeList()
        {
            return this._objectAttributeList != null && (this._objectAttributeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// If specified, the parent reference to which this object will be attached.
        /// </para>
        /// </summary>
        public ObjectReference ParentReference
        {
            get { return this._parentReference; }
            set { this._parentReference = value; }
        }

        // Check to see if ParentReference property is set
        internal bool IsSetParentReference()
        {
            return this._parentReference != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaFacets. 
        /// <para>
        /// A list of schema facets to be associated with the object. Do not provide minor version
        /// components. See <a>SchemaFacet</a> for details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SchemaFacet> SchemaFacets
        {
            get { return this._schemaFacets; }
            set { this._schemaFacets = value; }
        }

        // Check to see if SchemaFacets property is set
        internal bool IsSetSchemaFacets()
        {
            return this._schemaFacets != null && (this._schemaFacets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}