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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the ListReviewTemplateAnswers operation.
    /// </summary>
    public partial class ListReviewTemplateAnswersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnswerSummaries. 
        /// <para>
        /// List of answer summaries of a lens review in a review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReviewTemplateAnswerSummary> AnswerSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ReviewTemplateAnswerSummary>() : null;

        /// <summary>
        /// Checks to see if the AnswerSummaries property is set.
        /// </summary>
        internal bool IsSetAnswerSummaries() => this.AnswerSummaries != null && (this.AnswerSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The ARN of the review template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 250)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;
    }
}
