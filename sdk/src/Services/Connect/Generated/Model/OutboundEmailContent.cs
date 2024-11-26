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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private OutboundMessageSourceType _messageSourceType;
        private OutboundRawMessage _rawMessage;
        private TemplatedMessageConfig _templatedMessageConfig;

        /// <summary>
        /// Gets and sets the property MessageSourceType. 
        /// <para>
        /// The message source type, that is, <c>RAW</c> or <c>TEMPLATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutboundMessageSourceType MessageSourceType
        {
            get { return this._messageSourceType; }
            set { this._messageSourceType = value; }
        }

        // Check to see if MessageSourceType property is set
        internal bool IsSetMessageSourceType()
        {
            return this._messageSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RawMessage. 
        /// <para>
        /// The raw email body content.
        /// </para>
        /// </summary>
        public OutboundRawMessage RawMessage
        {
            get { return this._rawMessage; }
            set { this._rawMessage = value; }
        }

        // Check to see if RawMessage property is set
        internal bool IsSetRawMessage()
        {
            return this._rawMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TemplatedMessageConfig. 
        /// <para>
        /// Information about template message configuration.
        /// </para>
        /// </summary>
        public TemplatedMessageConfig TemplatedMessageConfig
        {
            get { return this._templatedMessageConfig; }
            set { this._templatedMessageConfig = value; }
        }

        // Check to see if TemplatedMessageConfig property is set
        internal bool IsSetTemplatedMessageConfig()
        {
            return this._templatedMessageConfig != null;
        }

    }
}