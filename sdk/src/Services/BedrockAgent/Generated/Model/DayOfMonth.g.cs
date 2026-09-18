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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The day of the month on which a monthly sync runs. Specify exactly one of <c>dayNumber</c>
    /// or <c>lastDayOfMonth</c>.
    /// </summary>
    public partial class DayOfMonth
    {
        /// <summary>
        /// Gets and sets the property DayNumber. 
        /// <para>
        /// A specific day of the month, from 1 to 28. Values are capped at 28, so a monthly sync
        /// runs in every month, including February.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 28)]
        public int? DayNumber { get; set; }

        /// <summary>
        /// Checks to see if the DayNumber property is set.
        /// </summary>
        internal bool IsSetDayNumber() => this.DayNumber.HasValue;

        /// <summary>
        /// Gets and sets the property LastDayOfMonth. 
        /// <para>
        /// Set this option to run the monthly sync on the last calendar day of each month.
        /// </para>
        /// </summary>
        public LastDayOfMonth LastDayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the LastDayOfMonth property is set.
        /// </summary>
        internal bool IsSetLastDayOfMonth() => this.LastDayOfMonth != null;
    }
}
