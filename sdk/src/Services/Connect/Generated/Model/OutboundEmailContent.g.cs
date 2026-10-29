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
    /// Information about email body content.
    /// </summary>
    public partial class OutboundEmailContent
    {
        /// <summary>
        /// Gets and sets the property MessageSourceType. 
        /// <para>
        /// The message source type, that is, <c>RAW</c> or <c>TEMPLATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutboundMessageSourceType MessageSourceType { get; set; }

        /// <summary>
        /// Checks to see if the MessageSourceType property is set.
        /// </summary>
        internal bool IsSetMessageSourceType() => this.MessageSourceType != null;

        /// <summary>
        /// Gets and sets the property RawMessage. 
        /// <para>
        /// The raw email body content.
        /// </para>
        /// </summary>
        public OutboundRawMessage RawMessage { get; set; }

        /// <summary>
        /// Checks to see if the RawMessage property is set.
        /// </summary>
        internal bool IsSetRawMessage() => this.RawMessage != null;

        /// <summary>
        /// Gets and sets the property TemplatedMessageConfig. 
        /// <para>
        /// Information about template message configuration.
        /// </para>
        /// </summary>
        public TemplatedMessageConfig TemplatedMessageConfig { get; set; }

        /// <summary>
        /// Checks to see if the TemplatedMessageConfig property is set.
        /// </summary>
        internal bool IsSetTemplatedMessageConfig() => this.TemplatedMessageConfig != null;
    }
}
