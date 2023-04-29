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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityHub
{

    /// <summary>
    /// Constants used for properties of type AdminStatus.
    /// </summary>
    public class AdminStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for AdminStatus
        /// </summary>
        public static readonly AdminStatus DISABLE_IN_PROGRESS = new AdminStatus("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for AdminStatus
        /// </summary>
        public static readonly AdminStatus ENABLED = new AdminStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminStatus FindValue(string value)
        {
            return FindValue<AdminStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatus.
    /// </summary>
    public class AssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus DISABLED = new AssociationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus ENABLED = new AssociationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatus FindValue(string value)
        {
            return FindValue<AssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoEnableStandards.
    /// </summary>
    public class AutoEnableStandards : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for AutoEnableStandards
        /// </summary>
        public static readonly AutoEnableStandards DEFAULT = new AutoEnableStandards("DEFAULT");
        /// <summary>
        /// Constant NONE for AutoEnableStandards
        /// </summary>
        public static readonly AutoEnableStandards NONE = new AutoEnableStandards("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoEnableStandards(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoEnableStandards FindValue(string value)
        {
            return FindValue<AutoEnableStandards>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoEnableStandards(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsIamAccessKeyStatus.
    /// </summary>
    public class AwsIamAccessKeyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for AwsIamAccessKeyStatus
        /// </summary>
        public static readonly AwsIamAccessKeyStatus Active = new AwsIamAccessKeyStatus("Active");
        /// <summary>
        /// Constant Inactive for AwsIamAccessKeyStatus
        /// </summary>
        public static readonly AwsIamAccessKeyStatus Inactive = new AwsIamAccessKeyStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsIamAccessKeyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsIamAccessKeyStatus FindValue(string value)
        {
            return FindValue<AwsIamAccessKeyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsIamAccessKeyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsS3BucketNotificationConfigurationS3KeyFilterRuleName.
    /// </summary>
    public class AwsS3BucketNotificationConfigurationS3KeyFilterRuleName : ConstantClass
    {

        /// <summary>
        /// Constant Prefix for AwsS3BucketNotificationConfigurationS3KeyFilterRuleName
        /// </summary>
        public static readonly AwsS3BucketNotificationConfigurationS3KeyFilterRuleName Prefix = new AwsS3BucketNotificationConfigurationS3KeyFilterRuleName("Prefix");
        /// <summary>
        /// Constant Suffix for AwsS3BucketNotificationConfigurationS3KeyFilterRuleName
        /// </summary>
        public static readonly AwsS3BucketNotificationConfigurationS3KeyFilterRuleName Suffix = new AwsS3BucketNotificationConfigurationS3KeyFilterRuleName("Suffix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsS3BucketNotificationConfigurationS3KeyFilterRuleName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsS3BucketNotificationConfigurationS3KeyFilterRuleName FindValue(string value)
        {
            return FindValue<AwsS3BucketNotificationConfigurationS3KeyFilterRuleName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsS3BucketNotificationConfigurationS3KeyFilterRuleName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceStatus.
    /// </summary>
    public class ComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus FAILED = new ComplianceStatus("FAILED");
        /// <summary>
        /// Constant NOT_AVAILABLE for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus NOT_AVAILABLE = new ComplianceStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant PASSED for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus PASSED = new ComplianceStatus("PASSED");
        /// <summary>
        /// Constant WARNING for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus WARNING = new ComplianceStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceStatus FindValue(string value)
        {
            return FindValue<ComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlFindingGenerator.
    /// </summary>
    public class ControlFindingGenerator : ConstantClass
    {

        /// <summary>
        /// Constant SECURITY_CONTROL for ControlFindingGenerator
        /// </summary>
        public static readonly ControlFindingGenerator SECURITY_CONTROL = new ControlFindingGenerator("SECURITY_CONTROL");
        /// <summary>
        /// Constant STANDARD_CONTROL for ControlFindingGenerator
        /// </summary>
        public static readonly ControlFindingGenerator STANDARD_CONTROL = new ControlFindingGenerator("STANDARD_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlFindingGenerator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlFindingGenerator FindValue(string value)
        {
            return FindValue<ControlFindingGenerator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlFindingGenerator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlStatus.
    /// </summary>
    public class ControlStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ControlStatus
        /// </summary>
        public static readonly ControlStatus DISABLED = new ControlStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ControlStatus
        /// </summary>
        public static readonly ControlStatus ENABLED = new ControlStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlStatus FindValue(string value)
        {
            return FindValue<ControlStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DateRangeUnit.
    /// </summary>
    public class DateRangeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for DateRangeUnit
        /// </summary>
        public static readonly DateRangeUnit DAYS = new DateRangeUnit("DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateRangeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateRangeUnit FindValue(string value)
        {
            return FindValue<DateRangeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateRangeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVE_FINDINGS_FROM_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType RECEIVE_FINDINGS_FROM_SECURITY_HUB = new IntegrationType("RECEIVE_FINDINGS_FROM_SECURITY_HUB");
        /// <summary>
        /// Constant SEND_FINDINGS_TO_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType SEND_FINDINGS_TO_SECURITY_HUB = new IntegrationType("SEND_FINDINGS_TO_SECURITY_HUB");
        /// <summary>
        /// Constant UPDATE_FINDINGS_IN_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType UPDATE_FINDINGS_IN_SECURITY_HUB = new IntegrationType("UPDATE_FINDINGS_IN_SECURITY_HUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareState.
    /// </summary>
    public class MalwareState : ConstantClass
    {

        /// <summary>
        /// Constant OBSERVED for MalwareState
        /// </summary>
        public static readonly MalwareState OBSERVED = new MalwareState("OBSERVED");
        /// <summary>
        /// Constant REMOVAL_FAILED for MalwareState
        /// </summary>
        public static readonly MalwareState REMOVAL_FAILED = new MalwareState("REMOVAL_FAILED");
        /// <summary>
        /// Constant REMOVED for MalwareState
        /// </summary>
        public static readonly MalwareState REMOVED = new MalwareState("REMOVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareState FindValue(string value)
        {
            return FindValue<MalwareState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareType.
    /// </summary>
    public class MalwareType : ConstantClass
    {

        /// <summary>
        /// Constant ADWARE for MalwareType
        /// </summary>
        public static readonly MalwareType ADWARE = new MalwareType("ADWARE");
        /// <summary>
        /// Constant BLENDED_THREAT for MalwareType
        /// </summary>
        public static readonly MalwareType BLENDED_THREAT = new MalwareType("BLENDED_THREAT");
        /// <summary>
        /// Constant BOTNET_AGENT for MalwareType
        /// </summary>
        public static readonly MalwareType BOTNET_AGENT = new MalwareType("BOTNET_AGENT");
        /// <summary>
        /// Constant COIN_MINER for MalwareType
        /// </summary>
        public static readonly MalwareType COIN_MINER = new MalwareType("COIN_MINER");
        /// <summary>
        /// Constant EXPLOIT_KIT for MalwareType
        /// </summary>
        public static readonly MalwareType EXPLOIT_KIT = new MalwareType("EXPLOIT_KIT");
        /// <summary>
        /// Constant KEYLOGGER for MalwareType
        /// </summary>
        public static readonly MalwareType KEYLOGGER = new MalwareType("KEYLOGGER");
        /// <summary>
        /// Constant MACRO for MalwareType
        /// </summary>
        public static readonly MalwareType MACRO = new MalwareType("MACRO");
        /// <summary>
        /// Constant POTENTIALLY_UNWANTED for MalwareType
        /// </summary>
        public static readonly MalwareType POTENTIALLY_UNWANTED = new MalwareType("POTENTIALLY_UNWANTED");
        /// <summary>
        /// Constant RANSOMWARE for MalwareType
        /// </summary>
        public static readonly MalwareType RANSOMWARE = new MalwareType("RANSOMWARE");
        /// <summary>
        /// Constant REMOTE_ACCESS for MalwareType
        /// </summary>
        public static readonly MalwareType REMOTE_ACCESS = new MalwareType("REMOTE_ACCESS");
        /// <summary>
        /// Constant ROOTKIT for MalwareType
        /// </summary>
        public static readonly MalwareType ROOTKIT = new MalwareType("ROOTKIT");
        /// <summary>
        /// Constant SPYWARE for MalwareType
        /// </summary>
        public static readonly MalwareType SPYWARE = new MalwareType("SPYWARE");
        /// <summary>
        /// Constant TROJAN for MalwareType
        /// </summary>
        public static readonly MalwareType TROJAN = new MalwareType("TROJAN");
        /// <summary>
        /// Constant VIRUS for MalwareType
        /// </summary>
        public static readonly MalwareType VIRUS = new MalwareType("VIRUS");
        /// <summary>
        /// Constant WORM for MalwareType
        /// </summary>
        public static readonly MalwareType WORM = new MalwareType("WORM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareType FindValue(string value)
        {
            return FindValue<MalwareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapFilterComparison.
    /// </summary>
    public class MapFilterComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison EQUALS = new MapFilterComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison NOT_EQUALS = new MapFilterComparison("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapFilterComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapFilterComparison FindValue(string value)
        {
            return FindValue<MapFilterComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapFilterComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkDirection.
    /// </summary>
    public class NetworkDirection : ConstantClass
    {

        /// <summary>
        /// Constant IN for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection IN = new NetworkDirection("IN");
        /// <summary>
        /// Constant OUT for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection OUT = new NetworkDirection("OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkDirection FindValue(string value)
        {
            return FindValue<NetworkDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Partition.
    /// </summary>
    public class Partition : ConstantClass
    {

        /// <summary>
        /// Constant Aws for Partition
        /// </summary>
        public static readonly Partition Aws = new Partition("aws");
        /// <summary>
        /// Constant AwsCn for Partition
        /// </summary>
        public static readonly Partition AwsCn = new Partition("aws-cn");
        /// <summary>
        /// Constant AwsUsGov for Partition
        /// </summary>
        public static readonly Partition AwsUsGov = new Partition("aws-us-gov");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Partition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Partition FindValue(string value)
        {
            return FindValue<Partition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Partition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordState.
    /// </summary>
    public class RecordState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RecordState
        /// </summary>
        public static readonly RecordState ACTIVE = new RecordState("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for RecordState
        /// </summary>
        public static readonly RecordState ARCHIVED = new RecordState("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordState FindValue(string value)
        {
            return FindValue<RecordState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionAvailabilityStatus.
    /// </summary>
    public class RegionAvailabilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for RegionAvailabilityStatus
        /// </summary>
        public static readonly RegionAvailabilityStatus AVAILABLE = new RegionAvailabilityStatus("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for RegionAvailabilityStatus
        /// </summary>
        public static readonly RegionAvailabilityStatus UNAVAILABLE = new RegionAvailabilityStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionAvailabilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionAvailabilityStatus FindValue(string value)
        {
            return FindValue<RegionAvailabilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionAvailabilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityLabel.
    /// </summary>
    public class SeverityLabel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel CRITICAL = new SeverityLabel("CRITICAL");
        /// <summary>
        /// Constant HIGH for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel HIGH = new SeverityLabel("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel INFORMATIONAL = new SeverityLabel("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel LOW = new SeverityLabel("LOW");
        /// <summary>
        /// Constant MEDIUM for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel MEDIUM = new SeverityLabel("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityLabel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityLabel FindValue(string value)
        {
            return FindValue<SeverityLabel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityLabel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityRating.
    /// </summary>
    public class SeverityRating : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for SeverityRating
        /// </summary>
        public static readonly SeverityRating CRITICAL = new SeverityRating("CRITICAL");
        /// <summary>
        /// Constant HIGH for SeverityRating
        /// </summary>
        public static readonly SeverityRating HIGH = new SeverityRating("HIGH");
        /// <summary>
        /// Constant LOW for SeverityRating
        /// </summary>
        public static readonly SeverityRating LOW = new SeverityRating("LOW");
        /// <summary>
        /// Constant MEDIUM for SeverityRating
        /// </summary>
        public static readonly SeverityRating MEDIUM = new SeverityRating("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityRating(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityRating FindValue(string value)
        {
            return FindValue<SeverityRating>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityRating(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Asc for SortOrder
        /// </summary>
        public static readonly SortOrder Asc = new SortOrder("asc");
        /// <summary>
        /// Constant Desc for SortOrder
        /// </summary>
        public static readonly SortOrder Desc = new SortOrder("desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardsStatus.
    /// </summary>
    public class StandardsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus DELETING = new StandardsStatus("DELETING");
        /// <summary>
        /// Constant FAILED for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus FAILED = new StandardsStatus("FAILED");
        /// <summary>
        /// Constant INCOMPLETE for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus INCOMPLETE = new StandardsStatus("INCOMPLETE");
        /// <summary>
        /// Constant PENDING for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus PENDING = new StandardsStatus("PENDING");
        /// <summary>
        /// Constant READY for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus READY = new StandardsStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardsStatus FindValue(string value)
        {
            return FindValue<StandardsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusReasonCode.
    /// </summary>
    public class StatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for StatusReasonCode
        /// </summary>
        public static readonly StatusReasonCode INTERNAL_ERROR = new StatusReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant NO_AVAILABLE_CONFIGURATION_RECORDER for StatusReasonCode
        /// </summary>
        public static readonly StatusReasonCode NO_AVAILABLE_CONFIGURATION_RECORDER = new StatusReasonCode("NO_AVAILABLE_CONFIGURATION_RECORDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusReasonCode FindValue(string value)
        {
            return FindValue<StatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringFilterComparison.
    /// </summary>
    public class StringFilterComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison EQUALS = new StringFilterComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison NOT_EQUALS = new StringFilterComparison("NOT_EQUALS");
        /// <summary>
        /// Constant PREFIX for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison PREFIX = new StringFilterComparison("PREFIX");
        /// <summary>
        /// Constant PREFIX_NOT_EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison PREFIX_NOT_EQUALS = new StringFilterComparison("PREFIX_NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringFilterComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringFilterComparison FindValue(string value)
        {
            return FindValue<StringFilterComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringFilterComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelIndicatorCategory.
    /// </summary>
    public class ThreatIntelIndicatorCategory : ConstantClass
    {

        /// <summary>
        /// Constant BACKDOOR for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory BACKDOOR = new ThreatIntelIndicatorCategory("BACKDOOR");
        /// <summary>
        /// Constant CARD_STEALER for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory CARD_STEALER = new ThreatIntelIndicatorCategory("CARD_STEALER");
        /// <summary>
        /// Constant COMMAND_AND_CONTROL for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory COMMAND_AND_CONTROL = new ThreatIntelIndicatorCategory("COMMAND_AND_CONTROL");
        /// <summary>
        /// Constant DROP_SITE for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory DROP_SITE = new ThreatIntelIndicatorCategory("DROP_SITE");
        /// <summary>
        /// Constant EXPLOIT_SITE for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory EXPLOIT_SITE = new ThreatIntelIndicatorCategory("EXPLOIT_SITE");
        /// <summary>
        /// Constant KEYLOGGER for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory KEYLOGGER = new ThreatIntelIndicatorCategory("KEYLOGGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelIndicatorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelIndicatorCategory FindValue(string value)
        {
            return FindValue<ThreatIntelIndicatorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelIndicatorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelIndicatorType.
    /// </summary>
    public class ThreatIntelIndicatorType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType DOMAIN = new ThreatIntelIndicatorType("DOMAIN");
        /// <summary>
        /// Constant EMAIL_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType EMAIL_ADDRESS = new ThreatIntelIndicatorType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant HASH_MD5 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_MD5 = new ThreatIntelIndicatorType("HASH_MD5");
        /// <summary>
        /// Constant HASH_SHA1 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA1 = new ThreatIntelIndicatorType("HASH_SHA1");
        /// <summary>
        /// Constant HASH_SHA256 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA256 = new ThreatIntelIndicatorType("HASH_SHA256");
        /// <summary>
        /// Constant HASH_SHA512 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA512 = new ThreatIntelIndicatorType("HASH_SHA512");
        /// <summary>
        /// Constant IPV4_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType IPV4_ADDRESS = new ThreatIntelIndicatorType("IPV4_ADDRESS");
        /// <summary>
        /// Constant IPV6_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType IPV6_ADDRESS = new ThreatIntelIndicatorType("IPV6_ADDRESS");
        /// <summary>
        /// Constant MUTEX for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType MUTEX = new ThreatIntelIndicatorType("MUTEX");
        /// <summary>
        /// Constant PROCESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType PROCESS = new ThreatIntelIndicatorType("PROCESS");
        /// <summary>
        /// Constant URL for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType URL = new ThreatIntelIndicatorType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelIndicatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelIndicatorType FindValue(string value)
        {
            return FindValue<ThreatIntelIndicatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelIndicatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnprocessedErrorCode.
    /// </summary>
    public class UnprocessedErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode ACCESS_DENIED = new UnprocessedErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INVALID_INPUT for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode INVALID_INPUT = new UnprocessedErrorCode("INVALID_INPUT");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode LIMIT_EXCEEDED = new UnprocessedErrorCode("LIMIT_EXCEEDED");
        /// <summary>
        /// Constant NOT_FOUND for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode NOT_FOUND = new UnprocessedErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnprocessedErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnprocessedErrorCode FindValue(string value)
        {
            return FindValue<UnprocessedErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnprocessedErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationState.
    /// </summary>
    public class VerificationState : ConstantClass
    {

        /// <summary>
        /// Constant BENIGN_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState BENIGN_POSITIVE = new VerificationState("BENIGN_POSITIVE");
        /// <summary>
        /// Constant FALSE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState FALSE_POSITIVE = new VerificationState("FALSE_POSITIVE");
        /// <summary>
        /// Constant TRUE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState TRUE_POSITIVE = new VerificationState("TRUE_POSITIVE");
        /// <summary>
        /// Constant UNKNOWN for VerificationState
        /// </summary>
        public static readonly VerificationState UNKNOWN = new VerificationState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationState FindValue(string value)
        {
            return FindValue<VerificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VulnerabilityFixAvailable.
    /// </summary>
    public class VulnerabilityFixAvailable : ConstantClass
    {

        /// <summary>
        /// Constant NO for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable NO = new VulnerabilityFixAvailable("NO");
        /// <summary>
        /// Constant PARTIAL for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable PARTIAL = new VulnerabilityFixAvailable("PARTIAL");
        /// <summary>
        /// Constant YES for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable YES = new VulnerabilityFixAvailable("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VulnerabilityFixAvailable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VulnerabilityFixAvailable FindValue(string value)
        {
            return FindValue<VulnerabilityFixAvailable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VulnerabilityFixAvailable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowState.
    /// </summary>
    public class WorkflowState : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for WorkflowState
        /// </summary>
        public static readonly WorkflowState ASSIGNED = new WorkflowState("ASSIGNED");
        /// <summary>
        /// Constant DEFERRED for WorkflowState
        /// </summary>
        public static readonly WorkflowState DEFERRED = new WorkflowState("DEFERRED");
        /// <summary>
        /// Constant IN_PROGRESS for WorkflowState
        /// </summary>
        public static readonly WorkflowState IN_PROGRESS = new WorkflowState("IN_PROGRESS");
        /// <summary>
        /// Constant NEW for WorkflowState
        /// </summary>
        public static readonly WorkflowState NEW = new WorkflowState("NEW");
        /// <summary>
        /// Constant RESOLVED for WorkflowState
        /// </summary>
        public static readonly WorkflowState RESOLVED = new WorkflowState("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowState FindValue(string value)
        {
            return FindValue<WorkflowState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStatus.
    /// </summary>
    public class WorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant NEW for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus NEW = new WorkflowStatus("NEW");
        /// <summary>
        /// Constant NOTIFIED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus NOTIFIED = new WorkflowStatus("NOTIFIED");
        /// <summary>
        /// Constant RESOLVED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus RESOLVED = new WorkflowStatus("RESOLVED");
        /// <summary>
        /// Constant SUPPRESSED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus SUPPRESSED = new WorkflowStatus("SUPPRESSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStatus FindValue(string value)
        {
            return FindValue<WorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }

}