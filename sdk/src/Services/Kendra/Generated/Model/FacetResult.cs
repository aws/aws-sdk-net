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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// The facet values for the documents in the response.
    /// </summary>
    public partial class FacetResult
    {
        private string _documentAttributeKey;
        private List<DocumentAttributeValueCountPair> _documentAttributeValueCountPairs = AWSConfigs.InitializeCollections ? new List<DocumentAttributeValueCountPair>() : null;
        private DocumentAttributeValueType _documentAttributeValueType;

        /// <summary>
        /// Gets and sets the property DocumentAttributeKey. 
        /// <para>
        /// The key for the facet values. This is the same as the <c>DocumentAttributeKey</c>
        /// provided in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DocumentAttributeKey
        {
            get { return this._documentAttributeKey; }
            set { this._documentAttributeKey = value; }
        }

        // Check to see if DocumentAttributeKey property is set
        internal bool IsSetDocumentAttributeKey()
        {
            return this._documentAttributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributeValueCountPairs. 
        /// <para>
        /// An array of key/value pairs, where the key is the value of the attribute and the count
        /// is the number of documents that share the key value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAttributeValueCountPair> DocumentAttributeValueCountPairs
        {
            get { return this._documentAttributeValueCountPairs; }
            set { this._documentAttributeValueCountPairs = value; }
        }

        // Check to see if DocumentAttributeValueCountPairs property is set
        internal bool IsSetDocumentAttributeValueCountPairs()
        {
            return this._documentAttributeValueCountPairs != null && (this._documentAttributeValueCountPairs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributeValueType. 
        /// <para>
        /// The data type of the facet value. This is the same as the type defined for the index
        /// field when it was created.
        /// </para>
        /// </summary>
        public DocumentAttributeValueType DocumentAttributeValueType
        {
            get { return this._documentAttributeValueType; }
            set { this._documentAttributeValueType = value; }
        }

        // Check to see if DocumentAttributeValueType property is set
        internal bool IsSetDocumentAttributeValueType()
        {
            return this._documentAttributeValueType != null;
        }

    }
}