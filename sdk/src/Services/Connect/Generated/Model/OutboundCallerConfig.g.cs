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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The outbound caller ID name, number, and outbound whisper flow.
    /// </summary>
    public partial class OutboundCallerConfig
    {
        /// <summary>
        /// Gets and sets the property OutboundCallerIdName. 
        /// <para>
        /// The caller ID name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OutboundCallerIdName { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallerIdName property is set.
        /// </summary>
        internal bool IsSetOutboundCallerIdName() => this.OutboundCallerIdName != null;

        /// <summary>
        /// Gets and sets the property OutboundCallerIdNumberId. 
        /// <para>
        /// The caller ID number.
        /// </para>
        /// </summary>
        public string OutboundCallerIdNumberId { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallerIdNumberId property is set.
        /// </summary>
        internal bool IsSetOutboundCallerIdNumberId() => this.OutboundCallerIdNumberId != null;

        /// <summary>
        /// Gets and sets the property OutboundFlowId. 
        /// <para>
        /// The outbound whisper flow to be used during an outbound call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string OutboundFlowId { get; set; }

        /// <summary>
        /// Checks to see if the OutboundFlowId property is set.
        /// </summary>
        internal bool IsSetOutboundFlowId() => this.OutboundFlowId != null;
    }
}
