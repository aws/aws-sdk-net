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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetRecommenderFilter operation.
    /// </summary>
    public partial class GetRecommenderFilterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the recommender filter was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the recommender filter failed, provides the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property RecommenderFilterExpression. 
        /// <para>
        /// The filter expression that defines which items to include or exclude from recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2500)]
        public string RecommenderFilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderFilterExpression property is set.
        /// </summary>
        internal bool IsSetRecommenderFilterExpression() => this.RecommenderFilterExpression != null;

        /// <summary>
        /// Gets and sets the property RecommenderFilterName. 
        /// <para>
        /// The name of the recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string RecommenderFilterName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderFilterName property is set.
        /// </summary>
        internal bool IsSetRecommenderFilterName() => this.RecommenderFilterName != null;

        /// <summary>
        /// Gets and sets the property RecommenderSchemaName. 
        /// <para>
        /// The name of the recommender schema associated with this recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecommenderSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderSchemaName property is set.
        /// </summary>
        internal bool IsSetRecommenderSchemaName() => this.RecommenderSchemaName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommenderFilterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
