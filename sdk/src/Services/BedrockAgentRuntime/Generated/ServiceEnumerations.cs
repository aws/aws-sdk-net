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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgentRuntime
{

    /// <summary>
    /// Constants used for properties of type CreationMode.
    /// </summary>
    public class CreationMode : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for CreationMode
        /// </summary>
        public static readonly CreationMode DEFAULT = new CreationMode("DEFAULT");
        /// <summary>
        /// Constant OVERRIDDEN for CreationMode
        /// </summary>
        public static readonly CreationMode OVERRIDDEN = new CreationMode("OVERRIDDEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreationMode FindValue(string value)
        {
            return FindValue<CreationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_GROUP for InvocationType
        /// </summary>
        public static readonly InvocationType ACTION_GROUP = new InvocationType("ACTION_GROUP");
        /// <summary>
        /// Constant FINISH for InvocationType
        /// </summary>
        public static readonly InvocationType FINISH = new InvocationType("FINISH");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for InvocationType
        /// </summary>
        public static readonly InvocationType KNOWLEDGE_BASE = new InvocationType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PromptType.
    /// </summary>
    public class PromptType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE_RESPONSE_GENERATION for PromptType
        /// </summary>
        public static readonly PromptType KNOWLEDGE_BASE_RESPONSE_GENERATION = new PromptType("KNOWLEDGE_BASE_RESPONSE_GENERATION");
        /// <summary>
        /// Constant ORCHESTRATION for PromptType
        /// </summary>
        public static readonly PromptType ORCHESTRATION = new PromptType("ORCHESTRATION");
        /// <summary>
        /// Constant POST_PROCESSING for PromptType
        /// </summary>
        public static readonly PromptType POST_PROCESSING = new PromptType("POST_PROCESSING");
        /// <summary>
        /// Constant PRE_PROCESSING for PromptType
        /// </summary>
        public static readonly PromptType PRE_PROCESSING = new PromptType("PRE_PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromptType FindValue(string value)
        {
            return FindValue<PromptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrievalResultLocationType.
    /// </summary>
    public class RetrievalResultLocationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType S3 = new RetrievalResultLocationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrievalResultLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrievalResultLocationType FindValue(string value)
        {
            return FindValue<RetrievalResultLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrievalResultLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrieveAndGenerateType.
    /// </summary>
    public class RetrieveAndGenerateType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for RetrieveAndGenerateType
        /// </summary>
        public static readonly RetrieveAndGenerateType KNOWLEDGE_BASE = new RetrieveAndGenerateType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrieveAndGenerateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrieveAndGenerateType FindValue(string value)
        {
            return FindValue<RetrieveAndGenerateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrieveAndGenerateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchType.
    /// </summary>
    public class SearchType : ConstantClass
    {

        /// <summary>
        /// Constant HYBRID for SearchType
        /// </summary>
        public static readonly SearchType HYBRID = new SearchType("HYBRID");
        /// <summary>
        /// Constant SEMANTIC for SearchType
        /// </summary>
        public static readonly SearchType SEMANTIC = new SearchType("SEMANTIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchType FindValue(string value)
        {
            return FindValue<SearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Source.
    /// </summary>
    public class Source : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_GROUP for Source
        /// </summary>
        public static readonly Source ACTION_GROUP = new Source("ACTION_GROUP");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for Source
        /// </summary>
        public static readonly Source KNOWLEDGE_BASE = new Source("KNOWLEDGE_BASE");
        /// <summary>
        /// Constant PARSER for Source
        /// </summary>
        public static readonly Source PARSER = new Source("PARSER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Source FindValue(string value)
        {
            return FindValue<Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_GROUP for Type
        /// </summary>
        public static readonly Type ACTION_GROUP = new Type("ACTION_GROUP");
        /// <summary>
        /// Constant ASK_USER for Type
        /// </summary>
        public static readonly Type ASK_USER = new Type("ASK_USER");
        /// <summary>
        /// Constant FINISH for Type
        /// </summary>
        public static readonly Type FINISH = new Type("FINISH");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for Type
        /// </summary>
        public static readonly Type KNOWLEDGE_BASE = new Type("KNOWLEDGE_BASE");
        /// <summary>
        /// Constant REPROMPT for Type
        /// </summary>
        public static readonly Type REPROMPT = new Type("REPROMPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}