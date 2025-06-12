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
    /// The document ID and its fields/attributes that are used for a query suggestion, if
    /// document fields set to use for query suggestions.
    /// </summary>
    public partial class SourceDocument
    {
        private List<DocumentAttribute> _additionalAttributes = AWSConfigs.InitializeCollections ? new List<DocumentAttribute>() : null;
        private string _documentId;
        private List<string> _suggestionAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional fields/attributes to include in the response. You can use additional
        /// fields to provide extra information in the response. Additional fields are not used
        /// to based suggestions on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAttribute> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && (this._additionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document used for a query suggestion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestionAttributes. 
        /// <para>
        /// The document fields/attributes used for a query suggestion.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> SuggestionAttributes
        {
            get { return this._suggestionAttributes; }
            set { this._suggestionAttributes = value; }
        }

        // Check to see if SuggestionAttributes property is set
        internal bool IsSetSuggestionAttributes()
        {
            return this._suggestionAttributes != null && (this._suggestionAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}