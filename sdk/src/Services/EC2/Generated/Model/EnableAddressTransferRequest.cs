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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableAddressTransfer operation.
    /// Enables Elastic IP address transfer. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-eips.html#transfer-EIPs-intro">Transfer
    /// Elastic IP addresses</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class EnableAddressTransferRequest : AmazonEC2Request
    {
        private string _allocationId;
        private bool? _dryRun;
        private string _transferAccountId;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID of an Elastic IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferAccountId. 
        /// <para>
        /// The ID of the account that you want to transfer the Elastic IP address to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransferAccountId
        {
            get { return this._transferAccountId; }
            set { this._transferAccountId = value; }
        }

        // Check to see if TransferAccountId property is set
        internal bool IsSetTransferAccountId()
        {
            return this._transferAccountId != null;
        }

    }
}