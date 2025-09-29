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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockRuntime
{

    /// <summary>
    /// Constants used for properties of type AsyncInvokeStatus.
    /// </summary>
    public class AsyncInvokeStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for AsyncInvokeStatus
        /// </summary>
        public static readonly AsyncInvokeStatus Completed = new AsyncInvokeStatus("Completed");
        /// <summary>
        /// Constant Failed for AsyncInvokeStatus
        /// </summary>
        public static readonly AsyncInvokeStatus Failed = new AsyncInvokeStatus("Failed");
        /// <summary>
        /// Constant InProgress for AsyncInvokeStatus
        /// </summary>
        public static readonly AsyncInvokeStatus InProgress = new AsyncInvokeStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AsyncInvokeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AsyncInvokeStatus FindValue(string value)
        {
            return FindValue<AsyncInvokeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AsyncInvokeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CachePointType.
    /// </summary>
    public class CachePointType : ConstantClass
    {

        /// <summary>
        /// Constant Default for CachePointType
        /// </summary>
        public static readonly CachePointType Default = new CachePointType("default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePointType FindValue(string value)
        {
            return FindValue<CachePointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationRole.
    /// </summary>
    public class ConversationRole : ConstantClass
    {

        /// <summary>
        /// Constant Assistant for ConversationRole
        /// </summary>
        public static readonly ConversationRole Assistant = new ConversationRole("assistant");
        /// <summary>
        /// Constant User for ConversationRole
        /// </summary>
        public static readonly ConversationRole User = new ConversationRole("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationRole FindValue(string value)
        {
            return FindValue<ConversationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFormat.
    /// </summary>
    public class DocumentFormat : ConstantClass
    {

        /// <summary>
        /// Constant Csv for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Csv = new DocumentFormat("csv");
        /// <summary>
        /// Constant Doc for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Doc = new DocumentFormat("doc");
        /// <summary>
        /// Constant Docx for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Docx = new DocumentFormat("docx");
        /// <summary>
        /// Constant Html for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Html = new DocumentFormat("html");
        /// <summary>
        /// Constant Md for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Md = new DocumentFormat("md");
        /// <summary>
        /// Constant Pdf for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Pdf = new DocumentFormat("pdf");
        /// <summary>
        /// Constant Txt for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Txt = new DocumentFormat("txt");
        /// <summary>
        /// Constant Xls for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Xls = new DocumentFormat("xls");
        /// <summary>
        /// Constant Xlsx for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat Xlsx = new DocumentFormat("xlsx");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFormat FindValue(string value)
        {
            return FindValue<DocumentFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailAction.
    /// </summary>
    public class GuardrailAction : ConstantClass
    {

        /// <summary>
        /// Constant GUARDRAIL_INTERVENED for GuardrailAction
        /// </summary>
        public static readonly GuardrailAction GUARDRAIL_INTERVENED = new GuardrailAction("GUARDRAIL_INTERVENED");
        /// <summary>
        /// Constant NONE for GuardrailAction
        /// </summary>
        public static readonly GuardrailAction NONE = new GuardrailAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailAction FindValue(string value)
        {
            return FindValue<GuardrailAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailAutomatedReasoningLogicWarningType.
    /// </summary>
    public class GuardrailAutomatedReasoningLogicWarningType : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS_FALSE for GuardrailAutomatedReasoningLogicWarningType
        /// </summary>
        public static readonly GuardrailAutomatedReasoningLogicWarningType ALWAYS_FALSE = new GuardrailAutomatedReasoningLogicWarningType("ALWAYS_FALSE");
        /// <summary>
        /// Constant ALWAYS_TRUE for GuardrailAutomatedReasoningLogicWarningType
        /// </summary>
        public static readonly GuardrailAutomatedReasoningLogicWarningType ALWAYS_TRUE = new GuardrailAutomatedReasoningLogicWarningType("ALWAYS_TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailAutomatedReasoningLogicWarningType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailAutomatedReasoningLogicWarningType FindValue(string value)
        {
            return FindValue<GuardrailAutomatedReasoningLogicWarningType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailAutomatedReasoningLogicWarningType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentFilterConfidence.
    /// </summary>
    public class GuardrailContentFilterConfidence : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence HIGH = new GuardrailContentFilterConfidence("HIGH");
        /// <summary>
        /// Constant LOW for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence LOW = new GuardrailContentFilterConfidence("LOW");
        /// <summary>
        /// Constant MEDIUM for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence MEDIUM = new GuardrailContentFilterConfidence("MEDIUM");
        /// <summary>
        /// Constant NONE for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence NONE = new GuardrailContentFilterConfidence("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentFilterConfidence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentFilterConfidence FindValue(string value)
        {
            return FindValue<GuardrailContentFilterConfidence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentFilterConfidence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentFilterStrength.
    /// </summary>
    public class GuardrailContentFilterStrength : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for GuardrailContentFilterStrength
        /// </summary>
        public static readonly GuardrailContentFilterStrength HIGH = new GuardrailContentFilterStrength("HIGH");
        /// <summary>
        /// Constant LOW for GuardrailContentFilterStrength
        /// </summary>
        public static readonly GuardrailContentFilterStrength LOW = new GuardrailContentFilterStrength("LOW");
        /// <summary>
        /// Constant MEDIUM for GuardrailContentFilterStrength
        /// </summary>
        public static readonly GuardrailContentFilterStrength MEDIUM = new GuardrailContentFilterStrength("MEDIUM");
        /// <summary>
        /// Constant NONE for GuardrailContentFilterStrength
        /// </summary>
        public static readonly GuardrailContentFilterStrength NONE = new GuardrailContentFilterStrength("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentFilterStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentFilterStrength FindValue(string value)
        {
            return FindValue<GuardrailContentFilterStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentFilterStrength(string value)
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
    /// Constants used for properties of type GuardrailContentPolicyAction.
    /// </summary>
    public class GuardrailContentPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailContentPolicyAction
        /// </summary>
        public static readonly GuardrailContentPolicyAction BLOCKED = new GuardrailContentPolicyAction("BLOCKED");
        /// <summary>
        /// Constant NONE for GuardrailContentPolicyAction
        /// </summary>
        public static readonly GuardrailContentPolicyAction NONE = new GuardrailContentPolicyAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailContentPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentQualifier.
    /// </summary>
    public class GuardrailContentQualifier : ConstantClass
    {

        /// <summary>
        /// Constant Grounding_source for GuardrailContentQualifier
        /// </summary>
        public static readonly GuardrailContentQualifier Grounding_source = new GuardrailContentQualifier("grounding_source");
        /// <summary>
        /// Constant Guard_content for GuardrailContentQualifier
        /// </summary>
        public static readonly GuardrailContentQualifier Guard_content = new GuardrailContentQualifier("guard_content");
        /// <summary>
        /// Constant Query for GuardrailContentQualifier
        /// </summary>
        public static readonly GuardrailContentQualifier Query = new GuardrailContentQualifier("query");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentQualifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentQualifier FindValue(string value)
        {
            return FindValue<GuardrailContentQualifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentQualifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentSource.
    /// </summary>
    public class GuardrailContentSource : ConstantClass
    {

        /// <summary>
        /// Constant INPUT for GuardrailContentSource
        /// </summary>
        public static readonly GuardrailContentSource INPUT = new GuardrailContentSource("INPUT");
        /// <summary>
        /// Constant OUTPUT for GuardrailContentSource
        /// </summary>
        public static readonly GuardrailContentSource OUTPUT = new GuardrailContentSource("OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentSource FindValue(string value)
        {
            return FindValue<GuardrailContentSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContextualGroundingFilterType.
    /// </summary>
    public class GuardrailContextualGroundingFilterType : ConstantClass
    {

        /// <summary>
        /// Constant GROUNDING for GuardrailContextualGroundingFilterType
        /// </summary>
        public static readonly GuardrailContextualGroundingFilterType GROUNDING = new GuardrailContextualGroundingFilterType("GROUNDING");
        /// <summary>
        /// Constant RELEVANCE for GuardrailContextualGroundingFilterType
        /// </summary>
        public static readonly GuardrailContextualGroundingFilterType RELEVANCE = new GuardrailContextualGroundingFilterType("RELEVANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContextualGroundingFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContextualGroundingFilterType FindValue(string value)
        {
            return FindValue<GuardrailContextualGroundingFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContextualGroundingFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContextualGroundingPolicyAction.
    /// </summary>
    public class GuardrailContextualGroundingPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailContextualGroundingPolicyAction
        /// </summary>
        public static readonly GuardrailContextualGroundingPolicyAction BLOCKED = new GuardrailContextualGroundingPolicyAction("BLOCKED");
        /// <summary>
        /// Constant NONE for GuardrailContextualGroundingPolicyAction
        /// </summary>
        public static readonly GuardrailContextualGroundingPolicyAction NONE = new GuardrailContextualGroundingPolicyAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContextualGroundingPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContextualGroundingPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailContextualGroundingPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContextualGroundingPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailConverseContentQualifier.
    /// </summary>
    public class GuardrailConverseContentQualifier : ConstantClass
    {

        /// <summary>
        /// Constant Grounding_source for GuardrailConverseContentQualifier
        /// </summary>
        public static readonly GuardrailConverseContentQualifier Grounding_source = new GuardrailConverseContentQualifier("grounding_source");
        /// <summary>
        /// Constant Guard_content for GuardrailConverseContentQualifier
        /// </summary>
        public static readonly GuardrailConverseContentQualifier Guard_content = new GuardrailConverseContentQualifier("guard_content");
        /// <summary>
        /// Constant Query for GuardrailConverseContentQualifier
        /// </summary>
        public static readonly GuardrailConverseContentQualifier Query = new GuardrailConverseContentQualifier("query");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailConverseContentQualifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailConverseContentQualifier FindValue(string value)
        {
            return FindValue<GuardrailConverseContentQualifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailConverseContentQualifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailConverseImageFormat.
    /// </summary>
    public class GuardrailConverseImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Jpeg for GuardrailConverseImageFormat
        /// </summary>
        public static readonly GuardrailConverseImageFormat Jpeg = new GuardrailConverseImageFormat("jpeg");
        /// <summary>
        /// Constant Png for GuardrailConverseImageFormat
        /// </summary>
        public static readonly GuardrailConverseImageFormat Png = new GuardrailConverseImageFormat("png");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailConverseImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailConverseImageFormat FindValue(string value)
        {
            return FindValue<GuardrailConverseImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailConverseImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailImageFormat.
    /// </summary>
    public class GuardrailImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Jpeg for GuardrailImageFormat
        /// </summary>
        public static readonly GuardrailImageFormat Jpeg = new GuardrailImageFormat("jpeg");
        /// <summary>
        /// Constant Png for GuardrailImageFormat
        /// </summary>
        public static readonly GuardrailImageFormat Png = new GuardrailImageFormat("png");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailImageFormat FindValue(string value)
        {
            return FindValue<GuardrailImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailManagedWordType.
    /// </summary>
    public class GuardrailManagedWordType : ConstantClass
    {

        /// <summary>
        /// Constant PROFANITY for GuardrailManagedWordType
        /// </summary>
        public static readonly GuardrailManagedWordType PROFANITY = new GuardrailManagedWordType("PROFANITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailManagedWordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailManagedWordType FindValue(string value)
        {
            return FindValue<GuardrailManagedWordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailManagedWordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailOutputScope.
    /// </summary>
    public class GuardrailOutputScope : ConstantClass
    {

        /// <summary>
        /// Constant FULL for GuardrailOutputScope
        /// </summary>
        public static readonly GuardrailOutputScope FULL = new GuardrailOutputScope("FULL");
        /// <summary>
        /// Constant INTERVENTIONS for GuardrailOutputScope
        /// </summary>
        public static readonly GuardrailOutputScope INTERVENTIONS = new GuardrailOutputScope("INTERVENTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailOutputScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailOutputScope FindValue(string value)
        {
            return FindValue<GuardrailOutputScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailOutputScope(string value)
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
    /// Constants used for properties of type GuardrailSensitiveInformationPolicyAction.
    /// </summary>
    public class GuardrailSensitiveInformationPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMIZED for GuardrailSensitiveInformationPolicyAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationPolicyAction ANONYMIZED = new GuardrailSensitiveInformationPolicyAction("ANONYMIZED");
        /// <summary>
        /// Constant BLOCKED for GuardrailSensitiveInformationPolicyAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationPolicyAction BLOCKED = new GuardrailSensitiveInformationPolicyAction("BLOCKED");
        /// <summary>
        /// Constant NONE for GuardrailSensitiveInformationPolicyAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationPolicyAction NONE = new GuardrailSensitiveInformationPolicyAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailSensitiveInformationPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailSensitiveInformationPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailSensitiveInformationPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailSensitiveInformationPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailStreamProcessingMode.
    /// </summary>
    public class GuardrailStreamProcessingMode : ConstantClass
    {

        /// <summary>
        /// Constant Async for GuardrailStreamProcessingMode
        /// </summary>
        public static readonly GuardrailStreamProcessingMode Async = new GuardrailStreamProcessingMode("async");
        /// <summary>
        /// Constant Sync for GuardrailStreamProcessingMode
        /// </summary>
        public static readonly GuardrailStreamProcessingMode Sync = new GuardrailStreamProcessingMode("sync");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailStreamProcessingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailStreamProcessingMode FindValue(string value)
        {
            return FindValue<GuardrailStreamProcessingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailStreamProcessingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailTopicPolicyAction.
    /// </summary>
    public class GuardrailTopicPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailTopicPolicyAction
        /// </summary>
        public static readonly GuardrailTopicPolicyAction BLOCKED = new GuardrailTopicPolicyAction("BLOCKED");
        /// <summary>
        /// Constant NONE for GuardrailTopicPolicyAction
        /// </summary>
        public static readonly GuardrailTopicPolicyAction NONE = new GuardrailTopicPolicyAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailTopicPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailTopicPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailTopicPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailTopicPolicyAction(string value)
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
    /// Constants used for properties of type GuardrailTrace.
    /// </summary>
    public class GuardrailTrace : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for GuardrailTrace
        /// </summary>
        public static readonly GuardrailTrace Disabled = new GuardrailTrace("disabled");
        /// <summary>
        /// Constant Enabled for GuardrailTrace
        /// </summary>
        public static readonly GuardrailTrace Enabled = new GuardrailTrace("enabled");
        /// <summary>
        /// Constant Enabled_full for GuardrailTrace
        /// </summary>
        public static readonly GuardrailTrace Enabled_full = new GuardrailTrace("enabled_full");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailTrace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailTrace FindValue(string value)
        {
            return FindValue<GuardrailTrace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailTrace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailWordPolicyAction.
    /// </summary>
    public class GuardrailWordPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailWordPolicyAction
        /// </summary>
        public static readonly GuardrailWordPolicyAction BLOCKED = new GuardrailWordPolicyAction("BLOCKED");
        /// <summary>
        /// Constant NONE for GuardrailWordPolicyAction
        /// </summary>
        public static readonly GuardrailWordPolicyAction NONE = new GuardrailWordPolicyAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailWordPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailWordPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailWordPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailWordPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFormat.
    /// </summary>
    public class ImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Gif for ImageFormat
        /// </summary>
        public static readonly ImageFormat Gif = new ImageFormat("gif");
        /// <summary>
        /// Constant Jpeg for ImageFormat
        /// </summary>
        public static readonly ImageFormat Jpeg = new ImageFormat("jpeg");
        /// <summary>
        /// Constant Png for ImageFormat
        /// </summary>
        public static readonly ImageFormat Png = new ImageFormat("png");
        /// <summary>
        /// Constant Webp for ImageFormat
        /// </summary>
        public static readonly ImageFormat Webp = new ImageFormat("webp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFormat FindValue(string value)
        {
            return FindValue<ImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PerformanceConfigLatency.
    /// </summary>
    public class PerformanceConfigLatency : ConstantClass
    {

        /// <summary>
        /// Constant Optimized for PerformanceConfigLatency
        /// </summary>
        public static readonly PerformanceConfigLatency Optimized = new PerformanceConfigLatency("optimized");
        /// <summary>
        /// Constant Standard for PerformanceConfigLatency
        /// </summary>
        public static readonly PerformanceConfigLatency Standard = new PerformanceConfigLatency("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PerformanceConfigLatency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PerformanceConfigLatency FindValue(string value)
        {
            return FindValue<PerformanceConfigLatency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PerformanceConfigLatency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortAsyncInvocationBy.
    /// </summary>
    public class SortAsyncInvocationBy : ConstantClass
    {

        /// <summary>
        /// Constant SubmissionTime for SortAsyncInvocationBy
        /// </summary>
        public static readonly SortAsyncInvocationBy SubmissionTime = new SortAsyncInvocationBy("SubmissionTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortAsyncInvocationBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortAsyncInvocationBy FindValue(string value)
        {
            return FindValue<SortAsyncInvocationBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortAsyncInvocationBy(string value)
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


    /// <summary>
    /// Constants used for properties of type StopReason.
    /// </summary>
    public class StopReason : ConstantClass
    {

        /// <summary>
        /// Constant Content_filtered for StopReason
        /// </summary>
        public static readonly StopReason Content_filtered = new StopReason("content_filtered");
        /// <summary>
        /// Constant End_turn for StopReason
        /// </summary>
        public static readonly StopReason End_turn = new StopReason("end_turn");
        /// <summary>
        /// Constant Guardrail_intervened for StopReason
        /// </summary>
        public static readonly StopReason Guardrail_intervened = new StopReason("guardrail_intervened");
        /// <summary>
        /// Constant Max_tokens for StopReason
        /// </summary>
        public static readonly StopReason Max_tokens = new StopReason("max_tokens");
        /// <summary>
        /// Constant Model_context_window_exceeded for StopReason
        /// </summary>
        public static readonly StopReason Model_context_window_exceeded = new StopReason("model_context_window_exceeded");
        /// <summary>
        /// Constant Stop_sequence for StopReason
        /// </summary>
        public static readonly StopReason Stop_sequence = new StopReason("stop_sequence");
        /// <summary>
        /// Constant Tool_use for StopReason
        /// </summary>
        public static readonly StopReason Tool_use = new StopReason("tool_use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopReason FindValue(string value)
        {
            return FindValue<StopReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ToolResultStatus.
    /// </summary>
    public class ToolResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for ToolResultStatus
        /// </summary>
        public static readonly ToolResultStatus Error = new ToolResultStatus("error");
        /// <summary>
        /// Constant Success for ToolResultStatus
        /// </summary>
        public static readonly ToolResultStatus Success = new ToolResultStatus("success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolResultStatus FindValue(string value)
        {
            return FindValue<ToolResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Trace.
    /// </summary>
    public class Trace : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Trace
        /// </summary>
        public static readonly Trace DISABLED = new Trace("DISABLED");
        /// <summary>
        /// Constant ENABLED for Trace
        /// </summary>
        public static readonly Trace ENABLED = new Trace("ENABLED");
        /// <summary>
        /// Constant ENABLED_FULL for Trace
        /// </summary>
        public static readonly Trace ENABLED_FULL = new Trace("ENABLED_FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Trace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Trace FindValue(string value)
        {
            return FindValue<Trace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Trace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoFormat.
    /// </summary>
    public class VideoFormat : ConstantClass
    {

        /// <summary>
        /// Constant Flv for VideoFormat
        /// </summary>
        public static readonly VideoFormat Flv = new VideoFormat("flv");
        /// <summary>
        /// Constant Mkv for VideoFormat
        /// </summary>
        public static readonly VideoFormat Mkv = new VideoFormat("mkv");
        /// <summary>
        /// Constant Mov for VideoFormat
        /// </summary>
        public static readonly VideoFormat Mov = new VideoFormat("mov");
        /// <summary>
        /// Constant Mp4 for VideoFormat
        /// </summary>
        public static readonly VideoFormat Mp4 = new VideoFormat("mp4");
        /// <summary>
        /// Constant Mpeg for VideoFormat
        /// </summary>
        public static readonly VideoFormat Mpeg = new VideoFormat("mpeg");
        /// <summary>
        /// Constant Mpg for VideoFormat
        /// </summary>
        public static readonly VideoFormat Mpg = new VideoFormat("mpg");
        /// <summary>
        /// Constant Three_gp for VideoFormat
        /// </summary>
        public static readonly VideoFormat Three_gp = new VideoFormat("three_gp");
        /// <summary>
        /// Constant Webm for VideoFormat
        /// </summary>
        public static readonly VideoFormat Webm = new VideoFormat("webm");
        /// <summary>
        /// Constant Wmv for VideoFormat
        /// </summary>
        public static readonly VideoFormat Wmv = new VideoFormat("wmv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoFormat FindValue(string value)
        {
            return FindValue<VideoFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoFormat(string value)
        {
            return FindValue(value);
        }
    }

}