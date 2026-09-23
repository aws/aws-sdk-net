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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a recommendation.
    /// </summary>
    public partial class RecommendationItem
    {
        /// <summary>
        /// Gets and sets the property AlreadyImplemented. 
        /// <para>
        /// Specifies if the recommendation has already been implemented.
        /// </para>
        /// </summary>
        public bool? AlreadyImplemented { get; set; }

        /// <summary>
        /// Checks to see if the AlreadyImplemented property is set.
        /// </summary>
        internal bool IsSetAlreadyImplemented() => this.AlreadyImplemented.HasValue;

        /// <summary>
        /// Gets and sets the property DiscoveredAlarm. 
        /// <para>
        /// Indicates the previously implemented Amazon CloudWatch alarm discovered by Resilience
        /// Hub.
        /// </para>
        /// </summary>
        public Alarm DiscoveredAlarm { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveredAlarm property is set.
        /// </summary>
        internal bool IsSetDiscoveredAlarm() => this.DiscoveredAlarm != null;

        /// <summary>
        /// Gets and sets the property ExcludeReason. 
        /// <para>
        /// Indicates the reason for excluding an operational recommendation.
        /// </para>
        /// </summary>
        public ExcludeRecommendationReason ExcludeReason { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeReason property is set.
        /// </summary>
        internal bool IsSetExcludeReason() => this.ExcludeReason != null;

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if an operational recommendation item is excluded.
        /// </para>
        /// </summary>
        public bool? Excluded { get; set; }

        /// <summary>
        /// Checks to see if the Excluded property is set.
        /// </summary>
        internal bool IsSetExcluded() => this.Excluded.HasValue;

        /// <summary>
        /// Gets and sets the property LatestDiscoveredExperiment. 
        /// <para>
        /// Indicates the experiment created in FIS that was discovered by Resilience Hub, which
        /// matches the recommendation.
        /// </para>
        /// </summary>
        public Experiment LatestDiscoveredExperiment { get; set; }

        /// <summary>
        /// Checks to see if the LatestDiscoveredExperiment property is set.
        /// </summary>
        internal bool IsSetLatestDiscoveredExperiment() => this.LatestDiscoveredExperiment != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// Identifier of the target account.
        /// </para>
        /// </summary>
        public string TargetAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccountId property is set.
        /// </summary>
        internal bool IsSetTargetAccountId() => this.TargetAccountId != null;

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The target region.
        /// </para>
        /// </summary>
        public string TargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the TargetRegion property is set.
        /// </summary>
        internal bool IsSetTargetRegion() => this.TargetRegion != null;
    }
}
