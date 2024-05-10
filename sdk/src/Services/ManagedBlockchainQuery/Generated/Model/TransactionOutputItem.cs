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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
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
        private ConfirmationStatus _confirmationStatus;
        private QueryNetwork _network;
        private string _transactionHash;
        private string _transactionId;
        private DateTime? _transactionTimestamp;

        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// Specifies whether to list transactions that have not reached Finality.
        /// </para>
        /// </summary>
        public ConfirmationStatus ConfirmationStatus
        {
            get { return this._confirmationStatus; }
            set { this._confirmationStatus = value; }
        }

        // Check to see if ConfirmationStatus property is set
        internal bool IsSetConfirmationStatus()
        {
            return this._confirmationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network where the transaction occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryNetwork Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionHash. 
        /// <para>
        /// The hash of a transaction. It is generated when a transaction is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransactionHash
        {
            get { return this._transactionHash; }
            set { this._transactionHash = value; }
        }

        // Check to see if TransactionHash property is set
        internal bool IsSetTransactionHash()
        {
            return this._transactionHash != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The identifier of a Bitcoin transaction. It is generated when a transaction is created.
        /// </para>
        /// </summary>
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionTimestamp. 
        /// <para>
        /// The time when the transaction occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? TransactionTimestamp
        {
            get { return this._transactionTimestamp; }
            set { this._transactionTimestamp = value; }
        }

        // Check to see if TransactionTimestamp property is set
        internal bool IsSetTransactionTimestamp()
        {
            return this._transactionTimestamp.HasValue; 
        }

    }
}