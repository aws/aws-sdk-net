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
    /// A single entry in a weekly calling schedule, defining the open and close times for
    /// one day of the week.
    /// </summary>
    public partial class WhatsAppWeeklyOperatingHoursEntry
    {
        private WhatsAppTimeOfDay _closeTime;
        private WhatsAppDayOfWeek _dayOfWeek;
        private WhatsAppTimeOfDay _openTime;

        /// <summary>
        /// Gets and sets the property CloseTime. 
        /// <para>
        /// The time of day when the business stops accepting calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppTimeOfDay CloseTime
        {
            get { return this._closeTime; }
            set { this._closeTime = value; }
        }

        // Check to see if CloseTime property is set
        internal bool IsSetCloseTime()
        {
            return this._closeTime != null;
        }

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week that the entry applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppDayOfWeek DayOfWeek
        {
            get { return this._dayOfWeek; }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek != null;
        }

        /// <summary>
        /// Gets and sets the property OpenTime. 
        /// <para>
        /// The time of day when the business begins accepting calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppTimeOfDay OpenTime
        {
            get { return this._openTime; }
            set { this._openTime = value; }
        }

        // Check to see if OpenTime property is set
        internal bool IsSetOpenTime()
        {
            return this._openTime != null;
        }

    }
}