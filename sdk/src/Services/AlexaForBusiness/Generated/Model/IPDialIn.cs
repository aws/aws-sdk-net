/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The IP endpoint and protocol for calling.
    /// </summary>
    public partial class IPDialIn
    {
        private CommsProtocol _commsProtocol;
        private string _endpoint;

        /// <summary>
        /// Gets and sets the property CommsProtocol. 
        /// <para>
        /// The protocol, including SIP, SIPS, and H323.
        /// </para>
        /// </summary>
        public CommsProtocol CommsProtocol
        {
            get { return this._commsProtocol; }
            set { this._commsProtocol = value; }
        }

        // Check to see if CommsProtocol property is set
        internal bool IsSetCommsProtocol()
        {
            return this._commsProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

    }
}