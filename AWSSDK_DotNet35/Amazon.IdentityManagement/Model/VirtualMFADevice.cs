/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// The <code>VirtualMFADevice</code> data type contains information about a virtual MFA
    /// device.
    /// </summary>
    public partial class VirtualMFADevice
    {
        private MemoryStream _base32StringSeed;
        private DateTime? _enableDate;
        private MemoryStream _qRCodePNG;
        private string _serialNumber;
        private User _user;

        /// <summary>
        /// Gets and sets the property Base32StringSeed. 
        /// <para>
        /// The Base32 seed defined as specified in <a href="http://www.ietf.org/rfc/rfc3548.txt">RFC3548</a>.
        /// The <code>Base32StringSeed</code> is Base64-encoded.
        /// </para>
        /// </summary>
        public MemoryStream Base32StringSeed
        {
            get { return this._base32StringSeed; }
            set { this._base32StringSeed = value; }
        }

        // Check to see if Base32StringSeed property is set
        internal bool IsSetBase32StringSeed()
        {
            return this._base32StringSeed != null;
        }

        /// <summary>
        /// Gets and sets the property EnableDate.
        /// </summary>
        public DateTime EnableDate
        {
            get { return this._enableDate.GetValueOrDefault(); }
            set { this._enableDate = value; }
        }

        // Check to see if EnableDate property is set
        internal bool IsSetEnableDate()
        {
            return this._enableDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QRCodePNG. 
        /// <para>
        /// A QR code PNG image that encodes <i>otpauth://totp/$virtualMFADeviceName@$AccountName?
        /// secret=$Base32String</i> where $virtualMFADeviceName is one of the create call arguments,
        /// AccountName is the user name if set (accountId otherwise), and Base32String is the
        /// seed in Base32 format. The <code>Base32String</code> is Base64-encoded.
        /// </para>
        /// </summary>
        public MemoryStream QRCodePNG
        {
            get { return this._qRCodePNG; }
            set { this._qRCodePNG = value; }
        }

        // Check to see if QRCodePNG property is set
        internal bool IsSetQRCodePNG()
        {
            return this._qRCodePNG != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number associated with <code>VirtualMFADevice</code>.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property User.
        /// </summary>
        public User User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}