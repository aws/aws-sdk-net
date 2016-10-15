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
    /// The message template structure.
    /// </summary>
    public partial class MessageTemplateType
    {
        private string _emailMessage;
        private string _emailSubject;
        private string _smsMessage;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The message template for email messages.
        /// </para>
        /// </summary>
        public string EmailMessage
        {
            get { return this._emailMessage; }
            set { this._emailMessage = value; }
        }

        // Check to see if EmailMessage property is set
        internal bool IsSetEmailMessage()
        {
            return this._emailMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailSubject. 
        /// <para>
        /// The subject line for email messages.
        /// </para>
        /// </summary>
        public string EmailSubject
        {
            get { return this._emailSubject; }
            set { this._emailSubject = value; }
        }

        // Check to see if EmailSubject property is set
        internal bool IsSetEmailSubject()
        {
            return this._emailSubject != null;
        }

        /// <summary>
        /// Gets and sets the property SMSMessage. 
        /// <para>
        /// The message template for SMS messages.
        /// </para>
        /// </summary>
        public string SMSMessage
        {
            get { return this._smsMessage; }
            set { this._smsMessage = value; }
        }

        // Check to see if SMSMessage property is set
        internal bool IsSetSMSMessage()
        {
            return this._smsMessage != null;
        }

    }
}