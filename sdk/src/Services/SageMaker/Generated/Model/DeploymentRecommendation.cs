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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A set of recommended deployment configurations for the model. To get more advanced
    /// recommendations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateInferenceRecommendationsJob.html">CreateInferenceRecommendationsJob</a>
    /// to create an inference recommendation job.
    /// </summary>
    public partial class DeploymentRecommendation
    {
        private List<RealTimeInferenceRecommendation> _realTimeInferenceRecommendations = new List<RealTimeInferenceRecommendation>();
        private RecommendationStatus _recommendationStatus;

        /// <summary>
        /// Gets and sets the property RealTimeInferenceRecommendations. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_RealTimeInferenceRecommendation.html">RealTimeInferenceRecommendation</a>
        /// items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<RealTimeInferenceRecommendation> RealTimeInferenceRecommendations
        {
            get { return this._realTimeInferenceRecommendations; }
            set { this._realTimeInferenceRecommendations = value; }
        }

        // Check to see if RealTimeInferenceRecommendations property is set
        internal bool IsSetRealTimeInferenceRecommendations()
        {
            return this._realTimeInferenceRecommendations != null && this._realTimeInferenceRecommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationStatus. 
        /// <para>
        /// Status of the deployment recommendation. The status <code>NOT_APPLICABLE</code> means
        /// that SageMaker is unable to provide a default recommendation for the model using the
        /// information provided. If the deployment status is <code>IN_PROGRESS</code>, retry
        /// your API call after a few seconds to get a <code>COMPLETED</code> deployment recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationStatus RecommendationStatus
        {
            get { return this._recommendationStatus; }
            set { this._recommendationStatus = value; }
        }

        // Check to see if RecommendationStatus property is set
        internal bool IsSetRecommendationStatus()
        {
            return this._recommendationStatus != null;
        }

    }
}