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
    /// Error generated from a failed <c>BatchGetTokenBalance</c> request.
    /// </summary>
    public partial class BatchGetTokenBalanceErrorItem
    {
        private BlockchainInstant _atBlockchainInstant;
        private string _errorCode;
        private string _errorMessage;
        private ErrorType _errorType;
        private OwnerIdentifier _ownerIdentifier;
        private TokenIdentifier _tokenIdentifier;

        /// <summary>
        /// Gets and sets the property AtBlockchainInstant.
        /// </summary>
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code associated with the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The message associated with the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// The type of error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ErrorType ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerIdentifier.
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