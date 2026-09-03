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
    /// The configuration settings for a router output using the RTP (Real-Time Transport
    /// Protocol) protocol, including the destination address and port, and forward error
    /// correction state.
    /// </summary>
    public partial class RtpRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The destination IP address for the RTP protocol in the router output configuration.
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
        /// The destination port number for the RTP protocol in the router output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 65531)]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property ForwardErrorCorrection. 
        /// <para>
        /// The state of forward error correction for the RTP protocol in the router output configuration.
        /// </para>
        /// </summary>
        public ForwardErrorCorrectionState ForwardErrorCorrection { get; set; }

        /// <summary>
        /// Checks to see if the ForwardErrorCorrection property is set.
        /// </summary>
        internal bool IsSetForwardErrorCorrection() => this.ForwardErrorCorrection != null;
    }
}
