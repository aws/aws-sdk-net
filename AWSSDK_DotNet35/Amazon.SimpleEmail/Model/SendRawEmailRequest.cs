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
    /// Container for the parameters to the SendRawEmail operation.
    /// Sends an email message, with header and content specified by the client. The     
    ///       <code>SendRawEmail</code>            action is useful for sending multipart
    /// MIME emails. The raw text of the message must comply with Internet            email
    /// standards; otherwise, the message cannot be sent.        
    /// 
    ///         <important>            You can only send email from verified email addresses
    /// and domains.             If you have not requested production access to Amazon SES,
    /// you must also             verify every recipient email address except for the recipients
    /// provided             by the Amazon SES mailbox simulator. For more information, go
    /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
    /// SES                Developer Guide</a>.        </important>        
    /// <para>
    /// The total size of the message cannot exceed 10 MB. This includes any attachments that
    /// are part of the message.
    /// </para>
    ///         
    /// <para>
    /// Amazon SES has a limit on the total number of recipients per message: The combined
    /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
    /// to send an email            message to a larger audience, you can divide your recipient
    /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
    /// send the message to each group.        
    /// </para>
    ///         
    /// <para>
    /// The To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
    /// each recipient in a group list         counts towards the 50-recipient limit.    
    ///    
    /// </para>
    ///         
    /// <para>
    /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
    /// is            counted against your            <i>sending quota</i>            - the
    /// maximum number of emails you can send in            a 24-hour period. For information
    /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
    /// SES                Developer Guide</a>.        
    /// </para>
    /// </summary>
    public partial class SendRawEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _destinations = new List<string>();
        private RawMessage _rawMessage;
        private string _source;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendRawEmailRequest() { }

        /// <summary>
        /// Instantiates SendRawEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="rawMessage">The raw text of the message. The client is responsible for ensuring the following:     <ul>    <li>Message must contain a header and a body, separated by a blank line.</li>    <li>All required header fields must be present.</li>    <li>Each part of a multipart MIME message must be formatted properly.</li>    <li>MIME content types must be among those supported by Amazon SES. For more information, go to the     <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon SES      Developer Guide</a>.    </li>    <li>Content must be base64-encoded, if MIME requires it.</li>   </ul>  </param>
        public SendRawEmailRequest(RawMessage rawMessage)
        {
            _rawMessage = rawMessage;
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of destinations for the message, consisting of To:, CC:, and BCC: addresses.
        /// </para>
        /// </summary>
        public List<string> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RawMessage. 
        /// <para>
        /// The raw text of the message. The client is responsible for ensuring the following:
        /// </para>
        ///         
        /// <para>
        ///             <ul>                <li>Message must contain a header and a body, separated
        /// by a blank line.</li>                <li>All required header fields must be present.</li>
        ///                <li>Each part of a multipart MIME message must be formatted properly.</li>
        ///                <li>MIME content types must be among those supported by Amazon SES.
        /// For more information, go to the                    <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon
        /// SES                        Developer Guide</a>.                </li>             
        ///   <li>Content must be base64-encoded, if MIME requires it.</li>            </ul> 
        ///       
        /// </para>
        /// </summary>
        public RawMessage RawMessage
        {
            get { return this._rawMessage; }
            set { this._rawMessage = value; }
        }

        // Check to see if RawMessage property is set
        internal bool IsSetRawMessage()
        {
            return this._rawMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The identity's email address.
        /// </para>
        ///         
        /// <para>
        ///             By default, the string must be 7-bit ASCII. If the text must contain any
        /// other characters,             then you must use MIME encoded-word syntax (RFC 2047)
        /// instead of a literal string.             MIME encoded-word syntax uses the following
        /// form: <code>=?charset?encoding?encoded-text?=</code>.             For more information,
        /// see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.        
        /// </para>
        ///         <note>If you specify the            <code>Source</code>            parameter
        /// and have feedback forwarding enabled, then bounces and            complaints will
        /// be sent to this email address. This takes precedence over any            <i>Return-Path</i>
        ///            header that you might include in the raw text of the message.        </note>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}