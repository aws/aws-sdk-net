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
        /// <summary>
        /// Gets and sets the property BlockHash. 
        /// <para>
        /// The block hash is a unique identifier for a block. It is a fixed-size string that
        /// is calculated by using the information in the block. The block hash is used to verify
        /// the integrity of the data in the block.
        /// </para>
        /// </summary>
        public string BlockHash { get; set; }

        /// <summary>
        /// Checks to see if the BlockHash property is set.
        /// </summary>
        internal bool IsSetBlockHash() => this.BlockHash != null;

        /// <summary>
        /// Gets and sets the property BlockNumber. 
        /// <para>
        /// The block number in which the transaction is recorded.
        /// </para>
        /// </summary>
        public string BlockNumber { get; set; }

        /// <summary>
        /// Checks to see if the BlockNumber property is set.
        /// </summary>
        internal bool IsSetBlockNumber() => this.BlockNumber != null;

        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// Specifies whether the transaction has reached Finality.
        /// </para>
        /// </summary>
        public ConfirmationStatus ConfirmationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationStatus property is set.
        /// </summary>
        internal bool IsSetConfirmationStatus() => this.ConfirmationStatus != null;

        /// <summary>
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// The blockchain address for the contract.
        /// </para>
        /// </summary>
        public string ContractAddress { get; set; }

        /// <summary>
        /// Checks to see if the ContractAddress property is set.
        /// </summary>
        internal bool IsSetContractAddress() => this.ContractAddress != null;

        /// <summary>
        /// Gets and sets the property CumulativeGasUsed. 
        /// <para>
        /// The amount of gas used up to the specified point in the block.
        /// </para>
        /// </summary>
        public string CumulativeGasUsed { get; set; }

        /// <summary>
        /// Checks to see if the CumulativeGasUsed property is set.
        /// </summary>
        internal bool IsSetCumulativeGasUsed() => this.CumulativeGasUsed != null;

        /// <summary>
        /// Gets and sets the property EffectiveGasPrice. 
        /// <para>
        /// The effective gas price.
        /// </para>
        /// </summary>
        public string EffectiveGasPrice { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveGasPrice property is set.
        /// </summary>
        internal bool IsSetEffectiveGasPrice() => this.EffectiveGasPrice != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// Identifies whether the transaction has succeeded or failed.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The initiator of the transaction. It is either in the form a public key or a contract
        /// address.
        /// </para>
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property GasUsed. 
        /// <para>
        /// The amount of gas used for the transaction.
        /// </para>
        /// </summary>
        public string GasUsed { get; set; }

        /// <summary>
        /// Checks to see if the GasUsed property is set.
        /// </summary>
        internal bool IsSetGasUsed() => this.GasUsed != null;

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
        /// Gets and sets the property NumberOfTransactions. 
        /// <para>
        /// The number of transactions in the block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? NumberOfTransactions { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTransactions property is set.
        /// </summary>
        internal bool IsSetNumberOfTransactions() => this.NumberOfTransactions.HasValue;

        /// <summary>
        /// Gets and sets the property SignatureR. 
        /// <para>
        /// The signature of the transaction. The X coordinate of a point R.
        /// </para>
        /// </summary>
        public string SignatureR { get; set; }

        /// <summary>
        /// Checks to see if the SignatureR property is set.
        /// </summary>
        internal bool IsSetSignatureR() => this.SignatureR != null;

        /// <summary>
        /// Gets and sets the property SignatureS. 
        /// <para>
        /// The signature of the transaction. The Y coordinate of a point S.
        /// </para>
        /// </summary>
        public string SignatureS { get; set; }

        /// <summary>
        /// Checks to see if the SignatureS property is set.
        /// </summary>
        internal bool IsSetSignatureS() => this.SignatureS != null;

        /// <summary>
        /// Gets and sets the property SignatureV. 
        /// <para>
        /// The signature of the transaction. The Z coordinate of a point V.
        /// </para>
        /// </summary>
        public int? SignatureV { get; set; }

        /// <summary>
        /// Checks to see if the SignatureV property is set.
        /// </summary>
        internal bool IsSetSignatureV() => this.SignatureV.HasValue;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The identifier of the transaction. It is generated whenever a transaction is verified
        /// and added to the blockchain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;

        /// <summary>
        /// Gets and sets the property TransactionFee. 
        /// <para>
        /// The transaction fee.
        /// </para>
        /// </summary>
        public string TransactionFee { get; set; }

        /// <summary>
        /// Checks to see if the TransactionFee property is set.
        /// </summary>
        internal bool IsSetTransactionFee() => this.TransactionFee != null;

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
        /// Gets and sets the property TransactionIndex. 
        /// <para>
        /// The index of the transaction within a blockchain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TransactionIndex { get; set; }

        /// <summary>
        /// Checks to see if the TransactionIndex property is set.
        /// </summary>
        internal bool IsSetTransactionIndex() => this.TransactionIndex.HasValue;

        /// <summary>
        /// Gets and sets the property TransactionTimestamp. 
        /// <para>
        /// The <c>Timestamp</c> of the transaction. 
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
