/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The <c>VirtualMFADevice</c> data type contains information about a virtual MFA device.</para>
    /// </summary>
    public class VirtualMFADevice
    {
        
        private string serialNumber;
        private MemoryStream base32StringSeed;
        private MemoryStream qRCodePNG;
        private User user;
        private DateTime? enableDate;


        /// <summary>
        /// The serial number associated with <c>VirtualMFADevice</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>9 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=/:,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { this.serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this.serialNumber != null;
        }

        /// <summary>
        /// The Base32 seed defined as specified in <a href="http://www.ietf.org/rfc/rfc3548.txt" target="_blank">RFC3548</a>. The
        /// <c>Base32StringSeed</c> is Base64-encoded.
        ///  
        /// </summary>
        public MemoryStream Base32StringSeed
        {
            get { return this.base32StringSeed; }
            set { this.base32StringSeed = value; }
        }

        // Check to see if Base32StringSeed property is set
        internal bool IsSetBase32StringSeed()
        {
            return this.base32StringSeed != null;
        }

        /// <summary>
        /// A QR code PNG image that encodes <i>otpauth://totp/$virtualMFADeviceName@$AccountName? secret=$Base32String</i> where $virtualMFADeviceName
        /// is one of the create call arguments, AccountName is the user name if set (accountId otherwise), and Base32String is the seed in Base32
        /// format. The <c>Base32String</c> is Base64-encoded.
        ///  
        /// </summary>
        public MemoryStream QRCodePNG
        {
            get { return this.qRCodePNG; }
            set { this.qRCodePNG = value; }
        }

        // Check to see if QRCodePNG property is set
        internal bool IsSetQRCodePNG()
        {
            return this.qRCodePNG != null;
        }

        /// <summary>
        /// The User data type contains information about a user. This data type is used as a response element in the following actions: <ul>
        /// <li><a>CreateUser</a></li> <li><a>GetUser</a></li> <li><a>ListUsers</a></li> </ul>
        ///  
        /// </summary>
        public User User
        {
            get { return this.user; }
            set { this.user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this.user != null;
        }
        public DateTime EnableDate
        {
            get { return this.enableDate ?? default(DateTime); }
            set { this.enableDate = value; }
        }

        // Check to see if EnableDate property is set
        internal bool IsSetEnableDate()
        {
            return this.enableDate.HasValue;
        }
    }
}
