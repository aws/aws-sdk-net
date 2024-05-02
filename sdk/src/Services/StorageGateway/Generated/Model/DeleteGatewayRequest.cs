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
    /// Container for the parameters to the DeleteGateway operation.
    /// Deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name
    /// (ARN) of the gateway in your request. The operation deletes the gateway; however,
    /// it does not delete the gateway virtual machine (VM) from your host computer.
    /// 
    ///  
    /// <para>
    /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
    /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
    /// not complete. After you delete a gateway, your next step is to remove it from your
    /// environment.
    /// </para>
    ///  <important> 
    /// <para>
    /// You no longer pay software charges after the gateway is deleted; however, your existing
    /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
    /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
    /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
    /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">Storage
    /// Gateway detail page</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteGatewayRequest : AmazonStorageGatewayRequest
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