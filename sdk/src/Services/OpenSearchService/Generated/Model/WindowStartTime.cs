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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The desired start time for an <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html">off-peak
    /// maintenance window</a>.
    /// </summary>
    public partial class WindowStartTime
    {
        private long? _hours;
        private long? _minutes;

        /// <summary>
        /// Gets and sets the property Hours. 
        /// <para>
        /// The start hour of the window in Coordinated Universal Time (UTC), using 24-hour time.
        /// For example, <code>17</code> refers to 5:00 P.M. UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public long Hours
        {
            get { return this._hours.GetValueOrDefault(); }
            set { this._hours = value; }
        }

        // Check to see if Hours property is set
        internal bool IsSetHours()
        {
            return this._hours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minutes. 
        /// <para>
        /// The start minute of the window, in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public long Minutes
        {
            get { return this._minutes.GetValueOrDefault(); }
            set { this._minutes = value; }
        }

        // Check to see if Minutes property is set
        internal bool IsSetMinutes()
        {
            return this._minutes.HasValue; 
        }

    }
}