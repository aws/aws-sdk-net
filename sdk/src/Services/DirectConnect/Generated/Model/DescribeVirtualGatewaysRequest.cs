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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVirtualGateways operation.
    /// <note> 
    /// <para>
    /// Deprecated. Use <c>DescribeVpnGateways</c> instead. See <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnGateways.html">DescribeVPNGateways</a>
    /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Lists the virtual private gateways owned by the Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
    /// private gateway.
    /// </para>
    /// </summary>
    public partial class DescribeVirtualGatewaysRequest : AmazonDirectConnectRequest
    {

    }
}