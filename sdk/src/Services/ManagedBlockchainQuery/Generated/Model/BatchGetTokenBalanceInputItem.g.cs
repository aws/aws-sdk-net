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
    /// The container for the input for getting a token balance.
    /// </summary>
    public partial class BatchGetTokenBalanceInputItem
    {
        /// <summary>
        /// Gets and sets the property AtBlockchainInstant.
        /// </summary>
        public BlockchainInstant AtBlockchainInstant { get; set; }

        /// <summary>
        /// Checks to see if the AtBlockchainInstant property is set.
        /// </summary>
        internal bool IsSetAtBlockchainInstant() => this.AtBlockchainInstant != null;

        /// <summary>
        /// Gets and sets the property OwnerIdentifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public OwnerIdentifier OwnerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwnerIdentifier property is set.
        /// </summary>
        internal bool IsSetOwnerIdentifier() => this.OwnerIdentifier != null;

        /// <summary>
        /// Gets and sets the property TokenIdentifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenIdentifier TokenIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TokenIdentifier property is set.
        /// </summary>
        internal bool IsSetTokenIdentifier() => this.TokenIdentifier != null;
    }
}
