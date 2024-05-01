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
    /// The outbound caller ID name, number, and outbound whisper flow.
    /// </summary>
    public partial class OutboundCallerConfig
    {
        private string _outboundCallerIdName;
        private string _outboundCallerIdNumberId;
        private string _outboundFlowId;

        /// <summary>
        /// Gets and sets the property OutboundCallerIdName. 
        /// <para>
        /// The caller ID name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutboundCallerIdName
        {
            get { return this._outboundCallerIdName; }
            set { this._outboundCallerIdName = value; }
        }

        // Check to see if OutboundCallerIdName property is set
        internal bool IsSetOutboundCallerIdName()
        {
            return this._outboundCallerIdName != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallerIdNumberId. 
        /// <para>
        /// The caller ID number.
        /// </para>
        /// </summary>
        public string OutboundCallerIdNumberId
        {
            get { return this._outboundCallerIdNumberId; }
            set { this._outboundCallerIdNumberId = value; }
        }

        // Check to see if OutboundCallerIdNumberId property is set
        internal bool IsSetOutboundCallerIdNumberId()
        {
            return this._outboundCallerIdNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundFlowId. 
        /// <para>
        /// The outbound whisper flow to be used during an outbound call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string OutboundFlowId
        {
            get { return this._outboundFlowId; }
            set { this._outboundFlowId = value; }
        }

        // Check to see if OutboundFlowId property is set
        internal bool IsSetOutboundFlowId()
        {
            return this._outboundFlowId != null;
        }

    }
}