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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Polly
{

    /// <summary>
    /// Constants used for properties of type Engine.
    /// </summary>
    public class Engine : ConstantClass
    {

        /// <summary>
        /// Constant Neural for Engine
        /// </summary>
        public static readonly Engine Neural = new Engine("neural");
        /// <summary>
        /// Constant Standard for Engine
        /// </summary>
        public static readonly Engine Standard = new Engine("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Engine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Engine FindValue(string value)
        {
            return FindValue<Engine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Engine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Gender.
    /// </summary>
    public class Gender : ConstantClass
    {

        /// <summary>
        /// Constant Female for Gender
        /// </summary>
        public static readonly Gender Female = new Gender("Female");
        /// <summary>
        /// Constant Male for Gender
        /// </summary>
        public static readonly Gender Male = new Gender("Male");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Gender(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Gender FindValue(string value)
        {
            return FindValue<Gender>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Gender(string value)
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
        /// Constant ArAE for LanguageCode
        /// </summary>
        public static readonly LanguageCode ArAE = new LanguageCode("ar-AE");
        /// <summary>
        /// Constant Arb for LanguageCode
        /// </summary>
        public static readonly LanguageCode Arb = new LanguageCode("arb");
        /// <summary>
        /// Constant CaES for LanguageCode
        /// </summary>
        public static readonly LanguageCode CaES = new LanguageCode("ca-ES");
        /// <summary>
        /// Constant CmnCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode CmnCN = new LanguageCode("cmn-CN");
        /// <summary>
        /// Constant CyGB for LanguageCode
        /// </summary>
        public static readonly LanguageCode CyGB = new LanguageCode("cy-GB");
        /// <summary>
        /// Constant DaDK for LanguageCode
        /// </summary>
        public static readonly LanguageCode DaDK = new LanguageCode("da-DK");
        /// <summary>
        /// Constant DeAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeAT = new LanguageCode("de-AT");
        /// <summary>
        /// Constant DeDE for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeDE = new LanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnAU = new LanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnGB = new LanguageCode("en-GB");
        /// <summary>
        /// Constant EnGBWLS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnGBWLS = new LanguageCode("en-GB-WLS");
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
        /// Constant EnZA for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnZA = new LanguageCode("en-ZA");
        /// <summary>
        /// Constant EsES for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsES = new LanguageCode("es-ES");
        /// <summary>
        /// Constant EsMX for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsMX = new LanguageCode("es-MX");
        /// <summary>
        /// Constant EsUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsUS = new LanguageCode("es-US");
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
        /// Constant HiIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode HiIN = new LanguageCode("hi-IN");
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
        /// Constant KoKR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KoKR = new LanguageCode("ko-KR");
        /// <summary>
        /// Constant NbNO for LanguageCode
        /// </summary>
        public static readonly LanguageCode NbNO = new LanguageCode("nb-NO");
        /// <summary>
        /// Constant NlNL for LanguageCode
        /// </summary>
        public static readonly LanguageCode NlNL = new LanguageCode("nl-NL");
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
        /// Constant SvSE for LanguageCode
        /// </summary>
        public static readonly LanguageCode SvSE = new LanguageCode("sv-SE");
        /// <summary>
        /// Constant TrTR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TrTR = new LanguageCode("tr-TR");
        /// <summary>
        /// Constant YueCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode YueCN = new LanguageCode("yue-CN");

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
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for OutputFormat
        /// </summary>
        public static readonly OutputFormat Json = new OutputFormat("json");
        /// <summary>
        /// Constant Mp3 for OutputFormat
        /// </summary>
        public static readonly OutputFormat Mp3 = new OutputFormat("mp3");
        /// <summary>
        /// Constant Ogg_vorbis for OutputFormat
        /// </summary>
        public static readonly OutputFormat Ogg_vorbis = new OutputFormat("ogg_vorbis");
        /// <summary>
        /// Constant Pcm for OutputFormat
        /// </summary>
        public static readonly OutputFormat Pcm = new OutputFormat("pcm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpeechMarkType.
    /// </summary>
    public class SpeechMarkType : ConstantClass
    {

        /// <summary>
        /// Constant Sentence for SpeechMarkType
        /// </summary>
        public static readonly SpeechMarkType Sentence = new SpeechMarkType("sentence");
        /// <summary>
        /// Constant Ssml for SpeechMarkType
        /// </summary>
        public static readonly SpeechMarkType Ssml = new SpeechMarkType("ssml");
        /// <summary>
        /// Constant Viseme for SpeechMarkType
        /// </summary>
        public static readonly SpeechMarkType Viseme = new SpeechMarkType("viseme");
        /// <summary>
        /// Constant Word for SpeechMarkType
        /// </summary>
        public static readonly SpeechMarkType Word = new SpeechMarkType("word");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpeechMarkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpeechMarkType FindValue(string value)
        {
            return FindValue<SpeechMarkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpeechMarkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Completed = new TaskStatus("completed");
        /// <summary>
        /// Constant Failed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Failed = new TaskStatus("failed");
        /// <summary>
        /// Constant InProgress for TaskStatus
        /// </summary>
        public static readonly TaskStatus InProgress = new TaskStatus("inProgress");
        /// <summary>
        /// Constant Scheduled for TaskStatus
        /// </summary>
        public static readonly TaskStatus Scheduled = new TaskStatus("scheduled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextType.
    /// </summary>
    public class TextType : ConstantClass
    {

        /// <summary>
        /// Constant Ssml for TextType
        /// </summary>
        public static readonly TextType Ssml = new TextType("ssml");
        /// <summary>
        /// Constant Text for TextType
        /// </summary>
        public static readonly TextType Text = new TextType("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextType FindValue(string value)
        {
            return FindValue<TextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceId.
    /// </summary>
    public class VoiceId : ConstantClass
    {

        /// <summary>
        /// Constant Aditi for VoiceId
        /// </summary>
        public static readonly VoiceId Aditi = new VoiceId("Aditi");
        /// <summary>
        /// Constant Adriano for VoiceId
        /// </summary>
        public static readonly VoiceId Adriano = new VoiceId("Adriano");
        /// <summary>
        /// Constant Amy for VoiceId
        /// </summary>
        public static readonly VoiceId Amy = new VoiceId("Amy");
        /// <summary>
        /// Constant Andres for VoiceId
        /// </summary>
        public static readonly VoiceId Andres = new VoiceId("Andres");
        /// <summary>
        /// Constant Aria for VoiceId
        /// </summary>
        public static readonly VoiceId Aria = new VoiceId("Aria");
        /// <summary>
        /// Constant Arlet for VoiceId
        /// </summary>
        public static readonly VoiceId Arlet = new VoiceId("Arlet");
        /// <summary>
        /// Constant Arthur for VoiceId
        /// </summary>
        public static readonly VoiceId Arthur = new VoiceId("Arthur");
        /// <summary>
        /// Constant Astrid for VoiceId
        /// </summary>
        public static readonly VoiceId Astrid = new VoiceId("Astrid");
        /// <summary>
        /// Constant Ayanda for VoiceId
        /// </summary>
        public static readonly VoiceId Ayanda = new VoiceId("Ayanda");
        /// <summary>
        /// Constant Bianca for VoiceId
        /// </summary>
        public static readonly VoiceId Bianca = new VoiceId("Bianca");
        /// <summary>
        /// Constant Brian for VoiceId
        /// </summary>
        public static readonly VoiceId Brian = new VoiceId("Brian");
        /// <summary>
        /// Constant Camila for VoiceId
        /// </summary>
        public static readonly VoiceId Camila = new VoiceId("Camila");
        /// <summary>
        /// Constant Carla for VoiceId
        /// </summary>
        public static readonly VoiceId Carla = new VoiceId("Carla");
        /// <summary>
        /// Constant Carmen for VoiceId
        /// </summary>
        public static readonly VoiceId Carmen = new VoiceId("Carmen");
        /// <summary>
        /// Constant Celine for VoiceId
        /// </summary>
        public static readonly VoiceId Celine = new VoiceId("Celine");
        /// <summary>
        /// Constant Chantal for VoiceId
        /// </summary>
        public static readonly VoiceId Chantal = new VoiceId("Chantal");
        /// <summary>
        /// Constant Conchita for VoiceId
        /// </summary>
        public static readonly VoiceId Conchita = new VoiceId("Conchita");
        /// <summary>
        /// Constant Cristiano for VoiceId
        /// </summary>
        public static readonly VoiceId Cristiano = new VoiceId("Cristiano");
        /// <summary>
        /// Constant Daniel for VoiceId
        /// </summary>
        public static readonly VoiceId Daniel = new VoiceId("Daniel");
        /// <summary>
        /// Constant Dora for VoiceId
        /// </summary>
        public static readonly VoiceId Dora = new VoiceId("Dora");
        /// <summary>
        /// Constant Elin for VoiceId
        /// </summary>
        public static readonly VoiceId Elin = new VoiceId("Elin");
        /// <summary>
        /// Constant Emma for VoiceId
        /// </summary>
        public static readonly VoiceId Emma = new VoiceId("Emma");
        /// <summary>
        /// Constant Enrique for VoiceId
        /// </summary>
        public static readonly VoiceId Enrique = new VoiceId("Enrique");
        /// <summary>
        /// Constant Ewa for VoiceId
        /// </summary>
        public static readonly VoiceId Ewa = new VoiceId("Ewa");
        /// <summary>
        /// Constant Filiz for VoiceId
        /// </summary>
        public static readonly VoiceId Filiz = new VoiceId("Filiz");
        /// <summary>
        /// Constant Gabrielle for VoiceId
        /// </summary>
        public static readonly VoiceId Gabrielle = new VoiceId("Gabrielle");
        /// <summary>
        /// Constant Geraint for VoiceId
        /// </summary>
        public static readonly VoiceId Geraint = new VoiceId("Geraint");
        /// <summary>
        /// Constant Giorgio for VoiceId
        /// </summary>
        public static readonly VoiceId Giorgio = new VoiceId("Giorgio");
        /// <summary>
        /// Constant Gwyneth for VoiceId
        /// </summary>
        public static readonly VoiceId Gwyneth = new VoiceId("Gwyneth");
        /// <summary>
        /// Constant Hala for VoiceId
        /// </summary>
        public static readonly VoiceId Hala = new VoiceId("Hala");
        /// <summary>
        /// Constant Hannah for VoiceId
        /// </summary>
        public static readonly VoiceId Hannah = new VoiceId("Hannah");
        /// <summary>
        /// Constant Hans for VoiceId
        /// </summary>
        public static readonly VoiceId Hans = new VoiceId("Hans");
        /// <summary>
        /// Constant Hiujin for VoiceId
        /// </summary>
        public static readonly VoiceId Hiujin = new VoiceId("Hiujin");
        /// <summary>
        /// Constant Ida for VoiceId
        /// </summary>
        public static readonly VoiceId Ida = new VoiceId("Ida");
        /// <summary>
        /// Constant Ines for VoiceId
        /// </summary>
        public static readonly VoiceId Ines = new VoiceId("Ines");
        /// <summary>
        /// Constant Ivy for VoiceId
        /// </summary>
        public static readonly VoiceId Ivy = new VoiceId("Ivy");
        /// <summary>
        /// Constant Jacek for VoiceId
        /// </summary>
        public static readonly VoiceId Jacek = new VoiceId("Jacek");
        /// <summary>
        /// Constant Jan for VoiceId
        /// </summary>
        public static readonly VoiceId Jan = new VoiceId("Jan");
        /// <summary>
        /// Constant Joanna for VoiceId
        /// </summary>
        public static readonly VoiceId Joanna = new VoiceId("Joanna");
        /// <summary>
        /// Constant Joey for VoiceId
        /// </summary>
        public static readonly VoiceId Joey = new VoiceId("Joey");
        /// <summary>
        /// Constant Justin for VoiceId
        /// </summary>
        public static readonly VoiceId Justin = new VoiceId("Justin");
        /// <summary>
        /// Constant Kajal for VoiceId
        /// </summary>
        public static readonly VoiceId Kajal = new VoiceId("Kajal");
        /// <summary>
        /// Constant Karl for VoiceId
        /// </summary>
        public static readonly VoiceId Karl = new VoiceId("Karl");
        /// <summary>
        /// Constant Kazuha for VoiceId
        /// </summary>
        public static readonly VoiceId Kazuha = new VoiceId("Kazuha");
        /// <summary>
        /// Constant Kendra for VoiceId
        /// </summary>
        public static readonly VoiceId Kendra = new VoiceId("Kendra");
        /// <summary>
        /// Constant Kevin for VoiceId
        /// </summary>
        public static readonly VoiceId Kevin = new VoiceId("Kevin");
        /// <summary>
        /// Constant Kimberly for VoiceId
        /// </summary>
        public static readonly VoiceId Kimberly = new VoiceId("Kimberly");
        /// <summary>
        /// Constant Laura for VoiceId
        /// </summary>
        public static readonly VoiceId Laura = new VoiceId("Laura");
        /// <summary>
        /// Constant Lea for VoiceId
        /// </summary>
        public static readonly VoiceId Lea = new VoiceId("Lea");
        /// <summary>
        /// Constant Liam for VoiceId
        /// </summary>
        public static readonly VoiceId Liam = new VoiceId("Liam");
        /// <summary>
        /// Constant Liv for VoiceId
        /// </summary>
        public static readonly VoiceId Liv = new VoiceId("Liv");
        /// <summary>
        /// Constant Lotte for VoiceId
        /// </summary>
        public static readonly VoiceId Lotte = new VoiceId("Lotte");
        /// <summary>
        /// Constant Lucia for VoiceId
        /// </summary>
        public static readonly VoiceId Lucia = new VoiceId("Lucia");
        /// <summary>
        /// Constant Lupe for VoiceId
        /// </summary>
        public static readonly VoiceId Lupe = new VoiceId("Lupe");
        /// <summary>
        /// Constant Mads for VoiceId
        /// </summary>
        public static readonly VoiceId Mads = new VoiceId("Mads");
        /// <summary>
        /// Constant Maja for VoiceId
        /// </summary>
        public static readonly VoiceId Maja = new VoiceId("Maja");
        /// <summary>
        /// Constant Marlene for VoiceId
        /// </summary>
        public static readonly VoiceId Marlene = new VoiceId("Marlene");
        /// <summary>
        /// Constant Mathieu for VoiceId
        /// </summary>
        public static readonly VoiceId Mathieu = new VoiceId("Mathieu");
        /// <summary>
        /// Constant Matthew for VoiceId
        /// </summary>
        public static readonly VoiceId Matthew = new VoiceId("Matthew");
        /// <summary>
        /// Constant Maxim for VoiceId
        /// </summary>
        public static readonly VoiceId Maxim = new VoiceId("Maxim");
        /// <summary>
        /// Constant Mia for VoiceId
        /// </summary>
        public static readonly VoiceId Mia = new VoiceId("Mia");
        /// <summary>
        /// Constant Miguel for VoiceId
        /// </summary>
        public static readonly VoiceId Miguel = new VoiceId("Miguel");
        /// <summary>
        /// Constant Mizuki for VoiceId
        /// </summary>
        public static readonly VoiceId Mizuki = new VoiceId("Mizuki");
        /// <summary>
        /// Constant Naja for VoiceId
        /// </summary>
        public static readonly VoiceId Naja = new VoiceId("Naja");
        /// <summary>
        /// Constant Nicole for VoiceId
        /// </summary>
        public static readonly VoiceId Nicole = new VoiceId("Nicole");
        /// <summary>
        /// Constant Ola for VoiceId
        /// </summary>
        public static readonly VoiceId Ola = new VoiceId("Ola");
        /// <summary>
        /// Constant Olivia for VoiceId
        /// </summary>
        public static readonly VoiceId Olivia = new VoiceId("Olivia");
        /// <summary>
        /// Constant Pedro for VoiceId
        /// </summary>
        public static readonly VoiceId Pedro = new VoiceId("Pedro");
        /// <summary>
        /// Constant Penelope for VoiceId
        /// </summary>
        public static readonly VoiceId Penelope = new VoiceId("Penelope");
        /// <summary>
        /// Constant Raveena for VoiceId
        /// </summary>
        public static readonly VoiceId Raveena = new VoiceId("Raveena");
        /// <summary>
        /// Constant Remi for VoiceId
        /// </summary>
        public static readonly VoiceId Remi = new VoiceId("Remi");
        /// <summary>
        /// Constant Ricardo for VoiceId
        /// </summary>
        public static readonly VoiceId Ricardo = new VoiceId("Ricardo");
        /// <summary>
        /// Constant Ruben for VoiceId
        /// </summary>
        public static readonly VoiceId Ruben = new VoiceId("Ruben");
        /// <summary>
        /// Constant Russell for VoiceId
        /// </summary>
        public static readonly VoiceId Russell = new VoiceId("Russell");
        /// <summary>
        /// Constant Ruth for VoiceId
        /// </summary>
        public static readonly VoiceId Ruth = new VoiceId("Ruth");
        /// <summary>
        /// Constant Salli for VoiceId
        /// </summary>
        public static readonly VoiceId Salli = new VoiceId("Salli");
        /// <summary>
        /// Constant Seoyeon for VoiceId
        /// </summary>
        public static readonly VoiceId Seoyeon = new VoiceId("Seoyeon");
        /// <summary>
        /// Constant Sergio for VoiceId
        /// </summary>
        public static readonly VoiceId Sergio = new VoiceId("Sergio");
        /// <summary>
        /// Constant Stephen for VoiceId
        /// </summary>
        public static readonly VoiceId Stephen = new VoiceId("Stephen");
        /// <summary>
        /// Constant Suvi for VoiceId
        /// </summary>
        public static readonly VoiceId Suvi = new VoiceId("Suvi");
        /// <summary>
        /// Constant Takumi for VoiceId
        /// </summary>
        public static readonly VoiceId Takumi = new VoiceId("Takumi");
        /// <summary>
        /// Constant Tatyana for VoiceId
        /// </summary>
        public static readonly VoiceId Tatyana = new VoiceId("Tatyana");
        /// <summary>
        /// Constant Thiago for VoiceId
        /// </summary>
        public static readonly VoiceId Thiago = new VoiceId("Thiago");
        /// <summary>
        /// Constant Tomoko for VoiceId
        /// </summary>
        public static readonly VoiceId Tomoko = new VoiceId("Tomoko");
        /// <summary>
        /// Constant Vicki for VoiceId
        /// </summary>
        public static readonly VoiceId Vicki = new VoiceId("Vicki");
        /// <summary>
        /// Constant Vitoria for VoiceId
        /// </summary>
        public static readonly VoiceId Vitoria = new VoiceId("Vitoria");
        /// <summary>
        /// Constant Zeina for VoiceId
        /// </summary>
        public static readonly VoiceId Zeina = new VoiceId("Zeina");
        /// <summary>
        /// Constant Zhiyu for VoiceId
        /// </summary>
        public static readonly VoiceId Zhiyu = new VoiceId("Zhiyu");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceId FindValue(string value)
        {
            return FindValue<VoiceId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceId(string value)
        {
            return FindValue(value);
        }
    }

}