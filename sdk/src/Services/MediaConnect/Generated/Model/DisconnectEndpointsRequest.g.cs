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
    /// Container for the parameters to the DisconnectEndpoints operation. Disconnects a source
    /// endpoint from a destination endpoint.
    /// </summary>
    public partial class DisconnectEndpointsRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination endpoint to disconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 128)]
        public string DestinationEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEndpointArn property is set.
        /// </summary>
        internal bool IsSetDestinationEndpointArn() => this.DestinationEndpointArn != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint to disconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 128)]
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;
    }
}
