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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters to derive the confidentiality and integrity keys for a Visa payment card.
    /// </summary>
    public partial class VisaAttributes
    {
        /// <summary>
        /// Gets and sets the property ApplicationTransactionCounter. 
        /// <para>
        /// The transaction counter of the current transaction that is provided by the terminal
        /// during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 4)]
        public string ApplicationTransactionCounter { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationTransactionCounter property is set.
        /// </summary>
        internal bool IsSetApplicationTransactionCounter() => this.ApplicationTransactionCounter != null;

        /// <summary>
        /// Gets and sets the property AuthorizationRequestKeyIdentifier. 
        /// <para>
        /// The <c>keyArn</c> of the issuer master key for cryptogram (IMK-AC) for the payment
        /// card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string AuthorizationRequestKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationRequestKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetAuthorizationRequestKeyIdentifier() => this.AuthorizationRequestKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property CurrentPinAttributes. 
        /// <para>
        /// The encrypted pinblock of the old pin stored on the chip card.
        /// </para>
        /// </summary>
        public CurrentPinAttributes CurrentPinAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPinAttributes property is set.
        /// </summary>
        internal bool IsSetCurrentPinAttributes() => this.CurrentPinAttributes != null;

        /// <summary>
        /// Gets and sets the property MajorKeyDerivationMode. 
        /// <para>
        /// The method to use when deriving the master key for the payment card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MajorKeyDerivationMode MajorKeyDerivationMode { get; set; }

        /// <summary>
        /// Checks to see if the MajorKeyDerivationMode property is set.
        /// </summary>
        internal bool IsSetMajorKeyDerivationMode() => this.MajorKeyDerivationMode != null;

        /// <summary>
        /// Gets and sets the property PanSequenceNumber. 
        /// <para>
        /// A number that identifies and differentiates payment cards with the same Primary Account
        /// Number (PAN). Typically 00 is used, if no value is provided by the terminal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string PanSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the PanSequenceNumber property is set.
        /// </summary>
        internal bool IsSetPanSequenceNumber() => this.PanSequenceNumber != null;

        /// <summary>
        /// Gets and sets the property PrimaryAccountNumber. 
        /// <para>
        /// The Primary Account Number (PAN) of the cardholder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 12, Max = 19)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountNumber property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountNumber() => this.PrimaryAccountNumber != null;
    }
}
