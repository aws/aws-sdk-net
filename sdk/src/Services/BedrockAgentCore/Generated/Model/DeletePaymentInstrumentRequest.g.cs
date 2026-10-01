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
    /// Container for the parameters to the DeletePaymentInstrument operation. Deletes a payment
    /// instrument. This is a soft delete operation that preserves the record for audit and
    /// compliance purposes.
    /// </summary>
    public partial class DeletePaymentInstrumentRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The payment connector ID. Must match the instrument's paymentConnectorId.
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
        /// The payment instrument ID to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentInstrumentId property is set.
        /// </summary>
        internal bool IsSetPaymentInstrumentId() => this.PaymentInstrumentId != null;

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The payment manager ARN. Must match the instrument's paymentManagerArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 66, Max = 2048)]
        public string PaymentManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the PaymentManagerArn property is set.
        /// </summary>
        internal bool IsSetPaymentManagerArn() => this.PaymentManagerArn != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID making the delete request. Must match the instrument's userId.
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
