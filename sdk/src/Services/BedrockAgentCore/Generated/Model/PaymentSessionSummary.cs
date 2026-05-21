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
    /// Summary information about a payment session.
    /// </summary>
    public partial class PaymentSessionSummary
    {
        private DateTime? _createdAt;
        private int? _expiryTimeInMinutes;
        private string _paymentManagerArn;
        private string _paymentSessionId;
        private DateTime? _updatedAt;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiryTimeInMinutes. 
        /// <para>
        /// The session expiry time in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ExpiryTimeInMinutes
        {
            get { return this._expiryTimeInMinutes; }
            set { this._expiryTimeInMinutes = value; }
        }

        // Check to see if ExpiryTimeInMinutes property is set
        internal bool IsSetExpiryTimeInMinutes()
        {
            return this._expiryTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that owns this session.
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
        /// The unique identifier of the payment session.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the session was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=120)]
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