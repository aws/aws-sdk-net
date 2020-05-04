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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInvitations operation.
    /// Sends an Amazon Macie membership invitation to one or more accounts.
    /// </summary>
    public partial class CreateInvitationsRequest : AmazonMacie2Request
    {
        private List<string> _accountIds = new List<string>();
        private bool? _disableEmailNotification;
        private string _message;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// An array that lists AWS account IDs, one for each account to send the invitation to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableEmailNotification. 
        /// <para>
        /// Specifies whether to send an email notification to the root user of each account that
        /// the invitation will be sent to. This notification is in addition to an alert that
        /// the root user receives in AWS Personal Health Dashboard. To send an email notification
        /// to the root user of each account, set this value to true.
        /// </para>
        /// </summary>
        public bool DisableEmailNotification
        {
            get { return this._disableEmailNotification.GetValueOrDefault(); }
            set { this._disableEmailNotification = value; }
        }

        // Check to see if DisableEmailNotification property is set
        internal bool IsSetDisableEmailNotification()
        {
            return this._disableEmailNotification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A custom message to include in the invitation. Amazon Macie adds this message to the
        /// standard content that it sends for an invitation.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}