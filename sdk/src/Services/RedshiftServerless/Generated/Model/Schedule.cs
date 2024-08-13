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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The schedule of when Amazon Redshift Serverless should run the scheduled action.
    /// </summary>
    public partial class Schedule
    {
        private DateTime? _at;
        private string _cron;

        /// <summary>
        /// Gets and sets the property At. 
        /// <para>
        /// The timestamp of when Amazon Redshift Serverless should run the scheduled action.
        /// Timestamp is in UTC. Format of at expression is <c>yyyy-mm-ddThh:mm:ss</c>. For example,
        /// <c>2016-03-04T17:27:00</c>.
        /// </para>
        /// </summary>
        public DateTime? At
        {
            get { return this._at; }
            set { this._at = value; }
        }

        // Check to see if At property is set
        internal bool IsSetAt()
        {
            return this._at.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cron. 
        /// <para>
        /// The cron expression to use to schedule a recurring scheduled action. Schedule invocations
        /// must be separated by at least one hour. Times are in UTC.
        /// </para>
        ///  
        /// <para>
        /// Format of cron expressions is <c>(Minutes Hours Day-of-month Month Day-of-week Year)</c>.
        /// For example, <c>"(0 10 ? * MON *)"</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html#CronExpressions">Cron
        /// Expressions</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        /// </summary>
        public string Cron
        {
            get { return this._cron; }
            set { this._cron = value; }
        }

        // Check to see if Cron property is set
        internal bool IsSetCron()
        {
            return this._cron != null;
        }

    }
}