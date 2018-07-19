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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Comprehend
{

    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant COMMERCIAL_ITEM for EntityType
        /// </summary>
        public static readonly EntityType COMMERCIAL_ITEM = new EntityType("COMMERCIAL_ITEM");
        /// <summary>
        /// Constant DATE for EntityType
        /// </summary>
        public static readonly EntityType DATE = new EntityType("DATE");
        /// <summary>
        /// Constant EVENT for EntityType
        /// </summary>
        public static readonly EntityType EVENT = new EntityType("EVENT");
        /// <summary>
        /// Constant LOCATION for EntityType
        /// </summary>
        public static readonly EntityType LOCATION = new EntityType("LOCATION");
        /// <summary>
        /// Constant ORGANIZATION for EntityType
        /// </summary>
        public static readonly EntityType ORGANIZATION = new EntityType("ORGANIZATION");
        /// <summary>
        /// Constant OTHER for EntityType
        /// </summary>
        public static readonly EntityType OTHER = new EntityType("OTHER");
        /// <summary>
        /// Constant PERSON for EntityType
        /// </summary>
        public static readonly EntityType PERSON = new EntityType("PERSON");
        /// <summary>
        /// Constant QUANTITY for EntityType
        /// </summary>
        public static readonly EntityType QUANTITY = new EntityType("QUANTITY");
        /// <summary>
        /// Constant TITLE for EntityType
        /// </summary>
        public static readonly EntityType TITLE = new EntityType("TITLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputFormat.
    /// </summary>
    public class InputFormat : ConstantClass
    {

        /// <summary>
        /// Constant ONE_DOC_PER_FILE for InputFormat
        /// </summary>
        public static readonly InputFormat ONE_DOC_PER_FILE = new InputFormat("ONE_DOC_PER_FILE");
        /// <summary>
        /// Constant ONE_DOC_PER_LINE for InputFormat
        /// </summary>
        public static readonly InputFormat ONE_DOC_PER_LINE = new InputFormat("ONE_DOC_PER_LINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputFormat FindValue(string value)
        {
            return FindValue<InputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant STOP_REQUESTED for JobStatus
        /// </summary>
        public static readonly JobStatus STOP_REQUESTED = new JobStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for JobStatus
        /// </summary>
        public static readonly JobStatus STOPPED = new JobStatus("STOPPED");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant En for LanguageCode
        /// </summary>
        public static readonly LanguageCode En = new LanguageCode("en");
        /// <summary>
        /// Constant Es for LanguageCode
        /// </summary>
        public static readonly LanguageCode Es = new LanguageCode("es");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartOfSpeechTagType.
    /// </summary>
    public class PartOfSpeechTagType : ConstantClass
    {

        /// <summary>
        /// Constant ADJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADJ = new PartOfSpeechTagType("ADJ");
        /// <summary>
        /// Constant ADP for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADP = new PartOfSpeechTagType("ADP");
        /// <summary>
        /// Constant ADV for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADV = new PartOfSpeechTagType("ADV");
        /// <summary>
        /// Constant AUX for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType AUX = new PartOfSpeechTagType("AUX");
        /// <summary>
        /// Constant CONJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType CONJ = new PartOfSpeechTagType("CONJ");
        /// <summary>
        /// Constant DET for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType DET = new PartOfSpeechTagType("DET");
        /// <summary>
        /// Constant INTJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType INTJ = new PartOfSpeechTagType("INTJ");
        /// <summary>
        /// Constant NOUN for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType NOUN = new PartOfSpeechTagType("NOUN");
        /// <summary>
        /// Constant NUM for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType NUM = new PartOfSpeechTagType("NUM");
        /// <summary>
        /// Constant O for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType O = new PartOfSpeechTagType("O");
        /// <summary>
        /// Constant PART for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PART = new PartOfSpeechTagType("PART");
        /// <summary>
        /// Constant PRON for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PRON = new PartOfSpeechTagType("PRON");
        /// <summary>
        /// Constant PROPN for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PROPN = new PartOfSpeechTagType("PROPN");
        /// <summary>
        /// Constant PUNCT for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PUNCT = new PartOfSpeechTagType("PUNCT");
        /// <summary>
        /// Constant SCONJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType SCONJ = new PartOfSpeechTagType("SCONJ");
        /// <summary>
        /// Constant SYM for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType SYM = new PartOfSpeechTagType("SYM");
        /// <summary>
        /// Constant VERB for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType VERB = new PartOfSpeechTagType("VERB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartOfSpeechTagType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartOfSpeechTagType FindValue(string value)
        {
            return FindValue<PartOfSpeechTagType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartOfSpeechTagType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SentimentType.
    /// </summary>
    public class SentimentType : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for SentimentType
        /// </summary>
        public static readonly SentimentType MIXED = new SentimentType("MIXED");
        /// <summary>
        /// Constant NEGATIVE for SentimentType
        /// </summary>
        public static readonly SentimentType NEGATIVE = new SentimentType("NEGATIVE");
        /// <summary>
        /// Constant NEUTRAL for SentimentType
        /// </summary>
        public static readonly SentimentType NEUTRAL = new SentimentType("NEUTRAL");
        /// <summary>
        /// Constant POSITIVE for SentimentType
        /// </summary>
        public static readonly SentimentType POSITIVE = new SentimentType("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SentimentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SentimentType FindValue(string value)
        {
            return FindValue<SentimentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SentimentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyntaxLanguageCode.
    /// </summary>
    public class SyntaxLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant En for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode En = new SyntaxLanguageCode("en");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyntaxLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyntaxLanguageCode FindValue(string value)
        {
            return FindValue<SyntaxLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyntaxLanguageCode(string value)
        {
            return FindValue(value);
        }
    }

}