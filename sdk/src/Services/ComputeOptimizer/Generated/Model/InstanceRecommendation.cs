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
        private Finding _finding;
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
        /// The AWS account ID of the instance.
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
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification for the instance.
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
        /// of your workload and is not over provisioned. An optimized instance runs your workloads
        /// with optimal performance and infrastructure cost. For optimized resources, AWS Compute
        /// Optimizer might recommend a new generation instance type.
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
        /// The time stamp of when the instance recommendation was last refreshed.
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