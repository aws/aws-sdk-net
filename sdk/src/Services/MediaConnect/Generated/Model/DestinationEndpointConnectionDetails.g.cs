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
    /// The connection details for a destination endpoint. After the destination endpoint
    /// connects to a source endpoint, MediaConnect populates these details to describe the
    /// connected source. This is a union type, so exactly one of its members is set, depending
    /// on the destination endpoint type.
    /// </summary>
    public partial class DestinationEndpointConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property RouterInput. 
        /// <para>
        /// The connection details for a destination endpoint that represents a router input.
        /// </para>
        /// </summary>
        public RouterInputDestinationEndpointConnectionDetails RouterInput { get; set; }

        /// <summary>
        /// Checks to see if the RouterInput property is set.
        /// </summary>
        internal bool IsSetRouterInput() => this.RouterInput != null;

        /// <summary>
        /// Gets and sets the property Standard. 
        /// <para>
        /// The connection details for a standard destination endpoint.
        /// </para>
        /// </summary>
        public StandardDestinationEndpointConnectionDetails Standard { get; set; }

        /// <summary>
        /// Checks to see if the Standard property is set.
        /// </summary>
        internal bool IsSetStandard() => this.Standard != null;
    }
}
