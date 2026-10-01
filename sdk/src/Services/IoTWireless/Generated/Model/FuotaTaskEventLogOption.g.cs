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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The log options for a FUOTA task event and can be used to set log levels for a specific
    /// FUOTA task event.
    /// 
    ///  
    /// <para>
    /// For a LoRaWAN FUOTA task, the only possible event for a log message is <c>Fuota</c>.
    /// </para>
    /// </summary>
    public partial class FuotaTaskEventLogOption
    {
        /// <summary>
        /// Gets and sets the property Event.
        /// </summary>
        [AWSProperty(Required = true)]
        public FuotaTaskEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property LogLevel.
        /// </summary>
        [AWSProperty(Required = true)]
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;
    }
}
