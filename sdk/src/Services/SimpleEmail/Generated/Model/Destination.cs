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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the destination of the message, consisting of To:, CC:, and BCC: fields.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
    /// For this reason, the email address string must be 7-bit ASCII. If you want to send
    /// to or from email addresses that contain Unicode characters in the domain part of an
    /// address, you must encode the domain using Punycode. Punycode is not permitted in the
    /// local part of the email address (the part before the @ sign) nor in the "friendly
    /// from" name. If you want to use Unicode characters in the "friendly from" name, you
    /// must encode the "friendly from" name using MIME encoded-word syntax, as described
    /// in <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html">Sending
    /// raw email using the Amazon SES API</a>. For more information about Punycode, see <a
    /// href="http://tools.ietf.org/html/rfc3492">RFC 3492</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Destination
    {
        private List<string> _bccAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ccAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _toAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Destination() { }

        /// <summary>
        /// Instantiates Destination with the parameterized properties
        /// </summary>
        /// <param name="toAddresses">The recipients to place on the To: line of the message.</param>
        public Destination(List<string> toAddresses)
        {
            _toAddresses = toAddresses;
        }

        /// <summary>
        /// Gets and sets the property BccAddresses. 
        /// <para>
        /// The recipients to place on the BCC: line of the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BccAddresses
        {
            get { return this._bccAddresses; }
            set { this._bccAddresses = value; }
        }

        // Check to see if BccAddresses property is set
        internal bool IsSetBccAddresses()
        {
            return this._bccAddresses != null && (this._bccAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// The recipients to place on the CC: line of the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && (this._ccAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// The recipients to place on the To: line of the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && (this._toAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}