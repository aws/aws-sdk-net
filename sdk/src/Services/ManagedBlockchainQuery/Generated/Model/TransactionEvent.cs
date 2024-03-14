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

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// The container for the properties of a transaction event.
    /// </summary>
    public partial class TransactionEvent
    {
        private string _contractAddress;
        private QueryTransactionEventType _eventType;
        private string _from;
        private QueryNetwork _network;
        private string _to;
        private string _tokenId;
        private string _transactionHash;
        private string _transactionId;
        private string _value;
        private int? _voutIndex;

        /// <summary>
        /// Gets and sets the property ContractAddress. 
        /// <para>
        /// The blockchain address. for the contract
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
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of transaction event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryTransactionEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The wallet address initiating the transaction. It can either be a public key or a
        /// contract.
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
        /// Gets and sets the property To. 
        /// <para>
        /// The wallet address receiving the transaction. It can either be a public key or a contract.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TokenId. 
        /// <para>
        /// The unique identifier for the token involved in the transaction.
        /// </para>
        /// </summary>
        public string TokenId
        {
            get { return this._tokenId; }
            set { this._tokenId = value; }
        }

        // Check to see if TokenId property is set
        internal bool IsSetTokenId()
        {
            return this._tokenId != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionHash. 
        /// <para>
        /// The hash of the transaction. It is generated whenever a transaction is verified and
        /// added to the blockchain.
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
        /// The unique identifier of the transaction. It is generated whenever a transaction is
        /// verified and added to the blockchain.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value that was transacted.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property VoutIndex. 
        /// <para>
        /// The position of the vout in the transaction output list.
        /// </para>
        /// </summary>
        public int? VoutIndex
        {
            get { return this._voutIndex; }
            set { this._voutIndex = value; }
        }

        // Check to see if VoutIndex property is set
        internal bool IsSetVoutIndex()
        {
            return this._voutIndex.HasValue; 
        }

    }
}