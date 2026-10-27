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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The network configuration for a code interpreter. This structure defines how the code
    /// interpreter connects to the network.
    /// </summary>
    public partial class CodeInterpreterNetworkConfiguration
    {
        /// <summary>
        /// Gets and sets the property NetworkMode. 
        /// <para>
        /// The network mode for the code interpreter. This field specifies how the code interpreter
        /// connects to the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeInterpreterNetworkMode NetworkMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMode property is set.
        /// </summary>
        internal bool IsSetNetworkMode() => this.NetworkMode != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the code interpreter. This configuration is required when
        /// the network mode is set to <c>VPC</c>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
