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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Gets information on the configuration of document fields/attributes that you want
    /// to base query suggestions on. To change your configuration, use <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_AttributeSuggestionsUpdateConfig.html">AttributeSuggestionsUpdateConfig</a>
    /// and then call <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateQuerySuggestionsConfig.html">UpdateQuerySuggestionsConfig</a>.
    /// </summary>
    public partial class AttributeSuggestionsDescribeConfig
    {
        private AttributeSuggestionsMode _attributeSuggestionsMode;
        private List<SuggestableConfig> _suggestableConfigList = new List<SuggestableConfig>();

        /// <summary>
        /// Gets and sets the property AttributeSuggestionsMode. 
        /// <para>
        /// The mode is set to either <code>ACTIVE</code> or <code>INACTIVE</code>. If the <code>Mode</code>
        /// for query history is set to <code>ENABLED</code> when calling <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateQuerySuggestionsConfig.html">UpdateQuerySuggestionsConfig</a>
        /// and <code>AttributeSuggestionsMode</code> to use fields/attributes is set to <code>ACTIVE</code>,
        /// and you haven't set your <code>SuggestionTypes</code> preference to <code>DOCUMENT_ATTRIBUTES</code>,
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
        /// </summary>
        public List<SuggestableConfig> SuggestableConfigList
        {
            get { return this._suggestableConfigList; }
            set { this._suggestableConfigList = value; }
        }

        // Check to see if SuggestableConfigList property is set
        internal bool IsSetSuggestableConfigList()
        {
            return this._suggestableConfigList != null && this._suggestableConfigList.Count > 0; 
        }

    }
}