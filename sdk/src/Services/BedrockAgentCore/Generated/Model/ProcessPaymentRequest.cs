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
    /// Container for the parameters to the ProcessPayment operation.
    /// Process a payment transaction
    /// </summary>
    public partial class ProcessPaymentRequest : AmazonBedrockAgentCoreRequest
    {
        private string _agentName;
        private string _clientToken;
        private PaymentInput _paymentInput;
        private string _paymentInstrumentId;
        private string _paymentManagerArn;
        private string _paymentSessionId;
        private PaymentType _paymentType;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The agent name associated with this request, used for observability.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token to ensure request uniqueness.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInput. 
        /// <para>
        /// The payment input details specific to the payment type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInput PaymentInput
        {
            get { return this._paymentInput; }
            set { this._paymentInput = value; }
        }

        // Check to see if PaymentInput property is set
        internal bool IsSetPaymentInput()
        {
            return this._paymentInput != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The ID of the payment instrument to use for this transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string PaymentInstrumentId
        {
            get { return this._paymentInstrumentId; }
            set { this._paymentInstrumentId = value; }
        }

        // Check to see if PaymentInstrumentId property is set
        internal bool IsSetPaymentInstrumentId()
        {
            return this._paymentInstrumentId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager handling this payment.
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
        /// The ID of the payment session for this transaction.
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
        /// Gets and sets the property PaymentType. 
        /// <para>
        /// The type of payment being processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentType PaymentType
        {
            get { return this._paymentType; }
            set { this._paymentType = value; }
        }

        // Check to see if PaymentType property is set
        internal bool IsSetPaymentType()
        {
            return this._paymentType != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this payment.
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