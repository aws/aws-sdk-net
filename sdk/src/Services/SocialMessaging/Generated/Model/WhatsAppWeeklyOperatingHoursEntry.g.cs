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
    /// A single entry in a weekly calling schedule, defining the open and close times for
    /// one day of the week.
    /// </summary>
    public partial class WhatsAppWeeklyOperatingHoursEntry
    {
        /// <summary>
        /// Gets and sets the property CloseTime. 
        /// <para>
        /// The time of day when the business stops accepting calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WhatsAppTimeOfDay CloseTime { get; set; }

        /// <summary>
        /// Checks to see if the CloseTime property is set.
        /// </summary>
        internal bool IsSetCloseTime() => this.CloseTime != null;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week that the entry applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WhatsAppDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Checks to see if the DayOfWeek property is set.
        /// </summary>
        internal bool IsSetDayOfWeek() => this.DayOfWeek != null;

        /// <summary>
        /// Gets and sets the property OpenTime. 
        /// <para>
        /// The time of day when the business begins accepting calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WhatsAppTimeOfDay OpenTime { get; set; }

        /// <summary>
        /// Checks to see if the OpenTime property is set.
        /// </summary>
        internal bool IsSetOpenTime() => this.OpenTime != null;
    }
}
