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
    /// Parameters that are required for DUKPT, HMAC, or EMV MAC generation or verification.
    /// </summary>
    public partial class MacAttributes
    {
        private MacAlgorithm _algorithm;
        private MacAlgorithmDukpt _dukptCmac;
        private MacAlgorithmDukpt _dukptIso9797Algorithm1;
        private MacAlgorithmDukpt _dukptIso9797Algorithm3;
        private MacAlgorithmEmv _emvMac;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The encryption algorithm for MAC generation or verification.
        /// </para>
        /// </summary>
        public MacAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property DukptCmac. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT CMAC algorithm.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptCmac
        {
            get { return this._dukptCmac; }
            set { this._dukptCmac = value; }
        }

        // Check to see if DukptCmac property is set
        internal bool IsSetDukptCmac()
        {
            return this._dukptCmac != null;
        }

        /// <summary>
        /// Gets and sets the property DukptIso9797Algorithm1. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT ISO 9797
        /// algorithm1.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptIso9797Algorithm1
        {
            get { return this._dukptIso9797Algorithm1; }
            set { this._dukptIso9797Algorithm1 = value; }
        }

        // Check to see if DukptIso9797Algorithm1 property is set
        internal bool IsSetDukptIso9797Algorithm1()
        {
            return this._dukptIso9797Algorithm1 != null;
        }

        /// <summary>
        /// Gets and sets the property DukptIso9797Algorithm3. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT ISO 9797
        /// algorithm3.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptIso9797Algorithm3
        {
            get { return this._dukptIso9797Algorithm3; }
            set { this._dukptIso9797Algorithm3 = value; }
        }

        // Check to see if DukptIso9797Algorithm3 property is set
        internal bool IsSetDukptIso9797Algorithm3()
        {
            return this._dukptIso9797Algorithm3 != null;
        }

        /// <summary>
        /// Gets and sets the property EmvMac. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using EMV MAC algorithm.
        /// </para>
        /// </summary>
        public MacAlgorithmEmv EmvMac
        {
            get { return this._emvMac; }
            set { this._emvMac = value; }
        }

        // Check to see if EmvMac property is set
        internal bool IsSetEmvMac()
        {
            return this._emvMac != null;
        }

    }
}