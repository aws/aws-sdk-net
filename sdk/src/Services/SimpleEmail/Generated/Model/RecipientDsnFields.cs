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
    /// Recipient-related information to include in the Delivery Status Notification (DSN)
    /// when an email that Amazon SES receives on your behalf bounces.
    /// 
    ///  
    /// <para>
    /// For information about receiving email through Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class RecipientDsnFields
    {
        private DsnAction _action;
        private string _diagnosticCode;
        private List<ExtensionField> _extensionFields = new List<ExtensionField>();
        private string _finalRecipient;
        private DateTime? _lastAttemptDate;
        private string _remoteMta;
        private string _status;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action performed by the reporting mail transfer agent (MTA) as a result of its
        /// attempt to deliver the message to the recipient address. This is required by <a href="https://tools.ietf.org/html/rfc3464">RFC
        /// 3464</a>.
        /// </para>
        /// </summary>
        public DsnAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property DiagnosticCode. 
        /// <para>
        /// An extended explanation of what went wrong; this is usually an SMTP response. See
        /// <a href="https://tools.ietf.org/html/rfc3463">RFC 3463</a> for the correct formatting
        /// of this parameter.
        /// </para>
        /// </summary>
        public string DiagnosticCode
        {
            get { return this._diagnosticCode; }
            set { this._diagnosticCode = value; }
        }

        // Check to see if DiagnosticCode property is set
        internal bool IsSetDiagnosticCode()
        {
            return this._diagnosticCode != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionFields. 
        /// <para>
        /// Additional X-headers to include in the DSN.
        /// </para>
        /// </summary>
        public List<ExtensionField> ExtensionFields
        {
            get { return this._extensionFields; }
            set { this._extensionFields = value; }
        }

        // Check to see if ExtensionFields property is set
        internal bool IsSetExtensionFields()
        {
            return this._extensionFields != null && this._extensionFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FinalRecipient. 
        /// <para>
        /// The email address to which the message was ultimately delivered. This corresponds
        /// to the <code>Final-Recipient</code> in the DSN. If not specified, <code>FinalRecipient</code>
        /// will be set to the <code>Recipient</code> specified in the <code>BouncedRecipientInfo</code>
        /// structure. Either <code>FinalRecipient</code> or the recipient in <code>BouncedRecipientInfo</code>
        /// must be a recipient of the original bounced message.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not prepend the <code>FinalRecipient</code> email address with <code>rfc 822;</code>,
        /// as described in <a href="https://tools.ietf.org/html/rfc3798">RFC 3798</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string FinalRecipient
        {
            get { return this._finalRecipient; }
            set { this._finalRecipient = value; }
        }

        // Check to see if FinalRecipient property is set
        internal bool IsSetFinalRecipient()
        {
            return this._finalRecipient != null;
        }

        /// <summary>
        /// Gets and sets the property LastAttemptDate. 
        /// <para>
        /// The time the final delivery attempt was made, in <a href="https://www.ietf.org/rfc/rfc0822.txt">RFC
        /// 822</a> date-time format.
        /// </para>
        /// </summary>
        public DateTime LastAttemptDate
        {
            get { return this._lastAttemptDate.GetValueOrDefault(); }
            set { this._lastAttemptDate = value; }
        }

        // Check to see if LastAttemptDate property is set
        internal bool IsSetLastAttemptDate()
        {
            return this._lastAttemptDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoteMta. 
        /// <para>
        /// The MTA to which the remote MTA attempted to deliver the message, formatted as specified
        /// in <a href="https://tools.ietf.org/html/rfc3464">RFC 3464</a> (<code>mta-name-type;
        /// mta-name</code>). This parameter typically applies only to propagating synchronous
        /// bounces.
        /// </para>
        /// </summary>
        public string RemoteMta
        {
            get { return this._remoteMta; }
            set { this._remoteMta = value; }
        }

        // Check to see if RemoteMta property is set
        internal bool IsSetRemoteMta()
        {
            return this._remoteMta != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status code that indicates what went wrong. This is required by <a href="https://tools.ietf.org/html/rfc3464">RFC
        /// 3464</a>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}