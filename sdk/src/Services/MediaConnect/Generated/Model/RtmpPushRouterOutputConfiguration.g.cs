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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The configuration settings for a router output that pushes a stream to a destination
    /// using the RTMP (Real-Time Messaging Protocol) protocol, or RTMPS (RTMP over TLS) when
    /// TLS encryption is specified. These settings include the destination address and port,
    /// the application and stream names, and optional TLS encryption configuration.
    /// </summary>
    public partial class RtmpPushRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the RTMP application on the destination server. Together with the stream
        /// name, the application name forms the RTMP URL path, in the pattern <c>rtmp://destinationAddress/applicationName/streamName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The IP address or hostname of the destination RTMP server that the router output pushes
        /// the stream to. Provide only the server address; specify the application and stream
        /// names separately.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAddress property is set.
        /// </summary>
        internal bool IsSetDestinationAddress() => this.DestinationAddress != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The TCP port on the destination RTMP server. For RTMP, valid values range from <c>1024</c>
        /// to <c>65535</c>. For RTMPS (RTMP over TLS), valid values are <c>443</c> or <c>1024</c>
        /// to <c>65535</c>. RTMP typically uses port <c>1935</c>, and RTMPS typically uses port
        /// <c>443</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 443, Max = 65535)]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the RTMP stream that the output publishes to the destination application.
        /// The stream name forms the final segment of the RTMP URL path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property TlsEncryption. 
        /// <para>
        /// The TLS encryption settings for the output. When you specify these settings, the output
        /// uses RTMPS (RTMP over TLS) to establish a secure, encrypted connection to the destination
        /// server.
        /// </para>
        /// </summary>
        public TlsEncryption TlsEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TlsEncryption property is set.
        /// </summary>
        internal bool IsSetTlsEncryption() => this.TlsEncryption != null;
    }
}
