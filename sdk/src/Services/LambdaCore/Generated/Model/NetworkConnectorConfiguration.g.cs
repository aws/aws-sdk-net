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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// The network configuration for a network connector. Different connector types use different
    /// configuration shapes; specify the configuration that matches your connector type.
    /// </summary>
    public partial class NetworkConnectorConfiguration
    {
        /// <summary>
        /// Gets and sets the property VpcEgressConfiguration. 
        /// <para>
        /// Configuration for a VPC egress network connector. Specifies the subnets, security
        /// groups, and network protocol for routing outbound traffic through your VPC.
        /// </para>
        /// </summary>
        public NetworkConnectorVpcEgressConfiguration VpcEgressConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcEgressConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcEgressConfiguration() => this.VpcEgressConfiguration != null;
    }
}
