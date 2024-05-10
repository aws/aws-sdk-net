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
    /// Parameters that are required for PIN data generation.
    /// </summary>
    public partial class PinGenerationAttributes
    {
        private Ibm3624NaturalPin _ibm3624NaturalPin;
        private Ibm3624PinFromOffset _ibm3624PinFromOffset;
        private Ibm3624PinOffset _ibm3624PinOffset;
        private Ibm3624RandomPin _ibm3624RandomPin;
        private VisaPin _visaPin;
        private VisaPinVerificationValue _visaPinVerificationValue;

        /// <summary>
        /// Gets and sets the property Ibm3624NaturalPin. 
        /// <para>
        /// Parameters that are required to generate or verify Ibm3624 natural PIN.
        /// </para>
        /// </summary>
        public Ibm3624NaturalPin Ibm3624NaturalPin
        {
            get { return this._ibm3624NaturalPin; }
            set { this._ibm3624NaturalPin = value; }
        }

        // Check to see if Ibm3624NaturalPin property is set
        internal bool IsSetIbm3624NaturalPin()
        {
            return this._ibm3624NaturalPin != null;
        }

        /// <summary>
        /// Gets and sets the property Ibm3624PinFromOffset. 
        /// <para>
        /// Parameters that are required to generate or verify Ibm3624 PIN from offset PIN.
        /// </para>
        /// </summary>
        public Ibm3624PinFromOffset Ibm3624PinFromOffset
        {
            get { return this._ibm3624PinFromOffset; }
            set { this._ibm3624PinFromOffset = value; }
        }

        // Check to see if Ibm3624PinFromOffset property is set
        internal bool IsSetIbm3624PinFromOffset()
        {
            return this._ibm3624PinFromOffset != null;
        }

        /// <summary>
        /// Gets and sets the property Ibm3624PinOffset. 
        /// <para>
        /// Parameters that are required to generate or verify Ibm3624 PIN offset PIN.
        /// </para>
        /// </summary>
        public Ibm3624PinOffset Ibm3624PinOffset
        {
            get { return this._ibm3624PinOffset; }
            set { this._ibm3624PinOffset = value; }
        }

        // Check to see if Ibm3624PinOffset property is set
        internal bool IsSetIbm3624PinOffset()
        {
            return this._ibm3624PinOffset != null;
        }

        /// <summary>
        /// Gets and sets the property Ibm3624RandomPin. 
        /// <para>
        /// Parameters that are required to generate or verify Ibm3624 random PIN.
        /// </para>
        /// </summary>
        public Ibm3624RandomPin Ibm3624RandomPin
        {
            get { return this._ibm3624RandomPin; }
            set { this._ibm3624RandomPin = value; }
        }

        // Check to see if Ibm3624RandomPin property is set
        internal bool IsSetIbm3624RandomPin()
        {
            return this._ibm3624RandomPin != null;
        }

        /// <summary>
        /// Gets and sets the property VisaPin. 
        /// <para>
        /// Parameters that are required to generate or verify Visa PIN.
        /// </para>
        /// </summary>
        public VisaPin VisaPin
        {
            get { return this._visaPin; }
            set { this._visaPin = value; }
        }

        // Check to see if VisaPin property is set
        internal bool IsSetVisaPin()
        {
            return this._visaPin != null;
        }

        /// <summary>
        /// Gets and sets the property VisaPinVerificationValue. 
        /// <para>
        /// Parameters that are required to generate or verify Visa PIN Verification Value (PVV).
        /// </para>
        /// </summary>
        public VisaPinVerificationValue VisaPinVerificationValue
        {
            get { return this._visaPinVerificationValue; }
            set { this._visaPinVerificationValue = value; }
        }

        // Check to see if VisaPinVerificationValue property is set
        internal bool IsSetVisaPinVerificationValue()
        {
            return this._visaPinVerificationValue != null;
        }

    }
}