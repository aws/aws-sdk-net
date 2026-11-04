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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// An Amazon Redshift Advisor recommended action on the Amazon Redshift cluster.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster for which the recommendation is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time (UTC) that the recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier of the Advisor recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ImpactRanking. 
        /// <para>
        /// The scale of the impact that the Advisor recommendation has to the performance and
        /// cost of the cluster.
        /// </para>
        /// </summary>
        public ImpactRankingType ImpactRanking { get; set; }

        /// <summary>
        /// Checks to see if the ImpactRanking property is set.
        /// </summary>
        internal bool IsSetImpactRanking() => this.ImpactRanking != null;

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Redshift cluster namespace ARN for which the recommendations is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceArn property is set.
        /// </summary>
        internal bool IsSetNamespaceArn() => this.NamespaceArn != null;

        /// <summary>
        /// Gets and sets the property Observation. 
        /// <para>
        /// The description of what was observed about your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Observation { get; set; }

        /// <summary>
        /// Checks to see if the Observation property is set.
        /// </summary>
        internal bool IsSetObservation() => this.Observation != null;

        /// <summary>
        /// Gets and sets the property RecommendationText. 
        /// <para>
        /// The description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string RecommendationText { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationText property is set.
        /// </summary>
        internal bool IsSetRecommendationText() => this.RecommendationText != null;

        /// <summary>
        /// Gets and sets the property RecommendationType. 
        /// <para>
        /// The type of Advisor recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string RecommendationType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationType property is set.
        /// </summary>
        internal bool IsSetRecommendationType() => this.RecommendationType != null;

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// List of Amazon Redshift recommended actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedAction> RecommendedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendedAction>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActions property is set.
        /// </summary>
        internal bool IsSetRecommendedActions() => this.RecommendedActions != null && (this.RecommendedActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceLinks. 
        /// <para>
        /// List of helpful links for more information about the Advisor recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceLink> ReferenceLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceLink>() : null;

        /// <summary>
        /// Checks to see if the ReferenceLinks property is set.
        /// </summary>
        internal bool IsSetReferenceLinks() => this.ReferenceLinks != null && (this.ReferenceLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
