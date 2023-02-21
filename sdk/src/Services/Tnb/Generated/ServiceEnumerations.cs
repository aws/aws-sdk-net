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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Tnb
{

    /// <summary>
    /// Constants used for properties of type DescriptorContentType.
    /// </summary>
    public class DescriptorContentType : ConstantClass
    {

        /// <summary>
        /// Constant TextPlain for DescriptorContentType
        /// </summary>
        public static readonly DescriptorContentType TextPlain = new DescriptorContentType("text/plain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescriptorContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescriptorContentType FindValue(string value)
        {
            return FindValue<DescriptorContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescriptorContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LcmOperationType.
    /// </summary>
    public class LcmOperationType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANTIATE for LcmOperationType
        /// </summary>
        public static readonly LcmOperationType INSTANTIATE = new LcmOperationType("INSTANTIATE");
        /// <summary>
        /// Constant TERMINATE for LcmOperationType
        /// </summary>
        public static readonly LcmOperationType TERMINATE = new LcmOperationType("TERMINATE");
        /// <summary>
        /// Constant UPDATE for LcmOperationType
        /// </summary>
        public static readonly LcmOperationType UPDATE = new LcmOperationType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LcmOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LcmOperationType FindValue(string value)
        {
            return FindValue<LcmOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LcmOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NsdOnboardingState.
    /// </summary>
    public class NsdOnboardingState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for NsdOnboardingState
        /// </summary>
        public static readonly NsdOnboardingState CREATED = new NsdOnboardingState("CREATED");
        /// <summary>
        /// Constant ERROR for NsdOnboardingState
        /// </summary>
        public static readonly NsdOnboardingState ERROR = new NsdOnboardingState("ERROR");
        /// <summary>
        /// Constant ONBOARDED for NsdOnboardingState
        /// </summary>
        public static readonly NsdOnboardingState ONBOARDED = new NsdOnboardingState("ONBOARDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NsdOnboardingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NsdOnboardingState FindValue(string value)
        {
            return FindValue<NsdOnboardingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NsdOnboardingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NsdOperationalState.
    /// </summary>
    public class NsdOperationalState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NsdOperationalState
        /// </summary>
        public static readonly NsdOperationalState DISABLED = new NsdOperationalState("DISABLED");
        /// <summary>
        /// Constant ENABLED for NsdOperationalState
        /// </summary>
        public static readonly NsdOperationalState ENABLED = new NsdOperationalState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NsdOperationalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NsdOperationalState FindValue(string value)
        {
            return FindValue<NsdOperationalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NsdOperationalState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NsdUsageState.
    /// </summary>
    public class NsdUsageState : ConstantClass
    {

        /// <summary>
        /// Constant IN_USE for NsdUsageState
        /// </summary>
        public static readonly NsdUsageState IN_USE = new NsdUsageState("IN_USE");
        /// <summary>
        /// Constant NOT_IN_USE for NsdUsageState
        /// </summary>
        public static readonly NsdUsageState NOT_IN_USE = new NsdUsageState("NOT_IN_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NsdUsageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NsdUsageState FindValue(string value)
        {
            return FindValue<NsdUsageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NsdUsageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NsLcmOperationState.
    /// </summary>
    public class NsLcmOperationState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for NsLcmOperationState
        /// </summary>
        public static readonly NsLcmOperationState CANCELLED = new NsLcmOperationState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for NsLcmOperationState
        /// </summary>
        public static readonly NsLcmOperationState CANCELLING = new NsLcmOperationState("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for NsLcmOperationState
        /// </summary>
        public static readonly NsLcmOperationState COMPLETED = new NsLcmOperationState("COMPLETED");
        /// <summary>
        /// Constant FAILED for NsLcmOperationState
        /// </summary>
        public static readonly NsLcmOperationState FAILED = new NsLcmOperationState("FAILED");
        /// <summary>
        /// Constant PROCESSING for NsLcmOperationState
        /// </summary>
        public static readonly NsLcmOperationState PROCESSING = new NsLcmOperationState("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NsLcmOperationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NsLcmOperationState FindValue(string value)
        {
            return FindValue<NsLcmOperationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NsLcmOperationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NsState.
    /// </summary>
    public class NsState : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for NsState
        /// </summary>
        public static readonly NsState DELETED = new NsState("DELETED");
        /// <summary>
        /// Constant IMPAIRED for NsState
        /// </summary>
        public static readonly NsState IMPAIRED = new NsState("IMPAIRED");
        /// <summary>
        /// Constant INSTANTIATE_IN_PROGRESS for NsState
        /// </summary>
        public static readonly NsState INSTANTIATE_IN_PROGRESS = new NsState("INSTANTIATE_IN_PROGRESS");
        /// <summary>
        /// Constant INSTANTIATED for NsState
        /// </summary>
        public static readonly NsState INSTANTIATED = new NsState("INSTANTIATED");
        /// <summary>
        /// Constant NOT_INSTANTIATED for NsState
        /// </summary>
        public static readonly NsState NOT_INSTANTIATED = new NsState("NOT_INSTANTIATED");
        /// <summary>
        /// Constant STOPPED for NsState
        /// </summary>
        public static readonly NsState STOPPED = new NsState("STOPPED");
        /// <summary>
        /// Constant TERMINATE_IN_PROGRESS for NsState
        /// </summary>
        public static readonly NsState TERMINATE_IN_PROGRESS = new NsState("TERMINATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for NsState
        /// </summary>
        public static readonly NsState UPDATE_IN_PROGRESS = new NsState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NsState FindValue(string value)
        {
            return FindValue<NsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnboardingState.
    /// </summary>
    public class OnboardingState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for OnboardingState
        /// </summary>
        public static readonly OnboardingState CREATED = new OnboardingState("CREATED");
        /// <summary>
        /// Constant ERROR for OnboardingState
        /// </summary>
        public static readonly OnboardingState ERROR = new OnboardingState("ERROR");
        /// <summary>
        /// Constant ONBOARDED for OnboardingState
        /// </summary>
        public static readonly OnboardingState ONBOARDED = new OnboardingState("ONBOARDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnboardingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnboardingState FindValue(string value)
        {
            return FindValue<OnboardingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnboardingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationalState.
    /// </summary>
    public class OperationalState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OperationalState
        /// </summary>
        public static readonly OperationalState DISABLED = new OperationalState("DISABLED");
        /// <summary>
        /// Constant ENABLED for OperationalState
        /// </summary>
        public static readonly OperationalState ENABLED = new OperationalState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationalState FindValue(string value)
        {
            return FindValue<OperationalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationalState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageContentType.
    /// </summary>
    public class PackageContentType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationZip for PackageContentType
        /// </summary>
        public static readonly PackageContentType ApplicationZip = new PackageContentType("application/zip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageContentType FindValue(string value)
        {
            return FindValue<PackageContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for TaskStatus
        /// </summary>
        public static readonly TaskStatus CANCELLED = new TaskStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for TaskStatus
        /// </summary>
        public static readonly TaskStatus COMPLETED = new TaskStatus("COMPLETED");
        /// <summary>
        /// Constant ERROR for TaskStatus
        /// </summary>
        public static readonly TaskStatus ERROR = new TaskStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for TaskStatus
        /// </summary>
        public static readonly TaskStatus IN_PROGRESS = new TaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SCHEDULED for TaskStatus
        /// </summary>
        public static readonly TaskStatus SCHEDULED = new TaskStatus("SCHEDULED");
        /// <summary>
        /// Constant SKIPPED for TaskStatus
        /// </summary>
        public static readonly TaskStatus SKIPPED = new TaskStatus("SKIPPED");
        /// <summary>
        /// Constant STARTED for TaskStatus
        /// </summary>
        public static readonly TaskStatus STARTED = new TaskStatus("STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateSolNetworkType.
    /// </summary>
    public class UpdateSolNetworkType : ConstantClass
    {

        /// <summary>
        /// Constant MODIFY_VNF_INFORMATION for UpdateSolNetworkType
        /// </summary>
        public static readonly UpdateSolNetworkType MODIFY_VNF_INFORMATION = new UpdateSolNetworkType("MODIFY_VNF_INFORMATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateSolNetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateSolNetworkType FindValue(string value)
        {
            return FindValue<UpdateSolNetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateSolNetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageState.
    /// </summary>
    public class UsageState : ConstantClass
    {

        /// <summary>
        /// Constant IN_USE for UsageState
        /// </summary>
        public static readonly UsageState IN_USE = new UsageState("IN_USE");
        /// <summary>
        /// Constant NOT_IN_USE for UsageState
        /// </summary>
        public static readonly UsageState NOT_IN_USE = new UsageState("NOT_IN_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageState FindValue(string value)
        {
            return FindValue<UsageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VnfInstantiationState.
    /// </summary>
    public class VnfInstantiationState : ConstantClass
    {

        /// <summary>
        /// Constant INSTANTIATED for VnfInstantiationState
        /// </summary>
        public static readonly VnfInstantiationState INSTANTIATED = new VnfInstantiationState("INSTANTIATED");
        /// <summary>
        /// Constant NOT_INSTANTIATED for VnfInstantiationState
        /// </summary>
        public static readonly VnfInstantiationState NOT_INSTANTIATED = new VnfInstantiationState("NOT_INSTANTIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VnfInstantiationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VnfInstantiationState FindValue(string value)
        {
            return FindValue<VnfInstantiationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VnfInstantiationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VnfOperationalState.
    /// </summary>
    public class VnfOperationalState : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for VnfOperationalState
        /// </summary>
        public static readonly VnfOperationalState STARTED = new VnfOperationalState("STARTED");
        /// <summary>
        /// Constant STOPPED for VnfOperationalState
        /// </summary>
        public static readonly VnfOperationalState STOPPED = new VnfOperationalState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VnfOperationalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VnfOperationalState FindValue(string value)
        {
            return FindValue<VnfOperationalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VnfOperationalState(string value)
        {
            return FindValue(value);
        }
    }

}