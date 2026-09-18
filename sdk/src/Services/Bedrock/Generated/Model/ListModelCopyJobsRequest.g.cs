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
    /// Container for the parameters to the ListModelCopyJobs operation. Returns a list of
    /// model copy jobs that you have submitted. You can filter the jobs to return based on
    /// one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
    /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class ListModelCopyJobsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Filters for model copy jobs created after the specified time.
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
        /// Filters for model copy jobs created before the specified time. 
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
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
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
        /// The field to sort by in the returned list of model copy jobs.
        /// </para>
        /// </summary>
        public SortJobsBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies whether to sort the results in ascending or descending order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property SourceAccountEquals. 
        /// <para>
        /// Filters for model copy jobs in which the account that the source model belongs to
        /// is equal to the value that you specify.
        /// </para>
        /// </summary>
        public string SourceAccountEquals { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountEquals property is set.
        /// </summary>
        internal bool IsSetSourceAccountEquals() => this.SourceAccountEquals != null;

        /// <summary>
        /// Gets and sets the property SourceModelArnEquals. 
        /// <para>
        /// Filters for model copy jobs in which the Amazon Resource Name (ARN) of the source
        /// model to is equal to the value that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string SourceModelArnEquals { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelArnEquals property is set.
        /// </summary>
        internal bool IsSetSourceModelArnEquals() => this.SourceModelArnEquals != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filters for model copy jobs whose status matches the value that you specify.
        /// </para>
        /// </summary>
        public ModelCopyJobStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;

        /// <summary>
        /// Gets and sets the property TargetModelNameContains. 
        /// <para>
        /// Filters for model copy jobs in which the name of the copied model contains the string
        /// that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string TargetModelNameContains { get; set; }

        /// <summary>
        /// Checks to see if the TargetModelNameContains property is set.
        /// </summary>
        internal bool IsSetTargetModelNameContains() => this.TargetModelNameContains != null;
    }
}
