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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private bool? _connected;
        private string _disconnectReason;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property Connected. 
        /// <para>
        /// True if the thing is connected to the Amazon Web Services IoT Core service; false
        /// if it is not connected.
        /// </para>
        /// </summary>
        public bool? Connected
        {
            get { return this._connected; }
            set { this._connected = value; }
        }

        // Check to see if Connected property is set
        internal bool IsSetConnected()
        {
            return this._connected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason why the client is disconnected. If the thing has been disconnected for
        /// approximately an hour, the <c>disconnectReason</c> value might be missing.
        /// </para>
        /// </summary>
        public string DisconnectReason
        {
            get { return this._disconnectReason; }
            set { this._disconnectReason = value; }
        }

        // Check to see if DisconnectReason property is set
        internal bool IsSetDisconnectReason()
        {
            return this._disconnectReason != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The epoch time (in milliseconds) when the thing last connected or disconnected. If
        /// the thing has been disconnected for approximately an hour, the time value might be
        /// missing.
        /// </para>
        /// </summary>
        public long? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}