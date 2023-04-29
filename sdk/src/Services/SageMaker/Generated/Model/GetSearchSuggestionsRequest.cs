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
    /// Container for the parameters to the GetSearchSuggestions operation.
    /// An auto-complete API for the search functionality in the SageMaker console. It returns
    /// suggestions of possible matches for the property name to use in <code>Search</code>
    /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
    /// and <code>Metrics</code>.
    /// </summary>
    public partial class GetSearchSuggestionsRequest : AmazonSageMakerRequest
    {
        private ResourceType _resource;
        private SuggestionQuery _suggestionQuery;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name of the SageMaker resource to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestionQuery. 
        /// <para>
        /// Limits the property names that are included in the response.
        /// </para>
        /// </summary>
        public SuggestionQuery SuggestionQuery
        {
            get { return this._suggestionQuery; }
            set { this._suggestionQuery = value; }
        }

        // Check to see if SuggestionQuery property is set
        internal bool IsSetSuggestionQuery()
        {
            return this._suggestionQuery != null;
        }

    }
}