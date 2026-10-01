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
    /// Summary of a Recommendation for a specific AWS Resource
    /// </summary>
    public partial class RecommendationForResourceSummary
    {
        /// <summary>
        /// Gets and sets the property AwsResourceArn. 
        /// <para>
        /// The AWS Resource ARN
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
        /// The Check ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CheckArn { get; set; }

        /// <summary>
        /// Checks to see if the CheckArn property is set.
        /// </summary>
        internal bool IsSetCheckArn() => this.CheckArn != null;

        /// <summary>
        /// Gets and sets the property ExclusionStatus. 
        /// <para>
        /// The exclusion status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExclusionStatus ExclusionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExclusionStatus property is set.
        /// </summary>
        internal bool IsSetExclusionStatus() => this.ExclusionStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the recommendation was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata associated with the recommendation
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The Pillars that the Recommendation is optimizing
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> Pillars { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Pillars property is set.
        /// </summary>
        internal bool IsSetPillars() => this.Pillars != null && (this.Pillars.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Recommendation ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
