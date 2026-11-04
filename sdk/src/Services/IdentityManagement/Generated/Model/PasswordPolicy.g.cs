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
    /// Contains information about the account password policy.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountPasswordPolicy.html">GetAccountPasswordPolicy</a>
    /// operation. 
    /// </para>
    /// </summary>
    public partial class PasswordPolicy
    {
        /// <summary>
        /// Gets and sets the property AllowUsersToChangePassword. 
        /// <para>
        /// Specifies whether IAM users are allowed to change their own password. Gives IAM users
        /// permissions to <c>iam:ChangePassword</c> for only their user and to the <c>iam:GetAccountPasswordPolicy</c>
        /// action. This option does not attach a permissions policy to each user, rather the
        /// permissions are applied at the account-level for all users by IAM.
        /// </para>
        /// </summary>
        public bool? AllowUsersToChangePassword { get; set; }

        /// <summary>
        /// Checks to see if the AllowUsersToChangePassword property is set.
        /// </summary>
        internal bool IsSetAllowUsersToChangePassword() => this.AllowUsersToChangePassword.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirePasswords. 
        /// <para>
        /// Indicates whether passwords in the account expire. Returns true if <c>MaxPasswordAge</c>
        /// contains a value greater than 0. Returns false if MaxPasswordAge is 0 or not present.
        /// </para>
        /// </summary>
        public bool? ExpirePasswords { get; set; }

        /// <summary>
        /// Checks to see if the ExpirePasswords property is set.
        /// </summary>
        internal bool IsSetExpirePasswords() => this.ExpirePasswords.HasValue;

        /// <summary>
        /// Gets and sets the property HardExpiry. 
        /// <para>
        /// Specifies whether IAM users are prevented from setting a new password via the Amazon
        /// Web Services Management Console after their password has expired. The IAM user cannot
        /// access the console until an administrator resets the password. IAM users with <c>iam:ChangePassword</c>
        /// permission and active access keys can reset their own expired console password using
        /// the CLI or API.
        /// </para>
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
        /// Minimum length to require for IAM user passwords.
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
        /// (a to z).
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
        /// </summary>
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// Checks to see if the RequireNumbers property is set.
        /// </summary>
        internal bool IsSetRequireNumbers() => this.RequireNumbers.HasValue;

        /// <summary>
        /// Gets and sets the property RequireSymbols. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one of the following symbols:
        /// </para>
        ///  
        /// <para>
        /// ! @ # $ % ^ &amp; * ( ) _ + - = [ ] { } | '
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
        /// (A to Z).
        /// </para>
        /// </summary>
        public bool? RequireUppercaseCharacters { get; set; }

        /// <summary>
        /// Checks to see if the RequireUppercaseCharacters property is set.
        /// </summary>
        internal bool IsSetRequireUppercaseCharacters() => this.RequireUppercaseCharacters.HasValue;
    }
}
