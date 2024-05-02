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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Enable or disable collection of reputation metrics for emails that you send using
    /// this configuration set in the current AWS Region.
    /// </summary>
    public partial class ReputationOptions
    {
        private DateTime? _lastFreshStart;
        private bool? _reputationMetricsEnabled;

        /// <summary>
        /// Gets and sets the property LastFreshStart. 
        /// <para>
        /// The date and time (in Unix time) when the reputation metrics were last given a fresh
        /// start. When your account is given a fresh start, your reputation metrics are calculated
        /// starting from the date of the fresh start.
        /// </para>
        /// </summary>
        public DateTime? LastFreshStart
        {
            get { return this._lastFreshStart; }
            set { this._lastFreshStart = value; }
        }

        // Check to see if LastFreshStart property is set
        internal bool IsSetLastFreshStart()
        {
            return this._lastFreshStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReputationMetricsEnabled. 
        /// <para>
        /// If <c>true</c>, tracking of reputation metrics is enabled for the configuration set.
        /// If <c>false</c>, tracking of reputation metrics is disabled for the configuration
        /// set.
        /// </para>
        /// </summary>
        public bool? ReputationMetricsEnabled
        {
            get { return this._reputationMetricsEnabled; }
            set { this._reputationMetricsEnabled = value; }
        }

        // Check to see if ReputationMetricsEnabled property is set
        internal bool IsSetReputationMetricsEnabled()
        {
            return this._reputationMetricsEnabled.HasValue; 
        }

    }
}