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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRenewal operation.
    /// Creates a renewal contract for the specified Outpost.
    /// </summary>
    public partial class CreateRenewalRequest : AmazonOutpostsRequest
    {
        private string _clientToken;
        private string _outpostIdentifier;
        private PaymentOption _paymentOption;
        private PaymentTerm _paymentTerm;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentTerm PaymentTerm
        {
            get { return this._paymentTerm; }
            set { this._paymentTerm = value; }
        }

        // Check to see if PaymentTerm property is set
        internal bool IsSetPaymentTerm()
        {
            return this._paymentTerm != null;
        }

    }
}