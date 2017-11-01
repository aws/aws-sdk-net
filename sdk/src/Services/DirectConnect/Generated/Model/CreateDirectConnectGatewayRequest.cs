/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDirectConnectGateway operation.
    /// Creates a new direct connect gateway. A direct connect gateway is an intermediate
    /// object that enables you to connect a set of virtual interfaces and virtual private
    /// gateways. direct connect gateways are global and visible in any AWS region after they
    /// are created. The virtual interfaces and virtual private gateways that are connected
    /// through a direct connect gateway can be in different regions. This enables you to
    /// connect to a VPC in any region, regardless of the region in which the virtual interfaces
    /// are located, and pass traffic between them.
    /// </summary>
    public partial class CreateDirectConnectGatewayRequest : AmazonDirectConnectRequest
    {
        private long? _amazonSideAsn;
        private string _directConnectGatewayName;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The autonomous system number (ASN) for Border Gateway Protocol (BGP) to be configured
        /// on the Amazon side of the connection. The ASN must be in the private range of 64,512
        /// to 65,534 or 4,200,000,000 to 4,294,967,294 
        /// </para>
        ///  
        /// <para>
        /// Example: 65200
        /// </para>
        ///  
        /// <para>
        /// Default: 64512
        /// </para>
        /// </summary>
        public long AmazonSideAsn
        {
            get { return this._amazonSideAsn.GetValueOrDefault(); }
            set { this._amazonSideAsn = value; }
        }

        // Check to see if AmazonSideAsn property is set
        internal bool IsSetAmazonSideAsn()
        {
            return this._amazonSideAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayName. 
        /// <para>
        /// The name of the direct connect gateway.
        /// </para>
        ///  
        /// <para>
        /// Example: "My direct connect gateway"
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public string DirectConnectGatewayName
        {
            get { return this._directConnectGatewayName; }
            set { this._directConnectGatewayName = value; }
        }

        // Check to see if DirectConnectGatewayName property is set
        internal bool IsSetDirectConnectGatewayName()
        {
            return this._directConnectGatewayName != null;
        }

    }
}