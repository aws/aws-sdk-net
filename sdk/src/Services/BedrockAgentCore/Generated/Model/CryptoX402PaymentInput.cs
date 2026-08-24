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
    /// The input for a crypto X402 payment.
    /// </summary>
    public partial class CryptoX402PaymentInput
    {
        private Amazon.Runtime.Documents.Document _payload;
        private string _permit2AllowanceLimit;
        private string _version;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The X402 payment payload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Amazon.Runtime.Documents.Document Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return !this._payload.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Permit2AllowanceLimit. 
        /// <para>
        /// The maximum on-chain Permit2 allowance to grant before signing the payment authorization,
        /// in the asset's smallest denomination. This field is valid only for the <c>upto</c>
        /// (metered) scheme; supplying it for the <c>exact</c> scheme returns a validation error.
        /// </para>
        ///  
        /// <para>
        /// When set, the service approves an ERC-20 allowance for this amount before processing
        /// the payment. The approval sets, rather than adds to, the wallet's allowance. Set this
        /// field only when the wallet needs approving, for example on its first <c>upto</c> payment,
        /// to avoid a redundant on-chain transaction. Omit the field to skip allowance handling.
        /// This is the default, and the only behavior for the <c>exact</c> scheme.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=78)]
        public string Permit2AllowanceLimit
        {
            get { return this._permit2AllowanceLimit; }
            set { this._permit2AllowanceLimit = value; }
        }

        // Check to see if Permit2AllowanceLimit property is set
        internal bool IsSetPermit2AllowanceLimit()
        {
            return this._permit2AllowanceLimit != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the X402 protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}