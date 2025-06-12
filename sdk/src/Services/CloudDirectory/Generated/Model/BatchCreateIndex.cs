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
    /// Creates an index object inside of a <a>BatchRead</a> operation. For more information,
    /// see <a>CreateIndex</a> and <a>BatchReadRequest$Operations</a>.
    /// </summary>
    public partial class BatchCreateIndex
    {
        private string _batchReferenceName;
        private bool? _isUnique;
        private string _linkName;
        private List<AttributeKey> _orderedIndexedAttributeList = AWSConfigs.InitializeCollections ? new List<AttributeKey>() : null;
        private ObjectReference _parentReference;

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
        /// Gets and sets the property IsUnique. 
        /// <para>
        /// Indicates whether the attribute that is being indexed has unique values or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsUnique
        {
            get { return this._isUnique; }
            set { this._isUnique = value; }
        }

        // Check to see if IsUnique property is set
        internal bool IsSetIsUnique()
        {
            return this._isUnique.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link between the parent object and the index object.
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
        /// Gets and sets the property OrderedIndexedAttributeList. 
        /// <para>
        /// Specifies the attributes that should be indexed on. Currently only a single attribute
        /// is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeKey> OrderedIndexedAttributeList
        {
            get { return this._orderedIndexedAttributeList; }
            set { this._orderedIndexedAttributeList = value; }
        }

        // Check to see if OrderedIndexedAttributeList property is set
        internal bool IsSetOrderedIndexedAttributeList()
        {
            return this._orderedIndexedAttributeList != null && (this._orderedIndexedAttributeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// A reference to the parent object that contains the index object.
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

    }
}