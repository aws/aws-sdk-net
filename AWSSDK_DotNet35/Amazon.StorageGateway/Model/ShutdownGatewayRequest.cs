/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ShutdownGateway operation.
    /// <para>This operation shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource Name (ARN) of the gateway in the
    /// body of your request.</para> <para>The operation shuts down the gateway service component running in the storage gateway's virtual machine
    /// (VM) and not the VM.</para> <para><b>NOTE:</b>If you want to shut down the VM, it is recommended that you first shut down the gateway
    /// component in the VM to avoid unpredictable conditions.</para> <para>After the gateway is shutdown, you cannot call any other API except
    /// StartGateway, DescribeGatewayInformation, and ListGateways. For more information, see ActivateGateway. Your applications cannot read from or
    /// write to the gateway's storage volumes, and there are no snapshots taken.</para> <para><b>NOTE:</b>When you make a shutdown request, you
    /// will get a 200 OK success response immediately. However, it might take some time for the gateway to shut down. You can call the
    /// DescribeGatewayInformation API to check the status. For more information, see ActivateGateway.</para> <para>If do not intend to use the
    /// gateway again, you must delete the gateway (using DeleteGateway) to no longer pay software charges associated with the gateway.</para>
    /// </summary>
    public partial class ShutdownGatewayRequest : AmazonStorageGatewayRequest
    {
        private string gatewayARN;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

    }
}
    
