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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// A date-specific override to the weekly operating hours, such as a holiday.
    /// </summary>
    public partial class WhatsAppHolidayScheduleEntry
    {
        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date that the override applies to, in ISO 8601 format (<c>YYYY-MM-DD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time of day when the business stops accepting calls on the override date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WhatsAppTimeOfDay EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time of day when the business begins accepting calls on the override date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WhatsAppTimeOfDay StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;
    }
}
