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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the XmlAttributesInMiddle operation.
    /// This example serializes an XML attribute on a payload when it's defined in the middle
    /// of the member list. This tests that implementations correctly write attributes immediately
    /// after the element start tag, which is critical for languages like C# where attribute
    /// writing must happen before child elements.
    /// </summary>
    public partial class XmlAttributesInMiddleRequest : AmazonRestXmlProtocolRequest
    {
        private XmlAttributesInMiddlePayloadRequest _payload;

        /// <summary>
        /// Gets and sets the property Payload.
        /// </summary>
        public XmlAttributesInMiddlePayloadRequest Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

    }
}