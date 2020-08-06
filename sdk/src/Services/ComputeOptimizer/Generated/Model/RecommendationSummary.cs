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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// A summary of a recommendation.
    /// </summary>
    public partial class RecommendationSummary
    {
        private string _accountId;
        private RecommendationSourceType _recommendationResourceType;
        private List<Summary> _summaries = new List<Summary>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID of the recommendation summary.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationResourceType. 
        /// <para>
        /// The resource type of the recommendation.
        /// </para>
        /// </summary>
        public RecommendationSourceType RecommendationResourceType
        {
            get { return this._recommendationResourceType; }
            set { this._recommendationResourceType = value; }
        }

        // Check to see if RecommendationResourceType property is set
        internal bool IsSetRecommendationResourceType()
        {
            return this._recommendationResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Summaries. 
        /// <para>
        /// An array of objects that describe a recommendation summary.
        /// </para>
        /// </summary>
        public List<Summary> Summaries
        {
            get { return this._summaries; }
            set { this._summaries = value; }
        }

        // Check to see if Summaries property is set
        internal bool IsSetSummaries()
        {
            return this._summaries != null && this._summaries.Count > 0; 
        }

    }
}