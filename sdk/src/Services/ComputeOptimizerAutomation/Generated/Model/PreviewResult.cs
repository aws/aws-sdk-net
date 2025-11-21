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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains the results of previewing an automation rule against available recommendations.
    /// </summary>
    public partial class PreviewResult
    {
        private string _accountId;
        private ResourceDetails _currentResourceDetails;
        private string _currentResourceSummary;
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private int? _lookBackPeriodInDays;
        private string _recommendedActionId;
        private RecommendedActionType _recommendedActionType;
        private ResourceDetails _recommendedResourceDetails;
        private string _recommendedResourceSummary;
        private string _region;
        private string _resourceArn;
        private string _resourceId;
        private List<Tag> _resourceTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ResourceType _resourceType;
        private bool? _restartNeeded;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the resource.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentResourceDetails.
        /// </summary>
        public ResourceDetails CurrentResourceDetails
        {
            get { return this._currentResourceDetails; }
            set { this._currentResourceDetails = value; }
        }

        // Check to see if CurrentResourceDetails property is set
        internal bool IsSetCurrentResourceDetails()
        {
            return this._currentResourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentResourceSummary. 
        /// <para>
        /// A summary of the resource's current configuration.
        /// </para>
        /// </summary>
        public string CurrentResourceSummary
        {
            get { return this._currentResourceSummary; }
            set { this._currentResourceSummary = value; }
        }

        // Check to see if CurrentResourceSummary property is set
        internal bool IsSetCurrentResourceSummary()
        {
            return this._currentResourceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings.
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// The number of days of historical data used to analyze the resource.
        /// </para>
        /// </summary>
        public int LookBackPeriodInDays
        {
            get { return this._lookBackPeriodInDays.GetValueOrDefault(); }
            set { this._lookBackPeriodInDays = value; }
        }

        // Check to see if LookBackPeriodInDays property is set
        internal bool IsSetLookBackPeriodInDays()
        {
            return this._lookBackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionId. 
        /// <para>
        /// The ID of the recommended action being previewed.
        /// </para>
        /// </summary>
        public string RecommendedActionId
        {
            get { return this._recommendedActionId; }
            set { this._recommendedActionId = value; }
        }

        // Check to see if RecommendedActionId property is set
        internal bool IsSetRecommendedActionId()
        {
            return this._recommendedActionId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionType. 
        /// <para>
        /// The type of recommended action being previewed.
        /// </para>
        /// </summary>
        public RecommendedActionType RecommendedActionType
        {
            get { return this._recommendedActionType; }
            set { this._recommendedActionType = value; }
        }

        // Check to see if RecommendedActionType property is set
        internal bool IsSetRecommendedActionType()
        {
            return this._recommendedActionType != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedResourceDetails.
        /// </summary>
        public ResourceDetails RecommendedResourceDetails
        {
            get { return this._recommendedResourceDetails; }
            set { this._recommendedResourceDetails = value; }
        }

        // Check to see if RecommendedResourceDetails property is set
        internal bool IsSetRecommendedResourceDetails()
        {
            return this._recommendedResourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedResourceSummary. 
        /// <para>
        /// A summary of the resource's recommended configuration.
        /// </para>
        /// </summary>
        public string RecommendedResourceSummary
        {
            get { return this._recommendedResourceSummary; }
            set { this._recommendedResourceSummary = value; }
        }

        // Check to see if RecommendedResourceSummary property is set
        internal bool IsSetRecommendedResourceSummary()
        {
            return this._recommendedResourceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the resource is located.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource affected by the recommended action.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource affected by the recommended action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource being evaluated.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Indicates whether implementing the recommended action requires a resource restart.
        /// </para>
        /// </summary>
        public bool RestartNeeded
        {
            get { return this._restartNeeded.GetValueOrDefault(); }
            set { this._restartNeeded = value; }
        }

        // Check to see if RestartNeeded property is set
        internal bool IsSetRestartNeeded()
        {
            return this._restartNeeded.HasValue; 
        }

    }
}