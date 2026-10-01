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
    /// The container for the properties of a transaction event.
    /// </summary>
    public partial class TransactionEvent
    {
        /// <summary>
        /// Gets and sets the property BlockchainInstant.
        /// </summary>
        public BlockchainInstant BlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the BlockchainInstant property is set.
        /// </summary>
        internal bool IsSetBlockchainInstant() => this.BlockchainInstant != null;

        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// This container specifies whether the transaction has reached Finality.
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
        /// The blockchain address for the contract
        /// </para>
        /// </summary>
        public string ContractAddress { get; set; }

        /// <summary>
        /// Checks to see if the ContractAddress property is set.
        /// </summary>
        internal bool IsSetContractAddress() => this.ContractAddress != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of transaction event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryTransactionEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The wallet address initiating the transaction. It can either be a public key or a
        /// contract.
        /// </para>
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

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
        /// Gets and sets the property SpentVoutIndex. 
        /// <para>
        /// The position of the spent transaction output in the output list of the <i>creating
        /// transaction</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only returned for <c>BITCOIN_VIN</c> event types.
        /// </para>
        ///  </note>
        /// </summary>
        public int? SpentVoutIndex { get; set; }

        /// <summary>
        /// Checks to see if the SpentVoutIndex property is set.
        /// </summary>
        internal bool IsSetSpentVoutIndex() => this.SpentVoutIndex.HasValue;

        /// <summary>
        /// Gets and sets the property SpentVoutTransactionHash. 
        /// <para>
        /// The transactionHash that <i>created</i> the spent transaction output.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only returned for <c>BITCOIN_VIN</c> event types.
        /// </para>
        ///  </note>
        /// </summary>
        public string SpentVoutTransactionHash { get; set; }

        /// <summary>
        /// Checks to see if the SpentVoutTransactionHash property is set.
        /// </summary>
        internal bool IsSetSpentVoutTransactionHash() => this.SpentVoutTransactionHash != null;

        /// <summary>
        /// Gets and sets the property SpentVoutTransactionId. 
        /// <para>
        /// The transactionId that <i>created</i> the spent transaction output.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only returned for <c>BITCOIN_VIN</c> event types.
        /// </para>
        ///  </note>
        /// </summary>
        public string SpentVoutTransactionId { get; set; }

        /// <summary>
        /// Checks to see if the SpentVoutTransactionId property is set.
        /// </summary>
        internal bool IsSetSpentVoutTransactionId() => this.SpentVoutTransactionId != null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The wallet address receiving the transaction. It can either be a public key or a contract.
        /// </para>
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;

        /// <summary>
        /// Gets and sets the property TokenId. 
        /// <para>
        /// The unique identifier for the token involved in the transaction.
        /// </para>
        /// </summary>
        public string TokenId { get; set; }

        /// <summary>
        /// Checks to see if the TokenId property is set.
        /// </summary>
        internal bool IsSetTokenId() => this.TokenId != null;

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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value that was transacted.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property VoutIndex. 
        /// <para>
        /// The position of the transaction output in the transaction output list.
        /// </para>
        /// </summary>
        public int? VoutIndex { get; set; }

        /// <summary>
        /// Checks to see if the VoutIndex property is set.
        /// </summary>
        internal bool IsSetVoutIndex() => this.VoutIndex.HasValue;

        /// <summary>
        /// Gets and sets the property VoutSpent. 
        /// <para>
        /// Specifies if the transaction output is spent or unspent. This is only returned for
        /// BITCOIN_VOUT event types.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only returned for <c>BITCOIN_VOUT</c> event types.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? VoutSpent { get; set; }

        /// <summary>
        /// Checks to see if the VoutSpent property is set.
        /// </summary>
        internal bool IsSetVoutSpent() => this.VoutSpent.HasValue;
    }
}
