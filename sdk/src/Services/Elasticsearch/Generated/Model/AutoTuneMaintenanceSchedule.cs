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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies Auto-Tune maitenance schedule. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
    /// target="_blank">Developer Guide</a> for more information.
    /// </summary>
    public partial class AutoTuneMaintenanceSchedule
    {
        private string _cronExpressionForRecurrence;
        private Duration _duration;
        private DateTime? _startAt;

        /// <summary>
        /// Gets and sets the property CronExpressionForRecurrence. 
        /// <para>
        /// Specifies cron expression for a recurring maintenance schedule. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
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
        /// Specifies maintenance schedule duration: duration value and duration unit. See the
        /// <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
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
        /// Specifies timestamp at which Auto-Tune maintenance schedule start. 
        /// </para>
        /// </summary>
        public DateTime? StartAt
        {
            get { return this._startAt; }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

    }
}