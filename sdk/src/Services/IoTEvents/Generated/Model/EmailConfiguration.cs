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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains the configuration information of email notifications.
    /// </summary>
    public partial class EmailConfiguration
    {
        private EmailContent _content;
        private string _from;
        private EmailRecipients _recipients;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains the subject and message of an email.
        /// </para>
        /// </summary>
        public EmailContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The email address that sends emails.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use the AWS IoT Events managed AWS Lambda function to manage your emails, you
        /// must <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-email-addresses.html">verify
        /// the email address that sends emails in Amazon SES</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Recipients. 
        /// <para>
        /// Contains the information of one or more recipients who receive the emails.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/addusers.html">add
        /// the users that receive emails to your AWS SSO store</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public EmailRecipients Recipients
        {
            get { return this._recipients; }
            set { this._recipients = value; }
        }

        // Check to see if Recipients property is set
        internal bool IsSetRecipients()
        {
            return this._recipients != null;
        }

    }
}