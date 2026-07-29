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
    /// The timeout settings for ad decision server interactions during ad personalization.
    /// </summary>
    public partial class AdsPersonalizationTimeouts
    {
        private int? _adsRequestTimeoutMilliseconds;
        private int? _liveMaximumAdsPersonalizationTimeMilliseconds;
        private int? _prefetchAdsRequestTimeoutMilliseconds;
        private int? _prefetchMaximumAdsPersonalizationTimeMilliseconds;
        private int? _vodMaximumAdsPersonalizationTimeMilliseconds;

        /// <summary>
        /// Gets and sets the property AdsRequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a single ad decision
        /// server response during live or VOD playback. The default is 3000.
        /// </para>
        /// </summary>
        public int? AdsRequestTimeoutMilliseconds
        {
            get { return this._adsRequestTimeoutMilliseconds; }
            set { this._adsRequestTimeoutMilliseconds = value; }
        }

        // Check to see if AdsRequestTimeoutMilliseconds property is set
        internal bool IsSetAdsRequestTimeoutMilliseconds()
        {
            return this._adsRequestTimeoutMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LiveMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity for live manifests, including making requests, waiting for responses, and
        /// following VAST wrapper redirects. The default is 10000.
        /// </para>
        /// </summary>
        public int? LiveMaximumAdsPersonalizationTimeMilliseconds
        {
            get { return this._liveMaximumAdsPersonalizationTimeMilliseconds; }
            set { this._liveMaximumAdsPersonalizationTimeMilliseconds = value; }
        }

        // Check to see if LiveMaximumAdsPersonalizationTimeMilliseconds property is set
        internal bool IsSetLiveMaximumAdsPersonalizationTimeMilliseconds()
        {
            return this._liveMaximumAdsPersonalizationTimeMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefetchAdsRequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a single ad decision
        /// server response during prefetch retrieval. If not set, the value of AdsRequestTimeoutMilliseconds
        /// is used.
        /// </para>
        /// </summary>
        public int? PrefetchAdsRequestTimeoutMilliseconds
        {
            get { return this._prefetchAdsRequestTimeoutMilliseconds; }
            set { this._prefetchAdsRequestTimeoutMilliseconds = value; }
        }

        // Check to see if PrefetchAdsRequestTimeoutMilliseconds property is set
        internal bool IsSetPrefetchAdsRequestTimeoutMilliseconds()
        {
            return this._prefetchAdsRequestTimeoutMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefetchMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity during prefetch retrieval, including making requests, waiting for responses,
        /// and following VAST wrapper redirects.
        /// </para>
        /// </summary>
        public int? PrefetchMaximumAdsPersonalizationTimeMilliseconds
        {
            get { return this._prefetchMaximumAdsPersonalizationTimeMilliseconds; }
            set { this._prefetchMaximumAdsPersonalizationTimeMilliseconds = value; }
        }

        // Check to see if PrefetchMaximumAdsPersonalizationTimeMilliseconds property is set
        internal bool IsSetPrefetchMaximumAdsPersonalizationTimeMilliseconds()
        {
            return this._prefetchMaximumAdsPersonalizationTimeMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VodMaximumAdsPersonalizationTimeMilliseconds. 
        /// <para>
        /// The maximum total time, in milliseconds, that MediaTailor spends on ad decision server
        /// activity for VOD manifests, including making requests, waiting for responses, and
        /// following VAST wrapper redirects. The default is 10000.
        /// </para>
        /// </summary>
        public int? VodMaximumAdsPersonalizationTimeMilliseconds
        {
            get { return this._vodMaximumAdsPersonalizationTimeMilliseconds; }
            set { this._vodMaximumAdsPersonalizationTimeMilliseconds = value; }
        }

        // Check to see if VodMaximumAdsPersonalizationTimeMilliseconds property is set
        internal bool IsSetVodMaximumAdsPersonalizationTimeMilliseconds()
        {
            return this._vodMaximumAdsPersonalizationTimeMilliseconds.HasValue; 
        }

    }
}