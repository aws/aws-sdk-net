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
    /// Container for the parameters to the ListCandidatesForAutoMLJob operation.
    /// List the candidates created for the job.
    /// </summary>
    public partial class ListCandidatesForAutoMLJobRequest : AmazonSageMakerRequest
    {
        private string _autoMLJobName;
        private string _candidateNameEquals;
        private int? _maxResults;
        private string _nextToken;
        private CandidateSortBy _sortBy;
        private AutoMLSortOrder _sortOrder;
        private CandidateStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// List the candidates created for the job by providing the job's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateNameEquals. 
        /// <para>
        /// List the candidates for the job and filter by candidate name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CandidateNameEquals
        {
            get { return this._candidateNameEquals; }
            set { this._candidateNameEquals = value; }
        }

        // Check to see if CandidateNameEquals property is set
        internal bool IsSetCandidateNameEquals()
        {
            return this._candidateNameEquals != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// List the job's candidates up to a specified limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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
        /// If the previous response was truncated, you receive this token. Use it in your next
        /// request to receive the next set of results.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The parameter by which to sort the results. The default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public CandidateSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. The default is <c>Ascending</c>.
        /// </para>
        /// </summary>
        public AutoMLSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// List the candidates for the job and filter by status.
        /// </para>
        /// </summary>
        public CandidateStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

    }
}