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
    /// Error generated from a failed <c>BatchGetTokenBalance</c> request.
    /// </summary>
    public partial class BatchGetTokenBalanceErrorItem
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code associated with the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The message associated with the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// The type of error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ErrorType ErrorType { get; set; }

        /// <summary>
        /// Checks to see if the ErrorType property is set.
        /// </summary>
        internal bool IsSetErrorType() => this.ErrorType != null;

        /// <summary>
        /// Gets and sets the property OwnerIdentifier.
        /// </summary>
        public OwnerIdentifier OwnerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwnerIdentifier property is set.
        /// </summary>
        internal bool IsSetOwnerIdentifier() => this.OwnerIdentifier != null;

        /// <summary>
        /// Gets and sets the property TokenIdentifier.
        /// </summary>
        public TokenIdentifier TokenIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TokenIdentifier property is set.
        /// </summary>
        internal bool IsSetTokenIdentifier() => this.TokenIdentifier != null;
    }
}
