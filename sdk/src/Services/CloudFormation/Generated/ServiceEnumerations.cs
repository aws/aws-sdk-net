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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudFormation
{

    /// <summary>
    /// Constants used for properties of type Capability.
    /// </summary>
    public class Capability : ConstantClass
    {

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

}