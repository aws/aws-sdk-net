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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The connectivity status of the thing.
    /// </summary>
    public partial class ThingConnectivity
    {
        /// <summary>
        /// Gets and sets the property CleanSession. 
        /// <para>
        /// Indicates whether the client is using a clean session. Returns <c>true</c> for clean
        /// sessions.
        /// </para>
        /// </summary>
        public bool? CleanSession { get; set; }

        /// <summary>
        /// Checks to see if the CleanSession property is set.
        /// </summary>
        internal bool IsSetCleanSession() => this.CleanSession.HasValue;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Connected. 
        /// <para>
        /// True if the thing is connected to the Amazon Web Services IoT Core service; false
        /// if it is not connected.
        /// </para>
        /// </summary>
        public bool? Connected { get; set; }

        /// <summary>
        /// Checks to see if the Connected property is set.
        /// </summary>
        internal bool IsSetConnected() => this.Connected.HasValue;

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason that the client is disconnected.
        /// </para>
        /// </summary>
        public string DisconnectReason { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectReason property is set.
        /// </summary>
        internal bool IsSetDisconnectReason() => this.DisconnectReason != null;

        /// <summary>
        /// Gets and sets the property KeepAliveDuration. 
        /// <para>
        /// The keep-alive interval in seconds that the client specified when establishing the
        /// connection.
        /// </para>
        /// </summary>
        public int? KeepAliveDuration { get; set; }

        /// <summary>
        /// Checks to see if the KeepAliveDuration property is set.
        /// </summary>
        internal bool IsSetKeepAliveDuration() => this.KeepAliveDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SessionExpiry. 
        /// <para>
        /// The session expiry interval in seconds for the MQTT client connection. This value
        /// indicates how long the session will remain active after the client disconnects.
        /// </para>
        /// </summary>
        public long? SessionExpiry { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpiry property is set.
        /// </summary>
        internal bool IsSetSessionExpiry() => this.SessionExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The epoch time (in milliseconds) when the thing last connected or disconnected.
        /// </para>
        /// </summary>
        public long? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
