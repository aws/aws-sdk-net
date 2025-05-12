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
    /// Container for the parameters to the ListInferenceRecommendationsJobSteps operation.
    /// Returns a list of the subtasks for an Inference Recommender job.
    /// 
    ///  
    /// <para>
    /// The supported subtasks are benchmarks, which evaluate the performance of your model
    /// on different instance types.
    /// </para>
    /// </summary>
    public partial class ListInferenceRecommendationsJobStepsRequest : AmazonSageMakerRequest
    {
        private string _jobName;
        private int? _maxResults;
        private string _nextToken;
        private RecommendationJobStatus _status;
        private RecommendationStepType _stepType;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// A token that you can specify to return more results from the list. Specify this field
        /// if you have a token that was returned from a previous request.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A filter to return benchmarks of a specified status. If this field is left empty,
        /// then all benchmarks are returned.
        /// </para>
        /// </summary>
        public RecommendationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// A filter to return details about the specified type of subtask.
        /// </para>
        ///  
        /// <para>
        ///  <c>BENCHMARK</c>: Evaluate the performance of your model on different instance types.
        /// </para>
        /// </summary>
        public RecommendationStepType StepType
        {
            get { return this._stepType; }
            set { this._stepType = value; }
        }

        // Check to see if StepType property is set
        internal bool IsSetStepType()
        {
            return this._stepType != null;
        }

    }
}