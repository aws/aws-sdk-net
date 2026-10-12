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
    /// The password policy settings for a user pool, including complexity, history, and length
    /// requirements.
    /// </summary>
    public partial class PasswordPolicyType
    {
        /// <summary>
        /// Gets and sets the property MinimumLength. 
        /// <para>
        /// The minimum length of the password in the policy that you have set. This value can't
        /// be less than 6.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 99)]
        public int? MinimumLength { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLength property is set.
        /// </summary>
        internal bool IsSetMinimumLength() => this.MinimumLength.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordHistorySize. 
        /// <para>
        /// The number of previous passwords that you want Amazon Cognito to restrict each user
        /// from reusing. Users can't set a password that matches any of <c>n</c> previous passwords,
        /// where <c>n</c> is the value of <c>PasswordHistorySize</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 24)]
        public int? PasswordHistorySize { get; set; }

        /// <summary>
        /// Checks to see if the PasswordHistorySize property is set.
        /// </summary>
        internal bool IsSetPasswordHistorySize() => this.PasswordHistorySize.HasValue;

        /// <summary>
        /// Gets and sets the property RequireLowercase. 
        /// <para>
        /// The requirement in a password policy that users must include at least one lowercase
        /// letter in their password.
        /// </para>
        /// </summary>
        public bool? RequireLowercase { get; set; }

        /// <summary>
        /// Checks to see if the RequireLowercase property is set.
        /// </summary>
        internal bool IsSetRequireLowercase() => this.RequireLowercase.HasValue;

        /// <summary>
        /// Gets and sets the property RequireNumbers. 
        /// <para>
        /// The requirement in a password policy that users must include at least one number in
        /// their password.
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
        /// The requirement in a password policy that users must include at least one symbol in
        /// their password.
        /// </para>
        /// </summary>
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// Checks to see if the RequireSymbols property is set.
        /// </summary>
        internal bool IsSetRequireSymbols() => this.RequireSymbols.HasValue;

        /// <summary>
        /// Gets and sets the property RequireUppercase. 
        /// <para>
        /// The requirement in a password policy that users must include at least one uppercase
        /// letter in their password.
        /// </para>
        /// </summary>
        public bool? RequireUppercase { get; set; }

        /// <summary>
        /// Checks to see if the RequireUppercase property is set.
        /// </summary>
        internal bool IsSetRequireUppercase() => this.RequireUppercase.HasValue;

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
        [AWSProperty(Min = 0, Max = 365)]
        public int? TemporaryPasswordValidityDays { get; set; }

        /// <summary>
        /// Checks to see if the TemporaryPasswordValidityDays property is set.
        /// </summary>
        internal bool IsSetTemporaryPasswordValidityDays() => this.TemporaryPasswordValidityDays.HasValue;
    }
}
