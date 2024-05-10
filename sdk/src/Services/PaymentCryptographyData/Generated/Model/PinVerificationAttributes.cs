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
    /// Parameters that are required for PIN data verification.
    /// </summary>
    public partial class PinVerificationAttributes
    {
        private Ibm3624PinVerification _ibm3624Pin;
        private VisaPinVerification _visaPin;

        /// <summary>
        /// Gets and sets the property Ibm3624Pin. 
        /// <para>
        /// Parameters that are required to generate or verify Ibm3624 PIN.
        /// </para>
        /// </summary>
        public Ibm3624PinVerification Ibm3624Pin
        {
            get { return this._ibm3624Pin; }
            set { this._ibm3624Pin = value; }
        }

        // Check to see if Ibm3624Pin property is set
        internal bool IsSetIbm3624Pin()
        {
            return this._ibm3624Pin != null;
        }

        /// <summary>
        /// Gets and sets the property VisaPin. 
        /// <para>
        /// Parameters that are required to generate or verify Visa PIN.
        /// </para>
        /// </summary>
        public VisaPinVerification VisaPin
        {
            get { return this._visaPin; }
            set { this._visaPin = value; }
        }

        // Check to see if VisaPin property is set
        internal bool IsSetVisaPin()
        {
            return this._visaPin != null;
        }

    }
}