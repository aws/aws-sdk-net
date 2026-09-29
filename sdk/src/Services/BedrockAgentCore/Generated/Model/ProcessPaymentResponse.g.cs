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
    /// This is the response object from the ProcessPayment operation.
    /// </summary>
    public partial class ProcessPaymentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the payment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The ID of the payment instrument used.
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
        /// The ARN of the payment manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 66, Max = 2048)]
        public string PaymentManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the PaymentManagerArn property is set.
        /// </summary>
        internal bool IsSetPaymentManagerArn() => this.PaymentManagerArn != null;

        /// <summary>
        /// Gets and sets the property PaymentOutput. 
        /// <para>
        /// The payment output details specific to the payment type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentOutput PaymentOutput { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOutput property is set.
        /// </summary>
        internal bool IsSetPaymentOutput() => this.PaymentOutput != null;

        /// <summary>
        /// Gets and sets the property PaymentSessionId. 
        /// <para>
        /// The ID of the payment session used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31, Max = 31)]
        public string PaymentSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PaymentSessionId property is set.
        /// </summary>
        internal bool IsSetPaymentSessionId() => this.PaymentSessionId != null;

        /// <summary>
        /// Gets and sets the property PaymentType. 
        /// <para>
        /// The type of payment processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Checks to see if the PaymentType property is set.
        /// </summary>
        internal bool IsSetPaymentType() => this.PaymentType != null;

        /// <summary>
        /// Gets and sets the property ProcessPaymentId. 
        /// <para>
        /// The unique identifier of the processed payment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ProcessPaymentId { get; set; }

        /// <summary>
        /// Checks to see if the ProcessPaymentId property is set.
        /// </summary>
        internal bool IsSetProcessPaymentId() => this.ProcessPaymentId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the payment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the payment was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
