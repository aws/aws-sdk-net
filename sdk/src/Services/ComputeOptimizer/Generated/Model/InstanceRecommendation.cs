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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes an Amazon EC2 instance recommendation.
    /// </summary>
    public partial class InstanceRecommendation
    {
        private string _accountId;
        private string _currentInstanceType;
        private CurrentPerformanceRisk _currentPerformanceRisk;
        private EffectiveRecommendationPreferences _effectiveRecommendationPreferences;
        private Finding _finding;
        private List<string> _findingReasonCodes = new List<string>();
        private List<string> _inferredWorkloadTypes = new List<string>();
        private string _instanceArn;
        private string _instanceName;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookBackPeriodInDays;
        private List<InstanceRecommendationOption> _recommendationOptions = new List<InstanceRecommendationOption>();
        private List<RecommendationSource> _recommendationSources = new List<RecommendationSource>();
        private List<UtilizationMetric> _utilizationMetrics = new List<UtilizationMetric>();

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
        ///  <b> <code>Underprovisioned</code> </b>—An instance is considered under-provisioned
        /// when at least one specification of your instance, such as CPU, memory, or network,
        /// does not meet the performance requirements of your workload. Under-provisioned instances
        /// may lead to poor application performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Overprovisioned</code> </b>—An instance is considered over-provisioned
        /// when at least one specification of your instance, such as CPU, memory, or network,
        /// can be sized down while still meeting the performance requirements of your workload,
        /// and no specification is under-provisioned. Over-provisioned instances may lead to
        /// unnecessary infrastructure cost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Optimized</code> </b>—An instance is considered optimized when all specifications
        /// of your instance, such as CPU, memory, and network, meet the performance requirements
        /// of your workload and is not over provisioned. For optimized resources, Compute Optimizer
        /// might recommend a new generation instance type.
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
        ///  <b> <code>CPUOverprovisioned</code> </b> — The instance’s CPU configuration can be
        /// sized down while still meeting the performance requirements of your workload. This
        /// is identified by analyzing the <code>CPUUtilization</code> metric of the current instance
        /// during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CPUUnderprovisioned</code> </b> — The instance’s CPU configuration doesn't
        /// meet the performance requirements of your workload and there is an alternative instance
        /// type that provides better CPU performance. This is identified by analyzing the <code>CPUUtilization</code>
        /// metric of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryOverprovisioned</code> </b> — The instance’s memory configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the memory utilization metric of the current instance
        /// during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryUnderprovisioned</code> </b> — The instance’s memory configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better memory performance. This is identified by analyzing
        /// the memory utilization metric of the current instance during the look-back period.
        /// </para>
        ///  <note> 
        /// <para>
        /// Memory utilization is analyzed only for resources that have the unified CloudWatch
        /// agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// memory utilization with the Amazon CloudWatch Agent</a> in the <i>Compute Optimizer
        /// User Guide</i>. On Linux instances, Compute Optimizer analyses the <code>mem_used_percent</code>
        /// metric in the <code>CWAgent</code> namespace, or the legacy <code>MemoryUtilization</code>
        /// metric in the <code>System/Linux</code> namespace. On Windows instances, Compute Optimizer
        /// analyses the <code>Memory % Committed Bytes In Use</code> metric in the <code>CWAgent</code>
        /// namespace.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <code>EBSThroughputOverprovisioned</code> </b> — The instance’s EBS throughput
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload. This is identified by analyzing the <code>VolumeReadOps</code> and
        /// <code>VolumeWriteOps</code> metrics of EBS volumes attached to the current instance
        /// during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSThroughputUnderprovisioned</code> </b> — The instance’s EBS throughput
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better EBS throughput performance. This
        /// is identified by analyzing the <code>VolumeReadOps</code> and <code>VolumeWriteOps</code>
        /// metrics of EBS volumes attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSIOPSOverprovisioned</code> </b> — The instance’s EBS IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <code>VolumeReadBytes</code> and <code>VolumeWriteBytes</code>
        /// metric of EBS volumes attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EBSIOPSUnderprovisioned</code> </b> — The instance’s EBS IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better EBS IOPS performance. This is identified by analyzing
        /// the <code>VolumeReadBytes</code> and <code>VolumeWriteBytes</code> metric of EBS volumes
        /// attached to the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkBandwidthOverprovisioned</code> </b> — The instance’s network bandwidth
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload. This is identified by analyzing the <code>NetworkIn</code> and <code>NetworkOut</code>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkBandwidthUnderprovisioned</code> </b> — The instance’s network bandwidth
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better network bandwidth performance.
        /// This is identified by analyzing the <code>NetworkIn</code> and <code>NetworkOut</code>
        /// metrics of the current instance during the look-back period. This finding reason happens
        /// when the <code>NetworkIn</code> or <code>NetworkOut</code> performance of an instance
        /// is impacted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkPPSOverprovisioned</code> </b> — The instance’s network PPS (packets
        /// per second) configuration can be sized down while still meeting the performance requirements
        /// of your workload. This is identified by analyzing the <code>NetworkPacketsIn</code>
        /// and <code>NetworkPacketsIn</code> metrics of the current instance during the look-back
        /// period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkPPSUnderprovisioned</code> </b> — The instance’s network PPS (packets
        /// per second) configuration doesn't meet the performance requirements of your workload
        /// and there is an alternative instance type that provides better network PPS performance.
        /// This is identified by analyzing the <code>NetworkPacketsIn</code> and <code>NetworkPacketsIn</code>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskIOPSOverprovisioned</code> </b> — The instance’s disk IOPS configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <code>DiskReadOps</code> and <code>DiskWriteOps</code>
        /// metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskIOPSUnderprovisioned</code> </b> — The instance’s disk IOPS configuration
        /// doesn't meet the performance requirements of your workload and there is an alternative
        /// instance type that provides better disk IOPS performance. This is identified by analyzing
        /// the <code>DiskReadOps</code> and <code>DiskWriteOps</code> metrics of the current
        /// instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskThroughputOverprovisioned</code> </b> — The instance’s disk throughput
        /// configuration can be sized down while still meeting the performance requirements of
        /// your workload. This is identified by analyzing the <code>DiskReadBytes</code> and
        /// <code>DiskWriteBytes</code> metrics of the current instance during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskThroughputUnderprovisioned</code> </b> — The instance’s disk throughput
        /// configuration doesn't meet the performance requirements of your workload and there
        /// is an alternative instance type that provides better disk throughput performance.
        /// This is identified by analyzing the <code>DiskReadBytes</code> and <code>DiskWriteBytes</code>
        /// metrics of the current instance during the look-back period.
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
        /// </summary>
        public List<string> FindingReasonCodes
        {
            get { return this._findingReasonCodes; }
            set { this._findingReasonCodes = value; }
        }

        // Check to see if FindingReasonCodes property is set
        internal bool IsSetFindingReasonCodes()
        {
            return this._findingReasonCodes != null && this._findingReasonCodes.Count > 0; 
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
        ///  <code>AmazonEmr</code> - Infers that Amazon EMR might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApacheCassandra</code> - Infers that Apache Cassandra might be running on the
        /// instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApacheHadoop</code> - Infers that Apache Hadoop might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Memcached</code> - Infers that Memcached might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NGINX</code> - Infers that NGINX might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PostgreSql</code> - Infers that PostgreSQL might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Redis</code> - Infers that Redis might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Kafka</code> - Infers that Kafka might be running on the instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> InferredWorkloadTypes
        {
            get { return this._inferredWorkloadTypes; }
            set { this._inferredWorkloadTypes = value; }
        }

        // Check to see if InferredWorkloadTypes property is set
        internal bool IsSetInferredWorkloadTypes()
        {
            return this._inferredWorkloadTypes != null && this._inferredWorkloadTypes.Count > 0; 
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
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the instance recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime LastRefreshTimestamp
        {
            get { return this._lastRefreshTimestamp.GetValueOrDefault(); }
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
        public double LookBackPeriodInDays
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
        /// Gets and sets the property RecommendationOptions. 
        /// <para>
        /// An array of objects that describe the recommendation options for the instance.
        /// </para>
        /// </summary>
        public List<InstanceRecommendationOption> RecommendationOptions
        {
            get { return this._recommendationOptions; }
            set { this._recommendationOptions = value; }
        }

        // Check to see if RecommendationOptions property is set
        internal bool IsSetRecommendationOptions()
        {
            return this._recommendationOptions != null && this._recommendationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationSources. 
        /// <para>
        /// An array of objects that describe the source resource of the recommendation.
        /// </para>
        /// </summary>
        public List<RecommendationSource> RecommendationSources
        {
            get { return this._recommendationSources; }
            set { this._recommendationSources = value; }
        }

        // Check to see if RecommendationSources property is set
        internal bool IsSetRecommendationSources()
        {
            return this._recommendationSources != null && this._recommendationSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the instance.
        /// </para>
        /// </summary>
        public List<UtilizationMetric> UtilizationMetrics
        {
            get { return this._utilizationMetrics; }
            set { this._utilizationMetrics = value; }
        }

        // Check to see if UtilizationMetrics property is set
        internal bool IsSetUtilizationMetrics()
        {
            return this._utilizationMetrics != null && this._utilizationMetrics.Count > 0; 
        }

    }
}