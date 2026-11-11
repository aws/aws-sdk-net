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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information for one log event that has been processed by a
    /// log transformer.
    /// </summary>
    public partial class TransformedLogRecord
    {
        /// <summary>
        /// Gets and sets the property EventMessage. 
        /// <para>
        /// The original log event message before it was transformed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EventMessage { get; set; }

        /// <summary>
        /// Checks to see if the EventMessage property is set.
        /// </summary>
        internal bool IsSetEventMessage() => this.EventMessage != null;

        /// <summary>
        /// Gets and sets the property EventNumber. 
        /// <para>
        /// The event number.
        /// </para>
        /// </summary>
        public long? EventNumber { get; set; }

        /// <summary>
        /// Checks to see if the EventNumber property is set.
        /// </summary>
        internal bool IsSetEventNumber() => this.EventNumber.HasValue;

        /// <summary>
        /// Gets and sets the property TransformedEventMessage. 
        /// <para>
        /// The log event message after being transformed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TransformedEventMessage { get; set; }

        /// <summary>
        /// Checks to see if the TransformedEventMessage property is set.
        /// </summary>
        internal bool IsSetTransformedEventMessage() => this.TransformedEventMessage != null;
    }
}
