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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Resiliencehubv2
{

    /// <summary>
    /// Constants used for properties of type AchievabilityStatus.
    /// </summary>
    public class AchievabilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACHIEVABLE for AchievabilityStatus
        /// </summary>
        public static readonly AchievabilityStatus ACHIEVABLE = new AchievabilityStatus("ACHIEVABLE");
        /// <summary>
        /// Constant NOT_ACHIEVABLE for AchievabilityStatus
        /// </summary>
        public static readonly AchievabilityStatus NOT_ACHIEVABLE = new AchievabilityStatus("NOT_ACHIEVABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AchievabilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AchievabilityStatus FindValue(string value)
        {
            return FindValue<AchievabilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AchievabilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActorType.
    /// </summary>
    public class ActorType : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM for ActorType
        /// </summary>
        public static readonly ActorType SYSTEM = new ActorType("SYSTEM");
        /// <summary>
        /// Constant USER for ActorType
        /// </summary>
        public static readonly ActorType USER = new ActorType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActorType FindValue(string value)
        {
            return FindValue<ActorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssertionSource.
    /// </summary>
    public class AssertionSource : ConstantClass
    {

        /// <summary>
        /// Constant AI_GENERATED for AssertionSource
        /// </summary>
        public static readonly AssertionSource AI_GENERATED = new AssertionSource("AI_GENERATED");
        /// <summary>
        /// Constant USER for AssertionSource
        /// </summary>
        public static readonly AssertionSource USER = new AssertionSource("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssertionSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssertionSource FindValue(string value)
        {
            return FindValue<AssertionSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssertionSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentErrorCode.
    /// </summary>
    public class AssessmentErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_ERROR for AssessmentErrorCode
        /// </summary>
        public static readonly AssessmentErrorCode AGENT_ERROR = new AssessmentErrorCode("AGENT_ERROR");
        /// <summary>
        /// Constant CMK_ACCESS_DENIED for AssessmentErrorCode
        /// </summary>
        public static readonly AssessmentErrorCode CMK_ACCESS_DENIED = new AssessmentErrorCode("CMK_ACCESS_DENIED");
        /// <summary>
        /// Constant DESIGN_FILE_ACCESS_DENIED for AssessmentErrorCode
        /// </summary>
        public static readonly AssessmentErrorCode DESIGN_FILE_ACCESS_DENIED = new AssessmentErrorCode("DESIGN_FILE_ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for AssessmentErrorCode
        /// </summary>
        public static readonly AssessmentErrorCode INTERNAL_ERROR = new AssessmentErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_PERMISSIONS for AssessmentErrorCode
        /// </summary>
        public static readonly AssessmentErrorCode INVALID_PERMISSIONS = new AssessmentErrorCode("INVALID_PERMISSIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentErrorCode FindValue(string value)
        {
            return FindValue<AssessmentErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentSortField.
    /// </summary>
    public class AssessmentSortField : ConstantClass
    {

        /// <summary>
        /// Constant STARTED_AT for AssessmentSortField
        /// </summary>
        public static readonly AssessmentSortField STARTED_AT = new AssessmentSortField("STARTED_AT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentSortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentSortField FindValue(string value)
        {
            return FindValue<AssessmentSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentSortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentStatus.
    /// </summary>
    public class AssessmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus FAILED = new AssessmentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus IN_PROGRESS = new AssessmentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus NOT_STARTED = new AssessmentStatus("NOT_STARTED");
        /// <summary>
        /// Constant PENDING for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus PENDING = new AssessmentStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus SUCCESS = new AssessmentStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentStatus FindValue(string value)
        {
            return FindValue<AssessmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentStep.
    /// </summary>
    public class AssessmentStep : ConstantClass
    {

        /// <summary>
        /// Constant DESIGN_ANALYSIS for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep DESIGN_ANALYSIS = new AssessmentStep("DESIGN_ANALYSIS");
        /// <summary>
        /// Constant FAILURE_MODE_FINDINGS_CONSOLIDATION for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep FAILURE_MODE_FINDINGS_CONSOLIDATION = new AssessmentStep("FAILURE_MODE_FINDINGS_CONSOLIDATION");
        /// <summary>
        /// Constant FAILURE_MODE_FINDINGS_ENRICHMENT for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep FAILURE_MODE_FINDINGS_ENRICHMENT = new AssessmentStep("FAILURE_MODE_FINDINGS_ENRICHMENT");
        /// <summary>
        /// Constant INPUT_VALIDATION for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep INPUT_VALIDATION = new AssessmentStep("INPUT_VALIDATION");
        /// <summary>
        /// Constant POLICY_VALIDATION for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep POLICY_VALIDATION = new AssessmentStep("POLICY_VALIDATION");
        /// <summary>
        /// Constant RESILIENCE_ASSESSMENT for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep RESILIENCE_ASSESSMENT = new AssessmentStep("RESILIENCE_ASSESSMENT");
        /// <summary>
        /// Constant SERVICE_FUNCTION_GENERATION for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep SERVICE_FUNCTION_GENERATION = new AssessmentStep("SERVICE_FUNCTION_GENERATION");
        /// <summary>
        /// Constant TOPOLOGY_ENHANCEMENT for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep TOPOLOGY_ENHANCEMENT = new AssessmentStep("TOPOLOGY_ENHANCEMENT");
        /// <summary>
        /// Constant TOPOLOGY_GENERATION for AssessmentStep
        /// </summary>
        public static readonly AssessmentStep TOPOLOGY_GENERATION = new AssessmentStep("TOPOLOGY_GENERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentStep(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentStep FindValue(string value)
        {
            return FindValue<AssessmentStep>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentStep(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostCurrency.
    /// </summary>
    public class CostCurrency : ConstantClass
    {

        /// <summary>
        /// Constant USD for CostCurrency
        /// </summary>
        public static readonly CostCurrency USD = new CostCurrency("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostCurrency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostCurrency FindValue(string value)
        {
            return FindValue<CostCurrency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostCurrency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DependencyCriticality.
    /// </summary>
    public class DependencyCriticality : ConstantClass
    {

        /// <summary>
        /// Constant HARD for DependencyCriticality
        /// </summary>
        public static readonly DependencyCriticality HARD = new DependencyCriticality("HARD");
        /// <summary>
        /// Constant SOFT for DependencyCriticality
        /// </summary>
        public static readonly DependencyCriticality SOFT = new DependencyCriticality("SOFT");
        /// <summary>
        /// Constant UNKNOWN for DependencyCriticality
        /// </summary>
        public static readonly DependencyCriticality UNKNOWN = new DependencyCriticality("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DependencyCriticality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependencyCriticality FindValue(string value)
        {
            return FindValue<DependencyCriticality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependencyCriticality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DependencyDiscoveryInput.
    /// </summary>
    public class DependencyDiscoveryInput : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DependencyDiscoveryInput
        /// </summary>
        public static readonly DependencyDiscoveryInput DISABLED = new DependencyDiscoveryInput("DISABLED");
        /// <summary>
        /// Constant ENABLED for DependencyDiscoveryInput
        /// </summary>
        public static readonly DependencyDiscoveryInput ENABLED = new DependencyDiscoveryInput("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DependencyDiscoveryInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependencyDiscoveryInput FindValue(string value)
        {
            return FindValue<DependencyDiscoveryInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependencyDiscoveryInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DependencyDiscoveryStatus.
    /// </summary>
    public class DependencyDiscoveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DependencyDiscoveryStatus
        /// </summary>
        public static readonly DependencyDiscoveryStatus DISABLED = new DependencyDiscoveryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DependencyDiscoveryStatus
        /// </summary>
        public static readonly DependencyDiscoveryStatus ENABLED = new DependencyDiscoveryStatus("ENABLED");
        /// <summary>
        /// Constant INITIALIZING for DependencyDiscoveryStatus
        /// </summary>
        public static readonly DependencyDiscoveryStatus INITIALIZING = new DependencyDiscoveryStatus("INITIALIZING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DependencyDiscoveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependencyDiscoveryStatus FindValue(string value)
        {
            return FindValue<DependencyDiscoveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependencyDiscoveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureCategory.
    /// </summary>
    public class FailureCategory : ConstantClass
    {

        /// <summary>
        /// Constant EXCESSIVE_LATENCY for FailureCategory
        /// </summary>
        public static readonly FailureCategory EXCESSIVE_LATENCY = new FailureCategory("EXCESSIVE_LATENCY");
        /// <summary>
        /// Constant EXCESSIVE_LOAD for FailureCategory
        /// </summary>
        public static readonly FailureCategory EXCESSIVE_LOAD = new FailureCategory("EXCESSIVE_LOAD");
        /// <summary>
        /// Constant MISCONFIGURATION_AND_BUGS for FailureCategory
        /// </summary>
        public static readonly FailureCategory MISCONFIGURATION_AND_BUGS = new FailureCategory("MISCONFIGURATION_AND_BUGS");
        /// <summary>
        /// Constant SHARED_FATE for FailureCategory
        /// </summary>
        public static readonly FailureCategory SHARED_FATE = new FailureCategory("SHARED_FATE");
        /// <summary>
        /// Constant SINGLE_POINT_OF_FAILURE for FailureCategory
        /// </summary>
        public static readonly FailureCategory SINGLE_POINT_OF_FAILURE = new FailureCategory("SINGLE_POINT_OF_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureCategory FindValue(string value)
        {
            return FindValue<FailureCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingSeverity.
    /// </summary>
    public class FindingSeverity : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity HIGH = new FindingSeverity("HIGH");
        /// <summary>
        /// Constant LOW for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity LOW = new FindingSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity MEDIUM = new FindingSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingSeverity FindValue(string value)
        {
            return FindValue<FindingSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatus.
    /// </summary>
    public class FindingStatus : ConstantClass
    {

        /// <summary>
        /// Constant IRRELEVANT for FindingStatus
        /// </summary>
        public static readonly FindingStatus IRRELEVANT = new FindingStatus("IRRELEVANT");
        /// <summary>
        /// Constant OPEN for FindingStatus
        /// </summary>
        public static readonly FindingStatus OPEN = new FindingStatus("OPEN");
        /// <summary>
        /// Constant RESOLVED for FindingStatus
        /// </summary>
        public static readonly FindingStatus RESOLVED = new FindingStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatus FindValue(string value)
        {
            return FindValue<FindingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputSourceType.
    /// </summary>
    public class InputSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CFN_STACK for InputSourceType
        /// </summary>
        public static readonly InputSourceType CFN_STACK = new InputSourceType("CFN_STACK");
        /// <summary>
        /// Constant DESIGN_FILE for InputSourceType
        /// </summary>
        public static readonly InputSourceType DESIGN_FILE = new InputSourceType("DESIGN_FILE");
        /// <summary>
        /// Constant EKS for InputSourceType
        /// </summary>
        public static readonly InputSourceType EKS = new InputSourceType("EKS");
        /// <summary>
        /// Constant MONITORING for InputSourceType
        /// </summary>
        public static readonly InputSourceType MONITORING = new InputSourceType("MONITORING");
        /// <summary>
        /// Constant TAGS for InputSourceType
        /// </summary>
        public static readonly InputSourceType TAGS = new InputSourceType("TAGS");
        /// <summary>
        /// Constant TERRAFORM for InputSourceType
        /// </summary>
        public static readonly InputSourceType TERRAFORM = new InputSourceType("TERRAFORM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSourceType FindValue(string value)
        {
            return FindValue<InputSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiAzDisasterRecoveryApproach.
    /// </summary>
    public class MultiAzDisasterRecoveryApproach : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_ACTIVE for MultiAzDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiAzDisasterRecoveryApproach ACTIVE_ACTIVE = new MultiAzDisasterRecoveryApproach("ACTIVE_ACTIVE");
        /// <summary>
        /// Constant BACKUP_AND_RESTORE for MultiAzDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiAzDisasterRecoveryApproach BACKUP_AND_RESTORE = new MultiAzDisasterRecoveryApproach("BACKUP_AND_RESTORE");
        /// <summary>
        /// Constant HOT_STANDBY for MultiAzDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiAzDisasterRecoveryApproach HOT_STANDBY = new MultiAzDisasterRecoveryApproach("HOT_STANDBY");
        /// <summary>
        /// Constant PILOT_LIGHT for MultiAzDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiAzDisasterRecoveryApproach PILOT_LIGHT = new MultiAzDisasterRecoveryApproach("PILOT_LIGHT");
        /// <summary>
        /// Constant WARM_STANDBY for MultiAzDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiAzDisasterRecoveryApproach WARM_STANDBY = new MultiAzDisasterRecoveryApproach("WARM_STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiAzDisasterRecoveryApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiAzDisasterRecoveryApproach FindValue(string value)
        {
            return FindValue<MultiAzDisasterRecoveryApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiAzDisasterRecoveryApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiRegionDisasterRecoveryApproach.
    /// </summary>
    public class MultiRegionDisasterRecoveryApproach : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_ACTIVE for MultiRegionDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiRegionDisasterRecoveryApproach ACTIVE_ACTIVE = new MultiRegionDisasterRecoveryApproach("ACTIVE_ACTIVE");
        /// <summary>
        /// Constant BACKUP_AND_RESTORE for MultiRegionDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiRegionDisasterRecoveryApproach BACKUP_AND_RESTORE = new MultiRegionDisasterRecoveryApproach("BACKUP_AND_RESTORE");
        /// <summary>
        /// Constant HOT_STANDBY for MultiRegionDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiRegionDisasterRecoveryApproach HOT_STANDBY = new MultiRegionDisasterRecoveryApproach("HOT_STANDBY");
        /// <summary>
        /// Constant PILOT_LIGHT for MultiRegionDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiRegionDisasterRecoveryApproach PILOT_LIGHT = new MultiRegionDisasterRecoveryApproach("PILOT_LIGHT");
        /// <summary>
        /// Constant WARM_STANDBY for MultiRegionDisasterRecoveryApproach
        /// </summary>
        public static readonly MultiRegionDisasterRecoveryApproach WARM_STANDBY = new MultiRegionDisasterRecoveryApproach("WARM_STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiRegionDisasterRecoveryApproach(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiRegionDisasterRecoveryApproach FindValue(string value)
        {
            return FindValue<MultiRegionDisasterRecoveryApproach>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiRegionDisasterRecoveryApproach(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyComponent.
    /// </summary>
    public class PolicyComponent : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABILITY_SLO for PolicyComponent
        /// </summary>
        public static readonly PolicyComponent AVAILABILITY_SLO = new PolicyComponent("AVAILABILITY_SLO");
        /// <summary>
        /// Constant DATA_RECOVERY for PolicyComponent
        /// </summary>
        public static readonly PolicyComponent DATA_RECOVERY = new PolicyComponent("DATA_RECOVERY");
        /// <summary>
        /// Constant MULTI_AZ_DISASTER_RECOVERY for PolicyComponent
        /// </summary>
        public static readonly PolicyComponent MULTI_AZ_DISASTER_RECOVERY = new PolicyComponent("MULTI_AZ_DISASTER_RECOVERY");
        /// <summary>
        /// Constant MULTI_REGION_DISASTER_RECOVERY for PolicyComponent
        /// </summary>
        public static readonly PolicyComponent MULTI_REGION_DISASTER_RECOVERY = new PolicyComponent("MULTI_REGION_DISASTER_RECOVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyComponent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyComponent FindValue(string value)
        {
            return FindValue<PolicyComponent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyComponent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyValueSource.
    /// </summary>
    public class PolicyValueSource : ConstantClass
    {

        /// <summary>
        /// Constant CROSS_ACCOUNT for PolicyValueSource
        /// </summary>
        public static readonly PolicyValueSource CROSS_ACCOUNT = new PolicyValueSource("CROSS_ACCOUNT");
        /// <summary>
        /// Constant SELF for PolicyValueSource
        /// </summary>
        public static readonly PolicyValueSource SELF = new PolicyValueSource("SELF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyValueSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyValueSource FindValue(string value)
        {
            return FindValue<PolicyValueSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyValueSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryGranularity.
    /// </summary>
    public class QueryGranularity : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for QueryGranularity
        /// </summary>
        public static readonly QueryGranularity DAILY = new QueryGranularity("DAILY");
        /// <summary>
        /// Constant HOURLY for QueryGranularity
        /// </summary>
        public static readonly QueryGranularity HOURLY = new QueryGranularity("HOURLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryGranularity FindValue(string value)
        {
            return FindValue<QueryGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryGranularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportGenerationErrorCode.
    /// </summary>
    public class ReportGenerationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_ERROR for ReportGenerationErrorCode
        /// </summary>
        public static readonly ReportGenerationErrorCode CONFIGURATION_ERROR = new ReportGenerationErrorCode("CONFIGURATION_ERROR");
        /// <summary>
        /// Constant INSUFFICIENT_PERMISSIONS for ReportGenerationErrorCode
        /// </summary>
        public static readonly ReportGenerationErrorCode INSUFFICIENT_PERMISSIONS = new ReportGenerationErrorCode("INSUFFICIENT_PERMISSIONS");
        /// <summary>
        /// Constant INTERNAL_ERROR for ReportGenerationErrorCode
        /// </summary>
        public static readonly ReportGenerationErrorCode INTERNAL_ERROR = new ReportGenerationErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportGenerationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportGenerationErrorCode FindValue(string value)
        {
            return FindValue<ReportGenerationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportGenerationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportGenerationStatus.
    /// </summary>
    public class ReportGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReportGenerationStatus
        /// </summary>
        public static readonly ReportGenerationStatus FAILED = new ReportGenerationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ReportGenerationStatus
        /// </summary>
        public static readonly ReportGenerationStatus PENDING = new ReportGenerationStatus("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for ReportGenerationStatus
        /// </summary>
        public static readonly ReportGenerationStatus SUCCEEDED = new ReportGenerationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportGenerationStatus FindValue(string value)
        {
            return FindValue<ReportGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportType.
    /// </summary>
    public class ReportType : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE_MODE for ReportType
        /// </summary>
        public static readonly ReportType FAILURE_MODE = new ReportType("FAILURE_MODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportType FindValue(string value)
        {
            return FindValue<ReportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceDiscoveryErrorCode.
    /// </summary>
    public class ResourceDiscoveryErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode ACCESS_DENIED = new ResourceDiscoveryErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant CLUSTER_NOT_FOUND for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode CLUSTER_NOT_FOUND = new ResourceDiscoveryErrorCode("CLUSTER_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode INTERNAL_ERROR = new ResourceDiscoveryErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_PERMISSIONS for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode INVALID_PERMISSIONS = new ResourceDiscoveryErrorCode("INVALID_PERMISSIONS");
        /// <summary>
        /// Constant STACK_NOT_FOUND for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode STACK_NOT_FOUND = new ResourceDiscoveryErrorCode("STACK_NOT_FOUND");
        /// <summary>
        /// Constant STATE_FILE_NOT_FOUND for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode STATE_FILE_NOT_FOUND = new ResourceDiscoveryErrorCode("STATE_FILE_NOT_FOUND");
        /// <summary>
        /// Constant UNSUPPORTED_CLUSTER for ResourceDiscoveryErrorCode
        /// </summary>
        public static readonly ResourceDiscoveryErrorCode UNSUPPORTED_CLUSTER = new ResourceDiscoveryErrorCode("UNSUPPORTED_CLUSTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceDiscoveryErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceDiscoveryErrorCode FindValue(string value)
        {
            return FindValue<ResourceDiscoveryErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceDiscoveryErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceDiscoveryRunStatus.
    /// </summary>
    public class ResourceDiscoveryRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ResourceDiscoveryRunStatus
        /// </summary>
        public static readonly ResourceDiscoveryRunStatus COMPLETED_WITH_FAILURES = new ResourceDiscoveryRunStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ResourceDiscoveryRunStatus
        /// </summary>
        public static readonly ResourceDiscoveryRunStatus FAILED = new ResourceDiscoveryRunStatus("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for ResourceDiscoveryRunStatus
        /// </summary>
        public static readonly ResourceDiscoveryRunStatus NOT_STARTED = new ResourceDiscoveryRunStatus("NOT_STARTED");
        /// <summary>
        /// Constant RUNNING for ResourceDiscoveryRunStatus
        /// </summary>
        public static readonly ResourceDiscoveryRunStatus RUNNING = new ResourceDiscoveryRunStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for ResourceDiscoveryRunStatus
        /// </summary>
        public static readonly ResourceDiscoveryRunStatus SUCCEEDED = new ResourceDiscoveryRunStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceDiscoveryRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceDiscoveryRunStatus FindValue(string value)
        {
            return FindValue<ResourceDiscoveryRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceDiscoveryRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceEventType.
    /// </summary>
    public class ServiceEventType : ConstantClass
    {

        /// <summary>
        /// Constant ASSERTION_CREATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType ASSERTION_CREATED = new ServiceEventType("ASSERTION_CREATED");
        /// <summary>
        /// Constant ASSERTION_DELETED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType ASSERTION_DELETED = new ServiceEventType("ASSERTION_DELETED");
        /// <summary>
        /// Constant ASSERTION_UPDATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType ASSERTION_UPDATED = new ServiceEventType("ASSERTION_UPDATED");
        /// <summary>
        /// Constant SERVICE_ACHIEVABILITY_UPDATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_ACHIEVABILITY_UPDATED = new ServiceEventType("SERVICE_ACHIEVABILITY_UPDATED");
        /// <summary>
        /// Constant SERVICE_CREATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_CREATED = new ServiceEventType("SERVICE_CREATED");
        /// <summary>
        /// Constant SERVICE_DELETED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_DELETED = new ServiceEventType("SERVICE_DELETED");
        /// <summary>
        /// Constant SERVICE_FUNCTION_CREATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_FUNCTION_CREATED = new ServiceEventType("SERVICE_FUNCTION_CREATED");
        /// <summary>
        /// Constant SERVICE_FUNCTION_DELETED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_FUNCTION_DELETED = new ServiceEventType("SERVICE_FUNCTION_DELETED");
        /// <summary>
        /// Constant SERVICE_FUNCTION_RESOURCES_ADDED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_FUNCTION_RESOURCES_ADDED = new ServiceEventType("SERVICE_FUNCTION_RESOURCES_ADDED");
        /// <summary>
        /// Constant SERVICE_FUNCTION_RESOURCES_REMOVED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_FUNCTION_RESOURCES_REMOVED = new ServiceEventType("SERVICE_FUNCTION_RESOURCES_REMOVED");
        /// <summary>
        /// Constant SERVICE_FUNCTION_UPDATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_FUNCTION_UPDATED = new ServiceEventType("SERVICE_FUNCTION_UPDATED");
        /// <summary>
        /// Constant SERVICE_INPUT_SOURCES_UPDATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_INPUT_SOURCES_UPDATED = new ServiceEventType("SERVICE_INPUT_SOURCES_UPDATED");
        /// <summary>
        /// Constant SERVICE_POLICY_ASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_POLICY_ASSOCIATED = new ServiceEventType("SERVICE_POLICY_ASSOCIATED");
        /// <summary>
        /// Constant SERVICE_POLICY_DISASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_POLICY_DISASSOCIATED = new ServiceEventType("SERVICE_POLICY_DISASSOCIATED");
        /// <summary>
        /// Constant SERVICE_RESOURCES_ASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_RESOURCES_ASSOCIATED = new ServiceEventType("SERVICE_RESOURCES_ASSOCIATED");
        /// <summary>
        /// Constant SERVICE_RESOURCES_DISASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_RESOURCES_DISASSOCIATED = new ServiceEventType("SERVICE_RESOURCES_DISASSOCIATED");
        /// <summary>
        /// Constant SERVICE_SYSTEM_ASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_SYSTEM_ASSOCIATED = new ServiceEventType("SERVICE_SYSTEM_ASSOCIATED");
        /// <summary>
        /// Constant SERVICE_SYSTEM_DISASSOCIATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_SYSTEM_DISASSOCIATED = new ServiceEventType("SERVICE_SYSTEM_DISASSOCIATED");
        /// <summary>
        /// Constant SERVICE_WORKFLOW_UPDATED for ServiceEventType
        /// </summary>
        public static readonly ServiceEventType SERVICE_WORKFLOW_UPDATED = new ServiceEventType("SERVICE_WORKFLOW_UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceEventType FindValue(string value)
        {
            return FindValue<ServiceEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceFunctionCriticality.
    /// </summary>
    public class ServiceFunctionCriticality : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY for ServiceFunctionCriticality
        /// </summary>
        public static readonly ServiceFunctionCriticality PRIMARY = new ServiceFunctionCriticality("PRIMARY");
        /// <summary>
        /// Constant SUPPLEMENTAL for ServiceFunctionCriticality
        /// </summary>
        public static readonly ServiceFunctionCriticality SUPPLEMENTAL = new ServiceFunctionCriticality("SUPPLEMENTAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceFunctionCriticality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceFunctionCriticality FindValue(string value)
        {
            return FindValue<ServiceFunctionCriticality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceFunctionCriticality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceFunctionSource.
    /// </summary>
    public class ServiceFunctionSource : ConstantClass
    {

        /// <summary>
        /// Constant AI_GENERATED for ServiceFunctionSource
        /// </summary>
        public static readonly ServiceFunctionSource AI_GENERATED = new ServiceFunctionSource("AI_GENERATED");
        /// <summary>
        /// Constant USER for ServiceFunctionSource
        /// </summary>
        public static readonly ServiceFunctionSource USER = new ServiceFunctionSource("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceFunctionSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceFunctionSource FindValue(string value)
        {
            return FindValue<ServiceFunctionSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceFunctionSource(string value)
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
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

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
    /// Constants used for properties of type SystemEventType.
    /// </summary>
    public class SystemEventType : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM_CREATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_CREATED = new SystemEventType("SYSTEM_CREATED");
        /// <summary>
        /// Constant SYSTEM_DELETED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_DELETED = new SystemEventType("SYSTEM_DELETED");
        /// <summary>
        /// Constant SYSTEM_POLICY_ASSOCIATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_POLICY_ASSOCIATED = new SystemEventType("SYSTEM_POLICY_ASSOCIATED");
        /// <summary>
        /// Constant SYSTEM_POLICY_DISASSOCIATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_POLICY_DISASSOCIATED = new SystemEventType("SYSTEM_POLICY_DISASSOCIATED");
        /// <summary>
        /// Constant SYSTEM_SERVICE_ASSOCIATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_SERVICE_ASSOCIATED = new SystemEventType("SYSTEM_SERVICE_ASSOCIATED");
        /// <summary>
        /// Constant SYSTEM_SERVICE_DISASSOCIATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_SERVICE_DISASSOCIATED = new SystemEventType("SYSTEM_SERVICE_DISASSOCIATED");
        /// <summary>
        /// Constant SYSTEM_USER_JOURNEY_CREATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_USER_JOURNEY_CREATED = new SystemEventType("SYSTEM_USER_JOURNEY_CREATED");
        /// <summary>
        /// Constant SYSTEM_USER_JOURNEY_DELETED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_USER_JOURNEY_DELETED = new SystemEventType("SYSTEM_USER_JOURNEY_DELETED");
        /// <summary>
        /// Constant SYSTEM_USER_JOURNEY_UPDATED for SystemEventType
        /// </summary>
        public static readonly SystemEventType SYSTEM_USER_JOURNEY_UPDATED = new SystemEventType("SYSTEM_USER_JOURNEY_UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemEventType FindValue(string value)
        {
            return FindValue<SystemEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopologyType.
    /// </summary>
    public class TopologyType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINMENT for TopologyType
        /// </summary>
        public static readonly TopologyType CONTAINMENT = new TopologyType("CONTAINMENT");
        /// <summary>
        /// Constant DATA_FLOW for TopologyType
        /// </summary>
        public static readonly TopologyType DATA_FLOW = new TopologyType("DATA_FLOW");
        /// <summary>
        /// Constant OBSERVABILITY for TopologyType
        /// </summary>
        public static readonly TopologyType OBSERVABILITY = new TopologyType("OBSERVABILITY");
        /// <summary>
        /// Constant PERMISSIONS for TopologyType
        /// </summary>
        public static readonly TopologyType PERMISSIONS = new TopologyType("PERMISSIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopologyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopologyType FindValue(string value)
        {
            return FindValue<TopologyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopologyType(string value)
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
        /// Constant DUPLICATE_VALUE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DUPLICATE_VALUE = new ValidationExceptionReason("DUPLICATE_VALUE");
        /// <summary>
        /// Constant INVALID_FIELD_VALUE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_FIELD_VALUE = new ValidationExceptionReason("INVALID_FIELD_VALUE");
        /// <summary>
        /// Constant MISSING_REQUIRED_FIELD for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_REQUIRED_FIELD = new ValidationExceptionReason("MISSING_REQUIRED_FIELD");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

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

}