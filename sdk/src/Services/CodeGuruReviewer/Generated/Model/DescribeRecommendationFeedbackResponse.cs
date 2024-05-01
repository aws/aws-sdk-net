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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
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
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// This is the response object from the DescribeRecommendationFeedback operation.
    /// </summary>
    public partial class DescribeRecommendationFeedbackResponse : AmazonWebServiceResponse
    {
        private RecommendationFeedback _recommendationFeedback;

        /// <summary>
        /// Gets and sets the property RecommendationFeedback. 
        /// <para>
        /// The recommendation feedback given by the user.
        /// </para>
        /// </summary>
        public RecommendationFeedback RecommendationFeedback
        {
            get { return this._recommendationFeedback; }
            set { this._recommendationFeedback = value; }
        }

        // Check to see if RecommendationFeedback property is set
        internal bool IsSetRecommendationFeedback()
        {
            return this._recommendationFeedback != null;
        }

    }
}