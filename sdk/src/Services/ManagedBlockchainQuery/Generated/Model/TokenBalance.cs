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
    /// The balance of the token.
    /// </summary>
    public partial class TokenBalance
    {
        private BlockchainInstant _atBlockchainInstant;
        private string _balance;
        private BlockchainInstant _lastUpdatedTime;
        private OwnerIdentifier _ownerIdentifier;
        private TokenIdentifier _tokenIdentifier;

        /// <summary>
        /// Gets and sets the property AtBlockchainInstant. 
        /// <para>
        /// The time for when the TokenBalance is requested or the current time if a time is not
        /// provided in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This time will only be recorded up to the second.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockchainInstant AtBlockchainInstant
        {
            get { return this._atBlockchainInstant; }
            set { this._atBlockchainInstant = value; }
        }

        // Check to see if AtBlockchainInstant property is set
        internal bool IsSetAtBlockchainInstant()
        {
            return this._atBlockchainInstant != null;
        }

        /// <summary>
        /// Gets and sets the property Balance. 
        /// <para>
        /// The container of the token balance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
        }

        // Check to see if Balance property is set
        internal bool IsSetBalance()
        {
            return this._balance != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The <c>Timestamp</c> of the last transaction at which the balance for the token in
        /// the wallet was updated.
        /// </para>
        /// </summary>
        public BlockchainInstant LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerIdentifier. 
        /// <para>
        /// The container for the identifier of the owner.
        /// </para>
        /// </summary>
        public OwnerIdentifier OwnerIdentifier
        {
            get { return this._ownerIdentifier; }
            set { this._ownerIdentifier = value; }
        }

        // Check to see if OwnerIdentifier property is set
        internal bool IsSetOwnerIdentifier()
        {
            return this._ownerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TokenIdentifier. 
        /// <para>
        /// The identifier for the token, including the unique token ID and its blockchain network.
        /// </para>
        /// </summary>
        public TokenIdentifier TokenIdentifier
        {
            get { return this._tokenIdentifier; }
            set { this._tokenIdentifier = value; }
        }

        // Check to see if TokenIdentifier property is set
        internal bool IsSetTokenIdentifier()
        {
            return this._tokenIdentifier != null;
        }

    }
}