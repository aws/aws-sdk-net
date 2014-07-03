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
    /// Updates the password policy settings for the account. For more information about using
    /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
    /// an                IAM Password Policy</a>.
    /// </summary>
    public partial class UpdateAccountPasswordPolicyRequest : AmazonWebServiceRequest
    {
        private bool? _allowUsersToChangePassword;
        private int? _minimumPasswordLength;
        private bool? _requireLowercaseCharacters;
        private bool? _requireNumbers;
        private bool? _requireSymbols;
        private bool? _requireUppercaseCharacters;


        /// <summary>
        /// Gets and sets the property AllowUsersToChangePassword.
        /// </summary>
        public bool AllowUsersToChangePassword
        {
            get { return this._allowUsersToChangePassword.GetValueOrDefault(); }
            set { this._allowUsersToChangePassword = value; }
        }


        /// <summary>
        /// Sets the AllowUsersToChangePassword property
        /// </summary>
        /// <param name="allowUsersToChangePassword">The value to set for the AllowUsersToChangePassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithAllowUsersToChangePassword(bool allowUsersToChangePassword)
        {
            this._allowUsersToChangePassword = allowUsersToChangePassword;
            return this;
        }

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this._allowUsersToChangePassword.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinimumPasswordLength.
        /// </summary>
        public int MinimumPasswordLength
        {
            get { return this._minimumPasswordLength.GetValueOrDefault(); }
            set { this._minimumPasswordLength = value; }
        }


        /// <summary>
        /// Sets the MinimumPasswordLength property
        /// </summary>
        /// <param name="minimumPasswordLength">The value to set for the MinimumPasswordLength property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithMinimumPasswordLength(int minimumPasswordLength)
        {
            this._minimumPasswordLength = minimumPasswordLength;
            return this;
        }

        // Check to see if MinimumPasswordLength property is set
        internal bool IsSetMinimumPasswordLength()
        {
            return this._minimumPasswordLength.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireLowercaseCharacters.
        /// </summary>
        public bool RequireLowercaseCharacters
        {
            get { return this._requireLowercaseCharacters.GetValueOrDefault(); }
            set { this._requireLowercaseCharacters = value; }
        }


        /// <summary>
        /// Sets the RequireLowercaseCharacters property
        /// </summary>
        /// <param name="requireLowercaseCharacters">The value to set for the RequireLowercaseCharacters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithRequireLowercaseCharacters(bool requireLowercaseCharacters)
        {
            this._requireLowercaseCharacters = requireLowercaseCharacters;
            return this;
        }

        // Check to see if RequireLowercaseCharacters property is set
        internal bool IsSetRequireLowercaseCharacters()
        {
            return this._requireLowercaseCharacters.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireNumbers.
        /// </summary>
        public bool RequireNumbers
        {
            get { return this._requireNumbers.GetValueOrDefault(); }
            set { this._requireNumbers = value; }
        }


        /// <summary>
        /// Sets the RequireNumbers property
        /// </summary>
        /// <param name="requireNumbers">The value to set for the RequireNumbers property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithRequireNumbers(bool requireNumbers)
        {
            this._requireNumbers = requireNumbers;
            return this;
        }

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this._requireNumbers.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireSymbols.
        /// </summary>
        public bool RequireSymbols
        {
            get { return this._requireSymbols.GetValueOrDefault(); }
            set { this._requireSymbols = value; }
        }


        /// <summary>
        /// Sets the RequireSymbols property
        /// </summary>
        /// <param name="requireSymbols">The value to set for the RequireSymbols property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithRequireSymbols(bool requireSymbols)
        {
            this._requireSymbols = requireSymbols;
            return this;
        }

        // Check to see if RequireSymbols property is set
        internal bool IsSetRequireSymbols()
        {
            return this._requireSymbols.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireUppercaseCharacters.
        /// </summary>
        public bool RequireUppercaseCharacters
        {
            get { return this._requireUppercaseCharacters.GetValueOrDefault(); }
            set { this._requireUppercaseCharacters = value; }
        }


        /// <summary>
        /// Sets the RequireUppercaseCharacters property
        /// </summary>
        /// <param name="requireUppercaseCharacters">The value to set for the RequireUppercaseCharacters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAccountPasswordPolicyRequest WithRequireUppercaseCharacters(bool requireUppercaseCharacters)
        {
            this._requireUppercaseCharacters = requireUppercaseCharacters;
            return this;
        }

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this._requireUppercaseCharacters.HasValue; 
        }

    }
}