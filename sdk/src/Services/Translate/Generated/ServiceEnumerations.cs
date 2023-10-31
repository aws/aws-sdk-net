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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Translate
{

    /// <summary>
    /// Constants used for properties of type Brevity.
    /// </summary>
    public class Brevity : ConstantClass
    {

        /// <summary>
        /// Constant ON for Brevity
        /// </summary>
        public static readonly Brevity ON = new Brevity("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Brevity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Brevity FindValue(string value)
        {
            return FindValue<Brevity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Brevity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Directionality.
    /// </summary>
    public class Directionality : ConstantClass
    {

        /// <summary>
        /// Constant MULTI for Directionality
        /// </summary>
        public static readonly Directionality MULTI = new Directionality("MULTI");
        /// <summary>
        /// Constant UNI for Directionality
        /// </summary>
        public static readonly Directionality UNI = new Directionality("UNI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Directionality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Directionality FindValue(string value)
        {
            return FindValue<Directionality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Directionality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisplayLanguageCode.
    /// </summary>
    public class DisplayLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant De for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode De = new DisplayLanguageCode("de");
        /// <summary>
        /// Constant En for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode En = new DisplayLanguageCode("en");
        /// <summary>
        /// Constant Es for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Es = new DisplayLanguageCode("es");
        /// <summary>
        /// Constant Fr for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Fr = new DisplayLanguageCode("fr");
        /// <summary>
        /// Constant It for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode It = new DisplayLanguageCode("it");
        /// <summary>
        /// Constant Ja for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Ja = new DisplayLanguageCode("ja");
        /// <summary>
        /// Constant Ko for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Ko = new DisplayLanguageCode("ko");
        /// <summary>
        /// Constant Pt for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Pt = new DisplayLanguageCode("pt");
        /// <summary>
        /// Constant Zh for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode Zh = new DisplayLanguageCode("zh");
        /// <summary>
        /// Constant ZhTW for DisplayLanguageCode
        /// </summary>
        public static readonly DisplayLanguageCode ZhTW = new DisplayLanguageCode("zh-TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisplayLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisplayLanguageCode FindValue(string value)
        {
            return FindValue<DisplayLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisplayLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionKeyType.
    /// </summary>
    public class EncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionKeyType
        /// </summary>
        public static readonly EncryptionKeyType KMS = new EncryptionKeyType("KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionKeyType FindValue(string value)
        {
            return FindValue<EncryptionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Formality.
    /// </summary>
    public class Formality : ConstantClass
    {

        /// <summary>
        /// Constant FORMAL for Formality
        /// </summary>
        public static readonly Formality FORMAL = new Formality("FORMAL");
        /// <summary>
        /// Constant INFORMAL for Formality
        /// </summary>
        public static readonly Formality INFORMAL = new Formality("INFORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Formality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Formality FindValue(string value)
        {
            return FindValue<Formality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Formality(string value)
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
        /// Constant COMPLETED_WITH_ERROR for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED_WITH_ERROR = new JobStatus("COMPLETED_WITH_ERROR");
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
    /// Constants used for properties of type MergeStrategy.
    /// </summary>
    public class MergeStrategy : ConstantClass
    {

        /// <summary>
        /// Constant OVERWRITE for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy OVERWRITE = new MergeStrategy("OVERWRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MergeStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MergeStrategy FindValue(string value)
        {
            return FindValue<MergeStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MergeStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParallelDataFormat.
    /// </summary>
    public class ParallelDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ParallelDataFormat
        /// </summary>
        public static readonly ParallelDataFormat CSV = new ParallelDataFormat("CSV");
        /// <summary>
        /// Constant TMX for ParallelDataFormat
        /// </summary>
        public static readonly ParallelDataFormat TMX = new ParallelDataFormat("TMX");
        /// <summary>
        /// Constant TSV for ParallelDataFormat
        /// </summary>
        public static readonly ParallelDataFormat TSV = new ParallelDataFormat("TSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParallelDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParallelDataFormat FindValue(string value)
        {
            return FindValue<ParallelDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParallelDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParallelDataStatus.
    /// </summary>
    public class ParallelDataStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ParallelDataStatus
        /// </summary>
        public static readonly ParallelDataStatus ACTIVE = new ParallelDataStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ParallelDataStatus
        /// </summary>
        public static readonly ParallelDataStatus CREATING = new ParallelDataStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ParallelDataStatus
        /// </summary>
        public static readonly ParallelDataStatus DELETING = new ParallelDataStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ParallelDataStatus
        /// </summary>
        public static readonly ParallelDataStatus FAILED = new ParallelDataStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ParallelDataStatus
        /// </summary>
        public static readonly ParallelDataStatus UPDATING = new ParallelDataStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParallelDataStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParallelDataStatus FindValue(string value)
        {
            return FindValue<ParallelDataStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParallelDataStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Profanity.
    /// </summary>
    public class Profanity : ConstantClass
    {

        /// <summary>
        /// Constant MASK for Profanity
        /// </summary>
        public static readonly Profanity MASK = new Profanity("MASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Profanity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Profanity FindValue(string value)
        {
            return FindValue<Profanity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Profanity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TerminologyDataFormat.
    /// </summary>
    public class TerminologyDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for TerminologyDataFormat
        /// </summary>
        public static readonly TerminologyDataFormat CSV = new TerminologyDataFormat("CSV");
        /// <summary>
        /// Constant TMX for TerminologyDataFormat
        /// </summary>
        public static readonly TerminologyDataFormat TMX = new TerminologyDataFormat("TMX");
        /// <summary>
        /// Constant TSV for TerminologyDataFormat
        /// </summary>
        public static readonly TerminologyDataFormat TSV = new TerminologyDataFormat("TSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TerminologyDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TerminologyDataFormat FindValue(string value)
        {
            return FindValue<TerminologyDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TerminologyDataFormat(string value)
        {
            return FindValue(value);
        }
    }

}