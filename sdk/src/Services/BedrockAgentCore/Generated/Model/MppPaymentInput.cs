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
    /// Contains the payment challenge from a 402 Payment Required response. Forward the raw
    /// <c>WWW-Authenticate: Payment</c> header value verbatim. In response, you receive a
    /// payment credential that satisfies the challenge. Provide exactly one challenge per
    /// request.
    /// </summary>
    public partial class MppPaymentInput
    {
        private bool? _buyerPaysGasFees;
        private string _version;
        private List<string> _wwwAuthenticateHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BuyerPaysGasFees. 
        /// <para>
        /// Authorizes the service to sign a payment whose blockchain network (gas) fees are charged
        /// to your wallet, on top of the payment amount.
        /// </para>
        ///  
        /// <para>
        /// The challenge indicates who sponsors the network fees. When the challenge does not
        /// sponsor them, the service signs the payment only if this field is <c>true</c>. Otherwise
        /// it returns a validation error, so you can decide whether to pay the fees or obtain
        /// a challenge that sponsors them.
        /// </para>
        ///  
        /// <para>
        /// Optional. When omitted or <c>false</c>, you decline to pay network fees. This field
        /// has no effect on challenges that already sponsor the fees.
        /// </para>
        /// </summary>
        public bool? BuyerPaysGasFees
        {
            get { return this._buyerPaysGasFees; }
            set { this._buyerPaysGasFees = value; }
        }

        // Check to see if BuyerPaysGasFees property is set
        internal bool IsSetBuyerPaysGasFees()
        {
            return this._buyerPaysGasFees.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The MPP protocol version, for example "1" or "2".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property WwwAuthenticateHeaders. 
        /// <para>
        /// The raw <c>WWW-Authenticate: Payment</c> header value from the 402 response, passed
        /// verbatim. Provide exactly one entry. The service uses this value to generate the payment
        /// credential.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> WwwAuthenticateHeaders
        {
            get { return this._wwwAuthenticateHeaders; }
            set { this._wwwAuthenticateHeaders = value; }
        }

        // Check to see if WwwAuthenticateHeaders property is set
        internal bool IsSetWwwAuthenticateHeaders()
        {
            return this._wwwAuthenticateHeaders != null && (this._wwwAuthenticateHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}