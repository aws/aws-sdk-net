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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The default sending limits for journeys in the application. To override these limits
    /// and define custom limits for a specific journey, use the Journey resource.
    /// </summary>
    public partial class ApplicationSettingsJourneyLimits
    {
        /// <summary>
        /// Gets and sets the property DailyCap. 
        /// <para>
        /// The daily number of messages that an endpoint can receive from all journeys. The maximum
        /// value is 100. If set to 0, this limit will not apply.
        /// </para>
        /// </summary>
        public int? DailyCap { get; set; }

        /// <summary>
        /// Checks to see if the DailyCap property is set.
        /// </summary>
        internal bool IsSetDailyCap() => this.DailyCap.HasValue;

        /// <summary>
        /// Gets and sets the property TimeframeCap. 
        /// <para>
        /// The default maximum number of messages that can be sent to an endpoint during the
        /// specified timeframe for all journeys.
        /// </para>
        /// </summary>
        public JourneyTimeframeCap TimeframeCap { get; set; }

        /// <summary>
        /// Checks to see if the TimeframeCap property is set.
        /// </summary>
        internal bool IsSetTimeframeCap() => this.TimeframeCap != null;

        /// <summary>
        /// Gets and sets the property TotalCap. 
        /// <para>
        /// The default maximum number of messages that a single journey can sent to a single
        /// endpoint. The maximum value is 100. If set to 0, this limit will not apply.
        /// </para>
        /// </summary>
        public int? TotalCap { get; set; }

        /// <summary>
        /// Checks to see if the TotalCap property is set.
        /// </summary>
        internal bool IsSetTotalCap() => this.TotalCap.HasValue;
    }
}
