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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// Container for the parameters to the ListEvaluationJobs operation.
    /// Lists all existing evaluation jobs.
    /// </summary>
    public partial class ListEvaluationJobsRequest : AmazonBedrockRequest
    {
        private ApplicationType _applicationTypeEquals;
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private SortJobsBy _sortBy;
        private SortOrder _sortOrder;
        private EvaluationJobStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property ApplicationTypeEquals. 
        /// <para>
        /// A filter to only list evaluation jobs that are either model evaluations or knowledge
        /// base evaluations.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationTypeEquals
        {
            get { return this._applicationTypeEquals; }
            set { this._applicationTypeEquals = value; }
        }

        // Check to see if ApplicationTypeEquals property is set
        internal bool IsSetApplicationTypeEquals()
        {
            return this._applicationTypeEquals != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter to only list evaluation jobs created after a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter to only list evaluation jobs created before a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A filter to only list evaluation jobs that contain a specified string in the job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Continuation token from the previous response, for Amazon Bedrock to list the next
        /// set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Specifies a creation time to sort the list of evaluation jobs by when they were created.
        /// </para>
        /// </summary>
        public SortJobsBy SortBy
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
        /// Specifies whether to sort the list of evaluation jobs by either ascending or descending
        /// order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
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
        /// A filter to only list evaluation jobs that are of a certain status.
        /// </para>
        /// </summary>
        public EvaluationJobStatus StatusEquals
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