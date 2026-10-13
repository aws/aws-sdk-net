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
    /// Container for the parameters to the ListModelCardExportJobs operation. List the export
    /// jobs for the Amazon SageMaker Model Card.
    /// </summary>
    public partial class ListModelCardExportJobsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Only list model card export jobs that were created after the time specified.
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
        /// Only list model card export jobs that were created before the time specified.
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
        /// The maximum number of model card export jobs to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelCardExportJobNameContains. 
        /// <para>
        /// Only list model card export jobs with names that contain the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelCardExportJobNameContains { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardExportJobNameContains property is set.
        /// </summary>
        internal bool IsSetModelCardExportJobNameContains() => this.ModelCardExportJobNameContains != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// List export jobs for the model card with the specified name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// List export jobs for the model card with the specified version.
        /// </para>
        /// </summary>
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListModelCardExportJobs</c> request was truncated,
        /// the response includes a <c>NextToken</c>. To retrieve the next set of model card export
        /// jobs, use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Sort model card export jobs by either name or creation time. Sorts by creation time
        /// by default.
        /// </para>
        /// </summary>
        public ModelCardExportJobSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Sort model card export jobs by ascending or descending order.
        /// </para>
        /// </summary>
        public ModelCardExportJobSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Only list model card export jobs with the specified status.
        /// </para>
        /// </summary>
        public ModelCardExportJobStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
