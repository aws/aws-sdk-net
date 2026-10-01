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
    /// Container for the parameters to the DeletePaymentSession operation. Deletes a payment
    /// session. This permanently removes the payment session record.
    /// </summary>
    public partial class DeletePaymentSessionRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The payment manager ARN. Must match the session's paymentManagerArn.
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
        /// The payment session ID to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31, Max = 31)]
        public string PaymentSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentSessionId property is set.
        /// </summary>
        internal bool IsSetPaymentSessionId() => this.PaymentSessionId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID making the delete request. Must match the session's userId.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 120)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
