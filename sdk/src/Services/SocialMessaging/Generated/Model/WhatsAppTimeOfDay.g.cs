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
    /// A time of day, expressed as an hour and minute.
    /// </summary>
    public partial class WhatsAppTimeOfDay
    {
        /// <summary>
        /// Gets and sets the property Hours. 
        /// <para>
        /// The hour of the day, from 0 to 23.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 23)]
        public int? Hours { get; set; }

        /// <summary>
        /// Checks to see if the Hours property is set.
        /// </summary>
        internal bool IsSetHours() => this.Hours.HasValue;

        /// <summary>
        /// Gets and sets the property Minutes. 
        /// <para>
        /// The minute of the hour, from 0 to 59.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 59)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Checks to see if the Minutes property is set.
        /// </summary>
        internal bool IsSetMinutes() => this.Minutes.HasValue;
    }
}
