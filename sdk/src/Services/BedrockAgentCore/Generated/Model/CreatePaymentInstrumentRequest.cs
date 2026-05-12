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
    /// Container for the parameters to the CreatePaymentInstrument operation.
    /// Create a new payment instrument for a connector
    /// </summary>
    public partial class CreatePaymentInstrumentRequest : AmazonBedrockAgentCoreRequest
    {
        private string _agentName;
        private string _clientToken;
        private string _paymentConnectorId;
        private PaymentInstrumentDetails _paymentInstrumentDetails;
        private PaymentInstrumentType _paymentInstrumentType;
        private string _paymentManagerArn;
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
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The ID of the payment connector to use for this instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=211)]
        public string PaymentConnectorId
        {
            get { return this._paymentConnectorId; }
            set { this._paymentConnectorId = value; }
        }

        // Check to see if PaymentConnectorId property is set
        internal bool IsSetPaymentConnectorId()
        {
            return this._paymentConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInstrumentDetails. 
        /// <para>
        /// The details of the payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInstrumentDetails PaymentInstrumentDetails
        {
            get { return this._paymentInstrumentDetails; }
            set { this._paymentInstrumentDetails = value; }
        }

        // Check to see if PaymentInstrumentDetails property is set
        internal bool IsSetPaymentInstrumentDetails()
        {
            return this._paymentInstrumentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInstrumentType. 
        /// <para>
        /// The type of payment instrument being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInstrumentType PaymentInstrumentType
        {
            get { return this._paymentInstrumentType; }
            set { this._paymentInstrumentType = value; }
        }

        // Check to see if PaymentInstrumentType property is set
        internal bool IsSetPaymentInstrumentType()
        {
            return this._paymentInstrumentType != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that owns this payment instrument.
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this payment instrument.
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