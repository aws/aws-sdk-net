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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TranscribeService
{

    /// <summary>
    /// Constants used for properties of type BaseModelName.
    /// </summary>
    public class BaseModelName : ConstantClass
    {

        /// <summary>
        /// Constant NarrowBand for BaseModelName
        /// </summary>
        public static readonly BaseModelName NarrowBand = new BaseModelName("NarrowBand");
        /// <summary>
        /// Constant WideBand for BaseModelName
        /// </summary>
        public static readonly BaseModelName WideBand = new BaseModelName("WideBand");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BaseModelName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BaseModelName FindValue(string value)
        {
            return FindValue<BaseModelName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BaseModelName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallAnalyticsFeature.
    /// </summary>
    public class CallAnalyticsFeature : ConstantClass
    {

        /// <summary>
        /// Constant GENERATIVE_SUMMARIZATION for CallAnalyticsFeature
        /// </summary>
        public static readonly CallAnalyticsFeature GENERATIVE_SUMMARIZATION = new CallAnalyticsFeature("GENERATIVE_SUMMARIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAnalyticsFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAnalyticsFeature FindValue(string value)
        {
            return FindValue<CallAnalyticsFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAnalyticsFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallAnalyticsJobStatus.
    /// </summary>
    public class CallAnalyticsJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CallAnalyticsJobStatus
        /// </summary>
        public static readonly CallAnalyticsJobStatus COMPLETED = new CallAnalyticsJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for CallAnalyticsJobStatus
        /// </summary>
        public static readonly CallAnalyticsJobStatus FAILED = new CallAnalyticsJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CallAnalyticsJobStatus
        /// </summary>
        public static readonly CallAnalyticsJobStatus IN_PROGRESS = new CallAnalyticsJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for CallAnalyticsJobStatus
        /// </summary>
        public static readonly CallAnalyticsJobStatus QUEUED = new CallAnalyticsJobStatus("QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAnalyticsJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAnalyticsJobStatus FindValue(string value)
        {
            return FindValue<CallAnalyticsJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAnalyticsJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallAnalyticsSkippedReasonCode.
    /// </summary>
    public class CallAnalyticsSkippedReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_SAFETY_GUIDELINES for CallAnalyticsSkippedReasonCode
        /// </summary>
        public static readonly CallAnalyticsSkippedReasonCode FAILED_SAFETY_GUIDELINES = new CallAnalyticsSkippedReasonCode("FAILED_SAFETY_GUIDELINES");
        /// <summary>
        /// Constant INSUFFICIENT_CONVERSATION_CONTENT for CallAnalyticsSkippedReasonCode
        /// </summary>
        public static readonly CallAnalyticsSkippedReasonCode INSUFFICIENT_CONVERSATION_CONTENT = new CallAnalyticsSkippedReasonCode("INSUFFICIENT_CONVERSATION_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAnalyticsSkippedReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAnalyticsSkippedReasonCode FindValue(string value)
        {
            return FindValue<CallAnalyticsSkippedReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAnalyticsSkippedReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CLMLanguageCode.
    /// </summary>
    public class CLMLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode DeDE = new CLMLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode EnAU = new CLMLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode EnGB = new CLMLanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode EnUS = new CLMLanguageCode("en-US");
        /// <summary>
        /// Constant EsUS for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode EsUS = new CLMLanguageCode("es-US");
        /// <summary>
        /// Constant HiIN for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode HiIN = new CLMLanguageCode("hi-IN");
        /// <summary>
        /// Constant JaJP for CLMLanguageCode
        /// </summary>
        public static readonly CLMLanguageCode JaJP = new CLMLanguageCode("ja-JP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CLMLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CLMLanguageCode FindValue(string value)
        {
            return FindValue<CLMLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CLMLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputType.
    /// </summary>
    public class InputType : ConstantClass
    {

        /// <summary>
        /// Constant POST_CALL for InputType
        /// </summary>
        public static readonly InputType POST_CALL = new InputType("POST_CALL");
        /// <summary>
        /// Constant REAL_TIME for InputType
        /// </summary>
        public static readonly InputType REAL_TIME = new InputType("REAL_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputType FindValue(string value)
        {
            return FindValue<InputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputType(string value)
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
        /// Constant AbGE for LanguageCode
        /// </summary>
        public static readonly LanguageCode AbGE = new LanguageCode("ab-GE");
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
        /// Constant AstES for LanguageCode
        /// </summary>
        public static readonly LanguageCode AstES = new LanguageCode("ast-ES");
        /// <summary>
        /// Constant AzAZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode AzAZ = new LanguageCode("az-AZ");
        /// <summary>
        /// Constant BaRU for LanguageCode
        /// </summary>
        public static readonly LanguageCode BaRU = new LanguageCode("ba-RU");
        /// <summary>
        /// Constant BeBY for LanguageCode
        /// </summary>
        public static readonly LanguageCode BeBY = new LanguageCode("be-BY");
        /// <summary>
        /// Constant BgBG for LanguageCode
        /// </summary>
        public static readonly LanguageCode BgBG = new LanguageCode("bg-BG");
        /// <summary>
        /// Constant BnIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode BnIN = new LanguageCode("bn-IN");
        /// <summary>
        /// Constant BsBA for LanguageCode
        /// </summary>
        public static readonly LanguageCode BsBA = new LanguageCode("bs-BA");
        /// <summary>
        /// Constant CaES for LanguageCode
        /// </summary>
        public static readonly LanguageCode CaES = new LanguageCode("ca-ES");
        /// <summary>
        /// Constant CkbIQ for LanguageCode
        /// </summary>
        public static readonly LanguageCode CkbIQ = new LanguageCode("ckb-IQ");
        /// <summary>
        /// Constant CkbIR for LanguageCode
        /// </summary>
        public static readonly LanguageCode CkbIR = new LanguageCode("ckb-IR");
        /// <summary>
        /// Constant CsCZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode CsCZ = new LanguageCode("cs-CZ");
        /// <summary>
        /// Constant CyWL for LanguageCode
        /// </summary>
        public static readonly LanguageCode CyWL = new LanguageCode("cy-WL");
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
        /// Constant EtEE for LanguageCode
        /// </summary>
        public static readonly LanguageCode EtEE = new LanguageCode("et-EE");
        /// <summary>
        /// Constant EtET for LanguageCode
        /// </summary>
        public static readonly LanguageCode EtET = new LanguageCode("et-ET");
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
        /// Constant GuIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode GuIN = new LanguageCode("gu-IN");
        /// <summary>
        /// Constant HaNG for LanguageCode
        /// </summary>
        public static readonly LanguageCode HaNG = new LanguageCode("ha-NG");
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
        /// Constant HuHU for LanguageCode
        /// </summary>
        public static readonly LanguageCode HuHU = new LanguageCode("hu-HU");
        /// <summary>
        /// Constant HyAM for LanguageCode
        /// </summary>
        public static readonly LanguageCode HyAM = new LanguageCode("hy-AM");
        /// <summary>
        /// Constant IdID for LanguageCode
        /// </summary>
        public static readonly LanguageCode IdID = new LanguageCode("id-ID");
        /// <summary>
        /// Constant IsIS for LanguageCode
        /// </summary>
        public static readonly LanguageCode IsIS = new LanguageCode("is-IS");
        /// <summary>
        /// Constant ItIT for LanguageCode
        /// </summary>
        public static readonly LanguageCode ItIT = new LanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for LanguageCode
        /// </summary>
        public static readonly LanguageCode JaJP = new LanguageCode("ja-JP");
        /// <summary>
        /// Constant KabDZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode KabDZ = new LanguageCode("kab-DZ");
        /// <summary>
        /// Constant KaGE for LanguageCode
        /// </summary>
        public static readonly LanguageCode KaGE = new LanguageCode("ka-GE");
        /// <summary>
        /// Constant KkKZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode KkKZ = new LanguageCode("kk-KZ");
        /// <summary>
        /// Constant KnIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode KnIN = new LanguageCode("kn-IN");
        /// <summary>
        /// Constant KoKR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KoKR = new LanguageCode("ko-KR");
        /// <summary>
        /// Constant KyKG for LanguageCode
        /// </summary>
        public static readonly LanguageCode KyKG = new LanguageCode("ky-KG");
        /// <summary>
        /// Constant LgIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode LgIN = new LanguageCode("lg-IN");
        /// <summary>
        /// Constant LtLT for LanguageCode
        /// </summary>
        public static readonly LanguageCode LtLT = new LanguageCode("lt-LT");
        /// <summary>
        /// Constant LvLV for LanguageCode
        /// </summary>
        public static readonly LanguageCode LvLV = new LanguageCode("lv-LV");
        /// <summary>
        /// Constant MhrRU for LanguageCode
        /// </summary>
        public static readonly LanguageCode MhrRU = new LanguageCode("mhr-RU");
        /// <summary>
        /// Constant MiNZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode MiNZ = new LanguageCode("mi-NZ");
        /// <summary>
        /// Constant MkMK for LanguageCode
        /// </summary>
        public static readonly LanguageCode MkMK = new LanguageCode("mk-MK");
        /// <summary>
        /// Constant MlIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode MlIN = new LanguageCode("ml-IN");
        /// <summary>
        /// Constant MnMN for LanguageCode
        /// </summary>
        public static readonly LanguageCode MnMN = new LanguageCode("mn-MN");
        /// <summary>
        /// Constant MrIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode MrIN = new LanguageCode("mr-IN");
        /// <summary>
        /// Constant MsMY for LanguageCode
        /// </summary>
        public static readonly LanguageCode MsMY = new LanguageCode("ms-MY");
        /// <summary>
        /// Constant MtMT for LanguageCode
        /// </summary>
        public static readonly LanguageCode MtMT = new LanguageCode("mt-MT");
        /// <summary>
        /// Constant NlNL for LanguageCode
        /// </summary>
        public static readonly LanguageCode NlNL = new LanguageCode("nl-NL");
        /// <summary>
        /// Constant NoNO for LanguageCode
        /// </summary>
        public static readonly LanguageCode NoNO = new LanguageCode("no-NO");
        /// <summary>
        /// Constant OrIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode OrIN = new LanguageCode("or-IN");
        /// <summary>
        /// Constant PaIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode PaIN = new LanguageCode("pa-IN");
        /// <summary>
        /// Constant PlPL for LanguageCode
        /// </summary>
        public static readonly LanguageCode PlPL = new LanguageCode("pl-PL");
        /// <summary>
        /// Constant PsAF for LanguageCode
        /// </summary>
        public static readonly LanguageCode PsAF = new LanguageCode("ps-AF");
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
        /// Constant RwRW for LanguageCode
        /// </summary>
        public static readonly LanguageCode RwRW = new LanguageCode("rw-RW");
        /// <summary>
        /// Constant SiLK for LanguageCode
        /// </summary>
        public static readonly LanguageCode SiLK = new LanguageCode("si-LK");
        /// <summary>
        /// Constant SkSK for LanguageCode
        /// </summary>
        public static readonly LanguageCode SkSK = new LanguageCode("sk-SK");
        /// <summary>
        /// Constant SlSI for LanguageCode
        /// </summary>
        public static readonly LanguageCode SlSI = new LanguageCode("sl-SI");
        /// <summary>
        /// Constant SoSO for LanguageCode
        /// </summary>
        public static readonly LanguageCode SoSO = new LanguageCode("so-SO");
        /// <summary>
        /// Constant SrRS for LanguageCode
        /// </summary>
        public static readonly LanguageCode SrRS = new LanguageCode("sr-RS");
        /// <summary>
        /// Constant SuID for LanguageCode
        /// </summary>
        public static readonly LanguageCode SuID = new LanguageCode("su-ID");
        /// <summary>
        /// Constant SvSE for LanguageCode
        /// </summary>
        public static readonly LanguageCode SvSE = new LanguageCode("sv-SE");
        /// <summary>
        /// Constant SwBI for LanguageCode
        /// </summary>
        public static readonly LanguageCode SwBI = new LanguageCode("sw-BI");
        /// <summary>
        /// Constant SwKE for LanguageCode
        /// </summary>
        public static readonly LanguageCode SwKE = new LanguageCode("sw-KE");
        /// <summary>
        /// Constant SwRW for LanguageCode
        /// </summary>
        public static readonly LanguageCode SwRW = new LanguageCode("sw-RW");
        /// <summary>
        /// Constant SwTZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode SwTZ = new LanguageCode("sw-TZ");
        /// <summary>
        /// Constant SwUG for LanguageCode
        /// </summary>
        public static readonly LanguageCode SwUG = new LanguageCode("sw-UG");
        /// <summary>
        /// Constant TaIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode TaIN = new LanguageCode("ta-IN");
        /// <summary>
        /// Constant TeIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode TeIN = new LanguageCode("te-IN");
        /// <summary>
        /// Constant ThTH for LanguageCode
        /// </summary>
        public static readonly LanguageCode ThTH = new LanguageCode("th-TH");
        /// <summary>
        /// Constant TlPH for LanguageCode
        /// </summary>
        public static readonly LanguageCode TlPH = new LanguageCode("tl-PH");
        /// <summary>
        /// Constant TrTR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TrTR = new LanguageCode("tr-TR");
        /// <summary>
        /// Constant TtRU for LanguageCode
        /// </summary>
        public static readonly LanguageCode TtRU = new LanguageCode("tt-RU");
        /// <summary>
        /// Constant UgCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode UgCN = new LanguageCode("ug-CN");
        /// <summary>
        /// Constant UkUA for LanguageCode
        /// </summary>
        public static readonly LanguageCode UkUA = new LanguageCode("uk-UA");
        /// <summary>
        /// Constant UzUZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode UzUZ = new LanguageCode("uz-UZ");
        /// <summary>
        /// Constant ViVN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ViVN = new LanguageCode("vi-VN");
        /// <summary>
        /// Constant WoSN for LanguageCode
        /// </summary>
        public static readonly LanguageCode WoSN = new LanguageCode("wo-SN");
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
    /// Constants used for properties of type MediaFormat.
    /// </summary>
    public class MediaFormat : ConstantClass
    {

        /// <summary>
        /// Constant Amr for MediaFormat
        /// </summary>
        public static readonly MediaFormat Amr = new MediaFormat("amr");
        /// <summary>
        /// Constant Flac for MediaFormat
        /// </summary>
        public static readonly MediaFormat Flac = new MediaFormat("flac");
        /// <summary>
        /// Constant M4a for MediaFormat
        /// </summary>
        public static readonly MediaFormat M4a = new MediaFormat("m4a");
        /// <summary>
        /// Constant Mp3 for MediaFormat
        /// </summary>
        public static readonly MediaFormat Mp3 = new MediaFormat("mp3");
        /// <summary>
        /// Constant Mp4 for MediaFormat
        /// </summary>
        public static readonly MediaFormat Mp4 = new MediaFormat("mp4");
        /// <summary>
        /// Constant Ogg for MediaFormat
        /// </summary>
        public static readonly MediaFormat Ogg = new MediaFormat("ogg");
        /// <summary>
        /// Constant Wav for MediaFormat
        /// </summary>
        public static readonly MediaFormat Wav = new MediaFormat("wav");
        /// <summary>
        /// Constant Webm for MediaFormat
        /// </summary>
        public static readonly MediaFormat Webm = new MediaFormat("webm");

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
    /// Constants used for properties of type MedicalScribeJobStatus.
    /// </summary>
    public class MedicalScribeJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for MedicalScribeJobStatus
        /// </summary>
        public static readonly MedicalScribeJobStatus COMPLETED = new MedicalScribeJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MedicalScribeJobStatus
        /// </summary>
        public static readonly MedicalScribeJobStatus FAILED = new MedicalScribeJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MedicalScribeJobStatus
        /// </summary>
        public static readonly MedicalScribeJobStatus IN_PROGRESS = new MedicalScribeJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for MedicalScribeJobStatus
        /// </summary>
        public static readonly MedicalScribeJobStatus QUEUED = new MedicalScribeJobStatus("QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeJobStatus FindValue(string value)
        {
            return FindValue<MedicalScribeJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeJobStatus(string value)
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
    /// Constants used for properties of type ModelStatus.
    /// </summary>
    public class ModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ModelStatus
        /// </summary>
        public static readonly ModelStatus COMPLETED = new ModelStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ModelStatus
        /// </summary>
        public static readonly ModelStatus FAILED = new ModelStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ModelStatus
        /// </summary>
        public static readonly ModelStatus IN_PROGRESS = new ModelStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelStatus FindValue(string value)
        {
            return FindValue<ModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelStatus(string value)
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
    /// Constants used for properties of type PiiEntityType.
    /// </summary>
    public class PiiEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType ADDRESS = new PiiEntityType("ADDRESS");
        /// <summary>
        /// Constant ALL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType ALL = new PiiEntityType("ALL");
        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType BANK_ACCOUNT_NUMBER = new PiiEntityType("BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant BANK_ROUTING for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType BANK_ROUTING = new PiiEntityType("BANK_ROUTING");
        /// <summary>
        /// Constant CREDIT_DEBIT_CVV for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_CVV = new PiiEntityType("CREDIT_DEBIT_CVV");
        /// <summary>
        /// Constant CREDIT_DEBIT_EXPIRY for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_EXPIRY = new PiiEntityType("CREDIT_DEBIT_EXPIRY");
        /// <summary>
        /// Constant CREDIT_DEBIT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_NUMBER = new PiiEntityType("CREDIT_DEBIT_NUMBER");
        /// <summary>
        /// Constant EMAIL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType EMAIL = new PiiEntityType("EMAIL");
        /// <summary>
        /// Constant NAME for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType NAME = new PiiEntityType("NAME");
        /// <summary>
        /// Constant PHONE for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PHONE = new PiiEntityType("PHONE");
        /// <summary>
        /// Constant PIN for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PIN = new PiiEntityType("PIN");
        /// <summary>
        /// Constant SSN for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType SSN = new PiiEntityType("SSN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PiiEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PiiEntityType FindValue(string value)
        {
            return FindValue<PiiEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PiiEntityType(string value)
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
    /// Constants used for properties of type SentimentValue.
    /// </summary>
    public class SentimentValue : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for SentimentValue
        /// </summary>
        public static readonly SentimentValue MIXED = new SentimentValue("MIXED");
        /// <summary>
        /// Constant NEGATIVE for SentimentValue
        /// </summary>
        public static readonly SentimentValue NEGATIVE = new SentimentValue("NEGATIVE");
        /// <summary>
        /// Constant NEUTRAL for SentimentValue
        /// </summary>
        public static readonly SentimentValue NEUTRAL = new SentimentValue("NEUTRAL");
        /// <summary>
        /// Constant POSITIVE for SentimentValue
        /// </summary>
        public static readonly SentimentValue POSITIVE = new SentimentValue("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SentimentValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SentimentValue FindValue(string value)
        {
            return FindValue<SentimentValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SentimentValue(string value)
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
        /// Constant PRIMARYCARE for Specialty
        /// </summary>
        public static readonly Specialty PRIMARYCARE = new Specialty("PRIMARYCARE");

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
    /// Constants used for properties of type SubtitleFormat.
    /// </summary>
    public class SubtitleFormat : ConstantClass
    {

        /// <summary>
        /// Constant Srt for SubtitleFormat
        /// </summary>
        public static readonly SubtitleFormat Srt = new SubtitleFormat("srt");
        /// <summary>
        /// Constant Vtt for SubtitleFormat
        /// </summary>
        public static readonly SubtitleFormat Vtt = new SubtitleFormat("vtt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubtitleFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubtitleFormat FindValue(string value)
        {
            return FindValue<SubtitleFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubtitleFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ToxicityCategory.
    /// </summary>
    public class ToxicityCategory : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ToxicityCategory
        /// </summary>
        public static readonly ToxicityCategory ALL = new ToxicityCategory("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToxicityCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToxicityCategory FindValue(string value)
        {
            return FindValue<ToxicityCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToxicityCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscriptFilterType.
    /// </summary>
    public class TranscriptFilterType : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for TranscriptFilterType
        /// </summary>
        public static readonly TranscriptFilterType EXACT = new TranscriptFilterType("EXACT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscriptFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscriptFilterType FindValue(string value)
        {
            return FindValue<TranscriptFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscriptFilterType(string value)
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