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
    /// Parameters to derive a session key for Authorization Response Cryptogram (ARQC) verification.
    /// </summary>
    public partial class SessionKeyDerivation
    {
        private SessionKeyAmex _amex;
        private SessionKeyEmv2000 _emv2000;
        private SessionKeyEmvCommon _emvCommon;
        private SessionKeyMastercard _mastercard;
        private SessionKeyVisa _visa;

        /// <summary>
        /// Gets and sets the property Amex. 
        /// <para>
        /// Parameters to derive session key for an Amex payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyAmex Amex
        {
            get { return this._amex; }
            set { this._amex = value; }
        }

        // Check to see if Amex property is set
        internal bool IsSetAmex()
        {
            return this._amex != null;
        }

        /// <summary>
        /// Gets and sets the property Emv2000. 
        /// <para>
        /// Parameters to derive session key for an Emv2000 payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyEmv2000 Emv2000
        {
            get { return this._emv2000; }
            set { this._emv2000 = value; }
        }

        // Check to see if Emv2000 property is set
        internal bool IsSetEmv2000()
        {
            return this._emv2000 != null;
        }

        /// <summary>
        /// Gets and sets the property EmvCommon. 
        /// <para>
        /// Parameters to derive session key for an Emv common payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyEmvCommon EmvCommon
        {
            get { return this._emvCommon; }
            set { this._emvCommon = value; }
        }

        // Check to see if EmvCommon property is set
        internal bool IsSetEmvCommon()
        {
            return this._emvCommon != null;
        }

        /// <summary>
        /// Gets and sets the property Mastercard. 
        /// <para>
        /// Parameters to derive session key for a Mastercard payment card for ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyMastercard Mastercard
        {
            get { return this._mastercard; }
            set { this._mastercard = value; }
        }

        // Check to see if Mastercard property is set
        internal bool IsSetMastercard()
        {
            return this._mastercard != null;
        }

        /// <summary>
        /// Gets and sets the property Visa. 
        /// <para>
        /// Parameters to derive session key for a Visa payment cardfor ARQC verification.
        /// </para>
        /// </summary>
        public SessionKeyVisa Visa
        {
            get { return this._visa; }
            set { this._visa = value; }
        }

        // Check to see if Visa property is set
        internal bool IsSetVisa()
        {
            return this._visa != null;
        }

    }
}