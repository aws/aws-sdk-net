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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The notify configuration type.
    /// </summary>
    public partial class NotifyConfigurationType
    {
        private NotifyEmailType _blockEmail;
        private string _from;
        private NotifyEmailType _mfaEmail;
        private NotifyEmailType _noActionEmail;
        private string _replyTo;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property BlockEmail. 
        /// <para>
        /// Email template used when a detected risk event is blocked.
        /// </para>
        /// </summary>
        public NotifyEmailType BlockEmail
        {
            get { return this._blockEmail; }
            set { this._blockEmail = value; }
        }

        // Check to see if BlockEmail property is set
        internal bool IsSetBlockEmail()
        {
            return this._blockEmail != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The email address that is sending the email. It must be either individually verified
        /// with Amazon SES, or from a domain that has been verified with Amazon SES.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property MfaEmail. 
        /// <para>
        /// The MFA email template used when MFA is challenged as part of a detected risk.
        /// </para>
        /// </summary>
        public NotifyEmailType MfaEmail
        {
            get { return this._mfaEmail; }
            set { this._mfaEmail = value; }
        }

        // Check to see if MfaEmail property is set
        internal bool IsSetMfaEmail()
        {
            return this._mfaEmail != null;
        }

        /// <summary>
        /// Gets and sets the property NoActionEmail. 
        /// <para>
        /// The email template used when a detected risk event is allowed.
        /// </para>
        /// </summary>
        public NotifyEmailType NoActionEmail
        {
            get { return this._noActionEmail; }
            set { this._noActionEmail = value; }
        }

        // Check to see if NoActionEmail property is set
        internal bool IsSetNoActionEmail()
        {
            return this._noActionEmail != null;
        }

        /// <summary>
        /// Gets and sets the property ReplyTo. 
        /// <para>
        /// The destination to which the receiver of an email should reply to.
        /// </para>
        /// </summary>
        public string ReplyTo
        {
            get { return this._replyTo; }
            set { this._replyTo = value; }
        }

        // Check to see if ReplyTo property is set
        internal bool IsSetReplyTo()
        {
            return this._replyTo != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity that is associated with the sending
        /// authorization policy. It permits Amazon Cognito to send for the email address specified
        /// in the <code>From</code> parameter.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}