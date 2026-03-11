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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Additional parameters specified by the acceptor while accepting the variable payment
    /// term.
    /// </summary>
    public partial class VariablePaymentTermConfiguration
    {
        private string _expirationDuration;
        private PaymentRequestApprovalStrategy _paymentRequestApprovalStrategy;

        /// <summary>
        /// Gets and sets the property ExpirationDuration. 
        /// <para>
        /// Defines the duration after which a payment request is automatically approved if no
        /// further action is taken. This only applies when the payment request approval strategy
        /// is set to <c>AUTO_APPROVE_ON_EXPIRATION</c>. The duration is represented in the ISO_8601
        /// format (e.g., P10D for 10 days).
        /// </para>
        /// </summary>
        public string ExpirationDuration
        {
            get { return this._expirationDuration; }
            set { this._expirationDuration = value; }
        }

        // Check to see if ExpirationDuration property is set
        internal bool IsSetExpirationDuration()
        {
            return this._expirationDuration != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentRequestApprovalStrategy. 
        /// <para>
        /// Defines the strategy for approving payment requests. Values include <c>AUTO_APPROVE_ON_EXPIRATION</c>
        /// and <c>WAIT_FOR_APPROVAL</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentRequestApprovalStrategy PaymentRequestApprovalStrategy
        {
            get { return this._paymentRequestApprovalStrategy; }
            set { this._paymentRequestApprovalStrategy = value; }
        }

        // Check to see if PaymentRequestApprovalStrategy property is set
        internal bool IsSetPaymentRequestApprovalStrategy()
        {
            return this._paymentRequestApprovalStrategy != null;
        }

    }
}