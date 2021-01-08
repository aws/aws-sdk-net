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
    /// Describes an AWS Lambda function recommendation.
    /// </summary>
    public partial class LambdaFunctionRecommendation
    {
        private string _accountId;
        private int? _currentMemorySize;
        private LambdaFunctionRecommendationFinding _finding;
        private List<string> _findingReasonCodes = new List<string>();
        private string _functionArn;
        private string _functionVersion;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookbackPeriodInDays;
        private List<LambdaFunctionMemoryRecommendationOption> _memorySizeRecommendationOptions = new List<LambdaFunctionMemoryRecommendationOption>();
        private long? _numberOfInvocations;
        private List<LambdaFunctionUtilizationMetric> _utilizationMetrics = new List<LambdaFunctionUtilizationMetric>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID of the function.
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
        /// Gets and sets the property CurrentMemorySize. 
        /// <para>
        /// The amount of memory, in MB, that's allocated to the current function.
        /// </para>
        /// </summary>
        public int CurrentMemorySize
        {
            get { return this._currentMemorySize.GetValueOrDefault(); }
            set { this._currentMemorySize = value; }
        }

        // Check to see if CurrentMemorySize property is set
        internal bool IsSetCurrentMemorySize()
        {
            return this._currentMemorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification for the function.
        /// </para>
        ///  
        /// <para>
        /// Findings for functions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Optimized</code> </b> — The function is correctly provisioned to run your
        /// workload based on its current configuration and its utilization history. This finding
        /// classification does not include finding reason codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NotOptimized</code> </b> — The function is performing at a higher level
        /// (over-provisioned) or at a lower level (under-provisioned) than required for your
        /// workload because its current configuration is not optimal. Over-provisioned resources
        /// might lead to unnecessary infrastructure cost, and under-provisioned resources might
        /// lead to poor application performance. This finding classification can include the
        /// <code>MemoryUnderprovisioned</code> and <code>MemoryUnderprovisioned</code> finding
        /// reason codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Unavailable</code> </b> — Compute Optimizer was unable to generate a recommendation
        /// for the function. This could be because the function has not accumulated sufficient
        /// metric data, or the function does not qualify for a recommendation. This finding classification
        /// can include the <code>InsufficientData</code> and <code>Inconclusive</code> finding
        /// reason codes.
        /// </para>
        ///  <note> 
        /// <para>
        /// Functions with a finding of unavailable are not returned unless you specify the <code>filter</code>
        /// parameter with a value of <code>Unavailable</code> in your <code>GetLambdaFunctionRecommendations</code>
        /// request.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public LambdaFunctionRecommendationFinding Finding
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
        /// The reason for the finding classification of the function.
        /// </para>
        ///  <note> 
        /// <para>
        /// Functions that have a finding classification of <code>Optimized</code> don't have
        /// a finding reason code.
        /// </para>
        ///  </note> 
        /// <para>
        /// Reason codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>MemoryOverprovisioned</code> </b> — The function is over-provisioned when
        /// its memory configuration can be sized down while still meeting the performance requirements
        /// of your workload. An over-provisioned function might lead to unnecessary infrastructure
        /// cost. This finding reason code is part of the <code>NotOptimized</code> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MemoryUnderprovisioned</code> </b> — The function is under-provisioned
        /// when its memory configuration doesn't meet the performance requirements of the workload.
        /// An under-provisioned function might lead to poor application performance. This finding
        /// reason code is part of the <code>NotOptimized</code> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>InsufficientData</code> </b> — The function does not have sufficient metric
        /// data for Compute Optimizer to generate a recommendation. For more information, see
        /// the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>. This
        /// finding reason code is part of the <code>Unavailable</code> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Inconclusive</code> </b> — The function does not qualify for a recommendation,
        /// or there was an internal error. This finding reason code is part of the <code>Unavailable</code>
        /// finding classification.
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current function.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// The version number of the current function.
        /// </para>
        /// </summary>
        public string FunctionVersion
        {
            get { return this._functionVersion; }
            set { this._functionVersion = value; }
        }

        // Check to see if FunctionVersion property is set
        internal bool IsSetFunctionVersion()
        {
            return this._functionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The time stamp of when the function recommendation was last refreshed.
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
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The number of days for which utilization metrics were analyzed for the function.
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
        /// Gets and sets the property MemorySizeRecommendationOptions. 
        /// <para>
        /// An array of objects that describe the memory configuration recommendation options
        /// for the function.
        /// </para>
        /// </summary>
        public List<LambdaFunctionMemoryRecommendationOption> MemorySizeRecommendationOptions
        {
            get { return this._memorySizeRecommendationOptions; }
            set { this._memorySizeRecommendationOptions = value; }
        }

        // Check to see if MemorySizeRecommendationOptions property is set
        internal bool IsSetMemorySizeRecommendationOptions()
        {
            return this._memorySizeRecommendationOptions != null && this._memorySizeRecommendationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfInvocations. 
        /// <para>
        /// The number of times your function code was executed during the look-back period.
        /// </para>
        /// </summary>
        public long NumberOfInvocations
        {
            get { return this._numberOfInvocations.GetValueOrDefault(); }
            set { this._numberOfInvocations = value; }
        }

        // Check to see if NumberOfInvocations property is set
        internal bool IsSetNumberOfInvocations()
        {
            return this._numberOfInvocations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the function.
        /// </para>
        /// </summary>
        public List<LambdaFunctionUtilizationMetric> UtilizationMetrics
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