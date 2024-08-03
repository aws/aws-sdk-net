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
    /// Container for the parameters to the ListModelCopyJobs operation.
    /// Returns a list of model copy jobs that you have submitted. You can filter the jobs
    /// to return based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
    /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class ListModelCopyJobsRequest : AmazonBedrockRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private int? _maxResults;
        private string _nextToken;
        private SortJobsBy _sortBy;
        private SortOrder _sortOrder;
        private string _sourceAccountEquals;
        private string _sourceModelArnEquals;
        private ModelCopyJobStatus _statusEquals;
        private string _targetModelNameContains;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Filters for model copy jobs created after the specified time.
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
        /// Filters for model copy jobs created before the specified time. 
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
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
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
        /// The field to sort by in the returned list of model copy jobs.
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
        /// Specifies whether to sort the results in ascending or descending order.
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
        /// Gets and sets the property SourceAccountEquals. 
        /// <para>
        /// Filters for model copy jobs in which the account that the source model belongs to
        /// is equal to the value that you specify.
        /// </para>
        /// </summary>
        public string SourceAccountEquals
        {
            get { return this._sourceAccountEquals; }
            set { this._sourceAccountEquals = value; }
        }

        // Check to see if SourceAccountEquals property is set
        internal bool IsSetSourceAccountEquals()
        {
            return this._sourceAccountEquals != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelArnEquals. 
        /// <para>
        /// Filters for model copy jobs in which the Amazon Resource Name (ARN) of the source
        /// model to is equal to the value that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string SourceModelArnEquals
        {
            get { return this._sourceModelArnEquals; }
            set { this._sourceModelArnEquals = value; }
        }

        // Check to see if SourceModelArnEquals property is set
        internal bool IsSetSourceModelArnEquals()
        {
            return this._sourceModelArnEquals != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filters for model copy jobs whose status matches the value that you specify.
        /// </para>
        /// </summary>
        public ModelCopyJobStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelNameContains. 
        /// <para>
        /// Filters for model copy jobs in which the name of the copied model contains the string
        /// that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string TargetModelNameContains
        {
            get { return this._targetModelNameContains; }
            set { this._targetModelNameContains = value; }
        }

        // Check to see if TargetModelNameContains property is set
        internal bool IsSetTargetModelNameContains()
        {
            return this._targetModelNameContains != null;
        }

    }
}