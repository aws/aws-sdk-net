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
    /// Configuration settings for persistent connection for a specific channel.
    /// </summary>
    public partial class PersistentConnectionConfig
    {
        private Channel _channel;
        private bool? _persistentConnection;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// Configuration settings for persistent connection. <b>Only <c>VOICE</c> is supported
        /// for this data type.</b> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentConnection. 
        /// <para>
        /// Indicates whether persistent connection is enabled. When enabled, the agent's connection
        /// is maintained after a call ends, enabling subsequent calls to connect faster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PersistentConnection
        {
            get { return this._persistentConnection; }
            set { this._persistentConnection = value; }
        }

        // Check to see if PersistentConnection property is set
        internal bool IsSetPersistentConnection()
        {
            return this._persistentConnection.HasValue; 
        }

    }
}