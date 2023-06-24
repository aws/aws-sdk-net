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
    /// Details about when an on-call rotation shift begins or ends.
    /// </summary>
    public partial class HandOffTime
    {
        private int? _hourOfDay;
        private int? _minuteOfHour;

        /// <summary>
        /// Gets and sets the property HourOfDay. 
        /// <para>
        /// The hour when an on-call rotation shift begins or ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int HourOfDay
        {
            get { return this._hourOfDay.GetValueOrDefault(); }
            set { this._hourOfDay = value; }
        }

        // Check to see if HourOfDay property is set
        internal bool IsSetHourOfDay()
        {
            return this._hourOfDay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinuteOfHour. 
        /// <para>
        /// The minute when an on-call rotation shift begins or ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public int MinuteOfHour
        {
            get { return this._minuteOfHour.GetValueOrDefault(); }
            set { this._minuteOfHour = value; }
        }

        // Check to see if MinuteOfHour property is set
        internal bool IsSetMinuteOfHour()
        {
            return this._minuteOfHour.HasValue; 
        }

    }
}