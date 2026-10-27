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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation. Creates a new user in the
    /// user pool.
    /// </summary>
    public partial class CreateUserRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type for the user. You must specify USERPOOL. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name, or given name, of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name, or surname, of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MessageAction. 
        /// <para>
        /// The action to take for the welcome email that is sent to a user after the user is
        /// created in the user pool. If you specify SUPPRESS, no email is sent. If you specify
        /// RESEND, do not specify the first name or last name of the user. If the value is null,
        /// the email is sent. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The temporary password in the welcome email is valid for only 7 days. If users don’t
        /// set their passwords within 7 days, you must send them a new welcome email.
        /// </para>
        ///  </note>
        /// </summary>
        public MessageAction MessageAction { get; set; }

        /// <summary>
        /// Checks to see if the MessageAction property is set.
        /// </summary>
        internal bool IsSetMessageAction() => this.MessageAction != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The email address of the user.
        /// </para>
        ///  <note> 
        /// <para>
        /// Users' email addresses are case-sensitive. During login, if they specify an email
        /// address that doesn't use the same capitalization as the email address specified when
        /// their user pool account was created, a "user does not exist" error message displays.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
