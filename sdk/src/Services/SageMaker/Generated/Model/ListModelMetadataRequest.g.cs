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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListModelMetadata operation. Lists the domain,
    /// framework, task, and model name of standard machine learning models found in common
    /// model zoos.
    /// </summary>
    public partial class ListModelMetadataRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of models to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListModelMetadataResponse</c> request was truncated,
        /// the response includes a NextToken. To retrieve the next set of model metadata, use
        /// the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchExpression. 
        /// <para>
        /// One or more filters that searches for the specified resource or resources in a search.
        /// All resource objects that satisfy the expression's condition are included in the search
        /// results. Specify the Framework, FrameworkVersion, Domain or Task to filter supported.
        /// Filter names and values are case-sensitive.
        /// </para>
        /// </summary>
        public ModelMetadataSearchExpression SearchExpression { get; set; }

        /// <summary>
        /// Checks to see if the SearchExpression property is set.
        /// </summary>
        internal bool IsSetSearchExpression() => this.SearchExpression != null;
    }
}
