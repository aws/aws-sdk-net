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
    /// The configuration settings for a destination endpoint that uses the RIST protocol.
    /// </summary>
    public partial class RistStandardDestinationEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The IP address on which the destination endpoint receives content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAddress property is set.
        /// </summary>
        internal bool IsSetDestinationAddress() => this.DestinationAddress != null;

        /// <summary>
        /// Gets and sets the property DestinationIngestPort. 
        /// <para>
        /// The port on which the destination endpoint receives content. The valid range is 1024
        /// to 65531.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 65531)]
        public int? DestinationIngestPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIngestPort property is set.
        /// </summary>
        internal bool IsSetDestinationIngestPort() => this.DestinationIngestPort.HasValue;
    }
}
