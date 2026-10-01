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
    /// Summary of a payment instrument for list operations.
    /// </summary>
    public partial class PaymentInstrumentSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this payment instrument was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The ID of the payment connector associated with this instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 211)]
        public string PaymentConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentConnectorId property is set.
        /// </summary>
        internal bool IsSetPaymentConnectorId() => this.PaymentConnectorId != null;

        /// <summary>
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The unique identifier for this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentInstrumentId property is set.
        /// </summary>
        internal bool IsSetPaymentInstrumentId() => this.PaymentInstrumentId != null;

        /// <summary>
        /// Gets and sets the property PaymentInstrumentType. 
        /// <para>
        /// The type of payment instrument (e.g., EMBEDDED_CRYPTO_WALLET).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentInstrumentType PaymentInstrumentType { get; set; }

        /// <summary>
        /// Checks to see if the PaymentInstrumentType property is set.
        /// </summary>
        internal bool IsSetPaymentInstrumentType() => this.PaymentInstrumentType != null;

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that owns this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 66, Max = 2048)]
        public string PaymentManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the PaymentManagerArn property is set.
        /// </summary>
        internal bool IsSetPaymentManagerArn() => this.PaymentManagerArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentInstrumentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when this payment instrument was last updated.
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
        /// The user ID associated with this payment instrument.
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
