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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListModelMetadata operation.
    /// Lists the domain, framework, task, and model name of standard machine learning models
    /// found in common model zoos.
    /// </summary>
    public partial class ListModelMetadataRequest : AmazonSageMakerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ModelMetadataSearchExpression _searchExpression;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of models to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListModelMetadataResponse</c> request was truncated,
        /// the response includes a NextToken. To retrieve the next set of model metadata, use
        /// the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchExpression. 
        /// <para>
        /// One or more filters that searches for the specified resource or resources in a search.
        /// All resource objects that satisfy the expression's condition are included in the search
        /// results. Specify the Framework, FrameworkVersion, Domain or Task to filter supported.
        /// Filter names and values are case-sensitive.
        /// </para>
        /// </summary>
        public ModelMetadataSearchExpression SearchExpression
        {
            get { return this._searchExpression; }
            set { this._searchExpression = value; }
        }

        // Check to see if SearchExpression property is set
        internal bool IsSetSearchExpression()
        {
            return this._searchExpression != null;
        }

    }
}