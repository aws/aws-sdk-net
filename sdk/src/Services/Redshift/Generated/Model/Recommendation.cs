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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private string _clusterIdentifier;
        private DateTime? _createdAt;
        private string _description;
        private string _id;
        private ImpactRankingType _impactRanking;
        private string _namespaceArn;
        private string _observation;
        private string _recommendationText;
        private string _recommendationType;
        private List<RecommendedAction> _recommendedActions = AWSConfigs.InitializeCollections ? new List<RecommendedAction>() : null;
        private List<ReferenceLink> _referenceLinks = AWSConfigs.InitializeCollections ? new List<ReferenceLink>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster for which the recommendation is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time (UTC) that the recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier of the Advisor recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ImpactRanking. 
        /// <para>
        /// The scale of the impact that the Advisor recommendation has to the performance and
        /// cost of the cluster.
        /// </para>
        /// </summary>
        public ImpactRankingType ImpactRanking
        {
            get { return this._impactRanking; }
            set { this._impactRanking = value; }
        }

        // Check to see if ImpactRanking property is set
        internal bool IsSetImpactRanking()
        {
            return this._impactRanking != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Redshift cluster namespace ARN for which the recommendations is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Observation. 
        /// <para>
        /// The description of what was observed about your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Observation
        {
            get { return this._observation; }
            set { this._observation = value; }
        }

        // Check to see if Observation property is set
        internal bool IsSetObservation()
        {
            return this._observation != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationText. 
        /// <para>
        /// The description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string RecommendationText
        {
            get { return this._recommendationText; }
            set { this._recommendationText = value; }
        }

        // Check to see if RecommendationText property is set
        internal bool IsSetRecommendationText()
        {
            return this._recommendationText != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationType. 
        /// <para>
        /// The type of Advisor recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string RecommendationType
        {
            get { return this._recommendationType; }
            set { this._recommendationType = value; }
        }

        // Check to see if RecommendationType property is set
        internal bool IsSetRecommendationType()
        {
            return this._recommendationType != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// List of Amazon Redshift recommended actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedAction> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }

        // Check to see if RecommendedActions property is set
        internal bool IsSetRecommendedActions()
        {
            return this._recommendedActions != null && (this._recommendedActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReferenceLinks. 
        /// <para>
        /// List of helpful links for more information about the Advisor recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceLink> ReferenceLinks
        {
            get { return this._referenceLinks; }
            set { this._referenceLinks = value; }
        }

        // Check to see if ReferenceLinks property is set
        internal bool IsSetReferenceLinks()
        {
            return this._referenceLinks != null && (this._referenceLinks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}