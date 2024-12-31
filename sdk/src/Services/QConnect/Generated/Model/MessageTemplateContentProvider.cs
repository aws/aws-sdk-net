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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The container of message template content.
    /// </summary>
    public partial class MessageTemplateContentProvider
    {
        private EmailMessageTemplateContent _email;
        private SMSMessageTemplateContent _sms;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The content of the message template that applies to the email channel subtype.
        /// </para>
        /// </summary>
        public EmailMessageTemplateContent Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Sms. 
        /// <para>
        /// The content of the message template that applies to the SMS channel subtype.
        /// </para>
        /// </summary>
        public SMSMessageTemplateContent Sms
        {
            get { return this._sms; }
            set { this._sms = value; }
        }

        // Check to see if Sms property is set
        internal bool IsSetSms()
        {
            return this._sms != null;
        }

    }
}