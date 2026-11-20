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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// A payment instrument on your account, such as a card or a bank account.
    /// </summary>
    public partial class PaymentInstrument
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instrument. To allow or deny <c>GetPaymentInstrument</c>
        /// for this instrument, use the ARN in the <c>Resource</c> element of an Amazon Web Services
        /// Identity and Access Management (IAM) policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC, when the instrument was registered.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details that are specific to the instrument's payment method. This member is absent
        /// for a payment method that has no additional details.
        /// </para>
        /// </summary>
        public PaymentInstrumentDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property PaymentMethod. 
        /// <para>
        /// The payment method of the instrument. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CARD</c> – A credit or debit card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>US_ACH_BANK_ACCOUNT</c> – A US bank account debited over Automated Clearing House
        /// (ACH).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEPA_BANK_ACCOUNT</c> – A bank account debited over Single Euro Payments Area
        /// (SEPA) Direct Debit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UK_BACS_BANK_ACCOUNT</c> – A UK bank account debited over Bacs Direct Debit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_NET_BANKING</c> – India net banking. You authorize each payment on your bank's
        /// website.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CN_BANK_REDIRECT</c> – China bank redirect. You authorize each payment on your
        /// bank's website.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPI</c> – Unified Payments Interface, the India real-time payment system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PIX</c> – Pix, the Brazilian Central Bank instant payment system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAY_BY_INVOICE</c> – Pay by invoice. You pay each invoice yourself, for example
        /// by bank transfer, instead of Amazon Web Services collecting payment from a card or
        /// a bank account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Checks to see if the PaymentMethod property is set.
        /// </summary>
        internal bool IsSetPaymentMethod() => this.PaymentMethod != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instrument. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – The instrument is set up, and Amazon Web Services can use it for
        /// payments. <c>ACTIVE</c> doesn't confirm that the instrument is verified or that a
        /// payment with it will succeed. You don't need to take action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID</c> – Amazon Web Services can't use the instrument for payments, for example
        /// because its Direct Debit or UPI mandate is no longer valid. This status is permanent.
        /// The instrument doesn't return to <c>ACTIVE</c>. To pay with this payment method again,
        /// add a new payment instrument.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_SETUP</c> – The instrument needs an action from you before Amazon Web
        /// Services can use it, such as resuming a paused UPI mandate in your UPI app. Amazon
        /// Web Services doesn't use the instrument for payments until you complete that action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SETUP_IN_PROGRESS</c> – You completed the setup steps, and setup of the instrument
        /// is in progress, for example while a Direct Debit or UPI mandate waits for confirmation.
        /// Amazon Web Services doesn't use the instrument for payments until setup is complete.
        /// You don't need to take action.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentInstrumentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC, when the instrument was last changed.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
