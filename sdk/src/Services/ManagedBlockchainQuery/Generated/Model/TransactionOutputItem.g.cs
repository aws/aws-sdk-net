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

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// The container of the transaction output.
    /// </summary>
    public partial class TransactionOutputItem
    {
        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// Specifies whether to list transactions that have not reached Finality.
        /// </para>
        /// </summary>
        public ConfirmationStatus ConfirmationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationStatus property is set.
        /// </summary>
        internal bool IsSetConfirmationStatus() => this.ConfirmationStatus != null;

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network where the transaction occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryNetwork Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property TransactionHash. 
        /// <para>
        /// The hash of a transaction. It is generated when a transaction is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Checks to see if the TransactionHash property is set.
        /// </summary>
        internal bool IsSetTransactionHash() => this.TransactionHash != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The identifier of a Bitcoin transaction. It is generated when a transaction is created.
        /// </para>
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;

        /// <summary>
        /// Gets and sets the property TransactionTimestamp. 
        /// <para>
        /// The time when the transaction occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TransactionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TransactionTimestamp property is set.
        /// </summary>
        internal bool IsSetTransactionTimestamp() => this.TransactionTimestamp.HasValue;
    }
}
