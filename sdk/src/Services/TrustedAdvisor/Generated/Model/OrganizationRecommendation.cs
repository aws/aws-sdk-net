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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
    /// A Recommendation for accounts within an Organization
    /// </summary>
    public partial class OrganizationRecommendation
    {
        private string _arn;
        private List<string> _awsServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _checkArn;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private RecommendationLifecycleStage _lifecycleStage;
        private string _name;
        private List<string> _pillars = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RecommendationPillarSpecificAggregates _pillarSpecificAggregates;
        private DateTime? _resolvedAt;
        private RecommendationResourcesAggregates _resourcesAggregates;
        private RecommendationSource _source;
        private RecommendationStatus _status;
        private RecommendationType _type;
        private string _updatedOnBehalfOf;
        private string _updatedOnBehalfOfJobTitle;
        private string _updateReason;
        private UpdateRecommendationLifecycleStageReasonCode _updateReasonCode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The AWS Services that the Recommendation applies to
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsServices
        {
            get { return this._awsServices; }
            set { this._awsServices = value; }
        }

        // Check to see if AwsServices property is set
        internal bool IsSetAwsServices()
        {
            return this._awsServices != null && (this._awsServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CheckArn. 
        /// <para>
        /// The AWS Trusted Advisor Check ARN that relates to the Recommendation
        /// </para>
        /// </summary>
        public string CheckArn
        {
            get { return this._checkArn; }
            set { this._checkArn = value; }
        }

        // Check to see if CheckArn property is set
        internal bool IsSetCheckArn()
        {
            return this._checkArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the Recommendation was created, if created by AWS Trusted Advisor Priority
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The creator, if created by AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for AWS Trusted Advisor recommendations
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID which identifies where the Recommendation was produced
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the Recommendation was last updated
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The lifecycle stage from AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public RecommendationLifecycleStage LifecycleStage
        {
            get { return this._lifecycleStage; }
            set { this._lifecycleStage = value; }
        }

        // Check to see if LifecycleStage property is set
        internal bool IsSetLifecycleStage()
        {
            return this._lifecycleStage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AWS Trusted Advisor Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The Pillars that the Recommendation is optimizing
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Pillars
        {
            get { return this._pillars; }
            set { this._pillars = value; }
        }

        // Check to see if Pillars property is set
        internal bool IsSetPillars()
        {
            return this._pillars != null && (this._pillars.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PillarSpecificAggregates. 
        /// <para>
        /// The pillar aggregations for cost savings
        /// </para>
        /// </summary>
        public RecommendationPillarSpecificAggregates PillarSpecificAggregates
        {
            get { return this._pillarSpecificAggregates; }
            set { this._pillarSpecificAggregates = value; }
        }

        // Check to see if PillarSpecificAggregates property is set
        internal bool IsSetPillarSpecificAggregates()
        {
            return this._pillarSpecificAggregates != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedAt. 
        /// <para>
        /// When the Recommendation was resolved
        /// </para>
        /// </summary>
        public DateTime? ResolvedAt
        {
            get { return this._resolvedAt; }
            set { this._resolvedAt = value; }
        }

        // Check to see if ResolvedAt property is set
        internal bool IsSetResolvedAt()
        {
            return this._resolvedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcesAggregates. 
        /// <para>
        /// An aggregation of all resources
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationResourcesAggregates ResourcesAggregates
        {
            get { return this._resourcesAggregates; }
            set { this._resourcesAggregates = value; }
        }

        // Check to see if ResourcesAggregates property is set
        internal bool IsSetResourcesAggregates()
        {
            return this._resourcesAggregates != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether the Recommendation was automated or generated by AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOf. 
        /// <para>
        /// The person on whose behalf a Technical Account Manager (TAM) updated the recommendation.
        /// This information is only available when a Technical Account Manager takes an action
        /// on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOf
        {
            get { return this._updatedOnBehalfOf; }
            set { this._updatedOnBehalfOf = value; }
        }

        // Check to see if UpdatedOnBehalfOf property is set
        internal bool IsSetUpdatedOnBehalfOf()
        {
            return this._updatedOnBehalfOf != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOfJobTitle. 
        /// <para>
        /// The job title of the person on whose behalf a Technical Account Manager (TAM) updated
        /// the recommendation. This information is only available when a Technical Account Manager
        /// takes an action on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOfJobTitle
        {
            get { return this._updatedOnBehalfOfJobTitle; }
            set { this._updatedOnBehalfOfJobTitle = value; }
        }

        // Check to see if UpdatedOnBehalfOfJobTitle property is set
        internal bool IsSetUpdatedOnBehalfOfJobTitle()
        {
            return this._updatedOnBehalfOfJobTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// Reason for the lifecycle stage change
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=10, Max=4096)]
        public string UpdateReason
        {
            get { return this._updateReason; }
            set { this._updateReason = value; }
        }

        // Check to see if UpdateReason property is set
        internal bool IsSetUpdateReason()
        {
            return this._updateReason != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReasonCode. 
        /// <para>
        /// Reason code for the lifecycle state change
        /// </para>
        /// </summary>
        public UpdateRecommendationLifecycleStageReasonCode UpdateReasonCode
        {
            get { return this._updateReasonCode; }
            set { this._updateReasonCode = value; }
        }

        // Check to see if UpdateReasonCode property is set
        internal bool IsSetUpdateReasonCode()
        {
            return this._updateReasonCode != null;
        }

    }
}