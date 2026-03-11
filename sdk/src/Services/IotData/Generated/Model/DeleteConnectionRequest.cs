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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
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
namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConnection operation.
    /// Disconnects a connected MQTT client from Amazon Web Services IoT Core. When you disconnect
    /// a client, Amazon Web Services IoT Core closes the client's network connection and
    /// optionally cleans the session state.
    /// </summary>
    public partial class DeleteConnectionRequest : AmazonIotDataRequest
    {
        private bool? _cleanSession;
        private string _clientId;
        private bool? _preventWillMessage;

        /// <summary>
        /// Gets and sets the property CleanSession. 
        /// <para>
        /// Specifies whether to remove the client's session state when disconnecting. Set to
        /// <c>TRUE</c> to delete all session information, including subscriptions and queued
        /// messages. Set to <c>FALSE</c> to preserve the session state. By default, this is set
        /// to <c>FALSE</c> (preserves the session state).
        /// </para>
        /// </summary>
        public bool? CleanSession
        {
            get { return this._cleanSession; }
            set { this._cleanSession = value; }
        }

        // Check to see if CleanSession property is set
        internal bool IsSetCleanSession()
        {
            return this._cleanSession.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client to disconnect. The client ID can't start
        /// with a dollar sign ($).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property PreventWillMessage. 
        /// <para>
        /// Controls if Amazon Web Services IoT Core publishes the client's Last Will and Testament
        /// (LWT) message upon disconnection. Set to <c>TRUE</c> to prevent publishing the LWT
        /// message. Set to <c>FALSE</c> to allow publishing. By default, this is set to <c>FALSE</c>
        /// (allows publishing the LWT message).
        /// </para>
        /// </summary>
        public bool? PreventWillMessage
        {
            get { return this._preventWillMessage; }
            set { this._preventWillMessage = value; }
        }

        // Check to see if PreventWillMessage property is set
        internal bool IsSetPreventWillMessage()
        {
            return this._preventWillMessage.HasValue; 
        }

    }
}