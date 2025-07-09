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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains the details for an Outbound EDI capability.
    /// </summary>
    public partial class CapabilityOptions
    {
        private InboundEdiOptions _inboundEdi;
        private OutboundEdiOptions _outboundEdi;

        /// <summary>
        /// Gets and sets the property InboundEdi. 
        /// <para>
        /// A structure that contains the inbound EDI options for the capability.
        /// </para>
        /// </summary>
        public InboundEdiOptions InboundEdi
        {
            get { return this._inboundEdi; }
            set { this._inboundEdi = value; }
        }

        // Check to see if InboundEdi property is set
        internal bool IsSetInboundEdi()
        {
            return this._inboundEdi != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundEdi. 
        /// <para>
        /// A structure that contains the outbound EDI options.
        /// </para>
        /// </summary>
        public OutboundEdiOptions OutboundEdi
        {
            get { return this._outboundEdi; }
            set { this._outboundEdi = value; }
        }

        // Check to see if OutboundEdi property is set
        internal bool IsSetOutboundEdi()
        {
            return this._outboundEdi != null;
        }

    }
}