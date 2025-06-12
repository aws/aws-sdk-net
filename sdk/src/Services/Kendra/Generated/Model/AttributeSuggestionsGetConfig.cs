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
    /// Provides the configuration information for the document fields/attributes that you
    /// want to base query suggestions on.
    /// </summary>
    public partial class AttributeSuggestionsGetConfig
    {
        private List<string> _additionalResponseAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AttributeFilter _attributeFilter;
        private List<string> _suggestionAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UserContext _userContext;

        /// <summary>
        /// Gets and sets the property AdditionalResponseAttributes. 
        /// <para>
        /// The list of additional document field/attribute keys or field names to include in
        /// the response. You can use additional fields to provide extra information in the response.
        /// Additional fields are not used to based suggestions on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> AdditionalResponseAttributes
        {
            get { return this._additionalResponseAttributes; }
            set { this._additionalResponseAttributes = value; }
        }

        // Check to see if AdditionalResponseAttributes property is set
        internal bool IsSetAdditionalResponseAttributes()
        {
            return this._additionalResponseAttributes != null && (this._additionalResponseAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Filters the search results based on document fields/attributes.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestionAttributes. 
        /// <para>
        /// The list of document field/attribute keys or field names to use for query suggestions.
        /// If the content within any of the fields match what your user starts typing as their
        /// query, then the field content is returned as a query suggestion.
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

        /// <summary>
        /// Gets and sets the property UserContext. 
        /// <para>
        /// Applies user context filtering so that only users who are given access to certain
        /// documents see these document in their search results.
        /// </para>
        /// </summary>
        public UserContext UserContext
        {
            get { return this._userContext; }
            set { this._userContext = value; }
        }

        // Check to see if UserContext property is set
        internal bool IsSetUserContext()
        {
            return this._userContext != null;
        }

    }
}