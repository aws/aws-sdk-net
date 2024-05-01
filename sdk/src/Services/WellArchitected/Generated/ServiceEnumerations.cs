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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WellArchitected
{

    /// <summary>
    /// Constants used for properties of type AccountJiraIssueManagementStatus.
    /// </summary>
    public class AccountJiraIssueManagementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AccountJiraIssueManagementStatus
        /// </summary>
        public static readonly AccountJiraIssueManagementStatus DISABLED = new AccountJiraIssueManagementStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AccountJiraIssueManagementStatus
        /// </summary>
        public static readonly AccountJiraIssueManagementStatus ENABLED = new AccountJiraIssueManagementStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountJiraIssueManagementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountJiraIssueManagementStatus FindValue(string value)
        {
            return FindValue<AccountJiraIssueManagementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountJiraIssueManagementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdditionalResourceType.
    /// </summary>
    public class AdditionalResourceType : ConstantClass
    {

        /// <summary>
        /// Constant HELPFUL_RESOURCE for AdditionalResourceType
        /// </summary>
        public static readonly AdditionalResourceType HELPFUL_RESOURCE = new AdditionalResourceType("HELPFUL_RESOURCE");
        /// <summary>
        /// Constant IMPROVEMENT_PLAN for AdditionalResourceType
        /// </summary>
        public static readonly AdditionalResourceType IMPROVEMENT_PLAN = new AdditionalResourceType("IMPROVEMENT_PLAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalResourceType FindValue(string value)
        {
            return FindValue<AdditionalResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnswerReason.
    /// </summary>
    public class AnswerReason : ConstantClass
    {

        /// <summary>
        /// Constant ARCHITECTURE_CONSTRAINTS for AnswerReason
        /// </summary>
        public static readonly AnswerReason ARCHITECTURE_CONSTRAINTS = new AnswerReason("ARCHITECTURE_CONSTRAINTS");
        /// <summary>
        /// Constant BUSINESS_PRIORITIES for AnswerReason
        /// </summary>
        public static readonly AnswerReason BUSINESS_PRIORITIES = new AnswerReason("BUSINESS_PRIORITIES");
        /// <summary>
        /// Constant NONE for AnswerReason
        /// </summary>
        public static readonly AnswerReason NONE = new AnswerReason("NONE");
        /// <summary>
        /// Constant OTHER for AnswerReason
        /// </summary>
        public static readonly AnswerReason OTHER = new AnswerReason("OTHER");
        /// <summary>
        /// Constant OUT_OF_SCOPE for AnswerReason
        /// </summary>
        public static readonly AnswerReason OUT_OF_SCOPE = new AnswerReason("OUT_OF_SCOPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnswerReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnswerReason FindValue(string value)
        {
            return FindValue<AnswerReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnswerReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckFailureReason.
    /// </summary>
    public class CheckFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for CheckFailureReason
        /// </summary>
        public static readonly CheckFailureReason ACCESS_DENIED = new CheckFailureReason("ACCESS_DENIED");
        /// <summary>
        /// Constant ASSUME_ROLE_ERROR for CheckFailureReason
        /// </summary>
        public static readonly CheckFailureReason ASSUME_ROLE_ERROR = new CheckFailureReason("ASSUME_ROLE_ERROR");
        /// <summary>
        /// Constant PREMIUM_SUPPORT_REQUIRED for CheckFailureReason
        /// </summary>
        public static readonly CheckFailureReason PREMIUM_SUPPORT_REQUIRED = new CheckFailureReason("PREMIUM_SUPPORT_REQUIRED");
        /// <summary>
        /// Constant UNKNOWN_ERROR for CheckFailureReason
        /// </summary>
        public static readonly CheckFailureReason UNKNOWN_ERROR = new CheckFailureReason("UNKNOWN_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckFailureReason FindValue(string value)
        {
            return FindValue<CheckFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckProvider.
    /// </summary>
    public class CheckProvider : ConstantClass
    {

        /// <summary>
        /// Constant TRUSTED_ADVISOR for CheckProvider
        /// </summary>
        public static readonly CheckProvider TRUSTED_ADVISOR = new CheckProvider("TRUSTED_ADVISOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckProvider FindValue(string value)
        {
            return FindValue<CheckProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckStatus.
    /// </summary>
    public class CheckStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for CheckStatus
        /// </summary>
        public static readonly CheckStatus ERROR = new CheckStatus("ERROR");
        /// <summary>
        /// Constant FETCH_FAILED for CheckStatus
        /// </summary>
        public static readonly CheckStatus FETCH_FAILED = new CheckStatus("FETCH_FAILED");
        /// <summary>
        /// Constant NOT_AVAILABLE for CheckStatus
        /// </summary>
        public static readonly CheckStatus NOT_AVAILABLE = new CheckStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant OKAY for CheckStatus
        /// </summary>
        public static readonly CheckStatus OKAY = new CheckStatus("OKAY");
        /// <summary>
        /// Constant WARNING for CheckStatus
        /// </summary>
        public static readonly CheckStatus WARNING = new CheckStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckStatus FindValue(string value)
        {
            return FindValue<CheckStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChoiceReason.
    /// </summary>
    public class ChoiceReason : ConstantClass
    {

        /// <summary>
        /// Constant ARCHITECTURE_CONSTRAINTS for ChoiceReason
        /// </summary>
        public static readonly ChoiceReason ARCHITECTURE_CONSTRAINTS = new ChoiceReason("ARCHITECTURE_CONSTRAINTS");
        /// <summary>
        /// Constant BUSINESS_PRIORITIES for ChoiceReason
        /// </summary>
        public static readonly ChoiceReason BUSINESS_PRIORITIES = new ChoiceReason("BUSINESS_PRIORITIES");
        /// <summary>
        /// Constant NONE for ChoiceReason
        /// </summary>
        public static readonly ChoiceReason NONE = new ChoiceReason("NONE");
        /// <summary>
        /// Constant OTHER for ChoiceReason
        /// </summary>
        public static readonly ChoiceReason OTHER = new ChoiceReason("OTHER");
        /// <summary>
        /// Constant OUT_OF_SCOPE for ChoiceReason
        /// </summary>
        public static readonly ChoiceReason OUT_OF_SCOPE = new ChoiceReason("OUT_OF_SCOPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChoiceReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChoiceReason FindValue(string value)
        {
            return FindValue<ChoiceReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChoiceReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChoiceStatus.
    /// </summary>
    public class ChoiceStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_APPLICABLE for ChoiceStatus
        /// </summary>
        public static readonly ChoiceStatus NOT_APPLICABLE = new ChoiceStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant SELECTED for ChoiceStatus
        /// </summary>
        public static readonly ChoiceStatus SELECTED = new ChoiceStatus("SELECTED");
        /// <summary>
        /// Constant UNSELECTED for ChoiceStatus
        /// </summary>
        public static readonly ChoiceStatus UNSELECTED = new ChoiceStatus("UNSELECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChoiceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChoiceStatus FindValue(string value)
        {
            return FindValue<ChoiceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChoiceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefinitionType.
    /// </summary>
    public class DefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant APP_REGISTRY for DefinitionType
        /// </summary>
        public static readonly DefinitionType APP_REGISTRY = new DefinitionType("APP_REGISTRY");
        /// <summary>
        /// Constant WORKLOAD_METADATA for DefinitionType
        /// </summary>
        public static readonly DefinitionType WORKLOAD_METADATA = new DefinitionType("WORKLOAD_METADATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefinitionType FindValue(string value)
        {
            return FindValue<DefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DifferenceStatus.
    /// </summary>
    public class DifferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus DELETED = new DifferenceStatus("DELETED");
        /// <summary>
        /// Constant NEW for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus NEW = new DifferenceStatus("NEW");
        /// <summary>
        /// Constant UPDATED for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus UPDATED = new DifferenceStatus("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DifferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DifferenceStatus FindValue(string value)
        {
            return FindValue<DifferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DifferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscoveryIntegrationStatus.
    /// </summary>
    public class DiscoveryIntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DiscoveryIntegrationStatus
        /// </summary>
        public static readonly DiscoveryIntegrationStatus DISABLED = new DiscoveryIntegrationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DiscoveryIntegrationStatus
        /// </summary>
        public static readonly DiscoveryIntegrationStatus ENABLED = new DiscoveryIntegrationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscoveryIntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryIntegrationStatus FindValue(string value)
        {
            return FindValue<DiscoveryIntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryIntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportLensStatus.
    /// </summary>
    public class ImportLensStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ImportLensStatus
        /// </summary>
        public static readonly ImportLensStatus COMPLETE = new ImportLensStatus("COMPLETE");
        /// <summary>
        /// Constant ERROR for ImportLensStatus
        /// </summary>
        public static readonly ImportLensStatus ERROR = new ImportLensStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for ImportLensStatus
        /// </summary>
        public static readonly ImportLensStatus IN_PROGRESS = new ImportLensStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportLensStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportLensStatus FindValue(string value)
        {
            return FindValue<ImportLensStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportLensStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegratingService.
    /// </summary>
    public class IntegratingService : ConstantClass
    {

        /// <summary>
        /// Constant JIRA for IntegratingService
        /// </summary>
        public static readonly IntegratingService JIRA = new IntegratingService("JIRA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegratingService(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegratingService FindValue(string value)
        {
            return FindValue<IntegratingService>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegratingService(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatus.
    /// </summary>
    public class IntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURED for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus CONFIGURED = new IntegrationStatus("CONFIGURED");
        /// <summary>
        /// Constant NOT_CONFIGURED for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus NOT_CONFIGURED = new IntegrationStatus("NOT_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatus FindValue(string value)
        {
            return FindValue<IntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatusInput.
    /// </summary>
    public class IntegrationStatusInput : ConstantClass
    {

        /// <summary>
        /// Constant NOT_CONFIGURED for IntegrationStatusInput
        /// </summary>
        public static readonly IntegrationStatusInput NOT_CONFIGURED = new IntegrationStatusInput("NOT_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatusInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatusInput FindValue(string value)
        {
            return FindValue<IntegrationStatusInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatusInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IssueManagementType.
    /// </summary>
    public class IssueManagementType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for IssueManagementType
        /// </summary>
        public static readonly IssueManagementType AUTO = new IssueManagementType("AUTO");
        /// <summary>
        /// Constant MANUAL for IssueManagementType
        /// </summary>
        public static readonly IssueManagementType MANUAL = new IssueManagementType("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IssueManagementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueManagementType FindValue(string value)
        {
            return FindValue<IssueManagementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueManagementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LensStatus.
    /// </summary>
    public class LensStatus : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT for LensStatus
        /// </summary>
        public static readonly LensStatus CURRENT = new LensStatus("CURRENT");
        /// <summary>
        /// Constant DELETED for LensStatus
        /// </summary>
        public static readonly LensStatus DELETED = new LensStatus("DELETED");
        /// <summary>
        /// Constant DEPRECATED for LensStatus
        /// </summary>
        public static readonly LensStatus DEPRECATED = new LensStatus("DEPRECATED");
        /// <summary>
        /// Constant NOT_CURRENT for LensStatus
        /// </summary>
        public static readonly LensStatus NOT_CURRENT = new LensStatus("NOT_CURRENT");
        /// <summary>
        /// Constant UNSHARED for LensStatus
        /// </summary>
        public static readonly LensStatus UNSHARED = new LensStatus("UNSHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LensStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LensStatus FindValue(string value)
        {
            return FindValue<LensStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LensStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LensStatusType.
    /// </summary>
    public class LensStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for LensStatusType
        /// </summary>
        public static readonly LensStatusType ALL = new LensStatusType("ALL");
        /// <summary>
        /// Constant DRAFT for LensStatusType
        /// </summary>
        public static readonly LensStatusType DRAFT = new LensStatusType("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for LensStatusType
        /// </summary>
        public static readonly LensStatusType PUBLISHED = new LensStatusType("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LensStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LensStatusType FindValue(string value)
        {
            return FindValue<LensStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LensStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LensType.
    /// </summary>
    public class LensType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OFFICIAL for LensType
        /// </summary>
        public static readonly LensType AWS_OFFICIAL = new LensType("AWS_OFFICIAL");
        /// <summary>
        /// Constant CUSTOM_SELF for LensType
        /// </summary>
        public static readonly LensType CUSTOM_SELF = new LensType("CUSTOM_SELF");
        /// <summary>
        /// Constant CUSTOM_SHARED for LensType
        /// </summary>
        public static readonly LensType CUSTOM_SHARED = new LensType("CUSTOM_SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LensType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LensType FindValue(string value)
        {
            return FindValue<LensType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LensType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricType.
    /// </summary>
    public class MetricType : ConstantClass
    {

        /// <summary>
        /// Constant WORKLOAD for MetricType
        /// </summary>
        public static readonly MetricType WORKLOAD = new MetricType("WORKLOAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricType FindValue(string value)
        {
            return FindValue<MetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant LENS_VERSION_DEPRECATED for NotificationType
        /// </summary>
        public static readonly NotificationType LENS_VERSION_DEPRECATED = new NotificationType("LENS_VERSION_DEPRECATED");
        /// <summary>
        /// Constant LENS_VERSION_UPGRADED for NotificationType
        /// </summary>
        public static readonly NotificationType LENS_VERSION_UPGRADED = new NotificationType("LENS_VERSION_UPGRADED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationSharingStatus.
    /// </summary>
    public class OrganizationSharingStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OrganizationSharingStatus
        /// </summary>
        public static readonly OrganizationSharingStatus DISABLED = new OrganizationSharingStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OrganizationSharingStatus
        /// </summary>
        public static readonly OrganizationSharingStatus ENABLED = new OrganizationSharingStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationSharingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationSharingStatus FindValue(string value)
        {
            return FindValue<OrganizationSharingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationSharingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for PermissionType
        /// </summary>
        public static readonly PermissionType CONTRIBUTOR = new PermissionType("CONTRIBUTOR");
        /// <summary>
        /// Constant READONLY for PermissionType
        /// </summary>
        public static readonly PermissionType READONLY = new PermissionType("READONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileNotificationType.
    /// </summary>
    public class ProfileNotificationType : ConstantClass
    {

        /// <summary>
        /// Constant PROFILE_ANSWERS_UPDATED for ProfileNotificationType
        /// </summary>
        public static readonly ProfileNotificationType PROFILE_ANSWERS_UPDATED = new ProfileNotificationType("PROFILE_ANSWERS_UPDATED");
        /// <summary>
        /// Constant PROFILE_DELETED for ProfileNotificationType
        /// </summary>
        public static readonly ProfileNotificationType PROFILE_DELETED = new ProfileNotificationType("PROFILE_DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileNotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileNotificationType FindValue(string value)
        {
            return FindValue<ProfileNotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileNotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileOwnerType.
    /// </summary>
    public class ProfileOwnerType : ConstantClass
    {

        /// <summary>
        /// Constant SELF for ProfileOwnerType
        /// </summary>
        public static readonly ProfileOwnerType SELF = new ProfileOwnerType("SELF");
        /// <summary>
        /// Constant SHARED for ProfileOwnerType
        /// </summary>
        public static readonly ProfileOwnerType SHARED = new ProfileOwnerType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileOwnerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileOwnerType FindValue(string value)
        {
            return FindValue<ProfileOwnerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileOwnerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Question.
    /// </summary>
    public class Question : ConstantClass
    {

        /// <summary>
        /// Constant ANSWERED for Question
        /// </summary>
        public static readonly Question ANSWERED = new Question("ANSWERED");
        /// <summary>
        /// Constant UNANSWERED for Question
        /// </summary>
        public static readonly Question UNANSWERED = new Question("UNANSWERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Question(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Question FindValue(string value)
        {
            return FindValue<Question>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Question(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuestionPriority.
    /// </summary>
    public class QuestionPriority : ConstantClass
    {

        /// <summary>
        /// Constant NONE for QuestionPriority
        /// </summary>
        public static readonly QuestionPriority NONE = new QuestionPriority("NONE");
        /// <summary>
        /// Constant PRIORITIZED for QuestionPriority
        /// </summary>
        public static readonly QuestionPriority PRIORITIZED = new QuestionPriority("PRIORITIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuestionPriority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuestionPriority FindValue(string value)
        {
            return FindValue<QuestionPriority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuestionPriority(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuestionType.
    /// </summary>
    public class QuestionType : ConstantClass
    {

        /// <summary>
        /// Constant NON_PRIORITIZED for QuestionType
        /// </summary>
        public static readonly QuestionType NON_PRIORITIZED = new QuestionType("NON_PRIORITIZED");
        /// <summary>
        /// Constant PRIORITIZED for QuestionType
        /// </summary>
        public static readonly QuestionType PRIORITIZED = new QuestionType("PRIORITIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuestionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuestionType FindValue(string value)
        {
            return FindValue<QuestionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuestionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormat.
    /// </summary>
    public class ReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for ReportFormat
        /// </summary>
        public static readonly ReportFormat JSON = new ReportFormat("JSON");
        /// <summary>
        /// Constant PDF for ReportFormat
        /// </summary>
        public static readonly ReportFormat PDF = new ReportFormat("PDF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormat FindValue(string value)
        {
            return FindValue<ReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewTemplateAnswerStatus.
    /// </summary>
    public class ReviewTemplateAnswerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANSWERED for ReviewTemplateAnswerStatus
        /// </summary>
        public static readonly ReviewTemplateAnswerStatus ANSWERED = new ReviewTemplateAnswerStatus("ANSWERED");
        /// <summary>
        /// Constant UNANSWERED for ReviewTemplateAnswerStatus
        /// </summary>
        public static readonly ReviewTemplateAnswerStatus UNANSWERED = new ReviewTemplateAnswerStatus("UNANSWERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewTemplateAnswerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewTemplateAnswerStatus FindValue(string value)
        {
            return FindValue<ReviewTemplateAnswerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewTemplateAnswerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewTemplateUpdateStatus.
    /// </summary>
    public class ReviewTemplateUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT for ReviewTemplateUpdateStatus
        /// </summary>
        public static readonly ReviewTemplateUpdateStatus CURRENT = new ReviewTemplateUpdateStatus("CURRENT");
        /// <summary>
        /// Constant LENS_NOT_CURRENT for ReviewTemplateUpdateStatus
        /// </summary>
        public static readonly ReviewTemplateUpdateStatus LENS_NOT_CURRENT = new ReviewTemplateUpdateStatus("LENS_NOT_CURRENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewTemplateUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewTemplateUpdateStatus FindValue(string value)
        {
            return FindValue<ReviewTemplateUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewTemplateUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Risk.
    /// </summary>
    public class Risk : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Risk
        /// </summary>
        public static readonly Risk HIGH = new Risk("HIGH");
        /// <summary>
        /// Constant MEDIUM for Risk
        /// </summary>
        public static readonly Risk MEDIUM = new Risk("MEDIUM");
        /// <summary>
        /// Constant NONE for Risk
        /// </summary>
        public static readonly Risk NONE = new Risk("NONE");
        /// <summary>
        /// Constant NOT_APPLICABLE for Risk
        /// </summary>
        public static readonly Risk NOT_APPLICABLE = new Risk("NOT_APPLICABLE");
        /// <summary>
        /// Constant UNANSWERED for Risk
        /// </summary>
        public static readonly Risk UNANSWERED = new Risk("UNANSWERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Risk(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Risk FindValue(string value)
        {
            return FindValue<Risk>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Risk(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareInvitationAction.
    /// </summary>
    public class ShareInvitationAction : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for ShareInvitationAction
        /// </summary>
        public static readonly ShareInvitationAction ACCEPT = new ShareInvitationAction("ACCEPT");
        /// <summary>
        /// Constant REJECT for ShareInvitationAction
        /// </summary>
        public static readonly ShareInvitationAction REJECT = new ShareInvitationAction("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareInvitationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareInvitationAction FindValue(string value)
        {
            return FindValue<ShareInvitationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareInvitationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareResourceType.
    /// </summary>
    public class ShareResourceType : ConstantClass
    {

        /// <summary>
        /// Constant LENS for ShareResourceType
        /// </summary>
        public static readonly ShareResourceType LENS = new ShareResourceType("LENS");
        /// <summary>
        /// Constant PROFILE for ShareResourceType
        /// </summary>
        public static readonly ShareResourceType PROFILE = new ShareResourceType("PROFILE");
        /// <summary>
        /// Constant TEMPLATE for ShareResourceType
        /// </summary>
        public static readonly ShareResourceType TEMPLATE = new ShareResourceType("TEMPLATE");
        /// <summary>
        /// Constant WORKLOAD for ShareResourceType
        /// </summary>
        public static readonly ShareResourceType WORKLOAD = new ShareResourceType("WORKLOAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareResourceType FindValue(string value)
        {
            return FindValue<ShareResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareStatus.
    /// </summary>
    public class ShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for ShareStatus
        /// </summary>
        public static readonly ShareStatus ACCEPTED = new ShareStatus("ACCEPTED");
        /// <summary>
        /// Constant ASSOCIATED for ShareStatus
        /// </summary>
        public static readonly ShareStatus ASSOCIATED = new ShareStatus("ASSOCIATED");
        /// <summary>
        /// Constant ASSOCIATING for ShareStatus
        /// </summary>
        public static readonly ShareStatus ASSOCIATING = new ShareStatus("ASSOCIATING");
        /// <summary>
        /// Constant EXPIRED for ShareStatus
        /// </summary>
        public static readonly ShareStatus EXPIRED = new ShareStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for ShareStatus
        /// </summary>
        public static readonly ShareStatus FAILED = new ShareStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ShareStatus
        /// </summary>
        public static readonly ShareStatus PENDING = new ShareStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for ShareStatus
        /// </summary>
        public static readonly ShareStatus REJECTED = new ShareStatus("REJECTED");
        /// <summary>
        /// Constant REVOKED for ShareStatus
        /// </summary>
        public static readonly ShareStatus REVOKED = new ShareStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatus FindValue(string value)
        {
            return FindValue<ShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustedAdvisorIntegrationStatus.
    /// </summary>
    public class TrustedAdvisorIntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for TrustedAdvisorIntegrationStatus
        /// </summary>
        public static readonly TrustedAdvisorIntegrationStatus DISABLED = new TrustedAdvisorIntegrationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for TrustedAdvisorIntegrationStatus
        /// </summary>
        public static readonly TrustedAdvisorIntegrationStatus ENABLED = new TrustedAdvisorIntegrationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustedAdvisorIntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustedAdvisorIntegrationStatus FindValue(string value)
        {
            return FindValue<TrustedAdvisorIntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustedAdvisorIntegrationStatus(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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
    /// Constants used for properties of type WorkloadEnvironment.
    /// </summary>
    public class WorkloadEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant PREPRODUCTION for WorkloadEnvironment
        /// </summary>
        public static readonly WorkloadEnvironment PREPRODUCTION = new WorkloadEnvironment("PREPRODUCTION");
        /// <summary>
        /// Constant PRODUCTION for WorkloadEnvironment
        /// </summary>
        public static readonly WorkloadEnvironment PRODUCTION = new WorkloadEnvironment("PRODUCTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEnvironment FindValue(string value)
        {
            return FindValue<WorkloadEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadImprovementStatus.
    /// </summary>
    public class WorkloadImprovementStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus COMPLETE = new WorkloadImprovementStatus("COMPLETE");
        /// <summary>
        /// Constant IN_PROGRESS for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus IN_PROGRESS = new WorkloadImprovementStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_APPLICABLE for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus NOT_APPLICABLE = new WorkloadImprovementStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant NOT_STARTED for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus NOT_STARTED = new WorkloadImprovementStatus("NOT_STARTED");
        /// <summary>
        /// Constant RISK_ACKNOWLEDGED for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus RISK_ACKNOWLEDGED = new WorkloadImprovementStatus("RISK_ACKNOWLEDGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadImprovementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadImprovementStatus FindValue(string value)
        {
            return FindValue<WorkloadImprovementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadImprovementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadIssueManagementStatus.
    /// </summary>
    public class WorkloadIssueManagementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WorkloadIssueManagementStatus
        /// </summary>
        public static readonly WorkloadIssueManagementStatus DISABLED = new WorkloadIssueManagementStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for WorkloadIssueManagementStatus
        /// </summary>
        public static readonly WorkloadIssueManagementStatus ENABLED = new WorkloadIssueManagementStatus("ENABLED");
        /// <summary>
        /// Constant INHERIT for WorkloadIssueManagementStatus
        /// </summary>
        public static readonly WorkloadIssueManagementStatus INHERIT = new WorkloadIssueManagementStatus("INHERIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadIssueManagementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadIssueManagementStatus FindValue(string value)
        {
            return FindValue<WorkloadIssueManagementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadIssueManagementStatus(string value)
        {
            return FindValue(value);
        }
    }

}