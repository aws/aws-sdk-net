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
    /// Describes an Amazon Aurora and RDS database recommendation.
    /// </summary>
    public partial class RDSDBRecommendation
    {
        private string _accountId;
        private string _currentdbInstanceClass;
        private RDSCurrentInstancePerformanceRisk _currentInstancePerformanceRisk;
        private DBStorageConfiguration _currentStorageConfiguration;
        private RDSEstimatedMonthlyVolumeIOPsCostVariation _currentStorageEstimatedMonthlyVolumeIOPsCostVariation;
        private string _dbClusterIdentifier;
        private RDSEffectiveRecommendationPreferences _effectiveRecommendationPreferences;
        private string _engine;
        private string _engineVersion;
        private Idle _idle;
        private RDSInstanceFinding _instanceFinding;
        private List<string> _instanceFindingReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RDSDBInstanceRecommendationOption> _instanceRecommendationOptions = AWSConfigs.InitializeCollections ? new List<RDSDBInstanceRecommendationOption>() : null;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookbackPeriodInDays;
        private int? _promotionTier;
        private string _resourceArn;
        private RDSStorageFinding _storageFinding;
        private List<string> _storageFindingReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RDSDBStorageRecommendationOption> _storageRecommendationOptions = AWSConfigs.InitializeCollections ? new List<RDSDBStorageRecommendationOption>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<RDSDBUtilizationMetric> _utilizationMetrics = AWSConfigs.InitializeCollections ? new List<RDSDBUtilizationMetric>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the Amazon Aurora or RDS database. 
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
        /// Gets and sets the property CurrentDBInstanceClass. 
        /// <para>
        ///  The DB instance class of the current Aurora or RDS DB instance. 
        /// </para>
        /// </summary>
        public string CurrentDBInstanceClass
        {
            get { return this._currentdbInstanceClass; }
            set { this._currentdbInstanceClass = value; }
        }

        // Check to see if CurrentDBInstanceClass property is set
        internal bool IsSetCurrentDBInstanceClass()
        {
            return this._currentdbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentInstancePerformanceRisk. 
        /// <para>
        /// The performance risk for the current DB instance.
        /// </para>
        /// </summary>
        public RDSCurrentInstancePerformanceRisk CurrentInstancePerformanceRisk
        {
            get { return this._currentInstancePerformanceRisk; }
            set { this._currentInstancePerformanceRisk = value; }
        }

        // Check to see if CurrentInstancePerformanceRisk property is set
        internal bool IsSetCurrentInstancePerformanceRisk()
        {
            return this._currentInstancePerformanceRisk != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentStorageConfiguration. 
        /// <para>
        ///  The configuration of the current DB storage. 
        /// </para>
        /// </summary>
        public DBStorageConfiguration CurrentStorageConfiguration
        {
            get { return this._currentStorageConfiguration; }
            set { this._currentStorageConfiguration = value; }
        }

        // Check to see if CurrentStorageConfiguration property is set
        internal bool IsSetCurrentStorageConfiguration()
        {
            return this._currentStorageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation.
        /// 
        /// <para>
        ///  The level of variation in monthly I/O costs for the current DB storage configuration.
        /// 
        /// </para>
        /// </summary>
        public RDSEstimatedMonthlyVolumeIOPsCostVariation CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation
        {
            get { return this._currentStorageEstimatedMonthlyVolumeIOPsCostVariation; }
            set { this._currentStorageEstimatedMonthlyVolumeIOPsCostVariation = value; }
        }

        // Check to see if CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation property is set
        internal bool IsSetCurrentStorageEstimatedMonthlyVolumeIOPsCostVariation()
        {
            return this._currentStorageEstimatedMonthlyVolumeIOPsCostVariation != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The identifier for DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DbClusterIdentifier property is set
        internal bool IsSetDbClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveRecommendationPreferences. 
        /// <para>
        ///  Describes the effective recommendation preferences for DB instances. 
        /// </para>
        /// </summary>
        public RDSEffectiveRecommendationPreferences EffectiveRecommendationPreferences
        {
            get { return this._effectiveRecommendationPreferences; }
            set { this._effectiveRecommendationPreferences = value; }
        }

        // Check to see if EffectiveRecommendationPreferences property is set
        internal bool IsSetEffectiveRecommendationPreferences()
        {
            return this._effectiveRecommendationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The engine of the DB instance. 
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The database engine version. 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        ///  This indicates if the DB instance is idle or not. 
        /// </para>
        /// </summary>
        public Idle Idle
        {
            get { return this._idle; }
            set { this._idle = value; }
        }

        // Check to see if Idle property is set
        internal bool IsSetIdle()
        {
            return this._idle != null;
        }

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
        public RDSInstanceFinding InstanceFinding
        {
            get { return this._instanceFinding; }
            set { this._instanceFinding = value; }
        }

        // Check to see if InstanceFinding property is set
        internal bool IsSetInstanceFinding()
        {
            return this._instanceFinding != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification of a DB instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceFindingReasonCodes
        {
            get { return this._instanceFindingReasonCodes; }
            set { this._instanceFindingReasonCodes = value; }
        }

        // Check to see if InstanceFindingReasonCodes property is set
        internal bool IsSetInstanceFindingReasonCodes()
        {
            return this._instanceFindingReasonCodes != null && (this._instanceFindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for the RDS DB instance.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBInstanceRecommendationOption> InstanceRecommendationOptions
        {
            get { return this._instanceRecommendationOptions; }
            set { this._instanceRecommendationOptions = value; }
        }

        // Check to see if InstanceRecommendationOptions property is set
        internal bool IsSetInstanceRecommendationOptions()
        {
            return this._instanceRecommendationOptions != null && (this._instanceRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the DB instance recommendation was last generated. 
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
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days the DB instance utilization metrics were analyzed. 
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The promotion tier for the Aurora instance.
        /// </para>
        /// </summary>
        public int? PromotionTier
        {
            get { return this._promotionTier; }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

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
        public RDSStorageFinding StorageFinding
        {
            get { return this._storageFinding; }
            set { this._storageFinding = value; }
        }

        // Check to see if StorageFinding property is set
        internal bool IsSetStorageFinding()
        {
            return this._storageFinding != null;
        }

        /// <summary>
        /// Gets and sets the property StorageFindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification of RDS DB instance storage. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StorageFindingReasonCodes
        {
            get { return this._storageFindingReasonCodes; }
            set { this._storageFindingReasonCodes = value; }
        }

        // Check to see if StorageFindingReasonCodes property is set
        internal bool IsSetStorageFindingReasonCodes()
        {
            return this._storageFindingReasonCodes != null && (this._storageFindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for DB instance storage.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBStorageRecommendationOption> StorageRecommendationOptions
        {
            get { return this._storageRecommendationOptions; }
            set { this._storageRecommendationOptions = value; }
        }

        // Check to see if StorageRecommendationOptions property is set
        internal bool IsSetStorageRecommendationOptions()
        {
            return this._storageRecommendationOptions != null && (this._storageRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your DB instance recommendations. 
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
        ///  An array of objects that describe the utilization metrics of the DB instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBUtilizationMetric> UtilizationMetrics
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