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
    /// Container for the parameters to the GetPaymentInstrumentBalance operation.
    /// Get the balance of a payment instrument
    /// </summary>
    public partial class GetPaymentInstrumentBalanceRequest : AmazonBedrockAgentCoreRequest
    {
        private string _agentName;
        private BlockchainChainId _chain;
        private string _paymentConnectorId;
        private string _paymentInstrumentId;
        private string _paymentManagerArn;
        private InstrumentBalanceToken _token;
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
        /// Gets and sets the property Chain. 
        /// <para>
        /// The specific blockchain chain to query balance on. Required because balances are chain-specific
        /// — the same wallet address may hold different token balances on different chains.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockchainChainId Chain
        {
            get { return this._chain; }
            set { this._chain = value; }
        }

        // Check to see if Chain property is set
        internal bool IsSetChain()
        {
            return this._chain != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The ID of the payment connector associated with this instrument.
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
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The ID of the payment instrument to query balance for.
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
        /// Gets and sets the property Token. 
        /// <para>
        /// The token to query balance for. Required to specify which supported token's balance
        /// to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstrumentBalanceToken Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
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