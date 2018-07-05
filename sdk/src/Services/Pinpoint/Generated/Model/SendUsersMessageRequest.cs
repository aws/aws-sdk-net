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
    public partial class SendUsersMessageRequest
    {
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private DirectMessageConfiguration _messageConfiguration;
        private Dictionary<string, EndpointSendConfiguration> _users = new Dictionary<string, EndpointSendConfiguration>();

        /// <summary>
        /// Gets and sets the property Context. A map of custom attribute-value pairs. Amazon
        /// Pinpoint adds these attributes to the data.pinpoint object in the body of the push
        /// notification payload. Amazon Pinpoint also provides these attributes in the events
        /// that it generates for users-messages deliveries.
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
        /// Gets and sets the property MessageConfiguration. Message definitions for the default
        /// message and any messages that are tailored for specific channels.
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

        /// <summary>
        /// Gets and sets the property Users. A map that associates user IDs with EndpointSendConfiguration
        /// objects. Within an EndpointSendConfiguration object, you can tailor the message for
        /// a user by specifying message overrides or substitutions.
        /// </summary>
        public Dictionary<string, EndpointSendConfiguration> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && this._users.Count > 0; 
        }

    }
}