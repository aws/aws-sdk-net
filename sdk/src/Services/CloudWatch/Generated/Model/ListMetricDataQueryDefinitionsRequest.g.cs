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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetricDataQueryDefinitions operation. Lists
    /// the metric data query definitions in your account and Region. <para> The results are
    /// summaries that don't include the expression. To get the full definition, call <c>GetMetricDataQueryDefinition</c>
    /// with its ID. </para> <para> This operation supports pagination. Use the <c>MaxResults</c>
    /// and <c>NextToken</c> parameters to retrieve results in multiple calls. </para> <para>
    /// <b>Permissions</b> </para> <para> To list definitions, you need the <c>cloudwatch:ListMetricDataQueryDefinitions</c>
    /// permission. This permission applies to all definitions in the account and Region.
    /// The results aren't filtered by tags. </para>
    /// </summary>
    public partial class ListMetricDataQueryDefinitionsRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of metric data query definitions to return in one call. The default
        /// is 100.
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
        /// The token returned by a previous call to indicate where to continue retrieving results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
