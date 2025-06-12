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
    /// Container for the parameters to the AddFacetToObject operation.
    /// Adds a new <a>Facet</a> to an object. An object can have more than one facet applied
    /// on it.
    /// </summary>
    public partial class AddFacetToObjectRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private List<AttributeKeyAndValue> _objectAttributeList = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;
        private ObjectReference _objectReference;
        private SchemaFacet _schemaFacet;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> where
        /// the object resides. For more information, see <a>arns</a>.
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
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// Attributes on the facet that you are adding to the object.
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
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// A reference to the object you are adding the specified facet to.
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
        /// Identifiers for the facet that you are adding to the object. See <a>SchemaFacet</a>
        /// for details.
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