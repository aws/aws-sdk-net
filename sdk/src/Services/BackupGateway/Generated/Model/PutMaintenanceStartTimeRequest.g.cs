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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the PutMaintenanceStartTime operation. Set the maintenance
    /// start time for a gateway.
    /// </summary>
    public partial class PutMaintenanceStartTimeRequest : AmazonBackupGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month start maintenance on a gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid values range from <c>Sunday</c> to <c>Saturday</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 31)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth.HasValue;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week to start maintenance on a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6)]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// Checks to see if the DayOfWeek property is set.
        /// </summary>
        internal bool IsSetDayOfWeek() => this.DayOfWeek.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the gateway, used to specify its maintenance start
        /// time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 180)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property HourOfDay. 
        /// <para>
        /// The hour of the day to start maintenance on a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 23)]
        public int? HourOfDay { get; set; }

        /// <summary>
        /// Checks to see if the HourOfDay property is set.
        /// </summary>
        internal bool IsSetHourOfDay() => this.HourOfDay.HasValue;

        /// <summary>
        /// Gets and sets the property MinuteOfHour. 
        /// <para>
        /// The minute of the hour to start maintenance on a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 59)]
        public int? MinuteOfHour { get; set; }

        /// <summary>
        /// Checks to see if the MinuteOfHour property is set.
        /// </summary>
        internal bool IsSetMinuteOfHour() => this.MinuteOfHour.HasValue;
    }
}
