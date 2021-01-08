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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Detective
{

    /// <summary>
    /// Constants used for properties of type MemberDisabledReason.
    /// </summary>
    public class MemberDisabledReason : ConstantClass
    {

        /// <summary>
        /// Constant VOLUME_TOO_HIGH for MemberDisabledReason
        /// </summary>
        public static readonly MemberDisabledReason VOLUME_TOO_HIGH = new MemberDisabledReason("VOLUME_TOO_HIGH");
        /// <summary>
        /// Constant VOLUME_UNKNOWN for MemberDisabledReason
        /// </summary>
        public static readonly MemberDisabledReason VOLUME_UNKNOWN = new MemberDisabledReason("VOLUME_UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberDisabledReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberDisabledReason FindValue(string value)
        {
            return FindValue<MemberDisabledReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberDisabledReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberStatus.
    /// </summary>
    public class MemberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED_BUT_DISABLED for MemberStatus
        /// </summary>
        public static readonly MemberStatus ACCEPTED_BUT_DISABLED = new MemberStatus("ACCEPTED_BUT_DISABLED");
        /// <summary>
        /// Constant ENABLED for MemberStatus
        /// </summary>
        public static readonly MemberStatus ENABLED = new MemberStatus("ENABLED");
        /// <summary>
        /// Constant INVITED for MemberStatus
        /// </summary>
        public static readonly MemberStatus INVITED = new MemberStatus("INVITED");
        /// <summary>
        /// Constant VERIFICATION_FAILED for MemberStatus
        /// </summary>
        public static readonly MemberStatus VERIFICATION_FAILED = new MemberStatus("VERIFICATION_FAILED");
        /// <summary>
        /// Constant VERIFICATION_IN_PROGRESS for MemberStatus
        /// </summary>
        public static readonly MemberStatus VERIFICATION_IN_PROGRESS = new MemberStatus("VERIFICATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberStatus FindValue(string value)
        {
            return FindValue<MemberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberStatus(string value)
        {
            return FindValue(value);
        }
    }

}