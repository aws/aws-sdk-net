/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCrawlerSchedule operation.
    /// Updates the schedule of a crawler using a <code>cron</code> expression.
    /// </summary>
    public partial class UpdateCrawlerScheduleRequest : AmazonGlueRequest
    {
        private string _crawlerName;
        private string _schedule;

        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// Name of the crawler whose schedule to update.
        /// </para>
        /// </summary>
        public string CrawlerName
        {
            get { return this._crawlerName; }
            set { this._crawlerName = value; }
        }

        // Check to see if CrawlerName property is set
        internal bool IsSetCrawlerName()
        {
            return this._crawlerName != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The updated <code>cron</code> expression used to specify the schedule (see <a href="http://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <code>cron(15 12 * * ? *)</code>.
        /// </para>
        /// </summary>
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

    }
}