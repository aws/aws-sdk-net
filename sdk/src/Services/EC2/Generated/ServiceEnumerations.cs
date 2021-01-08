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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EC2
{

    /// <summary>
    /// Constants used for properties of type AccountAttributeName.
    /// </summary>
    public class AccountAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant DefaultVpc for AccountAttributeName
        /// </summary>
        public static readonly AccountAttributeName DefaultVpc = new AccountAttributeName("default-vpc");
        /// <summary>
        /// Constant SupportedPlatforms for AccountAttributeName
        /// </summary>
        public static readonly AccountAttributeName SupportedPlatforms = new AccountAttributeName("supported-platforms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountAttributeName FindValue(string value)
        {
            return FindValue<AccountAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivityStatus.
    /// </summary>
    public class ActivityStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus Error = new ActivityStatus("error");
        /// <summary>
        /// Constant Fulfilled for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus Fulfilled = new ActivityStatus("fulfilled");
        /// <summary>
        /// Constant Pending_fulfillment for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus Pending_fulfillment = new ActivityStatus("pending_fulfillment");
        /// <summary>
        /// Constant Pending_termination for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus Pending_termination = new ActivityStatus("pending_termination");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStatus FindValue(string value)
        {
            return FindValue<ActivityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Affinity.
    /// </summary>
    public class Affinity : ConstantClass
    {

        /// <summary>
        /// Constant Default for Affinity
        /// </summary>
        public static readonly Affinity Default = new Affinity("default");
        /// <summary>
        /// Constant Host for Affinity
        /// </summary>
        public static readonly Affinity Host = new Affinity("host");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Affinity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Affinity FindValue(string value)
        {
            return FindValue<Affinity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Affinity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllocationState.
    /// </summary>
    public class AllocationState : ConstantClass
    {

        /// <summary>
        /// Constant Available for AllocationState
        /// </summary>
        public static readonly AllocationState Available = new AllocationState("available");
        /// <summary>
        /// Constant Pending for AllocationState
        /// </summary>
        public static readonly AllocationState Pending = new AllocationState("pending");
        /// <summary>
        /// Constant PermanentFailure for AllocationState
        /// </summary>
        public static readonly AllocationState PermanentFailure = new AllocationState("permanent-failure");
        /// <summary>
        /// Constant Released for AllocationState
        /// </summary>
        public static readonly AllocationState Released = new AllocationState("released");
        /// <summary>
        /// Constant ReleasedPermanentFailure for AllocationState
        /// </summary>
        public static readonly AllocationState ReleasedPermanentFailure = new AllocationState("released-permanent-failure");
        /// <summary>
        /// Constant UnderAssessment for AllocationState
        /// </summary>
        public static readonly AllocationState UnderAssessment = new AllocationState("under-assessment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllocationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllocationState FindValue(string value)
        {
            return FindValue<AllocationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllocationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllocationStrategy.
    /// </summary>
    public class AllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CapacityOptimized for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy CapacityOptimized = new AllocationStrategy("capacityOptimized");
        /// <summary>
        /// Constant Diversified for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy Diversified = new AllocationStrategy("diversified");
        /// <summary>
        /// Constant LowestPrice for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy LowestPrice = new AllocationStrategy("lowestPrice");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllocationStrategy FindValue(string value)
        {
            return FindValue<AllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowsMultipleInstanceTypes.
    /// </summary>
    public class AllowsMultipleInstanceTypes : ConstantClass
    {

        /// <summary>
        /// Constant Off for AllowsMultipleInstanceTypes
        /// </summary>
        public static readonly AllowsMultipleInstanceTypes Off = new AllowsMultipleInstanceTypes("off");
        /// <summary>
        /// Constant On for AllowsMultipleInstanceTypes
        /// </summary>
        public static readonly AllowsMultipleInstanceTypes On = new AllowsMultipleInstanceTypes("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowsMultipleInstanceTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowsMultipleInstanceTypes FindValue(string value)
        {
            return FindValue<AllowsMultipleInstanceTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowsMultipleInstanceTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisStatus.
    /// </summary>
    public class AnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus Failed = new AnalysisStatus("failed");
        /// <summary>
        /// Constant Running for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus Running = new AnalysisStatus("running");
        /// <summary>
        /// Constant Succeeded for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus Succeeded = new AnalysisStatus("succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisStatus FindValue(string value)
        {
            return FindValue<AnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplianceModeSupportValue.
    /// </summary>
    public class ApplianceModeSupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for ApplianceModeSupportValue
        /// </summary>
        public static readonly ApplianceModeSupportValue Disable = new ApplianceModeSupportValue("disable");
        /// <summary>
        /// Constant Enable for ApplianceModeSupportValue
        /// </summary>
        public static readonly ApplianceModeSupportValue Enable = new ApplianceModeSupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplianceModeSupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplianceModeSupportValue FindValue(string value)
        {
            return FindValue<ApplianceModeSupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplianceModeSupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchitectureType.
    /// </summary>
    public class ArchitectureType : ConstantClass
    {

        /// <summary>
        /// Constant Arm64 for ArchitectureType
        /// </summary>
        public static readonly ArchitectureType Arm64 = new ArchitectureType("arm64");
        /// <summary>
        /// Constant I386 for ArchitectureType
        /// </summary>
        public static readonly ArchitectureType I386 = new ArchitectureType("i386");
        /// <summary>
        /// Constant X86_64 for ArchitectureType
        /// </summary>
        public static readonly ArchitectureType X86_64 = new ArchitectureType("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchitectureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchitectureType FindValue(string value)
        {
            return FindValue<ArchitectureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchitectureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchitectureValues.
    /// </summary>
    public class ArchitectureValues : ConstantClass
    {

        /// <summary>
        /// Constant Arm64 for ArchitectureValues
        /// </summary>
        public static readonly ArchitectureValues Arm64 = new ArchitectureValues("arm64");
        /// <summary>
        /// Constant I386 for ArchitectureValues
        /// </summary>
        public static readonly ArchitectureValues I386 = new ArchitectureValues("i386");
        /// <summary>
        /// Constant X86_64 for ArchitectureValues
        /// </summary>
        public static readonly ArchitectureValues X86_64 = new ArchitectureValues("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchitectureValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchitectureValues FindValue(string value)
        {
            return FindValue<ArchitectureValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchitectureValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociatedNetworkType.
    /// </summary>
    public class AssociatedNetworkType : ConstantClass
    {

        /// <summary>
        /// Constant Vpc for AssociatedNetworkType
        /// </summary>
        public static readonly AssociatedNetworkType Vpc = new AssociatedNetworkType("vpc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociatedNetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociatedNetworkType FindValue(string value)
        {
            return FindValue<AssociatedNetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociatedNetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatusCode.
    /// </summary>
    public class AssociationStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Associated for AssociationStatusCode
        /// </summary>
        public static readonly AssociationStatusCode Associated = new AssociationStatusCode("associated");
        /// <summary>
        /// Constant Associating for AssociationStatusCode
        /// </summary>
        public static readonly AssociationStatusCode Associating = new AssociationStatusCode("associating");
        /// <summary>
        /// Constant AssociationFailed for AssociationStatusCode
        /// </summary>
        public static readonly AssociationStatusCode AssociationFailed = new AssociationStatusCode("association-failed");
        /// <summary>
        /// Constant Disassociated for AssociationStatusCode
        /// </summary>
        public static readonly AssociationStatusCode Disassociated = new AssociationStatusCode("disassociated");
        /// <summary>
        /// Constant Disassociating for AssociationStatusCode
        /// </summary>
        public static readonly AssociationStatusCode Disassociating = new AssociationStatusCode("disassociating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatusCode FindValue(string value)
        {
            return FindValue<AssociationStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentStatus.
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Attached for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus Attached = new AttachmentStatus("attached");
        /// <summary>
        /// Constant Attaching for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus Attaching = new AttachmentStatus("attaching");
        /// <summary>
        /// Constant Detached for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus Detached = new AttachmentStatus("detached");
        /// <summary>
        /// Constant Detaching for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus Detaching = new AttachmentStatus("detaching");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoAcceptSharedAssociationsValue.
    /// </summary>
    public class AutoAcceptSharedAssociationsValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for AutoAcceptSharedAssociationsValue
        /// </summary>
        public static readonly AutoAcceptSharedAssociationsValue Disable = new AutoAcceptSharedAssociationsValue("disable");
        /// <summary>
        /// Constant Enable for AutoAcceptSharedAssociationsValue
        /// </summary>
        public static readonly AutoAcceptSharedAssociationsValue Enable = new AutoAcceptSharedAssociationsValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoAcceptSharedAssociationsValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoAcceptSharedAssociationsValue FindValue(string value)
        {
            return FindValue<AutoAcceptSharedAssociationsValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoAcceptSharedAssociationsValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoAcceptSharedAttachmentsValue.
    /// </summary>
    public class AutoAcceptSharedAttachmentsValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for AutoAcceptSharedAttachmentsValue
        /// </summary>
        public static readonly AutoAcceptSharedAttachmentsValue Disable = new AutoAcceptSharedAttachmentsValue("disable");
        /// <summary>
        /// Constant Enable for AutoAcceptSharedAttachmentsValue
        /// </summary>
        public static readonly AutoAcceptSharedAttachmentsValue Enable = new AutoAcceptSharedAttachmentsValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoAcceptSharedAttachmentsValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoAcceptSharedAttachmentsValue FindValue(string value)
        {
            return FindValue<AutoAcceptSharedAttachmentsValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoAcceptSharedAttachmentsValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoPlacement.
    /// </summary>
    public class AutoPlacement : ConstantClass
    {

        /// <summary>
        /// Constant Off for AutoPlacement
        /// </summary>
        public static readonly AutoPlacement Off = new AutoPlacement("off");
        /// <summary>
        /// Constant On for AutoPlacement
        /// </summary>
        public static readonly AutoPlacement On = new AutoPlacement("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoPlacement FindValue(string value)
        {
            return FindValue<AutoPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailabilityZoneOptInStatus.
    /// </summary>
    public class AvailabilityZoneOptInStatus : ConstantClass
    {

        /// <summary>
        /// Constant NotOptedIn for AvailabilityZoneOptInStatus
        /// </summary>
        public static readonly AvailabilityZoneOptInStatus NotOptedIn = new AvailabilityZoneOptInStatus("not-opted-in");
        /// <summary>
        /// Constant OptedIn for AvailabilityZoneOptInStatus
        /// </summary>
        public static readonly AvailabilityZoneOptInStatus OptedIn = new AvailabilityZoneOptInStatus("opted-in");
        /// <summary>
        /// Constant OptInNotRequired for AvailabilityZoneOptInStatus
        /// </summary>
        public static readonly AvailabilityZoneOptInStatus OptInNotRequired = new AvailabilityZoneOptInStatus("opt-in-not-required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityZoneOptInStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityZoneOptInStatus FindValue(string value)
        {
            return FindValue<AvailabilityZoneOptInStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityZoneOptInStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailabilityZoneState.
    /// </summary>
    public class AvailabilityZoneState : ConstantClass
    {

        /// <summary>
        /// Constant Available for AvailabilityZoneState
        /// </summary>
        public static readonly AvailabilityZoneState Available = new AvailabilityZoneState("available");
        /// <summary>
        /// Constant Impaired for AvailabilityZoneState
        /// </summary>
        public static readonly AvailabilityZoneState Impaired = new AvailabilityZoneState("impaired");
        /// <summary>
        /// Constant Information for AvailabilityZoneState
        /// </summary>
        public static readonly AvailabilityZoneState Information = new AvailabilityZoneState("information");
        /// <summary>
        /// Constant Unavailable for AvailabilityZoneState
        /// </summary>
        public static readonly AvailabilityZoneState Unavailable = new AvailabilityZoneState("unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityZoneState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityZoneState FindValue(string value)
        {
            return FindValue<AvailabilityZoneState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityZoneState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchState.
    /// </summary>
    public class BatchState : ConstantClass
    {

        /// <summary>
        /// Constant Active for BatchState
        /// </summary>
        public static readonly BatchState Active = new BatchState("active");
        /// <summary>
        /// Constant Cancelled for BatchState
        /// </summary>
        public static readonly BatchState Cancelled = new BatchState("cancelled");
        /// <summary>
        /// Constant Cancelled_running for BatchState
        /// </summary>
        public static readonly BatchState Cancelled_running = new BatchState("cancelled_running");
        /// <summary>
        /// Constant Cancelled_terminating for BatchState
        /// </summary>
        public static readonly BatchState Cancelled_terminating = new BatchState("cancelled_terminating");
        /// <summary>
        /// Constant Failed for BatchState
        /// </summary>
        public static readonly BatchState Failed = new BatchState("failed");
        /// <summary>
        /// Constant Modifying for BatchState
        /// </summary>
        public static readonly BatchState Modifying = new BatchState("modifying");
        /// <summary>
        /// Constant Submitted for BatchState
        /// </summary>
        public static readonly BatchState Submitted = new BatchState("submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchState FindValue(string value)
        {
            return FindValue<BatchState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BgpStatus.
    /// </summary>
    public class BgpStatus : ConstantClass
    {

        /// <summary>
        /// Constant Down for BgpStatus
        /// </summary>
        public static readonly BgpStatus Down = new BgpStatus("down");
        /// <summary>
        /// Constant Up for BgpStatus
        /// </summary>
        public static readonly BgpStatus Up = new BgpStatus("up");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BgpStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BgpStatus FindValue(string value)
        {
            return FindValue<BgpStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BgpStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BundleTaskState.
    /// </summary>
    public class BundleTaskState : ConstantClass
    {

        /// <summary>
        /// Constant Bundling for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Bundling = new BundleTaskState("bundling");
        /// <summary>
        /// Constant Cancelling for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Cancelling = new BundleTaskState("cancelling");
        /// <summary>
        /// Constant Complete for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Complete = new BundleTaskState("complete");
        /// <summary>
        /// Constant Failed for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Failed = new BundleTaskState("failed");
        /// <summary>
        /// Constant Pending for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Pending = new BundleTaskState("pending");
        /// <summary>
        /// Constant Storing for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState Storing = new BundleTaskState("storing");
        /// <summary>
        /// Constant WaitingForShutdown for BundleTaskState
        /// </summary>
        public static readonly BundleTaskState WaitingForShutdown = new BundleTaskState("waiting-for-shutdown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BundleTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BundleTaskState FindValue(string value)
        {
            return FindValue<BundleTaskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BundleTaskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ByoipCidrState.
    /// </summary>
    public class ByoipCidrState : ConstantClass
    {

        /// <summary>
        /// Constant Advertised for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState Advertised = new ByoipCidrState("advertised");
        /// <summary>
        /// Constant Deprovisioned for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState Deprovisioned = new ByoipCidrState("deprovisioned");
        /// <summary>
        /// Constant FailedDeprovision for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FailedDeprovision = new ByoipCidrState("failed-deprovision");
        /// <summary>
        /// Constant FailedProvision for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FailedProvision = new ByoipCidrState("failed-provision");
        /// <summary>
        /// Constant PendingDeprovision for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PendingDeprovision = new ByoipCidrState("pending-deprovision");
        /// <summary>
        /// Constant PendingProvision for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PendingProvision = new ByoipCidrState("pending-provision");
        /// <summary>
        /// Constant Provisioned for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState Provisioned = new ByoipCidrState("provisioned");
        /// <summary>
        /// Constant ProvisionedNotPubliclyAdvertisable for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState ProvisionedNotPubliclyAdvertisable = new ByoipCidrState("provisioned-not-publicly-advertisable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ByoipCidrState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ByoipCidrState FindValue(string value)
        {
            return FindValue<ByoipCidrState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ByoipCidrState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancelBatchErrorCode.
    /// </summary>
    public class CancelBatchErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant FleetRequestIdDoesNotExist for CancelBatchErrorCode
        /// </summary>
        public static readonly CancelBatchErrorCode FleetRequestIdDoesNotExist = new CancelBatchErrorCode("fleetRequestIdDoesNotExist");
        /// <summary>
        /// Constant FleetRequestIdMalformed for CancelBatchErrorCode
        /// </summary>
        public static readonly CancelBatchErrorCode FleetRequestIdMalformed = new CancelBatchErrorCode("fleetRequestIdMalformed");
        /// <summary>
        /// Constant FleetRequestNotInCancellableState for CancelBatchErrorCode
        /// </summary>
        public static readonly CancelBatchErrorCode FleetRequestNotInCancellableState = new CancelBatchErrorCode("fleetRequestNotInCancellableState");
        /// <summary>
        /// Constant UnexpectedError for CancelBatchErrorCode
        /// </summary>
        public static readonly CancelBatchErrorCode UnexpectedError = new CancelBatchErrorCode("unexpectedError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancelBatchErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelBatchErrorCode FindValue(string value)
        {
            return FindValue<CancelBatchErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancelBatchErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancelSpotInstanceRequestState.
    /// </summary>
    public class CancelSpotInstanceRequestState : ConstantClass
    {

        /// <summary>
        /// Constant Active for CancelSpotInstanceRequestState
        /// </summary>
        public static readonly CancelSpotInstanceRequestState Active = new CancelSpotInstanceRequestState("active");
        /// <summary>
        /// Constant Cancelled for CancelSpotInstanceRequestState
        /// </summary>
        public static readonly CancelSpotInstanceRequestState Cancelled = new CancelSpotInstanceRequestState("cancelled");
        /// <summary>
        /// Constant Closed for CancelSpotInstanceRequestState
        /// </summary>
        public static readonly CancelSpotInstanceRequestState Closed = new CancelSpotInstanceRequestState("closed");
        /// <summary>
        /// Constant Completed for CancelSpotInstanceRequestState
        /// </summary>
        public static readonly CancelSpotInstanceRequestState Completed = new CancelSpotInstanceRequestState("completed");
        /// <summary>
        /// Constant Open for CancelSpotInstanceRequestState
        /// </summary>
        public static readonly CancelSpotInstanceRequestState Open = new CancelSpotInstanceRequestState("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancelSpotInstanceRequestState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelSpotInstanceRequestState FindValue(string value)
        {
            return FindValue<CancelSpotInstanceRequestState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancelSpotInstanceRequestState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationInstancePlatform.
    /// </summary>
    public class CapacityReservationInstancePlatform : ConstantClass
    {

        /// <summary>
        /// Constant LinuxUNIX for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform LinuxUNIX = new CapacityReservationInstancePlatform("Linux/UNIX");
        /// <summary>
        /// Constant LinuxWithSQLServerEnterprise for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform LinuxWithSQLServerEnterprise = new CapacityReservationInstancePlatform("Linux with SQL Server Enterprise");
        /// <summary>
        /// Constant LinuxWithSQLServerStandard for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform LinuxWithSQLServerStandard = new CapacityReservationInstancePlatform("Linux with SQL Server Standard");
        /// <summary>
        /// Constant LinuxWithSQLServerWeb for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform LinuxWithSQLServerWeb = new CapacityReservationInstancePlatform("Linux with SQL Server Web");
        /// <summary>
        /// Constant RedHatEnterpriseLinux for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform RedHatEnterpriseLinux = new CapacityReservationInstancePlatform("Red Hat Enterprise Linux");
        /// <summary>
        /// Constant SUSELinux for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform SUSELinux = new CapacityReservationInstancePlatform("SUSE Linux");
        /// <summary>
        /// Constant Windows for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform Windows = new CapacityReservationInstancePlatform("Windows");
        /// <summary>
        /// Constant WindowsWithSQLServer for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform WindowsWithSQLServer = new CapacityReservationInstancePlatform("Windows with SQL Server");
        /// <summary>
        /// Constant WindowsWithSQLServerEnterprise for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform WindowsWithSQLServerEnterprise = new CapacityReservationInstancePlatform("Windows with SQL Server Enterprise");
        /// <summary>
        /// Constant WindowsWithSQLServerStandard for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform WindowsWithSQLServerStandard = new CapacityReservationInstancePlatform("Windows with SQL Server Standard");
        /// <summary>
        /// Constant WindowsWithSQLServerWeb for CapacityReservationInstancePlatform
        /// </summary>
        public static readonly CapacityReservationInstancePlatform WindowsWithSQLServerWeb = new CapacityReservationInstancePlatform("Windows with SQL Server Web");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationInstancePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationInstancePlatform FindValue(string value)
        {
            return FindValue<CapacityReservationInstancePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationInstancePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationPreference.
    /// </summary>
    public class CapacityReservationPreference : ConstantClass
    {

        /// <summary>
        /// Constant None for CapacityReservationPreference
        /// </summary>
        public static readonly CapacityReservationPreference None = new CapacityReservationPreference("none");
        /// <summary>
        /// Constant Open for CapacityReservationPreference
        /// </summary>
        public static readonly CapacityReservationPreference Open = new CapacityReservationPreference("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationPreference FindValue(string value)
        {
            return FindValue<CapacityReservationPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationState.
    /// </summary>
    public class CapacityReservationState : ConstantClass
    {

        /// <summary>
        /// Constant Active for CapacityReservationState
        /// </summary>
        public static readonly CapacityReservationState Active = new CapacityReservationState("active");
        /// <summary>
        /// Constant Cancelled for CapacityReservationState
        /// </summary>
        public static readonly CapacityReservationState Cancelled = new CapacityReservationState("cancelled");
        /// <summary>
        /// Constant Expired for CapacityReservationState
        /// </summary>
        public static readonly CapacityReservationState Expired = new CapacityReservationState("expired");
        /// <summary>
        /// Constant Failed for CapacityReservationState
        /// </summary>
        public static readonly CapacityReservationState Failed = new CapacityReservationState("failed");
        /// <summary>
        /// Constant Pending for CapacityReservationState
        /// </summary>
        public static readonly CapacityReservationState Pending = new CapacityReservationState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationState FindValue(string value)
        {
            return FindValue<CapacityReservationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationTenancy.
    /// </summary>
    public class CapacityReservationTenancy : ConstantClass
    {

        /// <summary>
        /// Constant Dedicated for CapacityReservationTenancy
        /// </summary>
        public static readonly CapacityReservationTenancy Dedicated = new CapacityReservationTenancy("dedicated");
        /// <summary>
        /// Constant Default for CapacityReservationTenancy
        /// </summary>
        public static readonly CapacityReservationTenancy Default = new CapacityReservationTenancy("default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationTenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationTenancy FindValue(string value)
        {
            return FindValue<CapacityReservationTenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationTenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CarrierGatewayState.
    /// </summary>
    public class CarrierGatewayState : ConstantClass
    {

        /// <summary>
        /// Constant Available for CarrierGatewayState
        /// </summary>
        public static readonly CarrierGatewayState Available = new CarrierGatewayState("available");
        /// <summary>
        /// Constant Deleted for CarrierGatewayState
        /// </summary>
        public static readonly CarrierGatewayState Deleted = new CarrierGatewayState("deleted");
        /// <summary>
        /// Constant Deleting for CarrierGatewayState
        /// </summary>
        public static readonly CarrierGatewayState Deleting = new CarrierGatewayState("deleting");
        /// <summary>
        /// Constant Pending for CarrierGatewayState
        /// </summary>
        public static readonly CarrierGatewayState Pending = new CarrierGatewayState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CarrierGatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CarrierGatewayState FindValue(string value)
        {
            return FindValue<CarrierGatewayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CarrierGatewayState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientCertificateRevocationListStatusCode.
    /// </summary>
    public class ClientCertificateRevocationListStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ClientCertificateRevocationListStatusCode
        /// </summary>
        public static readonly ClientCertificateRevocationListStatusCode Active = new ClientCertificateRevocationListStatusCode("active");
        /// <summary>
        /// Constant Pending for ClientCertificateRevocationListStatusCode
        /// </summary>
        public static readonly ClientCertificateRevocationListStatusCode Pending = new ClientCertificateRevocationListStatusCode("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientCertificateRevocationListStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientCertificateRevocationListStatusCode FindValue(string value)
        {
            return FindValue<ClientCertificateRevocationListStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientCertificateRevocationListStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnAuthenticationType.
    /// </summary>
    public class ClientVpnAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant CertificateAuthentication for ClientVpnAuthenticationType
        /// </summary>
        public static readonly ClientVpnAuthenticationType CertificateAuthentication = new ClientVpnAuthenticationType("certificate-authentication");
        /// <summary>
        /// Constant DirectoryServiceAuthentication for ClientVpnAuthenticationType
        /// </summary>
        public static readonly ClientVpnAuthenticationType DirectoryServiceAuthentication = new ClientVpnAuthenticationType("directory-service-authentication");
        /// <summary>
        /// Constant FederatedAuthentication for ClientVpnAuthenticationType
        /// </summary>
        public static readonly ClientVpnAuthenticationType FederatedAuthentication = new ClientVpnAuthenticationType("federated-authentication");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnAuthenticationType FindValue(string value)
        {
            return FindValue<ClientVpnAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnAuthorizationRuleStatusCode.
    /// </summary>
    public class ClientVpnAuthorizationRuleStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ClientVpnAuthorizationRuleStatusCode
        /// </summary>
        public static readonly ClientVpnAuthorizationRuleStatusCode Active = new ClientVpnAuthorizationRuleStatusCode("active");
        /// <summary>
        /// Constant Authorizing for ClientVpnAuthorizationRuleStatusCode
        /// </summary>
        public static readonly ClientVpnAuthorizationRuleStatusCode Authorizing = new ClientVpnAuthorizationRuleStatusCode("authorizing");
        /// <summary>
        /// Constant Failed for ClientVpnAuthorizationRuleStatusCode
        /// </summary>
        public static readonly ClientVpnAuthorizationRuleStatusCode Failed = new ClientVpnAuthorizationRuleStatusCode("failed");
        /// <summary>
        /// Constant Revoking for ClientVpnAuthorizationRuleStatusCode
        /// </summary>
        public static readonly ClientVpnAuthorizationRuleStatusCode Revoking = new ClientVpnAuthorizationRuleStatusCode("revoking");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnAuthorizationRuleStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnAuthorizationRuleStatusCode FindValue(string value)
        {
            return FindValue<ClientVpnAuthorizationRuleStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnAuthorizationRuleStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnConnectionStatusCode.
    /// </summary>
    public class ClientVpnConnectionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ClientVpnConnectionStatusCode
        /// </summary>
        public static readonly ClientVpnConnectionStatusCode Active = new ClientVpnConnectionStatusCode("active");
        /// <summary>
        /// Constant FailedToTerminate for ClientVpnConnectionStatusCode
        /// </summary>
        public static readonly ClientVpnConnectionStatusCode FailedToTerminate = new ClientVpnConnectionStatusCode("failed-to-terminate");
        /// <summary>
        /// Constant Terminated for ClientVpnConnectionStatusCode
        /// </summary>
        public static readonly ClientVpnConnectionStatusCode Terminated = new ClientVpnConnectionStatusCode("terminated");
        /// <summary>
        /// Constant Terminating for ClientVpnConnectionStatusCode
        /// </summary>
        public static readonly ClientVpnConnectionStatusCode Terminating = new ClientVpnConnectionStatusCode("terminating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnConnectionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnConnectionStatusCode FindValue(string value)
        {
            return FindValue<ClientVpnConnectionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnConnectionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnEndpointAttributeStatusCode.
    /// </summary>
    public class ClientVpnEndpointAttributeStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Applied for ClientVpnEndpointAttributeStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointAttributeStatusCode Applied = new ClientVpnEndpointAttributeStatusCode("applied");
        /// <summary>
        /// Constant Applying for ClientVpnEndpointAttributeStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointAttributeStatusCode Applying = new ClientVpnEndpointAttributeStatusCode("applying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnEndpointAttributeStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnEndpointAttributeStatusCode FindValue(string value)
        {
            return FindValue<ClientVpnEndpointAttributeStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnEndpointAttributeStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnEndpointStatusCode.
    /// </summary>
    public class ClientVpnEndpointStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Available for ClientVpnEndpointStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointStatusCode Available = new ClientVpnEndpointStatusCode("available");
        /// <summary>
        /// Constant Deleted for ClientVpnEndpointStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointStatusCode Deleted = new ClientVpnEndpointStatusCode("deleted");
        /// <summary>
        /// Constant Deleting for ClientVpnEndpointStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointStatusCode Deleting = new ClientVpnEndpointStatusCode("deleting");
        /// <summary>
        /// Constant PendingAssociate for ClientVpnEndpointStatusCode
        /// </summary>
        public static readonly ClientVpnEndpointStatusCode PendingAssociate = new ClientVpnEndpointStatusCode("pending-associate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnEndpointStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnEndpointStatusCode FindValue(string value)
        {
            return FindValue<ClientVpnEndpointStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnEndpointStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientVpnRouteStatusCode.
    /// </summary>
    public class ClientVpnRouteStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for ClientVpnRouteStatusCode
        /// </summary>
        public static readonly ClientVpnRouteStatusCode Active = new ClientVpnRouteStatusCode("active");
        /// <summary>
        /// Constant Creating for ClientVpnRouteStatusCode
        /// </summary>
        public static readonly ClientVpnRouteStatusCode Creating = new ClientVpnRouteStatusCode("creating");
        /// <summary>
        /// Constant Deleting for ClientVpnRouteStatusCode
        /// </summary>
        public static readonly ClientVpnRouteStatusCode Deleting = new ClientVpnRouteStatusCode("deleting");
        /// <summary>
        /// Constant Failed for ClientVpnRouteStatusCode
        /// </summary>
        public static readonly ClientVpnRouteStatusCode Failed = new ClientVpnRouteStatusCode("failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVpnRouteStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVpnRouteStatusCode FindValue(string value)
        {
            return FindValue<ClientVpnRouteStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVpnRouteStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionNotificationState.
    /// </summary>
    public class ConnectionNotificationState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ConnectionNotificationState
        /// </summary>
        public static readonly ConnectionNotificationState Disabled = new ConnectionNotificationState("Disabled");
        /// <summary>
        /// Constant Enabled for ConnectionNotificationState
        /// </summary>
        public static readonly ConnectionNotificationState Enabled = new ConnectionNotificationState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionNotificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionNotificationState FindValue(string value)
        {
            return FindValue<ConnectionNotificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionNotificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionNotificationType.
    /// </summary>
    public class ConnectionNotificationType : ConstantClass
    {

        /// <summary>
        /// Constant Topic for ConnectionNotificationType
        /// </summary>
        public static readonly ConnectionNotificationType Topic = new ConnectionNotificationType("Topic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionNotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionNotificationType FindValue(string value)
        {
            return FindValue<ConnectionNotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionNotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFormat.
    /// </summary>
    public class ContainerFormat : ConstantClass
    {

        /// <summary>
        /// Constant Ova for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat Ova = new ContainerFormat("ova");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFormat FindValue(string value)
        {
            return FindValue<ContainerFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversionTaskState.
    /// </summary>
    public class ConversionTaskState : ConstantClass
    {

        /// <summary>
        /// Constant Active for ConversionTaskState
        /// </summary>
        public static readonly ConversionTaskState Active = new ConversionTaskState("active");
        /// <summary>
        /// Constant Cancelled for ConversionTaskState
        /// </summary>
        public static readonly ConversionTaskState Cancelled = new ConversionTaskState("cancelled");
        /// <summary>
        /// Constant Cancelling for ConversionTaskState
        /// </summary>
        public static readonly ConversionTaskState Cancelling = new ConversionTaskState("cancelling");
        /// <summary>
        /// Constant Completed for ConversionTaskState
        /// </summary>
        public static readonly ConversionTaskState Completed = new ConversionTaskState("completed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversionTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversionTaskState FindValue(string value)
        {
            return FindValue<ConversionTaskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversionTaskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CopyTagsFromSource.
    /// </summary>
    public class CopyTagsFromSource : ConstantClass
    {

        /// <summary>
        /// Constant Volume for CopyTagsFromSource
        /// </summary>
        public static readonly CopyTagsFromSource Volume = new CopyTagsFromSource("volume");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyTagsFromSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyTagsFromSource FindValue(string value)
        {
            return FindValue<CopyTagsFromSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyTagsFromSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCodeValues.
    /// </summary>
    public class CurrencyCodeValues : ConstantClass
    {

        /// <summary>
        /// Constant USD for CurrencyCodeValues
        /// </summary>
        public static readonly CurrencyCodeValues USD = new CurrencyCodeValues("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCodeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCodeValues FindValue(string value)
        {
            return FindValue<CurrencyCodeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCodeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatafeedSubscriptionState.
    /// </summary>
    public class DatafeedSubscriptionState : ConstantClass
    {

        /// <summary>
        /// Constant Active for DatafeedSubscriptionState
        /// </summary>
        public static readonly DatafeedSubscriptionState Active = new DatafeedSubscriptionState("Active");
        /// <summary>
        /// Constant Inactive for DatafeedSubscriptionState
        /// </summary>
        public static readonly DatafeedSubscriptionState Inactive = new DatafeedSubscriptionState("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatafeedSubscriptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatafeedSubscriptionState FindValue(string value)
        {
            return FindValue<DatafeedSubscriptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatafeedSubscriptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultRouteTableAssociationValue.
    /// </summary>
    public class DefaultRouteTableAssociationValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for DefaultRouteTableAssociationValue
        /// </summary>
        public static readonly DefaultRouteTableAssociationValue Disable = new DefaultRouteTableAssociationValue("disable");
        /// <summary>
        /// Constant Enable for DefaultRouteTableAssociationValue
        /// </summary>
        public static readonly DefaultRouteTableAssociationValue Enable = new DefaultRouteTableAssociationValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultRouteTableAssociationValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultRouteTableAssociationValue FindValue(string value)
        {
            return FindValue<DefaultRouteTableAssociationValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultRouteTableAssociationValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultRouteTablePropagationValue.
    /// </summary>
    public class DefaultRouteTablePropagationValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for DefaultRouteTablePropagationValue
        /// </summary>
        public static readonly DefaultRouteTablePropagationValue Disable = new DefaultRouteTablePropagationValue("disable");
        /// <summary>
        /// Constant Enable for DefaultRouteTablePropagationValue
        /// </summary>
        public static readonly DefaultRouteTablePropagationValue Enable = new DefaultRouteTablePropagationValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultRouteTablePropagationValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultRouteTablePropagationValue FindValue(string value)
        {
            return FindValue<DefaultRouteTablePropagationValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultRouteTablePropagationValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultTargetCapacityType.
    /// </summary>
    public class DefaultTargetCapacityType : ConstantClass
    {

        /// <summary>
        /// Constant OnDemand for DefaultTargetCapacityType
        /// </summary>
        public static readonly DefaultTargetCapacityType OnDemand = new DefaultTargetCapacityType("on-demand");
        /// <summary>
        /// Constant Spot for DefaultTargetCapacityType
        /// </summary>
        public static readonly DefaultTargetCapacityType Spot = new DefaultTargetCapacityType("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultTargetCapacityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultTargetCapacityType FindValue(string value)
        {
            return FindValue<DefaultTargetCapacityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultTargetCapacityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteFleetErrorCode.
    /// </summary>
    public class DeleteFleetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant FleetIdDoesNotExist for DeleteFleetErrorCode
        /// </summary>
        public static readonly DeleteFleetErrorCode FleetIdDoesNotExist = new DeleteFleetErrorCode("fleetIdDoesNotExist");
        /// <summary>
        /// Constant FleetIdMalformed for DeleteFleetErrorCode
        /// </summary>
        public static readonly DeleteFleetErrorCode FleetIdMalformed = new DeleteFleetErrorCode("fleetIdMalformed");
        /// <summary>
        /// Constant FleetNotInDeletableState for DeleteFleetErrorCode
        /// </summary>
        public static readonly DeleteFleetErrorCode FleetNotInDeletableState = new DeleteFleetErrorCode("fleetNotInDeletableState");
        /// <summary>
        /// Constant UnexpectedError for DeleteFleetErrorCode
        /// </summary>
        public static readonly DeleteFleetErrorCode UnexpectedError = new DeleteFleetErrorCode("unexpectedError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteFleetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteFleetErrorCode FindValue(string value)
        {
            return FindValue<DeleteFleetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteFleetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteQueuedReservedInstancesErrorCode.
    /// </summary>
    public class DeleteQueuedReservedInstancesErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ReservedInstancesIdInvalid for DeleteQueuedReservedInstancesErrorCode
        /// </summary>
        public static readonly DeleteQueuedReservedInstancesErrorCode ReservedInstancesIdInvalid = new DeleteQueuedReservedInstancesErrorCode("reserved-instances-id-invalid");
        /// <summary>
        /// Constant ReservedInstancesNotInQueuedState for DeleteQueuedReservedInstancesErrorCode
        /// </summary>
        public static readonly DeleteQueuedReservedInstancesErrorCode ReservedInstancesNotInQueuedState = new DeleteQueuedReservedInstancesErrorCode("reserved-instances-not-in-queued-state");
        /// <summary>
        /// Constant UnexpectedError for DeleteQueuedReservedInstancesErrorCode
        /// </summary>
        public static readonly DeleteQueuedReservedInstancesErrorCode UnexpectedError = new DeleteQueuedReservedInstancesErrorCode("unexpected-error");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteQueuedReservedInstancesErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteQueuedReservedInstancesErrorCode FindValue(string value)
        {
            return FindValue<DeleteQueuedReservedInstancesErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteQueuedReservedInstancesErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceType.
    /// </summary>
    public class DeviceType : ConstantClass
    {

        /// <summary>
        /// Constant Ebs for DeviceType
        /// </summary>
        public static readonly DeviceType Ebs = new DeviceType("ebs");
        /// <summary>
        /// Constant InstanceStore for DeviceType
        /// </summary>
        public static readonly DeviceType InstanceStore = new DeviceType("instance-store");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskImageFormat.
    /// </summary>
    public class DiskImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant RAW for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat RAW = new DiskImageFormat("RAW");
        /// <summary>
        /// Constant VHD for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat VHD = new DiskImageFormat("VHD");
        /// <summary>
        /// Constant VMDK for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat VMDK = new DiskImageFormat("VMDK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskImageFormat FindValue(string value)
        {
            return FindValue<DiskImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskType.
    /// </summary>
    public class DiskType : ConstantClass
    {

        /// <summary>
        /// Constant Hdd for DiskType
        /// </summary>
        public static readonly DiskType Hdd = new DiskType("hdd");
        /// <summary>
        /// Constant Ssd for DiskType
        /// </summary>
        public static readonly DiskType Ssd = new DiskType("ssd");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskType FindValue(string value)
        {
            return FindValue<DiskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsNameState.
    /// </summary>
    public class DnsNameState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for DnsNameState
        /// </summary>
        public static readonly DnsNameState Failed = new DnsNameState("failed");
        /// <summary>
        /// Constant PendingVerification for DnsNameState
        /// </summary>
        public static readonly DnsNameState PendingVerification = new DnsNameState("pendingVerification");
        /// <summary>
        /// Constant Verified for DnsNameState
        /// </summary>
        public static readonly DnsNameState Verified = new DnsNameState("verified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsNameState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsNameState FindValue(string value)
        {
            return FindValue<DnsNameState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsNameState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsSupportValue.
    /// </summary>
    public class DnsSupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for DnsSupportValue
        /// </summary>
        public static readonly DnsSupportValue Disable = new DnsSupportValue("disable");
        /// <summary>
        /// Constant Enable for DnsSupportValue
        /// </summary>
        public static readonly DnsSupportValue Enable = new DnsSupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsSupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsSupportValue FindValue(string value)
        {
            return FindValue<DnsSupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsSupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainType.
    /// </summary>
    public class DomainType : ConstantClass
    {

        /// <summary>
        /// Constant Standard for DomainType
        /// </summary>
        public static readonly DomainType Standard = new DomainType("standard");
        /// <summary>
        /// Constant Vpc for DomainType
        /// </summary>
        public static readonly DomainType Vpc = new DomainType("vpc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainType FindValue(string value)
        {
            return FindValue<DomainType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbsEncryptionSupport.
    /// </summary>
    public class EbsEncryptionSupport : ConstantClass
    {

        /// <summary>
        /// Constant Supported for EbsEncryptionSupport
        /// </summary>
        public static readonly EbsEncryptionSupport Supported = new EbsEncryptionSupport("supported");
        /// <summary>
        /// Constant Unsupported for EbsEncryptionSupport
        /// </summary>
        public static readonly EbsEncryptionSupport Unsupported = new EbsEncryptionSupport("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbsEncryptionSupport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbsEncryptionSupport FindValue(string value)
        {
            return FindValue<EbsEncryptionSupport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbsEncryptionSupport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbsNvmeSupport.
    /// </summary>
    public class EbsNvmeSupport : ConstantClass
    {

        /// <summary>
        /// Constant Required for EbsNvmeSupport
        /// </summary>
        public static readonly EbsNvmeSupport Required = new EbsNvmeSupport("required");
        /// <summary>
        /// Constant Supported for EbsNvmeSupport
        /// </summary>
        public static readonly EbsNvmeSupport Supported = new EbsNvmeSupport("supported");
        /// <summary>
        /// Constant Unsupported for EbsNvmeSupport
        /// </summary>
        public static readonly EbsNvmeSupport Unsupported = new EbsNvmeSupport("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbsNvmeSupport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbsNvmeSupport FindValue(string value)
        {
            return FindValue<EbsNvmeSupport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbsNvmeSupport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbsOptimizedSupport.
    /// </summary>
    public class EbsOptimizedSupport : ConstantClass
    {

        /// <summary>
        /// Constant Default for EbsOptimizedSupport
        /// </summary>
        public static readonly EbsOptimizedSupport Default = new EbsOptimizedSupport("default");
        /// <summary>
        /// Constant Supported for EbsOptimizedSupport
        /// </summary>
        public static readonly EbsOptimizedSupport Supported = new EbsOptimizedSupport("supported");
        /// <summary>
        /// Constant Unsupported for EbsOptimizedSupport
        /// </summary>
        public static readonly EbsOptimizedSupport Unsupported = new EbsOptimizedSupport("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbsOptimizedSupport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbsOptimizedSupport FindValue(string value)
        {
            return FindValue<EbsOptimizedSupport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbsOptimizedSupport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElasticGpuState.
    /// </summary>
    public class ElasticGpuState : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHED for ElasticGpuState
        /// </summary>
        public static readonly ElasticGpuState ATTACHED = new ElasticGpuState("ATTACHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElasticGpuState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElasticGpuState FindValue(string value)
        {
            return FindValue<ElasticGpuState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElasticGpuState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElasticGpuStatus.
    /// </summary>
    public class ElasticGpuStatus : ConstantClass
    {

        /// <summary>
        /// Constant IMPAIRED for ElasticGpuStatus
        /// </summary>
        public static readonly ElasticGpuStatus IMPAIRED = new ElasticGpuStatus("IMPAIRED");
        /// <summary>
        /// Constant OK for ElasticGpuStatus
        /// </summary>
        public static readonly ElasticGpuStatus OK = new ElasticGpuStatus("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElasticGpuStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElasticGpuStatus FindValue(string value)
        {
            return FindValue<ElasticGpuStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElasticGpuStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnaSupport.
    /// </summary>
    public class EnaSupport : ConstantClass
    {

        /// <summary>
        /// Constant Required for EnaSupport
        /// </summary>
        public static readonly EnaSupport Required = new EnaSupport("required");
        /// <summary>
        /// Constant Supported for EnaSupport
        /// </summary>
        public static readonly EnaSupport Supported = new EnaSupport("supported");
        /// <summary>
        /// Constant Unsupported for EnaSupport
        /// </summary>
        public static readonly EnaSupport Unsupported = new EnaSupport("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnaSupport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnaSupport FindValue(string value)
        {
            return FindValue<EnaSupport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnaSupport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndDateType.
    /// </summary>
    public class EndDateType : ConstantClass
    {

        /// <summary>
        /// Constant Limited for EndDateType
        /// </summary>
        public static readonly EndDateType Limited = new EndDateType("limited");
        /// <summary>
        /// Constant Unlimited for EndDateType
        /// </summary>
        public static readonly EndDateType Unlimited = new EndDateType("unlimited");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndDateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndDateType FindValue(string value)
        {
            return FindValue<EndDateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndDateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EphemeralNvmeSupport.
    /// </summary>
    public class EphemeralNvmeSupport : ConstantClass
    {

        /// <summary>
        /// Constant Required for EphemeralNvmeSupport
        /// </summary>
        public static readonly EphemeralNvmeSupport Required = new EphemeralNvmeSupport("required");
        /// <summary>
        /// Constant Supported for EphemeralNvmeSupport
        /// </summary>
        public static readonly EphemeralNvmeSupport Supported = new EphemeralNvmeSupport("supported");
        /// <summary>
        /// Constant Unsupported for EphemeralNvmeSupport
        /// </summary>
        public static readonly EphemeralNvmeSupport Unsupported = new EphemeralNvmeSupport("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EphemeralNvmeSupport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EphemeralNvmeSupport FindValue(string value)
        {
            return FindValue<EphemeralNvmeSupport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EphemeralNvmeSupport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventCode.
    /// </summary>
    public class EventCode : ConstantClass
    {

        /// <summary>
        /// Constant InstanceReboot for EventCode
        /// </summary>
        public static readonly EventCode InstanceReboot = new EventCode("instance-reboot");
        /// <summary>
        /// Constant InstanceRetirement for EventCode
        /// </summary>
        public static readonly EventCode InstanceRetirement = new EventCode("instance-retirement");
        /// <summary>
        /// Constant InstanceStop for EventCode
        /// </summary>
        public static readonly EventCode InstanceStop = new EventCode("instance-stop");
        /// <summary>
        /// Constant SystemMaintenance for EventCode
        /// </summary>
        public static readonly EventCode SystemMaintenance = new EventCode("system-maintenance");
        /// <summary>
        /// Constant SystemReboot for EventCode
        /// </summary>
        public static readonly EventCode SystemReboot = new EventCode("system-reboot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCode FindValue(string value)
        {
            return FindValue<EventCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant Error for EventType
        /// </summary>
        public static readonly EventType Error = new EventType("error");
        /// <summary>
        /// Constant FleetRequestChange for EventType
        /// </summary>
        public static readonly EventType FleetRequestChange = new EventType("fleetRequestChange");
        /// <summary>
        /// Constant Information for EventType
        /// </summary>
        public static readonly EventType Information = new EventType("information");
        /// <summary>
        /// Constant InstanceChange for EventType
        /// </summary>
        public static readonly EventType InstanceChange = new EventType("instanceChange");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExcessCapacityTerminationPolicy.
    /// </summary>
    public class ExcessCapacityTerminationPolicy : ConstantClass
    {

        /// <summary>
        /// Constant Default for ExcessCapacityTerminationPolicy
        /// </summary>
        public static readonly ExcessCapacityTerminationPolicy Default = new ExcessCapacityTerminationPolicy("default");
        /// <summary>
        /// Constant NoTermination for ExcessCapacityTerminationPolicy
        /// </summary>
        public static readonly ExcessCapacityTerminationPolicy NoTermination = new ExcessCapacityTerminationPolicy("noTermination");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExcessCapacityTerminationPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExcessCapacityTerminationPolicy FindValue(string value)
        {
            return FindValue<ExcessCapacityTerminationPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExcessCapacityTerminationPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportEnvironment.
    /// </summary>
    public class ExportEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant Citrix for ExportEnvironment
        /// </summary>
        public static readonly ExportEnvironment Citrix = new ExportEnvironment("citrix");
        /// <summary>
        /// Constant Microsoft for ExportEnvironment
        /// </summary>
        public static readonly ExportEnvironment Microsoft = new ExportEnvironment("microsoft");
        /// <summary>
        /// Constant Vmware for ExportEnvironment
        /// </summary>
        public static readonly ExportEnvironment Vmware = new ExportEnvironment("vmware");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportEnvironment FindValue(string value)
        {
            return FindValue<ExportEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportTaskState.
    /// </summary>
    public class ExportTaskState : ConstantClass
    {

        /// <summary>
        /// Constant Active for ExportTaskState
        /// </summary>
        public static readonly ExportTaskState Active = new ExportTaskState("active");
        /// <summary>
        /// Constant Cancelled for ExportTaskState
        /// </summary>
        public static readonly ExportTaskState Cancelled = new ExportTaskState("cancelled");
        /// <summary>
        /// Constant Cancelling for ExportTaskState
        /// </summary>
        public static readonly ExportTaskState Cancelling = new ExportTaskState("cancelling");
        /// <summary>
        /// Constant Completed for ExportTaskState
        /// </summary>
        public static readonly ExportTaskState Completed = new ExportTaskState("completed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportTaskState FindValue(string value)
        {
            return FindValue<ExportTaskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportTaskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FastSnapshotRestoreStateCode.
    /// </summary>
    public class FastSnapshotRestoreStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for FastSnapshotRestoreStateCode
        /// </summary>
        public static readonly FastSnapshotRestoreStateCode Disabled = new FastSnapshotRestoreStateCode("disabled");
        /// <summary>
        /// Constant Disabling for FastSnapshotRestoreStateCode
        /// </summary>
        public static readonly FastSnapshotRestoreStateCode Disabling = new FastSnapshotRestoreStateCode("disabling");
        /// <summary>
        /// Constant Enabled for FastSnapshotRestoreStateCode
        /// </summary>
        public static readonly FastSnapshotRestoreStateCode Enabled = new FastSnapshotRestoreStateCode("enabled");
        /// <summary>
        /// Constant Enabling for FastSnapshotRestoreStateCode
        /// </summary>
        public static readonly FastSnapshotRestoreStateCode Enabling = new FastSnapshotRestoreStateCode("enabling");
        /// <summary>
        /// Constant Optimizing for FastSnapshotRestoreStateCode
        /// </summary>
        public static readonly FastSnapshotRestoreStateCode Optimizing = new FastSnapshotRestoreStateCode("optimizing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FastSnapshotRestoreStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FastSnapshotRestoreStateCode FindValue(string value)
        {
            return FindValue<FastSnapshotRestoreStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FastSnapshotRestoreStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetActivityStatus.
    /// </summary>
    public class FleetActivityStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for FleetActivityStatus
        /// </summary>
        public static readonly FleetActivityStatus Error = new FleetActivityStatus("error");
        /// <summary>
        /// Constant Fulfilled for FleetActivityStatus
        /// </summary>
        public static readonly FleetActivityStatus Fulfilled = new FleetActivityStatus("fulfilled");
        /// <summary>
        /// Constant Pending_fulfillment for FleetActivityStatus
        /// </summary>
        public static readonly FleetActivityStatus Pending_fulfillment = new FleetActivityStatus("pending_fulfillment");
        /// <summary>
        /// Constant Pending_termination for FleetActivityStatus
        /// </summary>
        public static readonly FleetActivityStatus Pending_termination = new FleetActivityStatus("pending_termination");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetActivityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetActivityStatus FindValue(string value)
        {
            return FindValue<FleetActivityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetActivityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetCapacityReservationUsageStrategy.
    /// </summary>
    public class FleetCapacityReservationUsageStrategy : ConstantClass
    {

        /// <summary>
        /// Constant UseCapacityReservationsFirst for FleetCapacityReservationUsageStrategy
        /// </summary>
        public static readonly FleetCapacityReservationUsageStrategy UseCapacityReservationsFirst = new FleetCapacityReservationUsageStrategy("use-capacity-reservations-first");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetCapacityReservationUsageStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetCapacityReservationUsageStrategy FindValue(string value)
        {
            return FindValue<FleetCapacityReservationUsageStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetCapacityReservationUsageStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetEventType.
    /// </summary>
    public class FleetEventType : ConstantClass
    {

        /// <summary>
        /// Constant FleetChange for FleetEventType
        /// </summary>
        public static readonly FleetEventType FleetChange = new FleetEventType("fleet-change");
        /// <summary>
        /// Constant InstanceChange for FleetEventType
        /// </summary>
        public static readonly FleetEventType InstanceChange = new FleetEventType("instance-change");
        /// <summary>
        /// Constant ServiceError for FleetEventType
        /// </summary>
        public static readonly FleetEventType ServiceError = new FleetEventType("service-error");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetEventType FindValue(string value)
        {
            return FindValue<FleetEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetExcessCapacityTerminationPolicy.
    /// </summary>
    public class FleetExcessCapacityTerminationPolicy : ConstantClass
    {

        /// <summary>
        /// Constant NoTermination for FleetExcessCapacityTerminationPolicy
        /// </summary>
        public static readonly FleetExcessCapacityTerminationPolicy NoTermination = new FleetExcessCapacityTerminationPolicy("no-termination");
        /// <summary>
        /// Constant Termination for FleetExcessCapacityTerminationPolicy
        /// </summary>
        public static readonly FleetExcessCapacityTerminationPolicy Termination = new FleetExcessCapacityTerminationPolicy("termination");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetExcessCapacityTerminationPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetExcessCapacityTerminationPolicy FindValue(string value)
        {
            return FindValue<FleetExcessCapacityTerminationPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetExcessCapacityTerminationPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetOnDemandAllocationStrategy.
    /// </summary>
    public class FleetOnDemandAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LowestPrice for FleetOnDemandAllocationStrategy
        /// </summary>
        public static readonly FleetOnDemandAllocationStrategy LowestPrice = new FleetOnDemandAllocationStrategy("lowest-price");
        /// <summary>
        /// Constant Prioritized for FleetOnDemandAllocationStrategy
        /// </summary>
        public static readonly FleetOnDemandAllocationStrategy Prioritized = new FleetOnDemandAllocationStrategy("prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetOnDemandAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetOnDemandAllocationStrategy FindValue(string value)
        {
            return FindValue<FleetOnDemandAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetOnDemandAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetReplacementStrategy.
    /// </summary>
    public class FleetReplacementStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Launch for FleetReplacementStrategy
        /// </summary>
        public static readonly FleetReplacementStrategy Launch = new FleetReplacementStrategy("launch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetReplacementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetReplacementStrategy FindValue(string value)
        {
            return FindValue<FleetReplacementStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetReplacementStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStateCode.
    /// </summary>
    public class FleetStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Active = new FleetStateCode("active");
        /// <summary>
        /// Constant Deleted for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Deleted = new FleetStateCode("deleted");
        /// <summary>
        /// Constant Deleted_running for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Deleted_running = new FleetStateCode("deleted_running");
        /// <summary>
        /// Constant Deleted_terminating for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Deleted_terminating = new FleetStateCode("deleted_terminating");
        /// <summary>
        /// Constant Failed for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Failed = new FleetStateCode("failed");
        /// <summary>
        /// Constant Modifying for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Modifying = new FleetStateCode("modifying");
        /// <summary>
        /// Constant Submitted for FleetStateCode
        /// </summary>
        public static readonly FleetStateCode Submitted = new FleetStateCode("submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStateCode FindValue(string value)
        {
            return FindValue<FleetStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetType.
    /// </summary>
    public class FleetType : ConstantClass
    {

        /// <summary>
        /// Constant Instant for FleetType
        /// </summary>
        public static readonly FleetType Instant = new FleetType("instant");
        /// <summary>
        /// Constant Maintain for FleetType
        /// </summary>
        public static readonly FleetType Maintain = new FleetType("maintain");
        /// <summary>
        /// Constant Request for FleetType
        /// </summary>
        public static readonly FleetType Request = new FleetType("request");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetType FindValue(string value)
        {
            return FindValue<FleetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowLogsResourceType.
    /// </summary>
    public class FlowLogsResourceType : ConstantClass
    {

        /// <summary>
        /// Constant NetworkInterface for FlowLogsResourceType
        /// </summary>
        public static readonly FlowLogsResourceType NetworkInterface = new FlowLogsResourceType("NetworkInterface");
        /// <summary>
        /// Constant Subnet for FlowLogsResourceType
        /// </summary>
        public static readonly FlowLogsResourceType Subnet = new FlowLogsResourceType("Subnet");
        /// <summary>
        /// Constant VPC for FlowLogsResourceType
        /// </summary>
        public static readonly FlowLogsResourceType VPC = new FlowLogsResourceType("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowLogsResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowLogsResourceType FindValue(string value)
        {
            return FindValue<FlowLogsResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowLogsResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FpgaImageAttributeName.
    /// </summary>
    public class FpgaImageAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant Description for FpgaImageAttributeName
        /// </summary>
        public static readonly FpgaImageAttributeName Description = new FpgaImageAttributeName("description");
        /// <summary>
        /// Constant LoadPermission for FpgaImageAttributeName
        /// </summary>
        public static readonly FpgaImageAttributeName LoadPermission = new FpgaImageAttributeName("loadPermission");
        /// <summary>
        /// Constant Name for FpgaImageAttributeName
        /// </summary>
        public static readonly FpgaImageAttributeName Name = new FpgaImageAttributeName("name");
        /// <summary>
        /// Constant ProductCodes for FpgaImageAttributeName
        /// </summary>
        public static readonly FpgaImageAttributeName ProductCodes = new FpgaImageAttributeName("productCodes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FpgaImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FpgaImageAttributeName FindValue(string value)
        {
            return FindValue<FpgaImageAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FpgaImageAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FpgaImageStateCode.
    /// </summary>
    public class FpgaImageStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Available for FpgaImageStateCode
        /// </summary>
        public static readonly FpgaImageStateCode Available = new FpgaImageStateCode("available");
        /// <summary>
        /// Constant Failed for FpgaImageStateCode
        /// </summary>
        public static readonly FpgaImageStateCode Failed = new FpgaImageStateCode("failed");
        /// <summary>
        /// Constant Pending for FpgaImageStateCode
        /// </summary>
        public static readonly FpgaImageStateCode Pending = new FpgaImageStateCode("pending");
        /// <summary>
        /// Constant Unavailable for FpgaImageStateCode
        /// </summary>
        public static readonly FpgaImageStateCode Unavailable = new FpgaImageStateCode("unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FpgaImageStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FpgaImageStateCode FindValue(string value)
        {
            return FindValue<FpgaImageStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FpgaImageStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayType.
    /// </summary>
    public class GatewayType : ConstantClass
    {

        /// <summary>
        /// Constant Ipsec1 for GatewayType
        /// </summary>
        public static readonly GatewayType Ipsec1 = new GatewayType("ipsec.1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayType FindValue(string value)
        {
            return FindValue<GatewayType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostRecovery.
    /// </summary>
    public class HostRecovery : ConstantClass
    {

        /// <summary>
        /// Constant Off for HostRecovery
        /// </summary>
        public static readonly HostRecovery Off = new HostRecovery("off");
        /// <summary>
        /// Constant On for HostRecovery
        /// </summary>
        public static readonly HostRecovery On = new HostRecovery("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostRecovery(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostRecovery FindValue(string value)
        {
            return FindValue<HostRecovery>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostRecovery(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostTenancy.
    /// </summary>
    public class HostTenancy : ConstantClass
    {

        /// <summary>
        /// Constant Dedicated for HostTenancy
        /// </summary>
        public static readonly HostTenancy Dedicated = new HostTenancy("dedicated");
        /// <summary>
        /// Constant Host for HostTenancy
        /// </summary>
        public static readonly HostTenancy Host = new HostTenancy("host");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostTenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostTenancy FindValue(string value)
        {
            return FindValue<HostTenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostTenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpTokensState.
    /// </summary>
    public class HttpTokensState : ConstantClass
    {

        /// <summary>
        /// Constant Optional for HttpTokensState
        /// </summary>
        public static readonly HttpTokensState Optional = new HttpTokensState("optional");
        /// <summary>
        /// Constant Required for HttpTokensState
        /// </summary>
        public static readonly HttpTokensState Required = new HttpTokensState("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpTokensState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpTokensState FindValue(string value)
        {
            return FindValue<HttpTokensState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpTokensState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HypervisorType.
    /// </summary>
    public class HypervisorType : ConstantClass
    {

        /// <summary>
        /// Constant Ovm for HypervisorType
        /// </summary>
        public static readonly HypervisorType Ovm = new HypervisorType("ovm");
        /// <summary>
        /// Constant Xen for HypervisorType
        /// </summary>
        public static readonly HypervisorType Xen = new HypervisorType("xen");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HypervisorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HypervisorType FindValue(string value)
        {
            return FindValue<HypervisorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HypervisorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IamInstanceProfileAssociationState.
    /// </summary>
    public class IamInstanceProfileAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant Associated for IamInstanceProfileAssociationState
        /// </summary>
        public static readonly IamInstanceProfileAssociationState Associated = new IamInstanceProfileAssociationState("associated");
        /// <summary>
        /// Constant Associating for IamInstanceProfileAssociationState
        /// </summary>
        public static readonly IamInstanceProfileAssociationState Associating = new IamInstanceProfileAssociationState("associating");
        /// <summary>
        /// Constant Disassociated for IamInstanceProfileAssociationState
        /// </summary>
        public static readonly IamInstanceProfileAssociationState Disassociated = new IamInstanceProfileAssociationState("disassociated");
        /// <summary>
        /// Constant Disassociating for IamInstanceProfileAssociationState
        /// </summary>
        public static readonly IamInstanceProfileAssociationState Disassociating = new IamInstanceProfileAssociationState("disassociating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IamInstanceProfileAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamInstanceProfileAssociationState FindValue(string value)
        {
            return FindValue<IamInstanceProfileAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamInstanceProfileAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Igmpv2SupportValue.
    /// </summary>
    public class Igmpv2SupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for Igmpv2SupportValue
        /// </summary>
        public static readonly Igmpv2SupportValue Disable = new Igmpv2SupportValue("disable");
        /// <summary>
        /// Constant Enable for Igmpv2SupportValue
        /// </summary>
        public static readonly Igmpv2SupportValue Enable = new Igmpv2SupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Igmpv2SupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Igmpv2SupportValue FindValue(string value)
        {
            return FindValue<Igmpv2SupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Igmpv2SupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageAttributeName.
    /// </summary>
    public class ImageAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant BlockDeviceMapping for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName BlockDeviceMapping = new ImageAttributeName("blockDeviceMapping");
        /// <summary>
        /// Constant Description for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName Description = new ImageAttributeName("description");
        /// <summary>
        /// Constant Kernel for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName Kernel = new ImageAttributeName("kernel");
        /// <summary>
        /// Constant LaunchPermission for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName LaunchPermission = new ImageAttributeName("launchPermission");
        /// <summary>
        /// Constant ProductCodes for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName ProductCodes = new ImageAttributeName("productCodes");
        /// <summary>
        /// Constant Ramdisk for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName Ramdisk = new ImageAttributeName("ramdisk");
        /// <summary>
        /// Constant SriovNetSupport for ImageAttributeName
        /// </summary>
        public static readonly ImageAttributeName SriovNetSupport = new ImageAttributeName("sriovNetSupport");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageAttributeName FindValue(string value)
        {
            return FindValue<ImageAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageState.
    /// </summary>
    public class ImageState : ConstantClass
    {

        /// <summary>
        /// Constant Available for ImageState
        /// </summary>
        public static readonly ImageState Available = new ImageState("available");
        /// <summary>
        /// Constant Deregistered for ImageState
        /// </summary>
        public static readonly ImageState Deregistered = new ImageState("deregistered");
        /// <summary>
        /// Constant Error for ImageState
        /// </summary>
        public static readonly ImageState Error = new ImageState("error");
        /// <summary>
        /// Constant Failed for ImageState
        /// </summary>
        public static readonly ImageState Failed = new ImageState("failed");
        /// <summary>
        /// Constant Invalid for ImageState
        /// </summary>
        public static readonly ImageState Invalid = new ImageState("invalid");
        /// <summary>
        /// Constant Pending for ImageState
        /// </summary>
        public static readonly ImageState Pending = new ImageState("pending");
        /// <summary>
        /// Constant Transient for ImageState
        /// </summary>
        public static readonly ImageState Transient = new ImageState("transient");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageState FindValue(string value)
        {
            return FindValue<ImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageTypeValues.
    /// </summary>
    public class ImageTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant Kernel for ImageTypeValues
        /// </summary>
        public static readonly ImageTypeValues Kernel = new ImageTypeValues("kernel");
        /// <summary>
        /// Constant Machine for ImageTypeValues
        /// </summary>
        public static readonly ImageTypeValues Machine = new ImageTypeValues("machine");
        /// <summary>
        /// Constant Ramdisk for ImageTypeValues
        /// </summary>
        public static readonly ImageTypeValues Ramdisk = new ImageTypeValues("ramdisk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageTypeValues FindValue(string value)
        {
            return FindValue<ImageTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAttributeName.
    /// </summary>
    public class InstanceAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant BlockDeviceMapping for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName BlockDeviceMapping = new InstanceAttributeName("blockDeviceMapping");
        /// <summary>
        /// Constant DisableApiTermination for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName DisableApiTermination = new InstanceAttributeName("disableApiTermination");
        /// <summary>
        /// Constant EbsOptimized for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName EbsOptimized = new InstanceAttributeName("ebsOptimized");
        /// <summary>
        /// Constant EnaSupport for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName EnaSupport = new InstanceAttributeName("enaSupport");
        /// <summary>
        /// Constant EnclaveOptions for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName EnclaveOptions = new InstanceAttributeName("enclaveOptions");
        /// <summary>
        /// Constant GroupSet for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName GroupSet = new InstanceAttributeName("groupSet");
        /// <summary>
        /// Constant InstanceInitiatedShutdownBehavior for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName InstanceInitiatedShutdownBehavior = new InstanceAttributeName("instanceInitiatedShutdownBehavior");
        /// <summary>
        /// Constant InstanceType for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName InstanceType = new InstanceAttributeName("instanceType");
        /// <summary>
        /// Constant Kernel for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName Kernel = new InstanceAttributeName("kernel");
        /// <summary>
        /// Constant ProductCodes for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName ProductCodes = new InstanceAttributeName("productCodes");
        /// <summary>
        /// Constant Ramdisk for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName Ramdisk = new InstanceAttributeName("ramdisk");
        /// <summary>
        /// Constant RootDeviceName for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName RootDeviceName = new InstanceAttributeName("rootDeviceName");
        /// <summary>
        /// Constant SourceDestCheck for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName SourceDestCheck = new InstanceAttributeName("sourceDestCheck");
        /// <summary>
        /// Constant SriovNetSupport for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName SriovNetSupport = new InstanceAttributeName("sriovNetSupport");
        /// <summary>
        /// Constant UserData for InstanceAttributeName
        /// </summary>
        public static readonly InstanceAttributeName UserData = new InstanceAttributeName("userData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAttributeName FindValue(string value)
        {
            return FindValue<InstanceAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthStatus.
    /// </summary>
    public class InstanceHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant Healthy for InstanceHealthStatus
        /// </summary>
        public static readonly InstanceHealthStatus Healthy = new InstanceHealthStatus("healthy");
        /// <summary>
        /// Constant Unhealthy for InstanceHealthStatus
        /// </summary>
        public static readonly InstanceHealthStatus Unhealthy = new InstanceHealthStatus("unhealthy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthStatus FindValue(string value)
        {
            return FindValue<InstanceHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceInterruptionBehavior.
    /// </summary>
    public class InstanceInterruptionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Hibernate for InstanceInterruptionBehavior
        /// </summary>
        public static readonly InstanceInterruptionBehavior Hibernate = new InstanceInterruptionBehavior("hibernate");
        /// <summary>
        /// Constant Stop for InstanceInterruptionBehavior
        /// </summary>
        public static readonly InstanceInterruptionBehavior Stop = new InstanceInterruptionBehavior("stop");
        /// <summary>
        /// Constant Terminate for InstanceInterruptionBehavior
        /// </summary>
        public static readonly InstanceInterruptionBehavior Terminate = new InstanceInterruptionBehavior("terminate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceInterruptionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceInterruptionBehavior FindValue(string value)
        {
            return FindValue<InstanceInterruptionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceInterruptionBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceLifecycle.
    /// </summary>
    public class InstanceLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant OnDemand for InstanceLifecycle
        /// </summary>
        public static readonly InstanceLifecycle OnDemand = new InstanceLifecycle("on-demand");
        /// <summary>
        /// Constant Spot for InstanceLifecycle
        /// </summary>
        public static readonly InstanceLifecycle Spot = new InstanceLifecycle("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceLifecycle FindValue(string value)
        {
            return FindValue<InstanceLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceLifecycleType.
    /// </summary>
    public class InstanceLifecycleType : ConstantClass
    {

        /// <summary>
        /// Constant Scheduled for InstanceLifecycleType
        /// </summary>
        public static readonly InstanceLifecycleType Scheduled = new InstanceLifecycleType("scheduled");
        /// <summary>
        /// Constant Spot for InstanceLifecycleType
        /// </summary>
        public static readonly InstanceLifecycleType Spot = new InstanceLifecycleType("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceLifecycleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceLifecycleType FindValue(string value)
        {
            return FindValue<InstanceLifecycleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceLifecycleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMatchCriteria.
    /// </summary>
    public class InstanceMatchCriteria : ConstantClass
    {

        /// <summary>
        /// Constant Open for InstanceMatchCriteria
        /// </summary>
        public static readonly InstanceMatchCriteria Open = new InstanceMatchCriteria("open");
        /// <summary>
        /// Constant Targeted for InstanceMatchCriteria
        /// </summary>
        public static readonly InstanceMatchCriteria Targeted = new InstanceMatchCriteria("targeted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMatchCriteria(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMatchCriteria FindValue(string value)
        {
            return FindValue<InstanceMatchCriteria>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMatchCriteria(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetadataEndpointState.
    /// </summary>
    public class InstanceMetadataEndpointState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for InstanceMetadataEndpointState
        /// </summary>
        public static readonly InstanceMetadataEndpointState Disabled = new InstanceMetadataEndpointState("disabled");
        /// <summary>
        /// Constant Enabled for InstanceMetadataEndpointState
        /// </summary>
        public static readonly InstanceMetadataEndpointState Enabled = new InstanceMetadataEndpointState("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetadataEndpointState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetadataEndpointState FindValue(string value)
        {
            return FindValue<InstanceMetadataEndpointState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetadataEndpointState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetadataOptionsState.
    /// </summary>
    public class InstanceMetadataOptionsState : ConstantClass
    {

        /// <summary>
        /// Constant Applied for InstanceMetadataOptionsState
        /// </summary>
        public static readonly InstanceMetadataOptionsState Applied = new InstanceMetadataOptionsState("applied");
        /// <summary>
        /// Constant Pending for InstanceMetadataOptionsState
        /// </summary>
        public static readonly InstanceMetadataOptionsState Pending = new InstanceMetadataOptionsState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetadataOptionsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetadataOptionsState FindValue(string value)
        {
            return FindValue<InstanceMetadataOptionsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetadataOptionsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStateName.
    /// </summary>
    public class InstanceStateName : ConstantClass
    {

        /// <summary>
        /// Constant Pending for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName Pending = new InstanceStateName("pending");
        /// <summary>
        /// Constant Running for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName Running = new InstanceStateName("running");
        /// <summary>
        /// Constant ShuttingDown for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName ShuttingDown = new InstanceStateName("shutting-down");
        /// <summary>
        /// Constant Stopped for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName Stopped = new InstanceStateName("stopped");
        /// <summary>
        /// Constant Stopping for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName Stopping = new InstanceStateName("stopping");
        /// <summary>
        /// Constant Terminated for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName Terminated = new InstanceStateName("terminated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStateName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStateName FindValue(string value)
        {
            return FindValue<InstanceStateName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStateName(string value)
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
        /// Constant A12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType A12xlarge = new InstanceType("a1.2xlarge");
        /// <summary>
        /// Constant A14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType A14xlarge = new InstanceType("a1.4xlarge");
        /// <summary>
        /// Constant A1Large for InstanceType
        /// </summary>
        public static readonly InstanceType A1Large = new InstanceType("a1.large");
        /// <summary>
        /// Constant A1Medium for InstanceType
        /// </summary>
        public static readonly InstanceType A1Medium = new InstanceType("a1.medium");
        /// <summary>
        /// Constant A1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType A1Metal = new InstanceType("a1.metal");
        /// <summary>
        /// Constant A1Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType A1Xlarge = new InstanceType("a1.xlarge");
        /// <summary>
        /// Constant C1Medium for InstanceType
        /// </summary>
        public static readonly InstanceType C1Medium = new InstanceType("c1.medium");
        /// <summary>
        /// Constant C1Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C1Xlarge = new InstanceType("c1.xlarge");
        /// <summary>
        /// Constant C32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C32xlarge = new InstanceType("c3.2xlarge");
        /// <summary>
        /// Constant C34xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C34xlarge = new InstanceType("c3.4xlarge");
        /// <summary>
        /// Constant C38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C38xlarge = new InstanceType("c3.8xlarge");
        /// <summary>
        /// Constant C3Large for InstanceType
        /// </summary>
        public static readonly InstanceType C3Large = new InstanceType("c3.large");
        /// <summary>
        /// Constant C3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C3Xlarge = new InstanceType("c3.xlarge");
        /// <summary>
        /// Constant C42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C42xlarge = new InstanceType("c4.2xlarge");
        /// <summary>
        /// Constant C44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C44xlarge = new InstanceType("c4.4xlarge");
        /// <summary>
        /// Constant C48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C48xlarge = new InstanceType("c4.8xlarge");
        /// <summary>
        /// Constant C4Large for InstanceType
        /// </summary>
        public static readonly InstanceType C4Large = new InstanceType("c4.large");
        /// <summary>
        /// Constant C4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C4Xlarge = new InstanceType("c4.xlarge");
        /// <summary>
        /// Constant C512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C512xlarge = new InstanceType("c5.12xlarge");
        /// <summary>
        /// Constant C518xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C518xlarge = new InstanceType("c5.18xlarge");
        /// <summary>
        /// Constant C524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C524xlarge = new InstanceType("c5.24xlarge");
        /// <summary>
        /// Constant C52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C52xlarge = new InstanceType("c5.2xlarge");
        /// <summary>
        /// Constant C54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C54xlarge = new InstanceType("c5.4xlarge");
        /// <summary>
        /// Constant C59xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C59xlarge = new InstanceType("c5.9xlarge");
        /// <summary>
        /// Constant C5a12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a12xlarge = new InstanceType("c5a.12xlarge");
        /// <summary>
        /// Constant C5a16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a16xlarge = new InstanceType("c5a.16xlarge");
        /// <summary>
        /// Constant C5a24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a24xlarge = new InstanceType("c5a.24xlarge");
        /// <summary>
        /// Constant C5a2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a2xlarge = new InstanceType("c5a.2xlarge");
        /// <summary>
        /// Constant C5a4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a4xlarge = new InstanceType("c5a.4xlarge");
        /// <summary>
        /// Constant C5a8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5a8xlarge = new InstanceType("c5a.8xlarge");
        /// <summary>
        /// Constant C5ad12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad12xlarge = new InstanceType("c5ad.12xlarge");
        /// <summary>
        /// Constant C5ad16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad16xlarge = new InstanceType("c5ad.16xlarge");
        /// <summary>
        /// Constant C5ad24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad24xlarge = new InstanceType("c5ad.24xlarge");
        /// <summary>
        /// Constant C5ad2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad2xlarge = new InstanceType("c5ad.2xlarge");
        /// <summary>
        /// Constant C5ad4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad4xlarge = new InstanceType("c5ad.4xlarge");
        /// <summary>
        /// Constant C5ad8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5ad8xlarge = new InstanceType("c5ad.8xlarge");
        /// <summary>
        /// Constant C5adLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5adLarge = new InstanceType("c5ad.large");
        /// <summary>
        /// Constant C5adXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5adXlarge = new InstanceType("c5ad.xlarge");
        /// <summary>
        /// Constant C5aLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5aLarge = new InstanceType("c5a.large");
        /// <summary>
        /// Constant C5aXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5aXlarge = new InstanceType("c5a.xlarge");
        /// <summary>
        /// Constant C5d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d12xlarge = new InstanceType("c5d.12xlarge");
        /// <summary>
        /// Constant C5d18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d18xlarge = new InstanceType("c5d.18xlarge");
        /// <summary>
        /// Constant C5d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d24xlarge = new InstanceType("c5d.24xlarge");
        /// <summary>
        /// Constant C5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d2xlarge = new InstanceType("c5d.2xlarge");
        /// <summary>
        /// Constant C5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d4xlarge = new InstanceType("c5d.4xlarge");
        /// <summary>
        /// Constant C5d9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5d9xlarge = new InstanceType("c5d.9xlarge");
        /// <summary>
        /// Constant C5dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5dLarge = new InstanceType("c5d.large");
        /// <summary>
        /// Constant C5dMetal for InstanceType
        /// </summary>
        public static readonly InstanceType C5dMetal = new InstanceType("c5d.metal");
        /// <summary>
        /// Constant C5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5dXlarge = new InstanceType("c5d.xlarge");
        /// <summary>
        /// Constant C5Large for InstanceType
        /// </summary>
        public static readonly InstanceType C5Large = new InstanceType("c5.large");
        /// <summary>
        /// Constant C5Metal for InstanceType
        /// </summary>
        public static readonly InstanceType C5Metal = new InstanceType("c5.metal");
        /// <summary>
        /// Constant C5n18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5n18xlarge = new InstanceType("c5n.18xlarge");
        /// <summary>
        /// Constant C5n2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5n2xlarge = new InstanceType("c5n.2xlarge");
        /// <summary>
        /// Constant C5n4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5n4xlarge = new InstanceType("c5n.4xlarge");
        /// <summary>
        /// Constant C5n9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5n9xlarge = new InstanceType("c5n.9xlarge");
        /// <summary>
        /// Constant C5nLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5nLarge = new InstanceType("c5n.large");
        /// <summary>
        /// Constant C5nMetal for InstanceType
        /// </summary>
        public static readonly InstanceType C5nMetal = new InstanceType("c5n.metal");
        /// <summary>
        /// Constant C5nXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5nXlarge = new InstanceType("c5n.xlarge");
        /// <summary>
        /// Constant C5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C5Xlarge = new InstanceType("c5.xlarge");
        /// <summary>
        /// Constant C6g12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6g12xlarge = new InstanceType("c6g.12xlarge");
        /// <summary>
        /// Constant C6g16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6g16xlarge = new InstanceType("c6g.16xlarge");
        /// <summary>
        /// Constant C6g2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6g2xlarge = new InstanceType("c6g.2xlarge");
        /// <summary>
        /// Constant C6g4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6g4xlarge = new InstanceType("c6g.4xlarge");
        /// <summary>
        /// Constant C6g8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6g8xlarge = new InstanceType("c6g.8xlarge");
        /// <summary>
        /// Constant C6gd12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gd12xlarge = new InstanceType("c6gd.12xlarge");
        /// <summary>
        /// Constant C6gd16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gd16xlarge = new InstanceType("c6gd.16xlarge");
        /// <summary>
        /// Constant C6gd2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gd2xlarge = new InstanceType("c6gd.2xlarge");
        /// <summary>
        /// Constant C6gd4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gd4xlarge = new InstanceType("c6gd.4xlarge");
        /// <summary>
        /// Constant C6gd8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gd8xlarge = new InstanceType("c6gd.8xlarge");
        /// <summary>
        /// Constant C6gdLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gdLarge = new InstanceType("c6gd.large");
        /// <summary>
        /// Constant C6gdMedium for InstanceType
        /// </summary>
        public static readonly InstanceType C6gdMedium = new InstanceType("c6gd.medium");
        /// <summary>
        /// Constant C6gdMetal for InstanceType
        /// </summary>
        public static readonly InstanceType C6gdMetal = new InstanceType("c6gd.metal");
        /// <summary>
        /// Constant C6gdXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gdXlarge = new InstanceType("c6gd.xlarge");
        /// <summary>
        /// Constant C6gLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gLarge = new InstanceType("c6g.large");
        /// <summary>
        /// Constant C6gMedium for InstanceType
        /// </summary>
        public static readonly InstanceType C6gMedium = new InstanceType("c6g.medium");
        /// <summary>
        /// Constant C6gMetal for InstanceType
        /// </summary>
        public static readonly InstanceType C6gMetal = new InstanceType("c6g.metal");
        /// <summary>
        /// Constant C6gn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gn12xlarge = new InstanceType("c6gn.12xlarge");
        /// <summary>
        /// Constant C6gn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gn16xlarge = new InstanceType("c6gn.16xlarge");
        /// <summary>
        /// Constant C6gn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gn2xlarge = new InstanceType("c6gn.2xlarge");
        /// <summary>
        /// Constant C6gn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gn4xlarge = new InstanceType("c6gn.4xlarge");
        /// <summary>
        /// Constant C6gn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gn8xlarge = new InstanceType("c6gn.8xlarge");
        /// <summary>
        /// Constant C6gnLarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gnLarge = new InstanceType("c6gn.large");
        /// <summary>
        /// Constant C6gnMedium for InstanceType
        /// </summary>
        public static readonly InstanceType C6gnMedium = new InstanceType("c6gn.medium");
        /// <summary>
        /// Constant C6gnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gnXlarge = new InstanceType("c6gn.xlarge");
        /// <summary>
        /// Constant C6gXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType C6gXlarge = new InstanceType("c6g.xlarge");
        /// <summary>
        /// Constant Cc14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Cc14xlarge = new InstanceType("cc1.4xlarge");
        /// <summary>
        /// Constant Cc28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Cc28xlarge = new InstanceType("cc2.8xlarge");
        /// <summary>
        /// Constant Cg14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Cg14xlarge = new InstanceType("cg1.4xlarge");
        /// <summary>
        /// Constant Cr18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Cr18xlarge = new InstanceType("cr1.8xlarge");
        /// <summary>
        /// Constant D22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D22xlarge = new InstanceType("d2.2xlarge");
        /// <summary>
        /// Constant D24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D24xlarge = new InstanceType("d2.4xlarge");
        /// <summary>
        /// Constant D28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D28xlarge = new InstanceType("d2.8xlarge");
        /// <summary>
        /// Constant D2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D2Xlarge = new InstanceType("d2.xlarge");
        /// <summary>
        /// Constant D32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D32xlarge = new InstanceType("d3.2xlarge");
        /// <summary>
        /// Constant D34xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D34xlarge = new InstanceType("d3.4xlarge");
        /// <summary>
        /// Constant D38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D38xlarge = new InstanceType("d3.8xlarge");
        /// <summary>
        /// Constant D3en12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3en12xlarge = new InstanceType("d3en.12xlarge");
        /// <summary>
        /// Constant D3en2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3en2xlarge = new InstanceType("d3en.2xlarge");
        /// <summary>
        /// Constant D3en4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3en4xlarge = new InstanceType("d3en.4xlarge");
        /// <summary>
        /// Constant D3en6xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3en6xlarge = new InstanceType("d3en.6xlarge");
        /// <summary>
        /// Constant D3en8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3en8xlarge = new InstanceType("d3en.8xlarge");
        /// <summary>
        /// Constant D3enXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3enXlarge = new InstanceType("d3en.xlarge");
        /// <summary>
        /// Constant D3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType D3Xlarge = new InstanceType("d3.xlarge");
        /// <summary>
        /// Constant F116xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType F116xlarge = new InstanceType("f1.16xlarge");
        /// <summary>
        /// Constant F12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType F12xlarge = new InstanceType("f1.2xlarge");
        /// <summary>
        /// Constant F14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType F14xlarge = new InstanceType("f1.4xlarge");
        /// <summary>
        /// Constant G22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G22xlarge = new InstanceType("g2.2xlarge");
        /// <summary>
        /// Constant G28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G28xlarge = new InstanceType("g2.8xlarge");
        /// <summary>
        /// Constant G316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G316xlarge = new InstanceType("g3.16xlarge");
        /// <summary>
        /// Constant G34xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G34xlarge = new InstanceType("g3.4xlarge");
        /// <summary>
        /// Constant G38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G38xlarge = new InstanceType("g3.8xlarge");
        /// <summary>
        /// Constant G3sXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G3sXlarge = new InstanceType("g3s.xlarge");
        /// <summary>
        /// Constant G4ad16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4ad16xlarge = new InstanceType("g4ad.16xlarge");
        /// <summary>
        /// Constant G4ad4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4ad4xlarge = new InstanceType("g4ad.4xlarge");
        /// <summary>
        /// Constant G4ad8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4ad8xlarge = new InstanceType("g4ad.8xlarge");
        /// <summary>
        /// Constant G4dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dn12xlarge = new InstanceType("g4dn.12xlarge");
        /// <summary>
        /// Constant G4dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dn16xlarge = new InstanceType("g4dn.16xlarge");
        /// <summary>
        /// Constant G4dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dn2xlarge = new InstanceType("g4dn.2xlarge");
        /// <summary>
        /// Constant G4dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dn4xlarge = new InstanceType("g4dn.4xlarge");
        /// <summary>
        /// Constant G4dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dn8xlarge = new InstanceType("g4dn.8xlarge");
        /// <summary>
        /// Constant G4dnMetal for InstanceType
        /// </summary>
        public static readonly InstanceType G4dnMetal = new InstanceType("g4dn.metal");
        /// <summary>
        /// Constant G4dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType G4dnXlarge = new InstanceType("g4dn.xlarge");
        /// <summary>
        /// Constant H116xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType H116xlarge = new InstanceType("h1.16xlarge");
        /// <summary>
        /// Constant H12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType H12xlarge = new InstanceType("h1.2xlarge");
        /// <summary>
        /// Constant H14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType H14xlarge = new InstanceType("h1.4xlarge");
        /// <summary>
        /// Constant H18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType H18xlarge = new InstanceType("h1.8xlarge");
        /// <summary>
        /// Constant Hi14xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Hi14xlarge = new InstanceType("hi1.4xlarge");
        /// <summary>
        /// Constant Hs18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Hs18xlarge = new InstanceType("hs1.8xlarge");
        /// <summary>
        /// Constant I22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I22xlarge = new InstanceType("i2.2xlarge");
        /// <summary>
        /// Constant I24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I24xlarge = new InstanceType("i2.4xlarge");
        /// <summary>
        /// Constant I28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I28xlarge = new InstanceType("i2.8xlarge");
        /// <summary>
        /// Constant I2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I2Xlarge = new InstanceType("i2.xlarge");
        /// <summary>
        /// Constant I316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I316xlarge = new InstanceType("i3.16xlarge");
        /// <summary>
        /// Constant I32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I32xlarge = new InstanceType("i3.2xlarge");
        /// <summary>
        /// Constant I34xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I34xlarge = new InstanceType("i3.4xlarge");
        /// <summary>
        /// Constant I38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I38xlarge = new InstanceType("i3.8xlarge");
        /// <summary>
        /// Constant I3en12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3en12xlarge = new InstanceType("i3en.12xlarge");
        /// <summary>
        /// Constant I3en24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3en24xlarge = new InstanceType("i3en.24xlarge");
        /// <summary>
        /// Constant I3en2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3en2xlarge = new InstanceType("i3en.2xlarge");
        /// <summary>
        /// Constant I3en3xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3en3xlarge = new InstanceType("i3en.3xlarge");
        /// <summary>
        /// Constant I3en6xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3en6xlarge = new InstanceType("i3en.6xlarge");
        /// <summary>
        /// Constant I3enLarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3enLarge = new InstanceType("i3en.large");
        /// <summary>
        /// Constant I3enMetal for InstanceType
        /// </summary>
        public static readonly InstanceType I3enMetal = new InstanceType("i3en.metal");
        /// <summary>
        /// Constant I3enXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3enXlarge = new InstanceType("i3en.xlarge");
        /// <summary>
        /// Constant I3Large for InstanceType
        /// </summary>
        public static readonly InstanceType I3Large = new InstanceType("i3.large");
        /// <summary>
        /// Constant I3Metal for InstanceType
        /// </summary>
        public static readonly InstanceType I3Metal = new InstanceType("i3.metal");
        /// <summary>
        /// Constant I3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType I3Xlarge = new InstanceType("i3.xlarge");
        /// <summary>
        /// Constant Inf124xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Inf124xlarge = new InstanceType("inf1.24xlarge");
        /// <summary>
        /// Constant Inf12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Inf12xlarge = new InstanceType("inf1.2xlarge");
        /// <summary>
        /// Constant Inf16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Inf16xlarge = new InstanceType("inf1.6xlarge");
        /// <summary>
        /// Constant Inf1Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Inf1Xlarge = new InstanceType("inf1.xlarge");
        /// <summary>
        /// Constant M1Large for InstanceType
        /// </summary>
        public static readonly InstanceType M1Large = new InstanceType("m1.large");
        /// <summary>
        /// Constant M1Medium for InstanceType
        /// </summary>
        public static readonly InstanceType M1Medium = new InstanceType("m1.medium");
        /// <summary>
        /// Constant M1Small for InstanceType
        /// </summary>
        public static readonly InstanceType M1Small = new InstanceType("m1.small");
        /// <summary>
        /// Constant M1Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M1Xlarge = new InstanceType("m1.xlarge");
        /// <summary>
        /// Constant M22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M22xlarge = new InstanceType("m2.2xlarge");
        /// <summary>
        /// Constant M24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M24xlarge = new InstanceType("m2.4xlarge");
        /// <summary>
        /// Constant M2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M2Xlarge = new InstanceType("m2.xlarge");
        /// <summary>
        /// Constant M32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M32xlarge = new InstanceType("m3.2xlarge");
        /// <summary>
        /// Constant M3Large for InstanceType
        /// </summary>
        public static readonly InstanceType M3Large = new InstanceType("m3.large");
        /// <summary>
        /// Constant M3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType M3Medium = new InstanceType("m3.medium");
        /// <summary>
        /// Constant M3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M3Xlarge = new InstanceType("m3.xlarge");
        /// <summary>
        /// Constant M410xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M410xlarge = new InstanceType("m4.10xlarge");
        /// <summary>
        /// Constant M416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M416xlarge = new InstanceType("m4.16xlarge");
        /// <summary>
        /// Constant M42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M42xlarge = new InstanceType("m4.2xlarge");
        /// <summary>
        /// Constant M44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M44xlarge = new InstanceType("m4.4xlarge");
        /// <summary>
        /// Constant M4Large for InstanceType
        /// </summary>
        public static readonly InstanceType M4Large = new InstanceType("m4.large");
        /// <summary>
        /// Constant M4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M4Xlarge = new InstanceType("m4.xlarge");
        /// <summary>
        /// Constant M512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M512xlarge = new InstanceType("m5.12xlarge");
        /// <summary>
        /// Constant M516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M516xlarge = new InstanceType("m5.16xlarge");
        /// <summary>
        /// Constant M524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M524xlarge = new InstanceType("m5.24xlarge");
        /// <summary>
        /// Constant M52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M52xlarge = new InstanceType("m5.2xlarge");
        /// <summary>
        /// Constant M54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M54xlarge = new InstanceType("m5.4xlarge");
        /// <summary>
        /// Constant M58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M58xlarge = new InstanceType("m5.8xlarge");
        /// <summary>
        /// Constant M5a12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a12xlarge = new InstanceType("m5a.12xlarge");
        /// <summary>
        /// Constant M5a16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a16xlarge = new InstanceType("m5a.16xlarge");
        /// <summary>
        /// Constant M5a24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a24xlarge = new InstanceType("m5a.24xlarge");
        /// <summary>
        /// Constant M5a2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a2xlarge = new InstanceType("m5a.2xlarge");
        /// <summary>
        /// Constant M5a4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a4xlarge = new InstanceType("m5a.4xlarge");
        /// <summary>
        /// Constant M5a8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5a8xlarge = new InstanceType("m5a.8xlarge");
        /// <summary>
        /// Constant M5ad12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad12xlarge = new InstanceType("m5ad.12xlarge");
        /// <summary>
        /// Constant M5ad16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad16xlarge = new InstanceType("m5ad.16xlarge");
        /// <summary>
        /// Constant M5ad24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad24xlarge = new InstanceType("m5ad.24xlarge");
        /// <summary>
        /// Constant M5ad2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad2xlarge = new InstanceType("m5ad.2xlarge");
        /// <summary>
        /// Constant M5ad4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad4xlarge = new InstanceType("m5ad.4xlarge");
        /// <summary>
        /// Constant M5ad8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5ad8xlarge = new InstanceType("m5ad.8xlarge");
        /// <summary>
        /// Constant M5adLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5adLarge = new InstanceType("m5ad.large");
        /// <summary>
        /// Constant M5adXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5adXlarge = new InstanceType("m5ad.xlarge");
        /// <summary>
        /// Constant M5aLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5aLarge = new InstanceType("m5a.large");
        /// <summary>
        /// Constant M5aXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5aXlarge = new InstanceType("m5a.xlarge");
        /// <summary>
        /// Constant M5d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d12xlarge = new InstanceType("m5d.12xlarge");
        /// <summary>
        /// Constant M5d16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d16xlarge = new InstanceType("m5d.16xlarge");
        /// <summary>
        /// Constant M5d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d24xlarge = new InstanceType("m5d.24xlarge");
        /// <summary>
        /// Constant M5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d2xlarge = new InstanceType("m5d.2xlarge");
        /// <summary>
        /// Constant M5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d4xlarge = new InstanceType("m5d.4xlarge");
        /// <summary>
        /// Constant M5d8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5d8xlarge = new InstanceType("m5d.8xlarge");
        /// <summary>
        /// Constant M5dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dLarge = new InstanceType("m5d.large");
        /// <summary>
        /// Constant M5dMetal for InstanceType
        /// </summary>
        public static readonly InstanceType M5dMetal = new InstanceType("m5d.metal");
        /// <summary>
        /// Constant M5dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn12xlarge = new InstanceType("m5dn.12xlarge");
        /// <summary>
        /// Constant M5dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn16xlarge = new InstanceType("m5dn.16xlarge");
        /// <summary>
        /// Constant M5dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn24xlarge = new InstanceType("m5dn.24xlarge");
        /// <summary>
        /// Constant M5dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn2xlarge = new InstanceType("m5dn.2xlarge");
        /// <summary>
        /// Constant M5dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn4xlarge = new InstanceType("m5dn.4xlarge");
        /// <summary>
        /// Constant M5dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dn8xlarge = new InstanceType("m5dn.8xlarge");
        /// <summary>
        /// Constant M5dnLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dnLarge = new InstanceType("m5dn.large");
        /// <summary>
        /// Constant M5dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dnXlarge = new InstanceType("m5dn.xlarge");
        /// <summary>
        /// Constant M5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5dXlarge = new InstanceType("m5d.xlarge");
        /// <summary>
        /// Constant M5Large for InstanceType
        /// </summary>
        public static readonly InstanceType M5Large = new InstanceType("m5.large");
        /// <summary>
        /// Constant M5Metal for InstanceType
        /// </summary>
        public static readonly InstanceType M5Metal = new InstanceType("m5.metal");
        /// <summary>
        /// Constant M5n12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n12xlarge = new InstanceType("m5n.12xlarge");
        /// <summary>
        /// Constant M5n16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n16xlarge = new InstanceType("m5n.16xlarge");
        /// <summary>
        /// Constant M5n24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n24xlarge = new InstanceType("m5n.24xlarge");
        /// <summary>
        /// Constant M5n2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n2xlarge = new InstanceType("m5n.2xlarge");
        /// <summary>
        /// Constant M5n4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n4xlarge = new InstanceType("m5n.4xlarge");
        /// <summary>
        /// Constant M5n8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5n8xlarge = new InstanceType("m5n.8xlarge");
        /// <summary>
        /// Constant M5nLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5nLarge = new InstanceType("m5n.large");
        /// <summary>
        /// Constant M5nXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5nXlarge = new InstanceType("m5n.xlarge");
        /// <summary>
        /// Constant M5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5Xlarge = new InstanceType("m5.xlarge");
        /// <summary>
        /// Constant M5zn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5zn12xlarge = new InstanceType("m5zn.12xlarge");
        /// <summary>
        /// Constant M5zn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5zn2xlarge = new InstanceType("m5zn.2xlarge");
        /// <summary>
        /// Constant M5zn3xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5zn3xlarge = new InstanceType("m5zn.3xlarge");
        /// <summary>
        /// Constant M5zn6xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5zn6xlarge = new InstanceType("m5zn.6xlarge");
        /// <summary>
        /// Constant M5znLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5znLarge = new InstanceType("m5zn.large");
        /// <summary>
        /// Constant M5znMetal for InstanceType
        /// </summary>
        public static readonly InstanceType M5znMetal = new InstanceType("m5zn.metal");
        /// <summary>
        /// Constant M5znXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M5znXlarge = new InstanceType("m5zn.xlarge");
        /// <summary>
        /// Constant M6g12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6g12xlarge = new InstanceType("m6g.12xlarge");
        /// <summary>
        /// Constant M6g16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6g16xlarge = new InstanceType("m6g.16xlarge");
        /// <summary>
        /// Constant M6g2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6g2xlarge = new InstanceType("m6g.2xlarge");
        /// <summary>
        /// Constant M6g4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6g4xlarge = new InstanceType("m6g.4xlarge");
        /// <summary>
        /// Constant M6g8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6g8xlarge = new InstanceType("m6g.8xlarge");
        /// <summary>
        /// Constant M6gd12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gd12xlarge = new InstanceType("m6gd.12xlarge");
        /// <summary>
        /// Constant M6gd16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gd16xlarge = new InstanceType("m6gd.16xlarge");
        /// <summary>
        /// Constant M6gd2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gd2xlarge = new InstanceType("m6gd.2xlarge");
        /// <summary>
        /// Constant M6gd4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gd4xlarge = new InstanceType("m6gd.4xlarge");
        /// <summary>
        /// Constant M6gd8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gd8xlarge = new InstanceType("m6gd.8xlarge");
        /// <summary>
        /// Constant M6gdLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gdLarge = new InstanceType("m6gd.large");
        /// <summary>
        /// Constant M6gdMedium for InstanceType
        /// </summary>
        public static readonly InstanceType M6gdMedium = new InstanceType("m6gd.medium");
        /// <summary>
        /// Constant M6gdMetal for InstanceType
        /// </summary>
        public static readonly InstanceType M6gdMetal = new InstanceType("m6gd.metal");
        /// <summary>
        /// Constant M6gdXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gdXlarge = new InstanceType("m6gd.xlarge");
        /// <summary>
        /// Constant M6gLarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gLarge = new InstanceType("m6g.large");
        /// <summary>
        /// Constant M6gMedium for InstanceType
        /// </summary>
        public static readonly InstanceType M6gMedium = new InstanceType("m6g.medium");
        /// <summary>
        /// Constant M6gMetal for InstanceType
        /// </summary>
        public static readonly InstanceType M6gMetal = new InstanceType("m6g.metal");
        /// <summary>
        /// Constant M6gXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType M6gXlarge = new InstanceType("m6g.xlarge");
        /// <summary>
        /// Constant Mac1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType Mac1Metal = new InstanceType("mac1.metal");
        /// <summary>
        /// Constant P216xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P216xlarge = new InstanceType("p2.16xlarge");
        /// <summary>
        /// Constant P28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P28xlarge = new InstanceType("p2.8xlarge");
        /// <summary>
        /// Constant P2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P2Xlarge = new InstanceType("p2.xlarge");
        /// <summary>
        /// Constant P316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P316xlarge = new InstanceType("p3.16xlarge");
        /// <summary>
        /// Constant P32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P32xlarge = new InstanceType("p3.2xlarge");
        /// <summary>
        /// Constant P38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P38xlarge = new InstanceType("p3.8xlarge");
        /// <summary>
        /// Constant P3dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P3dn24xlarge = new InstanceType("p3dn.24xlarge");
        /// <summary>
        /// Constant P4d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType P4d24xlarge = new InstanceType("p4d.24xlarge");
        /// <summary>
        /// Constant R32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R32xlarge = new InstanceType("r3.2xlarge");
        /// <summary>
        /// Constant R34xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R34xlarge = new InstanceType("r3.4xlarge");
        /// <summary>
        /// Constant R38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R38xlarge = new InstanceType("r3.8xlarge");
        /// <summary>
        /// Constant R3Large for InstanceType
        /// </summary>
        public static readonly InstanceType R3Large = new InstanceType("r3.large");
        /// <summary>
        /// Constant R3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R3Xlarge = new InstanceType("r3.xlarge");
        /// <summary>
        /// Constant R416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R416xlarge = new InstanceType("r4.16xlarge");
        /// <summary>
        /// Constant R42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R42xlarge = new InstanceType("r4.2xlarge");
        /// <summary>
        /// Constant R44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R44xlarge = new InstanceType("r4.4xlarge");
        /// <summary>
        /// Constant R48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R48xlarge = new InstanceType("r4.8xlarge");
        /// <summary>
        /// Constant R4Large for InstanceType
        /// </summary>
        public static readonly InstanceType R4Large = new InstanceType("r4.large");
        /// <summary>
        /// Constant R4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R4Xlarge = new InstanceType("r4.xlarge");
        /// <summary>
        /// Constant R512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R512xlarge = new InstanceType("r5.12xlarge");
        /// <summary>
        /// Constant R516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R516xlarge = new InstanceType("r5.16xlarge");
        /// <summary>
        /// Constant R524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R524xlarge = new InstanceType("r5.24xlarge");
        /// <summary>
        /// Constant R52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R52xlarge = new InstanceType("r5.2xlarge");
        /// <summary>
        /// Constant R54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R54xlarge = new InstanceType("r5.4xlarge");
        /// <summary>
        /// Constant R58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R58xlarge = new InstanceType("r5.8xlarge");
        /// <summary>
        /// Constant R5a12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a12xlarge = new InstanceType("r5a.12xlarge");
        /// <summary>
        /// Constant R5a16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a16xlarge = new InstanceType("r5a.16xlarge");
        /// <summary>
        /// Constant R5a24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a24xlarge = new InstanceType("r5a.24xlarge");
        /// <summary>
        /// Constant R5a2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a2xlarge = new InstanceType("r5a.2xlarge");
        /// <summary>
        /// Constant R5a4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a4xlarge = new InstanceType("r5a.4xlarge");
        /// <summary>
        /// Constant R5a8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5a8xlarge = new InstanceType("r5a.8xlarge");
        /// <summary>
        /// Constant R5ad12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad12xlarge = new InstanceType("r5ad.12xlarge");
        /// <summary>
        /// Constant R5ad16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad16xlarge = new InstanceType("r5ad.16xlarge");
        /// <summary>
        /// Constant R5ad24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad24xlarge = new InstanceType("r5ad.24xlarge");
        /// <summary>
        /// Constant R5ad2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad2xlarge = new InstanceType("r5ad.2xlarge");
        /// <summary>
        /// Constant R5ad4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad4xlarge = new InstanceType("r5ad.4xlarge");
        /// <summary>
        /// Constant R5ad8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5ad8xlarge = new InstanceType("r5ad.8xlarge");
        /// <summary>
        /// Constant R5adLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5adLarge = new InstanceType("r5ad.large");
        /// <summary>
        /// Constant R5adXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5adXlarge = new InstanceType("r5ad.xlarge");
        /// <summary>
        /// Constant R5aLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5aLarge = new InstanceType("r5a.large");
        /// <summary>
        /// Constant R5aXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5aXlarge = new InstanceType("r5a.xlarge");
        /// <summary>
        /// Constant R5b12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b12xlarge = new InstanceType("r5b.12xlarge");
        /// <summary>
        /// Constant R5b16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b16xlarge = new InstanceType("r5b.16xlarge");
        /// <summary>
        /// Constant R5b24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b24xlarge = new InstanceType("r5b.24xlarge");
        /// <summary>
        /// Constant R5b2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b2xlarge = new InstanceType("r5b.2xlarge");
        /// <summary>
        /// Constant R5b4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b4xlarge = new InstanceType("r5b.4xlarge");
        /// <summary>
        /// Constant R5b8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5b8xlarge = new InstanceType("r5b.8xlarge");
        /// <summary>
        /// Constant R5bLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5bLarge = new InstanceType("r5b.large");
        /// <summary>
        /// Constant R5bMetal for InstanceType
        /// </summary>
        public static readonly InstanceType R5bMetal = new InstanceType("r5b.metal");
        /// <summary>
        /// Constant R5bXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5bXlarge = new InstanceType("r5b.xlarge");
        /// <summary>
        /// Constant R5d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d12xlarge = new InstanceType("r5d.12xlarge");
        /// <summary>
        /// Constant R5d16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d16xlarge = new InstanceType("r5d.16xlarge");
        /// <summary>
        /// Constant R5d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d24xlarge = new InstanceType("r5d.24xlarge");
        /// <summary>
        /// Constant R5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d2xlarge = new InstanceType("r5d.2xlarge");
        /// <summary>
        /// Constant R5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d4xlarge = new InstanceType("r5d.4xlarge");
        /// <summary>
        /// Constant R5d8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5d8xlarge = new InstanceType("r5d.8xlarge");
        /// <summary>
        /// Constant R5dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dLarge = new InstanceType("r5d.large");
        /// <summary>
        /// Constant R5dMetal for InstanceType
        /// </summary>
        public static readonly InstanceType R5dMetal = new InstanceType("r5d.metal");
        /// <summary>
        /// Constant R5dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn12xlarge = new InstanceType("r5dn.12xlarge");
        /// <summary>
        /// Constant R5dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn16xlarge = new InstanceType("r5dn.16xlarge");
        /// <summary>
        /// Constant R5dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn24xlarge = new InstanceType("r5dn.24xlarge");
        /// <summary>
        /// Constant R5dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn2xlarge = new InstanceType("r5dn.2xlarge");
        /// <summary>
        /// Constant R5dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn4xlarge = new InstanceType("r5dn.4xlarge");
        /// <summary>
        /// Constant R5dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dn8xlarge = new InstanceType("r5dn.8xlarge");
        /// <summary>
        /// Constant R5dnLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dnLarge = new InstanceType("r5dn.large");
        /// <summary>
        /// Constant R5dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dnXlarge = new InstanceType("r5dn.xlarge");
        /// <summary>
        /// Constant R5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5dXlarge = new InstanceType("r5d.xlarge");
        /// <summary>
        /// Constant R5Large for InstanceType
        /// </summary>
        public static readonly InstanceType R5Large = new InstanceType("r5.large");
        /// <summary>
        /// Constant R5Metal for InstanceType
        /// </summary>
        public static readonly InstanceType R5Metal = new InstanceType("r5.metal");
        /// <summary>
        /// Constant R5n12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n12xlarge = new InstanceType("r5n.12xlarge");
        /// <summary>
        /// Constant R5n16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n16xlarge = new InstanceType("r5n.16xlarge");
        /// <summary>
        /// Constant R5n24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n24xlarge = new InstanceType("r5n.24xlarge");
        /// <summary>
        /// Constant R5n2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n2xlarge = new InstanceType("r5n.2xlarge");
        /// <summary>
        /// Constant R5n4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n4xlarge = new InstanceType("r5n.4xlarge");
        /// <summary>
        /// Constant R5n8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5n8xlarge = new InstanceType("r5n.8xlarge");
        /// <summary>
        /// Constant R5nLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5nLarge = new InstanceType("r5n.large");
        /// <summary>
        /// Constant R5nXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5nXlarge = new InstanceType("r5n.xlarge");
        /// <summary>
        /// Constant R5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R5Xlarge = new InstanceType("r5.xlarge");
        /// <summary>
        /// Constant R6g12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6g12xlarge = new InstanceType("r6g.12xlarge");
        /// <summary>
        /// Constant R6g16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6g16xlarge = new InstanceType("r6g.16xlarge");
        /// <summary>
        /// Constant R6g2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6g2xlarge = new InstanceType("r6g.2xlarge");
        /// <summary>
        /// Constant R6g4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6g4xlarge = new InstanceType("r6g.4xlarge");
        /// <summary>
        /// Constant R6g8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6g8xlarge = new InstanceType("r6g.8xlarge");
        /// <summary>
        /// Constant R6gd12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gd12xlarge = new InstanceType("r6gd.12xlarge");
        /// <summary>
        /// Constant R6gd16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gd16xlarge = new InstanceType("r6gd.16xlarge");
        /// <summary>
        /// Constant R6gd2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gd2xlarge = new InstanceType("r6gd.2xlarge");
        /// <summary>
        /// Constant R6gd4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gd4xlarge = new InstanceType("r6gd.4xlarge");
        /// <summary>
        /// Constant R6gd8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gd8xlarge = new InstanceType("r6gd.8xlarge");
        /// <summary>
        /// Constant R6gdLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gdLarge = new InstanceType("r6gd.large");
        /// <summary>
        /// Constant R6gdMedium for InstanceType
        /// </summary>
        public static readonly InstanceType R6gdMedium = new InstanceType("r6gd.medium");
        /// <summary>
        /// Constant R6gdMetal for InstanceType
        /// </summary>
        public static readonly InstanceType R6gdMetal = new InstanceType("r6gd.metal");
        /// <summary>
        /// Constant R6gdXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gdXlarge = new InstanceType("r6gd.xlarge");
        /// <summary>
        /// Constant R6gLarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gLarge = new InstanceType("r6g.large");
        /// <summary>
        /// Constant R6gMedium for InstanceType
        /// </summary>
        public static readonly InstanceType R6gMedium = new InstanceType("r6g.medium");
        /// <summary>
        /// Constant R6gMetal for InstanceType
        /// </summary>
        public static readonly InstanceType R6gMetal = new InstanceType("r6g.metal");
        /// <summary>
        /// Constant R6gXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType R6gXlarge = new InstanceType("r6g.xlarge");
        /// <summary>
        /// Constant T1Micro for InstanceType
        /// </summary>
        public static readonly InstanceType T1Micro = new InstanceType("t1.micro");
        /// <summary>
        /// Constant T22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T22xlarge = new InstanceType("t2.2xlarge");
        /// <summary>
        /// Constant T2Large for InstanceType
        /// </summary>
        public static readonly InstanceType T2Large = new InstanceType("t2.large");
        /// <summary>
        /// Constant T2Medium for InstanceType
        /// </summary>
        public static readonly InstanceType T2Medium = new InstanceType("t2.medium");
        /// <summary>
        /// Constant T2Micro for InstanceType
        /// </summary>
        public static readonly InstanceType T2Micro = new InstanceType("t2.micro");
        /// <summary>
        /// Constant T2Nano for InstanceType
        /// </summary>
        public static readonly InstanceType T2Nano = new InstanceType("t2.nano");
        /// <summary>
        /// Constant T2Small for InstanceType
        /// </summary>
        public static readonly InstanceType T2Small = new InstanceType("t2.small");
        /// <summary>
        /// Constant T2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T2Xlarge = new InstanceType("t2.xlarge");
        /// <summary>
        /// Constant T32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T32xlarge = new InstanceType("t3.2xlarge");
        /// <summary>
        /// Constant T3a2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T3a2xlarge = new InstanceType("t3a.2xlarge");
        /// <summary>
        /// Constant T3aLarge for InstanceType
        /// </summary>
        public static readonly InstanceType T3aLarge = new InstanceType("t3a.large");
        /// <summary>
        /// Constant T3aMedium for InstanceType
        /// </summary>
        public static readonly InstanceType T3aMedium = new InstanceType("t3a.medium");
        /// <summary>
        /// Constant T3aMicro for InstanceType
        /// </summary>
        public static readonly InstanceType T3aMicro = new InstanceType("t3a.micro");
        /// <summary>
        /// Constant T3aNano for InstanceType
        /// </summary>
        public static readonly InstanceType T3aNano = new InstanceType("t3a.nano");
        /// <summary>
        /// Constant T3aSmall for InstanceType
        /// </summary>
        public static readonly InstanceType T3aSmall = new InstanceType("t3a.small");
        /// <summary>
        /// Constant T3aXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T3aXlarge = new InstanceType("t3a.xlarge");
        /// <summary>
        /// Constant T3Large for InstanceType
        /// </summary>
        public static readonly InstanceType T3Large = new InstanceType("t3.large");
        /// <summary>
        /// Constant T3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType T3Medium = new InstanceType("t3.medium");
        /// <summary>
        /// Constant T3Micro for InstanceType
        /// </summary>
        public static readonly InstanceType T3Micro = new InstanceType("t3.micro");
        /// <summary>
        /// Constant T3Nano for InstanceType
        /// </summary>
        public static readonly InstanceType T3Nano = new InstanceType("t3.nano");
        /// <summary>
        /// Constant T3Small for InstanceType
        /// </summary>
        public static readonly InstanceType T3Small = new InstanceType("t3.small");
        /// <summary>
        /// Constant T3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T3Xlarge = new InstanceType("t3.xlarge");
        /// <summary>
        /// Constant T4g2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T4g2xlarge = new InstanceType("t4g.2xlarge");
        /// <summary>
        /// Constant T4gLarge for InstanceType
        /// </summary>
        public static readonly InstanceType T4gLarge = new InstanceType("t4g.large");
        /// <summary>
        /// Constant T4gMedium for InstanceType
        /// </summary>
        public static readonly InstanceType T4gMedium = new InstanceType("t4g.medium");
        /// <summary>
        /// Constant T4gMicro for InstanceType
        /// </summary>
        public static readonly InstanceType T4gMicro = new InstanceType("t4g.micro");
        /// <summary>
        /// Constant T4gNano for InstanceType
        /// </summary>
        public static readonly InstanceType T4gNano = new InstanceType("t4g.nano");
        /// <summary>
        /// Constant T4gSmall for InstanceType
        /// </summary>
        public static readonly InstanceType T4gSmall = new InstanceType("t4g.small");
        /// <summary>
        /// Constant T4gXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType T4gXlarge = new InstanceType("t4g.xlarge");
        /// <summary>
        /// Constant U12tb1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType U12tb1Metal = new InstanceType("u-12tb1.metal");
        /// <summary>
        /// Constant U18tb1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType U18tb1Metal = new InstanceType("u-18tb1.metal");
        /// <summary>
        /// Constant U24tb1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType U24tb1Metal = new InstanceType("u-24tb1.metal");
        /// <summary>
        /// Constant U6tb1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType U6tb1Metal = new InstanceType("u-6tb1.metal");
        /// <summary>
        /// Constant U9tb1Metal for InstanceType
        /// </summary>
        public static readonly InstanceType U9tb1Metal = new InstanceType("u-9tb1.metal");
        /// <summary>
        /// Constant X116xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X116xlarge = new InstanceType("x1.16xlarge");
        /// <summary>
        /// Constant X132xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X132xlarge = new InstanceType("x1.32xlarge");
        /// <summary>
        /// Constant X1e16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1e16xlarge = new InstanceType("x1e.16xlarge");
        /// <summary>
        /// Constant X1e2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1e2xlarge = new InstanceType("x1e.2xlarge");
        /// <summary>
        /// Constant X1e32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1e32xlarge = new InstanceType("x1e.32xlarge");
        /// <summary>
        /// Constant X1e4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1e4xlarge = new InstanceType("x1e.4xlarge");
        /// <summary>
        /// Constant X1e8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1e8xlarge = new InstanceType("x1e.8xlarge");
        /// <summary>
        /// Constant X1eXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType X1eXlarge = new InstanceType("x1e.xlarge");
        /// <summary>
        /// Constant Z1d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1d12xlarge = new InstanceType("z1d.12xlarge");
        /// <summary>
        /// Constant Z1d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1d2xlarge = new InstanceType("z1d.2xlarge");
        /// <summary>
        /// Constant Z1d3xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1d3xlarge = new InstanceType("z1d.3xlarge");
        /// <summary>
        /// Constant Z1d6xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1d6xlarge = new InstanceType("z1d.6xlarge");
        /// <summary>
        /// Constant Z1dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1dLarge = new InstanceType("z1d.large");
        /// <summary>
        /// Constant Z1dMetal for InstanceType
        /// </summary>
        public static readonly InstanceType Z1dMetal = new InstanceType("z1d.metal");
        /// <summary>
        /// Constant Z1dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType Z1dXlarge = new InstanceType("z1d.xlarge");

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
    /// Constants used for properties of type InstanceTypeHypervisor.
    /// </summary>
    public class InstanceTypeHypervisor : ConstantClass
    {

        /// <summary>
        /// Constant Nitro for InstanceTypeHypervisor
        /// </summary>
        public static readonly InstanceTypeHypervisor Nitro = new InstanceTypeHypervisor("nitro");
        /// <summary>
        /// Constant Xen for InstanceTypeHypervisor
        /// </summary>
        public static readonly InstanceTypeHypervisor Xen = new InstanceTypeHypervisor("xen");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceTypeHypervisor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceTypeHypervisor FindValue(string value)
        {
            return FindValue<InstanceTypeHypervisor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceTypeHypervisor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InterfacePermissionType.
    /// </summary>
    public class InterfacePermissionType : ConstantClass
    {

        /// <summary>
        /// Constant EIPASSOCIATE for InterfacePermissionType
        /// </summary>
        public static readonly InterfacePermissionType EIPASSOCIATE = new InterfacePermissionType("EIP-ASSOCIATE");
        /// <summary>
        /// Constant INSTANCEATTACH for InterfacePermissionType
        /// </summary>
        public static readonly InterfacePermissionType INSTANCEATTACH = new InterfacePermissionType("INSTANCE-ATTACH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterfacePermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterfacePermissionType FindValue(string value)
        {
            return FindValue<InterfacePermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterfacePermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ipv6SupportValue.
    /// </summary>
    public class Ipv6SupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for Ipv6SupportValue
        /// </summary>
        public static readonly Ipv6SupportValue Disable = new Ipv6SupportValue("disable");
        /// <summary>
        /// Constant Enable for Ipv6SupportValue
        /// </summary>
        public static readonly Ipv6SupportValue Enable = new Ipv6SupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ipv6SupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ipv6SupportValue FindValue(string value)
        {
            return FindValue<Ipv6SupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ipv6SupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchTemplateErrorCode.
    /// </summary>
    public class LaunchTemplateErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant LaunchTemplateIdDoesNotExist for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode LaunchTemplateIdDoesNotExist = new LaunchTemplateErrorCode("launchTemplateIdDoesNotExist");
        /// <summary>
        /// Constant LaunchTemplateIdMalformed for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode LaunchTemplateIdMalformed = new LaunchTemplateErrorCode("launchTemplateIdMalformed");
        /// <summary>
        /// Constant LaunchTemplateNameDoesNotExist for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode LaunchTemplateNameDoesNotExist = new LaunchTemplateErrorCode("launchTemplateNameDoesNotExist");
        /// <summary>
        /// Constant LaunchTemplateNameMalformed for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode LaunchTemplateNameMalformed = new LaunchTemplateErrorCode("launchTemplateNameMalformed");
        /// <summary>
        /// Constant LaunchTemplateVersionDoesNotExist for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode LaunchTemplateVersionDoesNotExist = new LaunchTemplateErrorCode("launchTemplateVersionDoesNotExist");
        /// <summary>
        /// Constant UnexpectedError for LaunchTemplateErrorCode
        /// </summary>
        public static readonly LaunchTemplateErrorCode UnexpectedError = new LaunchTemplateErrorCode("unexpectedError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchTemplateErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchTemplateErrorCode FindValue(string value)
        {
            return FindValue<LaunchTemplateErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchTemplateErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchTemplateHttpTokensState.
    /// </summary>
    public class LaunchTemplateHttpTokensState : ConstantClass
    {

        /// <summary>
        /// Constant Optional for LaunchTemplateHttpTokensState
        /// </summary>
        public static readonly LaunchTemplateHttpTokensState Optional = new LaunchTemplateHttpTokensState("optional");
        /// <summary>
        /// Constant Required for LaunchTemplateHttpTokensState
        /// </summary>
        public static readonly LaunchTemplateHttpTokensState Required = new LaunchTemplateHttpTokensState("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchTemplateHttpTokensState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchTemplateHttpTokensState FindValue(string value)
        {
            return FindValue<LaunchTemplateHttpTokensState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchTemplateHttpTokensState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchTemplateInstanceMetadataEndpointState.
    /// </summary>
    public class LaunchTemplateInstanceMetadataEndpointState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for LaunchTemplateInstanceMetadataEndpointState
        /// </summary>
        public static readonly LaunchTemplateInstanceMetadataEndpointState Disabled = new LaunchTemplateInstanceMetadataEndpointState("disabled");
        /// <summary>
        /// Constant Enabled for LaunchTemplateInstanceMetadataEndpointState
        /// </summary>
        public static readonly LaunchTemplateInstanceMetadataEndpointState Enabled = new LaunchTemplateInstanceMetadataEndpointState("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchTemplateInstanceMetadataEndpointState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchTemplateInstanceMetadataEndpointState FindValue(string value)
        {
            return FindValue<LaunchTemplateInstanceMetadataEndpointState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchTemplateInstanceMetadataEndpointState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchTemplateInstanceMetadataOptionsState.
    /// </summary>
    public class LaunchTemplateInstanceMetadataOptionsState : ConstantClass
    {

        /// <summary>
        /// Constant Applied for LaunchTemplateInstanceMetadataOptionsState
        /// </summary>
        public static readonly LaunchTemplateInstanceMetadataOptionsState Applied = new LaunchTemplateInstanceMetadataOptionsState("applied");
        /// <summary>
        /// Constant Pending for LaunchTemplateInstanceMetadataOptionsState
        /// </summary>
        public static readonly LaunchTemplateInstanceMetadataOptionsState Pending = new LaunchTemplateInstanceMetadataOptionsState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchTemplateInstanceMetadataOptionsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchTemplateInstanceMetadataOptionsState FindValue(string value)
        {
            return FindValue<LaunchTemplateInstanceMetadataOptionsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchTemplateInstanceMetadataOptionsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListingState.
    /// </summary>
    public class ListingState : ConstantClass
    {

        /// <summary>
        /// Constant Available for ListingState
        /// </summary>
        public static readonly ListingState Available = new ListingState("available");
        /// <summary>
        /// Constant Cancelled for ListingState
        /// </summary>
        public static readonly ListingState Cancelled = new ListingState("cancelled");
        /// <summary>
        /// Constant Pending for ListingState
        /// </summary>
        public static readonly ListingState Pending = new ListingState("pending");
        /// <summary>
        /// Constant Sold for ListingState
        /// </summary>
        public static readonly ListingState Sold = new ListingState("sold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingState FindValue(string value)
        {
            return FindValue<ListingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListingStatus.
    /// </summary>
    public class ListingStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for ListingStatus
        /// </summary>
        public static readonly ListingStatus Active = new ListingStatus("active");
        /// <summary>
        /// Constant Cancelled for ListingStatus
        /// </summary>
        public static readonly ListingStatus Cancelled = new ListingStatus("cancelled");
        /// <summary>
        /// Constant Closed for ListingStatus
        /// </summary>
        public static readonly ListingStatus Closed = new ListingStatus("closed");
        /// <summary>
        /// Constant Pending for ListingStatus
        /// </summary>
        public static readonly ListingStatus Pending = new ListingStatus("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingStatus FindValue(string value)
        {
            return FindValue<ListingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalGatewayRouteState.
    /// </summary>
    public class LocalGatewayRouteState : ConstantClass
    {

        /// <summary>
        /// Constant Active for LocalGatewayRouteState
        /// </summary>
        public static readonly LocalGatewayRouteState Active = new LocalGatewayRouteState("active");
        /// <summary>
        /// Constant Blackhole for LocalGatewayRouteState
        /// </summary>
        public static readonly LocalGatewayRouteState Blackhole = new LocalGatewayRouteState("blackhole");
        /// <summary>
        /// Constant Deleted for LocalGatewayRouteState
        /// </summary>
        public static readonly LocalGatewayRouteState Deleted = new LocalGatewayRouteState("deleted");
        /// <summary>
        /// Constant Deleting for LocalGatewayRouteState
        /// </summary>
        public static readonly LocalGatewayRouteState Deleting = new LocalGatewayRouteState("deleting");
        /// <summary>
        /// Constant Pending for LocalGatewayRouteState
        /// </summary>
        public static readonly LocalGatewayRouteState Pending = new LocalGatewayRouteState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalGatewayRouteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalGatewayRouteState FindValue(string value)
        {
            return FindValue<LocalGatewayRouteState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalGatewayRouteState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalGatewayRouteType.
    /// </summary>
    public class LocalGatewayRouteType : ConstantClass
    {

        /// <summary>
        /// Constant Propagated for LocalGatewayRouteType
        /// </summary>
        public static readonly LocalGatewayRouteType Propagated = new LocalGatewayRouteType("propagated");
        /// <summary>
        /// Constant Static for LocalGatewayRouteType
        /// </summary>
        public static readonly LocalGatewayRouteType Static = new LocalGatewayRouteType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalGatewayRouteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalGatewayRouteType FindValue(string value)
        {
            return FindValue<LocalGatewayRouteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalGatewayRouteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityZone for LocationType
        /// </summary>
        public static readonly LocationType AvailabilityZone = new LocationType("availability-zone");
        /// <summary>
        /// Constant AvailabilityZoneId for LocationType
        /// </summary>
        public static readonly LocationType AvailabilityZoneId = new LocationType("availability-zone-id");
        /// <summary>
        /// Constant Region for LocationType
        /// </summary>
        public static readonly LocationType Region = new LocationType("region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDestinationType.
    /// </summary>
    public class LogDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchLogs for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType CloudWatchLogs = new LogDestinationType("cloud-watch-logs");
        /// <summary>
        /// Constant S3 for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType S3 = new LogDestinationType("s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDestinationType FindValue(string value)
        {
            return FindValue<LogDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketType.
    /// </summary>
    public class MarketType : ConstantClass
    {

        /// <summary>
        /// Constant Spot for MarketType
        /// </summary>
        public static readonly MarketType Spot = new MarketType("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketType FindValue(string value)
        {
            return FindValue<MarketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipType.
    /// </summary>
    public class MembershipType : ConstantClass
    {

        /// <summary>
        /// Constant Igmp for MembershipType
        /// </summary>
        public static readonly MembershipType Igmp = new MembershipType("igmp");
        /// <summary>
        /// Constant Static for MembershipType
        /// </summary>
        public static readonly MembershipType Static = new MembershipType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipType FindValue(string value)
        {
            return FindValue<MembershipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModifyAvailabilityZoneOptInStatus.
    /// </summary>
    public class ModifyAvailabilityZoneOptInStatus : ConstantClass
    {

        /// <summary>
        /// Constant NotOptedIn for ModifyAvailabilityZoneOptInStatus
        /// </summary>
        public static readonly ModifyAvailabilityZoneOptInStatus NotOptedIn = new ModifyAvailabilityZoneOptInStatus("not-opted-in");
        /// <summary>
        /// Constant OptedIn for ModifyAvailabilityZoneOptInStatus
        /// </summary>
        public static readonly ModifyAvailabilityZoneOptInStatus OptedIn = new ModifyAvailabilityZoneOptInStatus("opted-in");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModifyAvailabilityZoneOptInStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModifyAvailabilityZoneOptInStatus FindValue(string value)
        {
            return FindValue<ModifyAvailabilityZoneOptInStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModifyAvailabilityZoneOptInStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringState.
    /// </summary>
    public class MonitoringState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MonitoringState
        /// </summary>
        public static readonly MonitoringState Disabled = new MonitoringState("disabled");
        /// <summary>
        /// Constant Disabling for MonitoringState
        /// </summary>
        public static readonly MonitoringState Disabling = new MonitoringState("disabling");
        /// <summary>
        /// Constant Enabled for MonitoringState
        /// </summary>
        public static readonly MonitoringState Enabled = new MonitoringState("enabled");
        /// <summary>
        /// Constant Pending for MonitoringState
        /// </summary>
        public static readonly MonitoringState Pending = new MonitoringState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringState FindValue(string value)
        {
            return FindValue<MonitoringState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MoveStatus.
    /// </summary>
    public class MoveStatus : ConstantClass
    {

        /// <summary>
        /// Constant MovingToVpc for MoveStatus
        /// </summary>
        public static readonly MoveStatus MovingToVpc = new MoveStatus("movingToVpc");
        /// <summary>
        /// Constant RestoringToClassic for MoveStatus
        /// </summary>
        public static readonly MoveStatus RestoringToClassic = new MoveStatus("restoringToClassic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MoveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MoveStatus FindValue(string value)
        {
            return FindValue<MoveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MoveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MulticastSupportValue.
    /// </summary>
    public class MulticastSupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for MulticastSupportValue
        /// </summary>
        public static readonly MulticastSupportValue Disable = new MulticastSupportValue("disable");
        /// <summary>
        /// Constant Enable for MulticastSupportValue
        /// </summary>
        public static readonly MulticastSupportValue Enable = new MulticastSupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MulticastSupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MulticastSupportValue FindValue(string value)
        {
            return FindValue<MulticastSupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MulticastSupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NatGatewayState.
    /// </summary>
    public class NatGatewayState : ConstantClass
    {

        /// <summary>
        /// Constant Available for NatGatewayState
        /// </summary>
        public static readonly NatGatewayState Available = new NatGatewayState("available");
        /// <summary>
        /// Constant Deleted for NatGatewayState
        /// </summary>
        public static readonly NatGatewayState Deleted = new NatGatewayState("deleted");
        /// <summary>
        /// Constant Deleting for NatGatewayState
        /// </summary>
        public static readonly NatGatewayState Deleting = new NatGatewayState("deleting");
        /// <summary>
        /// Constant Failed for NatGatewayState
        /// </summary>
        public static readonly NatGatewayState Failed = new NatGatewayState("failed");
        /// <summary>
        /// Constant Pending for NatGatewayState
        /// </summary>
        public static readonly NatGatewayState Pending = new NatGatewayState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NatGatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NatGatewayState FindValue(string value)
        {
            return FindValue<NatGatewayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NatGatewayState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceAttribute.
    /// </summary>
    public class NetworkInterfaceAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Attachment for NetworkInterfaceAttribute
        /// </summary>
        public static readonly NetworkInterfaceAttribute Attachment = new NetworkInterfaceAttribute("attachment");
        /// <summary>
        /// Constant Description for NetworkInterfaceAttribute
        /// </summary>
        public static readonly NetworkInterfaceAttribute Description = new NetworkInterfaceAttribute("description");
        /// <summary>
        /// Constant GroupSet for NetworkInterfaceAttribute
        /// </summary>
        public static readonly NetworkInterfaceAttribute GroupSet = new NetworkInterfaceAttribute("groupSet");
        /// <summary>
        /// Constant SourceDestCheck for NetworkInterfaceAttribute
        /// </summary>
        public static readonly NetworkInterfaceAttribute SourceDestCheck = new NetworkInterfaceAttribute("sourceDestCheck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceAttribute FindValue(string value)
        {
            return FindValue<NetworkInterfaceAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceCreationType.
    /// </summary>
    public class NetworkInterfaceCreationType : ConstantClass
    {

        /// <summary>
        /// Constant Efa for NetworkInterfaceCreationType
        /// </summary>
        public static readonly NetworkInterfaceCreationType Efa = new NetworkInterfaceCreationType("efa");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceCreationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceCreationType FindValue(string value)
        {
            return FindValue<NetworkInterfaceCreationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceCreationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfacePermissionStateCode.
    /// </summary>
    public class NetworkInterfacePermissionStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Granted for NetworkInterfacePermissionStateCode
        /// </summary>
        public static readonly NetworkInterfacePermissionStateCode Granted = new NetworkInterfacePermissionStateCode("granted");
        /// <summary>
        /// Constant Pending for NetworkInterfacePermissionStateCode
        /// </summary>
        public static readonly NetworkInterfacePermissionStateCode Pending = new NetworkInterfacePermissionStateCode("pending");
        /// <summary>
        /// Constant Revoked for NetworkInterfacePermissionStateCode
        /// </summary>
        public static readonly NetworkInterfacePermissionStateCode Revoked = new NetworkInterfacePermissionStateCode("revoked");
        /// <summary>
        /// Constant Revoking for NetworkInterfacePermissionStateCode
        /// </summary>
        public static readonly NetworkInterfacePermissionStateCode Revoking = new NetworkInterfacePermissionStateCode("revoking");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfacePermissionStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfacePermissionStateCode FindValue(string value)
        {
            return FindValue<NetworkInterfacePermissionStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfacePermissionStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceStatus.
    /// </summary>
    public class NetworkInterfaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Associated for NetworkInterfaceStatus
        /// </summary>
        public static readonly NetworkInterfaceStatus Associated = new NetworkInterfaceStatus("associated");
        /// <summary>
        /// Constant Attaching for NetworkInterfaceStatus
        /// </summary>
        public static readonly NetworkInterfaceStatus Attaching = new NetworkInterfaceStatus("attaching");
        /// <summary>
        /// Constant Available for NetworkInterfaceStatus
        /// </summary>
        public static readonly NetworkInterfaceStatus Available = new NetworkInterfaceStatus("available");
        /// <summary>
        /// Constant Detaching for NetworkInterfaceStatus
        /// </summary>
        public static readonly NetworkInterfaceStatus Detaching = new NetworkInterfaceStatus("detaching");
        /// <summary>
        /// Constant InUse for NetworkInterfaceStatus
        /// </summary>
        public static readonly NetworkInterfaceStatus InUse = new NetworkInterfaceStatus("in-use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceStatus FindValue(string value)
        {
            return FindValue<NetworkInterfaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceType.
    /// </summary>
    public class NetworkInterfaceType : ConstantClass
    {

        /// <summary>
        /// Constant Efa for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType Efa = new NetworkInterfaceType("efa");
        /// <summary>
        /// Constant Interface for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType Interface = new NetworkInterfaceType("interface");
        /// <summary>
        /// Constant NatGateway for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType NatGateway = new NetworkInterfaceType("natGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceType FindValue(string value)
        {
            return FindValue<NetworkInterfaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingClassType.
    /// </summary>
    public class OfferingClassType : ConstantClass
    {

        /// <summary>
        /// Constant Convertible for OfferingClassType
        /// </summary>
        public static readonly OfferingClassType Convertible = new OfferingClassType("convertible");
        /// <summary>
        /// Constant Standard for OfferingClassType
        /// </summary>
        public static readonly OfferingClassType Standard = new OfferingClassType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingClassType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingClassType FindValue(string value)
        {
            return FindValue<OfferingClassType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingClassType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingTypeValues.
    /// </summary>
    public class OfferingTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant AllUpfront for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues AllUpfront = new OfferingTypeValues("All Upfront");
        /// <summary>
        /// Constant HeavyUtilization for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues HeavyUtilization = new OfferingTypeValues("Heavy Utilization");
        /// <summary>
        /// Constant LightUtilization for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues LightUtilization = new OfferingTypeValues("Light Utilization");
        /// <summary>
        /// Constant MediumUtilization for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues MediumUtilization = new OfferingTypeValues("Medium Utilization");
        /// <summary>
        /// Constant NoUpfront for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues NoUpfront = new OfferingTypeValues("No Upfront");
        /// <summary>
        /// Constant PartialUpfront for OfferingTypeValues
        /// </summary>
        public static readonly OfferingTypeValues PartialUpfront = new OfferingTypeValues("Partial Upfront");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingTypeValues FindValue(string value)
        {
            return FindValue<OfferingTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnDemandAllocationStrategy.
    /// </summary>
    public class OnDemandAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LowestPrice for OnDemandAllocationStrategy
        /// </summary>
        public static readonly OnDemandAllocationStrategy LowestPrice = new OnDemandAllocationStrategy("lowestPrice");
        /// <summary>
        /// Constant Prioritized for OnDemandAllocationStrategy
        /// </summary>
        public static readonly OnDemandAllocationStrategy Prioritized = new OnDemandAllocationStrategy("prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnDemandAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnDemandAllocationStrategy FindValue(string value)
        {
            return FindValue<OnDemandAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnDemandAllocationStrategy(string value)
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
        /// Constant Add for OperationType
        /// </summary>
        public static readonly OperationType Add = new OperationType("add");
        /// <summary>
        /// Constant Remove for OperationType
        /// </summary>
        public static readonly OperationType Remove = new OperationType("remove");

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
    /// Constants used for properties of type PaymentOption.
    /// </summary>
    public class PaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant AllUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption AllUpfront = new PaymentOption("AllUpfront");
        /// <summary>
        /// Constant NoUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption NoUpfront = new PaymentOption("NoUpfront");
        /// <summary>
        /// Constant PartialUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption PartialUpfront = new PaymentOption("PartialUpfront");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentOption FindValue(string value)
        {
            return FindValue<PaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionGroup.
    /// </summary>
    public class PermissionGroup : ConstantClass
    {

        /// <summary>
        /// Constant All for PermissionGroup
        /// </summary>
        public static readonly PermissionGroup All = new PermissionGroup("all");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionGroup(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionGroup FindValue(string value)
        {
            return FindValue<PermissionGroup>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionGroup(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementGroupState.
    /// </summary>
    public class PlacementGroupState : ConstantClass
    {

        /// <summary>
        /// Constant Available for PlacementGroupState
        /// </summary>
        public static readonly PlacementGroupState Available = new PlacementGroupState("available");
        /// <summary>
        /// Constant Deleted for PlacementGroupState
        /// </summary>
        public static readonly PlacementGroupState Deleted = new PlacementGroupState("deleted");
        /// <summary>
        /// Constant Deleting for PlacementGroupState
        /// </summary>
        public static readonly PlacementGroupState Deleting = new PlacementGroupState("deleting");
        /// <summary>
        /// Constant Pending for PlacementGroupState
        /// </summary>
        public static readonly PlacementGroupState Pending = new PlacementGroupState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementGroupState FindValue(string value)
        {
            return FindValue<PlacementGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementGroupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementGroupStrategy.
    /// </summary>
    public class PlacementGroupStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy Cluster = new PlacementGroupStrategy("cluster");
        /// <summary>
        /// Constant Partition for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy Partition = new PlacementGroupStrategy("partition");
        /// <summary>
        /// Constant Spread for PlacementGroupStrategy
        /// </summary>
        public static readonly PlacementGroupStrategy Spread = new PlacementGroupStrategy("spread");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementGroupStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementGroupStrategy FindValue(string value)
        {
            return FindValue<PlacementGroupStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementGroupStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementStrategy.
    /// </summary>
    public class PlacementStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for PlacementStrategy
        /// </summary>
        public static readonly PlacementStrategy Cluster = new PlacementStrategy("cluster");
        /// <summary>
        /// Constant Partition for PlacementStrategy
        /// </summary>
        public static readonly PlacementStrategy Partition = new PlacementStrategy("partition");
        /// <summary>
        /// Constant Spread for PlacementStrategy
        /// </summary>
        public static readonly PlacementStrategy Spread = new PlacementStrategy("spread");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementStrategy FindValue(string value)
        {
            return FindValue<PlacementStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformValues.
    /// </summary>
    public class PlatformValues : ConstantClass
    {

        /// <summary>
        /// Constant Windows for PlatformValues
        /// </summary>
        public static readonly PlatformValues Windows = new PlatformValues("Windows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformValues FindValue(string value)
        {
            return FindValue<PlatformValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrefixListState.
    /// </summary>
    public class PrefixListState : ConstantClass
    {

        /// <summary>
        /// Constant CreateComplete for PrefixListState
        /// </summary>
        public static readonly PrefixListState CreateComplete = new PrefixListState("create-complete");
        /// <summary>
        /// Constant CreateFailed for PrefixListState
        /// </summary>
        public static readonly PrefixListState CreateFailed = new PrefixListState("create-failed");
        /// <summary>
        /// Constant CreateInProgress for PrefixListState
        /// </summary>
        public static readonly PrefixListState CreateInProgress = new PrefixListState("create-in-progress");
        /// <summary>
        /// Constant DeleteComplete for PrefixListState
        /// </summary>
        public static readonly PrefixListState DeleteComplete = new PrefixListState("delete-complete");
        /// <summary>
        /// Constant DeleteFailed for PrefixListState
        /// </summary>
        public static readonly PrefixListState DeleteFailed = new PrefixListState("delete-failed");
        /// <summary>
        /// Constant DeleteInProgress for PrefixListState
        /// </summary>
        public static readonly PrefixListState DeleteInProgress = new PrefixListState("delete-in-progress");
        /// <summary>
        /// Constant ModifyComplete for PrefixListState
        /// </summary>
        public static readonly PrefixListState ModifyComplete = new PrefixListState("modify-complete");
        /// <summary>
        /// Constant ModifyFailed for PrefixListState
        /// </summary>
        public static readonly PrefixListState ModifyFailed = new PrefixListState("modify-failed");
        /// <summary>
        /// Constant ModifyInProgress for PrefixListState
        /// </summary>
        public static readonly PrefixListState ModifyInProgress = new PrefixListState("modify-in-progress");
        /// <summary>
        /// Constant RestoreComplete for PrefixListState
        /// </summary>
        public static readonly PrefixListState RestoreComplete = new PrefixListState("restore-complete");
        /// <summary>
        /// Constant RestoreFailed for PrefixListState
        /// </summary>
        public static readonly PrefixListState RestoreFailed = new PrefixListState("restore-failed");
        /// <summary>
        /// Constant RestoreInProgress for PrefixListState
        /// </summary>
        public static readonly PrefixListState RestoreInProgress = new PrefixListState("restore-in-progress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrefixListState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrefixListState FindValue(string value)
        {
            return FindValue<PrefixListState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrefixListState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant Account for PrincipalType
        /// </summary>
        public static readonly PrincipalType Account = new PrincipalType("Account");
        /// <summary>
        /// Constant All for PrincipalType
        /// </summary>
        public static readonly PrincipalType All = new PrincipalType("All");
        /// <summary>
        /// Constant OrganizationUnit for PrincipalType
        /// </summary>
        public static readonly PrincipalType OrganizationUnit = new PrincipalType("OrganizationUnit");
        /// <summary>
        /// Constant Role for PrincipalType
        /// </summary>
        public static readonly PrincipalType Role = new PrincipalType("Role");
        /// <summary>
        /// Constant Service for PrincipalType
        /// </summary>
        public static readonly PrincipalType Service = new PrincipalType("Service");
        /// <summary>
        /// Constant User for PrincipalType
        /// </summary>
        public static readonly PrincipalType User = new PrincipalType("User");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductCodeValues.
    /// </summary>
    public class ProductCodeValues : ConstantClass
    {

        /// <summary>
        /// Constant Devpay for ProductCodeValues
        /// </summary>
        public static readonly ProductCodeValues Devpay = new ProductCodeValues("devpay");
        /// <summary>
        /// Constant Marketplace for ProductCodeValues
        /// </summary>
        public static readonly ProductCodeValues Marketplace = new ProductCodeValues("marketplace");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductCodeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductCodeValues FindValue(string value)
        {
            return FindValue<ProductCodeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductCodeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant Tcp for Protocol
        /// </summary>
        public static readonly Protocol Tcp = new Protocol("tcp");
        /// <summary>
        /// Constant Udp for Protocol
        /// </summary>
        public static readonly Protocol Udp = new Protocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtocolValue.
    /// </summary>
    public class ProtocolValue : ConstantClass
    {

        /// <summary>
        /// Constant Gre for ProtocolValue
        /// </summary>
        public static readonly ProtocolValue Gre = new ProtocolValue("gre");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtocolValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtocolValue FindValue(string value)
        {
            return FindValue<ProtocolValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtocolValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecurringChargeFrequency.
    /// </summary>
    public class RecurringChargeFrequency : ConstantClass
    {

        /// <summary>
        /// Constant Hourly for RecurringChargeFrequency
        /// </summary>
        public static readonly RecurringChargeFrequency Hourly = new RecurringChargeFrequency("Hourly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecurringChargeFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecurringChargeFrequency FindValue(string value)
        {
            return FindValue<RecurringChargeFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecurringChargeFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplacementStrategy.
    /// </summary>
    public class ReplacementStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Launch for ReplacementStrategy
        /// </summary>
        public static readonly ReplacementStrategy Launch = new ReplacementStrategy("launch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplacementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplacementStrategy FindValue(string value)
        {
            return FindValue<ReplacementStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplacementStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportInstanceReasonCodes.
    /// </summary>
    public class ReportInstanceReasonCodes : ConstantClass
    {

        /// <summary>
        /// Constant InstanceStuckInState for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes InstanceStuckInState = new ReportInstanceReasonCodes("instance-stuck-in-state");
        /// <summary>
        /// Constant NotAcceptingCredentials for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes NotAcceptingCredentials = new ReportInstanceReasonCodes("not-accepting-credentials");
        /// <summary>
        /// Constant Other for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes Other = new ReportInstanceReasonCodes("other");
        /// <summary>
        /// Constant PasswordNotAvailable for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes PasswordNotAvailable = new ReportInstanceReasonCodes("password-not-available");
        /// <summary>
        /// Constant PerformanceEbsVolume for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceEbsVolume = new ReportInstanceReasonCodes("performance-ebs-volume");
        /// <summary>
        /// Constant PerformanceInstanceStore for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceInstanceStore = new ReportInstanceReasonCodes("performance-instance-store");
        /// <summary>
        /// Constant PerformanceNetwork for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceNetwork = new ReportInstanceReasonCodes("performance-network");
        /// <summary>
        /// Constant PerformanceOther for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceOther = new ReportInstanceReasonCodes("performance-other");
        /// <summary>
        /// Constant Unresponsive for ReportInstanceReasonCodes
        /// </summary>
        public static readonly ReportInstanceReasonCodes Unresponsive = new ReportInstanceReasonCodes("unresponsive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportInstanceReasonCodes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportInstanceReasonCodes FindValue(string value)
        {
            return FindValue<ReportInstanceReasonCodes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportInstanceReasonCodes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStatusType.
    /// </summary>
    public class ReportStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Impaired for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType Impaired = new ReportStatusType("impaired");
        /// <summary>
        /// Constant Ok for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType Ok = new ReportStatusType("ok");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStatusType FindValue(string value)
        {
            return FindValue<ReportStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationState.
    /// </summary>
    public class ReservationState : ConstantClass
    {

        /// <summary>
        /// Constant Active for ReservationState
        /// </summary>
        public static readonly ReservationState Active = new ReservationState("active");
        /// <summary>
        /// Constant PaymentFailed for ReservationState
        /// </summary>
        public static readonly ReservationState PaymentFailed = new ReservationState("payment-failed");
        /// <summary>
        /// Constant PaymentPending for ReservationState
        /// </summary>
        public static readonly ReservationState PaymentPending = new ReservationState("payment-pending");
        /// <summary>
        /// Constant Retired for ReservationState
        /// </summary>
        public static readonly ReservationState Retired = new ReservationState("retired");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationState FindValue(string value)
        {
            return FindValue<ReservationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservedInstanceState.
    /// </summary>
    public class ReservedInstanceState : ConstantClass
    {

        /// <summary>
        /// Constant Active for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState Active = new ReservedInstanceState("active");
        /// <summary>
        /// Constant PaymentFailed for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState PaymentFailed = new ReservedInstanceState("payment-failed");
        /// <summary>
        /// Constant PaymentPending for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState PaymentPending = new ReservedInstanceState("payment-pending");
        /// <summary>
        /// Constant Queued for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState Queued = new ReservedInstanceState("queued");
        /// <summary>
        /// Constant QueuedDeleted for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState QueuedDeleted = new ReservedInstanceState("queued-deleted");
        /// <summary>
        /// Constant Retired for ReservedInstanceState
        /// </summary>
        public static readonly ReservedInstanceState Retired = new ReservedInstanceState("retired");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedInstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedInstanceState FindValue(string value)
        {
            return FindValue<ReservedInstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedInstanceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResetFpgaImageAttributeName.
    /// </summary>
    public class ResetFpgaImageAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant LoadPermission for ResetFpgaImageAttributeName
        /// </summary>
        public static readonly ResetFpgaImageAttributeName LoadPermission = new ResetFpgaImageAttributeName("loadPermission");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResetFpgaImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResetFpgaImageAttributeName FindValue(string value)
        {
            return FindValue<ResetFpgaImageAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResetFpgaImageAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResetImageAttributeName.
    /// </summary>
    public class ResetImageAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant LaunchPermission for ResetImageAttributeName
        /// </summary>
        public static readonly ResetImageAttributeName LaunchPermission = new ResetImageAttributeName("launchPermission");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResetImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResetImageAttributeName FindValue(string value)
        {
            return FindValue<ResetImageAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResetImageAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ClientVpnEndpoint for ResourceType
        /// </summary>
        public static readonly ResourceType ClientVpnEndpoint = new ResourceType("client-vpn-endpoint");
        /// <summary>
        /// Constant CustomerGateway for ResourceType
        /// </summary>
        public static readonly ResourceType CustomerGateway = new ResourceType("customer-gateway");
        /// <summary>
        /// Constant DedicatedHost for ResourceType
        /// </summary>
        public static readonly ResourceType DedicatedHost = new ResourceType("dedicated-host");
        /// <summary>
        /// Constant DhcpOptions for ResourceType
        /// </summary>
        public static readonly ResourceType DhcpOptions = new ResourceType("dhcp-options");
        /// <summary>
        /// Constant EgressOnlyInternetGateway for ResourceType
        /// </summary>
        public static readonly ResourceType EgressOnlyInternetGateway = new ResourceType("egress-only-internet-gateway");
        /// <summary>
        /// Constant ElasticGpu for ResourceType
        /// </summary>
        public static readonly ResourceType ElasticGpu = new ResourceType("elastic-gpu");
        /// <summary>
        /// Constant ElasticIp for ResourceType
        /// </summary>
        public static readonly ResourceType ElasticIp = new ResourceType("elastic-ip");
        /// <summary>
        /// Constant ExportImageTask for ResourceType
        /// </summary>
        public static readonly ResourceType ExportImageTask = new ResourceType("export-image-task");
        /// <summary>
        /// Constant ExportInstanceTask for ResourceType
        /// </summary>
        public static readonly ResourceType ExportInstanceTask = new ResourceType("export-instance-task");
        /// <summary>
        /// Constant Fleet for ResourceType
        /// </summary>
        public static readonly ResourceType Fleet = new ResourceType("fleet");
        /// <summary>
        /// Constant FpgaImage for ResourceType
        /// </summary>
        public static readonly ResourceType FpgaImage = new ResourceType("fpga-image");
        /// <summary>
        /// Constant HostReservation for ResourceType
        /// </summary>
        public static readonly ResourceType HostReservation = new ResourceType("host-reservation");
        /// <summary>
        /// Constant Image for ResourceType
        /// </summary>
        public static readonly ResourceType Image = new ResourceType("image");
        /// <summary>
        /// Constant ImportImageTask for ResourceType
        /// </summary>
        public static readonly ResourceType ImportImageTask = new ResourceType("import-image-task");
        /// <summary>
        /// Constant ImportSnapshotTask for ResourceType
        /// </summary>
        public static readonly ResourceType ImportSnapshotTask = new ResourceType("import-snapshot-task");
        /// <summary>
        /// Constant Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Instance = new ResourceType("instance");
        /// <summary>
        /// Constant InternetGateway for ResourceType
        /// </summary>
        public static readonly ResourceType InternetGateway = new ResourceType("internet-gateway");
        /// <summary>
        /// Constant KeyPair for ResourceType
        /// </summary>
        public static readonly ResourceType KeyPair = new ResourceType("key-pair");
        /// <summary>
        /// Constant LaunchTemplate for ResourceType
        /// </summary>
        public static readonly ResourceType LaunchTemplate = new ResourceType("launch-template");
        /// <summary>
        /// Constant LocalGatewayRouteTableVpcAssociation for ResourceType
        /// </summary>
        public static readonly ResourceType LocalGatewayRouteTableVpcAssociation = new ResourceType("local-gateway-route-table-vpc-association");
        /// <summary>
        /// Constant Natgateway for ResourceType
        /// </summary>
        public static readonly ResourceType Natgateway = new ResourceType("natgateway");
        /// <summary>
        /// Constant NetworkAcl for ResourceType
        /// </summary>
        public static readonly ResourceType NetworkAcl = new ResourceType("network-acl");
        /// <summary>
        /// Constant NetworkInsightsAnalysis for ResourceType
        /// </summary>
        public static readonly ResourceType NetworkInsightsAnalysis = new ResourceType("network-insights-analysis");
        /// <summary>
        /// Constant NetworkInsightsPath for ResourceType
        /// </summary>
        public static readonly ResourceType NetworkInsightsPath = new ResourceType("network-insights-path");
        /// <summary>
        /// Constant NetworkInterface for ResourceType
        /// </summary>
        public static readonly ResourceType NetworkInterface = new ResourceType("network-interface");
        /// <summary>
        /// Constant PlacementGroup for ResourceType
        /// </summary>
        public static readonly ResourceType PlacementGroup = new ResourceType("placement-group");
        /// <summary>
        /// Constant ReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType ReservedInstances = new ResourceType("reserved-instances");
        /// <summary>
        /// Constant RouteTable for ResourceType
        /// </summary>
        public static readonly ResourceType RouteTable = new ResourceType("route-table");
        /// <summary>
        /// Constant SecurityGroup for ResourceType
        /// </summary>
        public static readonly ResourceType SecurityGroup = new ResourceType("security-group");
        /// <summary>
        /// Constant Snapshot for ResourceType
        /// </summary>
        public static readonly ResourceType Snapshot = new ResourceType("snapshot");
        /// <summary>
        /// Constant SpotFleetRequest for ResourceType
        /// </summary>
        public static readonly ResourceType SpotFleetRequest = new ResourceType("spot-fleet-request");
        /// <summary>
        /// Constant SpotInstancesRequest for ResourceType
        /// </summary>
        public static readonly ResourceType SpotInstancesRequest = new ResourceType("spot-instances-request");
        /// <summary>
        /// Constant Subnet for ResourceType
        /// </summary>
        public static readonly ResourceType Subnet = new ResourceType("subnet");
        /// <summary>
        /// Constant TrafficMirrorFilter for ResourceType
        /// </summary>
        public static readonly ResourceType TrafficMirrorFilter = new ResourceType("traffic-mirror-filter");
        /// <summary>
        /// Constant TrafficMirrorSession for ResourceType
        /// </summary>
        public static readonly ResourceType TrafficMirrorSession = new ResourceType("traffic-mirror-session");
        /// <summary>
        /// Constant TrafficMirrorTarget for ResourceType
        /// </summary>
        public static readonly ResourceType TrafficMirrorTarget = new ResourceType("traffic-mirror-target");
        /// <summary>
        /// Constant TransitGateway for ResourceType
        /// </summary>
        public static readonly ResourceType TransitGateway = new ResourceType("transit-gateway");
        /// <summary>
        /// Constant TransitGatewayAttachment for ResourceType
        /// </summary>
        public static readonly ResourceType TransitGatewayAttachment = new ResourceType("transit-gateway-attachment");
        /// <summary>
        /// Constant TransitGatewayConnectPeer for ResourceType
        /// </summary>
        public static readonly ResourceType TransitGatewayConnectPeer = new ResourceType("transit-gateway-connect-peer");
        /// <summary>
        /// Constant TransitGatewayMulticastDomain for ResourceType
        /// </summary>
        public static readonly ResourceType TransitGatewayMulticastDomain = new ResourceType("transit-gateway-multicast-domain");
        /// <summary>
        /// Constant TransitGatewayRouteTable for ResourceType
        /// </summary>
        public static readonly ResourceType TransitGatewayRouteTable = new ResourceType("transit-gateway-route-table");
        /// <summary>
        /// Constant Volume for ResourceType
        /// </summary>
        public static readonly ResourceType Volume = new ResourceType("volume");
        /// <summary>
        /// Constant Vpc for ResourceType
        /// </summary>
        public static readonly ResourceType Vpc = new ResourceType("vpc");
        /// <summary>
        /// Constant VpcFlowLog for ResourceType
        /// </summary>
        public static readonly ResourceType VpcFlowLog = new ResourceType("vpc-flow-log");
        /// <summary>
        /// Constant VpcPeeringConnection for ResourceType
        /// </summary>
        public static readonly ResourceType VpcPeeringConnection = new ResourceType("vpc-peering-connection");
        /// <summary>
        /// Constant VpnConnection for ResourceType
        /// </summary>
        public static readonly ResourceType VpnConnection = new ResourceType("vpn-connection");
        /// <summary>
        /// Constant VpnGateway for ResourceType
        /// </summary>
        public static readonly ResourceType VpnGateway = new ResourceType("vpn-gateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RIProductDescription.
    /// </summary>
    public class RIProductDescription : ConstantClass
    {

        /// <summary>
        /// Constant LinuxUNIX for RIProductDescription
        /// </summary>
        public static readonly RIProductDescription LinuxUNIX = new RIProductDescription("Linux/UNIX");
        /// <summary>
        /// Constant LinuxUNIXAmazonVPC for RIProductDescription
        /// </summary>
        public static readonly RIProductDescription LinuxUNIXAmazonVPC = new RIProductDescription("Linux/UNIX (Amazon VPC)");
        /// <summary>
        /// Constant Windows for RIProductDescription
        /// </summary>
        public static readonly RIProductDescription Windows = new RIProductDescription("Windows");
        /// <summary>
        /// Constant WindowsAmazonVPC for RIProductDescription
        /// </summary>
        public static readonly RIProductDescription WindowsAmazonVPC = new RIProductDescription("Windows (Amazon VPC)");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RIProductDescription(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RIProductDescription FindValue(string value)
        {
            return FindValue<RIProductDescription>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RIProductDescription(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RootDeviceType.
    /// </summary>
    public class RootDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant Ebs for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType Ebs = new RootDeviceType("ebs");
        /// <summary>
        /// Constant InstanceStore for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType InstanceStore = new RootDeviceType("instance-store");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RootDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RootDeviceType FindValue(string value)
        {
            return FindValue<RootDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RootDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteOrigin.
    /// </summary>
    public class RouteOrigin : ConstantClass
    {

        /// <summary>
        /// Constant CreateRoute for RouteOrigin
        /// </summary>
        public static readonly RouteOrigin CreateRoute = new RouteOrigin("CreateRoute");
        /// <summary>
        /// Constant CreateRouteTable for RouteOrigin
        /// </summary>
        public static readonly RouteOrigin CreateRouteTable = new RouteOrigin("CreateRouteTable");
        /// <summary>
        /// Constant EnableVgwRoutePropagation for RouteOrigin
        /// </summary>
        public static readonly RouteOrigin EnableVgwRoutePropagation = new RouteOrigin("EnableVgwRoutePropagation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteOrigin FindValue(string value)
        {
            return FindValue<RouteOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteState.
    /// </summary>
    public class RouteState : ConstantClass
    {

        /// <summary>
        /// Constant Active for RouteState
        /// </summary>
        public static readonly RouteState Active = new RouteState("active");
        /// <summary>
        /// Constant Blackhole for RouteState
        /// </summary>
        public static readonly RouteState Blackhole = new RouteState("blackhole");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteState FindValue(string value)
        {
            return FindValue<RouteState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTableAssociationStateCode.
    /// </summary>
    public class RouteTableAssociationStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Associated for RouteTableAssociationStateCode
        /// </summary>
        public static readonly RouteTableAssociationStateCode Associated = new RouteTableAssociationStateCode("associated");
        /// <summary>
        /// Constant Associating for RouteTableAssociationStateCode
        /// </summary>
        public static readonly RouteTableAssociationStateCode Associating = new RouteTableAssociationStateCode("associating");
        /// <summary>
        /// Constant Disassociated for RouteTableAssociationStateCode
        /// </summary>
        public static readonly RouteTableAssociationStateCode Disassociated = new RouteTableAssociationStateCode("disassociated");
        /// <summary>
        /// Constant Disassociating for RouteTableAssociationStateCode
        /// </summary>
        public static readonly RouteTableAssociationStateCode Disassociating = new RouteTableAssociationStateCode("disassociating");
        /// <summary>
        /// Constant Failed for RouteTableAssociationStateCode
        /// </summary>
        public static readonly RouteTableAssociationStateCode Failed = new RouteTableAssociationStateCode("failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTableAssociationStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTableAssociationStateCode FindValue(string value)
        {
            return FindValue<RouteTableAssociationStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTableAssociationStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleAction.
    /// </summary>
    public class RuleAction : ConstantClass
    {

        /// <summary>
        /// Constant Allow for RuleAction
        /// </summary>
        public static readonly RuleAction Allow = new RuleAction("allow");
        /// <summary>
        /// Constant Deny for RuleAction
        /// </summary>
        public static readonly RuleAction Deny = new RuleAction("deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleAction FindValue(string value)
        {
            return FindValue<RuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityZone for Scope
        /// </summary>
        public static readonly Scope AvailabilityZone = new Scope("Availability Zone");
        /// <summary>
        /// Constant Region for Scope
        /// </summary>
        public static readonly Scope Region = new Scope("Region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelfServicePortal.
    /// </summary>
    public class SelfServicePortal : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for SelfServicePortal
        /// </summary>
        public static readonly SelfServicePortal Disabled = new SelfServicePortal("disabled");
        /// <summary>
        /// Constant Enabled for SelfServicePortal
        /// </summary>
        public static readonly SelfServicePortal Enabled = new SelfServicePortal("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelfServicePortal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelfServicePortal FindValue(string value)
        {
            return FindValue<SelfServicePortal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelfServicePortal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceState.
    /// </summary>
    public class ServiceState : ConstantClass
    {

        /// <summary>
        /// Constant Available for ServiceState
        /// </summary>
        public static readonly ServiceState Available = new ServiceState("Available");
        /// <summary>
        /// Constant Deleted for ServiceState
        /// </summary>
        public static readonly ServiceState Deleted = new ServiceState("Deleted");
        /// <summary>
        /// Constant Deleting for ServiceState
        /// </summary>
        public static readonly ServiceState Deleting = new ServiceState("Deleting");
        /// <summary>
        /// Constant Failed for ServiceState
        /// </summary>
        public static readonly ServiceState Failed = new ServiceState("Failed");
        /// <summary>
        /// Constant Pending for ServiceState
        /// </summary>
        public static readonly ServiceState Pending = new ServiceState("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceState FindValue(string value)
        {
            return FindValue<ServiceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceType.
    /// </summary>
    public class ServiceType : ConstantClass
    {

        /// <summary>
        /// Constant Gateway for ServiceType
        /// </summary>
        public static readonly ServiceType Gateway = new ServiceType("Gateway");
        /// <summary>
        /// Constant GatewayLoadBalancer for ServiceType
        /// </summary>
        public static readonly ServiceType GatewayLoadBalancer = new ServiceType("GatewayLoadBalancer");
        /// <summary>
        /// Constant Interface for ServiceType
        /// </summary>
        public static readonly ServiceType Interface = new ServiceType("Interface");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceType FindValue(string value)
        {
            return FindValue<ServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShutdownBehavior.
    /// </summary>
    public class ShutdownBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Stop for ShutdownBehavior
        /// </summary>
        public static readonly ShutdownBehavior Stop = new ShutdownBehavior("stop");
        /// <summary>
        /// Constant Terminate for ShutdownBehavior
        /// </summary>
        public static readonly ShutdownBehavior Terminate = new ShutdownBehavior("terminate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShutdownBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShutdownBehavior FindValue(string value)
        {
            return FindValue<ShutdownBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShutdownBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotAttributeName.
    /// </summary>
    public class SnapshotAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant CreateVolumePermission for SnapshotAttributeName
        /// </summary>
        public static readonly SnapshotAttributeName CreateVolumePermission = new SnapshotAttributeName("createVolumePermission");
        /// <summary>
        /// Constant ProductCodes for SnapshotAttributeName
        /// </summary>
        public static readonly SnapshotAttributeName ProductCodes = new SnapshotAttributeName("productCodes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotAttributeName FindValue(string value)
        {
            return FindValue<SnapshotAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotState.
    /// </summary>
    public class SnapshotState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SnapshotState
        /// </summary>
        public static readonly SnapshotState Completed = new SnapshotState("completed");
        /// <summary>
        /// Constant Error for SnapshotState
        /// </summary>
        public static readonly SnapshotState Error = new SnapshotState("error");
        /// <summary>
        /// Constant Pending for SnapshotState
        /// </summary>
        public static readonly SnapshotState Pending = new SnapshotState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotState FindValue(string value)
        {
            return FindValue<SnapshotState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotAllocationStrategy.
    /// </summary>
    public class SpotAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CapacityOptimized for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy CapacityOptimized = new SpotAllocationStrategy("capacity-optimized");
        /// <summary>
        /// Constant Diversified for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy Diversified = new SpotAllocationStrategy("diversified");
        /// <summary>
        /// Constant LowestPrice for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy LowestPrice = new SpotAllocationStrategy("lowest-price");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotAllocationStrategy FindValue(string value)
        {
            return FindValue<SpotAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotInstanceInterruptionBehavior.
    /// </summary>
    public class SpotInstanceInterruptionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Hibernate for SpotInstanceInterruptionBehavior
        /// </summary>
        public static readonly SpotInstanceInterruptionBehavior Hibernate = new SpotInstanceInterruptionBehavior("hibernate");
        /// <summary>
        /// Constant Stop for SpotInstanceInterruptionBehavior
        /// </summary>
        public static readonly SpotInstanceInterruptionBehavior Stop = new SpotInstanceInterruptionBehavior("stop");
        /// <summary>
        /// Constant Terminate for SpotInstanceInterruptionBehavior
        /// </summary>
        public static readonly SpotInstanceInterruptionBehavior Terminate = new SpotInstanceInterruptionBehavior("terminate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotInstanceInterruptionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceInterruptionBehavior FindValue(string value)
        {
            return FindValue<SpotInstanceInterruptionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotInstanceInterruptionBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotInstanceState.
    /// </summary>
    public class SpotInstanceState : ConstantClass
    {

        /// <summary>
        /// Constant Active for SpotInstanceState
        /// </summary>
        public static readonly SpotInstanceState Active = new SpotInstanceState("active");
        /// <summary>
        /// Constant Cancelled for SpotInstanceState
        /// </summary>
        public static readonly SpotInstanceState Cancelled = new SpotInstanceState("cancelled");
        /// <summary>
        /// Constant Closed for SpotInstanceState
        /// </summary>
        public static readonly SpotInstanceState Closed = new SpotInstanceState("closed");
        /// <summary>
        /// Constant Failed for SpotInstanceState
        /// </summary>
        public static readonly SpotInstanceState Failed = new SpotInstanceState("failed");
        /// <summary>
        /// Constant Open for SpotInstanceState
        /// </summary>
        public static readonly SpotInstanceState Open = new SpotInstanceState("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotInstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceState FindValue(string value)
        {
            return FindValue<SpotInstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotInstanceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotInstanceType.
    /// </summary>
    public class SpotInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant OneTime for SpotInstanceType
        /// </summary>
        public static readonly SpotInstanceType OneTime = new SpotInstanceType("one-time");
        /// <summary>
        /// Constant Persistent for SpotInstanceType
        /// </summary>
        public static readonly SpotInstanceType Persistent = new SpotInstanceType("persistent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceType FindValue(string value)
        {
            return FindValue<SpotInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant Available for State
        /// </summary>
        public static readonly State Available = new State("Available");
        /// <summary>
        /// Constant Deleted for State
        /// </summary>
        public static readonly State Deleted = new State("Deleted");
        /// <summary>
        /// Constant Deleting for State
        /// </summary>
        public static readonly State Deleting = new State("Deleting");
        /// <summary>
        /// Constant Expired for State
        /// </summary>
        public static readonly State Expired = new State("Expired");
        /// <summary>
        /// Constant Failed for State
        /// </summary>
        public static readonly State Failed = new State("Failed");
        /// <summary>
        /// Constant Pending for State
        /// </summary>
        public static readonly State Pending = new State("Pending");
        /// <summary>
        /// Constant PendingAcceptance for State
        /// </summary>
        public static readonly State PendingAcceptance = new State("PendingAcceptance");
        /// <summary>
        /// Constant Rejected for State
        /// </summary>
        public static readonly State Rejected = new State("Rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StaticSourcesSupportValue.
    /// </summary>
    public class StaticSourcesSupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for StaticSourcesSupportValue
        /// </summary>
        public static readonly StaticSourcesSupportValue Disable = new StaticSourcesSupportValue("disable");
        /// <summary>
        /// Constant Enable for StaticSourcesSupportValue
        /// </summary>
        public static readonly StaticSourcesSupportValue Enable = new StaticSourcesSupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StaticSourcesSupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StaticSourcesSupportValue FindValue(string value)
        {
            return FindValue<StaticSourcesSupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StaticSourcesSupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant InClassic for Status
        /// </summary>
        public static readonly Status InClassic = new Status("InClassic");
        /// <summary>
        /// Constant InVpc for Status
        /// </summary>
        public static readonly Status InVpc = new Status("InVpc");
        /// <summary>
        /// Constant MoveInProgress for Status
        /// </summary>
        public static readonly Status MoveInProgress = new Status("MoveInProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusName.
    /// </summary>
    public class StatusName : ConstantClass
    {

        /// <summary>
        /// Constant Reachability for StatusName
        /// </summary>
        public static readonly StatusName Reachability = new StatusName("reachability");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusName FindValue(string value)
        {
            return FindValue<StatusName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StatusType
        /// </summary>
        public static readonly StatusType Failed = new StatusType("failed");
        /// <summary>
        /// Constant Initializing for StatusType
        /// </summary>
        public static readonly StatusType Initializing = new StatusType("initializing");
        /// <summary>
        /// Constant InsufficientData for StatusType
        /// </summary>
        public static readonly StatusType InsufficientData = new StatusType("insufficient-data");
        /// <summary>
        /// Constant Passed for StatusType
        /// </summary>
        public static readonly StatusType Passed = new StatusType("passed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubnetCidrBlockStateCode.
    /// </summary>
    public class SubnetCidrBlockStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Associated for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Associated = new SubnetCidrBlockStateCode("associated");
        /// <summary>
        /// Constant Associating for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Associating = new SubnetCidrBlockStateCode("associating");
        /// <summary>
        /// Constant Disassociated for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Disassociated = new SubnetCidrBlockStateCode("disassociated");
        /// <summary>
        /// Constant Disassociating for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Disassociating = new SubnetCidrBlockStateCode("disassociating");
        /// <summary>
        /// Constant Failed for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Failed = new SubnetCidrBlockStateCode("failed");
        /// <summary>
        /// Constant Failing for SubnetCidrBlockStateCode
        /// </summary>
        public static readonly SubnetCidrBlockStateCode Failing = new SubnetCidrBlockStateCode("failing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubnetCidrBlockStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubnetCidrBlockStateCode FindValue(string value)
        {
            return FindValue<SubnetCidrBlockStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubnetCidrBlockStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubnetState.
    /// </summary>
    public class SubnetState : ConstantClass
    {

        /// <summary>
        /// Constant Available for SubnetState
        /// </summary>
        public static readonly SubnetState Available = new SubnetState("available");
        /// <summary>
        /// Constant Pending for SubnetState
        /// </summary>
        public static readonly SubnetState Pending = new SubnetState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubnetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubnetState FindValue(string value)
        {
            return FindValue<SubnetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubnetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryStatus.
    /// </summary>
    public class SummaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Impaired for SummaryStatus
        /// </summary>
        public static readonly SummaryStatus Impaired = new SummaryStatus("impaired");
        /// <summary>
        /// Constant Initializing for SummaryStatus
        /// </summary>
        public static readonly SummaryStatus Initializing = new SummaryStatus("initializing");
        /// <summary>
        /// Constant InsufficientData for SummaryStatus
        /// </summary>
        public static readonly SummaryStatus InsufficientData = new SummaryStatus("insufficient-data");
        /// <summary>
        /// Constant NotApplicable for SummaryStatus
        /// </summary>
        public static readonly SummaryStatus NotApplicable = new SummaryStatus("not-applicable");
        /// <summary>
        /// Constant Ok for SummaryStatus
        /// </summary>
        public static readonly SummaryStatus Ok = new SummaryStatus("ok");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SummaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryStatus FindValue(string value)
        {
            return FindValue<SummaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetryStatus.
    /// </summary>
    public class TelemetryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DOWN for TelemetryStatus
        /// </summary>
        public static readonly TelemetryStatus DOWN = new TelemetryStatus("DOWN");
        /// <summary>
        /// Constant UP for TelemetryStatus
        /// </summary>
        public static readonly TelemetryStatus UP = new TelemetryStatus("UP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryStatus FindValue(string value)
        {
            return FindValue<TelemetryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tenancy.
    /// </summary>
    public class Tenancy : ConstantClass
    {

        /// <summary>
        /// Constant Dedicated for Tenancy
        /// </summary>
        public static readonly Tenancy Dedicated = new Tenancy("dedicated");
        /// <summary>
        /// Constant Default for Tenancy
        /// </summary>
        public static readonly Tenancy Default = new Tenancy("default");
        /// <summary>
        /// Constant Host for Tenancy
        /// </summary>
        public static readonly Tenancy Host = new Tenancy("host");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tenancy FindValue(string value)
        {
            return FindValue<Tenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficDirection.
    /// </summary>
    public class TrafficDirection : ConstantClass
    {

        /// <summary>
        /// Constant Egress for TrafficDirection
        /// </summary>
        public static readonly TrafficDirection Egress = new TrafficDirection("egress");
        /// <summary>
        /// Constant Ingress for TrafficDirection
        /// </summary>
        public static readonly TrafficDirection Ingress = new TrafficDirection("ingress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficDirection FindValue(string value)
        {
            return FindValue<TrafficDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficMirrorFilterRuleField.
    /// </summary>
    public class TrafficMirrorFilterRuleField : ConstantClass
    {

        /// <summary>
        /// Constant Description for TrafficMirrorFilterRuleField
        /// </summary>
        public static readonly TrafficMirrorFilterRuleField Description = new TrafficMirrorFilterRuleField("description");
        /// <summary>
        /// Constant DestinationPortRange for TrafficMirrorFilterRuleField
        /// </summary>
        public static readonly TrafficMirrorFilterRuleField DestinationPortRange = new TrafficMirrorFilterRuleField("destination-port-range");
        /// <summary>
        /// Constant Protocol for TrafficMirrorFilterRuleField
        /// </summary>
        public static readonly TrafficMirrorFilterRuleField Protocol = new TrafficMirrorFilterRuleField("protocol");
        /// <summary>
        /// Constant SourcePortRange for TrafficMirrorFilterRuleField
        /// </summary>
        public static readonly TrafficMirrorFilterRuleField SourcePortRange = new TrafficMirrorFilterRuleField("source-port-range");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficMirrorFilterRuleField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficMirrorFilterRuleField FindValue(string value)
        {
            return FindValue<TrafficMirrorFilterRuleField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficMirrorFilterRuleField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficMirrorNetworkService.
    /// </summary>
    public class TrafficMirrorNetworkService : ConstantClass
    {

        /// <summary>
        /// Constant AmazonDns for TrafficMirrorNetworkService
        /// </summary>
        public static readonly TrafficMirrorNetworkService AmazonDns = new TrafficMirrorNetworkService("amazon-dns");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficMirrorNetworkService(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficMirrorNetworkService FindValue(string value)
        {
            return FindValue<TrafficMirrorNetworkService>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficMirrorNetworkService(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficMirrorRuleAction.
    /// </summary>
    public class TrafficMirrorRuleAction : ConstantClass
    {

        /// <summary>
        /// Constant Accept for TrafficMirrorRuleAction
        /// </summary>
        public static readonly TrafficMirrorRuleAction Accept = new TrafficMirrorRuleAction("accept");
        /// <summary>
        /// Constant Reject for TrafficMirrorRuleAction
        /// </summary>
        public static readonly TrafficMirrorRuleAction Reject = new TrafficMirrorRuleAction("reject");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficMirrorRuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficMirrorRuleAction FindValue(string value)
        {
            return FindValue<TrafficMirrorRuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficMirrorRuleAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficMirrorSessionField.
    /// </summary>
    public class TrafficMirrorSessionField : ConstantClass
    {

        /// <summary>
        /// Constant Description for TrafficMirrorSessionField
        /// </summary>
        public static readonly TrafficMirrorSessionField Description = new TrafficMirrorSessionField("description");
        /// <summary>
        /// Constant PacketLength for TrafficMirrorSessionField
        /// </summary>
        public static readonly TrafficMirrorSessionField PacketLength = new TrafficMirrorSessionField("packet-length");
        /// <summary>
        /// Constant VirtualNetworkId for TrafficMirrorSessionField
        /// </summary>
        public static readonly TrafficMirrorSessionField VirtualNetworkId = new TrafficMirrorSessionField("virtual-network-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficMirrorSessionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficMirrorSessionField FindValue(string value)
        {
            return FindValue<TrafficMirrorSessionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficMirrorSessionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficMirrorTargetType.
    /// </summary>
    public class TrafficMirrorTargetType : ConstantClass
    {

        /// <summary>
        /// Constant NetworkInterface for TrafficMirrorTargetType
        /// </summary>
        public static readonly TrafficMirrorTargetType NetworkInterface = new TrafficMirrorTargetType("network-interface");
        /// <summary>
        /// Constant NetworkLoadBalancer for TrafficMirrorTargetType
        /// </summary>
        public static readonly TrafficMirrorTargetType NetworkLoadBalancer = new TrafficMirrorTargetType("network-load-balancer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficMirrorTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficMirrorTargetType FindValue(string value)
        {
            return FindValue<TrafficMirrorTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficMirrorTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficType.
    /// </summary>
    public class TrafficType : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for TrafficType
        /// </summary>
        public static readonly TrafficType ACCEPT = new TrafficType("ACCEPT");
        /// <summary>
        /// Constant ALL for TrafficType
        /// </summary>
        public static readonly TrafficType ALL = new TrafficType("ALL");
        /// <summary>
        /// Constant REJECT for TrafficType
        /// </summary>
        public static readonly TrafficType REJECT = new TrafficType("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficType FindValue(string value)
        {
            return FindValue<TrafficType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayAssociationState.
    /// </summary>
    public class TransitGatewayAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant Associated for TransitGatewayAssociationState
        /// </summary>
        public static readonly TransitGatewayAssociationState Associated = new TransitGatewayAssociationState("associated");
        /// <summary>
        /// Constant Associating for TransitGatewayAssociationState
        /// </summary>
        public static readonly TransitGatewayAssociationState Associating = new TransitGatewayAssociationState("associating");
        /// <summary>
        /// Constant Disassociated for TransitGatewayAssociationState
        /// </summary>
        public static readonly TransitGatewayAssociationState Disassociated = new TransitGatewayAssociationState("disassociated");
        /// <summary>
        /// Constant Disassociating for TransitGatewayAssociationState
        /// </summary>
        public static readonly TransitGatewayAssociationState Disassociating = new TransitGatewayAssociationState("disassociating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayAssociationState FindValue(string value)
        {
            return FindValue<TransitGatewayAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayAttachmentResourceType.
    /// </summary>
    public class TransitGatewayAttachmentResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Connect for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType Connect = new TransitGatewayAttachmentResourceType("connect");
        /// <summary>
        /// Constant DirectConnectGateway for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType DirectConnectGateway = new TransitGatewayAttachmentResourceType("direct-connect-gateway");
        /// <summary>
        /// Constant Peering for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType Peering = new TransitGatewayAttachmentResourceType("peering");
        /// <summary>
        /// Constant TgwPeering for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType TgwPeering = new TransitGatewayAttachmentResourceType("tgw-peering");
        /// <summary>
        /// Constant Vpc for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType Vpc = new TransitGatewayAttachmentResourceType("vpc");
        /// <summary>
        /// Constant Vpn for TransitGatewayAttachmentResourceType
        /// </summary>
        public static readonly TransitGatewayAttachmentResourceType Vpn = new TransitGatewayAttachmentResourceType("vpn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayAttachmentResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayAttachmentResourceType FindValue(string value)
        {
            return FindValue<TransitGatewayAttachmentResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayAttachmentResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayAttachmentState.
    /// </summary>
    public class TransitGatewayAttachmentState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Available = new TransitGatewayAttachmentState("available");
        /// <summary>
        /// Constant Deleted for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Deleted = new TransitGatewayAttachmentState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Deleting = new TransitGatewayAttachmentState("deleting");
        /// <summary>
        /// Constant Failed for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Failed = new TransitGatewayAttachmentState("failed");
        /// <summary>
        /// Constant Failing for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Failing = new TransitGatewayAttachmentState("failing");
        /// <summary>
        /// Constant Initiating for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Initiating = new TransitGatewayAttachmentState("initiating");
        /// <summary>
        /// Constant InitiatingRequest for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState InitiatingRequest = new TransitGatewayAttachmentState("initiatingRequest");
        /// <summary>
        /// Constant Modifying for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Modifying = new TransitGatewayAttachmentState("modifying");
        /// <summary>
        /// Constant Pending for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Pending = new TransitGatewayAttachmentState("pending");
        /// <summary>
        /// Constant PendingAcceptance for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState PendingAcceptance = new TransitGatewayAttachmentState("pendingAcceptance");
        /// <summary>
        /// Constant Rejected for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Rejected = new TransitGatewayAttachmentState("rejected");
        /// <summary>
        /// Constant Rejecting for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState Rejecting = new TransitGatewayAttachmentState("rejecting");
        /// <summary>
        /// Constant RollingBack for TransitGatewayAttachmentState
        /// </summary>
        public static readonly TransitGatewayAttachmentState RollingBack = new TransitGatewayAttachmentState("rollingBack");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayAttachmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayAttachmentState FindValue(string value)
        {
            return FindValue<TransitGatewayAttachmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayAttachmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayConnectPeerState.
    /// </summary>
    public class TransitGatewayConnectPeerState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayConnectPeerState
        /// </summary>
        public static readonly TransitGatewayConnectPeerState Available = new TransitGatewayConnectPeerState("available");
        /// <summary>
        /// Constant Deleted for TransitGatewayConnectPeerState
        /// </summary>
        public static readonly TransitGatewayConnectPeerState Deleted = new TransitGatewayConnectPeerState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayConnectPeerState
        /// </summary>
        public static readonly TransitGatewayConnectPeerState Deleting = new TransitGatewayConnectPeerState("deleting");
        /// <summary>
        /// Constant Pending for TransitGatewayConnectPeerState
        /// </summary>
        public static readonly TransitGatewayConnectPeerState Pending = new TransitGatewayConnectPeerState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayConnectPeerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayConnectPeerState FindValue(string value)
        {
            return FindValue<TransitGatewayConnectPeerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayConnectPeerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayMulitcastDomainAssociationState.
    /// </summary>
    public class TransitGatewayMulitcastDomainAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant Associated for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Associated = new TransitGatewayMulitcastDomainAssociationState("associated");
        /// <summary>
        /// Constant Associating for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Associating = new TransitGatewayMulitcastDomainAssociationState("associating");
        /// <summary>
        /// Constant Disassociated for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Disassociated = new TransitGatewayMulitcastDomainAssociationState("disassociated");
        /// <summary>
        /// Constant Disassociating for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Disassociating = new TransitGatewayMulitcastDomainAssociationState("disassociating");
        /// <summary>
        /// Constant Failed for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Failed = new TransitGatewayMulitcastDomainAssociationState("failed");
        /// <summary>
        /// Constant PendingAcceptance for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState PendingAcceptance = new TransitGatewayMulitcastDomainAssociationState("pendingAcceptance");
        /// <summary>
        /// Constant Rejected for TransitGatewayMulitcastDomainAssociationState
        /// </summary>
        public static readonly TransitGatewayMulitcastDomainAssociationState Rejected = new TransitGatewayMulitcastDomainAssociationState("rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayMulitcastDomainAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayMulitcastDomainAssociationState FindValue(string value)
        {
            return FindValue<TransitGatewayMulitcastDomainAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayMulitcastDomainAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayMulticastDomainState.
    /// </summary>
    public class TransitGatewayMulticastDomainState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayMulticastDomainState
        /// </summary>
        public static readonly TransitGatewayMulticastDomainState Available = new TransitGatewayMulticastDomainState("available");
        /// <summary>
        /// Constant Deleted for TransitGatewayMulticastDomainState
        /// </summary>
        public static readonly TransitGatewayMulticastDomainState Deleted = new TransitGatewayMulticastDomainState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayMulticastDomainState
        /// </summary>
        public static readonly TransitGatewayMulticastDomainState Deleting = new TransitGatewayMulticastDomainState("deleting");
        /// <summary>
        /// Constant Pending for TransitGatewayMulticastDomainState
        /// </summary>
        public static readonly TransitGatewayMulticastDomainState Pending = new TransitGatewayMulticastDomainState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayMulticastDomainState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayMulticastDomainState FindValue(string value)
        {
            return FindValue<TransitGatewayMulticastDomainState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayMulticastDomainState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayPrefixListReferenceState.
    /// </summary>
    public class TransitGatewayPrefixListReferenceState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayPrefixListReferenceState
        /// </summary>
        public static readonly TransitGatewayPrefixListReferenceState Available = new TransitGatewayPrefixListReferenceState("available");
        /// <summary>
        /// Constant Deleting for TransitGatewayPrefixListReferenceState
        /// </summary>
        public static readonly TransitGatewayPrefixListReferenceState Deleting = new TransitGatewayPrefixListReferenceState("deleting");
        /// <summary>
        /// Constant Modifying for TransitGatewayPrefixListReferenceState
        /// </summary>
        public static readonly TransitGatewayPrefixListReferenceState Modifying = new TransitGatewayPrefixListReferenceState("modifying");
        /// <summary>
        /// Constant Pending for TransitGatewayPrefixListReferenceState
        /// </summary>
        public static readonly TransitGatewayPrefixListReferenceState Pending = new TransitGatewayPrefixListReferenceState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayPrefixListReferenceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayPrefixListReferenceState FindValue(string value)
        {
            return FindValue<TransitGatewayPrefixListReferenceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayPrefixListReferenceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayPropagationState.
    /// </summary>
    public class TransitGatewayPropagationState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for TransitGatewayPropagationState
        /// </summary>
        public static readonly TransitGatewayPropagationState Disabled = new TransitGatewayPropagationState("disabled");
        /// <summary>
        /// Constant Disabling for TransitGatewayPropagationState
        /// </summary>
        public static readonly TransitGatewayPropagationState Disabling = new TransitGatewayPropagationState("disabling");
        /// <summary>
        /// Constant Enabled for TransitGatewayPropagationState
        /// </summary>
        public static readonly TransitGatewayPropagationState Enabled = new TransitGatewayPropagationState("enabled");
        /// <summary>
        /// Constant Enabling for TransitGatewayPropagationState
        /// </summary>
        public static readonly TransitGatewayPropagationState Enabling = new TransitGatewayPropagationState("enabling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayPropagationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayPropagationState FindValue(string value)
        {
            return FindValue<TransitGatewayPropagationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayPropagationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayRouteState.
    /// </summary>
    public class TransitGatewayRouteState : ConstantClass
    {

        /// <summary>
        /// Constant Active for TransitGatewayRouteState
        /// </summary>
        public static readonly TransitGatewayRouteState Active = new TransitGatewayRouteState("active");
        /// <summary>
        /// Constant Blackhole for TransitGatewayRouteState
        /// </summary>
        public static readonly TransitGatewayRouteState Blackhole = new TransitGatewayRouteState("blackhole");
        /// <summary>
        /// Constant Deleted for TransitGatewayRouteState
        /// </summary>
        public static readonly TransitGatewayRouteState Deleted = new TransitGatewayRouteState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayRouteState
        /// </summary>
        public static readonly TransitGatewayRouteState Deleting = new TransitGatewayRouteState("deleting");
        /// <summary>
        /// Constant Pending for TransitGatewayRouteState
        /// </summary>
        public static readonly TransitGatewayRouteState Pending = new TransitGatewayRouteState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayRouteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayRouteState FindValue(string value)
        {
            return FindValue<TransitGatewayRouteState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayRouteState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayRouteTableState.
    /// </summary>
    public class TransitGatewayRouteTableState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayRouteTableState
        /// </summary>
        public static readonly TransitGatewayRouteTableState Available = new TransitGatewayRouteTableState("available");
        /// <summary>
        /// Constant Deleted for TransitGatewayRouteTableState
        /// </summary>
        public static readonly TransitGatewayRouteTableState Deleted = new TransitGatewayRouteTableState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayRouteTableState
        /// </summary>
        public static readonly TransitGatewayRouteTableState Deleting = new TransitGatewayRouteTableState("deleting");
        /// <summary>
        /// Constant Pending for TransitGatewayRouteTableState
        /// </summary>
        public static readonly TransitGatewayRouteTableState Pending = new TransitGatewayRouteTableState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayRouteTableState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayRouteTableState FindValue(string value)
        {
            return FindValue<TransitGatewayRouteTableState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayRouteTableState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayRouteType.
    /// </summary>
    public class TransitGatewayRouteType : ConstantClass
    {

        /// <summary>
        /// Constant Propagated for TransitGatewayRouteType
        /// </summary>
        public static readonly TransitGatewayRouteType Propagated = new TransitGatewayRouteType("propagated");
        /// <summary>
        /// Constant Static for TransitGatewayRouteType
        /// </summary>
        public static readonly TransitGatewayRouteType Static = new TransitGatewayRouteType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayRouteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayRouteType FindValue(string value)
        {
            return FindValue<TransitGatewayRouteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayRouteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayState.
    /// </summary>
    public class TransitGatewayState : ConstantClass
    {

        /// <summary>
        /// Constant Available for TransitGatewayState
        /// </summary>
        public static readonly TransitGatewayState Available = new TransitGatewayState("available");
        /// <summary>
        /// Constant Deleted for TransitGatewayState
        /// </summary>
        public static readonly TransitGatewayState Deleted = new TransitGatewayState("deleted");
        /// <summary>
        /// Constant Deleting for TransitGatewayState
        /// </summary>
        public static readonly TransitGatewayState Deleting = new TransitGatewayState("deleting");
        /// <summary>
        /// Constant Modifying for TransitGatewayState
        /// </summary>
        public static readonly TransitGatewayState Modifying = new TransitGatewayState("modifying");
        /// <summary>
        /// Constant Pending for TransitGatewayState
        /// </summary>
        public static readonly TransitGatewayState Pending = new TransitGatewayState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayState FindValue(string value)
        {
            return FindValue<TransitGatewayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransportProtocol.
    /// </summary>
    public class TransportProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Tcp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Tcp = new TransportProtocol("tcp");
        /// <summary>
        /// Constant Udp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Udp = new TransportProtocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransportProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransportProtocol FindValue(string value)
        {
            return FindValue<TransportProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransportProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TunnelInsideIpVersion.
    /// </summary>
    public class TunnelInsideIpVersion : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for TunnelInsideIpVersion
        /// </summary>
        public static readonly TunnelInsideIpVersion Ipv4 = new TunnelInsideIpVersion("ipv4");
        /// <summary>
        /// Constant Ipv6 for TunnelInsideIpVersion
        /// </summary>
        public static readonly TunnelInsideIpVersion Ipv6 = new TunnelInsideIpVersion("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TunnelInsideIpVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TunnelInsideIpVersion FindValue(string value)
        {
            return FindValue<TunnelInsideIpVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TunnelInsideIpVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnlimitedSupportedInstanceFamily.
    /// </summary>
    public class UnlimitedSupportedInstanceFamily : ConstantClass
    {

        /// <summary>
        /// Constant T2 for UnlimitedSupportedInstanceFamily
        /// </summary>
        public static readonly UnlimitedSupportedInstanceFamily T2 = new UnlimitedSupportedInstanceFamily("t2");
        /// <summary>
        /// Constant T3 for UnlimitedSupportedInstanceFamily
        /// </summary>
        public static readonly UnlimitedSupportedInstanceFamily T3 = new UnlimitedSupportedInstanceFamily("t3");
        /// <summary>
        /// Constant T3a for UnlimitedSupportedInstanceFamily
        /// </summary>
        public static readonly UnlimitedSupportedInstanceFamily T3a = new UnlimitedSupportedInstanceFamily("t3a");
        /// <summary>
        /// Constant T4g for UnlimitedSupportedInstanceFamily
        /// </summary>
        public static readonly UnlimitedSupportedInstanceFamily T4g = new UnlimitedSupportedInstanceFamily("t4g");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnlimitedSupportedInstanceFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnlimitedSupportedInstanceFamily FindValue(string value)
        {
            return FindValue<UnlimitedSupportedInstanceFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnlimitedSupportedInstanceFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnsuccessfulInstanceCreditSpecificationErrorCode.
    /// </summary>
    public class UnsuccessfulInstanceCreditSpecificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant IncorrectInstanceState for UnsuccessfulInstanceCreditSpecificationErrorCode
        /// </summary>
        public static readonly UnsuccessfulInstanceCreditSpecificationErrorCode IncorrectInstanceState = new UnsuccessfulInstanceCreditSpecificationErrorCode("IncorrectInstanceState");
        /// <summary>
        /// Constant InstanceCreditSpecificationNotSupported for UnsuccessfulInstanceCreditSpecificationErrorCode
        /// </summary>
        public static readonly UnsuccessfulInstanceCreditSpecificationErrorCode InstanceCreditSpecificationNotSupported = new UnsuccessfulInstanceCreditSpecificationErrorCode("InstanceCreditSpecification.NotSupported");
        /// <summary>
        /// Constant InvalidInstanceIDMalformed for UnsuccessfulInstanceCreditSpecificationErrorCode
        /// </summary>
        public static readonly UnsuccessfulInstanceCreditSpecificationErrorCode InvalidInstanceIDMalformed = new UnsuccessfulInstanceCreditSpecificationErrorCode("InvalidInstanceID.Malformed");
        /// <summary>
        /// Constant InvalidInstanceIDNotFound for UnsuccessfulInstanceCreditSpecificationErrorCode
        /// </summary>
        public static readonly UnsuccessfulInstanceCreditSpecificationErrorCode InvalidInstanceIDNotFound = new UnsuccessfulInstanceCreditSpecificationErrorCode("InvalidInstanceID.NotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnsuccessfulInstanceCreditSpecificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnsuccessfulInstanceCreditSpecificationErrorCode FindValue(string value)
        {
            return FindValue<UnsuccessfulInstanceCreditSpecificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnsuccessfulInstanceCreditSpecificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageClassType.
    /// </summary>
    public class UsageClassType : ConstantClass
    {

        /// <summary>
        /// Constant OnDemand for UsageClassType
        /// </summary>
        public static readonly UsageClassType OnDemand = new UsageClassType("on-demand");
        /// <summary>
        /// Constant Spot for UsageClassType
        /// </summary>
        public static readonly UsageClassType Spot = new UsageClassType("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageClassType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageClassType FindValue(string value)
        {
            return FindValue<UsageClassType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageClassType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualizationType.
    /// </summary>
    public class VirtualizationType : ConstantClass
    {

        /// <summary>
        /// Constant Hvm for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Hvm = new VirtualizationType("hvm");
        /// <summary>
        /// Constant Paravirtual for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Paravirtual = new VirtualizationType("paravirtual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualizationType FindValue(string value)
        {
            return FindValue<VirtualizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeAttachmentState.
    /// </summary>
    public class VolumeAttachmentState : ConstantClass
    {

        /// <summary>
        /// Constant Attached for VolumeAttachmentState
        /// </summary>
        public static readonly VolumeAttachmentState Attached = new VolumeAttachmentState("attached");
        /// <summary>
        /// Constant Attaching for VolumeAttachmentState
        /// </summary>
        public static readonly VolumeAttachmentState Attaching = new VolumeAttachmentState("attaching");
        /// <summary>
        /// Constant Busy for VolumeAttachmentState
        /// </summary>
        public static readonly VolumeAttachmentState Busy = new VolumeAttachmentState("busy");
        /// <summary>
        /// Constant Detached for VolumeAttachmentState
        /// </summary>
        public static readonly VolumeAttachmentState Detached = new VolumeAttachmentState("detached");
        /// <summary>
        /// Constant Detaching for VolumeAttachmentState
        /// </summary>
        public static readonly VolumeAttachmentState Detaching = new VolumeAttachmentState("detaching");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeAttachmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeAttachmentState FindValue(string value)
        {
            return FindValue<VolumeAttachmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeAttachmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeAttributeName.
    /// </summary>
    public class VolumeAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant AutoEnableIO for VolumeAttributeName
        /// </summary>
        public static readonly VolumeAttributeName AutoEnableIO = new VolumeAttributeName("autoEnableIO");
        /// <summary>
        /// Constant ProductCodes for VolumeAttributeName
        /// </summary>
        public static readonly VolumeAttributeName ProductCodes = new VolumeAttributeName("productCodes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeAttributeName FindValue(string value)
        {
            return FindValue<VolumeAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeModificationState.
    /// </summary>
    public class VolumeModificationState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for VolumeModificationState
        /// </summary>
        public static readonly VolumeModificationState Completed = new VolumeModificationState("completed");
        /// <summary>
        /// Constant Failed for VolumeModificationState
        /// </summary>
        public static readonly VolumeModificationState Failed = new VolumeModificationState("failed");
        /// <summary>
        /// Constant Modifying for VolumeModificationState
        /// </summary>
        public static readonly VolumeModificationState Modifying = new VolumeModificationState("modifying");
        /// <summary>
        /// Constant Optimizing for VolumeModificationState
        /// </summary>
        public static readonly VolumeModificationState Optimizing = new VolumeModificationState("optimizing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeModificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeModificationState FindValue(string value)
        {
            return FindValue<VolumeModificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeModificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeState.
    /// </summary>
    public class VolumeState : ConstantClass
    {

        /// <summary>
        /// Constant Available for VolumeState
        /// </summary>
        public static readonly VolumeState Available = new VolumeState("available");
        /// <summary>
        /// Constant Creating for VolumeState
        /// </summary>
        public static readonly VolumeState Creating = new VolumeState("creating");
        /// <summary>
        /// Constant Deleted for VolumeState
        /// </summary>
        public static readonly VolumeState Deleted = new VolumeState("deleted");
        /// <summary>
        /// Constant Deleting for VolumeState
        /// </summary>
        public static readonly VolumeState Deleting = new VolumeState("deleting");
        /// <summary>
        /// Constant Error for VolumeState
        /// </summary>
        public static readonly VolumeState Error = new VolumeState("error");
        /// <summary>
        /// Constant InUse for VolumeState
        /// </summary>
        public static readonly VolumeState InUse = new VolumeState("in-use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeState FindValue(string value)
        {
            return FindValue<VolumeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeStatusInfoStatus.
    /// </summary>
    public class VolumeStatusInfoStatus : ConstantClass
    {

        /// <summary>
        /// Constant Impaired for VolumeStatusInfoStatus
        /// </summary>
        public static readonly VolumeStatusInfoStatus Impaired = new VolumeStatusInfoStatus("impaired");
        /// <summary>
        /// Constant InsufficientData for VolumeStatusInfoStatus
        /// </summary>
        public static readonly VolumeStatusInfoStatus InsufficientData = new VolumeStatusInfoStatus("insufficient-data");
        /// <summary>
        /// Constant Ok for VolumeStatusInfoStatus
        /// </summary>
        public static readonly VolumeStatusInfoStatus Ok = new VolumeStatusInfoStatus("ok");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeStatusInfoStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStatusInfoStatus FindValue(string value)
        {
            return FindValue<VolumeStatusInfoStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeStatusInfoStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeStatusName.
    /// </summary>
    public class VolumeStatusName : ConstantClass
    {

        /// <summary>
        /// Constant IoEnabled for VolumeStatusName
        /// </summary>
        public static readonly VolumeStatusName IoEnabled = new VolumeStatusName("io-enabled");
        /// <summary>
        /// Constant IoPerformance for VolumeStatusName
        /// </summary>
        public static readonly VolumeStatusName IoPerformance = new VolumeStatusName("io-performance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeStatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStatusName FindValue(string value)
        {
            return FindValue<VolumeStatusName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeStatusName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Gp3 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp3 = new VolumeType("gp3");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Io2 for VolumeType
        /// </summary>
        public static readonly VolumeType Io2 = new VolumeType("io2");
        /// <summary>
        /// Constant Sc1 for VolumeType
        /// </summary>
        public static readonly VolumeType Sc1 = new VolumeType("sc1");
        /// <summary>
        /// Constant St1 for VolumeType
        /// </summary>
        public static readonly VolumeType St1 = new VolumeType("st1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcAttributeName.
    /// </summary>
    public class VpcAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant EnableDnsHostnames for VpcAttributeName
        /// </summary>
        public static readonly VpcAttributeName EnableDnsHostnames = new VpcAttributeName("enableDnsHostnames");
        /// <summary>
        /// Constant EnableDnsSupport for VpcAttributeName
        /// </summary>
        public static readonly VpcAttributeName EnableDnsSupport = new VpcAttributeName("enableDnsSupport");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcAttributeName FindValue(string value)
        {
            return FindValue<VpcAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcCidrBlockStateCode.
    /// </summary>
    public class VpcCidrBlockStateCode : ConstantClass
    {

        /// <summary>
        /// Constant Associated for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Associated = new VpcCidrBlockStateCode("associated");
        /// <summary>
        /// Constant Associating for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Associating = new VpcCidrBlockStateCode("associating");
        /// <summary>
        /// Constant Disassociated for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Disassociated = new VpcCidrBlockStateCode("disassociated");
        /// <summary>
        /// Constant Disassociating for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Disassociating = new VpcCidrBlockStateCode("disassociating");
        /// <summary>
        /// Constant Failed for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Failed = new VpcCidrBlockStateCode("failed");
        /// <summary>
        /// Constant Failing for VpcCidrBlockStateCode
        /// </summary>
        public static readonly VpcCidrBlockStateCode Failing = new VpcCidrBlockStateCode("failing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcCidrBlockStateCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcCidrBlockStateCode FindValue(string value)
        {
            return FindValue<VpcCidrBlockStateCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcCidrBlockStateCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointType.
    /// </summary>
    public class VpcEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant Gateway for VpcEndpointType
        /// </summary>
        public static readonly VpcEndpointType Gateway = new VpcEndpointType("Gateway");
        /// <summary>
        /// Constant GatewayLoadBalancer for VpcEndpointType
        /// </summary>
        public static readonly VpcEndpointType GatewayLoadBalancer = new VpcEndpointType("GatewayLoadBalancer");
        /// <summary>
        /// Constant Interface for VpcEndpointType
        /// </summary>
        public static readonly VpcEndpointType Interface = new VpcEndpointType("Interface");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointType FindValue(string value)
        {
            return FindValue<VpcEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcPeeringConnectionStateReasonCode.
    /// </summary>
    public class VpcPeeringConnectionStateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant Active for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Active = new VpcPeeringConnectionStateReasonCode("active");
        /// <summary>
        /// Constant Deleted for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Deleted = new VpcPeeringConnectionStateReasonCode("deleted");
        /// <summary>
        /// Constant Deleting for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Deleting = new VpcPeeringConnectionStateReasonCode("deleting");
        /// <summary>
        /// Constant Expired for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Expired = new VpcPeeringConnectionStateReasonCode("expired");
        /// <summary>
        /// Constant Failed for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Failed = new VpcPeeringConnectionStateReasonCode("failed");
        /// <summary>
        /// Constant InitiatingRequest for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode InitiatingRequest = new VpcPeeringConnectionStateReasonCode("initiating-request");
        /// <summary>
        /// Constant PendingAcceptance for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode PendingAcceptance = new VpcPeeringConnectionStateReasonCode("pending-acceptance");
        /// <summary>
        /// Constant Provisioning for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Provisioning = new VpcPeeringConnectionStateReasonCode("provisioning");
        /// <summary>
        /// Constant Rejected for VpcPeeringConnectionStateReasonCode
        /// </summary>
        public static readonly VpcPeeringConnectionStateReasonCode Rejected = new VpcPeeringConnectionStateReasonCode("rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcPeeringConnectionStateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcPeeringConnectionStateReasonCode FindValue(string value)
        {
            return FindValue<VpcPeeringConnectionStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcPeeringConnectionStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcState.
    /// </summary>
    public class VpcState : ConstantClass
    {

        /// <summary>
        /// Constant Available for VpcState
        /// </summary>
        public static readonly VpcState Available = new VpcState("available");
        /// <summary>
        /// Constant Pending for VpcState
        /// </summary>
        public static readonly VpcState Pending = new VpcState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcState FindValue(string value)
        {
            return FindValue<VpcState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcTenancy.
    /// </summary>
    public class VpcTenancy : ConstantClass
    {

        /// <summary>
        /// Constant Default for VpcTenancy
        /// </summary>
        public static readonly VpcTenancy Default = new VpcTenancy("default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcTenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcTenancy FindValue(string value)
        {
            return FindValue<VpcTenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcTenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpnEcmpSupportValue.
    /// </summary>
    public class VpnEcmpSupportValue : ConstantClass
    {

        /// <summary>
        /// Constant Disable for VpnEcmpSupportValue
        /// </summary>
        public static readonly VpnEcmpSupportValue Disable = new VpnEcmpSupportValue("disable");
        /// <summary>
        /// Constant Enable for VpnEcmpSupportValue
        /// </summary>
        public static readonly VpnEcmpSupportValue Enable = new VpnEcmpSupportValue("enable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpnEcmpSupportValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnEcmpSupportValue FindValue(string value)
        {
            return FindValue<VpnEcmpSupportValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpnEcmpSupportValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpnProtocol.
    /// </summary>
    public class VpnProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Openvpn for VpnProtocol
        /// </summary>
        public static readonly VpnProtocol Openvpn = new VpnProtocol("openvpn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpnProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnProtocol FindValue(string value)
        {
            return FindValue<VpnProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpnProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpnState.
    /// </summary>
    public class VpnState : ConstantClass
    {

        /// <summary>
        /// Constant Available for VpnState
        /// </summary>
        public static readonly VpnState Available = new VpnState("available");
        /// <summary>
        /// Constant Deleted for VpnState
        /// </summary>
        public static readonly VpnState Deleted = new VpnState("deleted");
        /// <summary>
        /// Constant Deleting for VpnState
        /// </summary>
        public static readonly VpnState Deleting = new VpnState("deleting");
        /// <summary>
        /// Constant Pending for VpnState
        /// </summary>
        public static readonly VpnState Pending = new VpnState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpnState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnState FindValue(string value)
        {
            return FindValue<VpnState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpnState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpnStaticRouteSource.
    /// </summary>
    public class VpnStaticRouteSource : ConstantClass
    {

        /// <summary>
        /// Constant Static for VpnStaticRouteSource
        /// </summary>
        public static readonly VpnStaticRouteSource Static = new VpnStaticRouteSource("Static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpnStaticRouteSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnStaticRouteSource FindValue(string value)
        {
            return FindValue<VpnStaticRouteSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpnStaticRouteSource(string value)
        {
            return FindValue(value);
        }
    }

}