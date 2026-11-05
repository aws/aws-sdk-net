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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration for event-based logging that specifies which event types to log and
    /// their logging settings. Used for account-level logging overrides.
    /// </summary>
    public partial class LogEventConfiguration
    {
        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        ///  The type of event to log. These include event types like Connect, Publish, and Disconnect.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        ///  CloudWatch Log Group for event-based logging. Specifies where log events should be
        /// sent. The log destination for event-based logging overrides default Log Group for
        /// the specified event type and applies to all resources associated with that event.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the LogDestination property is set.
        /// </summary>
        internal bool IsSetLogDestination() => this.LogDestination != null;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        ///  The logging level for the specified event type. Determines the verbosity of log messages
        /// generated for this event type. 
        /// </para>
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;
    }
}
