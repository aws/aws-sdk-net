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
    /// Constants used for properties of type AccountFilterType.
    /// </summary>
    public class AccountFilterType : ConstantClass
    {

        /// <summary>
        /// Constant DIFFERENCE for AccountFilterType
        /// </summary>
        public static readonly AccountFilterType DIFFERENCE = new AccountFilterType("DIFFERENCE");
        /// <summary>
        /// Constant INTERSECTION for AccountFilterType
        /// </summary>
        public static readonly AccountFilterType INTERSECTION = new AccountFilterType("INTERSECTION");
        /// <summary>
        /// Constant NONE for AccountFilterType
        /// </summary>
        public static readonly AccountFilterType NONE = new AccountFilterType("NONE");
        /// <summary>
        /// Constant UNION for AccountFilterType
        /// </summary>
        public static readonly AccountFilterType UNION = new AccountFilterType("UNION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountFilterType FindValue(string value)
        {
            return FindValue<AccountFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountFilterType(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type AttributeChangeType.
    /// </summary>
    public class AttributeChangeType : ConstantClass
    {

        /// <summary>
        /// Constant Add for AttributeChangeType
        /// </summary>
        public static readonly AttributeChangeType Add = new AttributeChangeType("Add");
        /// <summary>
        /// Constant Modify for AttributeChangeType
        /// </summary>
        public static readonly AttributeChangeType Modify = new AttributeChangeType("Modify");
        /// <summary>
        /// Constant Remove for AttributeChangeType
        /// </summary>
        public static readonly AttributeChangeType Remove = new AttributeChangeType("Remove");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeChangeType FindValue(string value)
        {
            return FindValue<AttributeChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallAs.
    /// </summary>
    public class CallAs : ConstantClass
    {

        /// <summary>
        /// Constant DELEGATED_ADMIN for CallAs
        /// </summary>
        public static readonly CallAs DELEGATED_ADMIN = new CallAs("DELEGATED_ADMIN");
        /// <summary>
        /// Constant SELF for CallAs
        /// </summary>
        public static readonly CallAs SELF = new CallAs("SELF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAs FindValue(string value)
        {
            return FindValue<CallAs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAs(string value)
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
    /// Constants used for properties of type Category.
    /// </summary>
    public class Category : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for Category
        /// </summary>
        public static readonly Category ACTIVATED = new Category("ACTIVATED");
        /// <summary>
        /// Constant AWS_TYPES for Category
        /// </summary>
        public static readonly Category AWS_TYPES = new Category("AWS_TYPES");
        /// <summary>
        /// Constant REGISTERED for Category
        /// </summary>
        public static readonly Category REGISTERED = new Category("REGISTERED");
        /// <summary>
        /// Constant THIRD_PARTY for Category
        /// </summary>
        public static readonly Category THIRD_PARTY = new Category("THIRD_PARTY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Category(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Category FindValue(string value)
        {
            return FindValue<Category>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Category(string value)
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
    /// Constants used for properties of type ChangeSetHooksStatus.
    /// </summary>
    public class ChangeSetHooksStatus : ConstantClass
    {

        /// <summary>
        /// Constant PLANNED for ChangeSetHooksStatus
        /// </summary>
        public static readonly ChangeSetHooksStatus PLANNED = new ChangeSetHooksStatus("PLANNED");
        /// <summary>
        /// Constant PLANNING for ChangeSetHooksStatus
        /// </summary>
        public static readonly ChangeSetHooksStatus PLANNING = new ChangeSetHooksStatus("PLANNING");
        /// <summary>
        /// Constant UNAVAILABLE for ChangeSetHooksStatus
        /// </summary>
        public static readonly ChangeSetHooksStatus UNAVAILABLE = new ChangeSetHooksStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSetHooksStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSetHooksStatus FindValue(string value)
        {
            return FindValue<ChangeSetHooksStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSetHooksStatus(string value)
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
    /// Constants used for properties of type ConcurrencyMode.
    /// </summary>
    public class ConcurrencyMode : ConstantClass
    {

        /// <summary>
        /// Constant SOFT_FAILURE_TOLERANCE for ConcurrencyMode
        /// </summary>
        public static readonly ConcurrencyMode SOFT_FAILURE_TOLERANCE = new ConcurrencyMode("SOFT_FAILURE_TOLERANCE");
        /// <summary>
        /// Constant STRICT_FAILURE_TOLERANCE for ConcurrencyMode
        /// </summary>
        public static readonly ConcurrencyMode STRICT_FAILURE_TOLERANCE = new ConcurrencyMode("STRICT_FAILURE_TOLERANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConcurrencyMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConcurrencyMode FindValue(string value)
        {
            return FindValue<ConcurrencyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConcurrencyMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletionMode.
    /// </summary>
    public class DeletionMode : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_DELETE_STACK for DeletionMode
        /// </summary>
        public static readonly DeletionMode FORCE_DELETE_STACK = new DeletionMode("FORCE_DELETE_STACK");
        /// <summary>
        /// Constant STANDARD for DeletionMode
        /// </summary>
        public static readonly DeletionMode STANDARD = new DeletionMode("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionMode FindValue(string value)
        {
            return FindValue<DeletionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionMode(string value)
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
    /// Constants used for properties of type DetailedStatus.
    /// </summary>
    public class DetailedStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_COMPLETE for DetailedStatus
        /// </summary>
        public static readonly DetailedStatus CONFIGURATION_COMPLETE = new DetailedStatus("CONFIGURATION_COMPLETE");
        /// <summary>
        /// Constant VALIDATION_FAILED for DetailedStatus
        /// </summary>
        public static readonly DetailedStatus VALIDATION_FAILED = new DetailedStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedStatus FindValue(string value)
        {
            return FindValue<DetailedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedStatus(string value)
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
    /// Constants used for properties of type GeneratedTemplateDeletionPolicy.
    /// </summary>
    public class GeneratedTemplateDeletionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for GeneratedTemplateDeletionPolicy
        /// </summary>
        public static readonly GeneratedTemplateDeletionPolicy DELETE = new GeneratedTemplateDeletionPolicy("DELETE");
        /// <summary>
        /// Constant RETAIN for GeneratedTemplateDeletionPolicy
        /// </summary>
        public static readonly GeneratedTemplateDeletionPolicy RETAIN = new GeneratedTemplateDeletionPolicy("RETAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedTemplateDeletionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedTemplateDeletionPolicy FindValue(string value)
        {
            return FindValue<GeneratedTemplateDeletionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedTemplateDeletionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedTemplateResourceStatus.
    /// </summary>
    public class GeneratedTemplateResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for GeneratedTemplateResourceStatus
        /// </summary>
        public static readonly GeneratedTemplateResourceStatus COMPLETE = new GeneratedTemplateResourceStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for GeneratedTemplateResourceStatus
        /// </summary>
        public static readonly GeneratedTemplateResourceStatus FAILED = new GeneratedTemplateResourceStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for GeneratedTemplateResourceStatus
        /// </summary>
        public static readonly GeneratedTemplateResourceStatus IN_PROGRESS = new GeneratedTemplateResourceStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for GeneratedTemplateResourceStatus
        /// </summary>
        public static readonly GeneratedTemplateResourceStatus PENDING = new GeneratedTemplateResourceStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedTemplateResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedTemplateResourceStatus FindValue(string value)
        {
            return FindValue<GeneratedTemplateResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedTemplateResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedTemplateStatus.
    /// </summary>
    public class GeneratedTemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus COMPLETE = new GeneratedTemplateStatus("COMPLETE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus CREATE_IN_PROGRESS = new GeneratedTemplateStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus CREATE_PENDING = new GeneratedTemplateStatus("CREATE_PENDING");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus DELETE_IN_PROGRESS = new GeneratedTemplateStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_PENDING for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus DELETE_PENDING = new GeneratedTemplateStatus("DELETE_PENDING");
        /// <summary>
        /// Constant FAILED for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus FAILED = new GeneratedTemplateStatus("FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus UPDATE_IN_PROGRESS = new GeneratedTemplateStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_PENDING for GeneratedTemplateStatus
        /// </summary>
        public static readonly GeneratedTemplateStatus UPDATE_PENDING = new GeneratedTemplateStatus("UPDATE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedTemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedTemplateStatus FindValue(string value)
        {
            return FindValue<GeneratedTemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedTemplateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedTemplateUpdateReplacePolicy.
    /// </summary>
    public class GeneratedTemplateUpdateReplacePolicy : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for GeneratedTemplateUpdateReplacePolicy
        /// </summary>
        public static readonly GeneratedTemplateUpdateReplacePolicy DELETE = new GeneratedTemplateUpdateReplacePolicy("DELETE");
        /// <summary>
        /// Constant RETAIN for GeneratedTemplateUpdateReplacePolicy
        /// </summary>
        public static readonly GeneratedTemplateUpdateReplacePolicy RETAIN = new GeneratedTemplateUpdateReplacePolicy("RETAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedTemplateUpdateReplacePolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedTemplateUpdateReplacePolicy FindValue(string value)
        {
            return FindValue<GeneratedTemplateUpdateReplacePolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedTemplateUpdateReplacePolicy(string value)
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
        /// Constant HandlerInternalFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode HandlerInternalFailure = new HandlerErrorCode("HandlerInternalFailure");
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
        /// Constant InvalidTypeConfiguration for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode InvalidTypeConfiguration = new HandlerErrorCode("InvalidTypeConfiguration");
        /// <summary>
        /// Constant NetworkFailure for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NetworkFailure = new HandlerErrorCode("NetworkFailure");
        /// <summary>
        /// Constant NonCompliant for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode NonCompliant = new HandlerErrorCode("NonCompliant");
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
        /// Constant Unknown for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode Unknown = new HandlerErrorCode("Unknown");
        /// <summary>
        /// Constant UnsupportedTarget for HandlerErrorCode
        /// </summary>
        public static readonly HandlerErrorCode UnsupportedTarget = new HandlerErrorCode("UnsupportedTarget");

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
    /// Constants used for properties of type HookFailureMode.
    /// </summary>
    public class HookFailureMode : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for HookFailureMode
        /// </summary>
        public static readonly HookFailureMode FAIL = new HookFailureMode("FAIL");
        /// <summary>
        /// Constant WARN for HookFailureMode
        /// </summary>
        public static readonly HookFailureMode WARN = new HookFailureMode("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HookFailureMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookFailureMode FindValue(string value)
        {
            return FindValue<HookFailureMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookFailureMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HookInvocationPoint.
    /// </summary>
    public class HookInvocationPoint : ConstantClass
    {

        /// <summary>
        /// Constant PRE_PROVISION for HookInvocationPoint
        /// </summary>
        public static readonly HookInvocationPoint PRE_PROVISION = new HookInvocationPoint("PRE_PROVISION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HookInvocationPoint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookInvocationPoint FindValue(string value)
        {
            return FindValue<HookInvocationPoint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookInvocationPoint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HookStatus.
    /// </summary>
    public class HookStatus : ConstantClass
    {

        /// <summary>
        /// Constant HOOK_COMPLETE_FAILED for HookStatus
        /// </summary>
        public static readonly HookStatus HOOK_COMPLETE_FAILED = new HookStatus("HOOK_COMPLETE_FAILED");
        /// <summary>
        /// Constant HOOK_COMPLETE_SUCCEEDED for HookStatus
        /// </summary>
        public static readonly HookStatus HOOK_COMPLETE_SUCCEEDED = new HookStatus("HOOK_COMPLETE_SUCCEEDED");
        /// <summary>
        /// Constant HOOK_FAILED for HookStatus
        /// </summary>
        public static readonly HookStatus HOOK_FAILED = new HookStatus("HOOK_FAILED");
        /// <summary>
        /// Constant HOOK_IN_PROGRESS for HookStatus
        /// </summary>
        public static readonly HookStatus HOOK_IN_PROGRESS = new HookStatus("HOOK_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HookStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookStatus FindValue(string value)
        {
            return FindValue<HookStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HookTargetType.
    /// </summary>
    public class HookTargetType : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE for HookTargetType
        /// </summary>
        public static readonly HookTargetType RESOURCE = new HookTargetType("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HookTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookTargetType FindValue(string value)
        {
            return FindValue<HookTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProvider.
    /// </summary>
    public class IdentityProvider : ConstantClass
    {

        /// <summary>
        /// Constant AWS_Marketplace for IdentityProvider
        /// </summary>
        public static readonly IdentityProvider AWS_Marketplace = new IdentityProvider("AWS_Marketplace");
        /// <summary>
        /// Constant Bitbucket for IdentityProvider
        /// </summary>
        public static readonly IdentityProvider Bitbucket = new IdentityProvider("Bitbucket");
        /// <summary>
        /// Constant GitHub for IdentityProvider
        /// </summary>
        public static readonly IdentityProvider GitHub = new IdentityProvider("GitHub");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProvider FindValue(string value)
        {
            return FindValue<IdentityProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListHookResultsTargetType.
    /// </summary>
    public class ListHookResultsTargetType : ConstantClass
    {

        /// <summary>
        /// Constant CHANGE_SET for ListHookResultsTargetType
        /// </summary>
        public static readonly ListHookResultsTargetType CHANGE_SET = new ListHookResultsTargetType("CHANGE_SET");
        /// <summary>
        /// Constant CLOUD_CONTROL for ListHookResultsTargetType
        /// </summary>
        public static readonly ListHookResultsTargetType CLOUD_CONTROL = new ListHookResultsTargetType("CLOUD_CONTROL");
        /// <summary>
        /// Constant RESOURCE for ListHookResultsTargetType
        /// </summary>
        public static readonly ListHookResultsTargetType RESOURCE = new ListHookResultsTargetType("RESOURCE");
        /// <summary>
        /// Constant STACK for ListHookResultsTargetType
        /// </summary>
        public static readonly ListHookResultsTargetType STACK = new ListHookResultsTargetType("STACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListHookResultsTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListHookResultsTargetType FindValue(string value)
        {
            return FindValue<ListHookResultsTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListHookResultsTargetType(string value)
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
    /// Constants used for properties of type OnStackFailure.
    /// </summary>
    public class OnStackFailure : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for OnStackFailure
        /// </summary>
        public static readonly OnStackFailure DELETE = new OnStackFailure("DELETE");
        /// <summary>
        /// Constant DO_NOTHING for OnStackFailure
        /// </summary>
        public static readonly OnStackFailure DO_NOTHING = new OnStackFailure("DO_NOTHING");
        /// <summary>
        /// Constant ROLLBACK for OnStackFailure
        /// </summary>
        public static readonly OnStackFailure ROLLBACK = new OnStackFailure("ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnStackFailure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnStackFailure FindValue(string value)
        {
            return FindValue<OnStackFailure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnStackFailure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationResultFilterName.
    /// </summary>
    public class OperationResultFilterName : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_RESULT_STATUS for OperationResultFilterName
        /// </summary>
        public static readonly OperationResultFilterName OPERATION_RESULT_STATUS = new OperationResultFilterName("OPERATION_RESULT_STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationResultFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationResultFilterName FindValue(string value)
        {
            return FindValue<OperationResultFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationResultFilterName(string value)
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
    /// Constants used for properties of type OrganizationStatus.
    /// </summary>
    public class OrganizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OrganizationStatus
        /// </summary>
        public static readonly OrganizationStatus DISABLED = new OrganizationStatus("DISABLED");
        /// <summary>
        /// Constant DISABLED_PERMANENTLY for OrganizationStatus
        /// </summary>
        public static readonly OrganizationStatus DISABLED_PERMANENTLY = new OrganizationStatus("DISABLED_PERMANENTLY");
        /// <summary>
        /// Constant ENABLED for OrganizationStatus
        /// </summary>
        public static readonly OrganizationStatus ENABLED = new OrganizationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationStatus FindValue(string value)
        {
            return FindValue<OrganizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationStatus(string value)
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
    /// Constants used for properties of type PolicyAction.
    /// </summary>
    public class PolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant Delete for PolicyAction
        /// </summary>
        public static readonly PolicyAction Delete = new PolicyAction("Delete");
        /// <summary>
        /// Constant ReplaceAndDelete for PolicyAction
        /// </summary>
        public static readonly PolicyAction ReplaceAndDelete = new PolicyAction("ReplaceAndDelete");
        /// <summary>
        /// Constant ReplaceAndRetain for PolicyAction
        /// </summary>
        public static readonly PolicyAction ReplaceAndRetain = new PolicyAction("ReplaceAndRetain");
        /// <summary>
        /// Constant ReplaceAndSnapshot for PolicyAction
        /// </summary>
        public static readonly PolicyAction ReplaceAndSnapshot = new PolicyAction("ReplaceAndSnapshot");
        /// <summary>
        /// Constant Retain for PolicyAction
        /// </summary>
        public static readonly PolicyAction Retain = new PolicyAction("Retain");
        /// <summary>
        /// Constant Snapshot for PolicyAction
        /// </summary>
        public static readonly PolicyAction Snapshot = new PolicyAction("Snapshot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyAction FindValue(string value)
        {
            return FindValue<PolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyAction(string value)
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
    /// Constants used for properties of type PublisherStatus.
    /// </summary>
    public class PublisherStatus : ConstantClass
    {

        /// <summary>
        /// Constant UNVERIFIED for PublisherStatus
        /// </summary>
        public static readonly PublisherStatus UNVERIFIED = new PublisherStatus("UNVERIFIED");
        /// <summary>
        /// Constant VERIFIED for PublisherStatus
        /// </summary>
        public static readonly PublisherStatus VERIFIED = new PublisherStatus("VERIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublisherStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublisherStatus FindValue(string value)
        {
            return FindValue<PublisherStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublisherStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionConcurrencyType.
    /// </summary>
    public class RegionConcurrencyType : ConstantClass
    {

        /// <summary>
        /// Constant PARALLEL for RegionConcurrencyType
        /// </summary>
        public static readonly RegionConcurrencyType PARALLEL = new RegionConcurrencyType("PARALLEL");
        /// <summary>
        /// Constant SEQUENTIAL for RegionConcurrencyType
        /// </summary>
        public static readonly RegionConcurrencyType SEQUENTIAL = new RegionConcurrencyType("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionConcurrencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionConcurrencyType FindValue(string value)
        {
            return FindValue<RegionConcurrencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionConcurrencyType(string value)
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
        /// Constant HOOK for RegistryType
        /// </summary>
        public static readonly RegistryType HOOK = new RegistryType("HOOK");
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
        /// Constant UpdateReplacePolicy for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute UpdateReplacePolicy = new ResourceAttribute("UpdateReplacePolicy");

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
    /// Constants used for properties of type ResourceScanStatus.
    /// </summary>
    public class ResourceScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ResourceScanStatus
        /// </summary>
        public static readonly ResourceScanStatus COMPLETE = new ResourceScanStatus("COMPLETE");
        /// <summary>
        /// Constant EXPIRED for ResourceScanStatus
        /// </summary>
        public static readonly ResourceScanStatus EXPIRED = new ResourceScanStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for ResourceScanStatus
        /// </summary>
        public static readonly ResourceScanStatus FAILED = new ResourceScanStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ResourceScanStatus
        /// </summary>
        public static readonly ResourceScanStatus IN_PROGRESS = new ResourceScanStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceScanStatus FindValue(string value)
        {
            return FindValue<ResourceScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceScanStatus(string value)
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
        /// Constant EXPORT_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_COMPLETE = new ResourceStatus("EXPORT_COMPLETE");
        /// <summary>
        /// Constant EXPORT_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_FAILED = new ResourceStatus("EXPORT_FAILED");
        /// <summary>
        /// Constant EXPORT_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_IN_PROGRESS = new ResourceStatus("EXPORT_IN_PROGRESS");
        /// <summary>
        /// Constant EXPORT_ROLLBACK_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_ROLLBACK_COMPLETE = new ResourceStatus("EXPORT_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant EXPORT_ROLLBACK_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_ROLLBACK_FAILED = new ResourceStatus("EXPORT_ROLLBACK_FAILED");
        /// <summary>
        /// Constant EXPORT_ROLLBACK_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus EXPORT_ROLLBACK_IN_PROGRESS = new ResourceStatus("EXPORT_ROLLBACK_IN_PROGRESS");
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
        /// Constant ROLLBACK_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ROLLBACK_COMPLETE = new ResourceStatus("ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant ROLLBACK_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ROLLBACK_FAILED = new ResourceStatus("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ROLLBACK_IN_PROGRESS = new ResourceStatus("ROLLBACK_IN_PROGRESS");
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
        /// Constant UPDATE_ROLLBACK_COMPLETE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_ROLLBACK_COMPLETE = new ResourceStatus("UPDATE_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_ROLLBACK_FAILED = new ResourceStatus("UPDATE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_ROLLBACK_IN_PROGRESS = new ResourceStatus("UPDATE_ROLLBACK_IN_PROGRESS");

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
    /// Constants used for properties of type ScanType.
    /// </summary>
    public class ScanType : ConstantClass
    {

        /// <summary>
        /// Constant FULL for ScanType
        /// </summary>
        public static readonly ScanType FULL = new ScanType("FULL");
        /// <summary>
        /// Constant PARTIAL for ScanType
        /// </summary>
        public static readonly ScanType PARTIAL = new ScanType("PARTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanType FindValue(string value)
        {
            return FindValue<ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanType(string value)
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
        /// Constant FAILED_IMPORT for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus FAILED_IMPORT = new StackInstanceDetailedStatus("FAILED_IMPORT");
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
        /// Constant SKIPPED_SUSPENDED_ACCOUNT for StackInstanceDetailedStatus
        /// </summary>
        public static readonly StackInstanceDetailedStatus SKIPPED_SUSPENDED_ACCOUNT = new StackInstanceDetailedStatus("SKIPPED_SUSPENDED_ACCOUNT");
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
        /// Constant DRIFT_STATUS for StackInstanceFilterName
        /// </summary>
        public static readonly StackInstanceFilterName DRIFT_STATUS = new StackInstanceFilterName("DRIFT_STATUS");
        /// <summary>
        /// Constant LAST_OPERATION_ID for StackInstanceFilterName
        /// </summary>
        public static readonly StackInstanceFilterName LAST_OPERATION_ID = new StackInstanceFilterName("LAST_OPERATION_ID");

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
    /// Constants used for properties of type StackRefactorActionEntity.
    /// </summary>
    public class StackRefactorActionEntity : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE for StackRefactorActionEntity
        /// </summary>
        public static readonly StackRefactorActionEntity RESOURCE = new StackRefactorActionEntity("RESOURCE");
        /// <summary>
        /// Constant STACK for StackRefactorActionEntity
        /// </summary>
        public static readonly StackRefactorActionEntity STACK = new StackRefactorActionEntity("STACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackRefactorActionEntity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackRefactorActionEntity FindValue(string value)
        {
            return FindValue<StackRefactorActionEntity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackRefactorActionEntity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackRefactorActionType.
    /// </summary>
    public class StackRefactorActionType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for StackRefactorActionType
        /// </summary>
        public static readonly StackRefactorActionType CREATE = new StackRefactorActionType("CREATE");
        /// <summary>
        /// Constant MOVE for StackRefactorActionType
        /// </summary>
        public static readonly StackRefactorActionType MOVE = new StackRefactorActionType("MOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackRefactorActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackRefactorActionType FindValue(string value)
        {
            return FindValue<StackRefactorActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackRefactorActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackRefactorDetection.
    /// </summary>
    public class StackRefactorDetection : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for StackRefactorDetection
        /// </summary>
        public static readonly StackRefactorDetection AUTO = new StackRefactorDetection("AUTO");
        /// <summary>
        /// Constant MANUAL for StackRefactorDetection
        /// </summary>
        public static readonly StackRefactorDetection MANUAL = new StackRefactorDetection("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackRefactorDetection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackRefactorDetection FindValue(string value)
        {
            return FindValue<StackRefactorDetection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackRefactorDetection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackRefactorExecutionStatus.
    /// </summary>
    public class StackRefactorExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus AVAILABLE = new StackRefactorExecutionStatus("AVAILABLE");
        /// <summary>
        /// Constant EXECUTE_COMPLETE for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus EXECUTE_COMPLETE = new StackRefactorExecutionStatus("EXECUTE_COMPLETE");
        /// <summary>
        /// Constant EXECUTE_FAILED for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus EXECUTE_FAILED = new StackRefactorExecutionStatus("EXECUTE_FAILED");
        /// <summary>
        /// Constant EXECUTE_IN_PROGRESS for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus EXECUTE_IN_PROGRESS = new StackRefactorExecutionStatus("EXECUTE_IN_PROGRESS");
        /// <summary>
        /// Constant OBSOLETE for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus OBSOLETE = new StackRefactorExecutionStatus("OBSOLETE");
        /// <summary>
        /// Constant ROLLBACK_COMPLETE for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus ROLLBACK_COMPLETE = new StackRefactorExecutionStatus("ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant ROLLBACK_FAILED for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus ROLLBACK_FAILED = new StackRefactorExecutionStatus("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus ROLLBACK_IN_PROGRESS = new StackRefactorExecutionStatus("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant UNAVAILABLE for StackRefactorExecutionStatus
        /// </summary>
        public static readonly StackRefactorExecutionStatus UNAVAILABLE = new StackRefactorExecutionStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackRefactorExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackRefactorExecutionStatus FindValue(string value)
        {
            return FindValue<StackRefactorExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackRefactorExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackRefactorStatus.
    /// </summary>
    public class StackRefactorStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus CREATE_COMPLETE = new StackRefactorStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus CREATE_FAILED = new StackRefactorStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus CREATE_IN_PROGRESS = new StackRefactorStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus DELETE_COMPLETE = new StackRefactorStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus DELETE_FAILED = new StackRefactorStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StackRefactorStatus
        /// </summary>
        public static readonly StackRefactorStatus DELETE_IN_PROGRESS = new StackRefactorStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackRefactorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackRefactorStatus FindValue(string value)
        {
            return FindValue<StackRefactorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackRefactorStatus(string value)
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
        /// Constant UNKNOWN for StackResourceDriftStatus
        /// </summary>
        public static readonly StackResourceDriftStatus UNKNOWN = new StackResourceDriftStatus("UNKNOWN");

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
        /// Constant UPDATE_FAILED for StackStatus
        /// </summary>
        public static readonly StackStatus UPDATE_FAILED = new StackStatus("UPDATE_FAILED");
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
    /// Constants used for properties of type TemplateFormat.
    /// </summary>
    public class TemplateFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for TemplateFormat
        /// </summary>
        public static readonly TemplateFormat JSON = new TemplateFormat("JSON");
        /// <summary>
        /// Constant YAML for TemplateFormat
        /// </summary>
        public static readonly TemplateFormat YAML = new TemplateFormat("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateFormat FindValue(string value)
        {
            return FindValue<TemplateFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateFormat(string value)
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
    /// Constants used for properties of type ThirdPartyType.
    /// </summary>
    public class ThirdPartyType : ConstantClass
    {

        /// <summary>
        /// Constant HOOK for ThirdPartyType
        /// </summary>
        public static readonly ThirdPartyType HOOK = new ThirdPartyType("HOOK");
        /// <summary>
        /// Constant MODULE for ThirdPartyType
        /// </summary>
        public static readonly ThirdPartyType MODULE = new ThirdPartyType("MODULE");
        /// <summary>
        /// Constant RESOURCE for ThirdPartyType
        /// </summary>
        public static readonly ThirdPartyType RESOURCE = new ThirdPartyType("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThirdPartyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThirdPartyType FindValue(string value)
        {
            return FindValue<ThirdPartyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThirdPartyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypeTestsStatus.
    /// </summary>
    public class TypeTestsStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for TypeTestsStatus
        /// </summary>
        public static readonly TypeTestsStatus FAILED = new TypeTestsStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TypeTestsStatus
        /// </summary>
        public static readonly TypeTestsStatus IN_PROGRESS = new TypeTestsStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_TESTED for TypeTestsStatus
        /// </summary>
        public static readonly TypeTestsStatus NOT_TESTED = new TypeTestsStatus("NOT_TESTED");
        /// <summary>
        /// Constant PASSED for TypeTestsStatus
        /// </summary>
        public static readonly TypeTestsStatus PASSED = new TypeTestsStatus("PASSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypeTestsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypeTestsStatus FindValue(string value)
        {
            return FindValue<TypeTestsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypeTestsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VersionBump.
    /// </summary>
    public class VersionBump : ConstantClass
    {

        /// <summary>
        /// Constant MAJOR for VersionBump
        /// </summary>
        public static readonly VersionBump MAJOR = new VersionBump("MAJOR");
        /// <summary>
        /// Constant MINOR for VersionBump
        /// </summary>
        public static readonly VersionBump MINOR = new VersionBump("MINOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionBump(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionBump FindValue(string value)
        {
            return FindValue<VersionBump>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionBump(string value)
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


    /// <summary>
    /// Constants used for properties of type WarningType.
    /// </summary>
    public class WarningType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDED_PROPERTIES for WarningType
        /// </summary>
        public static readonly WarningType EXCLUDED_PROPERTIES = new WarningType("EXCLUDED_PROPERTIES");
        /// <summary>
        /// Constant MUTUALLY_EXCLUSIVE_PROPERTIES for WarningType
        /// </summary>
        public static readonly WarningType MUTUALLY_EXCLUSIVE_PROPERTIES = new WarningType("MUTUALLY_EXCLUSIVE_PROPERTIES");
        /// <summary>
        /// Constant MUTUALLY_EXCLUSIVE_TYPES for WarningType
        /// </summary>
        public static readonly WarningType MUTUALLY_EXCLUSIVE_TYPES = new WarningType("MUTUALLY_EXCLUSIVE_TYPES");
        /// <summary>
        /// Constant UNSUPPORTED_PROPERTIES for WarningType
        /// </summary>
        public static readonly WarningType UNSUPPORTED_PROPERTIES = new WarningType("UNSUPPORTED_PROPERTIES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WarningType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WarningType FindValue(string value)
        {
            return FindValue<WarningType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WarningType(string value)
        {
            return FindValue(value);
        }
    }

}