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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about on-call rotations that recur monthly.
    /// </summary>
    public partial class MonthlySetting
    {
        private int? _dayOfMonth;
        private HandOffTime _handOffTime;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month when monthly recurring on-call rotations begin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=31)]
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

        /// <summary>
        /// Gets and sets the property HandOffTime. 
        /// <para>
        /// The time of day when a monthly recurring on-call shift rotation begins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HandOffTime HandOffTime
        {
            get { return this._handOffTime; }
            set { this._handOffTime = value; }
        }

        // Check to see if HandOffTime property is set
        internal bool IsSetHandOffTime()
        {
            return this._handOffTime != null;
        }

    }
}