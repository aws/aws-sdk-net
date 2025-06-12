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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BulkEmailEntry
    {
        private Destination _destination;
        private ReplacementEmailContent _replacementEmailContent;
        private List<MessageHeader> _replacementHeaders = AWSConfigs.InitializeCollections ? new List<MessageHeader>() : null;
        private List<MessageTag> _replacementTags = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Represents the destination of the message, consisting of To:, CC:, and BCC: fields.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
        /// For this reason, the local part of a destination email address (the part of the email
        /// address that precedes the @ sign) may only contain <a href="https://en.wikipedia.org/wiki/Email_address#Local-part">7-bit
        /// ASCII characters</a>. If the domain part of an address (the part after the @ sign)
        /// contains non-ASCII characters, they must be encoded using Punycode, as described in
        /// <a href="https://tools.ietf.org/html/rfc3492.html">RFC3492</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacementEmailContent. 
        /// <para>
        /// The <c>ReplacementEmailContent</c> associated with a <c>BulkEmailEntry</c>.
        /// </para>
        /// </summary>
        public ReplacementEmailContent ReplacementEmailContent
        {
            get { return this._replacementEmailContent; }
            set { this._replacementEmailContent = value; }
        }

        // Check to see if ReplacementEmailContent property is set
        internal bool IsSetReplacementEmailContent()
        {
            return this._replacementEmailContent != null;
        }

        /// <summary>
        /// Gets and sets the property ReplacementHeaders. 
        /// <para>
        /// The list of message headers associated with the <c>BulkEmailEntry</c> data type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Headers Not Present in <c>BulkEmailEntry</c>: If a header is specified in <a href="https://docs.aws.amazon.com/ses/latest/APIReference-V2/API_Template.html">
        /// <c>Template</c> </a> but not in <c>BulkEmailEntry</c>, the header from <c>Template</c>
        /// will be added to the outgoing email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Headers Present in <c>BulkEmailEntry</c>: If a header is specified in <c>BulkEmailEntry</c>,
        /// it takes precedence over any header of the same name specified in <a href="https://docs.aws.amazon.com/ses/latest/APIReference-V2/API_Template.html">
        /// <c>Template</c> </a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the header is also defined within <c>Template</c>, the value from <c>BulkEmailEntry</c>
        /// will replace the header's value in the email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the header is not defined within <c>Template</c>, it will simply be added to the
        /// email as specified in <c>BulkEmailEntry</c>.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<MessageHeader> ReplacementHeaders
        {
            get { return this._replacementHeaders; }
            set { this._replacementHeaders = value; }
        }

        // Check to see if ReplacementHeaders property is set
        internal bool IsSetReplacementHeaders()
        {
            return this._replacementHeaders != null && (this._replacementHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplacementTags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using the <c>SendBulkTemplatedEmail</c> operation. Tags correspond to characteristics
        /// of the email that you define, so that you can publish email sending events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> ReplacementTags
        {
            get { return this._replacementTags; }
            set { this._replacementTags = value; }
        }

        // Check to see if ReplacementTags property is set
        internal bool IsSetReplacementTags()
        {
            return this._replacementTags != null && (this._replacementTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}