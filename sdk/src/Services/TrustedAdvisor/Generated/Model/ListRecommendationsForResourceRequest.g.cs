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

namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecommendationsForResource operation. List
    /// all Trusted Advisor recommendations for a given AWS resource ARN.
    /// </summary>
    public partial class ListRecommendationsForResourceRequest : AmazonTrustedAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property AwsResourceArn. 
        /// <para>
        /// The ARN of the AWS resource to query recommendations for
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string AwsResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsResourceArn property is set.
        /// </summary>
        internal bool IsSetAwsResourceArn() => this.AwsResourceArn != null;

        /// <summary>
        /// Gets and sets the property CheckArn. 
        /// <para>
        /// The AWS Trusted Advisor Check ARN that relates to the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CheckArn { get; set; }

        /// <summary>
        /// Checks to see if the CheckArn property is set.
        /// </summary>
        internal bool IsSetCheckArn() => this.CheckArn != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language that you want your recommendations to appear in.
        /// </para>
        /// </summary>
        public RecommendationLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 10000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The pillar that the recommendation belongs to
        /// </para>
        /// </summary>
        public RecommendationPillar Pillar { get; set; }

        /// <summary>
        /// Checks to see if the Pillar property is set.
        /// </summary>
        internal bool IsSetPillar() => this.Pillar != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Recommendation Resource
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
