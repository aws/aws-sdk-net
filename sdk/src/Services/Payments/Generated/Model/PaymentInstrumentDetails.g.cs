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
    /// The details that are specific to a payment instrument's payment method.
    /// </summary>
    public partial class PaymentInstrumentDetails
    {
        /// <summary>
        /// Gets and sets the property Card. 
        /// <para>
        /// The details of a card payment instrument.
        /// </para>
        /// </summary>
        public Card Card { get; set; }

        /// <summary>
        /// Checks to see if the Card property is set.
        /// </summary>
        internal bool IsSetCard() => this.Card != null;

        /// <summary>
        /// Gets and sets the property CnBankRedirect. 
        /// <para>
        /// The details of a China bank redirect instrument.
        /// </para>
        /// </summary>
        public CnBankRedirect CnBankRedirect { get; set; }

        /// <summary>
        /// Checks to see if the CnBankRedirect property is set.
        /// </summary>
        internal bool IsSetCnBankRedirect() => this.CnBankRedirect != null;

        /// <summary>
        /// Gets and sets the property InNetBanking. 
        /// <para>
        /// The details of an India net banking instrument.
        /// </para>
        /// </summary>
        public InNetBanking InNetBanking { get; set; }

        /// <summary>
        /// Checks to see if the InNetBanking property is set.
        /// </summary>
        internal bool IsSetInNetBanking() => this.InNetBanking != null;

        /// <summary>
        /// Gets and sets the property SepaBankAccount. 
        /// <para>
        /// The details of a bank account that is debited over Single Euro Payments Area (SEPA)
        /// Direct Debit.
        /// </para>
        /// </summary>
        public SepaBankAccount SepaBankAccount { get; set; }

        /// <summary>
        /// Checks to see if the SepaBankAccount property is set.
        /// </summary>
        internal bool IsSetSepaBankAccount() => this.SepaBankAccount != null;

        /// <summary>
        /// Gets and sets the property UkBacsBankAccount. 
        /// <para>
        /// The details of a bank account that is debited over Bacs Direct Debit.
        /// </para>
        /// </summary>
        public UkBacsBankAccount UkBacsBankAccount { get; set; }

        /// <summary>
        /// Checks to see if the UkBacsBankAccount property is set.
        /// </summary>
        internal bool IsSetUkBacsBankAccount() => this.UkBacsBankAccount != null;

        /// <summary>
        /// Gets and sets the property Upi. 
        /// <para>
        /// The details of a Unified Payments Interface (UPI) instrument.
        /// </para>
        /// </summary>
        public Upi Upi { get; set; }

        /// <summary>
        /// Checks to see if the Upi property is set.
        /// </summary>
        internal bool IsSetUpi() => this.Upi != null;

        /// <summary>
        /// Gets and sets the property UsAchBankAccount. 
        /// <para>
        /// The details of a bank account that is debited over Automated Clearing House (ACH).
        /// </para>
        /// </summary>
        public UsAchBankAccount UsAchBankAccount { get; set; }

        /// <summary>
        /// Checks to see if the UsAchBankAccount property is set.
        /// </summary>
        internal bool IsSetUsAchBankAccount() => this.UsAchBankAccount != null;
    }
}
