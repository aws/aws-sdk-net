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
    /// The networking configuration for a standard destination endpoint. This is a union
    /// type, so exactly one of its members is set: <c>public</c> for a publicly accessible
    /// endpoint, or <c>vpc</c> for an endpoint in a virtual private cloud (VPC).
    /// </summary>
    public partial class StandardDestinationEndpointNetworkingConfiguration
    {
        /// <summary>
        /// Gets and sets the property Public. 
        /// <para>
        /// The configuration for a publicly accessible destination endpoint.
        /// </para>
        /// </summary>
        public PublicDestinationEndpointNetworkingConfiguration Public { get; set; }

        /// <summary>
        /// Checks to see if the Public property is set.
        /// </summary>
        internal bool IsSetPublic() => this.Public != null;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The configuration for a destination endpoint in a virtual private cloud (VPC).
        /// </para>
        /// </summary>
        public VpcDestinationEndpointNetworkingConfiguration Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
