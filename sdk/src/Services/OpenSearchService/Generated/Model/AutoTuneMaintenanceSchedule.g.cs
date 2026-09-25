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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This object is deprecated. Use the domain's <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html">off-peak
    /// window</a> to schedule Auto-Tune optimizations. For migration instructions, see <a
    /// href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html#off-peak-migrate">Migrating
    /// from Auto-Tune maintenance windows</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The Auto-Tune maintenance schedule. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
    /// for Amazon OpenSearch Service</a>.
    /// </para>
    /// </summary>
    public partial class AutoTuneMaintenanceSchedule
    {
        /// <summary>
        /// Gets and sets the property CronExpressionForRecurrence. 
        /// <para>
        /// A cron expression for a recurring maintenance schedule during which Auto-Tune can
        /// deploy changes.
        /// </para>
        /// </summary>
        public string CronExpressionForRecurrence { get; set; }

        /// <summary>
        /// Checks to see if the CronExpressionForRecurrence property is set.
        /// </summary>
        internal bool IsSetCronExpressionForRecurrence() => this.CronExpressionForRecurrence != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the maintenance schedule. For example, <c>"Duration": {"Value": 2,
        /// "Unit": "HOURS"}</c>.
        /// </para>
        /// </summary>
        public Duration Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The Epoch timestamp at which the Auto-Tune maintenance schedule starts.
        /// </para>
        /// </summary>
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Checks to see if the StartAt property is set.
        /// </summary>
        internal bool IsSetStartAt() => this.StartAt.HasValue;
    }
}
