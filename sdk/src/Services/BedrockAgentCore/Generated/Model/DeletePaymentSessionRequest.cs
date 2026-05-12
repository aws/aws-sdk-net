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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePaymentSession operation.
    /// Delete a payment manager session
    /// 
    ///  
    /// <para>
    /// Permanently removes a payment session record from the database. This is a hard delete
    /// operation that removes the session completely.
    /// </para>
    ///  
    /// <para>
    /// Deleting a non-existent or already-deleted session returns ResourceNotFoundException
    /// (404).
    /// </para>
    ///  
    /// <para>
    /// Authorization: The caller must own the session (accountId, userId, and paymentManagerId
    /// must match). If authorization fails, a 403 Forbidden error is returned.
    /// </para>
    ///  
    /// <para>
    /// Errors:
    /// </para>
    ///  <ul> <li>ResourceNotFoundException: The session does not exist or has already been
    /// deleted</li> <li>AccessDeniedException: The caller is not authorized to delete this
    /// session</li> <li>ValidationException: Required fields are missing or invalid</li>
    /// <li>InternalServerException: An unexpected server error occurred</li> </ul>
    /// </summary>
    public partial class DeletePaymentSessionRequest : AmazonBedrockAgentCoreRequest
    {
        private string _paymentManagerArn;
        private string _paymentSessionId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The payment manager ARN. Must match the session's paymentManagerArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=66, Max=2048)]
        public string PaymentManagerArn
        {
            get { return this._paymentManagerArn; }
            set { this._paymentManagerArn = value; }
        }

        // Check to see if PaymentManagerArn property is set
        internal bool IsSetPaymentManagerArn()
        {
            return this._paymentManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentSessionId. 
        /// <para>
        /// The payment session ID to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31, Max=31)]
        public string PaymentSessionId
        {
            get { return this._paymentSessionId; }
            set { this._paymentSessionId = value; }
        }

        // Check to see if PaymentSessionId property is set
        internal bool IsSetPaymentSessionId()
        {
            return this._paymentSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID making the delete request. Must match the session's userId.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=120)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}