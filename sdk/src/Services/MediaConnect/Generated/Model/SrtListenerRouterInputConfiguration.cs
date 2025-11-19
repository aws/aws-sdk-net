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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The configuration settings for a router input using the SRT (Secure Reliable Transport)
    /// protocol in listener mode, including the port, minimum latency, and decryption key
    /// configuration.
    /// </summary>
    public partial class SrtListenerRouterInputConfiguration
    {
        private SrtDecryptionConfiguration _decryptionConfiguration;
        private long? _minimumLatencyMilliseconds;
        private int? _port;

        /// <summary>
        /// Gets and sets the property DecryptionConfiguration. 
        /// <para>
        /// Specifies the decryption settings for an SRT listener input, including the encryption
        /// key configuration and associated parameters.
        /// </para>
        /// </summary>
        public SrtDecryptionConfiguration DecryptionConfiguration
        {
            get { return this._decryptionConfiguration; }
            set { this._decryptionConfiguration = value; }
        }

        // Check to see if DecryptionConfiguration property is set
        internal bool IsSetDecryptionConfiguration()
        {
            return this._decryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLatencyMilliseconds. 
        /// <para>
        /// The minimum latency in milliseconds for the SRT protocol in listener mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10000)]
        public long MinimumLatencyMilliseconds
        {
            get { return this._minimumLatencyMilliseconds.GetValueOrDefault(); }
            set { this._minimumLatencyMilliseconds = value; }
        }

        // Check to see if MinimumLatencyMilliseconds property is set
        internal bool IsSetMinimumLatencyMilliseconds()
        {
            return this._minimumLatencyMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the SRT protocol in listener mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3000, Max=30000)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}