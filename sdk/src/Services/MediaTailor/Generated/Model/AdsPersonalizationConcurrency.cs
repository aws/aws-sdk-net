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
    /// The concurrency settings for ad decision server interactions during ad personalization.
    /// </summary>
    public partial class AdsPersonalizationConcurrency
    {
        private bool? _enableVodVastParallelization;
        private int? _maxConcurrentAdsRequests;

        /// <summary>
        /// Gets and sets the property EnableVodVastParallelization. 
        /// <para>
        /// Enables parallel processing of ad decision server requests in VOD workflows when the
        /// ADS returns VAST responses. The default is false.
        /// </para>
        /// </summary>
        public bool? EnableVodVastParallelization
        {
            get { return this._enableVodVastParallelization; }
            set { this._enableVodVastParallelization = value; }
        }

        // Check to see if EnableVodVastParallelization property is set
        internal bool IsSetEnableVodVastParallelization()
        {
            return this._enableVodVastParallelization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentAdsRequests. 
        /// <para>
        /// The maximum number of simultaneous requests that MediaTailor makes to the ad decision
        /// server per manifest request. The default is 1.
        /// </para>
        /// </summary>
        public int? MaxConcurrentAdsRequests
        {
            get { return this._maxConcurrentAdsRequests; }
            set { this._maxConcurrentAdsRequests = value; }
        }

        // Check to see if MaxConcurrentAdsRequests property is set
        internal bool IsSetMaxConcurrentAdsRequests()
        {
            return this._maxConcurrentAdsRequests.HasValue; 
        }

    }
}