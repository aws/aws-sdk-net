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
        private string _cronExpressionForRecurrence;
        private Duration _duration;
        private DateTime? _startAt;

        /// <summary>
        /// Gets and sets the property CronExpressionForRecurrence. 
        /// <para>
        /// A cron expression for a recurring maintenance schedule during which Auto-Tune can
        /// deploy changes.
        /// </para>
        /// </summary>
        public string CronExpressionForRecurrence
        {
            get { return this._cronExpressionForRecurrence; }
            set { this._cronExpressionForRecurrence = value; }
        }

        // Check to see if CronExpressionForRecurrence property is set
        internal bool IsSetCronExpressionForRecurrence()
        {
            return this._cronExpressionForRecurrence != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the maintenance schedule. For example, <code>"Duration": {"Value":
        /// 2, "Unit": "HOURS"}</code>.
        /// </para>
        /// </summary>
        public Duration Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The Epoch timestamp at which the Auto-Tune maintenance schedule starts.
        /// </para>
        /// </summary>
        public DateTime StartAt
        {
            get { return this._startAt.GetValueOrDefault(); }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

    }
}