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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The type-specific configuration for a gateway that you provide when you create it.
    /// Exactly one variant is set, and it determines the gateway type.
    /// </summary>
    public partial class GatewayConfiguration
    {
        /// <summary>
        /// Gets and sets the property HostSharedAlb. 
        /// <para>
        /// The configuration for a host-based, shared Application Load Balancer gateway. Each
        /// service that uses the gateway is assigned a unique DNS host name.
        /// </para>
        /// </summary>
        public HostSharedAlbConfiguration HostSharedAlb { get; set; }

        /// <summary>
        /// Checks to see if the HostSharedAlb property is set.
        /// </summary>
        internal bool IsSetHostSharedAlb() => this.HostSharedAlb != null;
    }
}
