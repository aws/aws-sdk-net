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
    /// Describes an Amazon Elastic Block Store (Amazon EBS) volume recommendation.
    /// </summary>
    public partial class VolumeRecommendation
    {
        private string _accountId;
        private VolumeConfiguration _currentConfiguration;
        private EBSFinding _finding;
        private DateTime? _lastRefreshTimestamp;
        private double? _lookBackPeriodInDays;
        private List<EBSUtilizationMetric> _utilizationMetrics = new List<EBSUtilizationMetric>();
        private string _volumeArn;
        private List<VolumeRecommendationOption> _volumeRecommendationOptions = new List<VolumeRecommendationOption>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID of the volume.
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
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// An array of objects that describe the current configuration of the volume.
        /// </para>
        /// </summary>
        public VolumeConfiguration CurrentConfiguration
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
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification for the volume.
        /// </para>
        ///  
        /// <para>
        /// Findings for volumes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>NotOptimized</code> </b>—A volume is considered not optimized when AWS
        /// Compute Optimizer identifies a recommendation that can provide better performance
        /// for your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Optimized</code> </b>—An volume is considered optimized when Compute Optimizer
        /// determines that the volume is correctly provisioned to run your workload based on
        /// the chosen volume type. For optimized resources, Compute Optimizer might recommend
        /// a new generation volume type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EBSFinding Finding
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
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The time stamp of when the volume recommendation was last refreshed.
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
        /// The number of days for which utilization metrics were analyzed for the volume.
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
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the volume.
        /// </para>
        /// </summary>
        public List<EBSUtilizationMetric> UtilizationMetrics
        {
            get { return this._utilizationMetrics; }
            set { this._utilizationMetrics = value; }
        }

        // Check to see if UtilizationMetrics property is set
        internal bool IsSetUtilizationMetrics()
        {
            return this._utilizationMetrics != null && this._utilizationMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VolumeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current volume.
        /// </para>
        /// </summary>
        public string VolumeArn
        {
            get { return this._volumeArn; }
            set { this._volumeArn = value; }
        }

        // Check to see if VolumeArn property is set
        internal bool IsSetVolumeArn()
        {
            return this._volumeArn != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeRecommendationOptions. 
        /// <para>
        /// An array of objects that describe the recommendation options for the volume.
        /// </para>
        /// </summary>
        public List<VolumeRecommendationOption> VolumeRecommendationOptions
        {
            get { return this._volumeRecommendationOptions; }
            set { this._volumeRecommendationOptions = value; }
        }

        // Check to see if VolumeRecommendationOptions property is set
        internal bool IsSetVolumeRecommendationOptions()
        {
            return this._volumeRecommendationOptions != null && this._volumeRecommendationOptions.Count > 0; 
        }

    }
}