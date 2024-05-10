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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Bedrock
{

    /// <summary>
    /// Constants used for properties of type CommitmentDuration.
    /// </summary>
    public class CommitmentDuration : ConstantClass
    {

        /// <summary>
        /// Constant OneMonth for CommitmentDuration
        /// </summary>
        public static readonly CommitmentDuration OneMonth = new CommitmentDuration("OneMonth");
        /// <summary>
        /// Constant SixMonths for CommitmentDuration
        /// </summary>
        public static readonly CommitmentDuration SixMonths = new CommitmentDuration("SixMonths");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommitmentDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommitmentDuration FindValue(string value)
        {
            return FindValue<CommitmentDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommitmentDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomizationType.
    /// </summary>
    public class CustomizationType : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUED_PRE_TRAINING for CustomizationType
        /// </summary>
        public static readonly CustomizationType CONTINUED_PRE_TRAINING = new CustomizationType("CONTINUED_PRE_TRAINING");
        /// <summary>
        /// Constant FINE_TUNING for CustomizationType
        /// </summary>
        public static readonly CustomizationType FINE_TUNING = new CustomizationType("FINE_TUNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomizationType FindValue(string value)
        {
            return FindValue<CustomizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationJobStatus.
    /// </summary>
    public class EvaluationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for EvaluationJobStatus
        /// </summary>
        public static readonly EvaluationJobStatus Completed = new EvaluationJobStatus("Completed");
        /// <summary>
        /// Constant Failed for EvaluationJobStatus
        /// </summary>
        public static readonly EvaluationJobStatus Failed = new EvaluationJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for EvaluationJobStatus
        /// </summary>
        public static readonly EvaluationJobStatus InProgress = new EvaluationJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for EvaluationJobStatus
        /// </summary>
        public static readonly EvaluationJobStatus Stopped = new EvaluationJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for EvaluationJobStatus
        /// </summary>
        public static readonly EvaluationJobStatus Stopping = new EvaluationJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationJobStatus FindValue(string value)
        {
            return FindValue<EvaluationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationJobType.
    /// </summary>
    public class EvaluationJobType : ConstantClass
    {

        /// <summary>
        /// Constant Automated for EvaluationJobType
        /// </summary>
        public static readonly EvaluationJobType Automated = new EvaluationJobType("Automated");
        /// <summary>
        /// Constant Human for EvaluationJobType
        /// </summary>
        public static readonly EvaluationJobType Human = new EvaluationJobType("Human");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationJobType FindValue(string value)
        {
            return FindValue<EvaluationJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationTaskType.
    /// </summary>
    public class EvaluationTaskType : ConstantClass
    {

        /// <summary>
        /// Constant Classification for EvaluationTaskType
        /// </summary>
        public static readonly EvaluationTaskType Classification = new EvaluationTaskType("Classification");
        /// <summary>
        /// Constant Custom for EvaluationTaskType
        /// </summary>
        public static readonly EvaluationTaskType Custom = new EvaluationTaskType("Custom");
        /// <summary>
        /// Constant Generation for EvaluationTaskType
        /// </summary>
        public static readonly EvaluationTaskType Generation = new EvaluationTaskType("Generation");
        /// <summary>
        /// Constant QuestionAndAnswer for EvaluationTaskType
        /// </summary>
        public static readonly EvaluationTaskType QuestionAndAnswer = new EvaluationTaskType("QuestionAndAnswer");
        /// <summary>
        /// Constant Summarization for EvaluationTaskType
        /// </summary>
        public static readonly EvaluationTaskType Summarization = new EvaluationTaskType("Summarization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationTaskType FindValue(string value)
        {
            return FindValue<EvaluationTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationTaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FineTuningJobStatus.
    /// </summary>
    public class FineTuningJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Completed = new FineTuningJobStatus("Completed");
        /// <summary>
        /// Constant Failed for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Failed = new FineTuningJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus InProgress = new FineTuningJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Stopped = new FineTuningJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Stopping = new FineTuningJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FineTuningJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FineTuningJobStatus FindValue(string value)
        {
            return FindValue<FineTuningJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FineTuningJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FoundationModelLifecycleStatus.
    /// </summary>
    public class FoundationModelLifecycleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FoundationModelLifecycleStatus
        /// </summary>
        public static readonly FoundationModelLifecycleStatus ACTIVE = new FoundationModelLifecycleStatus("ACTIVE");
        /// <summary>
        /// Constant LEGACY for FoundationModelLifecycleStatus
        /// </summary>
        public static readonly FoundationModelLifecycleStatus LEGACY = new FoundationModelLifecycleStatus("LEGACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FoundationModelLifecycleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FoundationModelLifecycleStatus FindValue(string value)
        {
            return FindValue<FoundationModelLifecycleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FoundationModelLifecycleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentFilterType.
    /// </summary>
    public class GuardrailContentFilterType : ConstantClass
    {

        /// <summary>
        /// Constant HATE for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType HATE = new GuardrailContentFilterType("HATE");
        /// <summary>
        /// Constant INSULTS for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType INSULTS = new GuardrailContentFilterType("INSULTS");
        /// <summary>
        /// Constant MISCONDUCT for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType MISCONDUCT = new GuardrailContentFilterType("MISCONDUCT");
        /// <summary>
        /// Constant PROMPT_ATTACK for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType PROMPT_ATTACK = new GuardrailContentFilterType("PROMPT_ATTACK");
        /// <summary>
        /// Constant SEXUAL for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType SEXUAL = new GuardrailContentFilterType("SEXUAL");
        /// <summary>
        /// Constant VIOLENCE for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType VIOLENCE = new GuardrailContentFilterType("VIOLENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentFilterType FindValue(string value)
        {
            return FindValue<GuardrailContentFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailFilterStrength.
    /// </summary>
    public class GuardrailFilterStrength : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength HIGH = new GuardrailFilterStrength("HIGH");
        /// <summary>
        /// Constant LOW for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength LOW = new GuardrailFilterStrength("LOW");
        /// <summary>
        /// Constant MEDIUM for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength MEDIUM = new GuardrailFilterStrength("MEDIUM");
        /// <summary>
        /// Constant NONE for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength NONE = new GuardrailFilterStrength("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailFilterStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailFilterStrength FindValue(string value)
        {
            return FindValue<GuardrailFilterStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailFilterStrength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailManagedWordsType.
    /// </summary>
    public class GuardrailManagedWordsType : ConstantClass
    {

        /// <summary>
        /// Constant PROFANITY for GuardrailManagedWordsType
        /// </summary>
        public static readonly GuardrailManagedWordsType PROFANITY = new GuardrailManagedWordsType("PROFANITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailManagedWordsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailManagedWordsType FindValue(string value)
        {
            return FindValue<GuardrailManagedWordsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailManagedWordsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailPiiEntityType.
    /// </summary>
    public class GuardrailPiiEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType ADDRESS = new GuardrailPiiEntityType("ADDRESS");
        /// <summary>
        /// Constant AGE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AGE = new GuardrailPiiEntityType("AGE");
        /// <summary>
        /// Constant AWS_ACCESS_KEY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AWS_ACCESS_KEY = new GuardrailPiiEntityType("AWS_ACCESS_KEY");
        /// <summary>
        /// Constant AWS_SECRET_KEY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AWS_SECRET_KEY = new GuardrailPiiEntityType("AWS_SECRET_KEY");
        /// <summary>
        /// Constant CA_HEALTH_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CA_HEALTH_NUMBER = new GuardrailPiiEntityType("CA_HEALTH_NUMBER");
        /// <summary>
        /// Constant CA_SOCIAL_INSURANCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CA_SOCIAL_INSURANCE_NUMBER = new GuardrailPiiEntityType("CA_SOCIAL_INSURANCE_NUMBER");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_CVV for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_CVV = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_CVV");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_EXPIRY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_EXPIRY = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_EXPIRY");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_NUMBER = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_NUMBER");
        /// <summary>
        /// Constant DRIVER_ID for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType DRIVER_ID = new GuardrailPiiEntityType("DRIVER_ID");
        /// <summary>
        /// Constant EMAIL for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType EMAIL = new GuardrailPiiEntityType("EMAIL");
        /// <summary>
        /// Constant INTERNATIONAL_BANK_ACCOUNT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType INTERNATIONAL_BANK_ACCOUNT_NUMBER = new GuardrailPiiEntityType("INTERNATIONAL_BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant IP_ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType IP_ADDRESS = new GuardrailPiiEntityType("IP_ADDRESS");
        /// <summary>
        /// Constant LICENSE_PLATE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType LICENSE_PLATE = new GuardrailPiiEntityType("LICENSE_PLATE");
        /// <summary>
        /// Constant MAC_ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType MAC_ADDRESS = new GuardrailPiiEntityType("MAC_ADDRESS");
        /// <summary>
        /// Constant NAME for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType NAME = new GuardrailPiiEntityType("NAME");
        /// <summary>
        /// Constant PASSWORD for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PASSWORD = new GuardrailPiiEntityType("PASSWORD");
        /// <summary>
        /// Constant PHONE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PHONE = new GuardrailPiiEntityType("PHONE");
        /// <summary>
        /// Constant PIN for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PIN = new GuardrailPiiEntityType("PIN");
        /// <summary>
        /// Constant SWIFT_CODE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType SWIFT_CODE = new GuardrailPiiEntityType("SWIFT_CODE");
        /// <summary>
        /// Constant UK_NATIONAL_HEALTH_SERVICE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_NATIONAL_HEALTH_SERVICE_NUMBER = new GuardrailPiiEntityType("UK_NATIONAL_HEALTH_SERVICE_NUMBER");
        /// <summary>
        /// Constant UK_NATIONAL_INSURANCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_NATIONAL_INSURANCE_NUMBER = new GuardrailPiiEntityType("UK_NATIONAL_INSURANCE_NUMBER");
        /// <summary>
        /// Constant UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER = new GuardrailPiiEntityType("UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER");
        /// <summary>
        /// Constant URL for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType URL = new GuardrailPiiEntityType("URL");
        /// <summary>
        /// Constant US_BANK_ACCOUNT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_BANK_ACCOUNT_NUMBER = new GuardrailPiiEntityType("US_BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant US_BANK_ROUTING_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_BANK_ROUTING_NUMBER = new GuardrailPiiEntityType("US_BANK_ROUTING_NUMBER");
        /// <summary>
        /// Constant US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER = new GuardrailPiiEntityType("US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER");
        /// <summary>
        /// Constant US_PASSPORT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_PASSPORT_NUMBER = new GuardrailPiiEntityType("US_PASSPORT_NUMBER");
        /// <summary>
        /// Constant US_SOCIAL_SECURITY_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_SOCIAL_SECURITY_NUMBER = new GuardrailPiiEntityType("US_SOCIAL_SECURITY_NUMBER");
        /// <summary>
        /// Constant USERNAME for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType USERNAME = new GuardrailPiiEntityType("USERNAME");
        /// <summary>
        /// Constant VEHICLE_IDENTIFICATION_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType VEHICLE_IDENTIFICATION_NUMBER = new GuardrailPiiEntityType("VEHICLE_IDENTIFICATION_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailPiiEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailPiiEntityType FindValue(string value)
        {
            return FindValue<GuardrailPiiEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailPiiEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailSensitiveInformationAction.
    /// </summary>
    public class GuardrailSensitiveInformationAction : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMIZE for GuardrailSensitiveInformationAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationAction ANONYMIZE = new GuardrailSensitiveInformationAction("ANONYMIZE");
        /// <summary>
        /// Constant BLOCK for GuardrailSensitiveInformationAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationAction BLOCK = new GuardrailSensitiveInformationAction("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailSensitiveInformationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailSensitiveInformationAction FindValue(string value)
        {
            return FindValue<GuardrailSensitiveInformationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailSensitiveInformationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailStatus.
    /// </summary>
    public class GuardrailStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus CREATING = new GuardrailStatus("CREATING");
        /// <summary>
        /// Constant DELETING for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus DELETING = new GuardrailStatus("DELETING");
        /// <summary>
        /// Constant FAILED for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus FAILED = new GuardrailStatus("FAILED");
        /// <summary>
        /// Constant READY for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus READY = new GuardrailStatus("READY");
        /// <summary>
        /// Constant UPDATING for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus UPDATING = new GuardrailStatus("UPDATING");
        /// <summary>
        /// Constant VERSIONING for GuardrailStatus
        /// </summary>
        public static readonly GuardrailStatus VERSIONING = new GuardrailStatus("VERSIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailStatus FindValue(string value)
        {
            return FindValue<GuardrailStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailTopicType.
    /// </summary>
    public class GuardrailTopicType : ConstantClass
    {

        /// <summary>
        /// Constant DENY for GuardrailTopicType
        /// </summary>
        public static readonly GuardrailTopicType DENY = new GuardrailTopicType("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailTopicType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailTopicType FindValue(string value)
        {
            return FindValue<GuardrailTopicType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailTopicType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceType.
    /// </summary>
    public class InferenceType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for InferenceType
        /// </summary>
        public static readonly InferenceType ON_DEMAND = new InferenceType("ON_DEMAND");
        /// <summary>
        /// Constant PROVISIONED for InferenceType
        /// </summary>
        public static readonly InferenceType PROVISIONED = new InferenceType("PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceType FindValue(string value)
        {
            return FindValue<InferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCustomization.
    /// </summary>
    public class ModelCustomization : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUED_PRE_TRAINING for ModelCustomization
        /// </summary>
        public static readonly ModelCustomization CONTINUED_PRE_TRAINING = new ModelCustomization("CONTINUED_PRE_TRAINING");
        /// <summary>
        /// Constant FINE_TUNING for ModelCustomization
        /// </summary>
        public static readonly ModelCustomization FINE_TUNING = new ModelCustomization("FINE_TUNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCustomization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCustomization FindValue(string value)
        {
            return FindValue<ModelCustomization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCustomization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCustomizationJobStatus.
    /// </summary>
    public class ModelCustomizationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Completed = new ModelCustomizationJobStatus("Completed");
        /// <summary>
        /// Constant Failed for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Failed = new ModelCustomizationJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus InProgress = new ModelCustomizationJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Stopped = new ModelCustomizationJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Stopping = new ModelCustomizationJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCustomizationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCustomizationJobStatus FindValue(string value)
        {
            return FindValue<ModelCustomizationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCustomizationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelModality.
    /// </summary>
    public class ModelModality : ConstantClass
    {

        /// <summary>
        /// Constant EMBEDDING for ModelModality
        /// </summary>
        public static readonly ModelModality EMBEDDING = new ModelModality("EMBEDDING");
        /// <summary>
        /// Constant IMAGE for ModelModality
        /// </summary>
        public static readonly ModelModality IMAGE = new ModelModality("IMAGE");
        /// <summary>
        /// Constant TEXT for ModelModality
        /// </summary>
        public static readonly ModelModality TEXT = new ModelModality("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelModality FindValue(string value)
        {
            return FindValue<ModelModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelModality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedModelStatus.
    /// </summary>
    public class ProvisionedModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for ProvisionedModelStatus
        /// </summary>
        public static readonly ProvisionedModelStatus Creating = new ProvisionedModelStatus("Creating");
        /// <summary>
        /// Constant Failed for ProvisionedModelStatus
        /// </summary>
        public static readonly ProvisionedModelStatus Failed = new ProvisionedModelStatus("Failed");
        /// <summary>
        /// Constant InService for ProvisionedModelStatus
        /// </summary>
        public static readonly ProvisionedModelStatus InService = new ProvisionedModelStatus("InService");
        /// <summary>
        /// Constant Updating for ProvisionedModelStatus
        /// </summary>
        public static readonly ProvisionedModelStatus Updating = new ProvisionedModelStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedModelStatus FindValue(string value)
        {
            return FindValue<ProvisionedModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortByProvisionedModels.
    /// </summary>
    public class SortByProvisionedModels : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortByProvisionedModels
        /// </summary>
        public static readonly SortByProvisionedModels CreationTime = new SortByProvisionedModels("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortByProvisionedModels(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortByProvisionedModels FindValue(string value)
        {
            return FindValue<SortByProvisionedModels>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortByProvisionedModels(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortJobsBy.
    /// </summary>
    public class SortJobsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortJobsBy
        /// </summary>
        public static readonly SortJobsBy CreationTime = new SortJobsBy("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortJobsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortJobsBy FindValue(string value)
        {
            return FindValue<SortJobsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortJobsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortModelsBy.
    /// </summary>
    public class SortModelsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortModelsBy
        /// </summary>
        public static readonly SortModelsBy CreationTime = new SortModelsBy("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortModelsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortModelsBy FindValue(string value)
        {
            return FindValue<SortModelsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortModelsBy(string value)
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
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

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

}