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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateCustomerGateway operation. Disassociates
    /// a customer gateway from a device and a link.
    /// </summary>
    public partial class DisassociateCustomerGatewayRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CustomerGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string CustomerGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayArn property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayArn() => this.CustomerGatewayArn != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;
    }
}
