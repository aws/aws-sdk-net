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
using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Describe Maintenance Start Time Result
    /// </summary>
    public partial class DescribeMaintenanceStartTimeResult : AmazonWebServiceResponse
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

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this.timezone != null;
        }
    }
}
