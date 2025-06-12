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
    /// Represents the output of a <a>CreateObject</a> operation.
    /// </summary>
    public partial class BatchCreateObject
    {
        private string _batchReferenceName;
        private string _linkName;
        private List<AttributeKeyAndValue> _objectAttributeList = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;
        private ObjectReference _parentReference;
        private List<SchemaFacet> _schemaFacet = AWSConfigs.InitializeCollections ? new List<SchemaFacet>() : null;

        /// <summary>
        /// Gets and sets the property BatchReferenceName. 
        /// <para>
        /// The batch reference name. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/transaction_support.html">Transaction
        /// Support</a> for more information.
        /// </para>
        /// </summary>
        public string BatchReferenceName
        {
            get { return this._batchReferenceName; }
            set { this._batchReferenceName = value; }
        }

        // Check to see if BatchReferenceName property is set
        internal bool IsSetBatchReferenceName()
        {
            return this._batchReferenceName != null;
        }

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link.
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
        /// An attribute map, which contains an attribute ARN as the key and attribute value as
        /// the map value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SchemaFacet. 
        /// <para>
        /// A list of <c>FacetArns</c> that will be associated with the object. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SchemaFacet> SchemaFacet
        {
            get { return this._schemaFacet; }
            set { this._schemaFacet = value; }
        }

        // Check to see if SchemaFacet property is set
        internal bool IsSetSchemaFacet()
        {
            return this._schemaFacet != null && (this._schemaFacet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}