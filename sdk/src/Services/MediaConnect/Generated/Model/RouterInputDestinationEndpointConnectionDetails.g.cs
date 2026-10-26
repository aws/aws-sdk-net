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
    /// The connection details for a destination endpoint that represents a router input.
    /// </summary>
    public partial class RouterInputDestinationEndpointConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property SourceEncryptionConfiguration.
        /// </summary>
        public EndpointEncryptionConfiguration SourceEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceEncryptionConfiguration() => this.SourceEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceEncryptionType. 
        /// <para>
        /// The type of encryption that the source uses for the connection.
        /// </para>
        /// </summary>
        public EndpointEncryptionType SourceEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the SourceEncryptionType property is set.
        /// </summary>
        internal bool IsSetSourceEncryptionType() => this.SourceEncryptionType != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointType. 
        /// <para>
        /// The type of the connected source endpoint.
        /// </para>
        /// </summary>
        public SourceEndpointType SourceEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointType property is set.
        /// </summary>
        internal bool IsSetSourceEndpointType() => this.SourceEndpointType != null;
    }
}
