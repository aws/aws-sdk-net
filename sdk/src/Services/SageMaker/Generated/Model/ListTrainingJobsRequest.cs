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
    /// Container for the parameters to the ListTrainingJobs operation.
    /// Lists training jobs.
    /// 
    ///  <note> 
    /// <para>
    /// When <c>StatusEquals</c> and <c>MaxResults</c> are set at the same time, the <c>MaxResults</c>
    /// number of training jobs are first retrieved ignoring the <c>StatusEquals</c> parameter
    /// and then they are filtered by the <c>StatusEquals</c> parameter, which is returned
    /// as a response.
    /// </para>
    ///  
    /// <para>
    /// For example, if <c>ListTrainingJobs</c> is invoked with the following parameters:
    /// </para>
    ///  
    /// <para>
    ///  <c>{ ... MaxResults: 100, StatusEquals: InProgress ... }</c> 
    /// </para>
    ///  
    /// <para>
    /// First, 100 trainings jobs with any status, including those other than <c>InProgress</c>,
    /// are selected (sorted according to the creation time, from the most current to the
    /// oldest). Next, those with a status of <c>InProgress</c> are returned.
    /// </para>
    ///  
    /// <para>
    /// You can quickly test the API using the following Amazon Web Services CLI code.
    /// </para>
    ///  
    /// <para>
    ///  <c>aws sagemaker list-training-jobs --max-results 100 --status-equals InProgress</c>
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListTrainingJobsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private DateTime? _lastModifiedTimeAfter;
        private DateTime? _lastModifiedTimeBefore;
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private SortBy _sortBy;
        private SortOrder _sortOrder;
        private TrainingJobStatus _statusEquals;
        private string _trainingPlanArnEquals;
        private WarmPoolResourceStatus _warmPoolStatusEquals;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only training jobs created after the specified time (timestamp).
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
        /// A filter that returns only training jobs created before the specified time (timestamp).
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
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only training jobs modified after the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter
        {
            get { return this._lastModifiedTimeAfter; }
            set { this._lastModifiedTimeAfter = value; }
        }

        // Check to see if LastModifiedTimeAfter property is set
        internal bool IsSetLastModifiedTimeAfter()
        {
            return this._lastModifiedTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only training jobs modified before the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore
        {
            get { return this._lastModifiedTimeBefore; }
            set { this._lastModifiedTimeBefore = value; }
        }

        // Check to see if LastModifiedTimeBefore property is set
        internal bool IsSetLastModifiedTimeBefore()
        {
            return this._lastModifiedTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of training jobs to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A string in the training job name. This filter returns only training jobs whose name
        /// contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// If the result of the previous <c>ListTrainingJobs</c> request was truncated, the response
        /// includes a <c>NextToken</c>. To retrieve the next set of training jobs, use the token
        /// in the next request. 
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
        /// The field to sort results by. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SortBy SortBy
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
        /// The sort order for results. The default is <c>Ascending</c>.
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
        /// A filter that retrieves only training jobs with a specific status.
        /// </para>
        /// </summary>
        public TrainingJobStatus StatusEquals
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
        /// Gets and sets the property TrainingPlanArnEquals. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan to filter training jobs by. For
        /// more information about reserving GPU capacity for your SageMaker training jobs using
        /// Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=2048)]
        public string TrainingPlanArnEquals
        {
            get { return this._trainingPlanArnEquals; }
            set { this._trainingPlanArnEquals = value; }
        }

        // Check to see if TrainingPlanArnEquals property is set
        internal bool IsSetTrainingPlanArnEquals()
        {
            return this._trainingPlanArnEquals != null;
        }

        /// <summary>
        /// Gets and sets the property WarmPoolStatusEquals. 
        /// <para>
        /// A filter that retrieves only training jobs with a specific warm pool status.
        /// </para>
        /// </summary>
        public WarmPoolResourceStatus WarmPoolStatusEquals
        {
            get { return this._warmPoolStatusEquals; }
            set { this._warmPoolStatusEquals = value; }
        }

        // Check to see if WarmPoolStatusEquals property is set
        internal bool IsSetWarmPoolStatusEquals()
        {
            return this._warmPoolStatusEquals != null;
        }

    }
}