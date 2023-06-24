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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeCatalyst
{

    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQ = new ComparisonOperator("EQ");
        /// <summary>
        /// Constant GE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GE = new ComparisonOperator("GE");
        /// <summary>
        /// Constant GT for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GT = new ComparisonOperator("GT");
        /// <summary>
        /// Constant LE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LE = new ComparisonOperator("LE");
        /// <summary>
        /// Constant LT for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LT = new ComparisonOperator("LT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DevEnvironmentSessionType.
    /// </summary>
    public class DevEnvironmentSessionType : ConstantClass
    {

        /// <summary>
        /// Constant SSH for DevEnvironmentSessionType
        /// </summary>
        public static readonly DevEnvironmentSessionType SSH = new DevEnvironmentSessionType("SSH");
        /// <summary>
        /// Constant SSM for DevEnvironmentSessionType
        /// </summary>
        public static readonly DevEnvironmentSessionType SSM = new DevEnvironmentSessionType("SSM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DevEnvironmentSessionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DevEnvironmentSessionType FindValue(string value)
        {
            return FindValue<DevEnvironmentSessionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DevEnvironmentSessionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DevEnvironmentStatus.
    /// </summary>
    public class DevEnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus DELETED = new DevEnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus DELETING = new DevEnvironmentStatus("DELETING");
        /// <summary>
        /// Constant FAILED for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus FAILED = new DevEnvironmentStatus("FAILED");
        /// <summary>
        /// Constant PENDING for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus PENDING = new DevEnvironmentStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus RUNNING = new DevEnvironmentStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus STARTING = new DevEnvironmentStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus STOPPED = new DevEnvironmentStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for DevEnvironmentStatus
        /// </summary>
        public static readonly DevEnvironmentStatus STOPPING = new DevEnvironmentStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DevEnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DevEnvironmentStatus FindValue(string value)
        {
            return FindValue<DevEnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DevEnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterKey.
    /// </summary>
    public class FilterKey : ConstantClass
    {

        /// <summary>
        /// Constant HasAccessTo for FilterKey
        /// </summary>
        public static readonly FilterKey HasAccessTo = new FilterKey("hasAccessTo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterKey FindValue(string value)
        {
            return FindValue<FilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant DevStandard1Large for InstanceType
        /// </summary>
        public static readonly InstanceType DevStandard1Large = new InstanceType("dev.standard1.large");
        /// <summary>
        /// Constant DevStandard1Medium for InstanceType
        /// </summary>
        public static readonly InstanceType DevStandard1Medium = new InstanceType("dev.standard1.medium");
        /// <summary>
        /// Constant DevStandard1Small for InstanceType
        /// </summary>
        public static readonly InstanceType DevStandard1Small = new InstanceType("dev.standard1.small");
        /// <summary>
        /// Constant DevStandard1Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType DevStandard1Xlarge = new InstanceType("dev.standard1.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant MUTATION for OperationType
        /// </summary>
        public static readonly OperationType MUTATION = new OperationType("MUTATION");
        /// <summary>
        /// Constant READONLY for OperationType
        /// </summary>
        public static readonly OperationType READONLY = new OperationType("READONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACCOUNT for UserType
        /// </summary>
        public static readonly UserType AWS_ACCOUNT = new UserType("AWS_ACCOUNT");
        /// <summary>
        /// Constant UNKNOWN for UserType
        /// </summary>
        public static readonly UserType UNKNOWN = new UserType("UNKNOWN");
        /// <summary>
        /// Constant USER for UserType
        /// </summary>
        public static readonly UserType USER = new UserType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
        {
            return FindValue(value);
        }
    }

}