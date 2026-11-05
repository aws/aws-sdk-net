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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Nielsen Nw Only
    /// </summary>
    public partial class NielsenNwOnly
    {
        /// <summary>
        /// Gets and sets the property CheckDigitString. Enter the check digit string for the
        /// watermark
        /// </summary>
        [AWSProperty(Required = true)]
        public string CheckDigitString { get; set; }

        /// <summary>
        /// Checks to see if the CheckDigitString property is set.
        /// </summary>
        internal bool IsSetCheckDigitString() => this.CheckDigitString != null;

        /// <summary>
        /// Gets and sets the property Sid. Enter the Nielsen Source ID (SID) to include in the
        /// watermark
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Sid { get; set; }

        /// <summary>
        /// Checks to see if the Sid property is set.
        /// </summary>
        internal bool IsSetSid() => this.Sid.HasValue;

        /// <summary>
        /// Gets and sets the property Timezone. Choose the timezone for the time stamps in the
        /// watermark. If not provided, the timestamps will be in Coordinated Universal Time (UTC)
        /// </summary>
        public NielsenWatermarkTimezones Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
