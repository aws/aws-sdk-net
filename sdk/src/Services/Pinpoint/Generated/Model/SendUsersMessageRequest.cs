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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the configuration and other settings for a message to send to all the endpoints
    /// that are associated with a list of users.
    /// </summary>
    public partial class SendUsersMessageRequest
    {
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private DirectMessageConfiguration _messageConfiguration;
        private TemplateConfiguration _templateConfiguration;
        private string _traceId;
        private Dictionary<string, EndpointSendConfiguration> _users = new Dictionary<string, EndpointSendConfiguration>();

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// A map of custom attribute-value pairs. For a push notification, Amazon Pinpoint adds
        /// these attributes to the data.pinpoint object in the body of the notification payload.
        /// Amazon Pinpoint also provides these attributes in the events that it generates for
        /// users-messages deliveries.
        /// </para>
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
        /// Gets and sets the property MessageConfiguration. 
        /// <para>
        /// The settings and content for the default message and any default messages that you
        /// defined for specific channels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template to use for the message.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The unique identifier for tracing the message. This identifier is visible to message
        /// recipients.
        /// </para>
        /// </summary>
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// A map that associates user IDs with <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/apps-application-id-messages.html#apps-application-id-messages-model-endpointsendconfiguration">EndpointSendConfiguration</a>
        /// objects. You can use an <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/apps-application-id-messages.html#apps-application-id-messages-model-endpointsendconfiguration">EndpointSendConfiguration</a>
        /// object to tailor the message for a user by specifying settings such as content overrides
        /// and message variables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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