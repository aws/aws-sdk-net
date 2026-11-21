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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The day on which the refresh runs. Specify one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>DayOfWeek</c> – For a weekly schedule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DayOfMonth</c> – For a monthly schedule.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class KnowledgeBaseScheduleRefreshOnEntity
    {
        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month on which a monthly refresh runs. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1</c> through <c>28</c> – The refresh runs on that day of each month.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAST_DAY_OF_MONTH</c> – The refresh runs on the last day of each month.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth != null;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week on which a weekly refresh runs.
        /// </para>
        /// </summary>
        public KbDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Checks to see if the DayOfWeek property is set.
        /// </summary>
        internal bool IsSetDayOfWeek() => this.DayOfWeek != null;
    }
}
