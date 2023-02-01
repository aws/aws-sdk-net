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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Set of options which defines notification preferences of given action.
    /// </summary>
    public partial class NotificationOptions
    {
        private string _emailMessage;
        private bool? _sendEmail;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// Text value to be included in the email body.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property SendEmail. 
        /// <para>
        /// Boolean value to indicate an email notification should be sent to the receipients.
        /// </para>
        /// </summary>
        public bool SendEmail
        {
            get { return this._sendEmail.GetValueOrDefault(); }
            set { this._sendEmail = value; }
        }

        // Check to see if SendEmail property is set
        internal bool IsSetSendEmail()
        {
            return this._sendEmail.HasValue; 
        }

    }
}