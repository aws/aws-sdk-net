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
    /// protocol in caller mode, including the source address and port, minimum latency, stream
    /// ID, and decryption key configuration.
    /// </summary>
    public partial class SrtCallerRouterInputConfiguration
    {
        private SrtDecryptionConfiguration _decryptionConfiguration;
        private long? _minimumLatencyMilliseconds;
        private string _sourceAddress;
        private int? _sourcePort;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property DecryptionConfiguration. 
        /// <para>
        /// Specifies the decryption settings for an SRT caller input, including the encryption
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
        /// The minimum latency in milliseconds for the SRT protocol in caller mode.
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
        /// Gets and sets the property SourceAddress. 
        /// <para>
        /// The source IP address for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceAddress
        {
            get { return this._sourceAddress; }
            set { this._sourceAddress = value; }
        }

        // Check to see if SourceAddress property is set
        internal bool IsSetSourceAddress()
        {
            return this._sourceAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port number for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int SourcePort
        {
            get { return this._sourcePort.GetValueOrDefault(); }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}