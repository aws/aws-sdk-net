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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProxyNetworkConfiguration operation. Updates
    /// the network configuration for the specified proxy.
    /// </summary>
    public partial class UpdateProxyNetworkConfigurationRequest : AmazonELBProxyRequest
    {
        /// <summary>
        /// Gets and sets the property ProxyIdentifier. The Amazon Resource Name (ARN) of the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProxyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProxyIdentifier property is set.
        /// </summary>
        internal bool IsSetProxyIdentifier() => this.ProxyIdentifier != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. The updated VPC configuration for the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateProxyVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
