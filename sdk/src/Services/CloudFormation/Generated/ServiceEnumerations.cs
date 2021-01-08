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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudFormation
{

    /// <summary>
    /// Constants used for properties of type AccountGateStatus.
    /// </summary>
    public class AccountGateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AccountGateStatus
        /// </summary>
        public static readonly AccountGateStatus FAILED = new AccountGateStatus("FAILED");
        /// <summary>
        /// Constant SKIPPED for AccountGateStatus
        /// </summary>
        public static readonly AccountGateStatus SKIPPED = new AccountGateStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCEEDED for AccountGateStatus
        /// </summary>
        public static readonly AccountGateStatus SUCCEEDED = new AccountGateStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountGateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountGateStatus FindValue(string value)
        {
            return FindValue<AccountGateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountGateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Capability.
    /// </summary>
    public class Capability : ConstantClass
    {

        /// <summary>
        /// Constant CAPABILITY_AUTO_EXPAND for Capability
        /// </summary>
        public static readonly Capability CAPABILITY_AUTO_EXPAND = new Capability("CAPABILITY_AUTO_EXPAND");
        /// <summary>
        /// Constant CAPABILITY_IAM for Capability
        /// </summary>
        public static readonly Capability CAPABILITY_IAM = new Capability("CAPABILITY_IAM");
        /// <summary>
        /// Constant CAPABILITY_NAMED_IAM for Capability
        /// </summary>
        public static readonly Capability CAPABILITY_NAMED_IAM = new Capability("CAPABILITY_NAMED_IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Capability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Capability FindValue(string value)
        {
            return FindValue<Capability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Capability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant Add for ChangeAction
        /// </summary>
        public static readonly ChangeAction Add = new ChangeAction("Add");
        /// <summary>
        /// Constant Dynamic for ChangeAction
        /// </summary>
        public static readonly ChangeAction Dynamic = new ChangeAction("Dynamic");
        /// <summary>
        /// Constant Import for ChangeAction
        /// </summary>
        public static readonly ChangeAction Import = new ChangeAction("Import");
        /// <summary>
        /// Constant Modify for ChangeAction
        /// </summary>
        public static readonly ChangeAction Modify = new ChangeAction("Modify");
        /// <summary>
        /// Constant Remove for ChangeAction
        /// </summary>
        public static readonly ChangeAction Remove = new ChangeAction("Remove");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeSetStatus.
    /// </summary>
    public class ChangeSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus CREATE_COMPLETE = new ChangeSetStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus CREATE_IN_PROGRESS = new ChangeSetStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus CREATE_PENDING = new ChangeSetStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_COMPLETE for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus DELETE_COMPLETE = new ChangeSetStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus DELETE_FAILED = new ChangeSetStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus DELETE_IN_PROGRESS = new ChangeSetStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus DELETE_PENDING = new ChangeSetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant FAILED for ChangeSetStatus
        /// </summary>
        public static readonly ChangeSetStatus FAILED = new ChangeSetStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSetStatus FindValue(string value)
        {
            return FindValue<ChangeSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeSetType.
    /// </summary>
    public class ChangeSetType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for ChangeSetType
        /// </summary>
        public static readonly ChangeSetType CREATE = new ChangeSetType("CREATE");
        /// <summary>
        /// Constant IMPORT for ChangeSetType
        /// </summary>
        public static readonly ChangeSetType IMPORT = new ChangeSetType("IMPORT");
        /// <summary>
        /// Constant UPDATE for ChangeSetType
        /// </summary>
        public static readonly ChangeSetType UPDATE = new ChangeSetType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSetType FindValue(string value)
        {
            return FindValue<ChangeSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeSource.
    /// </summary>
    public class ChangeSource : ConstantClass
    {

        /// <summary>
        /// Constant Automatic for ChangeSource
        /// </summary>
        public static readonly ChangeSource Automatic = new ChangeSource("Automatic");
        /// <summary>
        /// Constant DirectModification for ChangeSource
        /// </summary>
        public static readonly ChangeSource DirectModification = new ChangeSource("DirectModification");
        /// <summary>
        /// Constant ParameterReference for ChangeSource
        /// </summary>
        public static readonly ChangeSource ParameterReference = new ChangeSource("ParameterReference");
        /// <summary>
        /// Constant ResourceAttribute for ChangeSource
        /// </summary>
        public static readonly ChangeSource ResourceAttribute = new ChangeSource("ResourceAttribute");
        /// <summary>
        /// Constant ResourceReference for ChangeSource
        /// </summary>
        public static readonly ChangeSource ResourceReference = new ChangeSource("ResourceReference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSource FindValue(string value)
        {
            return FindValue<ChangeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant Resource for ChangeType
        /// </summary>
        public static readonly ChangeType Resource = new ChangeType("Resource");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeprecatedStatus.
    /// </summary>
    public class DeprecatedStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPRECATED for DeprecatedStatus
        /// </summary>
        public static readonly DeprecatedStatus DEPRECATED = new DeprecatedStatus("DEPRECATED");
        /// <summary>
        /// Constant LIVE for DeprecatedStatus
        /// </summary>
        public static readonly DeprecatedStatus LIVE = new DeprecatedStatus("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeprecatedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeprecatedStatus FindValue(string value)
        {
            return FindValue<DeprecatedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeprecatedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DifferenceType.
    /// </summary>
    public class DifferenceType : ConstantClass
    {

        /// <summary>
        /// Constant ADD for DifferenceType
        /// </summary>
        public static readonly DifferenceType ADD = new DifferenceType("ADD");
        /// <summary>
        /// Constant NOT_EQUAL for DifferenceType
        /// </summary>
        public static readonly DifferenceType NOT_EQUAL = new DifferenceType("NOT_EQUAL");
        /// <summary>
        /// Constant REMOVE for DifferenceType
        /// </summary>
        public static readonly DifferenceType REMOVE = new DifferenceType("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DifferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DifferenceType FindValue(string value)
        {
            return FindValue<DifferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DifferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationType.
    /// </summary>
    public class EvaluationType : ConstantClass
    {

        /// <summary>
        /// Constant Dynamic for EvaluationType
        /// </summary>
        public static readonly EvaluationType Dynamic = new EvaluationType("Dynamic");
        /// <summary>
        /// Constant Static for EvaluationType
        /// </summary>
        public static readonly EvaluationType Static = new EvaluationType("Static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationType FindValue(string value)
        {
            return FindValue<EvaluationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus AVAILABLE = new ExecutionStatus("AVAILABLE");
        /// <summary>
        /// Constant EXECUTE_COMPLETE for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus EXECUTE_COMPLETE = new ExecutionStatus("EXECUTE_COMPLETE");
        /// <summary>
        /// Constant EXECUTE_FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus EXECUTE_FAILED = new ExecutionStatus("EXECUTE_FAILED");
        /// <summary>
        /// Constant EXECUTE_IN_PROGRESS for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus EXECUTE_IN_PROGRESS = new ExecutionStatus("EXECUTE_IN_PROGRESS");
        /// <summary>
        /// Constant OBSOLETE for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus OBSOLETE = new ExecutionStatus("OBSOLETE");
        /// <summary>
        /// Constant UNAVAILABLE for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus UNAVAILABLE = new ExecutionStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandlerErrorCode.
    /// </summary>
    public class HandlerErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode AccessDenied = new HandlerErrorCode("AccessDenied");
        /// <summary>
        /// Constant AlreadyExists for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode AlreadyExists = new HandlerErrorCode("AlreadyExists");
        /// <summary>
        /// Constant GeneralServiceException for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode GeneralServiceException = new HandlerErrorCode("GeneralServiceException");
        /// <summary>
        /// Constant InternalFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InternalFailure = new HandlerErrorCode("InternalFailure");
        /// <summary>
        /// Constant InvalidCredentials for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InvalidCredentials = new HandlerErrorCode("InvalidCredentials");
        /// <summary>
        /// Constant InvalidRequest for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InvalidRequest = new HandlerErrorCode("InvalidRequest");
        /// <summary>
        /// Constant NetworkFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NetworkFailure = new HandlerErrorCode("NetworkFailure");
        /// <summary>
        /// Constant NotFound for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotFound = new HandlerErrorCode("NotFound");
        /// <summary>
        /// Constant NotStabilized for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotStabilized = new HandlerErrorCode("NotStabilized");
        /// <summary>
        /// Constant NotUpdatable for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NotUpdatable = new HandlerErrorCode("NotUpdatable");
        /// <summary>
        /// Constant ResourceConflict for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ResourceConflict = new HandlerErrorCode("ResourceConflict");
        /// <summary>
        /// Constant ServiceInternalError for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ServiceInternalError = new HandlerErrorCode("ServiceInternalError");
        /// <summary>
        /// Constant ServiceLimitExceeded for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode ServiceLimitExceeded = new HandlerErrorCode("ServiceLimitExceeded");
        /// <summary>
        /// Constant Throttling for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode Throttling = new HandlerErrorCode("Throttling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandlerErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandlerErrorCode FindValue(string value)
        {
            return FindValue<HandlerErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandlerErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnFailure.
    /// </summary>
    public class OnFailure : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for OnFailure
        /// </summary>
        public static readonly OnFailure DELETE = new OnFailure("DELETE");
        /// <summary>
        /// Constant DO_NOTHING for OnFailure
        /// </summary>
        public static readonly OnFailure DO_NOTHING = new OnFailure("DO_NOTHING");
        /// <summary>
        /// Constant ROLLBACK for OnFailure
        /// </summary>
        public static readonly OnFailure ROLLBACK = new OnFailure("ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnFailure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnFailure FindValue(string value)
        {
            return FindValue<OnFailure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnFailure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAILED = new OperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus IN_PROGRESS = new OperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for OperationStatus
        /// </summary>
        public static readonly OperationStatus PENDING = new OperationStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCESS = new OperationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionModels.
    /// </summary>
    public class PermissionModels : ConstantClass
    {

        /// <summary>
        /// Constant SELF_MANAGED for PermissionModels
        /// </summary>
        public static readonly PermissionModels SELF_MANAGED = new PermissionModels("SELF_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for PermissionModels
        /// </summary>
        public static readonly PermissionModels SERVICE_MANAGED = new PermissionModels("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionModels(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionModels FindValue(string value)
        {
            return FindValue<PermissionModels>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionModels(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningType.
    /// </summary>
    public class ProvisioningType : ConstantClass
    {

        /// <summary>
        /// Constant FULLY_MUTABLE for ProvisioningType
        /// </summary>
        public static readonly ProvisioningType FULLY_MUTABLE = new ProvisioningType("FULLY_MUTABLE");
        /// <summary>
        /// Constant IMMUTABLE for ProvisioningType
        /// </summary>
        public static readonly ProvisioningType IMMUTABLE = new ProvisioningType("IMMUTABLE");
        /// <summary>
        /// Constant NON_PROVISIONABLE for ProvisioningType
        /// </summary>
        public static readonly ProvisioningType NON_PROVISIONABLE = new ProvisioningType("NON_PROVISIONABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningType FindValue(string value)
        {
            return FindValue<ProvisioningType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus COMPLETE = new RegistrationStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus FAILED = new RegistrationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus IN_PROGRESS = new RegistrationStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryType.
    /// </summary>
    public class RegistryType : ConstantClass
    {

        /// <summary>
        /// Constant MODULE for RegistryType
        /// </summary>
        public static readonly RegistryType MODULE = new RegistryType("MODULE");
        /// <summary>
        /// Constant RESOURCE for RegistryType
        /// </summary>
        public static readonly RegistryType RESOURCE = new RegistryType("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryType FindValue(string value)
        {
            return FindValue<RegistryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Replacement.
    /// </summary>
    public class Replacement : ConstantClass
    {

        /// <summary>
        /// Constant Conditional for Replacement
        /// </summary>
        public static readonly Replacement Conditional = new Replacement("Conditional");
        /// <summary>
        /// Constant False for Replacement
        /// </summary>
        public static readonly Replacement False = new Replacement("False");
        /// <summary>
        /// Constant True for Replacement
        /// </summary>
        public static readonly Replacement True = new Replacement("True");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Replacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Replacement FindValue(string value)
        {
            return FindValue<Replacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Replacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequiresRecreation.
    /// </summary>
    public class RequiresRecreation : ConstantClass
    {

        /// <summary>
        /// Constant Always for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation Always = new RequiresRecreation("Always");
        /// <summary>
        /// Constant Conditionally for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation Conditionally = new RequiresRecreation("Conditionally");
        /// <summary>
        /// Constant Never for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation Never = new RequiresRecreation("Never");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequiresRecreation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequiresRecreation FindValue(string value)
        {
            return FindValue<RequiresRecreation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequiresRecreation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceAttribute.
    /// </summary>
    public class ResourceAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CreationPolicy for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute CreationPolicy = new ResourceAttribute("CreationPolicy");
        /// <summary>
        /// Constant DeletionPolicy for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute DeletionPolicy = new ResourceAttribute("DeletionPolicy");
        /// <summary>
        /// Constant Metadata for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute Metadata = new ResourceAttribute("Metadata");
        /// <summary>
        /// Constant Properties for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute Properties = new ResourceAttribute("Properties");
        /// <summary>
        /// Constant Tags for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute Tags = new ResourceAttribute("Tags");
        /// <summary>
        /// Constant UpdatePolicy for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute UpdatePolicy = new ResourceAttribute("UpdatePolicy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceAttribute FindValue(string value)
        {
            return FindValue<ResourceAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSignalStatus.
    /// </summary>
    public class ResourceSignalStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for ResourceSignalStatus
        /// </summary>
        public static readonly ResourceSignalStatus FAILURE = new ResourceSignalStatus("FAILURE");
        /// <summary>
        /// Constant SUCCESS for ResourceSignalStatus
        /// </summary>
        public static readonly ResourceSignalStatus SUCCESS = new ResourceSignalStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSignalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSignalStatus FindValue(string value)
        {
            return FindValue<ResourceSignalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSignalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATE_COMPLETE = new ResourceStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATE_FAILED = new ResourceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATE_IN_PROGRESS = new ResourceStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETE_COMPLETE = new ResourceStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETE_FAILED = new ResourceStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETE_IN_PROGRESS = new ResourceStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_SKIPPED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETE_SKIPPED = new ResourceStatus("DELETE_SKIPPED");
        /// <summary>
        /// Constant IMPORT_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_COMPLETE = new ResourceStatus("IMPORT_COMPLETE");
        /// <summary>
        /// Constant IMPORT_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_FAILED = new ResourceStatus("IMPORT_FAILED");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_IN_PROGRESS = new ResourceStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_ROLLBACK_COMPLETE = new ResourceStatus("IMPORT_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_ROLLBACK_FAILED = new ResourceStatus("IMPORT_ROLLBACK_FAILED");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus IMPORT_ROLLBACK_IN_PROGRESS = new ResourceStatus("IMPORT_ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_COMPLETE = new ResourceStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_FAILED = new ResourceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_IN_PROGRESS = new ResourceStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackDriftDetectionStatus.
    /// </summary>
    public class StackDriftDetectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DETECTION_COMPLETE for StackDriftDetectionStatus
        /// </summary>
        public static readonly StackDriftDetectionStatus DETECTION_COMPLETE = new StackDriftDetectionStatus("DETECTION_COMPLETE");
        /// <summary>
        /// Constant DETECTION_FAILED for StackDriftDetectionStatus
        /// </summary>
        public static readonly StackDriftDetectionStatus DETECTION_FAILED = new StackDriftDetectionStatus("DETECTION_FAILED");
        /// <summary>
        /// Constant DETECTION_IN_PROGRESS for StackDriftDetectionStatus
        /// </summary>
        public static readonly StackDriftDetectionStatus DETECTION_IN_PROGRESS = new StackDriftDetectionStatus("DETECTION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackDriftDetectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackDriftDetectionStatus FindValue(string value)
        {
            return FindValue<StackDriftDetectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackDriftDetectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackDriftStatus.
    /// </summary>
    public class StackDriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRIFTED for StackDriftStatus
        /// </summary>
        public static readonly StackDriftStatus DRIFTED = new StackDriftStatus("DRIFTED");
        /// <summary>
        /// Constant IN_SYNC for StackDriftStatus
        /// </summary>
        public static readonly StackDriftStatus IN_SYNC = new StackDriftStatus("IN_SYNC");
        /// <summary>
        /// Constant NOT_CHECKED for StackDriftStatus
        /// </summary>
        public static readonly StackDriftStatus NOT_CHECKED = new StackDriftStatus("NOT_CHECKED");
        /// <summary>
        /// Constant UNKNOWN for StackDriftStatus
        /// </summary>
        public static readonly StackDriftStatus UNKNOWN = new StackDriftStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackDriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackDriftStatus FindValue(string value)
        {
            return FindValue<StackDriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackDriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackInstanceDetailedStatus.
    /// </summary>
    public class StackInstanceDetailedStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus CANCELLED = new StackInstanceDetailedStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus FAILED = new StackInstanceDetailedStatus("FAILED");
        /// <summary>
        /// Constant INOPERABLE for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus INOPERABLE = new StackInstanceDetailedStatus("INOPERABLE");
        /// <summary>
        /// Constant PENDING for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus PENDING = new StackInstanceDetailedStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus RUNNING = new StackInstanceDetailedStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus SUCCEEDED = new StackInstanceDetailedStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackInstanceDetailedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackInstanceDetailedStatus FindValue(string value)
        {
            return FindValue<StackInstanceDetailedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackInstanceDetailedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackInstanceFilterName.
    /// </summary>
    public class StackInstanceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DETAILED_STATUS for StackInstanceFilterName
        /// </summary>
        public static readonly StackInstanceFilterName DETAILED_STATUS = new StackInstanceFilterName("DETAILED_STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackInstanceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackInstanceFilterName FindValue(string value)
        {
            return FindValue<StackInstanceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackInstanceFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackInstanceStatus.
    /// </summary>
    public class StackInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT for StackInstanceStatus
        /// </summary>
        public static readonly StackInstanceStatus CURRENT = new StackInstanceStatus("CURRENT");
        /// <summary>
        /// Constant INOPERABLE for StackInstanceStatus
        /// </summary>
        public static readonly StackInstanceStatus INOPERABLE = new StackInstanceStatus("INOPERABLE");
        /// <summary>
        /// Constant OUTDATED for StackInstanceStatus
        /// </summary>
        public static readonly StackInstanceStatus OUTDATED = new StackInstanceStatus("OUTDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackInstanceStatus FindValue(string value)
        {
            return FindValue<StackInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackResourceDriftStatus.
    /// </summary>
    public class StackResourceDriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for StackResourceDriftStatus
        /// </summary>
        public static readonly StackResourceDriftStatus DELETED = new StackResourceDriftStatus("DELETED");
        /// <summary>
        /// Constant IN_SYNC for StackResourceDriftStatus
        /// </summary>
        public static readonly StackResourceDriftStatus IN_SYNC = new StackResourceDriftStatus("IN_SYNC");
        /// <summary>
        /// Constant MODIFIED for StackResourceDriftStatus
        /// </summary>
        public static readonly StackResourceDriftStatus MODIFIED = new StackResourceDriftStatus("MODIFIED");
        /// <summary>
        /// Constant NOT_CHECKED for StackResourceDriftStatus
        /// </summary>
        public static readonly StackResourceDriftStatus NOT_CHECKED = new StackResourceDriftStatus("NOT_CHECKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackResourceDriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackResourceDriftStatus FindValue(string value)
        {
            return FindValue<StackResourceDriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackResourceDriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetDriftDetectionStatus.
    /// </summary>
    public class StackSetDriftDetectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for StackSetDriftDetectionStatus
        /// </summary>
        public static readonly StackSetDriftDetectionStatus COMPLETED = new StackSetDriftDetectionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for StackSetDriftDetectionStatus
        /// </summary>
        public static readonly StackSetDriftDetectionStatus FAILED = new StackSetDriftDetectionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for StackSetDriftDetectionStatus
        /// </summary>
        public static readonly StackSetDriftDetectionStatus IN_PROGRESS = new StackSetDriftDetectionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PARTIAL_SUCCESS for StackSetDriftDetectionStatus
        /// </summary>
        public static readonly StackSetDriftDetectionStatus PARTIAL_SUCCESS = new StackSetDriftDetectionStatus("PARTIAL_SUCCESS");
        /// <summary>
        /// Constant STOPPED for StackSetDriftDetectionStatus
        /// </summary>
        public static readonly StackSetDriftDetectionStatus STOPPED = new StackSetDriftDetectionStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetDriftDetectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetDriftDetectionStatus FindValue(string value)
        {
            return FindValue<StackSetDriftDetectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetDriftDetectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetDriftStatus.
    /// </summary>
    public class StackSetDriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRIFTED for StackSetDriftStatus
        /// </summary>
        public static readonly StackSetDriftStatus DRIFTED = new StackSetDriftStatus("DRIFTED");
        /// <summary>
        /// Constant IN_SYNC for StackSetDriftStatus
        /// </summary>
        public static readonly StackSetDriftStatus IN_SYNC = new StackSetDriftStatus("IN_SYNC");
        /// <summary>
        /// Constant NOT_CHECKED for StackSetDriftStatus
        /// </summary>
        public static readonly StackSetDriftStatus NOT_CHECKED = new StackSetDriftStatus("NOT_CHECKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetDriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetDriftStatus FindValue(string value)
        {
            return FindValue<StackSetDriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetDriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetOperationAction.
    /// </summary>
    public class StackSetOperationAction : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for StackSetOperationAction
        /// </summary>
        public static readonly StackSetOperationAction CREATE = new StackSetOperationAction("CREATE");
        /// <summary>
        /// Constant DELETE for StackSetOperationAction
        /// </summary>
        public static readonly StackSetOperationAction DELETE = new StackSetOperationAction("DELETE");
        /// <summary>
        /// Constant DETECT_DRIFT for StackSetOperationAction
        /// </summary>
        public static readonly StackSetOperationAction DETECT_DRIFT = new StackSetOperationAction("DETECT_DRIFT");
        /// <summary>
        /// Constant UPDATE for StackSetOperationAction
        /// </summary>
        public static readonly StackSetOperationAction UPDATE = new StackSetOperationAction("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetOperationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetOperationAction FindValue(string value)
        {
            return FindValue<StackSetOperationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetOperationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetOperationResultStatus.
    /// </summary>
    public class StackSetOperationResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for StackSetOperationResultStatus
        /// </summary>
        public static readonly StackSetOperationResultStatus CANCELLED = new StackSetOperationResultStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for StackSetOperationResultStatus
        /// </summary>
        public static readonly StackSetOperationResultStatus FAILED = new StackSetOperationResultStatus("FAILED");
        /// <summary>
        /// Constant PENDING for StackSetOperationResultStatus
        /// </summary>
        public static readonly StackSetOperationResultStatus PENDING = new StackSetOperationResultStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for StackSetOperationResultStatus
        /// </summary>
        public static readonly StackSetOperationResultStatus RUNNING = new StackSetOperationResultStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for StackSetOperationResultStatus
        /// </summary>
        public static readonly StackSetOperationResultStatus SUCCEEDED = new StackSetOperationResultStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetOperationResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetOperationResultStatus FindValue(string value)
        {
            return FindValue<StackSetOperationResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetOperationResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetOperationStatus.
    /// </summary>
    public class StackSetOperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus FAILED = new StackSetOperationStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus QUEUED = new StackSetOperationStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus RUNNING = new StackSetOperationStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus STOPPED = new StackSetOperationStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus STOPPING = new StackSetOperationStatus("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for StackSetOperationStatus
        /// </summary>
        public static readonly StackSetOperationStatus SUCCEEDED = new StackSetOperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetOperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetOperationStatus FindValue(string value)
        {
            return FindValue<StackSetOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetOperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackSetStatus.
    /// </summary>
    public class StackSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StackSetStatus
        /// </summary>
        public static readonly StackSetStatus ACTIVE = new StackSetStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for StackSetStatus
        /// </summary>
        public static readonly StackSetStatus DELETED = new StackSetStatus("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackSetStatus FindValue(string value)
        {
            return FindValue<StackSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackStatus.
    /// </summary>
    public class StackStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus CREATE_COMPLETE = new StackStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus CREATE_FAILED = new StackStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus CREATE_IN_PROGRESS = new StackStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus DELETE_COMPLETE = new StackStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus DELETE_FAILED = new StackStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus DELETE_IN_PROGRESS = new StackStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant IMPORT_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus IMPORT_COMPLETE = new StackStatus("IMPORT_COMPLETE");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus IMPORT_IN_PROGRESS = new StackStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus IMPORT_ROLLBACK_COMPLETE = new StackStatus("IMPORT_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus IMPORT_ROLLBACK_FAILED = new StackStatus("IMPORT_ROLLBACK_FAILED");
        /// <summary>
        /// Constant IMPORT_ROLLBACK_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus IMPORT_ROLLBACK_IN_PROGRESS = new StackStatus("IMPORT_ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant REVIEW_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus REVIEW_IN_PROGRESS = new StackStatus("REVIEW_IN_PROGRESS");
        /// <summary>
        /// Constant ROLLBACK_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus ROLLBACK_COMPLETE = new StackStatus("ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant ROLLBACK_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus ROLLBACK_FAILED = new StackStatus("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus ROLLBACK_IN_PROGRESS = new StackStatus("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_COMPLETE = new StackStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_COMPLETE_CLEANUP_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_COMPLETE_CLEANUP_IN_PROGRESS = new StackStatus("UPDATE_COMPLETE_CLEANUP_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_IN_PROGRESS = new StackStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_COMPLETE for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_ROLLBACK_COMPLETE = new StackStatus("UPDATE_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS = new StackStatus("UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_ROLLBACK_FAILED = new StackStatus("UPDATE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_IN_PROGRESS for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_ROLLBACK_IN_PROGRESS = new StackStatus("UPDATE_ROLLBACK_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackStatus FindValue(string value)
        {
            return FindValue<StackStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateStage.
    /// </summary>
    public class TemplateStage : ConstantClass
    {

        /// <summary>
        /// Constant Original for TemplateStage
        /// </summary>
        public static readonly TemplateStage Original = new TemplateStage("Original");
        /// <summary>
        /// Constant Processed for TemplateStage
        /// </summary>
        public static readonly TemplateStage Processed = new TemplateStage("Processed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateStage FindValue(string value)
        {
            return FindValue<TemplateStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Visibility.
    /// </summary>
    public class Visibility : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for Visibility
        /// </summary>
        public static readonly Visibility PRIVATE = new Visibility("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for Visibility
        /// </summary>
        public static readonly Visibility PUBLIC = new Visibility("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Visibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Visibility FindValue(string value)
        {
            return FindValue<Visibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Visibility(string value)
        {
            return FindValue(value);
        }
    }

}