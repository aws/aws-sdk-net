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
    /// This is the response object from the CancelAgreementPaymentRequest operation.
    /// </summary>
    public partial class CancelAgreementPaymentRequestResponse : AmazonWebServiceResponse
    {
        private string _agreementId;
        private string _chargeAmount;
        private DateTime? _createdAt;
        private string _currencyCode;
        private string _description;
        private string _name;
        private string _paymentRequestId;
        private PaymentRequestStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with this payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The amount that was requested to be charged.
        /// </para>
        /// </summary>
        public string ChargeAmount
        {
            get { return this._chargeAmount; }
            set { this._chargeAmount = value; }
        }

        // Check to see if ChargeAmount property is set
        internal bool IsSetChargeAmount()
        {
            return this._chargeAmount != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the payment request was originally created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the charge amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the payment request, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentRequestId. 
        /// <para>
        /// The unique identifier of the cancelled payment request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PaymentRequestId
        {
            get { return this._paymentRequestId; }
            set { this._paymentRequestId = value; }
        }

        // Check to see if PaymentRequestId property is set
        internal bool IsSetPaymentRequestId()
        {
            return this._paymentRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status of the payment request, which is <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public PaymentRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the payment request was cancelled, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}