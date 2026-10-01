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
    /// The timeout settings for ad decision server interactions during ad personalization.
    /// </summary>
    public partial class AdsPersonalizationTimeouts
    {
        /// <summary>
        /// Gets and sets the property AdsRequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a single ad decision
        /// server response during live or VOD playback. The default is 3000.
        /// </para>
        /// </summary>
        public int? AdsRequestTimeoutMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the AdsRequestTimeoutMilliseconds property is set.
        /// </summary>
        internal bool IsSetAdsRequestTimeoutMilliseconds() => this.AdsRequestTimeoutMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property LiveMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity for live manifests, including making requests, waiting for responses, and
        /// following VAST wrapper redirects. The default is 10000.
        /// </para>
        /// </summary>
        public int? LiveMaximumAdsPersonalizationTimeMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the LiveMaximumAdsPersonalizationTimeMilliseconds property is set.
        /// </summary>
        internal bool IsSetLiveMaximumAdsPersonalizationTimeMilliseconds() => this.LiveMaximumAdsPersonalizationTimeMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property PrefetchAdsRequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a single ad decision
        /// server response during prefetch retrieval. If not set, the value of AdsRequestTimeoutMilliseconds
        /// is used.
        /// </para>
        /// </summary>
        public int? PrefetchAdsRequestTimeoutMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the PrefetchAdsRequestTimeoutMilliseconds property is set.
        /// </summary>
        internal bool IsSetPrefetchAdsRequestTimeoutMilliseconds() => this.PrefetchAdsRequestTimeoutMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property PrefetchMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity during prefetch retrieval, including making requests, waiting for responses,
        /// and following VAST wrapper redirects.
        /// </para>
        /// </summary>
        public int? PrefetchMaximumAdsPersonalizationTimeMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the PrefetchMaximumAdsPersonalizationTimeMilliseconds property is set.
        /// </summary>
        internal bool IsSetPrefetchMaximumAdsPersonalizationTimeMilliseconds() => this.PrefetchMaximumAdsPersonalizationTimeMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property VodMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity for VOD manifests, including making requests, waiting for responses, and
        /// following VAST wrapper redirects. The default is 10000.
        /// </para>
        /// </summary>
        public int? VodMaximumAdsPersonalizationTimeMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the VodMaximumAdsPersonalizationTimeMilliseconds property is set.
        /// </summary>
        internal bool IsSetVodMaximumAdsPersonalizationTimeMilliseconds() => this.VodMaximumAdsPersonalizationTimeMilliseconds.HasValue;
    }
}
