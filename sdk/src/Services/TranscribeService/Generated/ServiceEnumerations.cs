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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TranscribeService
{

    /// <summary>
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant ArAE for LanguageCode
        /// </summary>
        public static readonly LanguageCode ArAE = new LanguageCode("ar-AE");
        /// <summary>
        /// Constant ArSA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ArSA = new LanguageCode("ar-SA");
        /// <summary>
        /// Constant DeCH for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeCH = new LanguageCode("de-CH");
        /// <summary>
        /// Constant DeDE for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeDE = new LanguageCode("de-DE");
        /// <summary>
        /// Constant EnAB for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnAB = new LanguageCode("en-AB");
        /// <summary>
        /// Constant EnAU for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnAU = new LanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnGB = new LanguageCode("en-GB");
        /// <summary>
        /// Constant EnIE for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnIE = new LanguageCode("en-IE");
        /// <summary>
        /// Constant EnIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnIN = new LanguageCode("en-IN");
        /// <summary>
        /// Constant EnUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnUS = new LanguageCode("en-US");
        /// <summary>
        /// Constant EnWL for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnWL = new LanguageCode("en-WL");
        /// <summary>
        /// Constant EsES for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsES = new LanguageCode("es-ES");
        /// <summary>
        /// Constant EsUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsUS = new LanguageCode("es-US");
        /// <summary>
        /// Constant FaIR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FaIR = new LanguageCode("fa-IR");
        /// <summary>
        /// Constant FrCA for LanguageCode
        /// </summary>
        public static readonly LanguageCode FrCA = new LanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FrFR = new LanguageCode("fr-FR");
        /// <summary>
        /// Constant HeIL for LanguageCode
        /// </summary>
        public static readonly LanguageCode HeIL = new LanguageCode("he-IL");
        /// <summary>
        /// Constant HiIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode HiIN = new LanguageCode("hi-IN");
        /// <summary>
        /// Constant IdID for LanguageCode
        /// </summary>
        public static readonly LanguageCode IdID = new LanguageCode("id-ID");
        /// <summary>
        /// Constant ItIT for LanguageCode
        /// </summary>
        public static readonly LanguageCode ItIT = new LanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for LanguageCode
        /// </summary>
        public static readonly LanguageCode JaJP = new LanguageCode("ja-JP");
        /// <summary>
        /// Constant KoKR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KoKR = new LanguageCode("ko-KR");
        /// <summary>
        /// Constant MsMY for LanguageCode
        /// </summary>
        public static readonly LanguageCode MsMY = new LanguageCode("ms-MY");
        /// <summary>
        /// Constant NlNL for LanguageCode
        /// </summary>
        public static readonly LanguageCode NlNL = new LanguageCode("nl-NL");
        /// <summary>
        /// Constant PtBR for LanguageCode
        /// </summary>
        public static readonly LanguageCode PtBR = new LanguageCode("pt-BR");
        /// <summary>
        /// Constant PtPT for LanguageCode
        /// </summary>
        public static readonly LanguageCode PtPT = new LanguageCode("pt-PT");
        /// <summary>
        /// Constant RuRU for LanguageCode
        /// </summary>
        public static readonly LanguageCode RuRU = new LanguageCode("ru-RU");
        /// <summary>
        /// Constant TaIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode TaIN = new LanguageCode("ta-IN");
        /// <summary>
        /// Constant TeIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode TeIN = new LanguageCode("te-IN");
        /// <summary>
        /// Constant TrTR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TrTR = new LanguageCode("tr-TR");
        /// <summary>
        /// Constant ZhCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhCN = new LanguageCode("zh-CN");

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
    /// Constants used for properties of type MediaFormat.
    /// </summary>
    public class MediaFormat : ConstantClass
    {

        /// <summary>
        /// Constant Flac for MediaFormat
        /// </summary>
        public static readonly MediaFormat Flac = new MediaFormat("flac");
        /// <summary>
        /// Constant Mp3 for MediaFormat
        /// </summary>
        public static readonly MediaFormat Mp3 = new MediaFormat("mp3");
        /// <summary>
        /// Constant Mp4 for MediaFormat
        /// </summary>
        public static readonly MediaFormat Mp4 = new MediaFormat("mp4");
        /// <summary>
        /// Constant Wav for MediaFormat
        /// </summary>
        public static readonly MediaFormat Wav = new MediaFormat("wav");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaFormat FindValue(string value)
        {
            return FindValue<MediaFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputLocationType.
    /// </summary>
    public class OutputLocationType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_BUCKET for OutputLocationType
        /// </summary>
        public static readonly OutputLocationType CUSTOMER_BUCKET = new OutputLocationType("CUSTOMER_BUCKET");
        /// <summary>
        /// Constant SERVICE_BUCKET for OutputLocationType
        /// </summary>
        public static readonly OutputLocationType SERVICE_BUCKET = new OutputLocationType("SERVICE_BUCKET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputLocationType FindValue(string value)
        {
            return FindValue<OutputLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedactionOutput.
    /// </summary>
    public class RedactionOutput : ConstantClass
    {

        /// <summary>
        /// Constant Redacted for RedactionOutput
        /// </summary>
        public static readonly RedactionOutput Redacted = new RedactionOutput("redacted");
        /// <summary>
        /// Constant Redacted_and_unredacted for RedactionOutput
        /// </summary>
        public static readonly RedactionOutput Redacted_and_unredacted = new RedactionOutput("redacted_and_unredacted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedactionOutput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedactionOutput FindValue(string value)
        {
            return FindValue<RedactionOutput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedactionOutput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedactionType.
    /// </summary>
    public class RedactionType : ConstantClass
    {

        /// <summary>
        /// Constant PII for RedactionType
        /// </summary>
        public static readonly RedactionType PII = new RedactionType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedactionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedactionType FindValue(string value)
        {
            return FindValue<RedactionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedactionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscriptionJobStatus.
    /// </summary>
    public class TranscriptionJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for TranscriptionJobStatus
        /// </summary>
        public static readonly TranscriptionJobStatus COMPLETED = new TranscriptionJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for TranscriptionJobStatus
        /// </summary>
        public static readonly TranscriptionJobStatus FAILED = new TranscriptionJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TranscriptionJobStatus
        /// </summary>
        public static readonly TranscriptionJobStatus IN_PROGRESS = new TranscriptionJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for TranscriptionJobStatus
        /// </summary>
        public static readonly TranscriptionJobStatus QUEUED = new TranscriptionJobStatus("QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscriptionJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscriptionJobStatus FindValue(string value)
        {
            return FindValue<TranscriptionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscriptionJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VocabularyFilterMethod.
    /// </summary>
    public class VocabularyFilterMethod : ConstantClass
    {

        /// <summary>
        /// Constant Mask for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Mask = new VocabularyFilterMethod("mask");
        /// <summary>
        /// Constant Remove for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Remove = new VocabularyFilterMethod("remove");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VocabularyFilterMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VocabularyFilterMethod FindValue(string value)
        {
            return FindValue<VocabularyFilterMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VocabularyFilterMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VocabularyState.
    /// </summary>
    public class VocabularyState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for VocabularyState
        /// </summary>
        public static readonly VocabularyState FAILED = new VocabularyState("FAILED");
        /// <summary>
        /// Constant PENDING for VocabularyState
        /// </summary>
        public static readonly VocabularyState PENDING = new VocabularyState("PENDING");
        /// <summary>
        /// Constant READY for VocabularyState
        /// </summary>
        public static readonly VocabularyState READY = new VocabularyState("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VocabularyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VocabularyState FindValue(string value)
        {
            return FindValue<VocabularyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VocabularyState(string value)
        {
            return FindValue(value);
        }
    }

}