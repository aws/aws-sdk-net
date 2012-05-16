/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMaintenanceStartTime operation.
    /// <para>This operation updates a gateway's weekly maintenance start time information, including day and time of the week. The maintenance time
    /// is the time in your gateway's time zone.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateMaintenanceStartTime"/>
    public class UpdateMaintenanceStartTimeRequest : AmazonWebServiceRequest
    {
        private string gatewayARN;
        private int? hourOfDay;
        private int? minuteOfHour;
        private int? dayOfWeek;

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
        public UpdateMaintenanceStartTimeRequest WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;       
        }

        /// <summary>
        /// The maintenance start time hour of day. Length: 2 <i>Valid Values</i>: An integer between 0 and 23 representing the hour of day.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        public UpdateMaintenanceStartTimeRequest WithHourOfDay(int hourOfDay)
        {
            this.hourOfDay = hourOfDay;
            return this;
        }
            

        // Check to see if HourOfDay property is set
        internal bool IsSetHourOfDay()
        {
            return this.hourOfDay.HasValue;       
        }

        /// <summary>
        /// The maintenance start time minute of hour.. Length: 2 <i>Valid Values</i>: An integer between 0 and 59 representing the minute of hour.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 59</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        public UpdateMaintenanceStartTimeRequest WithMinuteOfHour(int minuteOfHour)
        {
            this.minuteOfHour = minuteOfHour;
            return this;
        }
            

        // Check to see if MinuteOfHour property is set
        internal bool IsSetMinuteOfHour()
        {
            return this.minuteOfHour.HasValue;       
        }

        /// <summary>
        /// The maintenance start time day of the week. Length: 1 Valid Values An integer between 0 and 6, where 0 represents Sunday and 6 represents
        /// Saturday.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 6</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        public UpdateMaintenanceStartTimeRequest WithDayOfWeek(int dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
            

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this.dayOfWeek.HasValue;       
        }
    }
}
    
