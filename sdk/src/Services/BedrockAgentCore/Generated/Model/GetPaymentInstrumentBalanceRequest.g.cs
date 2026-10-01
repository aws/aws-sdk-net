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
    /// Container for the parameters to the GetPaymentInstrumentBalance operation. Get the
    /// balance of a payment instrument.
    /// </summary>
    public partial class GetPaymentInstrumentBalanceRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The agent name associated with this request, used for observability.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property Chain. 
        /// <para>
        /// The specific blockchain chain to query balance on. Required because balances are chain-specific.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BlockchainChainId Chain { get; set; }

        /// <summary>
        /// Checks to see if the Chain property is set.
        /// </summary>
        internal bool IsSetChain() => this.Chain != null;

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
        /// The ID of the payment instrument to query balance for.
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
        /// Gets and sets the property Token. 
        /// <para>
        /// The token to query balance for. Only tokens supported for X402 payments are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentBalanceToken Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this payment instrument.
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
