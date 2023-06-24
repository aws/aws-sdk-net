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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// A complex type that contains settings governing when MediaTailor prefetches ads, and
    /// which dynamic variables that MediaTailor includes in the request to the ad decision
    /// server.
    /// </summary>
    public partial class PrefetchRetrieval
    {
        private Dictionary<string, string> _dynamicVariables = new Dictionary<string, string>();
        private DateTime? _endTime;
        private DateTime? _startTime;

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
        /// specify <code>DynamicVariables</code> for prefetch retrieval, MediaTailor includes
        /// the dynamic variables in the request to the ADS.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DynamicVariables
        {
            get { return this._dynamicVariables; }
            set { this._dynamicVariables = value; }
        }

        // Check to see if DynamicVariables property is set
        internal bool IsSetDynamicVariables()
        {
            return this._dynamicVariables != null && this._dynamicVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when prefetch retrieval ends for the ad break. Prefetching will be attempted
        /// for manifest requests that occur at or before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when prefetch retrievals can start for this break. Ad prefetching will be
        /// attempted for manifest requests that occur at or after this time. Defaults to the
        /// current time. If not specified, the prefetch retrieval starts as soon as possible.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}