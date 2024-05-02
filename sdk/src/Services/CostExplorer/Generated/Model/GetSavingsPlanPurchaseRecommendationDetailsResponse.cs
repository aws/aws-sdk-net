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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetSavingsPlanPurchaseRecommendationDetails operation.
    /// </summary>
    public partial class GetSavingsPlanPurchaseRecommendationDetailsResponse : AmazonWebServiceResponse
    {
        private RecommendationDetailData _recommendationDetailData;
        private string _recommendationDetailId;

        /// <summary>
        /// Gets and sets the property RecommendationDetailData. 
        /// <para>
        /// Contains detailed information about a specific Savings Plan recommendation.
        /// </para>
        /// </summary>
        public RecommendationDetailData RecommendationDetailData
        {
            get { return this._recommendationDetailData; }
            set { this._recommendationDetailData = value; }
        }

        // Check to see if RecommendationDetailData property is set
        internal bool IsSetRecommendationDetailData()
        {
            return this._recommendationDetailData != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationDetailId. 
        /// <para>
        /// The ID that is associated with the Savings Plan recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string RecommendationDetailId
        {
            get { return this._recommendationDetailId; }
            set { this._recommendationDetailId = value; }
        }

        // Check to see if RecommendationDetailId property is set
        internal bool IsSetRecommendationDetailId()
        {
            return this._recommendationDetailId != null;
        }

    }
}