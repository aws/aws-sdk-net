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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains a part of an agent response and citations for it.
    /// </summary>
    public partial class PayloadPart : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Attribution. 
        /// <para>
        /// Contains citations for a part of an agent response.
        /// </para>
        /// </summary>
        public Attribution Attribution { get; set; }

        /// <summary>
        /// Checks to see if the Attribution property is set.
        /// </summary>
        internal bool IsSetAttribution() => this.Attribution != null;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// A part of the agent response in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000000)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;
    }
}
