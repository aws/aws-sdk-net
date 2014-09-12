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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountPasswordPolicy operation.
    /// Updates the password policy settings for the AWS account.
    /// 
    ///  
    /// <para>
    /// For more information about using a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
    /// an IAM Password Policy</a> in the <i>Using IAM</i> guide.
    /// </para>
    /// </summary>
    public partial class UpdateAccountPasswordPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private bool? _allowUsersToChangePassword;
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
        /// Allows all IAM users in your account to use the AWS Management Console to change their
        /// own passwords. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/HowToPwdIAMUser.html">Letting
        /// IAM Users Change Their Own Passwords</a> in the <i>Using IAM</i> guide.
        /// </para>
        ///  
        /// <para>
        /// Default value: false
        /// </para>
        /// </summary>
        public bool AllowUsersToChangePassword
        {
            get { return this._allowUsersToChangePassword.GetValueOrDefault(); }
            set { this._allowUsersToChangePassword = value; }
        }

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this._allowUsersToChangePassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HardExpiry. 
        /// <para>
        /// Prevents IAM users from setting a new password after their password has expired.
        /// </para>
        ///  
        /// <para>
        /// Default value: false
        /// </para>
        /// </summary>
        public bool HardExpiry
        {
            get { return this._hardExpiry.GetValueOrDefault(); }
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
        /// The number of days that an IAM user password is valid. The default value of 0 means
        /// IAM user passwords never expire.
        /// </para>
        ///  
        /// <para>
        /// Default value: 0
        /// </para>
        /// </summary>
        public int MaxPasswordAge
        {
            get { return this._maxPasswordAge.GetValueOrDefault(); }
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
        /// The minimum number of characters allowed in an IAM user password.
        /// </para>
        ///  
        /// <para>
        /// Default value: 6
        /// </para>
        /// </summary>
        public int MinimumPasswordLength
        {
            get { return this._minimumPasswordLength.GetValueOrDefault(); }
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
        /// The default value of 0 means IAM users are not prevented from reusing previous passwords.
        /// </para>
        ///  
        /// <para>
        /// Default value: 0
        /// </para>
        /// </summary>
        public int PasswordReusePrevention
        {
            get { return this._passwordReusePrevention.GetValueOrDefault(); }
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
        /// from the ISO basic Latin alphabet (a to z).
        /// </para>
        ///  
        /// <para>
        /// Default value: false
        /// </para>
        /// </summary>
        public bool RequireLowercaseCharacters
        {
            get { return this._requireLowercaseCharacters.GetValueOrDefault(); }
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
        ///  
        /// <para>
        /// Default value: false
        /// </para>
        /// </summary>
        public bool RequireNumbers
        {
            get { return this._requireNumbers.GetValueOrDefault(); }
            set { this._requireNumbers = value; }
        }

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this._requireNumbers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireSymbols. Specifies whether IAM user passwords must
        /// contain at least one of the following non-alphanumeric characters: ! @ # $ % ^ &amp;
        /// * ( ) _ + - = [ ] { } | ' Default value: false
        /// </summary>
        public bool RequireSymbols
        {
            get { return this._requireSymbols.GetValueOrDefault(); }
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
        /// from the ISO basic Latin alphabet (A to Z).
        /// </para>
        ///  
        /// <para>
        /// Default value: false
        /// </para>
        /// </summary>
        public bool RequireUppercaseCharacters
        {
            get { return this._requireUppercaseCharacters.GetValueOrDefault(); }
            set { this._requireUppercaseCharacters = value; }
        }

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this._requireUppercaseCharacters.HasValue; 
        }

    }
}