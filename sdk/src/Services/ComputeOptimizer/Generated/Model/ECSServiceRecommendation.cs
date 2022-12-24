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
    /// Describes an Amazon ECS service recommendation.
    /// </summary>
    public partial class ECSServiceRecommendation
    {
        private string _accountId;
        private CurrentPerformanceRisk _currentPerformanceRisk;
        private ServiceConfiguration _currentServiceConfiguration;
        private ECSServiceRecommendationFinding _finding;
        private List<string> _findingReasonCodes = new List<string>();
        private DateTime? _lastRefreshTimestamp;
        private ECSServiceLaunchType _launchType;
        private double? _lookbackPeriodInDays;
        private string _serviceArn;
        private List<ECSServiceRecommendationOption> _serviceRecommendationOptions = new List<ECSServiceRecommendationOption>();
        private List<ECSServiceUtilizationMetric> _utilizationMetrics = new List<ECSServiceUtilizationMetric>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the ECS service. 
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
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        ///  The risk of the current ECS service not meeting the performance needs of its workloads.
        /// The higher the risk, the more likely the current service can't meet the performance
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
        /// Gets and sets the property CurrentServiceConfiguration. 
        /// <para>
        ///  The configuration of the current ECS service. 
        /// </para>
        /// </summary>
        public ServiceConfiguration CurrentServiceConfiguration
        {
            get { return this._currentServiceConfiguration; }
            set { this._currentServiceConfiguration = value; }
        }

        // Check to see if CurrentServiceConfiguration property is set
        internal bool IsSetCurrentServiceConfiguration()
        {
            return this._currentServiceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        ///  The finding classification of an ECS service. 
        /// </para>
        ///  
        /// <para>
        /// Findings for ECS services include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Underprovisioned</code> </b> — When Compute Optimizer detects that there’s
        /// not enough memory or CPU, an ECS service is considered under-provisioned. An under-provisioned
        /// ECS service might result in poor application performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Overprovisioned</code> </b> — When Compute Optimizer detects that there’s
        /// excessive memory or CPU, an ECS service is considered over-provisioned. An over-provisioned
        /// ECS service might result in additional infrastructure costs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Optimized</code> </b> — When both the CPU and memory of your ECS service
        /// meet the performance requirements of your workload, the service is considered optimized.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ECSServiceRecommendationFinding Finding
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
        ///  The reason for the finding classification of an ECS service. 
        /// </para>
        ///  
        /// <para>
        /// Finding reason codes for ECS services include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>CPUUnderprovisioned</code> </b> — The ECS service CPU configuration can
        /// be sized up to enhance the performance of your workload. This is identified by analyzing
        /// the <code>CPUUtilization</code> metric of the current service during the look-back
        /// period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CPUOverprovisioned</code> </b> — The ECS service CPU configuration can
        /// be sized down while still meeting the performance requirements of your workload. This
        /// is identified by analyzing the <code>CPUUtilization</code> metric of the current service
        /// during the look-back period. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryUnderprovisioned</code> </b> — The ECS service memory configuration
        /// can be sized up to enhance the performance of your workload. This is identified by
        /// analyzing the <code>MemoryUtilization</code> metric of the current service during
        /// the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryOverprovisioned</code> </b> — The ECS service memory configuration
        /// can be sized down while still meeting the performance requirements of your workload.
        /// This is identified by analyzing the <code>MemoryUtilization</code> metric of the current
        /// service during the look-back period.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the ECS service recommendation was last generated. 
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        ///  The launch type the ECS service is using. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute Optimizer only supports the Fargate launch type.
        /// </para>
        ///  </note>
        /// </summary>
        public ECSServiceLaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days the ECS service utilization metrics were analyzed. 
        /// </para>
        /// </summary>
        public double LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays.GetValueOrDefault(); }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the current ECS service. 
        /// </para>
        ///  
        /// <para>
        ///  The following is the format of the ARN: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:ecs:region:aws_account_id:service/cluster-name/service-name</code>
        /// 
        /// </para>
        /// </summary>
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for the ECS service.
        /// 
        /// </para>
        /// </summary>
        public List<ECSServiceRecommendationOption> ServiceRecommendationOptions
        {
            get { return this._serviceRecommendationOptions; }
            set { this._serviceRecommendationOptions = value; }
        }

        // Check to see if ServiceRecommendationOptions property is set
        internal bool IsSetServiceRecommendationOptions()
        {
            return this._serviceRecommendationOptions != null && this._serviceRecommendationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the utilization metrics of the ECS service. 
        /// </para>
        /// </summary>
        public List<ECSServiceUtilizationMetric> UtilizationMetrics
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