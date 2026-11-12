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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Contains the configuration used to schedule automated workflow execution. Only one
    /// version of a workflow can have an active schedule at any time.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The schedule expression that determines when the workflow runs, as specified in the
        /// <c>schedule</c> parameter of the workflow's YAML definition. You can specify one of
        /// the following types of schedule expressions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Apache Airflow cron expression – Five fields, such as <c>0 12 1 * *</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Apache Airflow schedule preset – <c>@hourly</c>, <c>@daily</c>, <c>@weekly</c>, <c>@monthly</c>,
        /// <c>@yearly</c>, or <c>@annually</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EventBridge Scheduler rate expression – For example, <c>rate(5 minutes)</c>. Supported
        /// units are minutes, hours, and days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EventBridge Scheduler cron expression – Six fields, such as <c>cron(0 12 * * ? *)</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In a cron expression, specify either a day-of-month or a day-of-week, not both.
        /// </para>
        /// </summary>
        public string CronExpression { get; set; }

        /// <summary>
        /// Checks to see if the CronExpression property is set.
        /// </summary>
        internal bool IsSetCronExpression() => this.CronExpression != null;
    }
}
