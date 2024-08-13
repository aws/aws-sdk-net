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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
    /// Parameters that are required to generate, translate, or verify PIN data.
    /// </summary>
    public partial class PinData
    {
        private string _pinOffset;
        private string _verificationValue;

        /// <summary>
        /// Gets and sets the property PinOffset. 
        /// <para>
        /// The PIN offset value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=12)]
        public string PinOffset
        {
            get { return this._pinOffset; }
            set { this._pinOffset = value; }
        }

        // Check to see if PinOffset property is set
        internal bool IsSetPinOffset()
        {
            return this._pinOffset != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationValue. 
        /// <para>
        /// The unique data to identify a cardholder. In most cases, this is the same as cardholder's
        /// Primary Account Number (PAN). If a value is not provided, it defaults to PAN.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=12)]
        public string VerificationValue
        {
            get { return this._verificationValue; }
            set { this._verificationValue = value; }
        }

        // Check to see if VerificationValue property is set
        internal bool IsSetVerificationValue()
        {
            return this._verificationValue != null;
        }

    }
}