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
    /// Describes an Auto Scaling group recommendation.
    /// </summary>
    public partial class AutoScalingGroupRecommendation
    {
        private string _accountId;
        private string _autoScalingGroupArn;
        private string _autoScalingGroupName;
        private AutoScalingGroupConfiguration _currentConfiguration;
        private GpuInfo _currentInstanceGpuInfo;
        private CurrentPerformanceRisk _currentPerformanceRisk;
        private EffectiveRecommendationPreferences _effectiveRecommendationPreferences;
        private Finding _finding;
        private List<string> _inferredWorkloadTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookBackPeriodInDays;
        private List<AutoScalingGroupRecommendationOption> _recommendationOptions = AWSConfigs.InitializeCollections ? new List<AutoScalingGroupRecommendationOption>() : null;
        private List<UtilizationMetric> _utilizationMetrics = AWSConfigs.InitializeCollections ? new List<UtilizationMetric>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Auto Scaling group.
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
        /// Gets and sets the property AutoScalingGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Auto Scaling group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupArn
        {
            get { return this._autoScalingGroupArn; }
            set { this._autoScalingGroupArn = value; }
        }

        // Check to see if AutoScalingGroupArn property is set
        internal bool IsSetAutoScalingGroupArn()
        {
            return this._autoScalingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// An array of objects that describe the current configuration of the Auto Scaling group.
        /// </para>
        /// </summary>
        public AutoScalingGroupConfiguration CurrentConfiguration
        {
            get { return this._currentConfiguration; }
            set { this._currentConfiguration = value; }
        }

        // Check to see if CurrentConfiguration property is set
        internal bool IsSetCurrentConfiguration()
        {
            return this._currentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentInstanceGpuInfo. 
        /// <para>
        ///  Describes the GPU accelerator settings for the current instance type of the Auto
        /// Scaling group. 
        /// </para>
        /// </summary>
        public GpuInfo CurrentInstanceGpuInfo
        {
            get { return this._currentInstanceGpuInfo; }
            set { this._currentInstanceGpuInfo = value; }
        }

        // Check to see if CurrentInstanceGpuInfo property is set
        internal bool IsSetCurrentInstanceGpuInfo()
        {
            return this._currentInstanceGpuInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        /// The risk of the current Auto Scaling group not meeting the performance needs of its
        /// workloads. The higher the risk, the more likely the current Auto Scaling group configuration
        /// has insufficient capacity and cannot meet workload requirements.
        /// </para>
        /// </summary>
        public CurrentPerformanceRisk CurrentPerformanceRisk
        {
            get { return this._currentPerformanceRisk; }
            set { this._currentPerformanceRisk = value; }
        }

        // Check to see if CurrentPerformanceRisk property is set
        internal bool IsSetCurrentPerformanceRisk()
        {
            return this._currentPerformanceRisk != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveRecommendationPreferences. 
        /// <para>
        /// An object that describes the effective recommendation preferences for the Auto Scaling
        /// group.
        /// </para>
        /// </summary>
        public EffectiveRecommendationPreferences EffectiveRecommendationPreferences
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
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// Findings for Auto Scaling groups include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>NotOptimized</c> </b>—An Auto Scaling group is considered not optimized when
        /// Compute Optimizer identifies a recommendation that can provide better performance
        /// for your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Optimized</c> </b>—An Auto Scaling group is considered optimized when Compute
        /// Optimizer determines that the group is correctly provisioned to run your workload
        /// based on the chosen instance type. For optimized resources, Compute Optimizer might
        /// recommend a new generation instance type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Finding Finding
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
        /// Gets and sets the property InferredWorkloadTypes. 
        /// <para>
        /// The applications that might be running on the instances in the Auto Scaling group
        /// as inferred by Compute Optimizer.
        /// </para>
        ///  
        /// <para>
        /// Compute Optimizer can infer if one of the following applications might be running
        /// on the instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AmazonEmr</c> - Infers that Amazon EMR might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheCassandra</c> - Infers that Apache Cassandra might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheHadoop</c> - Infers that Apache Hadoop might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Memcached</c> - Infers that Memcached might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NGINX</c> - Infers that NGINX might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PostgreSql</c> - Infers that PostgreSQL might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Redis</c> - Infers that Redis might be running on the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Kafka</c> - Infers that Kafka might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQLServer</c> - Infers that SQLServer might be running on the instance.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InferredWorkloadTypes
        {
            get { return this._inferredWorkloadTypes; }
            set { this._inferredWorkloadTypes = value; }
        }

        // Check to see if InferredWorkloadTypes property is set
        internal bool IsSetInferredWorkloadTypes()
        {
            return this._inferredWorkloadTypes != null && (this._inferredWorkloadTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the Auto Scaling group recommendation was last generated.
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
        /// The number of days for which utilization metrics were analyzed for the Auto Scaling
        /// group.
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
        /// Gets and sets the property RecommendationOptions. 
        /// <para>
        /// An array of objects that describe the recommendation options for the Auto Scaling
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingGroupRecommendationOption> RecommendationOptions
        {
            get { return this._recommendationOptions; }
            set { this._recommendationOptions = value; }
        }

        // Check to see if RecommendationOptions property is set
        internal bool IsSetRecommendationOptions()
        {
            return this._recommendationOptions != null && (this._recommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtilizationMetric> UtilizationMetrics
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