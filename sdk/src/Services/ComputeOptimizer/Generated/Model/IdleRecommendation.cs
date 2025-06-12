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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes an Idle resource recommendation.
    /// </summary>
    public partial class IdleRecommendation
    {
        private string _accountId;
        private IdleFinding _finding;
        private string _findingDescription;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookBackPeriodInDays;
        private string _resourceArn;
        private string _resourceId;
        private IdleRecommendationResourceType _resourceType;
        private IdleSavingsOpportunity _savingsOpportunity;
        private IdleSavingsOpportunityAfterDiscounts _savingsOpportunityAfterDiscounts;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<IdleUtilizationMetric> _utilizationMetrics = AWSConfigs.InitializeCollections ? new List<IdleUtilizationMetric>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the idle resource.
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
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of an idle resource.
        /// </para>
        /// </summary>
        public IdleFinding Finding
        {
            get { return this._finding; }
            set { this._finding = value; }
        }

        // Check to see if Finding property is set
        internal bool IsSetFinding()
        {
            return this._finding != null;
        }

        /// <summary>
        /// Gets and sets the property FindingDescription. 
        /// <para>
        /// A summary of the findings for the resource.
        /// </para>
        /// </summary>
        public string FindingDescription
        {
            get { return this._findingDescription; }
            set { this._findingDescription = value; }
        }

        // Check to see if FindingDescription property is set
        internal bool IsSetFindingDescription()
        {
            return this._findingDescription != null;
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the idle resource recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp
        {
            get { return this._lastRefreshTimestamp; }
            set { this._lastRefreshTimestamp = value; }
        }

        // Check to see if LastRefreshTimestamp property is set
        internal bool IsSetLastRefreshTimestamp()
        {
            return this._lastRefreshTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// The number of days the idle resource utilization metrics were analyzed.
        /// </para>
        /// </summary>
        public double? LookBackPeriodInDays
        {
            get { return this._lookBackPeriodInDays; }
            set { this._lookBackPeriodInDays = value; }
        }

        // Check to see if LookBackPeriodInDays property is set
        internal bool IsSetLookBackPeriodInDays()
        {
            return this._lookBackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the current idle resource.
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
        /// The unique identifier for the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that is idle.
        /// </para>
        /// </summary>
        public IdleRecommendationResourceType ResourceType
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
        /// Gets and sets the property SavingsOpportunity. 
        /// <para>
        /// The savings opportunity for the idle resource.
        /// </para>
        /// </summary>
        public IdleSavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunityAfterDiscounts. 
        /// <para>
        /// The savings opportunity for the idle resource after any applying discounts.
        /// </para>
        /// </summary>
        public IdleSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts
        {
            get { return this._savingsOpportunityAfterDiscounts; }
            set { this._savingsOpportunityAfterDiscounts = value; }
        }

        // Check to see if SavingsOpportunityAfterDiscounts property is set
        internal bool IsSetSavingsOpportunityAfterDiscounts()
        {
            return this._savingsOpportunityAfterDiscounts != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags assigned to your idle resource recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the idle resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdleUtilizationMetric> UtilizationMetrics
        {
            get { return this._utilizationMetrics; }
            set { this._utilizationMetrics = value; }
        }

        // Check to see if UtilizationMetrics property is set
        internal bool IsSetUtilizationMetrics()
        {
            return this._utilizationMetrics != null && (this._utilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}