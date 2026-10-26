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
    /// The protocol configuration for a standard destination endpoint. This is a union type,
    /// so exactly one of its members is set, depending on the protocol that the destination
    /// endpoint uses.
    /// </summary>
    public partial class StandardDestinationEndpointProtocolConfiguration
    {
        /// <summary>
        /// Gets and sets the property Rist. 
        /// <para>
        /// The configuration settings for a destination endpoint that uses the RIST protocol.
        /// </para>
        /// </summary>
        public RistStandardDestinationEndpointConfiguration Rist { get; set; }

        /// <summary>
        /// Checks to see if the Rist property is set.
        /// </summary>
        internal bool IsSetRist() => this.Rist != null;

        /// <summary>
        /// Gets and sets the property Rtp. 
        /// <para>
        /// The configuration settings for a destination endpoint that uses the RTP protocol.
        /// </para>
        /// </summary>
        public RtpStandardDestinationEndpointConfiguration Rtp { get; set; }

        /// <summary>
        /// Checks to see if the Rtp property is set.
        /// </summary>
        internal bool IsSetRtp() => this.Rtp != null;

        /// <summary>
        /// Gets and sets the property SrtCaller. 
        /// <para>
        /// The configuration settings for a destination endpoint that uses SRT in caller mode.
        /// </para>
        /// </summary>
        public SrtCallerStandardDestinationEndpointConfiguration SrtCaller { get; set; }

        /// <summary>
        /// Checks to see if the SrtCaller property is set.
        /// </summary>
        internal bool IsSetSrtCaller() => this.SrtCaller != null;

        /// <summary>
        /// Gets and sets the property SrtListener. 
        /// <para>
        /// The configuration settings for a destination endpoint that uses SRT in listener mode.
        /// </para>
        /// </summary>
        public SrtListenerStandardDestinationEndpointConfiguration SrtListener { get; set; }

        /// <summary>
        /// Checks to see if the SrtListener property is set.
        /// </summary>
        internal bool IsSetSrtListener() => this.SrtListener != null;
    }
}
