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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The password policy type.
    /// </summary>
    public partial class PasswordPolicyType
    {
        private int? _minimumLength;
        private bool? _requireLowercase;
        private bool? _requireNumbers;
        private bool? _requireSymbols;
        private bool? _requireUppercase;

        /// <summary>
        /// Gets and sets the property MinimumLength. 
        /// <para>
        /// The minimum length of the password policy that you have set. Cannot be less than 6.
        /// </para>
        /// </summary>
        public int MinimumLength
        {
            get { return this._minimumLength.GetValueOrDefault(); }
            set { this._minimumLength = value; }
        }

        // Check to see if MinimumLength property is set
        internal bool IsSetMinimumLength()
        {
            return this._minimumLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireLowercase. 
        /// <para>
        /// In the password policy that you have set, refers to whether you have required users
        /// to use at least one lowercase letter in their password.
        /// </para>
        /// </summary>
        public bool RequireLowercase
        {
            get { return this._requireLowercase.GetValueOrDefault(); }
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
        /// In the password policy that you have set, refers to whether you have required users
        /// to use at least one number in their password.
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
        /// Gets and sets the property RequireSymbols. 
        /// <para>
        /// In the password policy that you have set, refers to whether you have required users
        /// to use at least one symbol in their password.
        /// </para>
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
        /// Gets and sets the property RequireUppercase. 
        /// <para>
        /// In the password policy that you have set, refers to whether you have required users
        /// to use at least one uppercase letter in their password.
        /// </para>
        /// </summary>
        public bool RequireUppercase
        {
            get { return this._requireUppercase.GetValueOrDefault(); }
            set { this._requireUppercase = value; }
        }

        // Check to see if RequireUppercase property is set
        internal bool IsSetRequireUppercase()
        {
            return this._requireUppercase.HasValue; 
        }

    }
}