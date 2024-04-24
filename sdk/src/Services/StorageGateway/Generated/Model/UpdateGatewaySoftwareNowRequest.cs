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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGatewaySoftwareNow operation.
    /// Updates the gateway virtual machine (VM) software. The request immediately triggers
    /// the software update.
    /// 
    ///  <note> 
    /// <para>
    /// When you make this request, you get a <c>200 OK</c> success response immediately.
    /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
    /// to verify the gateway is in the <c>STATE_RUNNING</c> state.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// A software update forces a system restart of your gateway. You can minimize the chance
    /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
    /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
    /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
    /// your Windows iSCSI settings</a> and <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
    /// your Linux iSCSI settings</a>, respectively.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateGatewaySoftwareNowRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}