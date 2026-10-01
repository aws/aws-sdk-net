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
    /// Container for the parameters to the ListRecommendationResources operation. List Resources
    /// of a Recommendation. This API provides global recommendations, eliminating the need
    /// to call the API in each AWS Region.
    /// </summary>
    public partial class ListRecommendationResourcesRequest : AmazonTrustedAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property ExclusionStatus. 
        /// <para>
        /// The exclusion status of the resource
        /// </para>
        /// </summary>
        public ExclusionStatus ExclusionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExclusionStatus property is set.
        /// </summary>
        internal bool IsSetExclusionStatus() => this.ExclusionStatus != null;

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
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
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
        /// Gets and sets the property RecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 200)]
        public string RecommendationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationIdentifier property is set.
        /// </summary>
        internal bool IsSetRecommendationIdentifier() => this.RecommendationIdentifier != null;

        /// <summary>
        /// Gets and sets the property RegionCode. 
        /// <para>
        /// The AWS Region code of the resource
        /// </para>
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Checks to see if the RegionCode property is set.
        /// </summary>
        internal bool IsSetRegionCode() => this.RegionCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
