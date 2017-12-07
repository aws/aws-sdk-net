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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the destination of the message, consisting of To:, CC:, and BCC: fields.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
    /// For this reason, the <i>local part</i> of a destination email address (the part of
    /// the email address that precedes the @ sign) may only contain <a href="https://en.wikipedia.org/wiki/Email_address#Local-part">7-bit
    /// ASCII characters</a>. If the <i>domain part</i> of an address (the part after the
    /// @ sign) contains non-ASCII characters, they must be encoded using Punycode, as described
    /// in <a href="https://tools.ietf.org/html/rfc3492.html">RFC3492</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Destination
    {
        private List<string> _bccAddresses = new List<string>();
        private List<string> _ccAddresses = new List<string>();
        private List<string> _toAddresses = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Destination() { }

        /// <summary>
        /// Instantiates Destination with the parameterized properties
        /// </summary>
        /// <param name="toAddresses">The To: field(s) of the message.</param>
        public Destination(List<string> toAddresses)
        {
            _toAddresses = toAddresses;
        }

        /// <summary>
        /// Gets and sets the property BccAddresses. 
        /// <para>
        /// The BCC: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> BccAddresses
        {
            get { return this._bccAddresses; }
            set { this._bccAddresses = value; }
        }

        // Check to see if BccAddresses property is set
        internal bool IsSetBccAddresses()
        {
            return this._bccAddresses != null && this._bccAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// The CC: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && this._ccAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// The To: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && this._toAddresses.Count > 0; 
        }

    }
}