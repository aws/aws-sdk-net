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
    /// The operating hours during which a business phone number accepts WhatsApp calls, including
    /// the time zone, weekly schedule, and any holiday overrides.
    /// </summary>
    public partial class WhatsAppCallHours
    {
        private bool? _enabled;
        private List<WhatsAppHolidayScheduleEntry> _holidaySchedule = AWSConfigs.InitializeCollections ? new List<WhatsAppHolidayScheduleEntry>() : null;
        private string _timezone;
        private List<WhatsAppWeeklyOperatingHoursEntry> _weeklyOperatingHours = AWSConfigs.InitializeCollections ? new List<WhatsAppWeeklyOperatingHoursEntry>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether call hours are enforced. When disabled, the business accepts calls
        /// at any time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HolidaySchedule. 
        /// <para>
        /// Date-specific overrides to the weekly operating hours, such as holidays.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<WhatsAppHolidayScheduleEntry> HolidaySchedule
        {
            get { return this._holidaySchedule; }
            set { this._holidaySchedule = value; }
        }

        // Check to see if HolidaySchedule property is set
        internal bool IsSetHolidaySchedule()
        {
            return this._holidaySchedule != null && (this._holidaySchedule.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The IANA time zone in which the operating hours are interpreted, such as <c>America/New_York</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyOperatingHours. 
        /// <para>
        /// The weekly schedule of hours during which the business accepts calls.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=14)]
        public List<WhatsAppWeeklyOperatingHoursEntry> WeeklyOperatingHours
        {
            get { return this._weeklyOperatingHours; }
            set { this._weeklyOperatingHours = value; }
        }

        // Check to see if WeeklyOperatingHours property is set
        internal bool IsSetWeeklyOperatingHours()
        {
            return this._weeklyOperatingHours != null && (this._weeklyOperatingHours.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}