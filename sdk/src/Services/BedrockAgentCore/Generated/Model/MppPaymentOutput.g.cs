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
    /// Contains the payment credential, ready to retry the request.
    /// </summary>
    public partial class MppPaymentOutput
    {
        /// <summary>
        /// Gets and sets the property PaymentCredential. 
        /// <para>
        /// Ready-to-send value for the <c>Authorization</c> header, in the form "Payment &lt;base64url-token&gt;".
        /// Attach this header and retry the original request. To inspect the full credential,
        /// base64url-decode the token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 32768)]
        public string PaymentCredential { get; set; }

        /// <summary>
        /// Checks to see if the PaymentCredential property is set.
        /// </summary>
        internal bool IsSetPaymentCredential() => this.PaymentCredential != null;

        /// <summary>
        /// Gets and sets the property SelectedPaymentId. 
        /// <para>
        /// The id of the challenge that was paid, echoed from the input challenge so you can
        /// correlate the result without decoding the credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SelectedPaymentId { get; set; }

        /// <summary>
        /// Checks to see if the SelectedPaymentId property is set.
        /// </summary>
        internal bool IsSetSelectedPaymentId() => this.SelectedPaymentId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The MPP protocol version, for example "1" or "2".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
