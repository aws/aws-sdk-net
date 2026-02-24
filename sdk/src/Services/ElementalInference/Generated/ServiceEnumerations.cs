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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElementalInference
{

    /// <summary>
    /// Constants used for properties of type FeedStatus.
    /// </summary>
    public class FeedStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FeedStatus
        /// </summary>
        public static readonly FeedStatus ACTIVE = new FeedStatus("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for FeedStatus
        /// </summary>
        public static readonly FeedStatus ARCHIVED = new FeedStatus("ARCHIVED");
        /// <summary>
        /// Constant AVAILABLE for FeedStatus
        /// </summary>
        public static readonly FeedStatus AVAILABLE = new FeedStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for FeedStatus
        /// </summary>
        public static readonly FeedStatus CREATING = new FeedStatus("CREATING");
        /// <summary>
        /// Constant DELETED for FeedStatus
        /// </summary>
        public static readonly FeedStatus DELETED = new FeedStatus("DELETED");
        /// <summary>
        /// Constant DELETING for FeedStatus
        /// </summary>
        public static readonly FeedStatus DELETING = new FeedStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for FeedStatus
        /// </summary>
        public static readonly FeedStatus UPDATING = new FeedStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedStatus FindValue(string value)
        {
            return FindValue<FeedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputStatus.
    /// </summary>
    public class OutputStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus DISABLED = new OutputStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus ENABLED = new OutputStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputStatus FindValue(string value)
        {
            return FindValue<OutputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputStatus(string value)
        {
            return FindValue(value);
        }
    }

}