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
    /// The connection details for a source endpoint that represents a router output.
    /// </summary>
    public partial class RouterOutputSourceEndpointConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property DestinationDecryptionConfiguration.
        /// </summary>
        public EndpointEncryptionConfiguration DestinationDecryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDecryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationDecryptionConfiguration() => this.DestinationDecryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DestinationDecryptionType. 
        /// <para>
        /// The type of decryption that the destination uses for the connection.
        /// </para>
        /// </summary>
        public EndpointEncryptionType DestinationDecryptionType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDecryptionType property is set.
        /// </summary>
        internal bool IsSetDestinationDecryptionType() => this.DestinationDecryptionType != null;

        /// <summary>
        /// Gets and sets the property DestinationEndpointType. 
        /// <para>
        /// The type of the connected destination endpoint.
        /// </para>
        /// </summary>
        public DestinationEndpointType DestinationEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEndpointType property is set.
        /// </summary>
        internal bool IsSetDestinationEndpointType() => this.DestinationEndpointType != null;
    }
}
