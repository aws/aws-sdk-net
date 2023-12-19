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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ChimeSDKMeetings
{

    /// <summary>
    /// Constants used for properties of type ContentResolution.
    /// </summary>
    public class ContentResolution : ConstantClass
    {

        /// <summary>
        /// Constant FHD for ContentResolution
        /// </summary>
        public static readonly ContentResolution FHD = new ContentResolution("FHD");
        /// <summary>
        /// Constant None for ContentResolution
        /// </summary>
        public static readonly ContentResolution None = new ContentResolution("None");
        /// <summary>
        /// Constant UHD for ContentResolution
        /// </summary>
        public static readonly ContentResolution UHD = new ContentResolution("UHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentResolution FindValue(string value)
        {
            return FindValue<ContentResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaCapabilities.
    /// </summary>
    public class MediaCapabilities : ConstantClass
    {

        /// <summary>
        /// Constant None for MediaCapabilities
        /// </summary>
        public static readonly MediaCapabilities None = new MediaCapabilities("None");
        /// <summary>
        /// Constant Receive for MediaCapabilities
        /// </summary>
        public static readonly MediaCapabilities Receive = new MediaCapabilities("Receive");
        /// <summary>
        /// Constant Send for MediaCapabilities
        /// </summary>
        public static readonly MediaCapabilities Send = new MediaCapabilities("Send");
        /// <summary>
        /// Constant SendReceive for MediaCapabilities
        /// </summary>
        public static readonly MediaCapabilities SendReceive = new MediaCapabilities("SendReceive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaCapabilities(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaCapabilities FindValue(string value)
        {
            return FindValue<MediaCapabilities>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaCapabilities(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MeetingFeatureStatus.
    /// </summary>
    public class MeetingFeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for MeetingFeatureStatus
        /// </summary>
        public static readonly MeetingFeatureStatus AVAILABLE = new MeetingFeatureStatus("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for MeetingFeatureStatus
        /// </summary>
        public static readonly MeetingFeatureStatus UNAVAILABLE = new MeetingFeatureStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeetingFeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeetingFeatureStatus FindValue(string value)
        {
            return FindValue<MeetingFeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeetingFeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeContentIdentificationType.
    /// </summary>
    public class TranscribeContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PII for TranscribeContentIdentificationType
        /// </summary>
        public static readonly TranscribeContentIdentificationType PII = new TranscribeContentIdentificationType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeContentIdentificationType FindValue(string value)
        {
            return FindValue<TranscribeContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeContentRedactionType.
    /// </summary>
    public class TranscribeContentRedactionType : ConstantClass
    {

        /// <summary>
        /// Constant PII for TranscribeContentRedactionType
        /// </summary>
        public static readonly TranscribeContentRedactionType PII = new TranscribeContentRedactionType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeContentRedactionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeContentRedactionType FindValue(string value)
        {
            return FindValue<TranscribeContentRedactionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeContentRedactionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeLanguageCode.
    /// </summary>
    public class TranscribeLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode DeDE = new TranscribeLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnAU = new TranscribeLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnGB = new TranscribeLanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnUS = new TranscribeLanguageCode("en-US");
        /// <summary>
        /// Constant EsUS for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EsUS = new TranscribeLanguageCode("es-US");
        /// <summary>
        /// Constant FrCA for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode FrCA = new TranscribeLanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode FrFR = new TranscribeLanguageCode("fr-FR");
        /// <summary>
        /// Constant HiIN for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode HiIN = new TranscribeLanguageCode("hi-IN");
        /// <summary>
        /// Constant ItIT for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ItIT = new TranscribeLanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode JaJP = new TranscribeLanguageCode("ja-JP");
        /// <summary>
        /// Constant KoKR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode KoKR = new TranscribeLanguageCode("ko-KR");
        /// <summary>
        /// Constant PtBR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode PtBR = new TranscribeLanguageCode("pt-BR");
        /// <summary>
        /// Constant ThTH for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ThTH = new TranscribeLanguageCode("th-TH");
        /// <summary>
        /// Constant ZhCN for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ZhCN = new TranscribeLanguageCode("zh-CN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeLanguageCode FindValue(string value)
        {
            return FindValue<TranscribeLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalContentIdentificationType.
    /// </summary>
    public class TranscribeMedicalContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PHI for TranscribeMedicalContentIdentificationType
        /// </summary>
        public static readonly TranscribeMedicalContentIdentificationType PHI = new TranscribeMedicalContentIdentificationType("PHI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalContentIdentificationType FindValue(string value)
        {
            return FindValue<TranscribeMedicalContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalLanguageCode.
    /// </summary>
    public class TranscribeMedicalLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for TranscribeMedicalLanguageCode
        /// </summary>
        public static readonly TranscribeMedicalLanguageCode EnUS = new TranscribeMedicalLanguageCode("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalLanguageCode FindValue(string value)
        {
            return FindValue<TranscribeMedicalLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalRegion.
    /// </summary>
    public class TranscribeMedicalRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApSoutheast2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion ApSoutheast2 = new TranscribeMedicalRegion("ap-southeast-2");
        /// <summary>
        /// Constant Auto for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion Auto = new TranscribeMedicalRegion("auto");
        /// <summary>
        /// Constant CaCentral1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion CaCentral1 = new TranscribeMedicalRegion("ca-central-1");
        /// <summary>
        /// Constant EuWest1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion EuWest1 = new TranscribeMedicalRegion("eu-west-1");
        /// <summary>
        /// Constant UsEast1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsEast1 = new TranscribeMedicalRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsEast2 = new TranscribeMedicalRegion("us-east-2");
        /// <summary>
        /// Constant UsWest2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsWest2 = new TranscribeMedicalRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalRegion FindValue(string value)
        {
            return FindValue<TranscribeMedicalRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalSpecialty.
    /// </summary>
    public class TranscribeMedicalSpecialty : ConstantClass
    {

        /// <summary>
        /// Constant CARDIOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty CARDIOLOGY = new TranscribeMedicalSpecialty("CARDIOLOGY");
        /// <summary>
        /// Constant NEUROLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty NEUROLOGY = new TranscribeMedicalSpecialty("NEUROLOGY");
        /// <summary>
        /// Constant ONCOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty ONCOLOGY = new TranscribeMedicalSpecialty("ONCOLOGY");
        /// <summary>
        /// Constant PRIMARYCARE for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty PRIMARYCARE = new TranscribeMedicalSpecialty("PRIMARYCARE");
        /// <summary>
        /// Constant RADIOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty RADIOLOGY = new TranscribeMedicalSpecialty("RADIOLOGY");
        /// <summary>
        /// Constant UROLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty UROLOGY = new TranscribeMedicalSpecialty("UROLOGY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalSpecialty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalSpecialty FindValue(string value)
        {
            return FindValue<TranscribeMedicalSpecialty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalSpecialty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalType.
    /// </summary>
    public class TranscribeMedicalType : ConstantClass
    {

        /// <summary>
        /// Constant CONVERSATION for TranscribeMedicalType
        /// </summary>
        public static readonly TranscribeMedicalType CONVERSATION = new TranscribeMedicalType("CONVERSATION");
        /// <summary>
        /// Constant DICTATION for TranscribeMedicalType
        /// </summary>
        public static readonly TranscribeMedicalType DICTATION = new TranscribeMedicalType("DICTATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalType FindValue(string value)
        {
            return FindValue<TranscribeMedicalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribePartialResultsStability.
    /// </summary>
    public class TranscribePartialResultsStability : ConstantClass
    {

        /// <summary>
        /// Constant High for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability High = new TranscribePartialResultsStability("high");
        /// <summary>
        /// Constant Low for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability Low = new TranscribePartialResultsStability("low");
        /// <summary>
        /// Constant Medium for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability Medium = new TranscribePartialResultsStability("medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribePartialResultsStability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribePartialResultsStability FindValue(string value)
        {
            return FindValue<TranscribePartialResultsStability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribePartialResultsStability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeRegion.
    /// </summary>
    public class TranscribeRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApNortheast1 = new TranscribeRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApNortheast2 = new TranscribeRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSoutheast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApSoutheast2 = new TranscribeRegion("ap-southeast-2");
        /// <summary>
        /// Constant Auto for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion Auto = new TranscribeRegion("auto");
        /// <summary>
        /// Constant CaCentral1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion CaCentral1 = new TranscribeRegion("ca-central-1");
        /// <summary>
        /// Constant EuCentral1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuCentral1 = new TranscribeRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuWest1 = new TranscribeRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuWest2 = new TranscribeRegion("eu-west-2");
        /// <summary>
        /// Constant SaEast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion SaEast1 = new TranscribeRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsEast1 = new TranscribeRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsEast2 = new TranscribeRegion("us-east-2");
        /// <summary>
        /// Constant UsGovWest1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsGovWest1 = new TranscribeRegion("us-gov-west-1");
        /// <summary>
        /// Constant UsWest2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsWest2 = new TranscribeRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeRegion FindValue(string value)
        {
            return FindValue<TranscribeRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeVocabularyFilterMethod.
    /// </summary>
    public class TranscribeVocabularyFilterMethod : ConstantClass
    {

        /// <summary>
        /// Constant Mask for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Mask = new TranscribeVocabularyFilterMethod("mask");
        /// <summary>
        /// Constant Remove for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Remove = new TranscribeVocabularyFilterMethod("remove");
        /// <summary>
        /// Constant Tag for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Tag = new TranscribeVocabularyFilterMethod("tag");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeVocabularyFilterMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeVocabularyFilterMethod FindValue(string value)
        {
            return FindValue<TranscribeVocabularyFilterMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeVocabularyFilterMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoResolution.
    /// </summary>
    public class VideoResolution : ConstantClass
    {

        /// <summary>
        /// Constant FHD for VideoResolution
        /// </summary>
        public static readonly VideoResolution FHD = new VideoResolution("FHD");
        /// <summary>
        /// Constant HD for VideoResolution
        /// </summary>
        public static readonly VideoResolution HD = new VideoResolution("HD");
        /// <summary>
        /// Constant None for VideoResolution
        /// </summary>
        public static readonly VideoResolution None = new VideoResolution("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoResolution FindValue(string value)
        {
            return FindValue<VideoResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoResolution(string value)
        {
            return FindValue(value);
        }
    }

}