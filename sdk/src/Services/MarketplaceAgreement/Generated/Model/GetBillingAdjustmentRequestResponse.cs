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
    /// This is the response object from the GetBillingAdjustmentRequest operation.
    /// </summary>
    public partial class GetBillingAdjustmentRequestResponse : AmazonWebServiceResponse
    {
        private string _adjustmentAmount;
        private BillingAdjustmentReasonCode _adjustmentReasonCode;
        private string _agreementId;
        private string _billingAdjustmentRequestId;
        private DateTime? _createdAt;
        private string _currencyCode;
        private string _description;
        private string _originalInvoiceId;
        private BillingAdjustmentStatus _status;
        private string _statusMessage;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AdjustmentAmount. 
        /// <para>
        /// The adjustment amount as a string representation of a decimal number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdjustmentAmount
        {
            get { return this._adjustmentAmount; }
            set { this._adjustmentAmount = value; }
        }

        // Check to see if AdjustmentAmount property is set
        internal bool IsSetAdjustmentAmount()
        {
            return this._adjustmentAmount != null;
        }

        /// <summary>
        /// Gets and sets the property AdjustmentReasonCode. 
        /// <para>
        /// The reason code for the billing adjustment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillingAdjustmentReasonCode AdjustmentReasonCode
        {
            get { return this._adjustmentReasonCode; }
            set { this._adjustmentReasonCode = value; }
        }

        // Check to see if AdjustmentReasonCode property is set
        internal bool IsSetAdjustmentReasonCode()
        {
            return this._adjustmentReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement associated with this billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property BillingAdjustmentRequestId. 
        /// <para>
        /// The unique identifier of the billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BillingAdjustmentRequestId
        {
            get { return this._billingAdjustmentRequestId; }
            set { this._billingAdjustmentRequestId = value; }
        }

        // Check to see if BillingAdjustmentRequestId property is set
        internal bool IsSetBillingAdjustmentRequestId()
        {
            return this._billingAdjustmentRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the billing adjustment request was created, as a POSIX timestamp
        /// (Unix epoch seconds).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The currency code for the adjustment amount (e.g., <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
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
        /// The detailed description of the billing adjustment reason, if provided.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The identifier of the original invoice being adjusted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OriginalInvoiceId
        {
            get { return this._originalInvoiceId; }
            set { this._originalInvoiceId = value; }
        }

        // Check to see if OriginalInvoiceId property is set
        internal bool IsSetOriginalInvoiceId()
        {
            return this._originalInvoiceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the billing adjustment request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillingAdjustmentStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional context about the billing adjustment request status.
        /// This field is populated only when the status is <c>VALIDATION_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the billing adjustment request was last updated, as a POSIX
        /// timestamp (Unix epoch seconds).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}