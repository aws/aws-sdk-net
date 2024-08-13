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
    /// There are two possible types of transactions used for this data type:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A Bitcoin transaction is a movement of BTC from one address to another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Ethereum transaction refers to an action initiated by an externally owned account,
    /// which is an account managed by a human, not a contract. For example, if Bob sends
    /// Alice 1 ETH, Bob's account must be debited and Alice's must be credited. This state-changing
    /// action occurs within a transaction.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Transaction
    {
        private string _blockHash;
        private string _blockNumber;
        private ConfirmationStatus _confirmationStatus;
        private string _contractAddress;
        private string _cumulativeGasUsed;
        private string _effectiveGasPrice;
        private ExecutionStatus _executionStatus;
        private string _from;
        private string _gasUsed;
        private QueryNetwork _network;
        private long? _numberOfTransactions;
        private string _signaturer;
        private string _signatures;
        private int? _signaturev;
        private string _to;
        private string _transactionFee;
        private string _transactionHash;
        private string _transactionId;
        private long? _transactionIndex;
        private DateTime? _transactionTimestamp;

        /// <summary>
        /// Gets and sets the property BlockHash. 
        /// <para>
        /// The block hash is a unique identifier for a block. It is a fixed-size string that
        /// is calculated by using the information in the block. The block hash is used to verify
        /// the integrity of the data in the block.
        /// </para>
        /// </summary>
        public string BlockHash
        {
            get { return this._blockHash; }
            set { this._blockHash = value; }
        }

        // Check to see if BlockHash property is set
        internal bool IsSetBlockHash()
        {
            return this._blockHash != null;
        }

        /// <summary>
        /// Gets and sets the property BlockNumber. 
        /// <para>
        /// The block number in which the transaction is recorded.
        /// </para>
        /// </summary>
        public string BlockNumber
        {
            get { return this._blockNumber; }
            set { this._blockNumber = value; }
        }

        // Check to see if BlockNumber property is set
        internal bool IsSetBlockNumber()
        {
            return this._blockNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// Specifies whether the transaction has reached Finality.
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
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// The blockchain address for the contract.
        /// </para>
        /// </summary>
        public string ContractAddress
        {
            get { return this._contractAddress; }
            set { this._contractAddress = value; }
        }

        // Check to see if ContractAddress property is set
        internal bool IsSetContractAddress()
        {
            return this._contractAddress != null;
        }

        /// <summary>
        /// Gets and sets the property CumulativeGasUsed. 
        /// <para>
        /// The amount of gas used up to the specified point in the block.
        /// </para>
        /// </summary>
        public string CumulativeGasUsed
        {
            get { return this._cumulativeGasUsed; }
            set { this._cumulativeGasUsed = value; }
        }

        // Check to see if CumulativeGasUsed property is set
        internal bool IsSetCumulativeGasUsed()
        {
            return this._cumulativeGasUsed != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveGasPrice. 
        /// <para>
        /// The effective gas price.
        /// </para>
        /// </summary>
        public string EffectiveGasPrice
        {
            get { return this._effectiveGasPrice; }
            set { this._effectiveGasPrice = value; }
        }

        // Check to see if EffectiveGasPrice property is set
        internal bool IsSetEffectiveGasPrice()
        {
            return this._effectiveGasPrice != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// Identifies whether the transaction has succeeded or failed.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The initiator of the transaction. It is either in the form a public key or a contract
        /// address.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property GasUsed. 
        /// <para>
        /// The amount of gas used for the transaction.
        /// </para>
        /// </summary>
        public string GasUsed
        {
            get { return this._gasUsed; }
            set { this._gasUsed = value; }
        }

        // Check to see if GasUsed property is set
        internal bool IsSetGasUsed()
        {
            return this._gasUsed != null;
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
        /// Gets and sets the property NumberOfTransactions. 
        /// <para>
        /// The number of transactions in the block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? NumberOfTransactions
        {
            get { return this._numberOfTransactions; }
            set { this._numberOfTransactions = value; }
        }

        // Check to see if NumberOfTransactions property is set
        internal bool IsSetNumberOfTransactions()
        {
            return this._numberOfTransactions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignatureR. 
        /// <para>
        /// The signature of the transaction. The X coordinate of a point R.
        /// </para>
        /// </summary>
        public string SignatureR
        {
            get { return this._signaturer; }
            set { this._signaturer = value; }
        }

        // Check to see if SignatureR property is set
        internal bool IsSetSignatureR()
        {
            return this._signaturer != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureS. 
        /// <para>
        /// The signature of the transaction. The Y coordinate of a point S.
        /// </para>
        /// </summary>
        public string SignatureS
        {
            get { return this._signatures; }
            set { this._signatures = value; }
        }

        // Check to see if SignatureS property is set
        internal bool IsSetSignatureS()
        {
            return this._signatures != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureV. 
        /// <para>
        /// The signature of the transaction. The Z coordinate of a point V.
        /// </para>
        /// </summary>
        public int? SignatureV
        {
            get { return this._signaturev; }
            set { this._signaturev = value; }
        }

        // Check to see if SignatureV property is set
        internal bool IsSetSignatureV()
        {
            return this._signaturev.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The identifier of the transaction. It is generated whenever a transaction is verified
        /// and added to the blockchain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionFee. 
        /// <para>
        /// The transaction fee.
        /// </para>
        /// </summary>
        public string TransactionFee
        {
            get { return this._transactionFee; }
            set { this._transactionFee = value; }
        }

        // Check to see if TransactionFee property is set
        internal bool IsSetTransactionFee()
        {
            return this._transactionFee != null;
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
        /// Gets and sets the property TransactionIndex. 
        /// <para>
        /// The index of the transaction within a blockchain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TransactionIndex
        {
            get { return this._transactionIndex; }
            set { this._transactionIndex = value; }
        }

        // Check to see if TransactionIndex property is set
        internal bool IsSetTransactionIndex()
        {
            return this._transactionIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionTimestamp. 
        /// <para>
        /// The <c>Timestamp</c> of the transaction. 
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