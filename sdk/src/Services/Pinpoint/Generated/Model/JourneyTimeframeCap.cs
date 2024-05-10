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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The number of messages that can be sent to an endpoint during the specified timeframe
    /// for all journeys.
    /// </summary>
    public partial class JourneyTimeframeCap
    {
        private int? _cap;
        private int? _days;

        /// <summary>
        /// Gets and sets the property Cap. 
        /// <para>
        /// The maximum number of messages that all journeys can send to an endpoint during the
        /// specified timeframe. The maximum value is 100. If set to 0, this limit will not apply.
        /// </para>
        /// </summary>
        public int? Cap
        {
            get { return this._cap; }
            set { this._cap = value; }
        }

        // Check to see if Cap property is set
        internal bool IsSetCap()
        {
            return this._cap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// The length of the timeframe in days. The maximum value is 30. If set to 0, this limit
        /// will not apply.
        /// </para>
        /// </summary>
        public int? Days
        {
            get { return this._days; }
            set { this._days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this._days.HasValue; 
        }

    }
}