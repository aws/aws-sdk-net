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
    /// The payment output details, which vary by payment type.
    /// </summary>
    public partial class PaymentOutput
    {
        /// <summary>
        /// Gets and sets the property CryptoX402. 
        /// <para>
        /// Output from a crypto X402 payment.
        /// </para>
        /// </summary>
        public CryptoX402PaymentOutput CryptoX402 { get; set; }

        /// <summary>
        /// Checks to see if the CryptoX402 property is set.
        /// </summary>
        internal bool IsSetCryptoX402() => this.CryptoX402 != null;

        /// <summary>
        /// Gets and sets the property Mpp.
        /// </summary>
        public MppPaymentOutput Mpp { get; set; }

        /// <summary>
        /// Checks to see if the Mpp property is set.
        /// </summary>
        internal bool IsSetMpp() => this.Mpp != null;
    }
}
