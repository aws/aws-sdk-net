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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Macie
{

    /// <summary>
    /// Constants used for properties of type S3ContinuousClassificationType.
    /// </summary>
    public class S3ContinuousClassificationType : ConstantClass
    {

        /// <summary>
        /// Constant FULL for S3ContinuousClassificationType
        /// </summary>
        public static readonly S3ContinuousClassificationType FULL = new S3ContinuousClassificationType("FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ContinuousClassificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ContinuousClassificationType FindValue(string value)
        {
            return FindValue<S3ContinuousClassificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ContinuousClassificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3OneTimeClassificationType.
    /// </summary>
    public class S3OneTimeClassificationType : ConstantClass
    {

        /// <summary>
        /// Constant FULL for S3OneTimeClassificationType
        /// </summary>
        public static readonly S3OneTimeClassificationType FULL = new S3OneTimeClassificationType("FULL");
        /// <summary>
        /// Constant NONE for S3OneTimeClassificationType
        /// </summary>
        public static readonly S3OneTimeClassificationType NONE = new S3OneTimeClassificationType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3OneTimeClassificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3OneTimeClassificationType FindValue(string value)
        {
            return FindValue<S3OneTimeClassificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3OneTimeClassificationType(string value)
        {
            return FindValue(value);
        }
    }

}