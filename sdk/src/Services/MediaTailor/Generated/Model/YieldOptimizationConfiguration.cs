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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
    /// Configuration for Yield Optimization, which fills unsold ad inventory in ad breaks
    /// with programmatic ads from Amazon Publisher Services (APS).
    /// </summary>
    public partial class YieldOptimizationConfiguration
    {
        private int? _minimumUnfilledDuration;
        private string _openRtbTemplate;
        private string _publisherId;
        private ApsRegion _region;

        /// <summary>
        /// Gets and sets the property MinimumUnfilledDuration. 
        /// <para>
        /// The minimum unfilled duration, in seconds, that must remain in an ad break before
        /// MediaTailor requests additional ads from Amazon Publisher Services (APS). For example,
        /// if set to 6 seconds, yield optimization triggers only when at least 6 seconds of unfilled
        /// time remains after the primary ad server response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=3600)]
        public int? MinimumUnfilledDuration
        {
            get { return this._minimumUnfilledDuration; }
            set { this._minimumUnfilledDuration = value; }
        }

        // Check to see if MinimumUnfilledDuration property is set
        internal bool IsSetMinimumUnfilledDuration()
        {
            return this._minimumUnfilledDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenRtbTemplate. 
        /// <para>
        /// The OpenRTB bid request template, in JSON, that MediaTailor sends to Amazon Publisher
        /// Services (APS). The template must include an <c>imp</c> array with one impression
        /// specifying <c>bidfloor</c>, an <c>app</c> object specifying <c>bundle</c> and <c>storeurl</c>,
        /// and a <c>device</c> object specifying <c>ua</c> and <c>ip</c>. Use double curly braces
        /// (for example, <c>{{player_params.user_agent}}</c>) to insert session variables and
        /// player parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=102400)]
        public string OpenRtbTemplate
        {
            get { return this._openRtbTemplate; }
            set { this._openRtbTemplate = value; }
        }

        // Check to see if OpenRtbTemplate property is set
        internal bool IsSetOpenRtbTemplate()
        {
            return this._openRtbTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// Publisher ID for an existing Amazon Publisher Services configuration. This ID must
        /// be obtained by registering with APS prior to using the Yield Optimization feature.
        /// The Publisher ID identifies your account in the APS system and is required for all
        /// bid requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Publisher Services (APS) region that MediaTailor sends bid requests to.
        /// Choose the region closest to your primary audience, because the selection affects
        /// both latency and the ad inventory available to you. This setting applies to the entire
        /// playback configuration, not to individual viewers. If you serve traffic across multiple
        /// regions, create a separate playback configuration for each APS region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApsRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}