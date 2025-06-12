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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Creates a new grouping recommendation.
    /// </summary>
    public partial class GroupingRecommendation
    {
        private GroupingRecommendationConfidenceLevel _confidenceLevel;
        private DateTime? _creationTime;
        private GroupingAppComponent _groupingAppComponent;
        private string _groupingRecommendationId;
        private List<string> _recommendationReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GroupingRecommendationRejectionReason _rejectionReason;
        private List<GroupingResource> _resources = AWSConfigs.InitializeCollections ? new List<GroupingResource>() : null;
        private double? _score;
        private GroupingRecommendationStatusType _status;

        /// <summary>
        /// Gets and sets the property ConfidenceLevel. 
        /// <para>
        /// Indicates the confidence level of Resilience Hub on the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupingRecommendationConfidenceLevel ConfidenceLevel
        {
            get { return this._confidenceLevel; }
            set { this._confidenceLevel = value; }
        }

        // Check to see if ConfidenceLevel property is set
        internal bool IsSetConfidenceLevel()
        {
            return this._confidenceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Indicates the creation time of the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupingAppComponent. 
        /// <para>
        /// Indicates the name of the recommended Application Component (AppComponent).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupingAppComponent GroupingAppComponent
        {
            get { return this._groupingAppComponent; }
            set { this._groupingAppComponent = value; }
        }

        // Check to see if GroupingAppComponent property is set
        internal bool IsSetGroupingAppComponent()
        {
            return this._groupingAppComponent != null;
        }

        /// <summary>
        /// Gets and sets the property GroupingRecommendationId. 
        /// <para>
        /// Indicates all the reasons available for rejecting a grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GroupingRecommendationId
        {
            get { return this._groupingRecommendationId; }
            set { this._groupingRecommendationId = value; }
        }

        // Check to see if GroupingRecommendationId property is set
        internal bool IsSetGroupingRecommendationId()
        {
            return this._groupingRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationReasons. 
        /// <para>
        /// Indicates all the reasons available for rejecting a grouping recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RecommendationReasons
        {
            get { return this._recommendationReasons; }
            set { this._recommendationReasons = value; }
        }

        // Check to see if RecommendationReasons property is set
        internal bool IsSetRecommendationReasons()
        {
            return this._recommendationReasons != null && (this._recommendationReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// Indicates the reason you had selected while rejecting a grouping recommendation.
        /// </para>
        /// </summary>
        public GroupingRecommendationRejectionReason RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Indicates the resources that are grouped in a recommended AppComponent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GroupingResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Indicates the confidence level of the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of grouping resources into AppComponents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupingRecommendationStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}