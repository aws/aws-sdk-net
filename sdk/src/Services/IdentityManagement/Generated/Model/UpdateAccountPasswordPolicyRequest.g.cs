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
    /// Container for the parameters to the UpdateAccountPasswordPolicy operation. Updates
    /// the password policy settings for the Amazon Web Services account. <note> <para> This
    /// operation does not support partial updates. No parameters are required, but if you
    /// do not specify a parameter, that parameter's value reverts to its default value. See
    /// the <b>Request Parameters</b> section for each parameter's default value. Also note
    /// that some parameters do not allow the default parameter to be explicitly set. Instead,
    /// to invoke the default value, do not include that parameter when you invoke the operation.
    /// </para> </note> <para> For more information about using a password policy, see <a
    /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
    /// an IAM password policy</a> in the <i>IAM User Guide</i>. </para>
    /// </summary>
    public partial class UpdateAccountPasswordPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AllowUsersToChangePassword. 
        /// <para>
        ///  Allows all IAM users in your account to use the Amazon Web Services Management Console
        /// to change their own passwords. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_enable-user-change.html">Permitting
        /// IAM users to change their own passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that IAM users in the account do not automatically
        /// have permissions to change their own password.
        /// </para>
        /// </summary>
        public bool? AllowUsersToChangePassword { get; set; }

        /// <summary>
        /// Checks to see if the AllowUsersToChangePassword property is set.
        /// </summary>
        internal bool IsSetAllowUsersToChangePassword() => this.AllowUsersToChangePassword.HasValue;

        /// <summary>
        /// Gets and sets the property HardExpiry. 
        /// <para>
        ///  Prevents IAM users who are accessing the account via the Amazon Web Services Management
        /// Console from setting a new console password after their password has expired. The
        /// IAM user cannot access the console until an administrator resets the password.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that IAM users can change their passwords after
        /// they expire and continue to sign in as the user.
        /// </para>
        ///  <note> 
        /// <para>
        ///  In the Amazon Web Services Management Console, the custom password policy option
        /// <b>Allow users to change their own password</b> gives IAM users permissions to <c>iam:ChangePassword</c>
        /// for only their user and to the <c>iam:GetAccountPasswordPolicy</c> action. This option
        /// does not attach a permissions policy to each user, rather the permissions are applied
        /// at the account-level for all users by IAM. IAM users with <c>iam:ChangePassword</c>
        /// permission and active access keys can reset their own expired console password using
        /// the CLI or API.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? HardExpiry { get; set; }

        /// <summary>
        /// Checks to see if the HardExpiry property is set.
        /// </summary>
        internal bool IsSetHardExpiry() => this.HardExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPasswordAge. 
        /// <para>
        /// The number of days that an IAM user password is valid.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>0</c>. The result is that IAM user passwords never expire.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1095)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// Checks to see if the MaxPasswordAge property is set.
        /// </summary>
        internal bool IsSetMaxPasswordAge() => this.MaxPasswordAge.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumPasswordLength. 
        /// <para>
        /// The minimum number of characters allowed in an IAM user password.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 128)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// Checks to see if the MinimumPasswordLength property is set.
        /// </summary>
        internal bool IsSetMinimumPasswordLength() => this.MinimumPasswordLength.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordReusePrevention. 
        /// <para>
        /// Specifies the number of previous passwords that IAM users are prevented from reusing.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>0</c>. The result is that IAM users are not prevented from reusing previous
        /// passwords.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// Checks to see if the PasswordReusePrevention property is set.
        /// </summary>
        internal bool IsSetPasswordReusePrevention() => this.PasswordReusePrevention.HasValue;

        /// <summary>
        /// Gets and sets the property RequireLowercaseCharacters. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one lowercase character
        /// from the ISO basic Latin alphabet (a to z).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that passwords do not require at least one lowercase
        /// character.
        /// </para>
        /// </summary>
        public bool? RequireLowercaseCharacters { get; set; }

        /// <summary>
        /// Checks to see if the RequireLowercaseCharacters property is set.
        /// </summary>
        internal bool IsSetRequireLowercaseCharacters() => this.RequireLowercaseCharacters.HasValue;

        /// <summary>
        /// Gets and sets the property RequireNumbers. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one numeric character (0
        /// to 9).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that passwords do not require at least one numeric
        /// character.
        /// </para>
        /// </summary>
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// Checks to see if the RequireNumbers property is set.
        /// </summary>
        internal bool IsSetRequireNumbers() => this.RequireNumbers.HasValue;

        /// <summary>
        /// Gets and sets the property RequireSymbols. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one of the following non-alphanumeric
        /// characters:
        /// </para>
        ///  
        /// <para>
        /// ! @ # $ % ^ &amp; * ( ) _ + - = [ ] { } | '
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that passwords do not require at least one symbol
        /// character.
        /// </para>
        /// </summary>
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// Checks to see if the RequireSymbols property is set.
        /// </summary>
        internal bool IsSetRequireSymbols() => this.RequireSymbols.HasValue;

        /// <summary>
        /// Gets and sets the property RequireUppercaseCharacters. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one uppercase character
        /// from the ISO basic Latin alphabet (A to Z).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for this parameter, then the operation uses the default
        /// value of <c>false</c>. The result is that passwords do not require at least one uppercase
        /// character.
        /// </para>
        /// </summary>
        public bool? RequireUppercaseCharacters { get; set; }

        /// <summary>
        /// Checks to see if the RequireUppercaseCharacters property is set.
        /// </summary>
        internal bool IsSetRequireUppercaseCharacters() => this.RequireUppercaseCharacters.HasValue;
    }
}
