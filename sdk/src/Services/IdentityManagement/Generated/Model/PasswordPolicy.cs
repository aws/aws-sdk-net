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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
        private bool? _allowUsersToChangePassword;
        private bool? _expirePasswords;
        private bool? _hardExpiry;
        private int? _maxPasswordAge;
        private int? _minimumPasswordLength;
        private int? _passwordReusePrevention;
        private bool? _requireLowercaseCharacters;
        private bool? _requireNumbers;
        private bool? _requireSymbols;
        private bool? _requireUppercaseCharacters;

        /// <summary>
        /// Gets and sets the property AllowUsersToChangePassword. 
        /// <para>
        /// Specifies whether IAM users are allowed to change their own password. Gives IAM users
        /// permissions to <c>iam:ChangePassword</c> for only their user and to the <c>iam:GetAccountPasswordPolicy</c>
        /// action. This option does not attach a permissions policy to each user, rather the
        /// permissions are applied at the account-level for all users by IAM.
        /// </para>
        /// </summary>
        public bool? AllowUsersToChangePassword
        {
            get { return this._allowUsersToChangePassword; }
            set { this._allowUsersToChangePassword = value; }
        }

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this._allowUsersToChangePassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirePasswords. 
        /// <para>
        /// Indicates whether passwords in the account expire. Returns true if <c>MaxPasswordAge</c>
        /// contains a value greater than 0. Returns false if MaxPasswordAge is 0 or not present.
        /// </para>
        /// </summary>
        public bool? ExpirePasswords
        {
            get { return this._expirePasswords; }
            set { this._expirePasswords = value; }
        }

        // Check to see if ExpirePasswords property is set
        internal bool IsSetExpirePasswords()
        {
            return this._expirePasswords.HasValue; 
        }

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
        public bool? HardExpiry
        {
            get { return this._hardExpiry; }
            set { this._hardExpiry = value; }
        }

        // Check to see if HardExpiry property is set
        internal bool IsSetHardExpiry()
        {
            return this._hardExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPasswordAge. 
        /// <para>
        /// The number of days that an IAM user password is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1095)]
        public int? MaxPasswordAge
        {
            get { return this._maxPasswordAge; }
            set { this._maxPasswordAge = value; }
        }

        // Check to see if MaxPasswordAge property is set
        internal bool IsSetMaxPasswordAge()
        {
            return this._maxPasswordAge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumPasswordLength. 
        /// <para>
        /// Minimum length to require for IAM user passwords.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=128)]
        public int? MinimumPasswordLength
        {
            get { return this._minimumPasswordLength; }
            set { this._minimumPasswordLength = value; }
        }

        // Check to see if MinimumPasswordLength property is set
        internal bool IsSetMinimumPasswordLength()
        {
            return this._minimumPasswordLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordReusePrevention. 
        /// <para>
        /// Specifies the number of previous passwords that IAM users are prevented from reusing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public int? PasswordReusePrevention
        {
            get { return this._passwordReusePrevention; }
            set { this._passwordReusePrevention = value; }
        }

        // Check to see if PasswordReusePrevention property is set
        internal bool IsSetPasswordReusePrevention()
        {
            return this._passwordReusePrevention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireLowercaseCharacters. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one lowercase character
        /// (a to z).
        /// </para>
        /// </summary>
        public bool? RequireLowercaseCharacters
        {
            get { return this._requireLowercaseCharacters; }
            set { this._requireLowercaseCharacters = value; }
        }

        // Check to see if RequireLowercaseCharacters property is set
        internal bool IsSetRequireLowercaseCharacters()
        {
            return this._requireLowercaseCharacters.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireNumbers. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one numeric character (0
        /// to 9).
        /// </para>
        /// </summary>
        public bool? RequireNumbers
        {
            get { return this._requireNumbers; }
            set { this._requireNumbers = value; }
        }

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this._requireNumbers.HasValue; 
        }

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
        public bool? RequireSymbols
        {
            get { return this._requireSymbols; }
            set { this._requireSymbols = value; }
        }

        // Check to see if RequireSymbols property is set
        internal bool IsSetRequireSymbols()
        {
            return this._requireSymbols.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireUppercaseCharacters. 
        /// <para>
        /// Specifies whether IAM user passwords must contain at least one uppercase character
        /// (A to Z).
        /// </para>
        /// </summary>
        public bool? RequireUppercaseCharacters
        {
            get { return this._requireUppercaseCharacters; }
            set { this._requireUppercaseCharacters = value; }
        }

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this._requireUppercaseCharacters.HasValue; 
        }

    }
}