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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A payment session for managing payment transactions.
    /// </summary>
    public partial class PaymentSession
    {
        /// <summary>
        /// Gets and sets the property AvailableLimits. 
        /// <para>
        /// The current available spending limits.
        /// </para>
        /// </summary>
        public AvailableLimits AvailableLimits { get; set; }

        /// <summary>
        /// Checks to see if the AvailableLimits property is set.
        /// </summary>
        internal bool IsSetAvailableLimits() => this.AvailableLimits != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiryTimeInMinutes. 
        /// <para>
        /// The session expiry time in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ExpiryTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetExpiryTimeInMinutes() => this.ExpiryTimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The spending limits for the payment session.
        /// </para>
        /// </summary>
        public SessionLimits Limits { get; set; }

        /// <summary>
        /// Checks to see if the Limits property is set.
        /// </summary>
        internal bool IsSetLimits() => this.Limits != null;

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that owns this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 66, Max = 2048)]
        public string PaymentManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the PaymentManagerArn property is set.
        /// </summary>
        internal bool IsSetPaymentManagerArn() => this.PaymentManagerArn != null;

        /// <summary>
        /// Gets and sets the property PaymentSessionId. 
        /// <para>
        /// The unique identifier of the payment session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31, Max = 31)]
        public string PaymentSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentSessionId property is set.
        /// </summary>
        internal bool IsSetPaymentSessionId() => this.PaymentSessionId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the session was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 120)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
