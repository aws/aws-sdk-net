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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Details on the Elastic IP address transfer. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-eips.html#transfer-EIPs-intro">Transfer
    /// Elastic IP addresses</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class AddressTransfer
    {
        /// <summary>
        /// Gets and sets the property AddressTransferStatus. 
        /// <para>
        /// The Elastic IP address transfer status.
        /// </para>
        /// </summary>
        public AddressTransferStatus AddressTransferStatus { get; set; }

        /// <summary>
        /// Checks to see if the AddressTransferStatus property is set.
        /// </summary>
        internal bool IsSetAddressTransferStatus() => this.AddressTransferStatus != null;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID of an Elastic IP address.
        /// </para>
        /// </summary>
        public string AllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AllocationId property is set.
        /// </summary>
        internal bool IsSetAllocationId() => this.AllocationId != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address being transferred.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;

        /// <summary>
        /// Gets and sets the property TransferAccountId. 
        /// <para>
        /// The ID of the account that you want to transfer the Elastic IP address to.
        /// </para>
        /// </summary>
        public string TransferAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TransferAccountId property is set.
        /// </summary>
        internal bool IsSetTransferAccountId() => this.TransferAccountId != null;

        /// <summary>
        /// Gets and sets the property TransferOfferAcceptedTimestamp. 
        /// <para>
        /// The timestamp when the Elastic IP address transfer was accepted.
        /// </para>
        /// </summary>
        public DateTime? TransferOfferAcceptedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TransferOfferAcceptedTimestamp property is set.
        /// </summary>
        internal bool IsSetTransferOfferAcceptedTimestamp() => this.TransferOfferAcceptedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TransferOfferExpirationTimestamp. 
        /// <para>
        /// The timestamp when the Elastic IP address transfer expired. When the source account
        /// starts the transfer, the transfer account has seven hours to allocate the Elastic
        /// IP address to complete the transfer, or the Elastic IP address will return to its
        /// original owner.
        /// </para>
        /// </summary>
        public DateTime? TransferOfferExpirationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TransferOfferExpirationTimestamp property is set.
        /// </summary>
        internal bool IsSetTransferOfferExpirationTimestamp() => this.TransferOfferExpirationTimestamp.HasValue;
    }
}
