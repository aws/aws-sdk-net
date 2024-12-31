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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a recommendation.
    /// </summary>
    public partial class RecommendationItem
    {
        private bool? _alreadyImplemented;
        private Alarm _discoveredAlarm;
        private bool? _excluded;
        private ExcludeRecommendationReason _excludeReason;
        private Experiment _latestDiscoveredExperiment;
        private string _resourceId;
        private string _targetAccountId;
        private string _targetRegion;

        /// <summary>
        /// Gets and sets the property AlreadyImplemented. 
        /// <para>
        /// Specifies if the recommendation has already been implemented.
        /// </para>
        /// </summary>
        public bool? AlreadyImplemented
        {
            get { return this._alreadyImplemented; }
            set { this._alreadyImplemented = value; }
        }

        // Check to see if AlreadyImplemented property is set
        internal bool IsSetAlreadyImplemented()
        {
            return this._alreadyImplemented.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiscoveredAlarm. 
        /// <para>
        /// Indicates the previously implemented Amazon CloudWatch alarm discovered by Resilience
        /// Hub.
        /// </para>
        /// </summary>
        public Alarm DiscoveredAlarm
        {
            get { return this._discoveredAlarm; }
            set { this._discoveredAlarm = value; }
        }

        // Check to see if DiscoveredAlarm property is set
        internal bool IsSetDiscoveredAlarm()
        {
            return this._discoveredAlarm != null;
        }

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if an operational recommendation item is excluded.
        /// </para>
        /// </summary>
        public bool? Excluded
        {
            get { return this._excluded; }
            set { this._excluded = value; }
        }

        // Check to see if Excluded property is set
        internal bool IsSetExcluded()
        {
            return this._excluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeReason. 
        /// <para>
        /// Indicates the reason for excluding an operational recommendation.
        /// </para>
        /// </summary>
        public ExcludeRecommendationReason ExcludeReason
        {
            get { return this._excludeReason; }
            set { this._excludeReason = value; }
        }

        // Check to see if ExcludeReason property is set
        internal bool IsSetExcludeReason()
        {
            return this._excludeReason != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDiscoveredExperiment. 
        /// <para>
        /// Indicates the experiment created in FIS that was discovered by Resilience Hub, which
        /// matches the recommendation.
        /// </para>
        /// </summary>
        public Experiment LatestDiscoveredExperiment
        {
            get { return this._latestDiscoveredExperiment; }
            set { this._latestDiscoveredExperiment = value; }
        }

        // Check to see if LatestDiscoveredExperiment property is set
        internal bool IsSetLatestDiscoveredExperiment()
        {
            return this._latestDiscoveredExperiment != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// Identifier of the target account.
        /// </para>
        /// </summary>
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The target region.
        /// </para>
        /// </summary>
        public string TargetRegion
        {
            get { return this._targetRegion; }
            set { this._targetRegion = value; }
        }

        // Check to see if TargetRegion property is set
        internal bool IsSetTargetRegion()
        {
            return this._targetRegion != null;
        }

    }
}