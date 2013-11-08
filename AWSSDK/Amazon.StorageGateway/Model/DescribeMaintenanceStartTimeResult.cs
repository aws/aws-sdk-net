/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Describe Maintenance Start Time Result
    /// </summary>
    public partial class DescribeMaintenanceStartTimeResult
    {
        
        private string gatewayARN;
        private int? hourOfDay;
        private int? minuteOfHour;
        private int? dayOfWeek;
        private string timezone;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMaintenanceStartTimeResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
        public int HourOfDay
        {
            get { return this.hourOfDay ?? default(int); }
            set { this.hourOfDay = value; }
        }

        /// <summary>
        /// Sets the HourOfDay property
        /// </summary>
        /// <param name="hourOfDay">The value to set for the HourOfDay property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMaintenanceStartTimeResult WithHourOfDay(int hourOfDay)
        {
            this.hourOfDay = hourOfDay;
            return this;
        }
            

        // Check to see if HourOfDay property is set
        internal bool IsSetHourOfDay()
        {
            return this.hourOfDay.HasValue;
        }
        public int MinuteOfHour
        {
            get { return this.minuteOfHour ?? default(int); }
            set { this.minuteOfHour = value; }
        }

        /// <summary>
        /// Sets the MinuteOfHour property
        /// </summary>
        /// <param name="minuteOfHour">The value to set for the MinuteOfHour property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMaintenanceStartTimeResult WithMinuteOfHour(int minuteOfHour)
        {
            this.minuteOfHour = minuteOfHour;
            return this;
        }
            

        // Check to see if MinuteOfHour property is set
        internal bool IsSetMinuteOfHour()
        {
            return this.minuteOfHour.HasValue;
        }
        public int DayOfWeek
        {
            get { return this.dayOfWeek ?? default(int); }
            set { this.dayOfWeek = value; }
        }

        /// <summary>
        /// Sets the DayOfWeek property
        /// </summary>
        /// <param name="dayOfWeek">The value to set for the DayOfWeek property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMaintenanceStartTimeResult WithDayOfWeek(int dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
            

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this.dayOfWeek.HasValue;
        }
        public string Timezone
        {
            get { return this.timezone; }
            set { this.timezone = value; }
        }

        /// <summary>
        /// Sets the Timezone property
        /// </summary>
        /// <param name="timezone">The value to set for the Timezone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMaintenanceStartTimeResult WithTimezone(string timezone)
        {
            this.timezone = timezone;
            return this;
        }
            

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this.timezone != null;
        }
    }
}
