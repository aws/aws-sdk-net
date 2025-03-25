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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// The password policy settings for a user pool, including complexity, history, and length
    /// requirements.
    /// </summary>
    public partial class PasswordPolicyType
    {
        private int? _minimumLength;
        private int? _passwordHistorySize;
        private bool? _requireLowercase;
        private bool? _requireNumbers;
        private bool? _requireSymbols;
        private bool? _requireUppercase;
        private int? _temporaryPasswordValidityDays;

        /// <summary>
        /// Gets and sets the property MinimumLength. 
        /// <para>
        /// The minimum length of the password in the policy that you have set. This value can't
        /// be less than 6.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=99)]
        public int? MinimumLength
        {
            get { return this._minimumLength; }
            set { this._minimumLength = value; }
        }

        // Check to see if MinimumLength property is set
        internal bool IsSetMinimumLength()
        {
            return this._minimumLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordHistorySize. 
        /// <para>
        /// The number of previous passwords that you want Amazon Cognito to restrict each user
        /// from reusing. Users can't set a password that matches any of <c>n</c> previous passwords,
        /// where <c>n</c> is the value of <c>PasswordHistorySize</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=24)]
        public int? PasswordHistorySize
        {
            get { return this._passwordHistorySize; }
            set { this._passwordHistorySize = value; }
        }

        // Check to see if PasswordHistorySize property is set
        internal bool IsSetPasswordHistorySize()
        {
            return this._passwordHistorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireLowercase. 
        /// <para>
        /// The requirement in a password policy that users must include at least one lowercase
        /// letter in their password.
        /// </para>
        /// </summary>
        public bool? RequireLowercase
        {
            get { return this._requireLowercase; }
            set { this._requireLowercase = value; }
        }

        // Check to see if RequireLowercase property is set
        internal bool IsSetRequireLowercase()
        {
            return this._requireLowercase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireNumbers. 
        /// <para>
        /// The requirement in a password policy that users must include at least one number in
        /// their password.
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
        /// The requirement in a password policy that users must include at least one symbol in
        /// their password.
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
        /// Gets and sets the property RequireUppercase. 
        /// <para>
        /// The requirement in a password policy that users must include at least one uppercase
        /// letter in their password.
        /// </para>
        /// </summary>
        public bool? RequireUppercase
        {
            get { return this._requireUppercase; }
            set { this._requireUppercase = value; }
        }

        // Check to see if RequireUppercase property is set
        internal bool IsSetRequireUppercase()
        {
            return this._requireUppercase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemporaryPasswordValidityDays. 
        /// <para>
        /// The number of days a temporary password is valid in the password policy. If the user
        /// doesn't sign in during this time, an administrator must reset their password. Defaults
        /// to <c>7</c>. If you submit a value of <c>0</c>, Amazon Cognito treats it as a null
        /// value and sets <c>TemporaryPasswordValidityDays</c> to its default value.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you set <c>TemporaryPasswordValidityDays</c> for a user pool, you can no longer
        /// set a value for the legacy <c>UnusedAccountValidityDays</c> parameter in that user
        /// pool.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=365)]
        public int? TemporaryPasswordValidityDays
        {
            get { return this._temporaryPasswordValidityDays; }
            set { this._temporaryPasswordValidityDays = value; }
        }

        // Check to see if TemporaryPasswordValidityDays property is set
        internal bool IsSetTemporaryPasswordValidityDays()
        {
            return this._temporaryPasswordValidityDays.HasValue; 
        }

    }
}