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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
        private PrivateNetworkConfiguration _privateNetworkConfiguration;
        private PublicNetworkConfiguration _publicNetworkConfiguration;

        /// <summary>
        /// Gets and sets the property PrivateNetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the private ingress point.
        /// </para>
        /// </summary>
        public PrivateNetworkConfiguration PrivateNetworkConfiguration
        {
            get { return this._privateNetworkConfiguration; }
            set { this._privateNetworkConfiguration = value; }
        }

        // Check to see if PrivateNetworkConfiguration property is set
        internal bool IsSetPrivateNetworkConfiguration()
        {
            return this._privateNetworkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PublicNetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the public ingress point.
        /// </para>
        /// </summary>
        public PublicNetworkConfiguration PublicNetworkConfiguration
        {
            get { return this._publicNetworkConfiguration; }
            set { this._publicNetworkConfiguration = value; }
        }

        // Check to see if PublicNetworkConfiguration property is set
        internal bool IsSetPublicNetworkConfiguration()
        {
            return this._publicNetworkConfiguration != null;
        }

    }
}