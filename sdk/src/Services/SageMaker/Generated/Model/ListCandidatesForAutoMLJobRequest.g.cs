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
    /// Container for the parameters to the ListCandidatesForAutoMLJob operation. List the
    /// candidates created for the job.
    /// </summary>
    public partial class ListCandidatesForAutoMLJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// List the candidates created for the job by providing the job's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string AutoMLJobName { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobName property is set.
        /// </summary>
        internal bool IsSetAutoMLJobName() => this.AutoMLJobName != null;

        /// <summary>
        /// Gets and sets the property CandidateNameEquals. 
        /// <para>
        /// List the candidates for the job and filter by candidate name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CandidateNameEquals { get; set; }

        /// <summary>
        /// Checks to see if the CandidateNameEquals property is set.
        /// </summary>
        internal bool IsSetCandidateNameEquals() => this.CandidateNameEquals != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// List the job's candidates up to a specified limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you receive this token. Use it in your next
        /// request to receive the next set of results.
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
        /// The parameter by which to sort the results. The default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public CandidateSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. The default is <c>Ascending</c>.
        /// </para>
        /// </summary>
        public AutoMLSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// List the candidates for the job and filter by status.
        /// </para>
        /// </summary>
        public CandidateStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
