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
    /// Represents a payment instrument
    /// </summary>
    public partial class PaymentInstrument
    {
        private DateTime? _createdAt;
        private string _paymentConnectorId;
        private PaymentInstrumentDetails _paymentInstrumentDetails;
        private string _paymentInstrumentId;
        private PaymentInstrumentType _paymentInstrumentType;
        private string _paymentManagerArn;
        private PaymentInstrumentStatus _status;
        private DateTime? _updatedAt;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this payment instrument was created.
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
        /// Gets and sets the property PaymentConnectorId. 
        /// <para>
        /// The ID of the payment connector associated with this instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=211)]
        public string PaymentConnectorId
        {
            get { return this._paymentConnectorId; }
            set { this._paymentConnectorId = value; }
        }

        // Check to see if PaymentConnectorId property is set
        internal bool IsSetPaymentConnectorId()
        {
            return this._paymentConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInstrumentDetails. 
        /// <para>
        /// The details specific to the payment instrument type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInstrumentDetails PaymentInstrumentDetails
        {
            get { return this._paymentInstrumentDetails; }
            set { this._paymentInstrumentDetails = value; }
        }

        // Check to see if PaymentInstrumentDetails property is set
        internal bool IsSetPaymentInstrumentDetails()
        {
            return this._paymentInstrumentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The unique identifier for this payment instrument.
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
        /// Gets and sets the property PaymentInstrumentType. 
        /// <para>
        /// The type of payment instrument (e.g., EMBEDDED_CRYPTO_WALLET).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInstrumentType PaymentInstrumentType
        {
            get { return this._paymentInstrumentType; }
            set { this._paymentInstrumentType = value; }
        }

        // Check to see if PaymentInstrumentType property is set
        internal bool IsSetPaymentInstrumentType()
        {
            return this._paymentInstrumentType != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that owns this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=66, Max=2048)]
        public string PaymentManagerArn
        {
            get { return this._paymentManagerArn; }
            set { this._paymentManagerArn = value; }
        }

        // Check to see if PaymentManagerArn property is set
        internal bool IsSetPaymentManagerArn()
        {
            return this._paymentManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentInstrumentStatus Status
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
        /// The timestamp when this payment instrument was last updated.
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

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID associated with this payment instrument.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=120)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}