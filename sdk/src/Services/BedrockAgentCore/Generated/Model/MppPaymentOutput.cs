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
    /// Contains the payment credential, ready to retry the request.
    /// </summary>
    public partial class MppPaymentOutput
    {
        private string _paymentCredential;
        private string _selectedPaymentId;
        private string _version;

        /// <summary>
        /// Gets and sets the property PaymentCredential. 
        /// <para>
        /// Ready-to-send value for the <c>Authorization</c> header, in the form "Payment &lt;base64url-token&gt;".
        /// Attach this header and retry the original request. To inspect the full credential,
        /// base64url-decode the token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=32768)]
        public string PaymentCredential
        {
            get { return this._paymentCredential; }
            set { this._paymentCredential = value; }
        }

        // Check to see if PaymentCredential property is set
        internal bool IsSetPaymentCredential()
        {
            return this._paymentCredential != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedPaymentId. 
        /// <para>
        /// The id of the challenge that was paid, echoed from the input challenge so you can
        /// correlate the result without decoding the credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SelectedPaymentId
        {
            get { return this._selectedPaymentId; }
            set { this._selectedPaymentId = value; }
        }

        // Check to see if SelectedPaymentId property is set
        internal bool IsSetSelectedPaymentId()
        {
            return this._selectedPaymentId != null;
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

    }
}