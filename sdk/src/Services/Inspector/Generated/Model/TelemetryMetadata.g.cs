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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// The metadata about the Amazon Inspector application data metrics collected by the
    /// agent. This data type is used as the response element in the <a>GetTelemetryMetadata</a>
    /// action.
    /// </summary>
    public partial class TelemetryMetadata
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The count of messages that the agent sends to the Amazon Inspector service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DataSize. 
        /// <para>
        /// The data size of messages that the agent sends to the Amazon Inspector service.
        /// </para>
        /// </summary>
        public long? DataSize { get; set; }

        /// <summary>
        /// Checks to see if the DataSize property is set.
        /// </summary>
        internal bool IsSetDataSize() => this.DataSize.HasValue;

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// A specific type of behavioral data that is collected by the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;
    }
}
