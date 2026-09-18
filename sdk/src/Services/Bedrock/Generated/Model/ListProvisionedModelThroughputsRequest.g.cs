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
    /// Container for the parameters to the ListProvisionedModelThroughputs operation. Lists
    /// the Provisioned Throughputs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
    /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class ListProvisionedModelThroughputsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns Provisioned Throughputs created after the specified time. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns Provisioned Throughputs created before the specified time. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// THe maximum number of results to return in the response. If there are more results
        /// than the number you specified, the response returns a <c>nextToken</c> value. To see
        /// the next batch of results, send the <c>nextToken</c> value in another list request.
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
        /// A filter that returns Provisioned Throughputs whose model Amazon Resource Name (ARN)
        /// is equal to the value that you specify.
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
        /// A filter that returns Provisioned Throughputs if their name contains the expression
        /// that you specify.
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
        /// If there are more results than the number you specified in the <c>maxResults</c> field,
        /// the response returns a <c>nextToken</c> value. To see the next batch of results, specify
        /// the <c>nextToken</c> value in this field.
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
        /// The field by which to sort the returned list of Provisioned Throughputs.
        /// </para>
        /// </summary>
        public SortByProvisionedModels SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order of the results.
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
        /// A filter that returns Provisioned Throughputs if their statuses matches the value
        /// that you specify.
        /// </para>
        /// </summary>
        public ProvisionedModelStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
