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
    /// Container for the parameters to the ListTrainingJobsForHyperParameterTuningJob operation.
    /// Gets a list of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html">TrainingJobSummary</a>
    /// objects that describe the training jobs that a hyperparameter tuning job launched.
    /// </summary>
    public partial class ListTrainingJobsForHyperParameterTuningJobRequest : AmazonSageMakerRequest
    {
        private string _hyperParameterTuningJobName;
        private int? _maxResults;
        private string _nextToken;
        private TrainingJobSortByOptions _sortBy;
        private SortOrder _sortOrder;
        private TrainingJobStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of the tuning job whose training jobs you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string HyperParameterTuningJobName
        {
            get { return this._hyperParameterTuningJobName; }
            set { this._hyperParameterTuningJobName = value; }
        }

        // Check to see if HyperParameterTuningJobName property is set
        internal bool IsSetHyperParameterTuningJobName()
        {
            return this._hyperParameterTuningJobName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of training jobs to return. The default value is 10.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <c>ListTrainingJobsForHyperParameterTuningJob</c> request
        /// was truncated, the response includes a <c>NextToken</c>. To retrieve the next set
        /// of training jobs, use the token in the next request.
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
        /// The field to sort results by. The default is <c>Name</c>.
        /// </para>
        ///  
        /// <para>
        /// If the value of this field is <c>FinalObjectiveMetricValue</c>, any training jobs
        /// that did not return an objective metric are not listed.
        /// </para>
        /// </summary>
        public TrainingJobSortByOptions SortBy
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
        /// A filter that returns only training jobs with the specified status.
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

    }
}