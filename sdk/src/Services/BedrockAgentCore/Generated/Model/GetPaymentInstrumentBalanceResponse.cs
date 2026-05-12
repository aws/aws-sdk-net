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
    /// Response structure for getting payment instrument balance
    /// </summary>
    public partial class GetPaymentInstrumentBalanceResponse : AmazonWebServiceResponse
    {
        private string _paymentInstrumentId;
        private TokenBalance _tokenBalance;

        /// <summary>
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The ID of the payment instrument.
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
        /// Gets and sets the property TokenBalance. 
        /// <para>
        /// The balance of the supported token on the requested chain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenBalance TokenBalance
        {
            get { return this._tokenBalance; }
            set { this._tokenBalance = value; }
        }

        // Check to see if TokenBalance property is set
        internal bool IsSetTokenBalance()
        {
            return this._tokenBalance != null;
        }

    }
}