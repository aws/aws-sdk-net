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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListCustomModelDeployments operation. Lists custom
    /// model deployments in your account. You can filter the results by creation time, name,
    /// status, and associated model. Use this operation to manage and monitor your custom
    /// model deployments. <para> We recommend using pagination to ensure that the operation
    /// returns quickly and successfully. </para> <para> The following actions are related
    /// to the <c>ListCustomModelDeployments</c> operation: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class ListCustomModelDeploymentsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filters deployments created after the specified date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filters deployments created before the specified date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelArnEquals. 
        /// <para>
        /// Filters deployments by the Amazon Resource Name (ARN) of the associated custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string ModelArnEquals { get; set; }

        /// <summary>
        /// Checks to see if the ModelArnEquals property is set.
        /// </summary>
        internal bool IsSetModelArnEquals() => this.ModelArnEquals != null;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Filters deployments whose names contain the specified string. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use this token to retrieve additional results
        /// when the response is truncated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort the results by. The only supported value is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SortModelsBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. Valid values are <c>Ascending</c> and <c>Descending</c>.
        /// Default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filters deployments by status. Valid values are <c>CREATING</c>, <c>ACTIVE</c>, and
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public CustomModelDeploymentStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
