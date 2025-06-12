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
    /// Updates the configuration information for the document fields/attributes that you
    /// want to base query suggestions on.
    /// 
    ///  
    /// <para>
    /// To deactivate using documents fields for query suggestions, set the mode to <c>INACTIVE</c>.
    /// You must also set <c>SuggestionTypes</c> as either <c>QUERY</c> or <c>DOCUMENT_ATTRIBUTES</c>
    /// and then call <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_GetQuerySuggestions.html">GetQuerySuggestions</a>.
    /// If you set to <c>QUERY</c>, then Amazon Kendra uses the query history to base suggestions
    /// on. If you set to <c>DOCUMENT_ATTRIBUTES</c>, then Amazon Kendra uses the contents
    /// of document fields to base suggestions on.
    /// </para>
    /// </summary>
    public partial class AttributeSuggestionsUpdateConfig
    {
        private AttributeSuggestionsMode _attributeSuggestionsMode;
        private List<SuggestableConfig> _suggestableConfigList = AWSConfigs.InitializeCollections ? new List<SuggestableConfig>() : null;

        /// <summary>
        /// Gets and sets the property AttributeSuggestionsMode. 
        /// <para>
        /// You can set the mode to <c>ACTIVE</c> or <c>INACTIVE</c>. You must also set <c>SuggestionTypes</c>
        /// as either <c>QUERY</c> or <c>DOCUMENT_ATTRIBUTES</c> and then call <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_GetQuerySuggestions.html">GetQuerySuggestions</a>.
        /// If <c>Mode</c> to use query history is set to <c>ENABLED</c> when calling <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateQuerySuggestionsConfig.html">UpdateQuerySuggestionsConfig</a>
        /// and <c>AttributeSuggestionsMode</c> to use fields/attributes is set to <c>ACTIVE</c>,
        /// and you haven't set your <c>SuggestionTypes</c> preference to <c>DOCUMENT_ATTRIBUTES</c>,
        /// then Amazon Kendra uses the query history.
        /// </para>
        /// </summary>
        public AttributeSuggestionsMode AttributeSuggestionsMode
        {
            get { return this._attributeSuggestionsMode; }
            set { this._attributeSuggestionsMode = value; }
        }

        // Check to see if AttributeSuggestionsMode property is set
        internal bool IsSetAttributeSuggestionsMode()
        {
            return this._attributeSuggestionsMode != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestableConfigList. 
        /// <para>
        /// The list of fields/attributes that you want to set as suggestible for query suggestions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuggestableConfig> SuggestableConfigList
        {
            get { return this._suggestableConfigList; }
            set { this._suggestableConfigList = value; }
        }

        // Check to see if SuggestableConfigList property is set
        internal bool IsSetSuggestableConfigList()
        {
            return this._suggestableConfigList != null && (this._suggestableConfigList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}