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
    /// Describes an Amazon EC2 instance recommendation.
    /// </summary>
    public partial class InstanceRecommendation
    {
        private string _accountId;
        private GpuInfo _currentInstanceGpuInfo;
        private string _currentInstanceType;
        private CurrentPerformanceRisk _currentPerformanceRisk;
        private EffectiveRecommendationPreferences _effectiveRecommendationPreferences;
        private ExternalMetricStatus _externalMetricStatus;
        private Finding _finding;
        private List<string> _findingReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InstanceIdle _idle;
        private List<string> _inferredWorkloadTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceArn;
        private string _instanceName;
        private InstanceState _instanceState;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookBackPeriodInDays;
        private List<InstanceRecommendationOption> _recommendationOptions = AWSConfigs.InitializeCollections ? new List<InstanceRecommendationOption>() : null;
        private List<RecommendationSource> _recommendationSources = AWSConfigs.InitializeCollections ? new List<RecommendationSource>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<UtilizationMetric> _utilizationMetrics = AWSConfigs.InitializeCollections ? new List<UtilizationMetric>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the instance.
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
        /// Gets and sets the property CurrentInstanceGpuInfo. 
        /// <para>
        ///  Describes the GPU accelerator settings for the current instance type. 
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
        /// Gets and sets the property CurrentInstanceType. 
        /// <para>
        /// The instance type of the current instance.
        /// </para>
        /// </summary>
        public string CurrentInstanceType
        {
            get { return this._currentInstanceType; }
            set { this._currentInstanceType = value; }
        }

        // Check to see if CurrentInstanceType property is set
        internal bool IsSetCurrentInstanceType()
        {
            return this._currentInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        /// The risk of the current instance not meeting the performance needs of its workloads.
        /// The higher the risk, the more likely the current instance cannot meet the performance
        /// requirements of its workload.
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
        /// An object that describes the effective recommendation preferences for the instance.
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
        /// Gets and sets the property ExternalMetricStatus. 
        /// <para>
        ///  An object that describes Compute Optimizer's integration status with your external
        /// metrics provider. 
        /// </para>
        /// </summary>
        public ExternalMetricStatus ExternalMetricStatus
        {
            get { return this._externalMetricStatus; }
            set { this._externalMetricStatus = value; }
        }

        // Check to see if ExternalMetricStatus property is set
        internal bool IsSetExternalMetricStatus()
        {
            return this._externalMetricStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of the instance.
        /// </para>
        ///  
        /// <para>
        /// Findings for instances include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Underprovisioned</c> </b>—An instance is considered under-provisioned when
        /// at least one specification of your instance, such as CPU, memory, or network, does
        /// not meet the performance requirements of your workload. Under-provisioned instances
        /// may lead to poor application performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Overprovisioned</c> </b>—An instance is considered over-provisioned when at
        /// least one specification of your instance, such as CPU, memory, or network, can be
        /// sized down while still meeting the performance requirements of your workload, and
        /// no specification is under-provisioned. Over-provisioned instances may lead to unnecessary
        /// infrastructure cost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Optimized</c> </b>—An instance is considered optimized when all specifications
        /// of your instance, such as CPU, memory, and network, meet the performance requirements
        /// of your workload and is not over provisioned. For optimized resources, Compute Optimizer
        /// might recommend a new generation instance type.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The valid values in your API responses appear as OVER_PROVISIONED, UNDER_PROVISIONED,
        /// or OPTIMIZED.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property FindingReasonCodes. 
        /// <para>
        /// The reason for the finding classification of the instance.
        /// </para>
        ///  
        /// <para>
        /// Finding reason codes for instances include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>CPUOverprovisioned</c> </b> — The instance’s CPU configuration can be sized
        /// down while still meeting the performance requirements of your workload. This is identified
        /// by analyzing the <c>CPUUtilization</c> metric of the current instance during the look-back
        /// period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CPUUnderprovisioned</c> </b> — The instance’s CPU configuration doesn't meet
        /// the performance requirements of your workload and there is an alternative instance
        /// type that provides better CPU performance. This is identified by analyzing the <c>CPUUtilization</c>
        /// metric of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryOverprovisioned</c> </b> — The instance’s memory configuration can be
        /// sized down while still meeting the performance requirements of your workload. This
        /// is identified by analyzing the memory utilization metric of the current instance during
        /// the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryUnderprovisioned</c> </b> — The instance’s memory configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better memory performance. This is identified by analyzing the
        /// memory utilization metric of the current instance during the look-back period.
        /// </para>
        ///  <note> 
        /// <para>
        /// Memory utilization is analyzed only for resources that have the unified CloudWatch
        /// agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// memory utilization with the Amazon CloudWatch Agent</a> in the <i>Compute Optimizer
        /// User Guide</i>. On Linux instances, Compute Optimizer analyses the <c>mem_used_percent</c>
        /// metric in the <c>CWAgent</c> namespace, or the legacy <c>MemoryUtilization</c> metric
        /// in the <c>System/Linux</c> namespace. On Windows instances, Compute Optimizer analyses
        /// the <c>Memory % Committed Bytes In Use</c> metric in the <c>CWAgent</c> namespace.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>EBSThroughputOverprovisioned</c> </b> — The instance’s EBS throughput configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <c>VolumeReadBytes</c> and <c>VolumeWriteBytes</c>
        /// metrics of EBS volumes attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSThroughputUnderprovisioned</c> </b> — The instance’s EBS throughput configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better EBS throughput performance. This is identified
        /// by analyzing the <c>VolumeReadBytes</c> and <c>VolumeWriteBytes</c> metrics of EBS
        /// volumes attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSIOPSOverprovisioned</c> </b> — The instance’s EBS IOPS configuration can
        /// be sized down while still meeting the performance requirements of your workload. This
        /// is identified by analyzing the <c>VolumeReadOps</c> and <c>VolumeWriteOps</c> metric
        /// of EBS volumes attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EBSIOPSUnderprovisioned</c> </b> — The instance’s EBS IOPS configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better EBS IOPS performance. This is identified by analyzing the
        /// <c>VolumeReadOps</c> and <c>VolumeWriteOps</c> metric of EBS volumes attached to the
        /// current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkBandwidthOverprovisioned</c> </b> — The instance’s network bandwidth
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload. This is identified by analyzing the <c>NetworkIn</c> and <c>NetworkOut</c>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkBandwidthUnderprovisioned</c> </b> — The instance’s network bandwidth
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better network bandwidth performance.
        /// This is identified by analyzing the <c>NetworkIn</c> and <c>NetworkOut</c> metrics
        /// of the current instance during the look-back period. This finding reason happens when
        /// the <c>NetworkIn</c> or <c>NetworkOut</c> performance of an instance is impacted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkPPSOverprovisioned</c> </b> — The instance’s network PPS (packets per
        /// second) configuration can be sized down while still meeting the performance requirements
        /// of your workload. This is identified by analyzing the <c>NetworkPacketsIn</c> and
        /// <c>NetworkPacketsIn</c> metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkPPSUnderprovisioned</c> </b> — The instance’s network PPS (packets
        /// per second) configuration doesn't meet the performance requirements of your workload
        /// and there is an alternative instance type that provides better network PPS performance.
        /// This is identified by analyzing the <c>NetworkPacketsIn</c> and <c>NetworkPacketsIn</c>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskIOPSOverprovisioned</c> </b> — The instance’s disk IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <c>DiskReadOps</c> and <c>DiskWriteOps</c> metrics
        /// of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskIOPSUnderprovisioned</c> </b> — The instance’s disk IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk IOPS performance. This is identified by analyzing
        /// the <c>DiskReadOps</c> and <c>DiskWriteOps</c> metrics of the current instance during
        /// the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskThroughputOverprovisioned</c> </b> — The instance’s disk throughput configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <c>DiskReadBytes</c> and <c>DiskWriteBytes</c>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskThroughputUnderprovisioned</c> </b> — The instance’s disk throughput configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk throughput performance. This is identified
        /// by analyzing the <c>DiskReadBytes</c> and <c>DiskWriteBytes</c> metrics of the current
        /// instance during the look-back period.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// For more information about instance metrics, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/viewing_metrics_with_cloudwatch.html">List
        /// the available CloudWatch metrics for your instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>. For more information about EBS volume metrics, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cloudwatch_ebs.html">Amazon
        /// CloudWatch metrics for Amazon EBS</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FindingReasonCodes
        {
            get { return this._findingReasonCodes; }
            set { this._findingReasonCodes = value; }
        }

        // Check to see if FindingReasonCodes property is set
        internal bool IsSetFindingReasonCodes()
        {
            return this._findingReasonCodes != null && (this._findingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        ///  Describes if an Amazon EC2 instance is idle. 
        /// </para>
        /// </summary>
        public InstanceIdle Idle
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
        /// Gets and sets the property InferredWorkloadTypes. 
        /// <para>
        /// The applications that might be running on the instance as inferred by Compute Optimizer.
        /// </para>
        ///  
        /// <para>
        /// Compute Optimizer can infer if one of the following applications might be running
        /// on the instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AmazonEmr</c> - Infers that Amazon EMR might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheCassandra</c> - Infers that Apache Cassandra might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheHadoop</c> - Infers that Apache Hadoop might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Memcached</c> - Infers that Memcached might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NGINX</c> - Infers that NGINX might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PostgreSql</c> - Infers that PostgreSQL might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Redis</c> - Infers that Redis might be running on the instance.
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
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current instance.
        /// </para>
        /// </summary>
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the current instance.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        ///  The state of the instance when the recommendation was generated. 
        /// </para>
        /// </summary>
        public InstanceState InstanceState
        {
            get { return this._instanceState; }
            set { this._instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this._instanceState != null;
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the instance recommendation was last generated.
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
        /// The number of days for which utilization metrics were analyzed for the instance.
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
        /// An array of objects that describe the recommendation options for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceRecommendationOption> RecommendationOptions
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
        /// Gets and sets the property RecommendationSources. 
        /// <para>
        /// An array of objects that describe the source resource of the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationSource> RecommendationSources
        {
            get { return this._recommendationSources; }
            set { this._recommendationSources = value; }
        }

        // Check to see if RecommendationSources property is set
        internal bool IsSetRecommendationSources()
        {
            return this._recommendationSources != null && (this._recommendationSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your Amazon EC2 instance recommendations. 
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
        /// An array of objects that describe the utilization metrics of the instance.
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