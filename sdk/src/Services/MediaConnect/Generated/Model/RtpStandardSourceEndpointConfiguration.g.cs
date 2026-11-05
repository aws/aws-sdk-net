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
    /// The configuration settings for a source endpoint that uses the RTP protocol.
    /// </summary>
    public partial class RtpStandardSourceEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationIngestPort. 
        /// <para>
        /// The port on the destination that receives the content. The valid range is 3000 to
        /// 30000.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3000, Max = 30000)]
        public int? DestinationIngestPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIngestPort property is set.
        /// </summary>
        internal bool IsSetDestinationIngestPort() => this.DestinationIngestPort.HasValue;

        /// <summary>
        /// Gets and sets the property ForwardErrorCorrectionState. 
        /// <para>
        /// Indicates whether forward error correction (FEC) is enabled for the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ForwardErrorCorrectionState ForwardErrorCorrectionState { get; set; }

        /// <summary>
        /// Checks to see if the ForwardErrorCorrectionState property is set.
        /// </summary>
        internal bool IsSetForwardErrorCorrectionState() => this.ForwardErrorCorrectionState != null;
    }
}
