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
using Amazon.Runtime;

namespace Amazon.Route53Profiles
{
    /// <summary>
    /// Constants used for properties of type ProfileStatus.
    /// </summary>
    public class ProfileStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETE for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus COMPLETE = new ProfileStatus("COMPLETE");

        /// <summary>
        /// Constant CREATING for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus CREATING = new ProfileStatus("CREATING");

        /// <summary>
        /// Constant DELETED for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus DELETED = new ProfileStatus("DELETED");

        /// <summary>
        /// Constant DELETING for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus DELETING = new ProfileStatus("DELETING");

        /// <summary>
        /// Constant FAILED for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus FAILED = new ProfileStatus("FAILED");

        /// <summary>
        /// Constant UPDATING for ProfileStatus
        /// </summary>
        public static readonly ProfileStatus UPDATING = new ProfileStatus("UPDATING");

        /// <summary>
        /// Constructs a custom ProfileStatus for a value not among the defined constants.
        /// </summary>
        public ProfileStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileStatus FindValue(string value)
        {
            return FindValue<ProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ShareStatus.
    /// </summary>
    public class ShareStatus : ConstantClass
    {
        /// <summary>
        /// Constant NOT_SHARED for ShareStatus
        /// </summary>
        public static readonly ShareStatus NOT_SHARED = new ShareStatus("NOT_SHARED");

        /// <summary>
        /// Constant SHARED_BY_ME for ShareStatus
        /// </summary>
        public static readonly ShareStatus SHARED_BY_ME = new ShareStatus("SHARED_BY_ME");

        /// <summary>
        /// Constant SHARED_WITH_ME for ShareStatus
        /// </summary>
        public static readonly ShareStatus SHARED_WITH_ME = new ShareStatus("SHARED_WITH_ME");

        /// <summary>
        /// Constructs a custom ShareStatus for a value not among the defined constants.
        /// </summary>
        public ShareStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatus FindValue(string value)
        {
            return FindValue<ShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatus(string value)
        {
            return FindValue(value);
        }
    }
}
