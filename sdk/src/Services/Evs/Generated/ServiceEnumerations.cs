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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Evs
{

    /// <summary>
    /// Constants used for properties of type CheckResult.
    /// </summary>
    public class CheckResult : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CheckResult
        /// </summary>
        public static readonly CheckResult FAILED = new CheckResult("FAILED");
        /// <summary>
        /// Constant PASSED for CheckResult
        /// </summary>
        public static readonly CheckResult PASSED = new CheckResult("PASSED");
        /// <summary>
        /// Constant UNKNOWN for CheckResult
        /// </summary>
        public static readonly CheckResult UNKNOWN = new CheckResult("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckResult FindValue(string value)
        {
            return FindValue<CheckResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckType.
    /// </summary>
    public class CheckType : ConstantClass
    {

        /// <summary>
        /// Constant HOST_COUNT for CheckType
        /// </summary>
        public static readonly CheckType HOST_COUNT = new CheckType("HOST_COUNT");
        /// <summary>
        /// Constant KEY_COVERAGE for CheckType
        /// </summary>
        public static readonly CheckType KEY_COVERAGE = new CheckType("KEY_COVERAGE");
        /// <summary>
        /// Constant KEY_REUSE for CheckType
        /// </summary>
        public static readonly CheckType KEY_REUSE = new CheckType("KEY_REUSE");
        /// <summary>
        /// Constant REACHABILITY for CheckType
        /// </summary>
        public static readonly CheckType REACHABILITY = new CheckType("REACHABILITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckType FindValue(string value)
        {
            return FindValue<CheckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentState.
    /// </summary>
    public class EnvironmentState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState CREATE_FAILED = new EnvironmentState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState CREATED = new EnvironmentState("CREATED");
        /// <summary>
        /// Constant CREATING for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState CREATING = new EnvironmentState("CREATING");
        /// <summary>
        /// Constant DELETED for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState DELETED = new EnvironmentState("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState DELETING = new EnvironmentState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentState FindValue(string value)
        {
            return FindValue<EnvironmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostState.
    /// </summary>
    public class HostState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for HostState
        /// </summary>
        public static readonly HostState CREATE_FAILED = new HostState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for HostState
        /// </summary>
        public static readonly HostState CREATED = new HostState("CREATED");
        /// <summary>
        /// Constant CREATING for HostState
        /// </summary>
        public static readonly HostState CREATING = new HostState("CREATING");
        /// <summary>
        /// Constant DELETED for HostState
        /// </summary>
        public static readonly HostState DELETED = new HostState("DELETED");
        /// <summary>
        /// Constant DELETING for HostState
        /// </summary>
        public static readonly HostState DELETING = new HostState("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for HostState
        /// </summary>
        public static readonly HostState UPDATE_FAILED = new HostState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for HostState
        /// </summary>
        public static readonly HostState UPDATING = new HostState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostState FindValue(string value)
        {
            return FindValue<HostState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostState(string value)
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
        /// Constant I4iMetal for InstanceType
        /// </summary>
        public static readonly InstanceType I4iMetal = new InstanceType("i4i.metal");

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
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VcfVersion.
    /// </summary>
    public class VcfVersion : ConstantClass
    {

        /// <summary>
        /// Constant VCF521 for VcfVersion
        /// </summary>
        public static readonly VcfVersion VCF521 = new VcfVersion("VCF-5.2.1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VcfVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VcfVersion FindValue(string value)
        {
            return FindValue<VcfVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VcfVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VlanState.
    /// </summary>
    public class VlanState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for VlanState
        /// </summary>
        public static readonly VlanState CREATE_FAILED = new VlanState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for VlanState
        /// </summary>
        public static readonly VlanState CREATED = new VlanState("CREATED");
        /// <summary>
        /// Constant CREATING for VlanState
        /// </summary>
        public static readonly VlanState CREATING = new VlanState("CREATING");
        /// <summary>
        /// Constant DELETED for VlanState
        /// </summary>
        public static readonly VlanState DELETED = new VlanState("DELETED");
        /// <summary>
        /// Constant DELETING for VlanState
        /// </summary>
        public static readonly VlanState DELETING = new VlanState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VlanState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VlanState FindValue(string value)
        {
            return FindValue<VlanState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VlanState(string value)
        {
            return FindValue(value);
        }
    }

}