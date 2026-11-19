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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLoginProfile operation. Changes the password
    /// or the maximum sign-in session duration for the specified IAM user. You can use the
    /// CLI, the Amazon Web Services API, or the <b>Users</b> page in the IAM console to change
    /// the password for any IAM user. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
    /// to change your own password in the <b>My Security Credentials</b> page in the Amazon
    /// Web Services Management Console. <para> For more information about modifying passwords,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
    /// passwords</a> in the <i>IAM User Guide</i>. </para>
    /// </summary>
    public partial class UpdateLoginProfileRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateLoginProfileRequest() { }

        /// <summary>
        /// Instantiates UpdateLoginProfileRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user whose password you want to update.   This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric  characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public UpdateLoginProfileRequest(string userName)
        {
            this.UserName = userName;
        }

        /// <summary>
        /// Gets and sets the property MaxSigninSessionDuration. 
        /// <para>
        /// The maximum duration (in seconds) of an Amazon Web Services Sign-In session for the
        /// specified IAM user. This setting can have a value from 1 hour (3600 seconds) to 90
        /// days (7776000 seconds), inclusive, and replaces any value currently configured for
        /// the user.
        /// </para>
        ///  
        /// <para>
        /// If you omit both this parameter and <c>ResetMaxSigninSessionDuration</c>, the current
        /// setting is unchanged. You cannot specify this parameter and set <c>ResetMaxSigninSessionDuration</c>
        /// to <c>true</c> in the same request. If you update only the sign-in session duration,
        /// the user's password and <c>PasswordResetRequired</c> setting do not change.
        /// </para>
        ///  
        /// <para>
        /// Changes to this setting apply to new sign-in sessions. Sessions that are already established
        /// are not affected.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is not supported for the root user.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 3600, Max = 7776000)]
        public int? MaxSigninSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSigninSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSigninSessionDuration() => this.MaxSigninSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The new password for the specified IAM user.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<c>\u0020</c>) through
        /// the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <c>\u00FF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage
        /// return (<c>\u000D</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// However, the format can be further restricted by the account administrator by setting
        /// a password policy on the Amazon Web Services account. For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAccountPasswordPolicy.html">UpdateAccountPasswordPolicy</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property PasswordResetRequired. 
        /// <para>
        /// Allows this new password to be used only once by requiring the specified IAM user
        /// to set a new password on next sign-in.
        /// </para>
        /// </summary>
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// Checks to see if the PasswordResetRequired property is set.
        /// </summary>
        internal bool IsSetPasswordResetRequired() => this.PasswordResetRequired.HasValue;

        /// <summary>
        /// Gets and sets the property ResetMaxSigninSessionDuration. 
        /// <para>
        /// Specifies whether to clear the maximum sign-in session duration for the specified
        /// IAM user. Set this value to <c>true</c> to return the setting to its unset state,
        /// so that the existing sign-in session behavior applies. When the setting is unset,
        /// the user's <c>MaxSigninSessionDuration</c> is omitted from responses.
        /// </para>
        ///  
        /// <para>
        /// If you set this value to <c>false</c> or omit it, the current setting is not cleared.
        /// You cannot set this value to <c>true</c> and specify <c>MaxSigninSessionDuration</c>
        /// in the same request. Clearing a setting that is already unset has no effect.
        /// </para>
        /// </summary>
        public bool? ResetMaxSigninSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the ResetMaxSigninSessionDuration property is set.
        /// </summary>
        internal bool IsSetResetMaxSigninSessionDuration() => this.ResetMaxSigninSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose password you want to update.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
