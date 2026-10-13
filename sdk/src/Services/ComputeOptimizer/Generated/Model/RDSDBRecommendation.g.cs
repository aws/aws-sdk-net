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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes an Amazon Aurora and RDS database recommendation.
    /// </summary>
    public partial class RDSDBRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the Amazon Aurora or RDS database. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentDBInstanceClass. 
        /// <para>
        ///  The DB instance class of the current Aurora or RDS DB instance. 
        /// </para>
        /// </summary>
        public string CurrentDBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the CurrentDBInstanceClass property is set.
        /// </summary>
        internal bool IsSetCurrentDBInstanceClass() => this.CurrentDBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property CurrentInstancePerformanceRisk. 
        /// <para>
        /// The performance risk for the current DB instance.
        /// </para>
        /// </summary>
        public RDSCurrentInstancePerformanceRisk CurrentInstancePerformanceRisk { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInstancePerformanceRisk property is set.
        /// </summary>
        internal bool IsSetCurrentInstancePerformanceRisk() => this.CurrentInstancePerformanceRisk != null;

        /// <summary>
        /// Gets and sets the property CurrentStorageConfiguration. 
        /// <para>
        ///  The configuration of the current DB storage. 
        /// </para>
        /// </summary>
        public DBStorageConfiguration CurrentStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentStorageConfiguration() => this.CurrentStorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation.
        /// 
        /// <para>
        ///  The level of variation in monthly I/O costs for the current DB storage configuration.
        /// 
        /// </para>
        /// </summary>
        public RDSEstimatedMonthlyVolumeIOPsCostVariation CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation { get; set; }

        /// <summary>
        /// Checks to see if the CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation property is set.
        /// </summary>
        internal bool IsSetCurrentStorageEstimatedMonthlyVolumeIOPsCostVariation() => this.CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation != null;

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The identifier for DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDbClusterIdentifier() => this.DbClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property EffectiveRecommendationPreferences. 
        /// <para>
        ///  Describes the effective recommendation preferences for DB instances. 
        /// </para>
        /// </summary>
        public RDSEffectiveRecommendationPreferences EffectiveRecommendationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveRecommendationPreferences property is set.
        /// </summary>
        internal bool IsSetEffectiveRecommendationPreferences() => this.EffectiveRecommendationPreferences != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The engine of the DB instance. 
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The database engine version. 
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        ///  This indicates if the DB instance is idle or not. 
        /// </para>
        /// </summary>
        public Idle Idle { get; set; }

        /// <summary>
        /// Checks to see if the Idle property is set.
        /// </summary>
        internal bool IsSetIdle() => this.Idle != null;

        /// <summary>
        /// Gets and sets the property InstanceFinding. 
        /// <para>
        ///  The finding classification of an Amazon Aurora and RDS DB instance. 
        /// </para>
        ///  
        /// <para>
        /// For more information about finding classifications, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/view-rds-recommendations.html#rds-recommendations-findings">
        /// Finding classifications for Aurora and RDS databases</a> in the <i>Compute Optimizer
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public RDSInstanceFinding InstanceFinding { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFinding property is set.
        /// </summary>
        internal bool IsSetInstanceFinding() => this.InstanceFinding != null;

        /// <summary>
        /// Gets and sets the property InstanceFindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification of a DB instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceFindingReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceFindingReasonCodes property is set.
        /// </summary>
        internal bool IsSetInstanceFindingReasonCodes() => this.InstanceFindingReasonCodes != null && (this.InstanceFindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for the RDS DB instance.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBInstanceRecommendationOption> InstanceRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<RDSDBInstanceRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the InstanceRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetInstanceRecommendationOptions() => this.InstanceRecommendationOptions != null && (this.InstanceRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the DB instance recommendation was last generated. 
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days the DB instance utilization metrics were analyzed. 
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The promotion tier for the Aurora instance.
        /// </para>
        /// </summary>
        public int? PromotionTier { get; set; }

        /// <summary>
        /// Checks to see if the PromotionTier property is set.
        /// </summary>
        internal bool IsSetPromotionTier() => this.PromotionTier.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The ARN of the current Amazon Aurora or RDS database. 
        /// </para>
        ///  
        /// <para>
        ///  The following is the format of the ARN: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:rds:{region}:{accountId}:db:{resourceName}</c> 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property StorageFinding. 
        /// <para>
        ///  The finding classification of Amazon RDS DB instance storage. 
        /// </para>
        ///  
        /// <para>
        /// For more information about finding classifications, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/view-rds-recommendations.html#rds-recommendations-findings">
        /// Finding classifications for Aurora and RDS databases</a> in the <i>Compute Optimizer
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public RDSStorageFinding StorageFinding { get; set; }

        /// <summary>
        /// Checks to see if the StorageFinding property is set.
        /// </summary>
        internal bool IsSetStorageFinding() => this.StorageFinding != null;

        /// <summary>
        /// Gets and sets the property StorageFindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification of RDS DB instance storage. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StorageFindingReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StorageFindingReasonCodes property is set.
        /// </summary>
        internal bool IsSetStorageFindingReasonCodes() => this.StorageFindingReasonCodes != null && (this.StorageFindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for DB instance storage.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBStorageRecommendationOption> StorageRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<RDSDBStorageRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the StorageRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetStorageRecommendationOptions() => this.StorageRecommendationOptions != null && (this.StorageRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your DB instance recommendations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the utilization metrics of the DB instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBUtilizationMetric> UtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<RDSDBUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the UtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetUtilizationMetrics() => this.UtilizationMetrics != null && (this.UtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
