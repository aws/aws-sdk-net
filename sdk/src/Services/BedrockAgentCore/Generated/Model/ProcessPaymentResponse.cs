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
    /// Response structure for processing a payment
    /// </summary>
    public partial class ProcessPaymentResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _paymentInstrumentId;
        private string _paymentManagerArn;
        private PaymentOutput _paymentOutput;
        private string _paymentSessionId;
        private PaymentType _paymentType;
        private string _processPaymentId;
        private PaymentStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the payment was created.
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
        /// Gets and sets the property PaymentInstrumentId. 
        /// <para>
        /// The ID of the payment instrument used for this transaction.
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
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The ARN of the payment manager that processed this payment.
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
        /// Gets and sets the property PaymentOutput. 
        /// <para>
        /// The payment output details specific to the payment type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentOutput PaymentOutput
        {
            get { return this._paymentOutput; }
            set { this._paymentOutput = value; }
        }

        // Check to see if PaymentOutput property is set
        internal bool IsSetPaymentOutput()
        {
            return this._paymentOutput != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentSessionId. 
        /// <para>
        /// The ID of the payment session for this transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31, Max=31)]
        public string PaymentSessionId
        {
            get { return this._paymentSessionId; }
            set { this._paymentSessionId = value; }
        }

        // Check to see if PaymentSessionId property is set
        internal bool IsSetPaymentSessionId()
        {
            return this._paymentSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentType. 
        /// <para>
        /// The type of payment that was processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentType PaymentType
        {
            get { return this._paymentType; }
            set { this._paymentType = value; }
        }

        // Check to see if PaymentType property is set
        internal bool IsSetPaymentType()
        {
            return this._paymentType != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessPaymentId. 
        /// <para>
        /// The unique ID of the processed payment transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProcessPaymentId
        {
            get { return this._processPaymentId; }
            set { this._processPaymentId = value; }
        }

        // Check to see if ProcessPaymentId property is set
        internal bool IsSetProcessPaymentId()
        {
            return this._processPaymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the payment transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentStatus Status
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
        /// The timestamp when the payment was last updated.
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