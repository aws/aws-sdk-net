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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// A complex type that contains settings governing when MediaTailor prefetches ads, and
    /// which dynamic variables that MediaTailor includes in the request to the ad decision
    /// server.
    /// </summary>
    public partial class PrefetchRetrieval
    {
        /// <summary>
        /// Gets and sets the property DynamicVariables. 
        /// <para>
        /// The dynamic variables to use for substitution during prefetch requests to the ad decision
        /// server (ADS).
        /// </para>
        ///  
        /// <para>
        /// You initially configure <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/variables.html">dynamic
        /// variables</a> for the ADS URL when you set up your playback configuration. When you
        /// specify <c>DynamicVariables</c> for prefetch retrieval, MediaTailor includes the dynamic
        /// variables in the request to the ADS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DynamicVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DynamicVariables property is set.
        /// </summary>
        internal bool IsSetDynamicVariables() => this.DynamicVariables != null && (this.DynamicVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when prefetch retrieval ends for the ad break. Prefetching will be attempted
        /// for manifest requests that occur at or before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when prefetch retrievals can start for this break. Ad prefetching will be
        /// attempted for manifest requests that occur at or after this time. Defaults to the
        /// current time. If not specified, the prefetch retrieval starts as soon as possible.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficShapingRetrievalWindow. 
        /// <para>
        /// The configuration that tells Elemental MediaTailor how many seconds to spread out
        /// requests to the ad decision server (ADS). Instead of sending ADS requests for all
        /// sessions at the same time, MediaTailor spreads the requests across the amount of time
        /// specified in the retrieval window.
        /// </para>
        /// </summary>
        public TrafficShapingRetrievalWindow TrafficShapingRetrievalWindow { get; set; }

        /// <summary>
        /// Checks to see if the TrafficShapingRetrievalWindow property is set.
        /// </summary>
        internal bool IsSetTrafficShapingRetrievalWindow() => this.TrafficShapingRetrievalWindow != null;

        /// <summary>
        /// Gets and sets the property TrafficShapingTpsConfiguration. 
        /// <para>
        /// The configuration for TPS-based traffic shaping. This approach limits requests to
        /// the ad decision server (ADS) based on transactions per second and concurrent users.
        /// </para>
        /// </summary>
        public TrafficShapingTpsConfiguration TrafficShapingTpsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TrafficShapingTpsConfiguration property is set.
        /// </summary>
        internal bool IsSetTrafficShapingTpsConfiguration() => this.TrafficShapingTpsConfiguration != null;

        /// <summary>
        /// Gets and sets the property TrafficShapingType. 
        /// <para>
        /// Indicates the type of traffic shaping used to limit the number of requests to the
        /// ADS at one time.
        /// </para>
        /// </summary>
        public TrafficShapingType TrafficShapingType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficShapingType property is set.
        /// </summary>
        internal bool IsSetTrafficShapingType() => this.TrafficShapingType != null;
    }
}
