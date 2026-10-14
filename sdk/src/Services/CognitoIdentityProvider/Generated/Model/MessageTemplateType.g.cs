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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The message template structure.
    /// </summary>
    public partial class MessageTemplateType
    {
        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The message template for email messages. EmailMessage is allowed only if <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is DEVELOPER. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 20000)]
        public string EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property EmailSubject. 
        /// <para>
        /// The subject line for email messages. EmailSubject is allowed only if <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is DEVELOPER. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// Checks to see if the EmailSubject property is set.
        /// </summary>
        internal bool IsSetEmailSubject() => this.EmailSubject != null;

        /// <summary>
        /// Gets and sets the property SMSMessage. 
        /// <para>
        /// The message template for SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 140)]
        public string SMSMessage { get; set; }

        /// <summary>
        /// Checks to see if the SMSMessage property is set.
        /// </summary>
        internal bool IsSetSMSMessage() => this.SMSMessage != null;
    }
}
