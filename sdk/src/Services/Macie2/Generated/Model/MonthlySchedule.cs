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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Run the job once a month, on a specific day of the month. This value can be an integer
    /// from 1 through 30.
    /// </summary>
    public partial class MonthlySchedule
    {
        private int? _dayOfMonth;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// Run the job once a month, on a specific day of the month. This value can be an integer
        /// from 1 through 30.
        /// </para>
        /// </summary>
        public int DayOfMonth
        {
            get { return this._dayOfMonth.GetValueOrDefault(); }
            set { this._dayOfMonth = value; }
        }

        // Check to see if DayOfMonth property is set
        internal bool IsSetDayOfMonth()
        {
            return this._dayOfMonth.HasValue; 
        }

    }
}