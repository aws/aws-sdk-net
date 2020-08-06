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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaStore
{

    /// <summary>
    /// Constants used for properties of type ContainerLevelMetrics.
    /// </summary>
    public class ContainerLevelMetrics : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ContainerLevelMetrics
        /// </summary>
        public static readonly ContainerLevelMetrics DISABLED = new ContainerLevelMetrics("DISABLED");
        /// <summary>
        /// Constant ENABLED for ContainerLevelMetrics
        /// </summary>
        public static readonly ContainerLevelMetrics ENABLED = new ContainerLevelMetrics("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerLevelMetrics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerLevelMetrics FindValue(string value)
        {
            return FindValue<ContainerLevelMetrics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerLevelMetrics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerStatus.
    /// </summary>
    public class ContainerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContainerStatus
        /// </summary>
        public static readonly ContainerStatus ACTIVE = new ContainerStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ContainerStatus
        /// </summary>
        public static readonly ContainerStatus CREATING = new ContainerStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ContainerStatus
        /// </summary>
        public static readonly ContainerStatus DELETING = new ContainerStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerStatus FindValue(string value)
        {
            return FindValue<ContainerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MethodName.
    /// </summary>
    public class MethodName : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for MethodName
        /// </summary>
        public static readonly MethodName DELETE = new MethodName("DELETE");
        /// <summary>
        /// Constant GET for MethodName
        /// </summary>
        public static readonly MethodName GET = new MethodName("GET");
        /// <summary>
        /// Constant HEAD for MethodName
        /// </summary>
        public static readonly MethodName HEAD = new MethodName("HEAD");
        /// <summary>
        /// Constant PUT for MethodName
        /// </summary>
        public static readonly MethodName PUT = new MethodName("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MethodName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MethodName FindValue(string value)
        {
            return FindValue<MethodName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MethodName(string value)
        {
            return FindValue(value);
        }
    }

}