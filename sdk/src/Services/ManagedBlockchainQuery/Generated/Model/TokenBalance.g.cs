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
    /// The balance of the token.
    /// </summary>
    public partial class TokenBalance
    {
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
        [AWSProperty(Required = true)]
        public BlockchainInstant AtBlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the AtBlockchainInstant property is set.
        /// </summary>
        internal bool IsSetAtBlockchainInstant() => this.AtBlockchainInstant != null;

        /// <summary>
        /// Gets and sets the property Balance. 
        /// <para>
        /// The container of the token balance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Balance { get; set; }

        /// <summary>
        /// Checks to see if the Balance property is set.
        /// </summary>
        internal bool IsSetBalance() => this.Balance != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The <c>Timestamp</c> of the last transaction at which the balance for the token in
        /// the wallet was updated.
        /// </para>
        /// </summary>
        public BlockchainInstant LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property OwnerIdentifier. 
        /// <para>
        /// The container for the identifier of the owner.
        /// </para>
        /// </summary>
        public OwnerIdentifier OwnerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwnerIdentifier property is set.
        /// </summary>
        internal bool IsSetOwnerIdentifier() => this.OwnerIdentifier != null;

        /// <summary>
        /// Gets and sets the property TokenIdentifier. 
        /// <para>
        /// The identifier for the token, including the unique token ID and its blockchain network.
        /// </para>
        /// </summary>
        public TokenIdentifier TokenIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TokenIdentifier property is set.
        /// </summary>
        internal bool IsSetTokenIdentifier() => this.TokenIdentifier != null;
    }
}
