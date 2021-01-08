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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the GetSearchSuggestions operation.
    /// </summary>
    public partial class GetSearchSuggestionsResponse : AmazonWebServiceResponse
    {
        private List<PropertyNameSuggestion> _propertyNameSuggestions = new List<PropertyNameSuggestion>();

        /// <summary>
        /// Gets and sets the property PropertyNameSuggestions. 
        /// <para>
        /// A list of property names for a <code>Resource</code> that match a <code>SuggestionQuery</code>.
        /// </para>
        /// </summary>
        public List<PropertyNameSuggestion> PropertyNameSuggestions
        {
            get { return this._propertyNameSuggestions; }
            set { this._propertyNameSuggestions = value; }
        }

        // Check to see if PropertyNameSuggestions property is set
        internal bool IsSetPropertyNameSuggestions()
        {
            return this._propertyNameSuggestions != null && this._propertyNameSuggestions.Count > 0; 
        }

    }
}