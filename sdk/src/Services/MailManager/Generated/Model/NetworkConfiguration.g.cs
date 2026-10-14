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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The network type (IPv4-only, Dual-Stack, PrivateLink) of the ingress endpoint resource.
    /// </summary>
    public partial class NetworkConfiguration
    {
        /// <summary>
        /// Gets and sets the property PrivateNetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the private ingress point.
        /// </para>
        /// </summary>
        public PrivateNetworkConfiguration PrivateNetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PrivateNetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetPrivateNetworkConfiguration() => this.PrivateNetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PublicNetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the public ingress point.
        /// </para>
        /// </summary>
        public PublicNetworkConfiguration PublicNetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PublicNetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetPublicNetworkConfiguration() => this.PublicNetworkConfiguration != null;
    }
}
