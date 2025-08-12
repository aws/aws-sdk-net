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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TranscribeStreaming
{

    /// <summary>
    /// Constants used for properties of type CallAnalyticsLanguageCode.
    /// </summary>
    public class CallAnalyticsLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode DeDE = new CallAnalyticsLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnAU = new CallAnalyticsLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnGB = new CallAnalyticsLanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnUS = new CallAnalyticsLanguageCode("en-US");
        /// <summary>
        /// Constant EsUS for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EsUS = new CallAnalyticsLanguageCode("es-US");
        /// <summary>
        /// Constant FrCA for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode FrCA = new CallAnalyticsLanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode FrFR = new CallAnalyticsLanguageCode("fr-FR");
        /// <summary>
        /// Constant ItIT for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode ItIT = new CallAnalyticsLanguageCode("it-IT");
        /// <summary>
        /// Constant PtBR for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode PtBR = new CallAnalyticsLanguageCode("pt-BR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAnalyticsLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAnalyticsLanguageCode FindValue(string value)
        {
            return FindValue<CallAnalyticsLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAnalyticsLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClinicalNoteGenerationStatus.
    /// </summary>
    public class ClinicalNoteGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ClinicalNoteGenerationStatus
        /// </summary>
        public static readonly ClinicalNoteGenerationStatus COMPLETED = new ClinicalNoteGenerationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ClinicalNoteGenerationStatus
        /// </summary>
        public static readonly ClinicalNoteGenerationStatus FAILED = new ClinicalNoteGenerationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ClinicalNoteGenerationStatus
        /// </summary>
        public static readonly ClinicalNoteGenerationStatus IN_PROGRESS = new ClinicalNoteGenerationStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClinicalNoteGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClinicalNoteGenerationStatus FindValue(string value)
        {
            return FindValue<ClinicalNoteGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClinicalNoteGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentIdentificationType.
    /// </summary>
    public class ContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PII for ContentIdentificationType
        /// </summary>
        public static readonly ContentIdentificationType PII = new ContentIdentificationType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentIdentificationType FindValue(string value)
        {
            return FindValue<ContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentRedactionOutput.
    /// </summary>
    public class ContentRedactionOutput : ConstantClass
    {

        /// <summary>
        /// Constant Redacted for ContentRedactionOutput
        /// </summary>
        public static readonly ContentRedactionOutput Redacted = new ContentRedactionOutput("redacted");
        /// <summary>
        /// Constant Redacted_and_unredacted for ContentRedactionOutput
        /// </summary>
        public static readonly ContentRedactionOutput Redacted_and_unredacted = new ContentRedactionOutput("redacted_and_unredacted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentRedactionOutput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentRedactionOutput FindValue(string value)
        {
            return FindValue<ContentRedactionOutput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentRedactionOutput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentRedactionType.
    /// </summary>
    public class ContentRedactionType : ConstantClass
    {

        /// <summary>
        /// Constant PII for ContentRedactionType
        /// </summary>
        public static readonly ContentRedactionType PII = new ContentRedactionType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentRedactionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentRedactionType FindValue(string value)
        {
            return FindValue<ContentRedactionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentRedactionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ItemType.
    /// </summary>
    public class ItemType : ConstantClass
    {

        /// <summary>
        /// Constant Pronunciation for ItemType
        /// </summary>
        public static readonly ItemType Pronunciation = new ItemType("pronunciation");
        /// <summary>
        /// Constant Punctuation for ItemType
        /// </summary>
        public static readonly ItemType Punctuation = new ItemType("punctuation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ItemType FindValue(string value)
        {
            return FindValue<ItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ItemType(string value)
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
        /// Constant AfZA for LanguageCode
        /// </summary>
        public static readonly LanguageCode AfZA = new LanguageCode("af-ZA");
        /// <summary>
        /// Constant ArAE for LanguageCode
        /// </summary>
        public static readonly LanguageCode ArAE = new LanguageCode("ar-AE");
        /// <summary>
        /// Constant ArSA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ArSA = new LanguageCode("ar-SA");
        /// <summary>
        /// Constant CaES for LanguageCode
        /// </summary>
        public static readonly LanguageCode CaES = new LanguageCode("ca-ES");
        /// <summary>
        /// Constant CsCZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode CsCZ = new LanguageCode("cs-CZ");
        /// <summary>
        /// Constant DaDK for LanguageCode
        /// </summary>
        public static readonly LanguageCode DaDK = new LanguageCode("da-DK");
        /// <summary>
        /// Constant DeCH for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeCH = new LanguageCode("de-CH");
        /// <summary>
        /// Constant DeDE for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeDE = new LanguageCode("de-DE");
        /// <summary>
        /// Constant ElGR for LanguageCode
        /// </summary>
        public static readonly LanguageCode ElGR = new LanguageCode("el-GR");
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
        /// Constant EnNZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnNZ = new LanguageCode("en-NZ");
        /// <summary>
        /// Constant EnUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnUS = new LanguageCode("en-US");
        /// <summary>
        /// Constant EnWL for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnWL = new LanguageCode("en-WL");
        /// <summary>
        /// Constant EnZA for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnZA = new LanguageCode("en-ZA");
        /// <summary>
        /// Constant EsES for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsES = new LanguageCode("es-ES");
        /// <summary>
        /// Constant EsUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsUS = new LanguageCode("es-US");
        /// <summary>
        /// Constant EuES for LanguageCode
        /// </summary>
        public static readonly LanguageCode EuES = new LanguageCode("eu-ES");
        /// <summary>
        /// Constant FaIR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FaIR = new LanguageCode("fa-IR");
        /// <summary>
        /// Constant FiFI for LanguageCode
        /// </summary>
        public static readonly LanguageCode FiFI = new LanguageCode("fi-FI");
        /// <summary>
        /// Constant FrCA for LanguageCode
        /// </summary>
        public static readonly LanguageCode FrCA = new LanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FrFR = new LanguageCode("fr-FR");
        /// <summary>
        /// Constant GlES for LanguageCode
        /// </summary>
        public static readonly LanguageCode GlES = new LanguageCode("gl-ES");
        /// <summary>
        /// Constant HeIL for LanguageCode
        /// </summary>
        public static readonly LanguageCode HeIL = new LanguageCode("he-IL");
        /// <summary>
        /// Constant HiIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode HiIN = new LanguageCode("hi-IN");
        /// <summary>
        /// Constant HrHR for LanguageCode
        /// </summary>
        public static readonly LanguageCode HrHR = new LanguageCode("hr-HR");
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
        /// Constant LvLV for LanguageCode
        /// </summary>
        public static readonly LanguageCode LvLV = new LanguageCode("lv-LV");
        /// <summary>
        /// Constant MsMY for LanguageCode
        /// </summary>
        public static readonly LanguageCode MsMY = new LanguageCode("ms-MY");
        /// <summary>
        /// Constant NlNL for LanguageCode
        /// </summary>
        public static readonly LanguageCode NlNL = new LanguageCode("nl-NL");
        /// <summary>
        /// Constant NoNO for LanguageCode
        /// </summary>
        public static readonly LanguageCode NoNO = new LanguageCode("no-NO");
        /// <summary>
        /// Constant PlPL for LanguageCode
        /// </summary>
        public static readonly LanguageCode PlPL = new LanguageCode("pl-PL");
        /// <summary>
        /// Constant PtBR for LanguageCode
        /// </summary>
        public static readonly LanguageCode PtBR = new LanguageCode("pt-BR");
        /// <summary>
        /// Constant PtPT for LanguageCode
        /// </summary>
        public static readonly LanguageCode PtPT = new LanguageCode("pt-PT");
        /// <summary>
        /// Constant RoRO for LanguageCode
        /// </summary>
        public static readonly LanguageCode RoRO = new LanguageCode("ro-RO");
        /// <summary>
        /// Constant RuRU for LanguageCode
        /// </summary>
        public static readonly LanguageCode RuRU = new LanguageCode("ru-RU");
        /// <summary>
        /// Constant SkSK for LanguageCode
        /// </summary>
        public static readonly LanguageCode SkSK = new LanguageCode("sk-SK");
        /// <summary>
        /// Constant SoSO for LanguageCode
        /// </summary>
        public static readonly LanguageCode SoSO = new LanguageCode("so-SO");
        /// <summary>
        /// Constant SrRS for LanguageCode
        /// </summary>
        public static readonly LanguageCode SrRS = new LanguageCode("sr-RS");
        /// <summary>
        /// Constant SvSE for LanguageCode
        /// </summary>
        public static readonly LanguageCode SvSE = new LanguageCode("sv-SE");
        /// <summary>
        /// Constant ThTH for LanguageCode
        /// </summary>
        public static readonly LanguageCode ThTH = new LanguageCode("th-TH");
        /// <summary>
        /// Constant TlPH for LanguageCode
        /// </summary>
        public static readonly LanguageCode TlPH = new LanguageCode("tl-PH");
        /// <summary>
        /// Constant UkUA for LanguageCode
        /// </summary>
        public static readonly LanguageCode UkUA = new LanguageCode("uk-UA");
        /// <summary>
        /// Constant ViVN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ViVN = new LanguageCode("vi-VN");
        /// <summary>
        /// Constant ZhCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhCN = new LanguageCode("zh-CN");
        /// <summary>
        /// Constant ZhHK for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhHK = new LanguageCode("zh-HK");
        /// <summary>
        /// Constant ZhTW for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhTW = new LanguageCode("zh-TW");
        /// <summary>
        /// Constant ZuZA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZuZA = new LanguageCode("zu-ZA");

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
    /// Constants used for properties of type MediaEncoding.
    /// </summary>
    public class MediaEncoding : ConstantClass
    {

        /// <summary>
        /// Constant Flac for MediaEncoding
        /// </summary>
        public static readonly MediaEncoding Flac = new MediaEncoding("flac");
        /// <summary>
        /// Constant OggOpus for MediaEncoding
        /// </summary>
        public static readonly MediaEncoding OggOpus = new MediaEncoding("ogg-opus");
        /// <summary>
        /// Constant Pcm for MediaEncoding
        /// </summary>
        public static readonly MediaEncoding Pcm = new MediaEncoding("pcm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaEncoding FindValue(string value)
        {
            return FindValue<MediaEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalContentIdentificationType.
    /// </summary>
    public class MedicalContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PHI for MedicalContentIdentificationType
        /// </summary>
        public static readonly MedicalContentIdentificationType PHI = new MedicalContentIdentificationType("PHI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalContentIdentificationType FindValue(string value)
        {
            return FindValue<MedicalContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeLanguageCode.
    /// </summary>
    public class MedicalScribeLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for MedicalScribeLanguageCode
        /// </summary>
        public static readonly MedicalScribeLanguageCode EnUS = new MedicalScribeLanguageCode("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeLanguageCode FindValue(string value)
        {
            return FindValue<MedicalScribeLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeMediaEncoding.
    /// </summary>
    public class MedicalScribeMediaEncoding : ConstantClass
    {

        /// <summary>
        /// Constant Flac for MedicalScribeMediaEncoding
        /// </summary>
        public static readonly MedicalScribeMediaEncoding Flac = new MedicalScribeMediaEncoding("flac");
        /// <summary>
        /// Constant OggOpus for MedicalScribeMediaEncoding
        /// </summary>
        public static readonly MedicalScribeMediaEncoding OggOpus = new MedicalScribeMediaEncoding("ogg-opus");
        /// <summary>
        /// Constant Pcm for MedicalScribeMediaEncoding
        /// </summary>
        public static readonly MedicalScribeMediaEncoding Pcm = new MedicalScribeMediaEncoding("pcm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeMediaEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeMediaEncoding FindValue(string value)
        {
            return FindValue<MedicalScribeMediaEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeMediaEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeNoteTemplate.
    /// </summary>
    public class MedicalScribeNoteTemplate : ConstantClass
    {

        /// <summary>
        /// Constant BEHAVIORAL_SOAP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate BEHAVIORAL_SOAP = new MedicalScribeNoteTemplate("BEHAVIORAL_SOAP");
        /// <summary>
        /// Constant BIRP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate BIRP = new MedicalScribeNoteTemplate("BIRP");
        /// <summary>
        /// Constant DAP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate DAP = new MedicalScribeNoteTemplate("DAP");
        /// <summary>
        /// Constant GIRPP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate GIRPP = new MedicalScribeNoteTemplate("GIRPP");
        /// <summary>
        /// Constant HISTORY_AND_PHYSICAL for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate HISTORY_AND_PHYSICAL = new MedicalScribeNoteTemplate("HISTORY_AND_PHYSICAL");
        /// <summary>
        /// Constant PHYSICAL_SOAP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate PHYSICAL_SOAP = new MedicalScribeNoteTemplate("PHYSICAL_SOAP");
        /// <summary>
        /// Constant SIRP for MedicalScribeNoteTemplate
        /// </summary>
        public static readonly MedicalScribeNoteTemplate SIRP = new MedicalScribeNoteTemplate("SIRP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeNoteTemplate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeNoteTemplate FindValue(string value)
        {
            return FindValue<MedicalScribeNoteTemplate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeNoteTemplate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeParticipantRole.
    /// </summary>
    public class MedicalScribeParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant CLINICIAN for MedicalScribeParticipantRole
        /// </summary>
        public static readonly MedicalScribeParticipantRole CLINICIAN = new MedicalScribeParticipantRole("CLINICIAN");
        /// <summary>
        /// Constant PATIENT for MedicalScribeParticipantRole
        /// </summary>
        public static readonly MedicalScribeParticipantRole PATIENT = new MedicalScribeParticipantRole("PATIENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeParticipantRole FindValue(string value)
        {
            return FindValue<MedicalScribeParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeSessionControlEventType.
    /// </summary>
    public class MedicalScribeSessionControlEventType : ConstantClass
    {

        /// <summary>
        /// Constant END_OF_SESSION for MedicalScribeSessionControlEventType
        /// </summary>
        public static readonly MedicalScribeSessionControlEventType END_OF_SESSION = new MedicalScribeSessionControlEventType("END_OF_SESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeSessionControlEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeSessionControlEventType FindValue(string value)
        {
            return FindValue<MedicalScribeSessionControlEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeSessionControlEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeStreamStatus.
    /// </summary>
    public class MedicalScribeStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus COMPLETED = new MedicalScribeStreamStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus FAILED = new MedicalScribeStreamStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus IN_PROGRESS = new MedicalScribeStreamStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PAUSED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus PAUSED = new MedicalScribeStreamStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeStreamStatus FindValue(string value)
        {
            return FindValue<MedicalScribeStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeTranscriptItemType.
    /// </summary>
    public class MedicalScribeTranscriptItemType : ConstantClass
    {

        /// <summary>
        /// Constant Pronunciation for MedicalScribeTranscriptItemType
        /// </summary>
        public static readonly MedicalScribeTranscriptItemType Pronunciation = new MedicalScribeTranscriptItemType("pronunciation");
        /// <summary>
        /// Constant Punctuation for MedicalScribeTranscriptItemType
        /// </summary>
        public static readonly MedicalScribeTranscriptItemType Punctuation = new MedicalScribeTranscriptItemType("punctuation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeTranscriptItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeTranscriptItemType FindValue(string value)
        {
            return FindValue<MedicalScribeTranscriptItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeTranscriptItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeVocabularyFilterMethod.
    /// </summary>
    public class MedicalScribeVocabularyFilterMethod : ConstantClass
    {

        /// <summary>
        /// Constant Mask for MedicalScribeVocabularyFilterMethod
        /// </summary>
        public static readonly MedicalScribeVocabularyFilterMethod Mask = new MedicalScribeVocabularyFilterMethod("mask");
        /// <summary>
        /// Constant Remove for MedicalScribeVocabularyFilterMethod
        /// </summary>
        public static readonly MedicalScribeVocabularyFilterMethod Remove = new MedicalScribeVocabularyFilterMethod("remove");
        /// <summary>
        /// Constant Tag for MedicalScribeVocabularyFilterMethod
        /// </summary>
        public static readonly MedicalScribeVocabularyFilterMethod Tag = new MedicalScribeVocabularyFilterMethod("tag");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeVocabularyFilterMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeVocabularyFilterMethod FindValue(string value)
        {
            return FindValue<MedicalScribeVocabularyFilterMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeVocabularyFilterMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartialResultsStability.
    /// </summary>
    public class PartialResultsStability : ConstantClass
    {

        /// <summary>
        /// Constant High for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability High = new PartialResultsStability("high");
        /// <summary>
        /// Constant Low for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability Low = new PartialResultsStability("low");
        /// <summary>
        /// Constant Medium for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability Medium = new PartialResultsStability("medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartialResultsStability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartialResultsStability FindValue(string value)
        {
            return FindValue<PartialResultsStability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartialResultsStability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRole.
    /// </summary>
    public class ParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole AGENT = new ParticipantRole("AGENT");
        /// <summary>
        /// Constant CUSTOMER for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole CUSTOMER = new ParticipantRole("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRole FindValue(string value)
        {
            return FindValue<ParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Pronouns.
    /// </summary>
    public class Pronouns : ConstantClass
    {

        /// <summary>
        /// Constant HE_HIM for Pronouns
        /// </summary>
        public static readonly Pronouns HE_HIM = new Pronouns("HE_HIM");
        /// <summary>
        /// Constant SHE_HER for Pronouns
        /// </summary>
        public static readonly Pronouns SHE_HER = new Pronouns("SHE_HER");
        /// <summary>
        /// Constant THEY_THEM for Pronouns
        /// </summary>
        public static readonly Pronouns THEY_THEM = new Pronouns("THEY_THEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Pronouns(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Pronouns FindValue(string value)
        {
            return FindValue<Pronouns>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Pronouns(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Sentiment.
    /// </summary>
    public class Sentiment : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for Sentiment
        /// </summary>
        public static readonly Sentiment MIXED = new Sentiment("MIXED");
        /// <summary>
        /// Constant NEGATIVE for Sentiment
        /// </summary>
        public static readonly Sentiment NEGATIVE = new Sentiment("NEGATIVE");
        /// <summary>
        /// Constant NEUTRAL for Sentiment
        /// </summary>
        public static readonly Sentiment NEUTRAL = new Sentiment("NEUTRAL");
        /// <summary>
        /// Constant POSITIVE for Sentiment
        /// </summary>
        public static readonly Sentiment POSITIVE = new Sentiment("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Sentiment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sentiment FindValue(string value)
        {
            return FindValue<Sentiment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sentiment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Specialty.
    /// </summary>
    public class Specialty : ConstantClass
    {

        /// <summary>
        /// Constant CARDIOLOGY for Specialty
        /// </summary>
        public static readonly Specialty CARDIOLOGY = new Specialty("CARDIOLOGY");
        /// <summary>
        /// Constant NEUROLOGY for Specialty
        /// </summary>
        public static readonly Specialty NEUROLOGY = new Specialty("NEUROLOGY");
        /// <summary>
        /// Constant ONCOLOGY for Specialty
        /// </summary>
        public static readonly Specialty ONCOLOGY = new Specialty("ONCOLOGY");
        /// <summary>
        /// Constant PRIMARYCARE for Specialty
        /// </summary>
        public static readonly Specialty PRIMARYCARE = new Specialty("PRIMARYCARE");
        /// <summary>
        /// Constant RADIOLOGY for Specialty
        /// </summary>
        public static readonly Specialty RADIOLOGY = new Specialty("RADIOLOGY");
        /// <summary>
        /// Constant UROLOGY for Specialty
        /// </summary>
        public static readonly Specialty UROLOGY = new Specialty("UROLOGY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Specialty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Specialty FindValue(string value)
        {
            return FindValue<Specialty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Specialty(string value)
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
        /// Constant CONVERSATION for Type
        /// </summary>
        public static readonly Type CONVERSATION = new Type("CONVERSATION");
        /// <summary>
        /// Constant DICTATION for Type
        /// </summary>
        public static readonly Type DICTATION = new Type("DICTATION");

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
        /// Constant Tag for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Tag = new VocabularyFilterMethod("tag");

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

}