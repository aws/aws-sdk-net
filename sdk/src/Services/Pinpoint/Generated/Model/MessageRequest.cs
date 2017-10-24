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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Send message request.
    /// </summary>
    public partial class MessageRequest
    {
        private Dictionary<string, AddressConfiguration> _addresses = new Dictionary<string, AddressConfiguration>();
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private Dictionary<string, EndpointSendConfiguration> _endpoints = new Dictionary<string, EndpointSendConfiguration>();
        private DirectMessageConfiguration _messageConfiguration;

        /// <summary>
        /// Gets and sets the property Addresses. A map of destination addresses, with the address
        /// as the key(Email address, phone number or push token) and the Address Configuration
        /// as the value.
        /// </summary>
        public Dictionary<string, AddressConfiguration> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && this._addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Context. A map of custom attributes to attributes to be
        /// attached to the message. This payload is added to the push notification's 'data.pinpoint'
        /// object or added to the email/sms delivery receipt event attributes.
        /// </summary>
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && this._context.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. A map of destination addresses, with the address
        /// as the key(Email address, phone number or push token) and the Address Configuration
        /// as the value.
        /// </summary>
        public Dictionary<string, EndpointSendConfiguration> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MessageConfiguration. Message configuration.
        /// </summary>
        public DirectMessageConfiguration MessageConfiguration
        {
            get { return this._messageConfiguration; }
            set { this._messageConfiguration = value; }
        }

        // Check to see if MessageConfiguration property is set
        internal bool IsSetMessageConfiguration()
        {
            return this._messageConfiguration != null;
        }

    }
}