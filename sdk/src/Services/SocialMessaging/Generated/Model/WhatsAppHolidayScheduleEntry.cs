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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// A date-specific override to the weekly operating hours, such as a holiday.
    /// </summary>
    public partial class WhatsAppHolidayScheduleEntry
    {
        private string _date;
        private WhatsAppTimeOfDay _endTime;
        private WhatsAppTimeOfDay _startTime;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date that the override applies to, in ISO 8601 format (<c>YYYY-MM-DD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time of day when the business stops accepting calls on the override date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppTimeOfDay EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time of day when the business begins accepting calls on the override date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppTimeOfDay StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}