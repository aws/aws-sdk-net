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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Set of options which defines notification preferences of given action.
    /// </summary>
    public partial class NotificationOptions
    {
        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// Text value to be included in the email body.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property SendEmail. 
        /// <para>
        /// Boolean value to indicate an email notification should be sent to the recipients.
        /// </para>
        /// </summary>
        public bool? SendEmail { get; set; }

        /// <summary>
        /// Checks to see if the SendEmail property is set.
        /// </summary>
        internal bool IsSetSendEmail() => this.SendEmail.HasValue;
    }
}
