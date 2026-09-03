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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private int? _dayNumber;
        private LastDayOfMonth _lastDayOfMonth;

        /// <summary>
        /// Gets and sets the property DayNumber. 
        /// <para>
        /// A specific day of the month, from 1 to 28. Values are capped at 28, so a monthly sync
        /// runs in every month, including February.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=28)]
        public int? DayNumber
        {
            get { return this._dayNumber; }
            set { this._dayNumber = value; }
        }

        // Check to see if DayNumber property is set
        internal bool IsSetDayNumber()
        {
            return this._dayNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastDayOfMonth. 
        /// <para>
        /// Set this option to run the monthly sync on the last calendar day of each month.
        /// </para>
        /// </summary>
        public LastDayOfMonth LastDayOfMonth
        {
            get { return this._lastDayOfMonth; }
            set { this._lastDayOfMonth = value; }
        }

        // Check to see if LastDayOfMonth property is set
        internal bool IsSetLastDayOfMonth()
        {
            return this._lastDayOfMonth != null;
        }

    }
}